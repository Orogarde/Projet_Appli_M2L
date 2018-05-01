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
    public partial class AjoutClub : MetroForm
    {
        DAOclub connect = new DAOclub();
        public TypeClubManagement listTypeclub;
        public ClubManagement listClub;
        public int index;

        public AjoutClub(ClubManagement liste, TypeClubManagement listType)
        {
            InitializeComponent();
            this.listClub = liste;
            this.listTypeclub = listType;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;
        }

        private void AjoutClub_Load(object sender, EventArgs e)
        {
            listTypeclub.listTypesClubs = connect.ReadType();
            foreach (var item in listTypeclub.listTypesClubs)
            {
                listBox1.Items.Add(item.libelle );
            }
        }

        private void metroButtonAjout_Click(object sender, EventArgs e)
        {
            string titre = textBoxtitre.Text;
            string url = textBoxUrl.Text;
            string adresse = textBoxAdresse.Text;
            string codePostal = maskedTextBoxCodePostal.Text;
            string ville = TextBoxVille.Text;
            string mail = textBoxMail.Text;
            string tel = maskedTextBoxTel.Text;
            int idtype = 1;
            Club club = new Club(titre, url, ville, tel, codePostal, mail, idtype, adresse);
            club.Type = listTypeclub.GetTypeClubliste(index);
            DAOclub connect = new DAOclub();
            connect.ajouterClub(club);


            textBoxtitre.Text = string.Empty;
            textBoxUrl.Text = string.Empty;
            textBoxAdresse.Text = string.Empty;
            maskedTextBoxTel.Text = string.Empty;
            TextBoxVille.Text = string.Empty;
            textBoxMail.Text = string.Empty;
            maskedTextBoxCodePostal.Text = string.Empty;
        }
    }
}
