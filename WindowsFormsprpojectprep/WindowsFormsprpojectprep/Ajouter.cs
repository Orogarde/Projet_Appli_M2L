using System;
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
            DateTime date = DateTime.Now;
            adhérent adherent = new adhérent(nom, prenom,date);
            listAd.AjouterAdherent(adherent);
            textBoxN.Text = string.Empty;
            textBoxP.Text = string.Empty;
            
        }

        private void buttonvoir_Click(object sender, EventArgs e)
        {
            formL formL = new formL(listAd);
            formL.ShowDialog();
        }
    }
}
