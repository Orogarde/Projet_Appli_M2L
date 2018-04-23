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
            this.buttonAjout = new System.Windows.Forms.Button();
            this.listBoxClub = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Location = new System.Drawing.Point(47, 55);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(158, 20);
            this.textBoxTitre.TabIndex = 0;
            // 
            // monthCalendarDebut
            // 
            this.monthCalendarDebut.Location = new System.Drawing.Point(18, 129);
            this.monthCalendarDebut.Name = "monthCalendarDebut";
            this.monthCalendarDebut.TabIndex = 1;
            // 
            // monthCalendarFin
            // 
            this.monthCalendarFin.Location = new System.Drawing.Point(314, 129);
            this.monthCalendarFin.Name = "monthCalendarFin";
            this.monthCalendarFin.TabIndex = 2;
            // 
            // buttonAjout
            // 
            this.buttonAjout.Location = new System.Drawing.Point(242, 329);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(75, 23);
            this.buttonAjout.TabIndex = 3;
            this.buttonAjout.Text = "Ajouter";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click_1);
            // 
            // listBoxClub
            // 
            this.listBoxClub.FormattingEnabled = true;
            this.listBoxClub.Location = new System.Drawing.Point(374, 22);
            this.listBoxClub.Name = "listBoxClub";
            this.listBoxClub.Size = new System.Drawing.Size(120, 95);
            this.listBoxClub.TabIndex = 4;
            this.listBoxClub.SelectedIndexChanged += new System.EventHandler(this.listBoxClub_SelectedIndexChanged);
            // 
            // AjoutEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 378);
            this.Controls.Add(this.listBoxClub);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.monthCalendarFin);
            this.Controls.Add(this.monthCalendarDebut);
            this.Controls.Add(this.textBoxTitre);
            this.Name = "AjoutEvenement";
            this.Text = "AjoutEvenement";
            this.Load += new System.EventHandler(this.AjoutEvenement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitre;
        private System.Windows.Forms.MonthCalendar monthCalendarDebut;
        private System.Windows.Forms.MonthCalendar monthCalendarFin;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.ListBox listBoxClub;
    }
}