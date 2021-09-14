namespace RobotRaspberryPi.Interfejs
{
    partial class PrzegladBazy
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
            this.dgvPrzeglad = new System.Windows.Forms.DataGridView();
            this.combxTabele = new System.Windows.Forms.ComboBox();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzeglad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrzeglad
            // 
            this.dgvPrzeglad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrzeglad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPrzeglad.Location = new System.Drawing.Point(0, 98);
            this.dgvPrzeglad.Name = "dgvPrzeglad";
            this.dgvPrzeglad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrzeglad.Size = new System.Drawing.Size(768, 356);
            this.dgvPrzeglad.TabIndex = 0;
            // 
            // combxTabele
            // 
            this.combxTabele.FormattingEnabled = true;
            this.combxTabele.Location = new System.Drawing.Point(41, 35);
            this.combxTabele.Name = "combxTabele";
            this.combxTabele.Size = new System.Drawing.Size(152, 21);
            this.combxTabele.TabIndex = 1;
            this.combxTabele.SelectedIndexChanged += new System.EventHandler(this.combxTabele_SelectedIndexChanged);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(390, 35);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(80, 23);
            this.btnUsun.TabIndex = 2;
            this.btnUsun.Text = "Usuń wiersz";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Location = new System.Drawing.Point(297, 35);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(75, 23);
            this.btnOdswiez.TabIndex = 3;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(618, 69);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(138, 23);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Eksportuj do pliku Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // PrzegladBazy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 454);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.combxTabele);
            this.Controls.Add(this.dgvPrzeglad);
            this.Name = "PrzegladBazy";
            this.Text = "PrzegladBazy";
            this.Load += new System.EventHandler(this.PrzegladBazy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzeglad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrzeglad;
        private System.Windows.Forms.ComboBox combxTabele;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Button btnExcel;
    }
}