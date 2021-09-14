namespace RobotRaspberryPi.Interfejs
{
    partial class Menu
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
            this.btnBaza = new System.Windows.Forms.Button();
            this.btnZdanymi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRozlacz = new System.Windows.Forms.Button();
            this.btnPolacz = new System.Windows.Forms.Button();
            this.btnSteruj = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaza
            // 
            this.btnBaza.Location = new System.Drawing.Point(112, 119);
            this.btnBaza.Name = "btnBaza";
            this.btnBaza.Size = new System.Drawing.Size(107, 23);
            this.btnBaza.TabIndex = 18;
            this.btnBaza.Text = "Przejrzyj bazę";
            this.btnBaza.UseVisualStyleBackColor = true;
            this.btnBaza.Click += new System.EventHandler(this.btnBaza_Click);
            // 
            // btnZdanymi
            // 
            this.btnZdanymi.Location = new System.Drawing.Point(112, 177);
            this.btnZdanymi.Name = "btnZdanymi";
            this.btnZdanymi.Size = new System.Drawing.Size(107, 23);
            this.btnZdanymi.TabIndex = 17;
            this.btnZdanymi.Text = "Zbierz dane";
            this.btnZdanymi.UseVisualStyleBackColor = true;
            this.btnZdanymi.Click += new System.EventHandler(this.btnZdanymi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nie połączono";
            // 
            // btnRozlacz
            // 
            this.btnRozlacz.Location = new System.Drawing.Point(14, 106);
            this.btnRozlacz.Name = "btnRozlacz";
            this.btnRozlacz.Size = new System.Drawing.Size(75, 23);
            this.btnRozlacz.TabIndex = 15;
            this.btnRozlacz.Text = "Rozłącz";
            this.btnRozlacz.UseVisualStyleBackColor = true;
            this.btnRozlacz.Click += new System.EventHandler(this.btnRozlacz_Click);
            // 
            // btnPolacz
            // 
            this.btnPolacz.Location = new System.Drawing.Point(14, 62);
            this.btnPolacz.Name = "btnPolacz";
            this.btnPolacz.Size = new System.Drawing.Size(75, 23);
            this.btnPolacz.TabIndex = 14;
            this.btnPolacz.Text = "Połącz";
            this.btnPolacz.UseVisualStyleBackColor = true;
            this.btnPolacz.Click += new System.EventHandler(this.btnPolacz_Click);
            // 
            // btnSteruj
            // 
            this.btnSteruj.Location = new System.Drawing.Point(112, 148);
            this.btnSteruj.Name = "btnSteruj";
            this.btnSteruj.Size = new System.Drawing.Size(107, 23);
            this.btnSteruj.TabIndex = 19;
            this.btnSteruj.Text = "Steruj";
            this.btnSteruj.UseVisualStyleBackColor = true;
            this.btnSteruj.Click += new System.EventHandler(this.btnSteruj_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(95, 21);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 20;
            this.txtHost.Text = "192.168.178.46";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Adres IP:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnSteruj);
            this.Controls.Add(this.btnBaza);
            this.Controls.Add(this.btnZdanymi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRozlacz);
            this.Controls.Add(this.btnPolacz);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaza;
        private System.Windows.Forms.Button btnZdanymi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRozlacz;
        private System.Windows.Forms.Button btnPolacz;
        private System.Windows.Forms.Button btnSteruj;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label2;
    }
}