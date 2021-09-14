namespace RobotRaspberryPi.Interfejs
{
    partial class Czujniki
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
            this.txtPomiary = new System.Windows.Forms.TextBox();
            this.chbCzTemp = new System.Windows.Forms.CheckBox();
            this.chbCzOdleg = new System.Windows.Forms.CheckBox();
            this.chbCzAkcel = new System.Windows.Forms.CheckBox();
            this.chbCzZyros = new System.Windows.Forms.CheckBox();
            this.chbCzSwiatla = new System.Windows.Forms.CheckBox();
            this.btnPobierz = new System.Windows.Forms.Button();
            this.txtNazwaPom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStopPob = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtCzPom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPomiary
            // 
            this.txtPomiary.Location = new System.Drawing.Point(286, 44);
            this.txtPomiary.Multiline = true;
            this.txtPomiary.Name = "txtPomiary";
            this.txtPomiary.ReadOnly = true;
            this.txtPomiary.Size = new System.Drawing.Size(160, 252);
            this.txtPomiary.TabIndex = 0;
            this.txtPomiary.TextChanged += new System.EventHandler(this.txtPomiary_TextChanged);
            // 
            // chbCzTemp
            // 
            this.chbCzTemp.AutoSize = true;
            this.chbCzTemp.Location = new System.Drawing.Point(5, 87);
            this.chbCzTemp.Name = "chbCzTemp";
            this.chbCzTemp.Size = new System.Drawing.Size(85, 17);
            this.chbCzTemp.TabIndex = 4;
            this.chbCzTemp.Text = "Temperatury";
            this.chbCzTemp.UseVisualStyleBackColor = true;
            // 
            // chbCzOdleg
            // 
            this.chbCzOdleg.AutoSize = true;
            this.chbCzOdleg.Location = new System.Drawing.Point(125, 54);
            this.chbCzOdleg.Name = "chbCzOdleg";
            this.chbCzOdleg.Size = new System.Drawing.Size(77, 17);
            this.chbCzOdleg.TabIndex = 3;
            this.chbCzOdleg.Text = "Odległości";
            this.chbCzOdleg.UseVisualStyleBackColor = true;
            // 
            // chbCzAkcel
            // 
            this.chbCzAkcel.AutoSize = true;
            this.chbCzAkcel.Location = new System.Drawing.Point(5, 54);
            this.chbCzAkcel.Name = "chbCzAkcel";
            this.chbCzAkcel.Size = new System.Drawing.Size(88, 17);
            this.chbCzAkcel.TabIndex = 2;
            this.chbCzAkcel.Text = "Akcelerometr";
            this.chbCzAkcel.UseVisualStyleBackColor = true;
            // 
            // chbCzZyros
            // 
            this.chbCzZyros.AutoSize = true;
            this.chbCzZyros.Location = new System.Drawing.Point(125, 22);
            this.chbCzZyros.Name = "chbCzZyros";
            this.chbCzZyros.Size = new System.Drawing.Size(70, 17);
            this.chbCzZyros.TabIndex = 1;
            this.chbCzZyros.Text = "Żyroskop";
            this.chbCzZyros.UseVisualStyleBackColor = true;
            // 
            // chbCzSwiatla
            // 
            this.chbCzSwiatla.AutoSize = true;
            this.chbCzSwiatla.Location = new System.Drawing.Point(6, 22);
            this.chbCzSwiatla.Name = "chbCzSwiatla";
            this.chbCzSwiatla.Size = new System.Drawing.Size(113, 17);
            this.chbCzSwiatla.TabIndex = 0;
            this.chbCzSwiatla.Text = "Natężenia Światła";
            this.chbCzSwiatla.UseVisualStyleBackColor = true;
            // 
            // btnPobierz
            // 
            this.btnPobierz.Location = new System.Drawing.Point(16, 228);
            this.btnPobierz.Name = "btnPobierz";
            this.btnPobierz.Size = new System.Drawing.Size(127, 23);
            this.btnPobierz.TabIndex = 2;
            this.btnPobierz.Text = "Rozpocznij pobieranie";
            this.btnPobierz.UseVisualStyleBackColor = true;
            this.btnPobierz.Click += new System.EventHandler(this.btnPobierz_Click);
            // 
            // txtNazwaPom
            // 
            this.txtNazwaPom.Location = new System.Drawing.Point(16, 191);
            this.txtNazwaPom.Name = "txtNazwaPom";
            this.txtNazwaPom.Size = new System.Drawing.Size(100, 20);
            this.txtNazwaPom.TabIndex = 3;
            this.txtNazwaPom.Leave += new System.EventHandler(this.txtNazwaPom_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wpisz nazwę pomiaru";
            // 
            // btnStopPob
            // 
            this.btnStopPob.Location = new System.Drawing.Point(16, 257);
            this.btnStopPob.Name = "btnStopPob";
            this.btnStopPob.Size = new System.Drawing.Size(127, 23);
            this.btnStopPob.TabIndex = 5;
            this.btnStopPob.Text = "Zatrzymaj pobieranie";
            this.btnStopPob.UseVisualStyleBackColor = true;
            this.btnStopPob.Click += new System.EventHandler(this.btnStopPob_Click);
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtCzPom
            // 
            this.txtCzPom.Location = new System.Drawing.Point(169, 191);
            this.txtCzPom.Name = "txtCzPom";
            this.txtCzPom.Size = new System.Drawing.Size(100, 20);
            this.txtCzPom.TabIndex = 6;
            this.txtCzPom.Text = "5";
            this.txtCzPom.Leave += new System.EventHandler(this.txtCzPom_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Czas w sekundach \r\npomiędzy pomiarami:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbCzSwiatla);
            this.groupBox1.Controls.Add(this.chbCzTemp);
            this.groupBox1.Controls.Add(this.chbCzOdleg);
            this.groupBox1.Controls.Add(this.chbCzAkcel);
            this.groupBox1.Controls.Add(this.chbCzZyros);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 118);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Czujniki";
            // 
            // Czujniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCzPom);
            this.Controls.Add(this.btnStopPob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazwaPom);
            this.Controls.Add(this.btnPobierz);
            this.Controls.Add(this.txtPomiary);
            this.Name = "Czujniki";
            this.Text = "Czujniki";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPomiary;
        private System.Windows.Forms.CheckBox chbCzOdleg;
        private System.Windows.Forms.CheckBox chbCzAkcel;
        private System.Windows.Forms.CheckBox chbCzZyros;
        private System.Windows.Forms.CheckBox chbCzSwiatla;
        private System.Windows.Forms.CheckBox chbCzTemp;
        private System.Windows.Forms.Button btnPobierz;
        private System.Windows.Forms.TextBox txtNazwaPom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStopPob;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtCzPom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}