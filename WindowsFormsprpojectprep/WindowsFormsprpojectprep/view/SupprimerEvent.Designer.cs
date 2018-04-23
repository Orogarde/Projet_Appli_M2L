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
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxEvent
            // 
            this.listBoxEvent.FormattingEnabled = true;
            this.listBoxEvent.Location = new System.Drawing.Point(113, 62);
            this.listBoxEvent.Name = "listBoxEvent";
            this.listBoxEvent.Size = new System.Drawing.Size(334, 147);
            this.listBoxEvent.TabIndex = 0;
            this.listBoxEvent.SelectedIndexChanged += new System.EventHandler(this.listBoxEvent_SelectedIndexChanged);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(238, 269);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 1;
            this.buttonSupprimer.Text = "supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // SupprimerEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 333);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.listBoxEvent);
            this.Name = "SupprimerEvent";
            this.Text = "Supprimer";
            this.Load += new System.EventHandler(this.SupprimerEvent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEvent;
        private System.Windows.Forms.Button buttonSupprimer;
    }
}