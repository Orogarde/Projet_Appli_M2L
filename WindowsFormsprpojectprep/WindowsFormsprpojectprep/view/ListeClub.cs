using System.Windows.Forms;

namespace WindowsFormsprpojectprep
{
    public partial class ListeClub : Form
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

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.AutoResizeColumns();
                Liste.listClubs = connect.ReadClub();
                dataGridView1.DataSource = Liste.GetClubs();


            }
        }
    }
}
