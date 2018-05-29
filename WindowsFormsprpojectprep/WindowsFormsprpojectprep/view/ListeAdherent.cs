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

            

                metroGridAdherent.AutoGenerateColumns = true;
                metroGridAdherent.AutoResizeColumns();
                adherent.listM = connect.ReadadherentSansClub();
                adherent.listM.AddRange(connect.Readadherent());
                foreach (adhérent adh in adherent.listM)
                {
                    try
                    {   metroGridAdherent.Rows.Add(adh.prenom, adh.nom, adh.club.titre, adh.Adresse, adh.date, adh.cotisation, adh.numero);
                    }
                    catch
                    { metroGridAdherent.Rows.Add(adh.prenom, adh.nom,"aucun club", adh.Adresse, adh.date, adh.cotisation, adh.numero); }
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

        private void metroButtonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
