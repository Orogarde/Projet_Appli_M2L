using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsprpojectprep
{
    public partial class ListeClub : MetroForm
    {
        public ClubManagement Liste;

        DAOclub connect = new DAOclub();
        public int index;
        public Club clubAmodif;

        public ListeClub(ClubManagement club)
        {
            InitializeComponent();
            this.Liste = club;
        }

        private void ListeClub_Load(object sender, System.EventArgs e)
        {

                metroGridClubs.AutoGenerateColumns = true;
                metroGridClubs.AutoResizeColumns();
                Liste.listClubs = connect.ReadClub();
                foreach(Club club in Liste.listClubs)
                {

                metroGridClubs.Rows.Add(club.titre, club.ville, club.url,club.mail, club.numero,club.codepostal ,club.Type.libelle);
                    
                   
                }



            
        }

        private void metroGridClubs_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = metroGridClubs.CurrentRow.Index;
            clubAmodif = Liste.GetClubliste(index);
            ModifClub modif = new ModifClub(Liste, clubAmodif);
            modif.ShowDialog();
        }

        private void metroButtonRetour_Click(object sender, System.EventArgs e)
        {
            this.Close();
           
        }
    }
}
