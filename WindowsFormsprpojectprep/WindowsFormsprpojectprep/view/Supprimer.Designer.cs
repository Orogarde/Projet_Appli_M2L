namespace WindowsFormsprpojectprep
{
    partial class Supprimer
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
            this.metroButtonSupprimer = new MetroFramework.Controls.MetroButton();
            this.listBoxSupprimer = new System.Windows.Forms.ListBox();
            this.metroButtonRetour = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButtonSupprimer
            // 
            this.metroButtonSupprimer.ForeColor = System.Drawing.Color.Teal;
            this.metroButtonSupprimer.Highlight = true;
            this.metroButtonSupprimer.Location = new System.Drawing.Point(191, 279);
            this.metroButtonSupprimer.Name = "metroButtonSupprimer";
            this.metroButtonSupprimer.Size = new System.Drawing.Size(149, 35);
            this.metroButtonSupprimer.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButtonSupprimer.TabIndex = 4;
            this.metroButtonSupprimer.Text = "Supprimer un adhérent";
            this.metroButtonSupprimer.UseCustomBackColor = true;
            this.metroButtonSupprimer.UseSelectable = true;
            this.metroButtonSupprimer.UseStyleColors = true;
            this.metroButtonSupprimer.Click += new System.EventHandler(this.metroButtonSupprimer_Click);
            // 
            // listBoxSupprimer
            // 
            this.listBoxSupprimer.BackColor = System.Drawing.Color.Teal;
            this.listBoxSupprimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxSupprimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSupprimer.ForeColor = System.Drawing.Color.White;
            this.listBoxSupprimer.FormattingEnabled = true;
            this.listBoxSupprimer.ItemHeight = 12;
            this.listBoxSupprimer.Location = new System.Drawing.Point(20, 60);
            this.listBoxSupprimer.Name = "listBoxSupprimer";
            this.listBoxSupprimer.Size = new System.Drawing.Size(510, 172);
            this.listBoxSupprimer.TabIndex = 2;
            this.listBoxSupprimer.SelectedIndexChanged += new System.EventHandler(this.listBoxSupprimer_SelectedIndexChanged);
            // 
            // metroButtonRetour
            // 
            this.metroButtonRetour.Highlight = true;
            this.metroButtonRetour.Location = new System.Drawing.Point(412, 279);
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
            // Supprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.metroButtonRetour);
            this.Controls.Add(this.metroButtonSupprimer);
            this.Controls.Add(this.listBoxSupprimer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(550, 350);
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "Supprimer";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Supprimer un adhérent";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.Load += new System.EventHandler(this.Supprimer_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButtonSupprimer;
        private System.Windows.Forms.ListBox listBoxSupprimer;
        private MetroFramework.Controls.MetroButton metroButtonRetour;
    }
}