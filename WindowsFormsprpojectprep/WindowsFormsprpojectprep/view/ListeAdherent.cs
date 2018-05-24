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
    public partial class ListeAdherent : MetroForm
    {
        public int index;
        adhérent adherentModif;
        public AdherentManagement adherent;
        
        DAOadherent connect = new DAOadherent();

        public ListeAdherent(AdherentManagement adherent)

        {
            InitializeComponent();
            this.adherent = adherent;

        }

        private void formL_Load(object sender, EventArgs e)
        {

            foreach (var item in adherent.Getadherent())
            {

                metroGridAdherent.AutoGenerateColumns = true;
                metroGridAdherent.AutoResizeColumns();
                adherent.listM = connect.ReadadherentSansClub();
                adherent.listM.AddRange(connect.Readadherent());
                metroGridAdherent.DataSource = adherent.Getadherent();
                

            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGridAdherent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGridAdherent_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = metroGridAdherent.CurrentRow.Index;
            adherentModif = adherent.GetAdhérentliste(index);
            ModifierAdherent modif = new ModifierAdherent(adherent, adherentModif);
            modif.ShowDialog();

        }
    }
}
