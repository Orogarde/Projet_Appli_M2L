using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
  public class Evenement
    {
     

        public int idEvenement { get; set; }
        public DateTime debutEvenement { get; set; }
        public DateTime finEvenement { get; set; }
        public string titreEvenement { get; set; }
        public Club club { get; set; }


   public Evenement(DateTime debutEvenement, DateTime finEvenement, string titreEvenement)
        {
            this.debutEvenement = debutEvenement;
            this.finEvenement = finEvenement;
            this.titreEvenement = titreEvenement;
        }

    }
}
