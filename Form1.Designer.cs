namespace GudangMonitorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSuhu = new Label();
            txtLog = new TextBox();
            btnStartLogging = new Button();
            btnConnect = new Button();
            cmbPort = new ComboBox();
            label1 = new Label();
            lblKlasifikasi = new Label();
            testTxt = new TextBox();
            SuspendLayout();
            // 
            // lblSuhu
            // 
            lblSuhu.AutoSize = true;
            lblSuhu.Location = new Point(37, 37);
            lblSuhu.Name = "lblSuhu";
            lblSuhu.Size = new Size(52, 25);
            lblSuhu.TabIndex = 0;
            lblSuhu.Text = "Suhu";
            lblSuhu.Click += label1_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(37, 77);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(261, 273);
            txtLog.TabIndex = 1;
            // 
            // btnStartLogging
            // 
            btnStartLogging.Location = new Point(186, 366);
            btnStartLogging.Name = "btnStartLogging";
            btnStartLogging.Size = new Size(112, 34);
            btnStartLogging.TabIndex = 2;
            btnStartLogging.Text = "Logging";
            btnStartLogging.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(370, 133);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(112, 34);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            // 
            // cmbPort
            // 
            cmbPort.FormattingEnabled = true;
            cmbPort.Location = new Point(331, 77);
            cmbPort.Name = "cmbPort";
            cmbPort.Size = new Size(151, 33);
            cmbPort.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 276);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 5;
            label1.Text = "kelasifikasi";
            label1.Click += label1_Click_1;
            // 
            // lblKlasifikasi
            // 
            lblKlasifikasi.AutoSize = true;
            lblKlasifikasi.Location = new Point(331, 325);
            lblKlasifikasi.Name = "lblKlasifikasi";
            lblKlasifikasi.Size = new Size(55, 25);
            lblKlasifikasi.TabIndex = 6;
            lblKlasifikasi.Text = "None";
            // 
            // testTxt
            // 
            testTxt.Location = new Point(331, 221);
            testTxt.Name = "testTxt";
            testTxt.Size = new Size(150, 31);
            testTxt.TabIndex = 7;
            testTxt.TextChanged += testTxt_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 450);
            Controls.Add(testTxt);
            Controls.Add(lblKlasifikasi);
            Controls.Add(label1);
            Controls.Add(cmbPort);
            Controls.Add(btnConnect);
            Controls.Add(btnStartLogging);
            Controls.Add(txtLog);
            Controls.Add(lblSuhu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSuhu;
        private TextBox txtLog;
        private Button btnStartLogging;
        private Button btnConnect;
        private ComboBox cmbPort;
        private Label label1;
        private Label lblKlasifikasi;
        private TextBox testTxt;
    }
}
