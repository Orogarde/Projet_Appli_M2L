using MySql.Data.MySqlClient;
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

        public void supprimerClub(Club club)
        {
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                connexion.Open();
                string requete = "DELETE FROM club WHERE id_club = @id";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@id", club.id);
                cmd.ExecuteNonQuery();
            }
        }
        public void ajouterClub(Club club)
        {
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                connexion.Open();
                string requete = "INSERT INTO `club` (`id_club`, `Titre_club`, `url_club`, `Adresse_club`, `Code_Postal_club`, `Ville_club`, `mail_club`, `telephone_club`, `id_type_club`) VALUES (NULL, @titre, @url, @adresse, @code, @ville, @mail, @telephone, @idtype)";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@titre", club.titre);
                cmd.Parameters.AddWithValue("@url", club.url );
                cmd.Parameters.AddWithValue("@adresse", club.Adresse);
                cmd.Parameters.AddWithValue("@code", club.codepostal);
                cmd.Parameters.AddWithValue("@ville", club.ville);
                cmd.Parameters.AddWithValue("@mail", club.mail);
                cmd.Parameters.AddWithValue("@telephone", club.numero);
                cmd.Parameters.AddWithValue("@idtype", club.Type.id);
                cmd.ExecuteNonQuery();
            }
        }
        public List<TypeClub> ReadType()
        {
            List<TypeClub> liste = new List<TypeClub>();

            TypeClub type;
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                connexion.Open();
                string requete = "SELECT * FROM type_club";


                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        type = new TypeClub(
                            (string)datareader["libelle"]);

                        type.id = (int)datareader["id_type_club"];
                        liste.Add(type);

                    }

                }
            }
            return liste;
        }
    }
}
