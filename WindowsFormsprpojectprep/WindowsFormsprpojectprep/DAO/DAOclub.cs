﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
    class DAOclub
    {
        private string connectionString;

        //Constructor
        public DAOclub()
        {
            Initialize();
        }

        /// <summary>
        /// Initialise les champs et cree un objet connection.
        /// </summary>
        private void Initialize()
        {
            string server = "localhost";
            string port = "3306";
            string database = "m2l_aplication";
            string uid = "root";
            string password = "";
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        }



        /// <summary>
        /// La méthode Read retourne un fournisseur en fonction de l'id dans la table. 
        /// </summary>
        /// <param name="id">id du fournisseur recherché</param>
        /// <returns></returns>
        public List<Club> ReadClub ()
        {
            List<Club>liste= new List<Club>();
                
            Club clubs;
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                connexion.Open();
                string requete = "SELECT * FROM club";


                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        clubs = new Club(
                            (string)datareader["Titre_club"], (string)datareader["url_club"],
                            (string)datareader["Ville_club"], (string)datareader["telephone_club"], (string)datareader["Code_Postal_club"],
                            (string)datareader["mail_club"],  (int)datareader["id_type_club"], (string)datareader["Adresse_club"]);


                        clubs.id = (int)datareader["id_club"];
                        liste.Add(clubs);

                    }

                }
            }
            return liste;
        }

        public void supprimerAdherent(adhérent adhérents)
        {
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                connexion.Open();
                string requete = "DELETE FROM adherent WHERE id_adherent = @id";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@id", adhérents.id);
                cmd.ExecuteNonQuery();
            }
        }
        public void ajouterAdherent(adhérent adhérents)
        {
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                connexion.Open();
                string requete = "INSERT INTO `adherent` (`id_adherent`, `numero_licence`, `Nom_adherent`, `Prenom_adherent`, `Date_naissance_adherent`, `Adresse_adherent`, `Code_Postal_adherent`, `Ville_adherent`, `cotisation_adherent`, `id_club`) VALUES (NULL, @numero, @nom, @prenom, @date, @adresse, @codepostal, @ville, @cotisation, NULL);";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@nom", adhérents.nom);
                cmd.Parameters.AddWithValue("@prenom", adhérents.prenom);
                cmd.Parameters.AddWithValue("@date", adhérents.date);
                cmd.Parameters.AddWithValue("@adresse", adhérents.Adresse);
                cmd.Parameters.AddWithValue("@codepostal", adhérents.codepostal);
                cmd.Parameters.AddWithValue("@ville", adhérents.ville);
                cmd.Parameters.AddWithValue("@numero", adhérents.numero);
                cmd.Parameters.AddWithValue("@cotisation", adhérents.cotisation);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
