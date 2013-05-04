using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TokenBusApp
{
    public class Message
    {
        public IPAddress IPDestination
        {
            get { return new IPAddress(m_btDestAddr); }
            set { this.m_btDestAddr = value.GetAddressBytes(); }
        }
        protected byte[] m_btDestAddr;

        public IPAddress IPOrigin
        {
            get { return new IPAddress(m_btOriginAddr); }
            set { this.m_btOriginAddr = value.GetAddressBytes(); }
        }
        protected byte[] m_btOriginAddr;

        private byte m_btStartFlag;
        private byte m_btEndFlag;

        protected Bit m_bType;

        protected Message()
        {
            this.m_btOriginAddr = new byte[4];
            this.m_btStartFlag = this.m_btEndFlag = 0x7E;   // 011111110
        }
    }
}
