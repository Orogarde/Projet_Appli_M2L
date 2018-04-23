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
    public partial class AjoutEvenement : Form
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


        private void buttonAjout_Click_1(object sender, EventArgs e)
        {
            string titre = textBoxTitre.Text;
            DateTime dateDebut = monthCalendarDebut.SelectionStart;
            DateTime dateFin = monthCalendarFin.SelectionStart;
            Evenement evenement = new Evenement(dateDebut, dateFin, titre);
          
            evenement.club = listClub.GetClubliste(index);
            connect.ajouterEvenement(evenement);
            textBoxTitre.Text = string.Empty;
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
    }
}
