using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TokenBusApp
{
    public class Packet : Message
    {
        public Data Data
        {
            get { return this.m_oData; }
            set { this.m_oData = value; }
        }
        private Data m_oData;         // 100 bytes

        public byte[] CRC
        {
            get { return this.m_bCRC; }
            set { this.m_bCRC = value; }
        }
        private byte[] m_bCRC;          // 4 bytes

		public PacketStatus Status
		{
			get { return this.m_szbtStatus; }
			set { this.m_szbtStatus = value; }
		}
		private PacketStatus m_szbtStatus;

        private Bit[] m_szbtSequence;

        public Packet() : base()
        {
            this.m_oData = new Data();
            this.m_bType = new Bit(1);
            this.m_szbtStatus = PacketStatus.NotCopied;
            this.m_szbtSequence = new Bit[4];
        }

        public Packet(
            string _sData,
            IPAddress _ipDestination) : this()
        {   
            // ip da máquina que está enviando o pacote
            this.m_btOriginAddr = Dns.GetHostAddresses(Dns.GetHostName())[0].GetAddressBytes();
            // ip da máquina destino
            this.m_btDestAddr = _ipDestination.GetAddressBytes();

			this.m_oData = new Data(_sData);
        }

		public Packet(
			string _sData) : this(_sData, null)
		{
		}

        public override string ToString()
        {
            return
                "Destino: " +
                this.IPDestination.ToString() +
                " Dados: " +
                this.Data;
        }
    }

	public enum PacketStatus
	{
		NotCopied,
		Error,
		Ok
	};
}
