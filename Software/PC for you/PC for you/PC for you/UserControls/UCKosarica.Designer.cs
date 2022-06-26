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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxUkupno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKosarica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKosarica
            // 
            this.dgvKosarica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKosarica.Location = new System.Drawing.Point(12, 14);
            this.dgvKosarica.Name = "dgvKosarica";
            this.dgvKosarica.Size = new System.Drawing.Size(772, 371);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ukupno:";
            // 
            // tboxUkupno
            // 
            this.tboxUkupno.Enabled = false;
            this.tboxUkupno.Location = new System.Drawing.Point(352, 399);
            this.tboxUkupno.Name = "tboxUkupno";
            this.tboxUkupno.Size = new System.Drawing.Size(100, 20);
            this.tboxUkupno.TabIndex = 4;
            // 
            // UCKosarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tboxUkupno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.dgvKosarica);
            this.Name = "UCKosarica";
            this.Size = new System.Drawing.Size(797, 502);
            this.Load += new System.EventHandler(this.UCKosarica_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.UCKosarica_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKosarica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKosarica;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxUkupno;
    }
}
