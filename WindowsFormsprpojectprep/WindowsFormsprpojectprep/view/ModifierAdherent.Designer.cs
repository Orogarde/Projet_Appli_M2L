namespace WindowsFormsprpojectprep
{
    partial class ModifierAdherent
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
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.metroButtonAjouter = new MetroFramework.Controls.MetroButton();
            this.maskedTextBoxCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.maskedTextBoxCotisation = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonRetour = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // textBoxN
            // 
            this.textBoxN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxN.Location = new System.Drawing.Point(88, 63);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(125, 20);
            this.textBoxN.TabIndex = 3;
            // 
            // textBoxP
            // 
            this.textBoxP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxP.Location = new System.Drawing.Point(88, 99);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(125, 20);
            this.textBoxP.TabIndex = 4;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVille.Location = new System.Drawing.Point(88, 135);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(125, 20);
            this.textBoxVille.TabIndex = 6;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAdresse.Location = new System.Drawing.Point(88, 214);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(125, 20);
            this.textBoxAdresse.TabIndex = 9;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(244, 112);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 18;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Date";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // metroButtonAjouter
            // 
            this.metroButtonAjouter.Highlight = true;
            this.metroButtonAjouter.Location = new System.Drawing.Point(168, 324);
            this.metroButtonAjouter.Name = "metroButtonAjouter";
            this.metroButtonAjouter.Size = new System.Drawing.Size(158, 52);
            this.metroButtonAjouter.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButtonAjouter.TabIndex = 21;
            this.metroButtonAjouter.Text = "Modifier l\'adherent";
            this.metroButtonAjouter.UseCustomBackColor = true;
            this.metroButtonAjouter.UseSelectable = true;
            this.metroButtonAjouter.UseStyleColors = true;
            this.metroButtonAjouter.Click += new System.EventHandler(this.metroButtonAjouter_Click);
            // 
            // maskedTextBoxCodePostal
            // 
            this.maskedTextBoxCodePostal.Location = new System.Drawing.Point(88, 174);
            this.maskedTextBoxCodePostal.Mask = "00000";
            this.maskedTextBoxCodePostal.Name = "maskedTextBoxCodePostal";
            this.maskedTextBoxCodePostal.Size = new System.Drawing.Size(125, 20);
            this.maskedTextBoxCodePostal.TabIndex = 22;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(40, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Nom :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Prénom :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(42, 136);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = " Ville :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(-4, 175);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(90, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = " Code Postal :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 214);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 19);
            this.metroLabel5.TabIndex = 27;
            this.metroLabel5.Text = " Adresse :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 255);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(78, 19);
            this.metroLabel6.TabIndex = 28;
            this.metroLabel6.Text = " Cotisation :";
            // 
            // maskedTextBoxCotisation
            // 
            this.maskedTextBoxCotisation.Location = new System.Drawing.Point(88, 254);
            this.maskedTextBoxCotisation.Mask = "00000000000000";
            this.maskedTextBoxCotisation.Name = "maskedTextBoxCotisation";
            this.maskedTextBoxCotisation.Size = new System.Drawing.Size(125, 20);
            this.maskedTextBoxCotisation.TabIndex = 29;
            this.maskedTextBoxCotisation.ValidatingType = typeof(int);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(260, 77);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(116, 19);
            this.metroLabel7.TabIndex = 30;
            this.metroLabel7.Text = "Date sélectionner :";
            // 
            // metroButtonRetour
            // 
            this.metroButtonRetour.Highlight = true;
            this.metroButtonRetour.Location = new System.Drawing.Point(398, 18);
            this.metroButtonRetour.Name = "metroButtonRetour";
            this.metroButtonRetour.Size = new System.Drawing.Size(79, 35);
            this.metroButtonRetour.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButtonRetour.TabIndex = 31;
            this.metroButtonRetour.Text = "retour";
            this.metroButtonRetour.UseCustomBackColor = true;
            this.metroButtonRetour.UseSelectable = true;
            this.metroButtonRetour.UseStyleColors = true;
            this.metroButtonRetour.Click += new System.EventHandler(this.metroButtonRetour_Click);
            // 
            // ModifierAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.metroButtonRetour);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.maskedTextBoxCotisation);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.maskedTextBoxCodePostal);
            this.Controls.Add(this.metroButtonAjouter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxN);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ModifierAdherent";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Modifier un adhérent";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ModifierAdherent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroButton metroButtonAjouter;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodePostal;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCotisation;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton metroButtonRetour;
    }
}