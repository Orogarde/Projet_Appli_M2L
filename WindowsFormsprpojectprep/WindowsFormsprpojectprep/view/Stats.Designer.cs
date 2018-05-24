namespace WindowsFormsprpojectprep
{
    partial class Stats
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
            this.listBoxClub = new System.Windows.Forms.ListBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.labelAdherent = new System.Windows.Forms.Label();
            this.labelEvent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxClub
            // 
            this.listBoxClub.BackColor = System.Drawing.Color.Teal;
            this.listBoxClub.ForeColor = System.Drawing.Color.White;
            this.listBoxClub.FormattingEnabled = true;
            this.listBoxClub.Location = new System.Drawing.Point(176, 82);
            this.listBoxClub.Name = "listBoxClub";
            this.listBoxClub.Size = new System.Drawing.Size(120, 95);
            this.listBoxClub.TabIndex = 0;
            this.listBoxClub.SelectedIndexChanged += new System.EventHandler(this.listBoxClub_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 110);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(140, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "nombres d\'adhérents :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(309, 110);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(148, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "nombres d\'evenements:";
            // 
            // labelAdherent
            // 
            this.labelAdherent.AutoSize = true;
            this.labelAdherent.Location = new System.Drawing.Point(68, 140);
            this.labelAdherent.Name = "labelAdherent";
            this.labelAdherent.Size = new System.Drawing.Size(0, 13);
            this.labelAdherent.TabIndex = 5;
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Location = new System.Drawing.Point(370, 140);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(0, 13);
            this.labelEvent.TabIndex = 6;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 244);
            this.Controls.Add(this.labelEvent);
            this.Controls.Add(this.labelAdherent);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.listBoxClub);
            this.Name = "Stats";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Statistiques";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Statistiques_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClub;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Label labelAdherent;
        private System.Windows.Forms.Label labelEvent;
    }
}