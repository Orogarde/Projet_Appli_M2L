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
    public partial class MaisonDesLigues : Form
    {
        ClubManagement listClub;
        AdherentManagement listA;
        public MaisonDesLigues()
        {
            InitializeComponent();
            listA = new AdherentManagement();
            listClub = new ClubManagement();
        }

        private void adhérentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter Ajout = new Ajouter(listA);
            Ajout.ShowDialog();
        }

        private void listerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeAdherent formL = new ListeAdherent(listA);
            formL.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer Supprimer = new Supprimer(listA);
            Supprimer.ShowDialog();
        }

        private void listerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListeClub listeclubs = new ListeClub(listClub);
            listeclubs.ShowDialog();
        }
    }
}
