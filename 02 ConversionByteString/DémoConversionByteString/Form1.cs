/* Sujet    : Conversion de byte en string et de string en byte
 * Auteur   : Michel Berset
 * Remarque : voir illustrations sur le document "HID et conversion chaîne de caractères - nombre.notebook.pdf"
 * Date     : 19.05.2020
 * Dernière modif. : 09.12.2025
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

namespace DémoConversionByteString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            byte age;   // Déclaration d'une variable age de type byte


            // Conversion d'une chaîne de caractères (de type string) en une valeur numérique de type byte :

            age = Convert.ToByte(tbxAge.Text);  // 1ère possibilité, avec Convert.To (qui n'accepte que les noms de type .NET)

            age = byte.Parse(tbxAge.Text);      // 2ème possibilité, avec .Parse (qui accepte les noms de type C# et .NET)
            age = Byte.Parse(tbxAge.Text);      //  idem mais avec le nom de type .NET


            // Opération mathématique sur le nombre :
            age += 2;


            // Conversion d'une valeur numérique de type byte en une chaîne de caractères (de type string) :

            lblAffichage.Text = Convert.ToString(age);  // 1ère possibilité, avec Convert.To

            lblAffichage.Text = age.ToString();         // 2ème possibilité, avec .ToString

        }
    }
}
