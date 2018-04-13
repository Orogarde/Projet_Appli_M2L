﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsprpojectprep
{
    public partial class Ajouter : Form
    {
        public AdherentManagement listAd;
        
        public Ajouter(AdherentManagement listAdherent)
        {
            InitializeComponent();
            this.listAd = listAdherent;
           
        }
        
        private void buttonAjout_Click(object sender, EventArgs e)
        {
            
            string nom = textBoxN.Text;
            string prenom = textBoxP.Text;
            string ville = textBoxVille.Text;
            string numero = textBoxNumero.Text;
            string codepostal = textBoxCodepostal.Text;
            double cotisation = Convert.ToDouble( textBoxCotisation.Text);
            string adresse = textBoxAdresse.Text;
            DateTime date = monthCalendar1.SelectionStart;
            adhérent adherent = new adhérent(nom, prenom,ville,numero,codepostal,cotisation,adresse,date);
            listAd.AjouterAdherent(adherent);
            DBconnect connect = new DBconnect();
            connect.ajouterAdherent(adherent);
            textBoxN.Text = string.Empty;
            textBoxP.Text = string.Empty;
            textBoxCotisation.Text = string.Empty;
            textBoxCodepostal.Text = string.Empty;
            textBoxNumero.Text = string.Empty;
            textBoxVille.Text = string.Empty;
            textBoxAdresse.Text = string.Empty;

        }

        private void buttonvoir_Click(object sender, EventArgs e)
        {
            ListeAdherent formL = new ListeAdherent(listAd);
            formL.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label6.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }
    }
}
