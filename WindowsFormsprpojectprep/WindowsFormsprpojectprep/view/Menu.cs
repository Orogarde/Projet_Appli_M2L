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
        TypeClubManagement listType;
        EvenementManagement listEvent;
        public MaisonDesLigues()
        {
            InitializeComponent();
            listA = new AdherentManagement();
            listClub = new ClubManagement();
            listType = new TypeClubManagement();
            listEvent = new EvenementManagement();
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

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjoutClub ajoutC = new AjoutClub(listClub,listType);
            ajoutC.ShowDialog();
        }

        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            supprimerClub Supclub = new supprimerClub(listClub);
            Supclub.ShowDialog();
        }

        private void ajouterUnAdhérentsÀUnClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutAdherentAclub AjoutAdherentAclub = new AjoutAdherentAclub(listA,listClub);
            AjoutAdherentAclub.ShowDialog();
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AjoutEvenement ajoutEvent = new AjoutEvenement(listEvent, listClub);
            ajoutEvent.ShowDialog();
        }

        private void listerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListeEvenement listeEvent = new ListeEvenement(listEvent);
            listeEvent.ShowDialog();
        }

        private void supprimerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SupprimerEvent suppevent = new SupprimerEvent(listEvent);
            suppevent.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            desinscrire desins = new desinscrire(listA);
            desins.ShowDialog();
        }

        private void clubsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
