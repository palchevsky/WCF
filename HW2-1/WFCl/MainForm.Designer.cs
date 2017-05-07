namespace WFCl
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
            this.btFahrenheit = new System.Windows.Forms.Button();
            this.btCelsius = new System.Windows.Forms.Button();
            this.btConvert = new System.Windows.Forms.Button();
            this.lbInch = new System.Windows.Forms.Label();
            this.lbYards = new System.Windows.Forms.Label();
            this.lbInchNum = new System.Windows.Forms.Label();
            this.lbYardNum = new System.Windows.Forms.Label();
            this.lbFeetNum = new System.Windows.Forms.Label();
            this.lbFeet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMeters = new System.Windows.Forms.Label();
            this.tbFahrenheit = new System.Windows.Forms.TextBox();
            this.tbCelsius = new System.Windows.Forms.TextBox();
            this.tbMeters = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btFahrenheit
            // 
            this.btFahrenheit.Location = new System.Drawing.Point(156, 151);
            this.btFahrenheit.Name = "btFahrenheit";
            this.btFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.btFahrenheit.TabIndex = 15;
            this.btFahrenheit.Text = "Convert";
            this.btFahrenheit.UseVisualStyleBackColor = true;
            this.btFahrenheit.Click += new System.EventHandler(this.btConvert3_Click);
            // 
            // btCelsius
            // 
            this.btCelsius.Location = new System.Drawing.Point(156, 109);
            this.btCelsius.Name = "btCelsius";
            this.btCelsius.Size = new System.Drawing.Size(75, 23);
            this.btCelsius.TabIndex = 16;
            this.btCelsius.Text = "Convert";
            this.btCelsius.UseVisualStyleBackColor = true;
            this.btCelsius.Click += new System.EventHandler(this.btConvert2_Click);
            // 
            // btConvert
            // 
            this.btConvert.Location = new System.Drawing.Point(157, 22);
            this.btConvert.Name = "btConvert";
            this.btConvert.Size = new System.Drawing.Size(75, 23);
            this.btConvert.TabIndex = 17;
            this.btConvert.Text = "Convert";
            this.btConvert.UseVisualStyleBackColor = true;
            this.btConvert.Click += new System.EventHandler(this.btConvert1_Click);
            // 
            // lbInch
            // 
            this.lbInch.AutoSize = true;
            this.lbInch.Location = new System.Drawing.Point(9, 75);
            this.lbInch.Name = "lbInch";
            this.lbInch.Size = new System.Drawing.Size(49, 13);
            this.lbInch.TabIndex = 6;
            this.lbInch.Text = "Дюймы:";
            // 
            // lbYards
            // 
            this.lbYards.AutoSize = true;
            this.lbYards.Location = new System.Drawing.Point(9, 62);
            this.lbYards.Name = "lbYards";
            this.lbYards.Size = new System.Drawing.Size(38, 13);
            this.lbYards.TabIndex = 7;
            this.lbYards.Text = "Ярды:";
            // 
            // lbInchNum
            // 
            this.lbInchNum.AutoSize = true;
            this.lbInchNum.Location = new System.Drawing.Point(67, 75);
            this.lbInchNum.Name = "lbInchNum";
            this.lbInchNum.Size = new System.Drawing.Size(47, 13);
            this.lbInchNum.TabIndex = 8;
            this.lbInchNum.Text = "дюймов";
            // 
            // lbYardNum
            // 
            this.lbYardNum.AutoSize = true;
            this.lbYardNum.Location = new System.Drawing.Point(68, 62);
            this.lbYardNum.Name = "lbYardNum";
            this.lbYardNum.Size = new System.Drawing.Size(37, 13);
            this.lbYardNum.TabIndex = 9;
            this.lbYardNum.Text = "ярдов";
            // 
            // lbFeetNum
            // 
            this.lbFeetNum.AutoSize = true;
            this.lbFeetNum.Location = new System.Drawing.Point(68, 49);
            this.lbFeetNum.Name = "lbFeetNum";
            this.lbFeetNum.Size = new System.Drawing.Size(37, 13);
            this.lbFeetNum.TabIndex = 10;
            this.lbFeetNum.Text = "футов";
            // 
            // lbFeet
            // 
            this.lbFeet.AutoSize = true;
            this.lbFeet.Location = new System.Drawing.Point(9, 49);
            this.lbFeet.Name = "lbFeet";
            this.lbFeet.Size = new System.Drawing.Size(39, 13);
            this.lbFeet.TabIndex = 11;
            this.lbFeet.Text = "Футы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Градусы Фаренгейта:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Градусы Цельсия:";
            // 
            // lbMeters
            // 
            this.lbMeters.AutoSize = true;
            this.lbMeters.Location = new System.Drawing.Point(12, 10);
            this.lbMeters.Name = "lbMeters";
            this.lbMeters.Size = new System.Drawing.Size(44, 13);
            this.lbMeters.TabIndex = 14;
            this.lbMeters.Text = "Метры:";
            // 
            // tbFahrenheit
            // 
            this.tbFahrenheit.Location = new System.Drawing.Point(12, 152);
            this.tbFahrenheit.Name = "tbFahrenheit";
            this.tbFahrenheit.Size = new System.Drawing.Size(138, 20);
            this.tbFahrenheit.TabIndex = 3;
            this.tbFahrenheit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMeters_KeyPress);
            // 
            // tbCelsius
            // 
            this.tbCelsius.Location = new System.Drawing.Point(12, 110);
            this.tbCelsius.Name = "tbCelsius";
            this.tbCelsius.Size = new System.Drawing.Size(138, 20);
            this.tbCelsius.TabIndex = 4;
            this.tbCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMeters_KeyPress);
            // 
            // tbMeters
            // 
            this.tbMeters.Location = new System.Drawing.Point(12, 23);
            this.tbMeters.Name = "tbMeters";
            this.tbMeters.Size = new System.Drawing.Size(138, 20);
            this.tbMeters.TabIndex = 5;
            this.tbMeters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMeters_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 189);
            this.Controls.Add(this.btFahrenheit);
            this.Controls.Add(this.btCelsius);
            this.Controls.Add(this.btConvert);
            this.Controls.Add(this.lbInch);
            this.Controls.Add(this.lbYards);
            this.Controls.Add(this.lbInchNum);
            this.Controls.Add(this.lbYardNum);
            this.Controls.Add(this.lbFeetNum);
            this.Controls.Add(this.lbFeet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMeters);
            this.Controls.Add(this.tbFahrenheit);
            this.Controls.Add(this.tbCelsius);
            this.Controls.Add(this.tbMeters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFahrenheit;
        private System.Windows.Forms.Button btCelsius;
        private System.Windows.Forms.Button btConvert;
        private System.Windows.Forms.Label lbInch;
        private System.Windows.Forms.Label lbYards;
        private System.Windows.Forms.Label lbInchNum;
        private System.Windows.Forms.Label lbYardNum;
        private System.Windows.Forms.Label lbFeetNum;
        private System.Windows.Forms.Label lbFeet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMeters;
        private System.Windows.Forms.TextBox tbFahrenheit;
        private System.Windows.Forms.TextBox tbCelsius;
        private System.Windows.Forms.TextBox tbMeters;
    }
}

