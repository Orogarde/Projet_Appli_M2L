using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
    class Creationadd
    {
        public Creationadd()
        {

        }

        public static List<adhérent> creationliste()
        {
            List<adhérent> listcréer = new List<adhérent>();
            listcréer.Add(new adhérent("dieu", "koukou",DateTime.Now));
            listcréer.Add(new adhérent("swag", "ouai",DateTime.Now));
            return listcréer;
        }
    }
}
