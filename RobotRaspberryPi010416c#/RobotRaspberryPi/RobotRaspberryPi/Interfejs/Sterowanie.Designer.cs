namespace RobotRaspberryPi.Interfejs
{
    partial class Sterowanie
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
            this.btnNsekw = new System.Windows.Forms.Button();
            this.btnZsekw = new System.Windows.Forms.Button();
            this.txtSekwencja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTyl = new System.Windows.Forms.Button();
            this.btnPrawo = new System.Windows.Forms.Button();
            this.btnProsto = new System.Windows.Forms.Button();
            this.btnLewo = new System.Windows.Forms.Button();
            this.lbSekwencja = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.timerProsto = new System.Windows.Forms.Timer(this.components);
            this.timerTyl = new System.Windows.Forms.Timer(this.components);
            this.timerPrawo = new System.Windows.Forms.Timer(this.components);
            this.timerLewo = new System.Windows.Forms.Timer(this.components);
            this.combxSekw = new System.Windows.Forms.ComboBox();
            this.btnSekwencje = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.timerOdczyt = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNsekw
            // 
            this.btnNsekw.Location = new System.Drawing.Point(12, 337);
            this.btnNsekw.Name = "btnNsekw";
            this.btnNsekw.Size = new System.Drawing.Size(152, 23);
            this.btnNsekw.TabIndex = 13;
            this.btnNsekw.Text = "Nagraj sekwencję";
            this.btnNsekw.UseVisualStyleBackColor = true;
            this.btnNsekw.Click += new System.EventHandler(this.btnNsekw_Click);
            // 
            // btnZsekw
            // 
            this.btnZsekw.Location = new System.Drawing.Point(12, 377);
            this.btnZsekw.Name = "btnZsekw";
            this.btnZsekw.Size = new System.Drawing.Size(151, 23);
            this.btnZsekw.TabIndex = 14;
            this.btnZsekw.Text = "Zatrzymaj i zapisz nagranie";
            this.btnZsekw.UseVisualStyleBackColor = true;
            this.btnZsekw.Click += new System.EventHandler(this.btnZsekw_Click);
            // 
            // txtSekwencja
            // 
            this.txtSekwencja.Location = new System.Drawing.Point(180, 357);
            this.txtSekwencja.Name = "txtSekwencja";
            this.txtSekwencja.Size = new System.Drawing.Size(100, 20);
            this.txtSekwencja.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Wpisz nazwę sekwencji:";
            // 
            // btnTyl
            // 
            this.btnTyl.Image = global::RobotRaspberryPi.Properties.Resources.tyl;
            this.btnTyl.Location = new System.Drawing.Point(173, 258);
            this.btnTyl.Name = "btnTyl";
            this.btnTyl.Size = new System.Drawing.Size(37, 45);
            this.btnTyl.TabIndex = 3;
            this.btnTyl.UseVisualStyleBackColor = true;
            this.btnTyl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTyl_MouseDown);
            this.btnTyl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTyl_MouseUp);
            // 
            // btnPrawo
            // 
            this.btnPrawo.Image = global::RobotRaspberryPi.Properties.Resources.prawo;
            this.btnPrawo.Location = new System.Drawing.Point(250, 208);
            this.btnPrawo.Name = "btnPrawo";
            this.btnPrawo.Size = new System.Drawing.Size(51, 33);
            this.btnPrawo.TabIndex = 2;
            this.btnPrawo.UseVisualStyleBackColor = true;
            this.btnPrawo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPrawo_MouseDown);
            this.btnPrawo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPrawo_MouseUp);
            // 
            // btnProsto
            // 
            this.btnProsto.Image = global::RobotRaspberryPi.Properties.Resources.prosto;
            this.btnProsto.Location = new System.Drawing.Point(173, 147);
            this.btnProsto.Name = "btnProsto";
            this.btnProsto.Size = new System.Drawing.Size(37, 45);
            this.btnProsto.TabIndex = 1;
            this.btnProsto.UseVisualStyleBackColor = true;
            this.btnProsto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnProsto_MouseDown);
            this.btnProsto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnProsto_MouseUp);
            // 
            // btnLewo
            // 
            this.btnLewo.Image = global::RobotRaspberryPi.Properties.Resources.lewo;
            this.btnLewo.Location = new System.Drawing.Point(82, 208);
            this.btnLewo.Name = "btnLewo";
            this.btnLewo.Size = new System.Drawing.Size(51, 33);
            this.btnLewo.TabIndex = 0;
            this.btnLewo.UseVisualStyleBackColor = true;
            this.btnLewo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLewo_MouseDown);
            this.btnLewo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLewo_MouseUp);
            // 
            // lbSekwencja
            // 
            this.lbSekwencja.AutoSize = true;
            this.lbSekwencja.Location = new System.Drawing.Point(26, 300);
            this.lbSekwencja.Name = "lbSekwencja";
            this.lbSekwencja.Size = new System.Drawing.Size(0, 13);
            this.lbSekwencja.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAuto);
            this.groupBox1.Controls.Add(this.rbManual);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sterowanie";
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(18, 60);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(92, 17);
            this.rbAuto.TabIndex = 1;
            this.rbAuto.Text = "Automatyczne";
            this.rbAuto.UseVisualStyleBackColor = true;
            this.rbAuto.CheckedChanged += new System.EventHandler(this.rbAuto_CheckedChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Checked = true;
            this.rbManual.Location = new System.Drawing.Point(18, 36);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(72, 17);
            this.rbManual.TabIndex = 0;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manualne";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 19;
            // 
            // timerProsto
            // 
            this.timerProsto.Interval = 1500;
            this.timerProsto.Tick += new System.EventHandler(this.timerProsto_Tick);
            // 
            // timerTyl
            // 
            this.timerTyl.Interval = 1500;
            this.timerTyl.Tick += new System.EventHandler(this.timerTyl_Tick);
            // 
            // timerPrawo
            // 
            this.timerPrawo.Interval = 1500;
            this.timerPrawo.Tick += new System.EventHandler(this.timerPrawo_Tick);
            // 
            // timerLewo
            // 
            this.timerLewo.Interval = 1500;
            this.timerLewo.Tick += new System.EventHandler(this.timerLewo_Tick);
            // 
            // combxSekw
            // 
            this.combxSekw.FormattingEnabled = true;
            this.combxSekw.Location = new System.Drawing.Point(254, 56);
            this.combxSekw.Name = "combxSekw";
            this.combxSekw.Size = new System.Drawing.Size(121, 21);
            this.combxSekw.TabIndex = 20;
            this.combxSekw.SelectedIndexChanged += new System.EventHandler(this.combxSekw_SelectedIndexChanged);
            // 
            // btnSekwencje
            // 
            this.btnSekwencje.Enabled = false;
            this.btnSekwencje.Location = new System.Drawing.Point(227, 98);
            this.btnSekwencje.Name = "btnSekwencje";
            this.btnSekwencje.Size = new System.Drawing.Size(114, 23);
            this.btnSekwencje.TabIndex = 21;
            this.btnSekwencje.Text = "Załaduj Sekwencje";
            this.btnSekwencje.UseVisualStyleBackColor = true;
            this.btnSekwencje.Click += new System.EventHandler(this.btnSekwencje_Click);
            // 
            // btnGo
            // 
            this.btnGo.Enabled = false;
            this.btnGo.Location = new System.Drawing.Point(347, 98);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 22;
            this.btnGo.Text = "Jedź!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // timerOdczyt
            // 
            this.timerOdczyt.Interval = 5000;
            this.timerOdczyt.Tick += new System.EventHandler(this.timerOdczyt_Tick);
            // 
            // Sterowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 429);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnSekwencje);
            this.Controls.Add(this.combxSekw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbSekwencja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSekwencja);
            this.Controls.Add(this.btnZsekw);
            this.Controls.Add(this.btnNsekw);
            this.Controls.Add(this.btnTyl);
            this.Controls.Add(this.btnPrawo);
            this.Controls.Add(this.btnProsto);
            this.Controls.Add(this.btnLewo);
            this.Name = "Sterowanie";
            this.Text = "Sterowanie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLewo;
        private System.Windows.Forms.Button btnProsto;
        private System.Windows.Forms.Button btnPrawo;
        private System.Windows.Forms.Button btnTyl;
        private System.Windows.Forms.Button btnNsekw;
        private System.Windows.Forms.Button btnZsekw;
        private System.Windows.Forms.TextBox txtSekwencja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSekwencja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerProsto;
        private System.Windows.Forms.Timer timerTyl;
        private System.Windows.Forms.Timer timerPrawo;
        private System.Windows.Forms.Timer timerLewo;
        private System.Windows.Forms.ComboBox combxSekw;
        private System.Windows.Forms.Button btnSekwencje;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Timer timerOdczyt;
    }
}

