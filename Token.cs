using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TokenBusApp
{
    class Token : Message
    {
        public Token() : base()
        {
            this.m_bType = new Bit(0);
        }
    }
}
