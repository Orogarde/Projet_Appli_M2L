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
            this.buttondesinscrire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxadherent
            // 
            this.listBoxadherent.FormattingEnabled = true;
            this.listBoxadherent.Location = new System.Drawing.Point(44, 37);
            this.listBoxadherent.Name = "listBoxadherent";
            this.listBoxadherent.Size = new System.Drawing.Size(383, 134);
            this.listBoxadherent.TabIndex = 0;
            this.listBoxadherent.SelectedIndexChanged += new System.EventHandler(this.listBoxadherent_SelectedIndexChanged);
            // 
            // buttondesinscrire
            // 
            this.buttondesinscrire.Location = new System.Drawing.Point(202, 261);
            this.buttondesinscrire.Name = "buttondesinscrire";
            this.buttondesinscrire.Size = new System.Drawing.Size(75, 23);
            this.buttondesinscrire.TabIndex = 1;
            this.buttondesinscrire.Text = "désinscrire";
            this.buttondesinscrire.UseVisualStyleBackColor = true;
            this.buttondesinscrire.Click += new System.EventHandler(this.buttondesinscrire_Click);
            // 
            // desinscrire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 319);
            this.Controls.Add(this.buttondesinscrire);
            this.Controls.Add(this.listBoxadherent);
            this.Name = "desinscrire";
            this.Text = "desinscrire";
            this.Load += new System.EventHandler(this.desinscrire_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxadherent;
        private System.Windows.Forms.Button buttondesinscrire;
    }
}