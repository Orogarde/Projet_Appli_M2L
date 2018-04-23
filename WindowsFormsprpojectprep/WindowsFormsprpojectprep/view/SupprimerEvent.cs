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
    public partial class SupprimerEvent : Form
    {
        public Evenement evenement;
        public EvenementManagement liste;
        public int index;
        DAOEvenement connect = new DAOEvenement();
        public SupprimerEvent(EvenementManagement liste)
        {
            InitializeComponent();
            this.liste = liste;

        }

        private void SupprimerEvent_Load(object sender, EventArgs e)
        {
            liste.listEvenement = connect.ReadEvenement();
         

            foreach (var item in liste.listEvenement)
            {
                listBoxEvent.Items.Add(item.titreEvenement );
            }

        }

        private void listBoxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxEvent.SelectedIndex;
           
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
                evenement = liste.GetEvenementliste(index);





            connect.supprimerEvenement(evenement);
            //  adherent.suppression(index);

            listBoxEvent.Items.Clear();
            liste.listEvenement = connect.ReadEvenement();


            foreach (var item in liste.listEvenement)
            {
                listBoxEvent.Items.Add(item.titreEvenement);
            }




        }
    }
}
