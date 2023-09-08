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
            this.lstPrestazioni = new System.Windows.Forms.ListView();
            this.namecol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surnamecol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cellcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDebito = new System.Windows.Forms.Button();
            this.btnSegreteria = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnOrdinaPrestazioni = new System.Windows.Forms.Button();
            this.lstDebito = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSegreteria = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSoci = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPrestazioni
            // 
            this.lstPrestazioni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namecol,
            this.surnamecol,
            this.cellcol});
            this.lstPrestazioni.HideSelection = false;
            this.lstPrestazioni.Location = new System.Drawing.Point(26, 64);
            this.lstPrestazioni.Name = "lstPrestazioni";
            this.lstPrestazioni.Size = new System.Drawing.Size(180, 378);
            this.lstPrestazioni.TabIndex = 0;
            this.lstPrestazioni.UseCompatibleStateImageBehavior = false;
            // 
            // namecol
            // 
            this.namecol.Text = "NOME";
            this.namecol.Width = 120;
            // 
            // surnamecol
            // 
            this.surnamecol.Text = "COGNOME";
            this.surnamecol.Width = 166;
            // 
            // cellcol
            // 
            this.cellcol.Text = "TELEFONO";
            this.cellcol.Width = 133;
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(226, 21);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(142, 23);
            this.btnDebito.TabIndex = 3;
            this.btnDebito.Text = "DEBITO";
            this.btnDebito.UseVisualStyleBackColor = true;
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click);
            // 
            // btnSegreteria
            // 
            this.btnSegreteria.Location = new System.Drawing.Point(417, 21);
            this.btnSegreteria.Name = "btnSegreteria";
            this.btnSegreteria.Size = new System.Drawing.Size(142, 23);
            this.btnSegreteria.TabIndex = 4;
            this.btnSegreteria.Text = "SEGRETERIA";
            this.btnSegreteria.UseVisualStyleBackColor = true;
            this.btnSegreteria.Click += new System.EventHandler(this.btnSegreteria_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(585, 419);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(180, 23);
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
            // lstDebito
            // 
            this.lstDebito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstDebito.HideSelection = false;
            this.lstDebito.Location = new System.Drawing.Point(212, 64);
            this.lstDebito.Name = "lstDebito";
            this.lstDebito.Size = new System.Drawing.Size(180, 378);
            this.lstDebito.TabIndex = 13;
            this.lstDebito.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NOME";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "COGNOME";
            this.columnHeader2.Width = 166;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TELEFONO";
            this.columnHeader3.Width = 133;
            // 
            // lstSegreteria
            // 
            this.lstSegreteria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstSegreteria.HideSelection = false;
            this.lstSegreteria.Location = new System.Drawing.Point(398, 64);
            this.lstSegreteria.Name = "lstSegreteria";
            this.lstSegreteria.Size = new System.Drawing.Size(180, 378);
            this.lstSegreteria.TabIndex = 14;
            this.lstSegreteria.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NOME";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "COGNOME";
            this.columnHeader5.Width = 166;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TELEFONO";
            this.columnHeader6.Width = 133;
            // 
            // lstSoci
            // 
            this.lstSoci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lstSoci.HideSelection = false;
            this.lstSoci.Location = new System.Drawing.Point(585, 65);
            this.lstSoci.Name = "lstSoci";
            this.lstSoci.Size = new System.Drawing.Size(180, 348);
            this.lstSoci.TabIndex = 15;
            this.lstSoci.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "NOME";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "COGNOME";
            this.columnHeader8.Width = 166;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "TELEFONO";
            this.columnHeader9.Width = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "SOCI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSoci);
            this.Controls.Add(this.lstSegreteria);
            this.Controls.Add(this.lstDebito);
            this.Controls.Add(this.btnOrdinaPrestazioni);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSegreteria);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.lstPrestazioni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPrestazioni;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.Button btnSegreteria;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ColumnHeader namecol;
        private System.Windows.Forms.ColumnHeader surnamecol;
        private System.Windows.Forms.ColumnHeader cellcol;
        private System.Windows.Forms.Button btnOrdinaPrestazioni;
        private System.Windows.Forms.ListView lstDebito;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstSegreteria;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lstSoci;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label1;
    }
}

