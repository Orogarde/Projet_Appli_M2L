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
    public partial class Supprimer : Form
    {
        public AdherentManagement adherent;
        public int index;
        public Supprimer(AdherentManagement adherent)
        {
            InitializeComponent();
            this.adherent = adherent;
        }

        private void Supprimer_Load(object sender, EventArgs e)
        {
            foreach (var item in adherent.Getadherent())
            {
                listBoxSupprimer.Items.Add(item.nom + " " + item.prenom);
            }

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            adherent.suppression(index);
            refresh();
        }

        

        private void refresh()
        {
            for (int i = 0; i < listBoxSupprimer.Items.Count; i++)
            {
                listBoxSupprimer.Items.Remove(i);
            }

            listBoxSupprimer.Items.Clear();
            foreach (var item in adherent.Getadherent())
            {
                listBoxSupprimer.Items.Add(item.nom + "  " + item.prenom);
            }
        }

        private void listBoxSupprimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxSupprimer.SelectedIndex;
            
        }
    }
}
