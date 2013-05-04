using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace TokenBusApp
{
    public partial class NewMessageForm : Form
    {
        public delegate void MessageAddedEventHandler(object sender, MessageAddedEventArgs args);
        public event MessageAddedEventHandler MessageAdded;
        
        public NewMessageForm()
        {
            InitializeComponent();
            this.cbRetransmissions.SelectedIndex = 0;
        }

        private void rbIPAddress_CheckedChanged(object sender, EventArgs e)
        {
            this.txtIPAddress.Enabled = this.rbIPAddress.Checked;
        }

        private void rbHostname_CheckedChanged(object sender, EventArgs e)
        {
            this.txtHostname.Enabled = this.rbHostname.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            IPHostEntry l_ipDestination = null;

            if (this.txtData.Text == String.Empty)
            {
                MessageBox.Show("Dados da mensagem inválidos");
                return;
            }
            
            try
            {
                if (this.txtIPAddress.Enabled)
                {
                    l_ipDestination = Dns.GetHostEntry(IPAddress.Parse(this.txtIPAddress.Text));
                }
                else
                {
                    l_ipDestination = Dns.GetHostEntry(Dns.GetHostAddresses(this.txtHostname.Text)[0]);
                }
				if (l_ipDestination == null &&
					this.rbBroadcast.Checked) // broadcast
				{
					l_ipDestination = Dns.GetHostEntry(IPAddress.Broadcast);
				}
            }
            catch
            {
                MessageBox.Show("Destinatário inválido");
                return;
            }

            if (this.MessageAdded != null)
            {
                Packet p = new Packet(
                    this.txtData.Text,
                    l_ipDestination.AddressList[0]);

                // dispara o evento que insere uma mensagem na fila
                this.MessageAdded(this, new MessageAddedEventArgs(p));
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbUnicast_CheckedChanged(object sender, EventArgs e)
        {
            this.gbDest.Enabled = this.rbUnicast.Checked;
        }
    }

    public class MessageAddedEventArgs
    {
        public MessageAddedEventArgs(Packet _msg)
        {
            this.m_oMsg = _msg;
        }

        public Packet Msg
        {
            get { return this.m_oMsg; }
        }
        private Packet m_oMsg = null;
    }
}