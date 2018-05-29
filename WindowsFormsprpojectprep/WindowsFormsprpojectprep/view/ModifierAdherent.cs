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
  
    public partial class ModifierAdherent : MetroForm
    {
        public AdherentManagement listAd;
        public adhérent adherentModif;
        public Random rand;
        
        public ModifierAdherent(AdherentManagement listAdherent,adhérent adherentModif)
        {
            InitializeComponent();
            this.listAd = listAdherent;
            this.adherentModif = adherentModif;
           
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
            
            
            //string nom = textBoxN.Text;
             adherentModif.nom = textBoxN.Text ;
             adherentModif.prenom = textBoxP.Text;
             adherentModif.ville = textBoxVille.Text;
           adherentModif.cotisation =Convert.ToDouble( maskedTextBoxCotisation.Text);
            
            adherentModif.codepostal = maskedTextBoxCodePostal.Text;
            
             adherentModif.Adresse = textBoxAdresse.Text;

             adherentModif.date = monthCalendar1.SelectionStart;

           
            
            
            DAOadherent connect = new DAOadherent();
            connect.ModifAdherent(adherentModif);
            MetroFramework.MetroMessageBox.Show(this, "l'adhérent a été modifier , relancer la liste pour voir les modifications !", "Félicitation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxN.Text = string.Empty;
            textBoxP.Text = string.Empty;
            maskedTextBoxCodePostal.Text = string.Empty;
            maskedTextBoxCotisation.Text = string.Empty;

            textBoxVille.Text = string.Empty;
            textBoxAdresse.Text = string.Empty;
        }

        

        private void ModifierAdherent_Load(object sender, EventArgs e)
        {
              textBoxN.Text = adherentModif.nom;
             textBoxP.Text = adherentModif.prenom;
             textBoxVille.Text = adherentModif.ville;
            maskedTextBoxCotisation.Text = Convert.ToString(adherentModif.cotisation);
            maskedTextBoxCodePostal.Text = adherentModif.codepostal;

            textBoxAdresse.Text = adherentModif.Adresse;

              monthCalendar1.SelectionStart = adherentModif.date;
        }

        private void metroButtonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
