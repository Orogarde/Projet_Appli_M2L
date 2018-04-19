using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
    public class Club
    {   public int id { get; set; }
        public string titre { get; set; }
        public string url { get; set; }
        public string ville { get; set; }
        public string numero { get; set; }
        public string codepostal { get; set; }
        public string mail { get; set; }
        public int idType { get; set; }
        public string Adresse { get; set; }
        public TypeClub Type { get; set; }


        public Club(string titre, string url, string ville, string numero, string codepostal, string mail, int idType, string adresse)
        {
            this.titre = titre;
            this.url = url;
            this.ville = ville;
            this.numero = numero;
            this.codepostal = codepostal;
            this.mail = mail;
            this.idType = idType;
            this.Adresse = adresse;
        }

     
    }
   
}
