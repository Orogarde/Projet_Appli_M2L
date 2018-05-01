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
    public partial class AjoutAdherentAclub : MetroForm
    {
        DAOadherent connect = new DAOadherent();
        DAOclub connectClub = new DAOclub();
        public AdherentManagement listAdherents;
        public ClubManagement listClubs;
        public int indexAdherent;
        public int indexClub;
        public adhérent adherent;
        public Club club;
        public AjoutAdherentAclub(AdherentManagement listAdherents,ClubManagement listClubs)
        {
            InitializeComponent();
            this.listAdherents = listAdherents;
            this.listClubs = listClubs;
        }

        private void AjoutAdherentAclub_Load(object sender, EventArgs e)
        {
            listAdherents.listM = connect.ReadadherentSansClub();
            
            foreach (var item in listAdherents.listM)
            {
                listBoxAdherents.Items.Add(item.nom+"  "+item.prenom);
            }
            listClubs.listClubs= connectClub.ReadClub();
            foreach (var item in listClubs.listClubs)
            {
                listBoxClubs.Items.Add(item.titre);
            }
        }

        private void listBoxAdherents_SelectedIndexChanged(object sender, EventArgs e)
        {

            indexAdherent = listBoxAdherents.SelectedIndex;
            
           
        }

        private void listBoxClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexClub = listBoxClubs.SelectedIndex;
            
        }

        

        private void metroButtonAjout_Click(object sender, EventArgs e)
        {
            adherent = listAdherents.GetAdhérentliste(indexAdherent);
            club = listClubs.GetClubliste(indexClub);
            adherent.club = club;
            connect.AjoutAdherentAclub(adherent);

            listBoxAdherents.Items.Clear();
            listAdherents.listM = connect.ReadadherentSansClub();

            foreach (var item in listAdherents.listM)
            {
                listBoxAdherents.Items.Add(item.nom + "  " + item.prenom);
            }
        }
    }
}
