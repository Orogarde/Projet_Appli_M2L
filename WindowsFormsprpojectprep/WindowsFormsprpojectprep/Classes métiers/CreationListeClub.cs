using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
    class CreationListeClub
    {
        public static List<Club> creationliste()
        {

            List<Club> listcréer = new List<Club>();
            DAOclub connect = new DAOclub();

            listcréer = connect.ReadClub();



            return listcréer;
        }
    }
}
