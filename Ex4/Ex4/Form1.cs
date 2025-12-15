using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Result.Text = "0";
        }


        private void Tb1Value_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                if (Convert.ToDouble(Tb1Value.Text) < 0)
                {
                    MessageBox.Show("Pas de valeur négative", "Fermeture", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Result.Text = Convert.ToString(Convert.ToDouble(Tb1Value.Text) + Convert.ToDouble(Result.Text));
                    Tb1Value.Text = ""; //efface la valeur 
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void donnéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ecrire un programme qui additionne une suite de nombres positifs. Indiquez par un message d'erreur si un nombre negatif est entré.", "Fermeture", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
