namespace TokenBusApp
{
    partial class NewMessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.rbHostname = new System.Windows.Forms.RadioButton();
            this.rbIPAddress = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbDest = new System.Windows.Forms.GroupBox();
            this.rbBroadcast = new System.Windows.Forms.RadioButton();
            this.rbUnicast = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbRetransmissions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbDest.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHostname
            // 
            this.txtHostname.Enabled = false;
            this.txtHostname.Location = new System.Drawing.Point(99, 49);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(113, 20);
            this.txtHostname.TabIndex = 3;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(99, 19);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(113, 20);
            this.txtIPAddress.TabIndex = 2;
            // 
            // rbHostname
            // 
            this.rbHostname.AutoSize = true;
            this.rbHostname.Location = new System.Drawing.Point(6, 45);
            this.rbHostname.Name = "rbHostname";
            this.rbHostname.Size = new System.Drawing.Size(76, 17);
            this.rbHostname.TabIndex = 1;
            this.rbHostname.Text = "Hostname:";
            this.rbHostname.UseVisualStyleBackColor = true;
            this.rbHostname.CheckedChanged += new System.EventHandler(this.rbHostname_CheckedChanged);
            // 
            // rbIPAddress
            // 
            this.rbIPAddress.AutoSize = true;
            this.rbIPAddress.Checked = true;
            this.rbIPAddress.Location = new System.Drawing.Point(6, 25);
            this.rbIPAddress.Name = "rbIPAddress";
            this.rbIPAddress.Size = new System.Drawing.Size(87, 17);
            this.rbIPAddress.TabIndex = 0;
            this.rbIPAddress.TabStop = true;
            this.rbIPAddress.Text = "Endereço IP:";
            this.rbIPAddress.UseVisualStyleBackColor = true;
            this.rbIPAddress.CheckedChanged += new System.EventHandler(this.rbIPAddress_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gbDest);
            this.groupBox1.Controls.Add(this.rbBroadcast);
            this.groupBox1.Controls.Add(this.rbUnicast);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de transmissão";
            // 
            // gbDest
            // 
            this.gbDest.Controls.Add(this.rbIPAddress);
            this.gbDest.Controls.Add(this.txtHostname);
            this.gbDest.Controls.Add(this.rbHostname);
            this.gbDest.Controls.Add(this.txtIPAddress);
            this.gbDest.Location = new System.Drawing.Point(30, 42);
            this.gbDest.Name = "gbDest";
            this.gbDest.Size = new System.Drawing.Size(228, 75);
            this.gbDest.TabIndex = 4;
            this.gbDest.TabStop = false;
            this.gbDest.Text = "Destinatário";
            // 
            // rbBroadcast
            // 
            this.rbBroadcast.AutoSize = true;
            this.rbBroadcast.Location = new System.Drawing.Point(6, 123);
            this.rbBroadcast.Name = "rbBroadcast";
            this.rbBroadcast.Size = new System.Drawing.Size(73, 17);
            this.rbBroadcast.TabIndex = 1;
            this.rbBroadcast.Text = "Broadcast";
            this.rbBroadcast.UseVisualStyleBackColor = true;
            // 
            // rbUnicast
            // 
            this.rbUnicast.AutoSize = true;
            this.rbUnicast.Checked = true;
            this.rbUnicast.Location = new System.Drawing.Point(6, 19);
            this.rbUnicast.Name = "rbUnicast";
            this.rbUnicast.Size = new System.Drawing.Size(61, 17);
            this.rbUnicast.TabIndex = 0;
            this.rbUnicast.TabStop = true;
            this.rbUnicast.Text = "Unicast";
            this.rbUnicast.UseVisualStyleBackColor = true;
            this.rbUnicast.CheckedChanged += new System.EventHandler(this.rbUnicast_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbRetransmissions);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 126);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mensagem";
            // 
            // cbRetransmissions
            // 
            this.cbRetransmissions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRetransmissions.FormattingEnabled = true;
            this.cbRetransmissions.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbRetransmissions.Location = new System.Drawing.Point(118, 45);
            this.cbRetransmissions.Name = "cbRetransmissions";
            this.cbRetransmissions.Size = new System.Drawing.Size(44, 21);
            this.cbRetransmissions.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Retransmissões:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 87);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(152, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Inserir erros aleatoriamente";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(118, 19);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(179, 20);
            this.txtData.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(250, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(169, 300);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // NewMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 334);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewMessageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova Mensagem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDest.ResumeLayout(false);
            this.gbDest.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.RadioButton rbHostname;
        private System.Windows.Forms.RadioButton rbIPAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBroadcast;
        private System.Windows.Forms.RadioButton rbUnicast;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbRetransmissions;
        private System.Windows.Forms.GroupBox gbDest;
    }
}