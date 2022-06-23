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
            // UCKomponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
