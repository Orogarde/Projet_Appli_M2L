namespace WindowsFormsprpojectprep
{
    partial class ListeEvenement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGridEvent = new MetroFramework.Controls.MetroGrid();
            this.event_titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButtonRetour = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGridEvent
            // 
            this.metroGridEvent.AllowUserToAddRows = false;
            this.metroGridEvent.AllowUserToDeleteRows = false;
            this.metroGridEvent.AllowUserToResizeRows = false;
            this.metroGridEvent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridEvent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridEvent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEvent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.event_titre,
            this.event_debut,
            this.event_fin,
            this.event_club});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridEvent.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridEvent.EnableHeadersVisualStyles = false;
            this.metroGridEvent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridEvent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEvent.Location = new System.Drawing.Point(104, 75);
            this.metroGridEvent.MaximumSize = new System.Drawing.Size(438, 254);
            this.metroGridEvent.Name = "metroGridEvent";
            this.metroGridEvent.ReadOnly = true;
            this.metroGridEvent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEvent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridEvent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridEvent.Size = new System.Drawing.Size(329, 233);
            this.metroGridEvent.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGridEvent.TabIndex = 2;
            this.metroGridEvent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridEvent.UseCustomForeColor = true;
            this.metroGridEvent.UseStyleColors = true;
            this.metroGridEvent.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGridEvent_RowHeaderMouseDoubleClick);
            // 
            // event_titre
            // 
            this.event_titre.HeaderText = "Titre";
            this.event_titre.Name = "event_titre";
            this.event_titre.ReadOnly = true;
            // 
            // event_debut
            // 
            this.event_debut.HeaderText = "Date de debut";
            this.event_debut.Name = "event_debut";
            this.event_debut.ReadOnly = true;
            // 
            // event_fin
            // 
            this.event_fin.HeaderText = "Date de fin";
            this.event_fin.Name = "event_fin";
            this.event_fin.ReadOnly = true;
            // 
            // event_club
            // 
            this.event_club.HeaderText = "Club";
            this.event_club.Name = "event_club";
            this.event_club.ReadOnly = true;
            // 
            // metroButtonRetour
            // 
            this.metroButtonRetour.Highlight = true;
            this.metroButtonRetour.Location = new System.Drawing.Point(401, 18);
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
            // ListeEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 331);
            this.Controls.Add(this.metroButtonRetour);
            this.Controls.Add(this.metroGridEvent);
            this.Name = "ListeEvenement";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Liste des événements";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ListeEvenement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_club;
        private MetroFramework.Controls.MetroButton metroButtonRetour;
    }
}