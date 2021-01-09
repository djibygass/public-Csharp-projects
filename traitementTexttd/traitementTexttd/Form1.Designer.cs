
namespace traitementTexttd
{
    partial class Form1
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
            this.Contenu = new System.Windows.Forms.TextBox();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Ouvrir = new System.Windows.Forms.Button();
            this.OuvrirDialog = new System.Windows.Forms.OpenFileDialog();
            this.SauvegarderDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Contenu
            // 
            this.Contenu.Location = new System.Drawing.Point(252, 37);
            this.Contenu.Multiline = true;
            this.Contenu.Name = "Contenu";
            this.Contenu.Size = new System.Drawing.Size(324, 79);
            this.Contenu.TabIndex = 0;
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(252, 162);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(83, 26);
            this.Enregistrer.TabIndex = 1;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Ouvrir
            // 
            this.Ouvrir.Location = new System.Drawing.Point(492, 162);
            this.Ouvrir.Name = "Ouvrir";
            this.Ouvrir.Size = new System.Drawing.Size(83, 25);
            this.Ouvrir.TabIndex = 2;
            this.Ouvrir.Text = "Ouvrir";
            this.Ouvrir.UseVisualStyleBackColor = true;
            this.Ouvrir.Click += new System.EventHandler(this.Ouvrir_Click);
            // 
            // OuvrirDialog
            // 
            this.OuvrirDialog.FileName = "openFileDialog1";
            this.OuvrirDialog.Filter = "|*.txt";
            this.OuvrirDialog.Title = "Ouvrir un fichier";
            // 
            // SauvegarderDialog
            // 
            this.SauvegarderDialog.Title = "Sauvegarder le fichier";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ouvrir);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.Contenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Contenu;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Ouvrir;
        private System.Windows.Forms.OpenFileDialog OuvrirDialog;
        private System.Windows.Forms.SaveFileDialog SauvegarderDialog;
    }
}

