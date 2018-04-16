using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
    public class ClubManagement
    {
        public List<Club> listClubs { get; set; }

    public ClubManagement()
    {
        listClubs = CreationListeClub.creationliste();
    }

  

    public Club GetClubliste(int i)
    {
        return listClubs[i];
    }

    public List<Club> GetClubs()
    {
        return listClubs;
    }
   

}
}
