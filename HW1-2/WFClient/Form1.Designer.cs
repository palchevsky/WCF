namespace WCFClient
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
            this.btShow = new System.Windows.Forms.Button();
            this.lbContents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btShow
            // 
            this.btShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btShow.Location = new System.Drawing.Point(0, 303);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(297, 23);
            this.btShow.TabIndex = 2;
            this.btShow.Text = "Open Directory";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // lbContents
            // 
            this.lbContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbContents.FormattingEnabled = true;
            this.lbContents.Location = new System.Drawing.Point(0, 0);
            this.lbContents.Name = "lbContents";
            this.lbContents.Size = new System.Drawing.Size(297, 303);
            this.lbContents.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 326);
            this.Controls.Add(this.lbContents);
            this.Controls.Add(this.btShow);
            this.Name = "MainForm";
            this.Text = "WCF DiskInfo Example";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.ListBox lbContents;
    }
}

