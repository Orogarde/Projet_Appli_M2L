namespace WindowsFormsprpojectprep
{
    partial class AjoutEvenement
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
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.monthCalendarDebut = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarFin = new System.Windows.Forms.MonthCalendar();
            this.listBoxClub = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonAjout = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Location = new System.Drawing.Point(150, 97);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(96, 20);
            this.textBoxTitre.TabIndex = 0;
            // 
            // monthCalendarDebut
            // 
            this.monthCalendarDebut.Location = new System.Drawing.Point(19, 146);
            this.monthCalendarDebut.Name = "monthCalendarDebut";
            this.monthCalendarDebut.TabIndex = 1;
            // 
            // monthCalendarFin
            // 
            this.monthCalendarFin.Location = new System.Drawing.Point(313, 146);
            this.monthCalendarFin.Name = "monthCalendarFin";
            this.monthCalendarFin.TabIndex = 2;
            // 
            // listBoxClub
            // 
            this.listBoxClub.BackColor = System.Drawing.Color.Teal;
            this.listBoxClub.ForeColor = System.Drawing.Color.White;
            this.listBoxClub.FormattingEnabled = true;
            this.listBoxClub.Location = new System.Drawing.Point(420, 78);
            this.listBoxClub.Name = "listBoxClub";
            this.listBoxClub.Size = new System.Drawing.Size(120, 56);
            this.listBoxClub.TabIndex = 4;
            this.listBoxClub.SelectedIndexChanged += new System.EventHandler(this.listBoxClub_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(289, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(129, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Sélectionner un club:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(135, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Titre de l\'événement :";
            // 
            // metroButtonAjout
            // 
            this.metroButtonAjout.Highlight = true;
            this.metroButtonAjout.Location = new System.Drawing.Point(207, 342);
            this.metroButtonAjout.Name = "metroButtonAjout";
            this.metroButtonAjout.Size = new System.Drawing.Size(145, 23);
            this.metroButtonAjout.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButtonAjout.TabIndex = 7;
            this.metroButtonAjout.Text = "Ajouter un événement";
            this.metroButtonAjout.UseCustomBackColor = true;
            this.metroButtonAjout.UseSelectable = true;
            this.metroButtonAjout.UseStyleColors = true;
            this.metroButtonAjout.Click += new System.EventHandler(this.metroButtonAjout_Click);
            // 
            // AjoutEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 378);
            this.Controls.Add(this.metroButtonAjout);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBoxClub);
            this.Controls.Add(this.monthCalendarFin);
            this.Controls.Add(this.monthCalendarDebut);
            this.Controls.Add(this.textBoxTitre);
            this.MaximumSize = new System.Drawing.Size(559, 378);
            this.MinimumSize = new System.Drawing.Size(559, 378);
            this.Name = "AjoutEvenement";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Ajouter un événement";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AjoutEvenement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitre;
        private System.Windows.Forms.MonthCalendar monthCalendarDebut;
        private System.Windows.Forms.MonthCalendar monthCalendarFin;
        private System.Windows.Forms.ListBox listBoxClub;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButtonAjout;
    }
}