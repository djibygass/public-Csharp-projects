using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Appfenetre1
{
    public partial class Home : Form
    {
       private static MySqlConnection conn = new MySqlConnection("database=test;server=localhost;user id = root; pwd=");
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string messageSaisit = Message.Text;
            Resultat.Text = messageSaisit;
            Random rnd = new Random();
            int r = rnd.Next(0, 256);
            int g = rnd.Next(0, 256);
            int b = rnd.Next(0, 256);
            Color color = Color.FromArgb(r, g, b);
            Resultat.ForeColor = color;

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Naviguer_Click(object sender, EventArgs e)
        {
           DeuxiemeFenetre fenetre2 = new DeuxiemeFenetre(Resultat.Text);
           fenetre2.Show();
        }

        private void Connexionbdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();

                command.Parameters.AddWithValue("@nom", Message.Text);
                command.CommandText = "INSERT INTO Personnes (nom) VALUES (@nom)";
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Insertion effectuée");
                }
                else
                {
                    MessageBox.Show("Insertion échouée");
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("connexion échouée");
            }
           

        }

        private void recupUser_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();

                int iduser = Convert.ToInt32(tb_id.Text);

                command.Parameters.AddWithValue("@id", iduser);
                command.CommandText = "SELECT nom FROM  Personnes WHERE id = (@id)";

                MySqlDataReader reader = command.ExecuteReader();
         
                while (reader.Read())
                {
                    MessageBox.Show(reader.GetString(0));
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("connexion échouée");
            }
           
        }
    }
}
