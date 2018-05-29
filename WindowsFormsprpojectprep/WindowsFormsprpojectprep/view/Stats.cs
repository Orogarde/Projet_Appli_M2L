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
    public partial class Stats : MetroForm
    {
        DAOclub connect = new DAOclub();
        public ClubManagement liste;
        public int index;
        public Club club;
        public Stats(ClubManagement liste)
        {
            InitializeComponent();
            this.liste = liste;
        }

        private void Statistiques_Load(object sender, EventArgs e)
        {
            liste.listClubs = connect.ReadClub();

            foreach (var item in liste.listClubs)
            {
                listBoxClub.Items.Add(item.titre);
            }
        }

        private void listBoxClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxClub.SelectedIndex;
            if (index >= 0)
            {
                club = liste.GetClubliste(index);
                labelAdherent.Text = Convert.ToString(connect.countAdherentClub(club));
                labelEvent.Text = Convert.ToString(connect.countEventClub(club));
            }

        }

        private void metroButtonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
