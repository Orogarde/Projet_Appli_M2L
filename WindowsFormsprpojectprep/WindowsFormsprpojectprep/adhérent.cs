﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
     public class adhérent
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string ville { get; set; }
        public string numero { get; set; }
        public string codepostal { get; set; }
        public double cotisation { get; set; }
        public DateTime date { get; set; }
        public string Adresse { get; set; }
        public adhérent(string nom, string prenom,string ville,string numero,string codepostal,double cotisation,string Adresse, DateTime date)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
            this.numero = numero;
            this.codepostal = codepostal;
            this.cotisation = cotisation;
            this.Adresse = Adresse;
            this.date = date;
        }

        public string Affichage()
        {
            return nom + " " + prenom;
        }

       
    }
}

