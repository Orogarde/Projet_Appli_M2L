using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
    public class AdherentManagement
    {
       
        private List<adhérent> listM { get; set; }

        public AdherentManagement()
        {
            listM = CreationListeadherent.creationliste();
        }

        public void AjouterAdherent(adhérent adherent)
        {
            DBconnect connect = new DBconnect();

           
            listM.Add(adherent);

        }

        public List<adhérent> Getadherent()
        {
            return listM;
        }
        public void suppression(int i)
        {
            listM.RemoveAt(i);
        }

    }
}
