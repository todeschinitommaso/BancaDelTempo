namespace BancaDelTempo
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDebito = new System.Windows.Forms.Button();
            this.btnSegreteria = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnOrdinaPrestazioni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPrestazioni = new System.Windows.Forms.ListBox();
            this.lstDebito = new System.Windows.Forms.ListBox();
            this.lstSegreteria = new System.Windows.Forms.ListBox();
            this.lstSoci = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(237, 21);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(142, 23);
            this.btnDebito.TabIndex = 3;
            this.btnDebito.Text = "DEBITO";
            this.btnDebito.UseVisualStyleBackColor = true;
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click);
            // 
            // btnSegreteria
            // 
            this.btnSegreteria.Location = new System.Drawing.Point(441, 21);
            this.btnSegreteria.Name = "btnSegreteria";
            this.btnSegreteria.Size = new System.Drawing.Size(142, 23);
            this.btnSegreteria.TabIndex = 4;
            this.btnSegreteria.Text = "SEGRETERIA";
            this.btnSegreteria.UseVisualStyleBackColor = true;
            this.btnSegreteria.Click += new System.EventHandler(this.btnSegreteria_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(612, 422);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(194, 23);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnOrdinaPrestazioni
            // 
            this.btnOrdinaPrestazioni.Location = new System.Drawing.Point(43, 21);
            this.btnOrdinaPrestazioni.Name = "btnOrdinaPrestazioni";
            this.btnOrdinaPrestazioni.Size = new System.Drawing.Size(142, 23);
            this.btnOrdinaPrestazioni.TabIndex = 12;
            this.btnOrdinaPrestazioni.Text = "PRESTAZIONI";
            this.btnOrdinaPrestazioni.UseVisualStyleBackColor = true;
            this.btnOrdinaPrestazioni.Click += new System.EventHandler(this.btnOrdinaPrestazioni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "SOCI";
            // 
            // lstPrestazioni
            // 
            this.lstPrestazioni.FormattingEnabled = true;
            this.lstPrestazioni.Location = new System.Drawing.Point(12, 64);
            this.lstPrestazioni.Name = "lstPrestazioni";
            this.lstPrestazioni.Size = new System.Drawing.Size(394, 186);
            this.lstPrestazioni.TabIndex = 17;
            // 
            // lstDebito
            // 
            this.lstDebito.FormattingEnabled = true;
            this.lstDebito.Location = new System.Drawing.Point(12, 259);
            this.lstDebito.Name = "lstDebito";
            this.lstDebito.Size = new System.Drawing.Size(394, 186);
            this.lstDebito.TabIndex = 18;
            // 
            // lstSegreteria
            // 
            this.lstSegreteria.FormattingEnabled = true;
            this.lstSegreteria.Location = new System.Drawing.Point(412, 64);
            this.lstSegreteria.Name = "lstSegreteria";
            this.lstSegreteria.Size = new System.Drawing.Size(194, 381);
            this.lstSegreteria.TabIndex = 19;
            // 
            // lstSoci
            // 
            this.lstSoci.FormattingEnabled = true;
            this.lstSoci.Location = new System.Drawing.Point(612, 64);
            this.lstSoci.Name = "lstSoci";
            this.lstSoci.Size = new System.Drawing.Size(194, 355);
            this.lstSoci.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 458);
            this.Controls.Add(this.lstSoci);
            this.Controls.Add(this.lstSegreteria);
            this.Controls.Add(this.lstDebito);
            this.Controls.Add(this.lstPrestazioni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrdinaPrestazioni);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSegreteria);
            this.Controls.Add(this.btnDebito);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.Button btnSegreteria;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnOrdinaPrestazioni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPrestazioni;
        private System.Windows.Forms.ListBox lstDebito;
        private System.Windows.Forms.ListBox lstSegreteria;
        private System.Windows.Forms.ListBox lstSoci;
    }
}

