using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
    class CreationListeadherent
    {
        public CreationListeadherent()
        {

        }

        public static List<adhérent> creationliste()
        {

            List<adhérent> listcréer = new List<adhérent>();
               DAOadherent connect = new DAOadherent();

           // listcréer = connect.Readadherent() ;
           // listcréer.AddRange(connect.ReadadherentSansClub());
           listcréer = connect.ReadadherentSansClub();
            listcréer.AddRange(connect.Readadherent());



            return listcréer;
        }
    }
}
