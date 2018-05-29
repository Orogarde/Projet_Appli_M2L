namespace WindowsFormsprpojectprep
{
    partial class SupprimerEvent
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
            this.listBoxEvent = new System.Windows.Forms.ListBox();
            this.metroButtonSup = new MetroFramework.Controls.MetroButton();
            this.metroButtonRetour = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBoxEvent
            // 
            this.listBoxEvent.BackColor = System.Drawing.Color.Teal;
            this.listBoxEvent.ForeColor = System.Drawing.Color.White;
            this.listBoxEvent.FormattingEnabled = true;
            this.listBoxEvent.Location = new System.Drawing.Point(23, 90);
            this.listBoxEvent.Name = "listBoxEvent";
            this.listBoxEvent.Size = new System.Drawing.Size(518, 147);
            this.listBoxEvent.TabIndex = 0;
            this.listBoxEvent.SelectedIndexChanged += new System.EventHandler(this.listBoxEvent_SelectedIndexChanged);
            // 
            // metroButtonSup
            // 
            this.metroButtonSup.Highlight = true;
            this.metroButtonSup.Location = new System.Drawing.Point(209, 298);
            this.metroButtonSup.MaximumSize = new System.Drawing.Size(148, 23);
            this.metroButtonSup.MinimumSize = new System.Drawing.Size(148, 23);
            this.metroButtonSup.Name = "metroButtonSup";
            this.metroButtonSup.Size = new System.Drawing.Size(148, 23);
            this.metroButtonSup.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButtonSup.TabIndex = 2;
            this.metroButtonSup.Text = "Supprimer un événement";
            this.metroButtonSup.UseCustomBackColor = true;
            this.metroButtonSup.UseSelectable = true;
            this.metroButtonSup.UseStyleColors = true;
            this.metroButtonSup.Click += new System.EventHandler(this.metroButtonSup_Click);
            // 
            // metroButtonRetour
            // 
            this.metroButtonRetour.Highlight = true;
            this.metroButtonRetour.Location = new System.Drawing.Point(451, 286);
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
            // SupprimerEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 333);
            this.Controls.Add(this.metroButtonRetour);
            this.Controls.Add(this.metroButtonSup);
            this.Controls.Add(this.listBoxEvent);
            this.Name = "SupprimerEvent";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Supprimer un événement";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.SupprimerEvent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEvent;
        private MetroFramework.Controls.MetroButton metroButtonSup;
        private MetroFramework.Controls.MetroButton metroButtonRetour;
    }
}