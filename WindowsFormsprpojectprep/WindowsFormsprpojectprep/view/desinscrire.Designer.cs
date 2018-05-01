namespace WindowsFormsprpojectprep
{
    partial class desinscrire
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
            this.listBoxadherent = new System.Windows.Forms.ListBox();
            this.metroButtonDesinscrire = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBoxadherent
            // 
            this.listBoxadherent.BackColor = System.Drawing.Color.Teal;
            this.listBoxadherent.ForeColor = System.Drawing.Color.White;
            this.listBoxadherent.FormattingEnabled = true;
            this.listBoxadherent.Location = new System.Drawing.Point(44, 82);
            this.listBoxadherent.Name = "listBoxadherent";
            this.listBoxadherent.Size = new System.Drawing.Size(383, 134);
            this.listBoxadherent.TabIndex = 0;
            this.listBoxadherent.SelectedIndexChanged += new System.EventHandler(this.listBoxadherent_SelectedIndexChanged);
            // 
            // metroButtonDesinscrire
            // 
            this.metroButtonDesinscrire.Highlight = true;
            this.metroButtonDesinscrire.Location = new System.Drawing.Point(173, 280);
            this.metroButtonDesinscrire.MaximumSize = new System.Drawing.Size(130, 23);
            this.metroButtonDesinscrire.MinimumSize = new System.Drawing.Size(130, 23);
            this.metroButtonDesinscrire.Name = "metroButtonDesinscrire";
            this.metroButtonDesinscrire.Size = new System.Drawing.Size(130, 23);
            this.metroButtonDesinscrire.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButtonDesinscrire.TabIndex = 3;
            this.metroButtonDesinscrire.Text = "Désinscrire d\'un club";
            this.metroButtonDesinscrire.UseCustomBackColor = true;
            this.metroButtonDesinscrire.UseSelectable = true;
            this.metroButtonDesinscrire.UseStyleColors = true;
            this.metroButtonDesinscrire.Click += new System.EventHandler(this.metroButtonDesinscrire_Click);
            // 
            // desinscrire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 319);
            this.Controls.Add(this.metroButtonDesinscrire);
            this.Controls.Add(this.listBoxadherent);
            this.Name = "desinscrire";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Désinscrire un adhérent";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.desinscrire_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxadherent;
        private MetroFramework.Controls.MetroButton metroButtonDesinscrire;
    }
}