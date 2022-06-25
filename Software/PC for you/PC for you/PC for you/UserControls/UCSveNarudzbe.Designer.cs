namespace PC_for_you.UserControls
{
    partial class UCSveNarudzbe
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetaljiSveNarudzbe = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvodac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSveNarudzbe = new System.Windows.Forms.DataGridView();
            this.btnObrisiNarudzbu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiSveNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Detalji narudžbe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sve narudžbe:";
            // 
            // dgvDetaljiSveNarudzbe
            // 
            this.dgvDetaljiSveNarudzbe.AllowUserToAddRows = false;
            this.dgvDetaljiSveNarudzbe.AllowUserToDeleteRows = false;
            this.dgvDetaljiSveNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetaljiSveNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Kolicina,
            this.Tip,
            this.Proizvodac,
            this.Cijena});
            this.dgvDetaljiSveNarudzbe.Location = new System.Drawing.Point(3, 294);
            this.dgvDetaljiSveNarudzbe.Name = "dgvDetaljiSveNarudzbe";
            this.dgvDetaljiSveNarudzbe.ReadOnly = true;
            this.dgvDetaljiSveNarudzbe.Size = new System.Drawing.Size(794, 204);
            this.dgvDetaljiSveNarudzbe.TabIndex = 7;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 150;
            // 
            // Kolicina
            // 
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            this.Kolicina.Width = 150;
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Tip";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            this.Tip.Width = 150;
            // 
            // Proizvodac
            // 
            this.Proizvodac.HeaderText = "Proizvođač";
            this.Proizvodac.Name = "Proizvodac";
            this.Proizvodac.ReadOnly = true;
            this.Proizvodac.Width = 150;
            // 
            // Cijena
            // 
            this.Cijena.HeaderText = "Jedinična cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 150;
            // 
            // dgvSveNarudzbe
            // 
            this.dgvSveNarudzbe.AllowUserToAddRows = false;
            this.dgvSveNarudzbe.AllowUserToDeleteRows = false;
            this.dgvSveNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSveNarudzbe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSveNarudzbe.Location = new System.Drawing.Point(3, 33);
            this.dgvSveNarudzbe.Name = "dgvSveNarudzbe";
            this.dgvSveNarudzbe.ReadOnly = true;
            this.dgvSveNarudzbe.Size = new System.Drawing.Size(633, 204);
            this.dgvSveNarudzbe.TabIndex = 6;
            this.dgvSveNarudzbe.SelectionChanged += new System.EventHandler(this.dgvSveNarudzbe_SelectionChanged);
            // 
            // btnObrisiNarudzbu
            // 
            this.btnObrisiNarudzbu.Location = new System.Drawing.Point(661, 33);
            this.btnObrisiNarudzbu.Name = "btnObrisiNarudzbu";
            this.btnObrisiNarudzbu.Size = new System.Drawing.Size(136, 54);
            this.btnObrisiNarudzbu.TabIndex = 10;
            this.btnObrisiNarudzbu.Text = "Obriši odabranu narudžbu";
            this.btnObrisiNarudzbu.UseVisualStyleBackColor = true;
            this.btnObrisiNarudzbu.Click += new System.EventHandler(this.btnObrisiNarudzbu_Click);
            // 
            // UCSveNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisiNarudzbu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetaljiSveNarudzbe);
            this.Controls.Add(this.dgvSveNarudzbe);
            this.Name = "UCSveNarudzbe";
            this.Size = new System.Drawing.Size(800, 502);
            this.Load += new System.EventHandler(this.UCSveNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiSveNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetaljiSveNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvodac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridView dgvSveNarudzbe;
        private System.Windows.Forms.Button btnObrisiNarudzbu;
    }
}
