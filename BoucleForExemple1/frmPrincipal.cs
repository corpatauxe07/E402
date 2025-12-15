/* Sujet  : Exemple de la boucle "Pour"
 * Auteur : 
 * Date   : 
 * Dernière modif. : 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoucleForExemple1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCompte_Click(object sender, EventArgs e)
        {
            rtbRésultat.Clear(); // Efface le contenu du RichTextBox pour une nouvelle exécution

            // Mise en variables des données entrées par l'utilisateurs
            //int debut = int.Parse(tbxDébut.Text);           // Valeur initiale du compteur de boucle
            //int fin = int.Parse(tbxFin.Text);               // Valeur finale du compteur de boucle
            //int increment = int.Parse(tbxIncrément.Text);   // Incrément du compteur à chaque passage dans la boucle

            // Exécution de la boucle "Pour"
            for (Double i = Convert.ToDouble(tbxDébut.Text); i <= Convert.ToDouble(tbxFin.Text); i+=Convert.ToDouble(tbxIncrément.Text))
            {
                
                // Affichage de la valeur du compteur de boucle à chaque itération
                rtbRésultat.Text += i.ToString() + Environment.NewLine;
                
            }

            // Affichage de la valeur du compteur après la fin de la boucle
            rtbRésultat.Text += "Après la sortie de la boucle, le compteur vaut : " + Convert.ToString((Convert.ToDouble(tbxFin.Text)+Convert.ToDouble(tbxIncrément.Text)));
        }
    }
}
