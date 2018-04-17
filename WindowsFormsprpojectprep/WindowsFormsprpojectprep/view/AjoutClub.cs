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
    public partial class AjoutClub : Form
    {
        public ClubManagement listClub;
        public AjoutClub(ClubManagement liste)
        {
            InitializeComponent();
            this.listClub = liste;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            string titre = textBoxtitre.Text;
            string url = textBoxUrl.Text;
            string adresse = textBoxAdresse.Text;
            string codePostal = textBoxCodePostal.Text;
            string ville = TextBoxVille.Text ;
            string mail = textBoxMail.Text;
            string tel = textBoxTel.Text;
            int idtype = Convert.ToInt32(textBoxIdType.Text);

            Club club = new Club(titre, url, ville, tel, codePostal, mail, idtype, adresse);
            DAOclub connect = new DAOclub();
            connect.ajouterClub(club);

            textBoxIdType.Text = string.Empty;
            textBoxtitre.Text = string.Empty;
            textBoxUrl.Text = string.Empty;
            textBoxAdresse.Text = string.Empty;
            textBoxCodePostal.Text = string.Empty;
            TextBoxVille.Text = string.Empty;
            textBoxMail.Text = string.Empty;
            textBoxTel.Text = string.Empty;
        }
    }
}
