﻿namespace WindowsFormsprpojectprep
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
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.listBoxSupprimer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(217, 264);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(90, 35);
            this.buttonSupprimer.TabIndex = 1;
            this.buttonSupprimer.Text = "supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // listBoxSupprimer
            // 
            this.listBoxSupprimer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxSupprimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxSupprimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSupprimer.FormattingEnabled = true;
            this.listBoxSupprimer.ItemHeight = 12;
            this.listBoxSupprimer.Location = new System.Drawing.Point(0, 0);
            this.listBoxSupprimer.Name = "listBoxSupprimer";
            this.listBoxSupprimer.Size = new System.Drawing.Size(534, 172);
            this.listBoxSupprimer.TabIndex = 2;
            this.listBoxSupprimer.SelectedIndexChanged += new System.EventHandler(this.listBoxSupprimer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // Supprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSupprimer);
            this.Controls.Add(this.buttonSupprimer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(550, 350);
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "Supprimer";
            this.Text = "Supprimer un adhérent";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.Load += new System.EventHandler(this.Supprimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.ListBox listBoxSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}