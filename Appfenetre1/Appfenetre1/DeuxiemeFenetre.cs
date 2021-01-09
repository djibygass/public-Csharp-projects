using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appfenetre1
{
    public partial class DeuxiemeFenetre : Form
    {
        public DeuxiemeFenetre(string texte)
        {
            InitializeComponent();
            labelDeux.Text = texte;
        }
    }
}
