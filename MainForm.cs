using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TokenBusApp
{
    public partial class MainForm : Form
    {
		private NewMessageForm m_oMessageForm = new NewMessageForm();
		private Protocol m_oProtocol;

		// This delegate enables asynchronous calls for setting checkbox value
		delegate void SetCheckBoxCallback(object sender, MessageReceivedEventArgs args);

		public MainForm()
		{
			InitializeComponent();
			this.m_oMessageForm.MessageAdded += new NewMessageForm.MessageAddedEventHandler(this.MessageHasBeenAdded);
			this.txtOrigin.Text = System.Net.IPAddress.Any.ToString();
		}

		void MessageHasBeenAdded(object sender, MessageAddedEventArgs args)
		{
			this.lbMessages.Items.Add(args.Msg);
			this.btnStart.Enabled = true;
		}

		public void Run()
		{
			try
			{
				this.m_oProtocol = new Protocol(
						 this.txtOrigin.Text,
						 this.txtDest.Text);

				this.m_oProtocol.TokenReceived += new Protocol.MessageReceivedEventHandler(this.SendNextMessage);
				this.m_oProtocol.DataReceived += new Protocol.MessageReceivedEventHandler(this.DataReceived);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				this.Stop();
			}
		}

		void DataReceived(object sender, MessageReceivedEventArgs args)
		{
			if (this.checkboxData.InvokeRequired)
			{
				SetCheckBoxCallback callback = new SetCheckBoxCallback(DataReceived);
				this.Invoke(callback, new object[] { sender, args } );
			}
			else
			{
				System.Threading.Thread.Sleep(1000);
				this.checkboxData.Checked = true;
				this.txtData.Text = args.Data;
				System.Threading.Thread.Sleep(1000);
				this.checkboxData.Checked = false;
			}
		}

		private void Stop()
		{
			this.btnStart.Enabled = true;
			this.btnStop.Enabled = false;
			this.txtDest.Enabled = true;
			this.txtOrigin.Enabled = true;
			this.btnGenToken.Enabled = false;

			this.m_oProtocol.TokenReceived -= new Protocol.MessageReceivedEventHandler(this.SendNextMessage);
			this.m_oProtocol.DataReceived -= new Protocol.MessageReceivedEventHandler(this.DataReceived);
			this.m_oProtocol = null;
		}

		void SendNextMessage(object sender, MessageReceivedEventArgs args)
		{
			// the token has been received.. dequeue the first message
			Packet l_oPacket = (Packet)this.lbMessages.Items[0];

			this.m_oProtocol.SendMessage(
				l_oPacket);

			// TODO: only remove the message if it has been successfully delivered
			this.lbMessages.Items.RemoveAt(0);
		}

		private void btnManage_Click(object sender, EventArgs e)
		{
			this.m_oMessageForm.ShowDialog(this);
		}

		private void lbMessages_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.btnStart.Enabled = (this.lbMessages.Items.Count > 0);
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			this.btnStart.Enabled = false;
			this.btnStop.Enabled = true;
			this.txtDest.Enabled = false;
			this.txtOrigin.Enabled = false;
			this.btnGenToken.Enabled = true;
			this.Run();
		}

		private void btnGenToken_Click(object sender, EventArgs e)
		{
			this.m_oProtocol.GenerateToken();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			this.Stop();
		}

		 private void txtOrigin_TextChanged(object sender, EventArgs e)
		 {
			 this.btnStart.Enabled =
				 ((!this.txtOrigin.Text.Equals(String.Empty) && !this.txtDest.Text.Equals(String.Empty)));
		 }

		 private void txtDest_TextChanged(object sender, EventArgs e)
		 {
			 this.btnStart.Enabled = 
				 ((!this.txtOrigin.Text.Equals(String.Empty) && !this.txtDest.Text.Equals(String.Empty)));
		 }
    }
}