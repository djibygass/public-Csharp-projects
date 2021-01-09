using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace traitementTexttd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            DialogResult dr = SauvegarderDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fileName = SauvegarderDialog.FileName+".txt";
                string txtbx = Contenu.Text;
                File.WriteAllText(fileName,txtbx);
            }
        }

        private void Ouvrir_Click(object sender, EventArgs e)
        {
            DialogResult dr = OuvrirDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fileName = OuvrirDialog.FileName;
                string readtxt = File.ReadAllText(fileName);
                Contenu.Text = readtxt ;
            }
        }
    }
}
