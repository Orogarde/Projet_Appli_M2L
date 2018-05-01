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
    public partial class desinscrire : MetroForm
    {
        public adhérent adhérentselectionner;
        DAOadherent connect = new DAOadherent();
        
        public AdherentManagement adherent;
        public int index;

        public desinscrire(AdherentManagement adherent)
        {
            
            this.adherent = adherent;
            InitializeComponent();
        }

        private void desinscrire_Load(object sender, EventArgs e)
        {
            adherent.listM = connect.ReadadherentAvecClub();

            foreach (var item in adherent.listM)
            {
                listBoxadherent.Items.Add(item.nom + " " + item.prenom);
            }
        }

        private void listBoxadherent_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxadherent.SelectedIndex;
        }

       

        private void metroButtonDesinscrire_Click(object sender, EventArgs e)
        {
            adhérentselectionner = adherent.GetAdhérentliste(index);


            adherent.GetAdhérentliste(index);


            connect.EnleverAdherentAclub(adhérentselectionner);
            //  adherent.suppression(index);


            listBoxadherent.Items.Clear();
            adherent.listM = connect.ReadadherentAvecClub();

            foreach (var item in adherent.listM)
            {
                listBoxadherent.Items.Add(item.nom + " " + item.prenom);
            }
        }
    }
}
