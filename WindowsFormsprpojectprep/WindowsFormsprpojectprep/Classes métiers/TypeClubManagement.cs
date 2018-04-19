using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
    public class TypeClubManagement
    {
        public List<TypeClub> listTypesClubs { get; set; }

        public TypeClubManagement()
        {
            listTypesClubs = CreationListeTypeClub.creationliste();

        }

        public TypeClub GetTypeClubliste(int i)
        {
            return listTypesClubs[i];
        }

        public List<TypeClub> GetClubs()
        {
            return listTypesClubs;
        }
    }
}
