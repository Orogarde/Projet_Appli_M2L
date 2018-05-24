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
    public partial class ListeEvenement : MetroForm
    {
        public EvenementManagement liste;
        public Evenement eventModif;
        public int index;

        DAOEvenement connect = new DAOEvenement();

        public ListeEvenement(EvenementManagement liste)
        {
            InitializeComponent();
            this.liste = liste;
        }

        private void ListeEvenement_Load(object sender, EventArgs e)
        {
            foreach (var item in liste.listEvenement)
            {

                metroGridEvent.AutoGenerateColumns = true;
                metroGridEvent.AutoResizeColumns();
                liste.listEvenement = connect.ReadEvenement();
                metroGridEvent.DataSource = liste.GetEvenements();


            }
        }

        private void metroGridEvent_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         index = metroGridEvent.CurrentRow.Index;
          eventModif =  liste.GetEvenementliste(index);
            ModifEvenement modif = new ModifEvenement(liste, eventModif);
            modif.ShowDialog();
        }
    }
}
