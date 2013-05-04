using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TokenBusApp
{
    /// <summary>
    /// Implements a TokenBus net protocol
    /// </summary>
	class Protocol
	{
		private Socket m_oIncomingDataSocket;
        private Socket m_oOutgoingDataSocket;

		private IPEndPoint m_ipIncomingHost;
		private IPEndPoint m_ipOutgoingHost;

		private Token m_oToken;

		public static readonly uint PortNumber = 10000;
		public static readonly uint ERROR_CONNECTION_RESET = 10054;

		public delegate void MessageReceivedEventHandler(object sender, MessageReceivedEventArgs args);
		public event MessageReceivedEventHandler TokenReceived;	// event declaration for token received
		public event MessageReceivedEventHandler DataReceived;	// event declaration for data package received

		/// <summary>
		/// Default TokenBus protocol constructor
		/// </summary>
		/// <param name="_sIPOrigin">The IPAddress of previous host on the network</param>
		/// <param name="_sIPDest">The IPAddress of next host on the network</param>
		public Protocol(
            string _sIPOrigin,
            string _sIPDest)
		{
			Debugger.Log(0, "1", "\nProtocol::Protocol(): Entering...");

			this.m_ipIncomingHost = new IPEndPoint(
				IPAddress.Parse(_sIPOrigin),
				(int)Protocol.PortNumber);

			this.m_ipOutgoingHost = new IPEndPoint(
				IPAddress.Parse(_sIPDest),
				(int)Protocol.PortNumber);

			this.m_oIncomingDataSocket = new Socket(
				AddressFamily.InterNetwork,
				SocketType.Dgram,
				ProtocolType.Udp);
			
			this.m_oOutgoingDataSocket = new Socket(
				AddressFamily.InterNetwork,
				SocketType.Dgram,
				ProtocolType.Udp);

			this.m_oIncomingDataSocket.Bind(this.m_ipIncomingHost);
			this.m_oOutgoingDataSocket.Bind(this.m_ipOutgoingHost);

			this.WaitForData();

			Debugger.Log(0, "1", "\nProtocol::Protocol(): Exiting...");
		}

		~Protocol()
		{
			if (this.m_oIncomingDataSocket != null)
			{
				this.m_oIncomingDataSocket.Close();
			}
			if (this.m_oOutgoingDataSocket != null)
			{
				this.m_oOutgoingDataSocket.Close();
			}
		}

		/// <summary>
		/// This is the method which will run a thread
		/// forever listening for incoming data
		/// </summary>
		private void WaitForData()
		{
			try
			{
				Debugger.Log(0, "1", "\nProtocol::WaitForData(): Entering...");

				SocketPacket l_socketPacket = new SocketPacket(this.m_oIncomingDataSocket);

				Debugger.Log(0, "1", "\nProtocol::WaitForData(): Attempting to Receive data.");

				EndPoint ep = Protocol.LocalEndPoint();
				
				// begins a connectionless asynchronous data transfer
				this.m_oIncomingDataSocket.BeginReceiveFrom(
					l_socketPacket.DataBuffer,
					0,
					SocketPacket.BUFFER_SIZE,
					0,
					ref ep,
					new AsyncCallback(OnDataReceived),
					l_socketPacket);
			}
			catch (SocketException se)
			{
				MessageBox.Show(se.Message);
			}
			finally
			{
				Debugger.Log(0, "1", "\nProtocol::WaitForData(): Exiting...");
			}
		}

		/// <summary>
		/// This is the call back function which will be invoked when the socket
		/// detects any client writing of data on the stream
		/// </summary>
		public void OnDataReceived(IAsyncResult asyn)
		{
			Debugger.Log(0, "1", "\nProtocol::OnDataReceived(): Entering...");

			try
			{
				Socket l_workerSocket = ((SocketPacket)asyn.AsyncState).CurrentSocket;

				EndPoint ep = Protocol.LocalEndPoint();
				int iRx = l_workerSocket.EndReceiveFrom(asyn, ref ep);

				byte[] l_btData = ((SocketPacket)asyn.AsyncState).DataBuffer;
				
				this.HandleReceivedData(l_btData);

				Debugger.Log(0, "1", "\nProtocol::OnDataReceived(): Data successfully received");			
				
				// Continue the waiting for data on the Socket
				this.WaitForData();
			}
			catch (ObjectDisposedException)
			{
				Debugger.Log(0, "1", "\nProtocol::nOnDataReceived(): Socket has been closed");
			}
			catch (SocketException se)
			{
				if (se.ErrorCode == ERROR_CONNECTION_RESET) //connection reset by peer
				{
					Debugger.Log(0, "1", "\nnProtocol::OnDataReceived(): Client Disconnected\n");
				}
				else
				{
					MessageBox.Show(se.Message);
				}
			}
			finally
			{
				Debugger.Log(0, "1", "\nProtocol::OnDataReceived(): Exiting...");
			}
		}

		private void HandleReceivedData(
			byte[] _bytes)
		{
			Message l_oMessage = (Message)ObjectByteArrayConverter.ByteArrayToObject(_bytes);

			if (l_oMessage is Token)
			{
				this.HandleReceivedToken((Token)l_oMessage);
			}
			else if (l_oMessage is Packet)
			{
				Packet l_oReceivedPckt = (Packet)l_oMessage;
				string l_sReceivedData = l_oReceivedPckt.Data.ToString();

				// check if we are the message's destination
				if (IPAddress.IsLoopback(l_oReceivedPckt.IPDestination))
				{
					this.HandleReceivedPacket(l_oReceivedPckt);
				}
				else
				{
					/*
					 * TODO: Simulate errors if asked
					 */
					
					// just forward the packet to the next host...
					this.ForwardMessage(l_oReceivedPckt);
				}
			}
		}

		private void HandleReceivedToken(Token _token)
		{
			this.m_oToken = _token;
			
			// notify subscribers
			if (this.TokenReceived != null)
			{
				// fire the token received event
				this.TokenReceived(
					this,
					new MessageReceivedEventArgs());
			}
		}

		private void HandleReceivedPacket(Packet l_oReceivedPckt)
		{
			if (l_oReceivedPckt.Status == PacketStatus.Ok)
			{
				// we're receiving an ack, the message has been successfuly sent
				// now, forward the token to the next host
				this.ForwardToken();
			}
			else if (l_oReceivedPckt.Status == PacketStatus.NotCopied)
			{
				// we have just received a message, now set its status as
				// received and forward it to the original sender
				l_oReceivedPckt.Status = PacketStatus.Ok;
				l_oReceivedPckt.IPDestination = l_oReceivedPckt.IPOrigin;
				l_oReceivedPckt.IPOrigin = IPAddress.Loopback;
				this.ForwardMessage(l_oReceivedPckt);

				// notify subscribers
				if (this.DataReceived != null)
				{
					// fire the data received event
					this.DataReceived(
						this,
						new MessageReceivedEventArgs(l_oReceivedPckt.Data.ToString()));
				}
			}
		}

		/// <summary>
		/// Sends the token to the next host in the network
		/// </summary>
		private void ForwardToken()
		{
			if (this.m_oToken != null)
			{
				this.ForwardMessage((Message)this.m_oToken);
				this.m_oToken = null;
			}
		}

		/// <summary>
		/// Sends a received message to the next host in the network
		/// This doesn't require a Token because the message is just
		/// being forwarded, instead of being generated by this host
		/// </summary>
		private void ForwardMessage(Message l_oPacket)
		{
			this.SendData(
				l_oPacket,
				this.m_oOutgoingDataSocket);
		}

		/// <summary>
		/// Sends data assynchronously through the provided socket
		/// </summary>
		private void SendData(
			Message _oPacket,
			Socket _socket)
		{
			try
			{
				SocketPacket l_oSockPacket = new SocketPacket(_socket);
				l_oSockPacket.DataBuffer = ObjectByteArrayConverter.ObjectToByteArray(_oPacket);

				_socket.BeginSendTo(
					l_oSockPacket.DataBuffer,
					0,
					SocketPacket.BUFFER_SIZE,
					SocketFlags.None,
					this.m_ipOutgoingHost,
					this.OnDataSent,
					l_oSockPacket);
			}
			catch (SocketException se)
			{
				MessageBox.Show(se.Message);
			}
		}

		/// <summary>
		/// This is the call back function which will be invoked when the socket
		/// detects that data has been sent to the client
		/// </summary>
		private void OnDataSent(IAsyncResult asyn)
		{
			Debugger.Log(0, "1", "\nProtocol::OnDataSent(): Entering...");

			try
			{
				Socket l_workerSocket = ((SocketPacket)asyn.AsyncState).CurrentSocket;

				int iRx = l_workerSocket.EndSendTo(asyn);

				Debugger.Log(0, "1", "\nProtocol::OnDataSent(): Data successfully sent");
			}
			catch (ObjectDisposedException)
			{
				Debugger.Log(0, "1", "\nProtocol::OnDataSent(): Socket has been closed");
			}
			catch (SocketException se)
			{
				if (se.ErrorCode == ERROR_CONNECTION_RESET) //connection reset by peer
				{
					Debugger.Log(0, "1", "\nnProtocol::OnDataSent(): Client Disconnected\n");
				}
				else
				{
					MessageBox.Show(se.Message);
				}
			}
			finally
			{
				Debugger.Log(0, "1", "\nProtocol::OnDataSent(): Exiting...");
			}
		}

		private static EndPoint LocalEndPoint()
		{
			IPEndPoint localhost = new IPEndPoint(IPAddress.Any, 0);
			return (EndPoint)localhost;
		}

		/// <summary>
		/// Adds mannually a token to this host. 
		/// May generate multiple tokens on the network.
		/// </summary>
		internal void GenerateToken()
		{
			this.m_oToken = new Token();

			this.HandleReceivedToken();
		}

		/// <summary>
		/// Sends a packet of data
		/// </summary>
		internal void SendMessage(Packet l_oPacket)
		{
			// check if we have permission to send messages
			if (this.m_oToken != null)
			{
				this.ForwardMessage(l_oPacket);
			}
		}
	}

	public class SocketPacket
	{
		public SocketPacket(Socket socket)
		{
			this.m_oCurrentSocket = socket;
		}

		public Socket CurrentSocket
		{
			get { return this.m_oCurrentSocket; }
		}
		private Socket m_oCurrentSocket;

		public byte[] DataBuffer
		{
			get { return this.m_btBuffer; }
			set { this.m_btBuffer = value; }
		}
		private byte[] m_btBuffer = new byte[BUFFER_SIZE];
		
		// Buffer to store the data sent by the client
		public static readonly int BUFFER_SIZE = 1024;
	}

	public class MessageReceivedEventArgs
	{
		public MessageReceivedEventArgs() { }

		public MessageReceivedEventArgs(string _data)
		{
			this.m_sData = _data;
		}

		public string Data
		{
			get { return this.m_sData; }
		}
		private string m_sData = null;
	}
}
