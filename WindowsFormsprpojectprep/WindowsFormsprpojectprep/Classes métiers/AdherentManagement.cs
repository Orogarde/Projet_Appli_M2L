using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
    public class AdherentManagement
    {
       
        public List<adhérent> listM { get; set; }

        public AdherentManagement()
        {
            listM = CreationListeadherent.creationliste();
        }

        public void AjouterAdherent(adhérent adherent)
        {
            

           
            listM.Add(adherent);

        }

        public adhérent GetAdhérentliste(int i)
        {
            return listM[i];
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
