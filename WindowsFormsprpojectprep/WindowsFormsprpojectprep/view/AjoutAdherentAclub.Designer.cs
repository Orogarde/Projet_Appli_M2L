namespace WindowsFormsprpojectprep
{
    partial class AjoutAdherentAclub
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
            this.listBoxAdherents = new System.Windows.Forms.ListBox();
            this.listBoxClubs = new System.Windows.Forms.ListBox();
            this.metroButtonAjout = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonRetour = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBoxAdherents
            // 
            this.listBoxAdherents.BackColor = System.Drawing.Color.Teal;
            this.listBoxAdherents.ForeColor = System.Drawing.Color.White;
            this.listBoxAdherents.FormattingEnabled = true;
            this.listBoxAdherents.Location = new System.Drawing.Point(23, 99);
            this.listBoxAdherents.Name = "listBoxAdherents";
            this.listBoxAdherents.Size = new System.Drawing.Size(137, 173);
            this.listBoxAdherents.TabIndex = 0;
            this.listBoxAdherents.SelectedIndexChanged += new System.EventHandler(this.listBoxAdherents_SelectedIndexChanged);
            // 
            // listBoxClubs
            // 
            this.listBoxClubs.BackColor = System.Drawing.Color.Teal;
            this.listBoxClubs.ForeColor = System.Drawing.Color.White;
            this.listBoxClubs.FormattingEnabled = true;
            this.listBoxClubs.Location = new System.Drawing.Point(353, 99);
            this.listBoxClubs.Name = "listBoxClubs";
            this.listBoxClubs.Size = new System.Drawing.Size(133, 173);
            this.listBoxClubs.TabIndex = 1;
            this.listBoxClubs.SelectedIndexChanged += new System.EventHandler(this.listBoxClubs_SelectedIndexChanged);
            // 
            // metroButtonAjout
            // 
            this.metroButtonAjout.Highlight = true;
            this.metroButtonAjout.Location = new System.Drawing.Point(169, 295);
            this.metroButtonAjout.Name = "metroButtonAjout";
            this.metroButtonAjout.Size = new System.Drawing.Size(173, 35);
            this.metroButtonAjout.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButtonAjout.TabIndex = 3;
            this.metroButtonAjout.Text = "Ajoutrer un adhérent à un club";
            this.metroButtonAjout.UseCustomBackColor = true;
            this.metroButtonAjout.UseSelectable = true;
            this.metroButtonAjout.UseStyleColors = true;
            this.metroButtonAjout.Click += new System.EventHandler(this.metroButtonAjout_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(369, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Liste des Clubs : ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Liste des adhérents :";
            // 
            // metroButtonRetour
            // 
            this.metroButtonRetour.Highlight = true;
            this.metroButtonRetour.Location = new System.Drawing.Point(407, 295);
            this.metroButtonRetour.Name = "metroButtonRetour";
            this.metroButtonRetour.Size = new System.Drawing.Size(79, 35);
            this.metroButtonRetour.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButtonRetour.TabIndex = 6;
            this.metroButtonRetour.Text = "retour";
            this.metroButtonRetour.UseCustomBackColor = true;
            this.metroButtonRetour.UseSelectable = true;
            this.metroButtonRetour.UseStyleColors = true;
            this.metroButtonRetour.Click += new System.EventHandler(this.metroButtonRetour_Click);
            // 
            // AjoutAdherentAclub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 339);
            this.Controls.Add(this.metroButtonRetour);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonAjout);
            this.Controls.Add(this.listBoxClubs);
            this.Controls.Add(this.listBoxAdherents);
            this.MaximumSize = new System.Drawing.Size(509, 339);
            this.MinimumSize = new System.Drawing.Size(509, 339);
            this.Name = "AjoutAdherentAclub";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Ajouter un adhérent à club";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AjoutAdherentAclub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAdherents;
        private System.Windows.Forms.ListBox listBoxClubs;
        private MetroFramework.Controls.MetroButton metroButtonAjout;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButtonRetour;
    }
}