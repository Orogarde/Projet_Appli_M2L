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
            foreach (var item in Liste.GetClubs ())
            {

                metroGridClubs.AutoGenerateColumns = true;
                metroGridClubs.AutoResizeColumns();
                Liste.listClubs = connect.ReadClub();
                metroGridClubs.DataSource = Liste.GetClubs();


            }
        }

        private void metroGridClubs_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = metroGridClubs.CurrentRow.Index;
            clubAmodif = Liste.GetClubliste(index);
            ModifClub modif = new ModifClub(Liste, clubAmodif);
            modif.ShowDialog();
        }
    }
}
