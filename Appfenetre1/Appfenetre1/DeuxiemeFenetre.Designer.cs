
namespace Appfenetre1
{
    partial class DeuxiemeFenetre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDeux = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDeux
            // 
            this.labelDeux.AutoSize = true;
            this.labelDeux.Location = new System.Drawing.Point(342, 70);
            this.labelDeux.Name = "labelDeux";
            this.labelDeux.Size = new System.Drawing.Size(35, 13);
            this.labelDeux.TabIndex = 0;
            this.labelDeux.Text = "label1";
            // 
            // DeuxiemeFenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDeux);
            this.Name = "DeuxiemeFenetre";
            this.Text = "Deuxième fenêtre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeux;
    }
}