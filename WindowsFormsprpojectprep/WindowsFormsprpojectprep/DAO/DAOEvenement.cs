using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsprpojectprep
{
    class DAOEvenement
    {
        private string connectionString;

        //Constructor
        public DAOEvenement()
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
        public List<Evenement> ReadEvenement()
        {
            List<Evenement> liste = new List<Evenement>();

            Evenement evenements ;
            Club club;
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                connexion.Open();

                string requete = "SELECT debut_evenement, fin_evenement,Titre_evenement,id_evenement,club.id_club,Titre_club,url_club,Adresse_club,Code_Postal_club,Ville_club,mail_club,id_type_club,telephone_club FROM evenement INNER join club on evenement.id_club = club.id_club ";


                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        evenements= new Evenement((DateTime)datareader["debut_evenement"], (DateTime)datareader["fin_evenement"], (string)datareader["Titre_evenement"]);

                        club = new Club(
                          (string)datareader["Titre_club"], (string)datareader["url_club"],
                          (string)datareader["Ville_club"], (string)datareader["telephone_club"], (string)datareader["Code_Postal_club"],
                          (string)datareader["mail_club"], (int)datareader["id_type_club"], (string)datareader["Adresse_club"]);


                        club.id = (int)datareader["id_club"];


                        evenements.idEvenement = (int)datareader["id_evenement"];
                        evenements.club = club;

                      
                        liste.Add(evenements);

                    }

                }
            }
            return liste;
        }
       
        public void supprimerEvenement(Evenement evenement )
        {
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                connexion.Open();
                string requete = "DELETE FROM evenement WHERE id_evenement = @id";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@id", evenement.idEvenement);
                cmd.ExecuteNonQuery();
            }
        }
      
        public void ajouterEvenement(Evenement evenement)
        {
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                connexion.Open();
                string requete = "INSERT INTO `evenement` (`id_evenement`, `Titre_evenement`, `debut_evenement`, `fin_evenement`, `id_club`) VALUES (NULL, @titre, @dateDebut,@dateFin, @idClub);";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@titre", evenement.titreEvenement);
                cmd.Parameters.AddWithValue("@dateDebut", evenement.debutEvenement);
                cmd.Parameters.AddWithValue("@dateFin", evenement.finEvenement);
                cmd.Parameters.AddWithValue("@idClub", evenement.club.id);
                
                cmd.ExecuteNonQuery();
            }
        }
    }
}
