namespace WFClient
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
            this.btLogin = new System.Windows.Forms.Button();
            this.btSendText = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.tbSendText = new System.Windows.Forms.TextBox();
            this.tbReceivedText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(13, 13);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btSendText
            // 
            this.btSendText.Location = new System.Drawing.Point(383, 40);
            this.btSendText.Name = "btSendText";
            this.btSendText.Size = new System.Drawing.Size(75, 23);
            this.btSendText.TabIndex = 0;
            this.btSendText.Text = "Send";
            this.btSendText.UseVisualStyleBackColor = true;
            this.btSendText.Click += new System.EventHandler(this.btSendText_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(94, 13);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 23);
            this.btLogout.TabIndex = 0;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // tbSendText
            // 
            this.tbSendText.Enabled = false;
            this.tbSendText.Location = new System.Drawing.Point(13, 42);
            this.tbSendText.Name = "tbSendText";
            this.tbSendText.Size = new System.Drawing.Size(364, 20);
            this.tbSendText.TabIndex = 1;
            // 
            // tbReceivedText
            // 
            this.tbReceivedText.Location = new System.Drawing.Point(13, 69);
            this.tbReceivedText.Multiline = true;
            this.tbReceivedText.Name = "tbReceivedText";
            this.tbReceivedText.Size = new System.Drawing.Size(364, 279);
            this.tbReceivedText.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 360);
            this.Controls.Add(this.tbReceivedText);
            this.Controls.Add(this.tbSendText);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btSendText);
            this.Controls.Add(this.btLogin);
            this.Name = "MainForm";
            this.Text = "Send text";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btSendText;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.TextBox tbSendText;
        private System.Windows.Forms.TextBox tbReceivedText;
    }
}

