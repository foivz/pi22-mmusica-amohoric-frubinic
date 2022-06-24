namespace PC_for_you.UserControls
{
    partial class UCUredivanjeKomponenata
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUredivanjeKomponenata = new System.Windows.Forms.DataGridView();
            this.cmbVrsteKomponenata = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajKomponentu = new System.Windows.Forms.Button();
            this.btnAzurirajOdabranu = new System.Windows.Forms.Button();
            this.btnObrisiKomponentu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUredivanjeKomponenata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUredivanjeKomponenata
            // 
            this.dgvUredivanjeKomponenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUredivanjeKomponenata.Location = new System.Drawing.Point(3, 43);
            this.dgvUredivanjeKomponenata.Name = "dgvUredivanjeKomponenata";
            this.dgvUredivanjeKomponenata.Size = new System.Drawing.Size(794, 337);
            this.dgvUredivanjeKomponenata.TabIndex = 0;
            // 
            // cmbVrsteKomponenata
            // 
            this.cmbVrsteKomponenata.FormattingEnabled = true;
            this.cmbVrsteKomponenata.Location = new System.Drawing.Point(144, 16);
            this.cmbVrsteKomponenata.Name = "cmbVrsteKomponenata";
            this.cmbVrsteKomponenata.Size = new System.Drawing.Size(158, 21);
            this.cmbVrsteKomponenata.TabIndex = 1;
            this.cmbVrsteKomponenata.SelectedIndexChanged += new System.EventHandler(this.cmbVrsteKomponenata_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odaberi vrstu komponente:";
            // 
            // btnDodajKomponentu
            // 
            this.btnDodajKomponentu.Location = new System.Drawing.Point(3, 386);
            this.btnDodajKomponentu.Name = "btnDodajKomponentu";
            this.btnDodajKomponentu.Size = new System.Drawing.Size(102, 47);
            this.btnDodajKomponentu.TabIndex = 4;
            this.btnDodajKomponentu.Text = "Dodaj novu komponentu";
            this.btnDodajKomponentu.UseVisualStyleBackColor = true;
            this.btnDodajKomponentu.Click += new System.EventHandler(this.btnDodajKomponentu_Click);
            // 
            // btnAzurirajOdabranu
            // 
            this.btnAzurirajOdabranu.Location = new System.Drawing.Point(111, 387);
            this.btnAzurirajOdabranu.Name = "btnAzurirajOdabranu";
            this.btnAzurirajOdabranu.Size = new System.Drawing.Size(102, 46);
            this.btnAzurirajOdabranu.TabIndex = 5;
            this.btnAzurirajOdabranu.Text = "Ažuriraj odabranu komponentu";
            this.btnAzurirajOdabranu.UseVisualStyleBackColor = true;
            this.btnAzurirajOdabranu.Click += new System.EventHandler(this.btnAzurirajOdabranu_Click);
            // 
            // btnObrisiKomponentu
            // 
            this.btnObrisiKomponentu.Location = new System.Drawing.Point(219, 387);
            this.btnObrisiKomponentu.Name = "btnObrisiKomponentu";
            this.btnObrisiKomponentu.Size = new System.Drawing.Size(102, 46);
            this.btnObrisiKomponentu.TabIndex = 6;
            this.btnObrisiKomponentu.Text = "Obriši odabranu komponentu";
            this.btnObrisiKomponentu.UseVisualStyleBackColor = true;
            this.btnObrisiKomponentu.Click += new System.EventHandler(this.btnObrisiKomponentu_Click);
            // 
            // UCUredivanjeKomponenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisiKomponentu);
            this.Controls.Add(this.btnAzurirajOdabranu);
            this.Controls.Add(this.btnDodajKomponentu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVrsteKomponenata);
            this.Controls.Add(this.dgvUredivanjeKomponenata);
            this.Name = "UCUredivanjeKomponenata";
            this.Size = new System.Drawing.Size(800, 502);
            this.Load += new System.EventHandler(this.UCUredivanjeKomponenata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUredivanjeKomponenata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUredivanjeKomponenata;
        private System.Windows.Forms.ComboBox cmbVrsteKomponenata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajKomponentu;
        private System.Windows.Forms.Button btnAzurirajOdabranu;
        private System.Windows.Forms.Button btnObrisiKomponentu;
    }
}
