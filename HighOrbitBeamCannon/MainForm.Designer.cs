namespace HighOrbitBeamCannon
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
            this.components = new System.ComponentModel.Container();
            this.btnFire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBusy = new System.Windows.Forms.Label();
            this.lblRequests = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFUck = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.radTcp = new System.Windows.Forms.RadioButton();
            this.radUdp = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numThreads = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessageValid = new System.Windows.Forms.Label();
            this.radBinary = new System.Windows.Forms.RadioButton();
            this.radHex = new System.Windows.Forms.RadioButton();
            this.radUtf = new System.Windows.Forms.RadioButton();
            this.radAscii = new System.Windows.Forms.RadioButton();
            this.timerUiWork = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFire.Location = new System.Drawing.Point(601, 269);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(125, 63);
            this.btnFire.TabIndex = 0;
            this.btnFire.Text = "Fire!";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address:Port";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(165, 12);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(434, 39);
            this.txtAddress.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblBusy);
            this.groupBox1.Controls.Add(this.lblRequests);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblWaiting);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelFUck);
            this.groupBox1.Location = new System.Drawing.Point(13, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // lblBusy
            // 
            this.lblBusy.AutoSize = true;
            this.lblBusy.Location = new System.Drawing.Point(239, 29);
            this.lblBusy.Name = "lblBusy";
            this.lblBusy.Size = new System.Drawing.Size(18, 20);
            this.lblBusy.TabIndex = 5;
            this.lblBusy.Text = "0";
            // 
            // lblRequests
            // 
            this.lblRequests.AutoSize = true;
            this.lblRequests.Location = new System.Drawing.Point(404, 29);
            this.lblRequests.Name = "lblRequests";
            this.lblRequests.Size = new System.Drawing.Size(18, 20);
            this.lblRequests.TabIndex = 1;
            this.lblRequests.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Requests:";
            // 
            // lblWaiting
            // 
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.Location = new System.Drawing.Point(93, 29);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(18, 20);
            this.lblWaiting.TabIndex = 4;
            this.lblWaiting.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Waiting";
            // 
            // labelFUck
            // 
            this.labelFUck.AutoSize = true;
            this.labelFUck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFUck.Location = new System.Drawing.Point(159, 29);
            this.labelFUck.Name = "labelFUck";
            this.labelFUck.Size = new System.Drawing.Size(74, 20);
            this.labelFUck.TabIndex = 3;
            this.labelFUck.Text = "Working";
            // 
            // numPort
            // 
            this.numPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPort.Location = new System.Drawing.Point(605, 12);
            this.numPort.Maximum = new decimal(new int[] {
            65565,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(125, 39);
            this.numPort.TabIndex = 4;
            this.numPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // radTcp
            // 
            this.radTcp.AutoSize = true;
            this.radTcp.Location = new System.Drawing.Point(176, 67);
            this.radTcp.Name = "radTcp";
            this.radTcp.Size = new System.Drawing.Size(64, 24);
            this.radTcp.TabIndex = 5;
            this.radTcp.Text = "TCP";
            this.radTcp.UseVisualStyleBackColor = true;
            // 
            // radUdp
            // 
            this.radUdp.AutoSize = true;
            this.radUdp.Checked = true;
            this.radUdp.Location = new System.Drawing.Point(256, 67);
            this.radUdp.Name = "radUdp";
            this.radUdp.Size = new System.Drawing.Size(68, 24);
            this.radUdp.TabIndex = 6;
            this.radUdp.TabStop = true;
            this.radUdp.Text = "UDP";
            this.radUdp.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Workers";
            // 
            // numThreads
            // 
            this.numThreads.Location = new System.Drawing.Point(165, 112);
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(120, 26);
            this.numThreads.TabIndex = 9;
            this.numThreads.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(165, 150);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(560, 66);
            this.txtMessage.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblMessageValid);
            this.panel1.Controls.Add(this.radBinary);
            this.panel1.Controls.Add(this.radHex);
            this.panel1.Controls.Add(this.radUtf);
            this.panel1.Controls.Add(this.radAscii);
            this.panel1.Location = new System.Drawing.Point(165, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 31);
            this.panel1.TabIndex = 12;
            // 
            // lblMessageValid
            // 
            this.lblMessageValid.AutoSize = true;
            this.lblMessageValid.Location = new System.Drawing.Point(468, 6);
            this.lblMessageValid.Name = "lblMessageValid";
            this.lblMessageValid.Size = new System.Drawing.Size(0, 20);
            this.lblMessageValid.TabIndex = 14;
            // 
            // radBinary
            // 
            this.radBinary.AutoSize = true;
            this.radBinary.Location = new System.Drawing.Point(242, 3);
            this.radBinary.Name = "radBinary";
            this.radBinary.Size = new System.Drawing.Size(78, 24);
            this.radBinary.TabIndex = 13;
            this.radBinary.TabStop = true;
            this.radBinary.Text = "Binary";
            this.radBinary.UseVisualStyleBackColor = true;
            // 
            // radHex
            // 
            this.radHex.AutoSize = true;
            this.radHex.Location = new System.Drawing.Point(174, 4);
            this.radHex.Name = "radHex";
            this.radHex.Size = new System.Drawing.Size(62, 24);
            this.radHex.TabIndex = 2;
            this.radHex.TabStop = true;
            this.radHex.Text = "Hex";
            this.radHex.UseVisualStyleBackColor = true;
            // 
            // radUtf
            // 
            this.radUtf.AutoSize = true;
            this.radUtf.Location = new System.Drawing.Point(94, 4);
            this.radUtf.Name = "radUtf";
            this.radUtf.Size = new System.Drawing.Size(74, 24);
            this.radUtf.TabIndex = 1;
            this.radUtf.TabStop = true;
            this.radUtf.Text = "UTF8";
            this.radUtf.UseVisualStyleBackColor = true;
            // 
            // radAscii
            // 
            this.radAscii.AutoSize = true;
            this.radAscii.Location = new System.Drawing.Point(11, 4);
            this.radAscii.Name = "radAscii";
            this.radAscii.Size = new System.Drawing.Size(77, 24);
            this.radAscii.TabIndex = 0;
            this.radAscii.TabStop = true;
            this.radAscii.Text = "ASCII";
            this.radAscii.UseVisualStyleBackColor = true;
            // 
            // timerUiWork
            // 
            this.timerUiWork.Interval = 10;
            this.timerUiWork.Tick += new System.EventHandler(this.timerUiWork_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(738, 344);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numThreads);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radUdp);
            this.Controls.Add(this.radTcp);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFire);
            this.MinimumSize = new System.Drawing.Size(687, 400);
            this.Name = "MainForm";
            this.Text = "OOOooO KillEM!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRequests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBusy;
        private System.Windows.Forms.Label lblWaiting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFUck;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.RadioButton radTcp;
        private System.Windows.Forms.RadioButton radUdp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numThreads;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radAscii;
        private System.Windows.Forms.RadioButton radBinary;
        private System.Windows.Forms.RadioButton radHex;
        private System.Windows.Forms.RadioButton radUtf;
        private System.Windows.Forms.Label lblMessageValid;
        private System.Windows.Forms.Timer timerUiWork;
    }
}

