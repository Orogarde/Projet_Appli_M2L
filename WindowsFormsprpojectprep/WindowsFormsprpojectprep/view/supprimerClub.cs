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
    public partial class supprimerClub : MetroForm
    {
        public Club clubSelectionner;
        public ClubManagement clubs;

        DAOclub connect = new DAOclub();

        public int index;

        public supprimerClub(ClubManagement clubs)
        {
            InitializeComponent();
            this.clubs = clubs;
        }

        private void supprimerClub_Load(object sender, EventArgs e)
        {
            clubs.listClubs = connect.ReadClub();
            foreach (var item in clubs.listClubs)
            {
                listBoxSup.Items.Add(item.titre + " " + item.ville);
            }
        }

        private void listBoxSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxSup.SelectedIndex;
        }

       

        private void metroButtonSup_Click(object sender, EventArgs e)
        {
            clubSelectionner = clubs.GetClubliste(index);
            connect.supprimerClub(clubSelectionner);
            listBoxSup.Items.Clear();
            clubs.listClubs = connect.ReadClub();
            foreach (var item in clubs.listClubs)
            {
                listBoxSup.Items.Add(item.titre + " " + item.ville);
            }

        }
    }
}
