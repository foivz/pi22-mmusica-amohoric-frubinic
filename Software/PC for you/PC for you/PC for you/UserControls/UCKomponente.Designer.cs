namespace PC_for_you.UserControls
{
    partial class UCKomponente
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
            this.cboxKomponente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKomponente = new System.Windows.Forms.DataGridView();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.btnSloziRacunalo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxKomponenta = new System.Windows.Forms.ListBox();
            this.btnOdaberiKomponentu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomponente)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxKomponente
            // 
            this.cboxKomponente.FormattingEnabled = true;
            this.cboxKomponente.Location = new System.Drawing.Point(132, 34);
            this.cboxKomponente.Name = "cboxKomponente";
            this.cboxKomponente.Size = new System.Drawing.Size(210, 21);
            this.cboxKomponente.TabIndex = 0;
            this.cboxKomponente.SelectedIndexChanged += new System.EventHandler(this.cboxKomponente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tip komponente:";
            // 
            // dgvKomponente
            // 
            this.dgvKomponente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomponente.Location = new System.Drawing.Point(30, 115);
            this.dgvKomponente.Name = "dgvKomponente";
            this.dgvKomponente.Size = new System.Drawing.Size(746, 304);
            this.dgvKomponente.TabIndex = 2;
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(378, 32);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(196, 23);
            this.btnNaruci.TabIndex = 3;
            this.btnNaruci.Text = "Naruči odabranu komponentu";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // btnSloziRacunalo
            // 
            this.btnSloziRacunalo.Location = new System.Drawing.Point(580, 32);
            this.btnSloziRacunalo.Name = "btnSloziRacunalo";
            this.btnSloziRacunalo.Size = new System.Drawing.Size(196, 23);
            this.btnSloziRacunalo.TabIndex = 4;
            this.btnSloziRacunalo.Text = "Složi svoje računalo";
            this.btnSloziRacunalo.UseVisualStyleBackColor = true;
            this.btnSloziRacunalo.Click += new System.EventHandler(this.btnSloziRacunalo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Odabrana komponenta:";
            // 
            // listBoxKomponenta
            // 
            this.listBoxKomponenta.FormattingEnabled = true;
            this.listBoxKomponenta.Location = new System.Drawing.Point(598, 449);
            this.listBoxKomponenta.Name = "listBoxKomponenta";
            this.listBoxKomponenta.Size = new System.Drawing.Size(178, 17);
            this.listBoxKomponenta.TabIndex = 8;
            this.listBoxKomponenta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxKomponenta_MouseDown);
            // 
            // btnOdaberiKomponentu
            // 
            this.btnOdaberiKomponentu.Location = new System.Drawing.Point(598, 473);
            this.btnOdaberiKomponentu.Name = "btnOdaberiKomponentu";
            this.btnOdaberiKomponentu.Size = new System.Drawing.Size(178, 23);
            this.btnOdaberiKomponentu.TabIndex = 9;
            this.btnOdaberiKomponentu.Text = "Odaberi komponentu";
            this.btnOdaberiKomponentu.UseVisualStyleBackColor = true;
            this.btnOdaberiKomponentu.Click += new System.EventHandler(this.btnOdaberiKomponentu_Click);
            // 
            // UCKomponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOdaberiKomponentu);
            this.Controls.Add(this.listBoxKomponenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSloziRacunalo);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.dgvKomponente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxKomponente);
            this.Name = "UCKomponente";
            this.Size = new System.Drawing.Size(800, 502);
            this.Load += new System.EventHandler(this.UCKomponente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomponente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxKomponente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKomponente;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Button btnSloziRacunalo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxKomponenta;
        private System.Windows.Forms.Button btnOdaberiKomponentu;
    }
}
