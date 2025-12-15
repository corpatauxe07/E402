/* Sujet  : Démonstration de l'utilisation du "this"
 * Auteur : Michel Berset
 * Date   : 12.12.2014
 * Dernière modif. : 02.12.2024
 */
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DémoThis2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            // Afficher "Salut" dans le label "lblAffichage" = modifier la propriété "Text" de l'objet "lblAffichage"
            lblAffichage.Text = "Salut";
        }

        private void btnModifierTitre_Click(object sender, EventArgs e)
        {
            // Afficher "Bonjour" dans la barre de titre = modifier la propriété "Text" de... l'objet (formulaire) qui n'existe
            //   pas encore et dont on ne connait pas encore le nom au moment d'écrire cette instruction

            // frmPrincipal.Text = "Bonjour"; // Ne fonctionne pas car "frmPrincipal" est le nom du modèle, pas de l'objet dont
            //   on veut modifier le titre !

            this.Text = "Bonjour";  // Modifie la propriété "Text" de l'objet (formulaire) courant qui ne sera créé et
                                    //   qui n'aura un nom que lors de l'exécution
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();   // Ferme ce formulaire
        }
    }
}
