using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsprpojectprep
{
    public partial class ListeClub : MetroForm
    {
        public ClubManagement Liste;

        DAOclub connect = new DAOclub();

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
    }
}
