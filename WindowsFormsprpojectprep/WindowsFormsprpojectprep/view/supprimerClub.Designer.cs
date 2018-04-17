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
            this.buttonSup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSup
            // 
            this.listBoxSup.FormattingEnabled = true;
            this.listBoxSup.Location = new System.Drawing.Point(12, 20);
            this.listBoxSup.Name = "listBoxSup";
            this.listBoxSup.Size = new System.Drawing.Size(483, 173);
            this.listBoxSup.TabIndex = 0;
            this.listBoxSup.SelectedIndexChanged += new System.EventHandler(this.listBoxSup_SelectedIndexChanged);
            // 
            // buttonSup
            // 
            this.buttonSup.Location = new System.Drawing.Point(216, 288);
            this.buttonSup.Name = "buttonSup";
            this.buttonSup.Size = new System.Drawing.Size(75, 23);
            this.buttonSup.TabIndex = 1;
            this.buttonSup.Text = "Supprimer";
            this.buttonSup.UseVisualStyleBackColor = true;
            this.buttonSup.Click += new System.EventHandler(this.buttonSup_Click);
            // 
            // supprimerClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 323);
            this.Controls.Add(this.buttonSup);
            this.Controls.Add(this.listBoxSup);
            this.Name = "supprimerClub";
            this.Text = "supprimerClub";
            this.Load += new System.EventHandler(this.supprimerClub_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSup;
        private System.Windows.Forms.Button buttonSup;
    }
}