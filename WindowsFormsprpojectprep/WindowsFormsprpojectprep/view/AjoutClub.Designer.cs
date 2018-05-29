namespace WindowsFormsprpojectprep
{
    partial class AjoutClub
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
            this.textBoxtitre = new System.Windows.Forms.TextBox();
            this.TextBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroButtonAjout = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.metroButtonRetour = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // textBoxtitre
            // 
            this.textBoxtitre.Location = new System.Drawing.Point(97, 82);
            this.textBoxtitre.Name = "textBoxtitre";
            this.textBoxtitre.Size = new System.Drawing.Size(100, 20);
            this.textBoxtitre.TabIndex = 0;
            // 
            // TextBoxVille
            // 
            this.TextBoxVille.Location = new System.Drawing.Point(97, 183);
            this.TextBoxVille.Name = "TextBoxVille";
            this.TextBoxVille.Size = new System.Drawing.Size(100, 20);
            this.TextBoxVille.TabIndex = 1;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(97, 209);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxMail.TabIndex = 2;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(97, 131);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdresse.TabIndex = 4;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(97, 105);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(100, 20);
            this.textBoxUrl.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Teal;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(351, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 18;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // metroButtonAjout
            // 
            this.metroButtonAjout.Highlight = true;
            this.metroButtonAjout.Location = new System.Drawing.Point(213, 264);
            this.metroButtonAjout.Name = "metroButtonAjout";
            this.metroButtonAjout.Size = new System.Drawing.Size(96, 31);
            this.metroButtonAjout.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButtonAjout.TabIndex = 19;
            this.metroButtonAjout.Text = "Ajouter un club";
            this.metroButtonAjout.UseCustomBackColor = true;
            this.metroButtonAjout.UseSelectable = true;
            this.metroButtonAjout.UseStyleColors = true;
            this.metroButtonAjout.Click += new System.EventHandler(this.metroButtonAjout_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(51, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Titre :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "Adresse :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(59, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(33, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Url :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(5, 156);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 19);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "Code Postal :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(50, 182);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "Ville : ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(49, 208);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Mail :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(14, 234);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(75, 19);
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Téléphone :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(317, 69);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(183, 19);
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Sélectionner un Type de club :";
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(97, 235);
            this.maskedTextBoxTel.Mask = "00 00 00 00 00 00";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTel.TabIndex = 28;
            // 
            // maskedTextBoxCodePostal
            // 
            this.maskedTextBoxCodePostal.Location = new System.Drawing.Point(97, 157);
            this.maskedTextBoxCodePostal.Mask = "00000";
            this.maskedTextBoxCodePostal.Name = "maskedTextBoxCodePostal";
            this.maskedTextBoxCodePostal.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCodePostal.TabIndex = 29;
            // 
            // metroButtonRetour
            // 
            this.metroButtonRetour.Highlight = true;
            this.metroButtonRetour.Location = new System.Drawing.Point(369, 264);
            this.metroButtonRetour.Name = "metroButtonRetour";
            this.metroButtonRetour.Size = new System.Drawing.Size(79, 35);
            this.metroButtonRetour.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButtonRetour.TabIndex = 30;
            this.metroButtonRetour.Text = "retour";
            this.metroButtonRetour.UseCustomBackColor = true;
            this.metroButtonRetour.UseSelectable = true;
            this.metroButtonRetour.UseStyleColors = true;
            this.metroButtonRetour.Click += new System.EventHandler(this.metroButtonRetour_Click);
            // 
            // AjoutClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 318);
            this.Controls.Add(this.metroButtonRetour);
            this.Controls.Add(this.maskedTextBoxCodePostal);
            this.Controls.Add(this.maskedTextBoxTel);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonAjout);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.TextBoxVille);
            this.Controls.Add(this.textBoxtitre);
            this.MaximumSize = new System.Drawing.Size(521, 318);
            this.MinimumSize = new System.Drawing.Size(521, 318);
            this.Name = "AjoutClub";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Ajouter un Club";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AjoutClub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxtitre;
        private System.Windows.Forms.TextBox TextBoxVille;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton metroButtonAjout;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodePostal;
        private MetroFramework.Controls.MetroButton metroButtonRetour;
    }
}