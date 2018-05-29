namespace WindowsFormsprpojectprep
{
    partial class supprimerClub
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
            this.listBoxSup = new System.Windows.Forms.ListBox();
            this.metroButtonSup = new MetroFramework.Controls.MetroButton();
            this.metroButtonRetour = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBoxSup
            // 
            this.listBoxSup.BackColor = System.Drawing.Color.Teal;
            this.listBoxSup.ForeColor = System.Drawing.Color.White;
            this.listBoxSup.FormattingEnabled = true;
            this.listBoxSup.Location = new System.Drawing.Point(11, 63);
            this.listBoxSup.Name = "listBoxSup";
            this.listBoxSup.Size = new System.Drawing.Size(483, 173);
            this.listBoxSup.TabIndex = 0;
            this.listBoxSup.SelectedIndexChanged += new System.EventHandler(this.listBoxSup_SelectedIndexChanged);
            // 
            // metroButtonSup
            // 
            this.metroButtonSup.Highlight = true;
            this.metroButtonSup.Location = new System.Drawing.Point(184, 277);
            this.metroButtonSup.Name = "metroButtonSup";
            this.metroButtonSup.Size = new System.Drawing.Size(139, 23);
            this.metroButtonSup.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButtonSup.TabIndex = 2;
            this.metroButtonSup.Text = "Supprimer un club";
            this.metroButtonSup.UseCustomBackColor = true;
            this.metroButtonSup.UseSelectable = true;
            this.metroButtonSup.UseStyleColors = true;
            this.metroButtonSup.Click += new System.EventHandler(this.metroButtonSup_Click);
            // 
            // metroButtonRetour
            // 
            this.metroButtonRetour.Highlight = true;
            this.metroButtonRetour.Location = new System.Drawing.Point(388, 265);
            this.metroButtonRetour.Name = "metroButtonRetour";
            this.metroButtonRetour.Size = new System.Drawing.Size(79, 35);
            this.metroButtonRetour.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButtonRetour.TabIndex = 7;
            this.metroButtonRetour.Text = "retour";
            this.metroButtonRetour.UseCustomBackColor = true;
            this.metroButtonRetour.UseSelectable = true;
            this.metroButtonRetour.UseStyleColors = true;
            this.metroButtonRetour.Click += new System.EventHandler(this.metroButtonRetour_Click);
            // 
            // supprimerClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 323);
            this.Controls.Add(this.metroButtonRetour);
            this.Controls.Add(this.metroButtonSup);
            this.Controls.Add(this.listBoxSup);
            this.MaximumSize = new System.Drawing.Size(507, 323);
            this.MinimumSize = new System.Drawing.Size(507, 323);
            this.Name = "supprimerClub";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Supprimer un Club";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.supprimerClub_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSup;
        private MetroFramework.Controls.MetroButton metroButtonSup;
        private MetroFramework.Controls.MetroButton metroButtonRetour;
    }
}