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
    public partial class ModifClub : MetroForm
    {
        DAOclub connect = new DAOclub();
       
        public ClubManagement listClub;
        public int index;
        public Club clubModif;

        public ModifClub(ClubManagement liste,Club clubModif)
        {
            InitializeComponent();
            this.listClub = liste;
            this.clubModif = clubModif;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AjoutClub_Load(object sender, EventArgs e)
        {
            textBoxtitre.Text = clubModif.titre;
            textBoxUrl.Text = clubModif.url;
            textBoxAdresse.Text = clubModif.Adresse;
            maskedTextBoxTel.Text = clubModif.numero;
            TextBoxVille.Text = clubModif.ville;
            textBoxMail.Text = clubModif.mail;
            maskedTextBoxCodePostal.Text = clubModif.codepostal;

        }

        private void metroButtonAjout_Click(object sender, EventArgs e)
        {
            clubModif.titre = textBoxtitre.Text;
            clubModif.url = textBoxUrl.Text;
            clubModif.Adresse = textBoxAdresse.Text;
            clubModif.codepostal = maskedTextBoxCodePostal.Text;
            clubModif.ville = TextBoxVille.Text;
            clubModif.mail = textBoxMail.Text;
            clubModif.numero = maskedTextBoxTel.Text;
            
        
            DAOclub connect = new DAOclub();
            connect.ModifClub(clubModif);


            textBoxtitre.Text = string.Empty;
            textBoxUrl.Text = string.Empty;
            textBoxAdresse.Text = string.Empty;
            maskedTextBoxTel.Text = string.Empty;
            TextBoxVille.Text = string.Empty;
            textBoxMail.Text = string.Empty;
            maskedTextBoxCodePostal.Text = string.Empty;
        }

        private void metroButtonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
