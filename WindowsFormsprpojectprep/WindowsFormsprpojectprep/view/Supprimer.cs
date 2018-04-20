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
        public adhérent adhérentselectionner;
        
      //  public List<adhérent> liste = new List<adhérent>();
        public AdherentManagement adherent;
       
      DAOadherent connect = new DAOadherent();


        public int index;
        public Supprimer(AdherentManagement adherent)
        {
            InitializeComponent();
            this.adherent = adherent;
        }

        private void Supprimer_Load(object sender, EventArgs e)
        {
            adherent.listM = connect.ReadadherentSansClub();
            adherent.listM.AddRange(connect.Readadherent());

            foreach (var item in adherent.listM)
            {
                listBoxSupprimer.Items.Add(item.nom + " " + item.prenom);
            }

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
             

           adhérentselectionner= adherent.GetAdhérentliste(index);


            adherent.GetAdhérentliste(index);
            
           
            connect.supprimerAdherent(adhérentselectionner);
            //  adherent.suppression(index);
            
            
            listBoxSupprimer.Items.Clear();
            adherent.listM = connect.ReadadherentSansClub();
            adherent.listM.AddRange(connect.Readadherent());
            foreach (var item in adherent.listM)
            {
                listBoxSupprimer.Items.Add(item.nom + " " + item.prenom);
            }



        }



        /*  private void refresh()
          {
              for (int i = 0; i < listBoxSupprimer.Items.Count; i++)
              {
                  listBoxSupprimer.Items.Remove(i);
              }

              listBoxSupprimer.Items.Clear();
             foreach (var item in adherent.listM)
              {
                  listBoxSupprimer.Items.Add(item.nom + "  " + item.prenom);
             }
          }*/

        private void listBoxSupprimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxSupprimer.SelectedIndex;
            label1.Text =Convert.ToString(index);
            
           // adhérentselectionner = listBoxSupprimer.SelectedIted;
            
        }
    }
}
