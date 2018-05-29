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
    public partial class ModifEvenement : MetroForm
    {
        DAOclub connectClub = new DAOclub();
        DAOEvenement connect = new DAOEvenement();
        public Evenement eventModif;
        public EvenementManagement listEvenement;
        public int index;

        public ModifEvenement(EvenementManagement listEvenement,Evenement eventModif)
        {
            InitializeComponent();
            this.listEvenement = listEvenement;
            this.eventModif = eventModif;

        }



 
     

        

        private void AjoutEvenement_Load(object sender, EventArgs e)
        {
            textBoxTitre.Text = eventModif.titreEvenement;
            monthCalendarDebut.SelectionStart = eventModif.debutEvenement;
            monthCalendarFin.SelectionStart = eventModif.finEvenement;
        }

       

        private void metroButtonAjout_Click(object sender, EventArgs e)
        {
            
            eventModif.titreEvenement = textBoxTitre.Text;
           eventModif.debutEvenement = monthCalendarDebut.SelectionStart;
            eventModif.finEvenement = monthCalendarFin.SelectionStart;
            

            
            connect.ModifEvenement(eventModif);
            textBoxTitre.Text = string.Empty;
        }

        private void metroButtonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
