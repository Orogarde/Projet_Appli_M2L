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
    public partial class ListeEvenement : Form
    {
        public EvenementManagement liste;

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

                dataGridViewEvent.AutoGenerateColumns = true;
                dataGridViewEvent.AutoResizeColumns();
                liste.listEvenement = connect.ReadEvenement();
                dataGridViewEvent.DataSource = liste.GetEvenements();


            }
        }
    }
}
