namespace DémoThis2
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
            this.btnModifierLabel = new System.Windows.Forms.Button();
            this.lblAffichage = new System.Windows.Forms.Label();
            this.btnModifierTitre = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModifierLabel
            // 
            this.btnModifierLabel.Location = new System.Drawing.Point(27, 122);
            this.btnModifierLabel.Name = "btnModifierLabel";
            this.btnModifierLabel.Size = new System.Drawing.Size(81, 23);
            this.btnModifierLabel.TabIndex = 0;
            this.btnModifierLabel.Text = "Modifier label";
            this.btnModifierLabel.UseVisualStyleBackColor = true;
            this.btnModifierLabel.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // lblAffichage
            // 
            this.lblAffichage.AutoSize = true;
            this.lblAffichage.Location = new System.Drawing.Point(69, 67);
            this.lblAffichage.Name = "lblAffichage";
            this.lblAffichage.Size = new System.Drawing.Size(59, 13);
            this.lblAffichage.TabIndex = 1;
            this.lblAffichage.Text = "Texte label";
            // 
            // btnModifierTitre
            // 
            this.btnModifierTitre.Location = new System.Drawing.Point(151, 122);
            this.btnModifierTitre.Name = "btnModifierTitre";
            this.btnModifierTitre.Size = new System.Drawing.Size(75, 23);
            this.btnModifierTitre.TabIndex = 2;
            this.btnModifierTitre.Text = "Modifier titre";
            this.btnModifierTitre.UseVisualStyleBackColor = true;
            this.btnModifierTitre.Click += new System.EventHandler(this.btnModifierTitre_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(105, 191);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 239);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnModifierTitre);
            this.Controls.Add(this.lblAffichage);
            this.Controls.Add(this.btnModifierLabel);
            this.Name = "frmPrincipal";
            this.Text = "Titre du formulaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifierLabel;
        private System.Windows.Forms.Label lblAffichage;
        private System.Windows.Forms.Button btnModifierTitre;
        private System.Windows.Forms.Button btnFermer;
    }
}

