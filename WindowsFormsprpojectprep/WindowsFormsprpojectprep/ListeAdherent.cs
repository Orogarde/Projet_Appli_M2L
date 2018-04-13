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
    public partial class ListeAdherent : Form
    {
        public AdherentManagement adherent;

        public ListeAdherent(AdherentManagement adherent)

        {
            InitializeComponent();
            this.adherent = adherent;

        }

        private void formL_Load(object sender, EventArgs e)
        {

            foreach (var item in adherent.Getadherent())
            {

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.AutoResizeColumns();
                dataGridView1.DataSource = adherent.Getadherent();
                

            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
