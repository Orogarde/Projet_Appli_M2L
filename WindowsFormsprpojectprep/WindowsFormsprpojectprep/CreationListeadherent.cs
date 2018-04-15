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
               DBconnect connect = new DBconnect();

            listcréer = connect.Readadherent();


            
            return listcréer;
        }
    }
}
