namespace PC_for_you.UserControls
{
    partial class UCKosarica
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
            this.dgvKosarica = new System.Windows.Forms.DataGridView();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKosarica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKosarica
            // 
            this.dgvKosarica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKosarica.Location = new System.Drawing.Point(12, 14);
            this.dgvKosarica.Name = "dgvKosarica";
            this.dgvKosarica.Size = new System.Drawing.Size(772, 408);
            this.dgvKosarica.TabIndex = 0;
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(12, 428);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(772, 34);
            this.btnNaruci.TabIndex = 1;
            this.btnNaruci.Text = "Naruči";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(12, 465);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(772, 34);
            this.btnOtkazi.TabIndex = 2;
            this.btnOtkazi.Text = "Otkaži narudžbu";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // UCKosarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.dgvKosarica);
            this.Name = "UCKosarica";
            this.Size = new System.Drawing.Size(797, 502);
            this.Load += new System.EventHandler(this.UCKosarica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKosarica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKosarica;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Button btnOtkazi;
    }
}
