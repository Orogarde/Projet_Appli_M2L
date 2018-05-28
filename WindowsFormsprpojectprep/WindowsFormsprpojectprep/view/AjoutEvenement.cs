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
    public partial class AjoutEvenement : MetroForm
    {
        DAOclub connectClub = new DAOclub();
        DAOEvenement connect = new DAOEvenement();
        public ClubManagement listClub;
        public EvenementManagement listEvenement;
        public int index;

        public AjoutEvenement(EvenementManagement listEvenement,ClubManagement listClub)
        {
            InitializeComponent();
            this.listEvenement = listEvenement;
            this.listClub = listClub;

        }



 
     

        

        private void AjoutEvenement_Load(object sender, EventArgs e)
        {
            listClub.listClubs = connectClub.ReadClub(); 
            
            foreach (var item in listClub.listClubs)
            {
                listBoxClub.Items.Add(item.titre);
            }
        }

        private void listBoxClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            

                index = listBoxClub.SelectedIndex;
            
        }

        private void metroButtonAjout_Click(object sender, EventArgs e)
        {
            try
            {
                string titre = textBoxTitre.Text;
                DateTime dateDebut = monthCalendarDebut.SelectionStart;
                DateTime dateFin = monthCalendarFin.SelectionStart;
                if (titre.Length != 0 )
                {
                    Evenement evenement = new Evenement(dateDebut, dateFin, titre);

                    evenement.club = listClub.GetClubliste(index);
                    connect.ajouterEvenement(evenement);
                    MetroFramework.MetroMessageBox.Show(this, "l'evenement a bien été ajouté", "Félicitations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MetroFramework.MetroMessageBox.Show(this, "Vous devez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "problème lors de la saisie !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxTitre.Text = string.Empty;
        }
    }
}
