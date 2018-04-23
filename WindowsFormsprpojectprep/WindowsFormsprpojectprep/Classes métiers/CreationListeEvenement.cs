using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
    class CreationListeEvenement
    {
        public static List<Evenement> creationliste()
        {
            List<Evenement> listcréer = new List<Evenement>();
            DAOEvenement connect = new DAOEvenement();

            listcréer = connect.ReadEvenement();



            return listcréer;
        }
    }
}
