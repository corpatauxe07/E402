namespace BoucleForExemple1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDébut = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblIncrément = new System.Windows.Forms.Label();
            this.lblRésultat = new System.Windows.Forms.Label();
            this.rtbRésultat = new System.Windows.Forms.RichTextBox();
            this.tbxDébut = new System.Windows.Forms.TextBox();
            this.tbxFin = new System.Windows.Forms.TextBox();
            this.tbxIncrément = new System.Windows.Forms.TextBox();
            this.btnCompte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDébut
            // 
            this.lblDébut.AutoSize = true;
            this.lblDébut.Location = new System.Drawing.Point(31, 27);
            this.lblDébut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDébut.Name = "lblDébut";
            this.lblDébut.Size = new System.Drawing.Size(42, 13);
            this.lblDébut.TabIndex = 0;
            this.lblDébut.Text = "Début :";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(31, 63);
            this.lblFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(27, 13);
            this.lblFin.TabIndex = 1;
            this.lblFin.Text = "Fin :";
            // 
            // lblIncrément
            // 
            this.lblIncrément.AutoSize = true;
            this.lblIncrément.Location = new System.Drawing.Point(31, 99);
            this.lblIncrément.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncrément.Name = "lblIncrément";
            this.lblIncrément.Size = new System.Drawing.Size(60, 13);
            this.lblIncrément.TabIndex = 2;
            this.lblIncrément.Text = "Incrément :";
            // 
            // lblRésultat
            // 
            this.lblRésultat.AutoSize = true;
            this.lblRésultat.Location = new System.Drawing.Point(31, 137);
            this.lblRésultat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRésultat.Name = "lblRésultat";
            this.lblRésultat.Size = new System.Drawing.Size(52, 13);
            this.lblRésultat.TabIndex = 3;
            this.lblRésultat.Text = "Résultat :";
            // 
            // rtbRésultat
            // 
            this.rtbRésultat.Location = new System.Drawing.Point(91, 135);
            this.rtbRésultat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbRésultat.Name = "rtbRésultat";
            this.rtbRésultat.Size = new System.Drawing.Size(283, 245);
            this.rtbRésultat.TabIndex = 4;
            this.rtbRésultat.Text = "";
            // 
            // tbxDébut
            // 
            this.tbxDébut.Location = new System.Drawing.Point(91, 24);
            this.tbxDébut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxDébut.Name = "tbxDébut";
            this.tbxDébut.Size = new System.Drawing.Size(76, 20);
            this.tbxDébut.TabIndex = 5;
            this.tbxDébut.Text = "1";
            this.tbxDébut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxFin
            // 
            this.tbxFin.Location = new System.Drawing.Point(91, 60);
            this.tbxFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxFin.Name = "tbxFin";
            this.tbxFin.Size = new System.Drawing.Size(76, 20);
            this.tbxFin.TabIndex = 6;
            this.tbxFin.Text = "10";
            this.tbxFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxIncrément
            // 
            this.tbxIncrément.Location = new System.Drawing.Point(91, 97);
            this.tbxIncrément.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxIncrément.Name = "tbxIncrément";
            this.tbxIncrément.Size = new System.Drawing.Size(76, 20);
            this.tbxIncrément.TabIndex = 7;
            this.tbxIncrément.Text = "1";
            this.tbxIncrément.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCompte
            // 
            this.btnCompte.Location = new System.Drawing.Point(205, 97);
            this.btnCompte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompte.Name = "btnCompte";
            this.btnCompte.Size = new System.Drawing.Size(75, 23);
            this.btnCompte.TabIndex = 8;
            this.btnCompte.Text = "Compte";
            this.btnCompte.UseVisualStyleBackColor = true;
            this.btnCompte.Click += new System.EventHandler(this.btnCompte_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 399);
            this.Controls.Add(this.btnCompte);
            this.Controls.Add(this.tbxIncrément);
            this.Controls.Add(this.tbxFin);
            this.Controls.Add(this.tbxDébut);
            this.Controls.Add(this.rtbRésultat);
            this.Controls.Add(this.lblRésultat);
            this.Controls.Add(this.lblIncrément);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblDébut);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrincipal";
            this.Text = "Boucle \"Pour\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDébut;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblIncrément;
        private System.Windows.Forms.Label lblRésultat;
        private System.Windows.Forms.RichTextBox rtbRésultat;
        private System.Windows.Forms.TextBox tbxDébut;
        private System.Windows.Forms.TextBox tbxFin;
        private System.Windows.Forms.TextBox tbxIncrément;
        private System.Windows.Forms.Button btnCompte;
    }
}

