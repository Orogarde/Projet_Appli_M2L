using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
     public class adhérent
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime date { get; set; }

        public adhérent(string nom, string prenom,DateTime date)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.date = date;
        }

        public string Affichage()
        {
            return nom + " " + prenom;
        }

       
    }
}

