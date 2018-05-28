﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
    class DAOadherent
    {
        private string connectionString;
        public MySqlConnection connexion { get; set; }
        //Constructor
        public DAOadherent()
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
            try

            { this.connexion = new MySqlConnection(connectionString); }
            catch { Console.WriteLine("erreur"); }
        }



        /// <summary>
        /// La méthode Readadherent retourne une liste de tout les adhernents dans la table. 
        /// </summary>
        /// <param ></param>
        /// <returns></returns>
        public List<adhérent> Readadherent()
        {
           List <adhérent>liste = new List<adhérent>();
            
            adhérent adhérents;
            Club club;
            
            
                using (connexion)
                {
                    connexion.Open();

                    string requete = "SELECT id_adherent, Nom_adherent,numero_licence, Prenom_adherent, Date_naissance_adherent , Adresse_adherent, Code_Postal_adherent,Ville_adherent,cotisation_adherent,club.id_club,Titre_club,url_club,Adresse_club,Code_Postal_club,Ville_club,mail_club,id_type_club,telephone_club FROM adherent INNER join club on adherent.id_club = club.id_club";


                    MySqlCommand cmd = new MySqlCommand(requete, connexion);
                    using (MySqlDataReader datareader = cmd.ExecuteReader())
                    {
                        while (datareader.Read())
                        {
                            adhérents = new adhérent((string)datareader["Nom_adherent"],
                                (string)datareader["Prenom_adherent"], (string)datareader["Ville_adherent"],
                                (string)datareader["numero_licence"], (string)datareader["Code_Postal_adherent"],
                                Convert.ToDouble(datareader["cotisation_adherent"]), (DateTime)datareader["Date_naissance_adherent"], (string)datareader["Adresse_adherent"]);

                            club = new Club(
                               (string)datareader["Titre_club"], (string)datareader["url_club"],
                               (string)datareader["Ville_club"], (string)datareader["telephone_club"], (string)datareader["Code_Postal_club"],
                               (string)datareader["mail_club"], (int)datareader["id_type_club"], (string)datareader["Adresse_club"]);


                            club.id = (int)datareader["id_club"];

                            adhérents.id = (int)datareader["id_adherent"];
                            adhérents.club = club;
                            liste.Add(adhérents);

                        }

                    }
                }
         
            return liste;
            
            
        }
        /// <summary>
        /// retourne une liste de tout les adherents sans club dans la table 
        /// </summary>
        /// <returns></returns>
        public List<adhérent> ReadadherentSansClub()
        {
            List<adhérent> liste = new List<adhérent>();

            adhérent adhérents;
           
            using ( connexion )
            {
                connexion.Open();

                string requete = "SELECT * FROM adherent where adherent.id_club is Null";


                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        adhérents = new adhérent((string)datareader["Nom_adherent"],
                            (string)datareader["Prenom_adherent"], (string)datareader["Ville_adherent"],
                            (string)datareader["numero_licence"], (string)datareader["Code_Postal_adherent"],
                            Convert.ToDouble(datareader["cotisation_adherent"]), (DateTime)datareader["Date_naissance_adherent"], (string)datareader["Adresse_adherent"]);



                        adhérents.id = (int)datareader["id_adherent"];
                        
                        liste.Add(adhérents);

                    }

                }
            }
            return liste;
        }
        /// <summary>
        /// retourne une liste de tout les adherents avec club dans la table
        /// </summary>
        /// <returns></returns>
        public List<adhérent> ReadadherentAvecClub()
        {
            List<adhérent> liste = new List<adhérent>();

            adhérent adhérents;

            using ( connexion )
            {
                connexion.Open();

                string requete = "SELECT * FROM adherent where adherent.id_club is not Null";


                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        adhérents = new adhérent((string)datareader["Nom_adherent"],
                            (string)datareader["Prenom_adherent"], (string)datareader["Ville_adherent"],
                            (string)datareader["numero_licence"], (string)datareader["Code_Postal_adherent"],
                            Convert.ToDouble(datareader["cotisation_adherent"]), (DateTime)datareader["Date_naissance_adherent"], (string)datareader["Adresse_adherent"]);



                        adhérents.id = (int)datareader["id_adherent"];

                        liste.Add(adhérents);

                    }

                }
            }
            return liste;
        }
        /// <summary>
        /// delete un adherent de la table en fonction de l'id
        /// </summary>
        /// <param name="adhérents"></param>
        public void supprimerAdherent(adhérent adhérents)
        {
            using (connexion )
            {
                connexion.Open();
                string requete = "DELETE FROM adherent WHERE id_adherent = @id";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@id", adhérents.id);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// update dans la table de la clé étrangère id_club d'un adherent en fonction de l'id du club
        /// </summary>
        /// <param name="adhérents"></param>
        public void AjoutAdherentAclub(adhérent adhérents)
        {
            using ( connexion )
            {
                connexion.Open();
                string requete = "UPDATE adherent SET id_club = @idclub WHERE adherent.id_adherent = @id;";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@id", adhérents.id);
                cmd.Parameters.AddWithValue("@idclub", adhérents.club.id);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        ///  update dans la table de la clé étrangère id_club d'un adherent en NULL
        /// </summary>
        /// <param name="adhérents"></param>
        public void EnleverAdherentAclub(adhérent adhérents)
        {
            using (connexion )
            {
                connexion.Open();
                string requete = "UPDATE adherent SET id_club = Null WHERE adherent.id_adherent = @id;";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@id", adhérents.id);

                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// insert dans la table d'un adherent avec les  données saisies
        /// </summary>
        /// <param name="adhérents"></param>
        public void ajouterAdherent(adhérent adhérents)
        {
            using ( connexion )
            { 
                connexion.Open();
                string requete = "INSERT INTO `adherent` (`id_adherent`, `numero_licence`, `Nom_adherent`, `Prenom_adherent`, `Date_naissance_adherent`, `Adresse_adherent`, `Code_Postal_adherent`, `Ville_adherent`, `cotisation_adherent`, `id_club`) VALUES (NULL, @numero, @nom, @prenom, @date, @adresse, @codepostal, @ville, @cotisation, NULL);";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@nom", adhérents.nom);
                cmd.Parameters.AddWithValue("@prenom", adhérents.prenom);
                cmd.Parameters.AddWithValue("@date",adhérents.date);
                cmd.Parameters.AddWithValue("@adresse", adhérents.Adresse);
                cmd.Parameters.AddWithValue("@codepostal", adhérents.codepostal);
                cmd.Parameters.AddWithValue("@ville", adhérents.ville);
                cmd.Parameters.AddWithValue("@numero", adhérents.numero);
                cmd.Parameters.AddWithValue("@cotisation", adhérents.cotisation);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// update dans la table d'un adherent en fonction de l'id des modifications des données
        /// </summary>
        /// <param name="adhérents"></param>
        public void ModifAdherent(adhérent adhérents)
        {
            using ( connexion )
            {
                connexion.Open();
                string requete = "UPDATE `adherent` SET `Nom_adherent` = @nom, `Prenom_adherent` = @prenom, `Date_naissance_adherent` = @date, `Adresse_adherent` = @adresse, `Code_Postal_adherent` = @codepostal, `Ville_adherent` = @ville, `cotisation_adherent` = @cotisation WHERE `adherent`.`id_adherent` = @id";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@nom", adhérents.nom);
                cmd.Parameters.AddWithValue("@prenom", adhérents.prenom);
                cmd.Parameters.AddWithValue("@date", adhérents.date);
                cmd.Parameters.AddWithValue("@adresse", adhérents.Adresse);
                cmd.Parameters.AddWithValue("@codepostal", adhérents.codepostal);
                cmd.Parameters.AddWithValue("@ville", adhérents.ville);
                cmd.Parameters.AddWithValue("@cotisation", adhérents.cotisation);
                cmd.Parameters.AddWithValue("@id", adhérents.id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
       




