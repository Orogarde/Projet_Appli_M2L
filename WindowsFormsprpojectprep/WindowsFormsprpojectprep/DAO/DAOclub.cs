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
        public MySqlConnection connexion { get; set; }

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
            try

            { this.connexion = new MySqlConnection(connectionString); }
            catch { Console.WriteLine("erreur"); }


        }



        /// <summary>
        /// La méthode ReadClub retourne une liste de tout les clubs  dans la table. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Club> ReadClub ()
        {
            List<Club>liste= new List<Club>();
            TypeClub type;
            Club clubs;
            using ( connexion )
            {
                connexion.Open();
                string requete = "SELECT * FROM club join type_club on club.id_type_club = type_club.id_type_club ";


                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        clubs = new Club(
                            (string)datareader["Titre_club"], (string)datareader["url_club"],
                            (string)datareader["Ville_club"], (string)datareader["telephone_club"], (string)datareader["Code_Postal_club"],
                            (string)datareader["mail_club"],  (int)datareader["id_type_club"], (string)datareader["Adresse_club"]);

                        type = new TypeClub(
                           (string)datareader["libelle"]);

                        type.id = (int)datareader["id_type_club"];
                       

                        clubs.id = (int)datareader["id_club"];
                        clubs.Type = type;
                        liste.Add(clubs);

                    }

                }
            }
            return liste;
        }
        /// <summary>
        /// delete d'un club en fonction d'un club ( de l'id de ce club )
        /// </summary>
        /// <param name="club"></param>

        public void supprimerClub(Club club)
        {
            using ( connexion )
            {
                connexion.Open();
                string requete = "DELETE FROM club WHERE id_club = @id";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@id", club.id);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// utilisation de la procédure stocké count_adherent pour avoir le nombre d'adherents d'un club
        /// </summary>
        /// <param name="club"></param>
        /// <returns></returns>
        public int countAdherentClub(Club club)
        {
            int count=0;
            using ( connexion )
            {

                connexion.Open();
               string requete = "call count_adherent(@id)";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@id", club.id);
                cmd.ExecuteNonQuery();

                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        count = Convert.ToInt32(datareader["nbradh"]);
                    }
                }
                
            }
            return count;
        }
        /// <summary>
        ///  utilisation de la procédure stocké count_event pour avoir le nombre d'evenements d'un club
        /// </summary>
        /// <param name="club"></param>
        /// <returns></returns>
        public int countEventClub(Club club)
        {
            int count = 0;
            using ( connexion )
            {

                connexion.Open();
                string requete = "call count_event(@id)";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@id", club.id);
                cmd.ExecuteNonQuery();

                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        count = Convert.ToInt32(datareader["nbevent"]);
                    }
                }

            }
            return count;
        }
        /// <summary>
        /// insert dans la table des données saisies d'un club
        /// </summary>
        /// <param name="club"></param>
        public void ajouterClub(Club club)
        {
            using ( connexion )
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
        /// <summary>
        /// update dans la table d'un club en fonction des données saisies
        /// </summary>
        /// <param name="club"></param>
        public void ModifClub(Club club)
        {
            using ( connexion )
            {
                connexion.Open();
                string requete = "UPDATE `club` SET `Titre_club` = @titre, `url_club` = @url, `Adresse_club` = @adresse, `Code_Postal_club` = @code, `Ville_club` = @ville, `mail_club` = @mail, `telephone_club` = @telephone WHERE `club`.`id_club` = @id ;";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@titre", club.titre);
                cmd.Parameters.AddWithValue("@url", club.url);
                cmd.Parameters.AddWithValue("@adresse", club.Adresse);
                cmd.Parameters.AddWithValue("@code", club.codepostal);
                cmd.Parameters.AddWithValue("@ville", club.ville);
                cmd.Parameters.AddWithValue("@mail", club.mail);
                cmd.Parameters.AddWithValue("@telephone", club.numero);
                cmd.Parameters.AddWithValue("@id", club.id);

                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// readType retourne la liste des types de clubs
        /// </summary>
        /// <returns></returns>
        public List<TypeClub> ReadType()
        {
            List<TypeClub> liste = new List<TypeClub>();

            TypeClub type;
            using ( connexion )
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
