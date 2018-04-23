using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
   public class EvenementManagement
    {
        public List<Evenement> listEvenement{ get; set; }

        public EvenementManagement()
        {
            listEvenement = CreationListeEvenement.creationliste();
        }



        public Evenement GetEvenementliste(int i)
        {
            return listEvenement[i];
        }

        public List<Evenement> GetEvenements()
        {
            return listEvenement;
        }
    }
}
