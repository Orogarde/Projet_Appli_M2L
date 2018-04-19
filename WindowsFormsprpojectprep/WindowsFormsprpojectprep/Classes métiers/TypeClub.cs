using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
   public class TypeClub
    {
     

        public int id { get; set; }
        public string libelle { get; set; }


            public TypeClub(string libelle)
                {
                     this.libelle = libelle;
                }
    }
}
