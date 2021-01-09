
namespace Appfenetre1
{
    partial class Home
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
            this.Message = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Valider = new System.Windows.Forms.Button();
            this.Resultat = new System.Windows.Forms.Label();
            this.Naviguer = new System.Windows.Forms.Button();
            this.Connexionbdd = new System.Windows.Forms.Button();
            this.recupUser = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AccessibleName = "Message";
            this.Message.Location = new System.Drawing.Point(309, 12);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(184, 45);
            this.Message.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AccessibleName = "Resultat";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // Valider
            // 
            this.Valider.AccessibleName = "Valider";
            this.Valider.ForeColor = System.Drawing.Color.DarkBlue;
            this.Valider.Location = new System.Drawing.Point(309, 80);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(113, 31);
            this.Valider.TabIndex = 4;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resultat
            // 
            this.Resultat.AutoSize = true;
            this.Resultat.Location = new System.Drawing.Point(289, 159);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(0, 13);
            this.Resultat.TabIndex = 5;
            // 
            // Naviguer
            // 
            this.Naviguer.Location = new System.Drawing.Point(678, 55);
            this.Naviguer.Name = "Naviguer";
            this.Naviguer.Size = new System.Drawing.Size(95, 32);
            this.Naviguer.TabIndex = 6;
            this.Naviguer.Text = "Naviguer";
            this.Naviguer.UseVisualStyleBackColor = true;
            this.Naviguer.Click += new System.EventHandler(this.Naviguer_Click);
            // 
            // Connexionbdd
            // 
            this.Connexionbdd.Location = new System.Drawing.Point(3, 120);
            this.Connexionbdd.Name = "Connexionbdd";
            this.Connexionbdd.Size = new System.Drawing.Size(113, 23);
            this.Connexionbdd.TabIndex = 7;
            this.Connexionbdd.Text = "Ajouter utilisateur";
            this.Connexionbdd.UseVisualStyleBackColor = true;
            this.Connexionbdd.Click += new System.EventHandler(this.Connexionbdd_Click);
            // 
            // recupUser
            // 
            this.recupUser.Location = new System.Drawing.Point(0, 172);
            this.recupUser.Name = "recupUser";
            this.recupUser.Size = new System.Drawing.Size(116, 23);
            this.recupUser.TabIndex = 8;
            this.recupUser.Text = "récup user";
            this.recupUser.UseVisualStyleBackColor = true;
            this.recupUser.Click += new System.EventHandler(this.recupUser_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 261);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(166, 20);
            this.tb_id.TabIndex = 9;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(12, 233);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(15, 13);
            this.label_id.TabIndex = 10;
            this.label_id.Text = "id";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.recupUser);
            this.Controls.Add(this.Connexionbdd);
            this.Controls.Add(this.Naviguer);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Message);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Label Resultat;
        private System.Windows.Forms.Button Naviguer;
        private System.Windows.Forms.Button Connexionbdd;
        private System.Windows.Forms.Button recupUser;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label_id;
    }
}

