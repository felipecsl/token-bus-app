namespace TokenBusApp
{
    partial class MainForm
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
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnManage = new System.Windows.Forms.Button();
			this.lbMessages = new System.Windows.Forms.ListBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txtData = new System.Windows.Forms.TextBox();
			this.lblOK = new System.Windows.Forms.Label();
			this.lblErro = new System.Windows.Forms.Label();
			this.lblNotCopied = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.rbNCopied = new System.Windows.Forms.RadioButton();
			this.rbOK = new System.Windows.Forms.RadioButton();
			this.rbError = new System.Windows.Forms.RadioButton();
			this.checkboxData = new System.Windows.Forms.CheckBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.btnGenToken = new System.Windows.Forms.Button();
			this.checkboxController = new System.Windows.Forms.CheckBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtDest = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtOrigin = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnStop = new System.Windows.Forms.Button();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnManage);
			this.groupBox4.Controls.Add(this.lbMessages);
			this.groupBox4.Location = new System.Drawing.Point(12, 85);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(214, 177);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Fila de mensagens";
			// 
			// btnManage
			// 
			this.btnManage.Location = new System.Drawing.Point(6, 146);
			this.btnManage.Name = "btnManage";
			this.btnManage.Size = new System.Drawing.Size(111, 23);
			this.btnManage.TabIndex = 1;
			this.btnManage.Text = "Nova mensagem...";
			this.btnManage.UseVisualStyleBackColor = true;
			this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
			// 
			// lbMessages
			// 
			this.lbMessages.FormattingEnabled = true;
			this.lbMessages.Location = new System.Drawing.Point(6, 19);
			this.lbMessages.Name = "lbMessages";
			this.lbMessages.Size = new System.Drawing.Size(202, 121);
			this.lbMessages.TabIndex = 0;
			this.lbMessages.SelectedIndexChanged += new System.EventHandler(this.lbMessages_SelectedIndexChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.txtData);
			this.groupBox5.Controls.Add(this.lblOK);
			this.groupBox5.Controls.Add(this.lblErro);
			this.groupBox5.Controls.Add(this.lblNotCopied);
			this.groupBox5.Controls.Add(this.label1);
			this.groupBox5.Controls.Add(this.rbNCopied);
			this.groupBox5.Controls.Add(this.rbOK);
			this.groupBox5.Controls.Add(this.rbError);
			this.groupBox5.Controls.Add(this.checkboxData);
			this.groupBox5.Location = new System.Drawing.Point(232, 12);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(144, 138);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Status";
			// 
			// txtData
			// 
			this.txtData.Enabled = false;
			this.txtData.Location = new System.Drawing.Point(9, 38);
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(124, 20);
			this.txtData.TabIndex = 11;
			// 
			// lblOK
			// 
			this.lblOK.AutoSize = true;
			this.lblOK.Location = new System.Drawing.Point(30, 119);
			this.lblOK.Name = "lblOK";
			this.lblOK.Size = new System.Drawing.Size(21, 13);
			this.lblOK.TabIndex = 10;
			this.lblOK.Text = "Ok";
			// 
			// lblErro
			// 
			this.lblErro.AutoSize = true;
			this.lblErro.Location = new System.Drawing.Point(30, 96);
			this.lblErro.Name = "lblErro";
			this.lblErro.Size = new System.Drawing.Size(26, 13);
			this.lblErro.TabIndex = 9;
			this.lblErro.Text = "Erro";
			// 
			// lblNotCopied
			// 
			this.lblNotCopied.AutoSize = true;
			this.lblNotCopied.Location = new System.Drawing.Point(30, 73);
			this.lblNotCopied.Name = "lblNotCopied";
			this.lblNotCopied.Size = new System.Drawing.Size(68, 13);
			this.lblNotCopied.TabIndex = 8;
			this.lblNotCopied.Text = "Não copiado";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Mensagem Recebida";
			// 
			// rbNCopied
			// 
			this.rbNCopied.AutoSize = true;
			this.rbNCopied.Enabled = false;
			this.rbNCopied.Location = new System.Drawing.Point(8, 73);
			this.rbNCopied.Name = "rbNCopied";
			this.rbNCopied.Size = new System.Drawing.Size(14, 13);
			this.rbNCopied.TabIndex = 3;
			this.rbNCopied.TabStop = true;
			this.rbNCopied.UseVisualStyleBackColor = true;
			// 
			// rbOK
			// 
			this.rbOK.AutoSize = true;
			this.rbOK.Enabled = false;
			this.rbOK.Location = new System.Drawing.Point(8, 119);
			this.rbOK.Name = "rbOK";
			this.rbOK.Size = new System.Drawing.Size(14, 13);
			this.rbOK.TabIndex = 2;
			this.rbOK.TabStop = true;
			this.rbOK.UseVisualStyleBackColor = true;
			// 
			// rbError
			// 
			this.rbError.AutoSize = true;
			this.rbError.Enabled = false;
			this.rbError.Location = new System.Drawing.Point(8, 96);
			this.rbError.Name = "rbError";
			this.rbError.Size = new System.Drawing.Size(14, 13);
			this.rbError.TabIndex = 1;
			this.rbError.TabStop = true;
			this.rbError.UseVisualStyleBackColor = true;
			// 
			// checkboxData
			// 
			this.checkboxData.AutoSize = true;
			this.checkboxData.Enabled = false;
			this.checkboxData.Location = new System.Drawing.Point(9, 16);
			this.checkboxData.Name = "checkboxData";
			this.checkboxData.Size = new System.Drawing.Size(15, 14);
			this.checkboxData.TabIndex = 0;
			this.checkboxData.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.btnGenToken);
			this.groupBox6.Controls.Add(this.checkboxController);
			this.groupBox6.Location = new System.Drawing.Point(232, 156);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(143, 74);
			this.groupBox6.TabIndex = 5;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Controle de Tokens";
			// 
			// btnGenToken
			// 
			this.btnGenToken.Enabled = false;
			this.btnGenToken.Location = new System.Drawing.Point(6, 42);
			this.btnGenToken.Name = "btnGenToken";
			this.btnGenToken.Size = new System.Drawing.Size(127, 23);
			this.btnGenToken.TabIndex = 1;
			this.btnGenToken.Text = "Gerar Novo Token";
			this.btnGenToken.UseVisualStyleBackColor = true;
			this.btnGenToken.Click += new System.EventHandler(this.btnGenToken_Click);
			// 
			// checkboxController
			// 
			this.checkboxController.AutoSize = true;
			this.checkboxController.Location = new System.Drawing.Point(6, 19);
			this.checkboxController.Name = "checkboxController";
			this.checkboxController.Size = new System.Drawing.Size(127, 17);
			this.checkboxController.TabIndex = 0;
			this.checkboxController.Text = "Estação controladora";
			this.checkboxController.UseVisualStyleBackColor = true;
			// 
			// btnStart
			// 
			this.btnStart.Enabled = false;
			this.btnStart.Location = new System.Drawing.Point(309, 236);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(70, 26);
			this.btnStart.TabIndex = 6;
			this.btnStart.Text = "Iniciar";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDest);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtOrigin);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(214, 67);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rede";
			// 
			// txtDest
			// 
			this.txtDest.Location = new System.Drawing.Point(119, 38);
			this.txtDest.Name = "txtDest";
			this.txtDest.Size = new System.Drawing.Size(89, 20);
			this.txtDest.TabIndex = 9;
			this.txtDest.TextChanged += new System.EventHandler(this.txtDest_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Enviar pacotes para:";
			// 
			// txtOrigin
			// 
			this.txtOrigin.Location = new System.Drawing.Point(119, 13);
			this.txtOrigin.Name = "txtOrigin";
			this.txtOrigin.Size = new System.Drawing.Size(89, 20);
			this.txtOrigin.TabIndex = 8;
			this.txtOrigin.TextChanged += new System.EventHandler(this.txtOrigin_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Receber pacotes de:";
			// 
			// btnStop
			// 
			this.btnStop.Enabled = false;
			this.btnStop.Location = new System.Drawing.Point(235, 236);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(68, 26);
			this.btnStop.TabIndex = 8;
			this.btnStop.Text = "Parar";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 274);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Token Bus App - CDT 2006/2 - T2";
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbNCopied;
        private System.Windows.Forms.RadioButton rbOK;
        private System.Windows.Forms.RadioButton rbError;
        private System.Windows.Forms.CheckBox checkboxData;
		 private System.Windows.Forms.GroupBox groupBox6;
		 private System.Windows.Forms.CheckBox checkboxController;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnGenToken;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label lblOK;
		private System.Windows.Forms.Label lblErro;
		private System.Windows.Forms.Label lblNotCopied;
		 private System.Windows.Forms.TextBox txtData;
    }
}

