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
            try
            {
                string titre = textBoxtitre.Text;
                string url = textBoxUrl.Text;
                string adresse = textBoxAdresse.Text;
                string codePostal = maskedTextBoxCodePostal.Text;
                string ville = TextBoxVille.Text;
                string mail = textBoxMail.Text;
                string tel = maskedTextBoxTel.Text;
                int idtype = 1;
                if (titre.Length != 0 && url.Length != 0 && adresse.Length != 0 && codePostal.Length != 0 && ville.Length != 0 && mail.Length != 0 && tel.Length != 0)
                {
                    Club club = new Club(titre, url, ville, tel, codePostal, mail, idtype, adresse);
                    club.Type = listTypeclub.GetTypeClubliste(index);
                    DAOclub connect = new DAOclub();
                    connect.ajouterClub(club);
                    MetroFramework.MetroMessageBox.Show(this, "le Club a bien été ajouté", "Félicitations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MetroFramework.MetroMessageBox.Show(this, "Vous devez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "problème lors de la saisie !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
