using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsprpojectprep
{
  
    public partial class Ajouter : MetroForm
    {
        public AdherentManagement listAd;
        public Random rand = new Random();
        
        public Ajouter(AdherentManagement listAdherent)
        {
            InitializeComponent();
            this.listAd = listAdherent;
           
        }
    

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label6.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonAjouter_Click(object sender, EventArgs e)
        {
            
            try
            {
                //string nom = textBoxN.Text;
                string nom = textBoxN.Text;
                string prenom = textBoxP.Text;
                string ville = textBoxVille.Text;
                double cotisation = Convert.ToDouble(maskedTextBoxCotisation.Text);
                string numero =Convert.ToString( rand.Next());
                string codepostal = maskedTextBoxCodePostal.Text;

                string adresse = textBoxAdresse.Text;

                DateTime date = monthCalendar1.SelectionStart;

                adhérent adherent = new adhérent(nom, prenom, ville, numero, codepostal, cotisation, date, adresse);
                //  listAd.AjouterAdherent(adherent);
                adherent.date = date;
                
                DAOadherent connect = new DAOadherent();
                connect.ajouterAdherent(adherent);
                MetroFramework.MetroMessageBox.Show(this, "l'adhérent a été ajouté à la base de données avec succès !", "Félicitation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "problème lors de la saisie !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxN.Text = string.Empty;
            textBoxP.Text = string.Empty;
            maskedTextBoxCodePostal.Text = string.Empty;
            maskedTextBoxCotisation.Text = string.Empty;

            textBoxVille.Text = string.Empty;
            textBoxAdresse.Text = string.Empty;
        }

        private void metroButtonVoir_Click(object sender, EventArgs e)
        {
            ListeAdherent formL = new ListeAdherent(listAd);
            formL.ShowDialog();

        }

        private void metroButtonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
