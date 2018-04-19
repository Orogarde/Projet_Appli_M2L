using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
   public class CreationListeTypeClub
    {

        public static List<TypeClub> creationliste()
        {
            List<TypeClub> listcréer = new List<TypeClub>();
            DAOclub connect = new DAOclub();

            listcréer = connect.ReadType();




            return listcréer;

        }
    }
}
