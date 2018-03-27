namespace WindowsFormsprpojectprep
{
    partial class Ajouter
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
            this.buttonAjout = new System.Windows.Forms.Button();
            this.labelN = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.buttonvoir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAjout
            // 
            this.buttonAjout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjout.AutoSize = true;
            this.buttonAjout.Location = new System.Drawing.Point(192, 170);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(75, 23);
            this.buttonAjout.TabIndex = 0;
            this.buttonAjout.Text = "Ajouter";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // labelN
            // 
            this.labelN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(77, 54);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(32, 13);
            this.labelN.TabIndex = 1;
            this.labelN.Text = "NOM";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(80, 107);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(54, 13);
            this.labelP.TabIndex = 2;
            this.labelP.Text = "PRENOM";
            // 
            // textBoxN
            // 
            this.textBoxN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxN.Location = new System.Drawing.Point(181, 38);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 3;
            // 
            // textBoxP
            // 
            this.textBoxP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxP.Location = new System.Drawing.Point(181, 91);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 20);
            this.textBoxP.TabIndex = 4;
            // 
            // buttonvoir
            // 
            this.buttonvoir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonvoir.AutoSize = true;
            this.buttonvoir.Location = new System.Drawing.Point(367, 91);
            this.buttonvoir.Name = "buttonvoir";
            this.buttonvoir.Size = new System.Drawing.Size(75, 23);
            this.buttonvoir.TabIndex = 5;
            this.buttonvoir.Text = "voir liste";
            this.buttonvoir.UseVisualStyleBackColor = true;
            this.buttonvoir.Click += new System.EventHandler(this.buttonvoir_Click);
            // 
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(475, 261);
            this.Controls.Add(this.buttonvoir);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.buttonAjout);
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Ajouter";
            this.Text = "Ajouter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Button buttonvoir;
    }
}