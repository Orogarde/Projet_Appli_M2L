﻿namespace WindowsFormsprpojectprep
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
            this.buttonAjout = new System.Windows.Forms.Button();
            this.labelClub = new System.Windows.Forms.Label();
            this.labelAdherent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxAdherents
            // 
            this.listBoxAdherents.FormattingEnabled = true;
            this.listBoxAdherents.Location = new System.Drawing.Point(25, 58);
            this.listBoxAdherents.Name = "listBoxAdherents";
            this.listBoxAdherents.Size = new System.Drawing.Size(137, 173);
            this.listBoxAdherents.TabIndex = 0;
            this.listBoxAdherents.SelectedIndexChanged += new System.EventHandler(this.listBoxAdherents_SelectedIndexChanged);
            // 
            // listBoxClubs
            // 
            this.listBoxClubs.FormattingEnabled = true;
            this.listBoxClubs.Location = new System.Drawing.Point(343, 58);
            this.listBoxClubs.Name = "listBoxClubs";
            this.listBoxClubs.Size = new System.Drawing.Size(133, 173);
            this.listBoxClubs.TabIndex = 1;
            this.listBoxClubs.SelectedIndexChanged += new System.EventHandler(this.listBoxClubs_SelectedIndexChanged);
            // 
            // buttonAjout
            // 
            this.buttonAjout.Location = new System.Drawing.Point(192, 279);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(118, 23);
            this.buttonAjout.TabIndex = 2;
            this.buttonAjout.Text = "Ajouter un adhérent";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // labelClub
            // 
            this.labelClub.AutoSize = true;
            this.labelClub.Location = new System.Drawing.Point(387, 261);
            this.labelClub.Name = "labelClub";
            this.labelClub.Size = new System.Drawing.Size(35, 13);
            this.labelClub.TabIndex = 3;
            this.labelClub.Text = "label1";
            // 
            // labelAdherent
            // 
            this.labelAdherent.AutoSize = true;
            this.labelAdherent.Location = new System.Drawing.Point(72, 261);
            this.labelAdherent.Name = "labelAdherent";
            this.labelAdherent.Size = new System.Drawing.Size(35, 13);
            this.labelAdherent.TabIndex = 4;
            this.labelAdherent.Text = "label2";
            // 
            // AjoutAdherentAclub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 314);
            this.Controls.Add(this.labelAdherent);
            this.Controls.Add(this.labelClub);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.listBoxClubs);
            this.Controls.Add(this.listBoxAdherents);
            this.Name = "AjoutAdherentAclub";
            this.Text = "AjoutAdherentAclub";
            this.Load += new System.EventHandler(this.AjoutAdherentAclub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAdherents;
        private System.Windows.Forms.ListBox listBoxClubs;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Label labelClub;
        private System.Windows.Forms.Label labelAdherent;
    }
}