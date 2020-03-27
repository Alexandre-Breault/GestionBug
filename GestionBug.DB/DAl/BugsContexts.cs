using GestionBug.DB.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBug.DB.DAl
{

    public class BugsContexts
    {
        private string connectionString;
        public BugsContexts(string connectionString)
        {
            this.connectionString = connectionString;
        }
        /// <summary>
        /// Récupère toutes les personnes de la BDD 
        /// </summary>
        /// <returns>Les personnes de la BDD</returns>
        public List<Bug> GetAll()
        {
            List<Bug> bugs = new List<Bug>();

            using (MySqlConnection connection = new MySqlConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT identifiant, Titre, dateBug, EstBloquant, identifiantSeverite FROM Bugs;";

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Bug bug = new Bug();
                    bug.Identifiant = reader.GetInt32("identifiant");
                    bug.Titre = reader.GetString("Titre");
                    bug.DateBug = reader.GetDateTime("dateBug");
                    bug.EstBloquant = reader.GetBoolean("EstBloquant");
                    bug.IdentifiantSeverite = reader.GetInt16("identifiantSeverite");

                    bugs.Add(bug);
                }

            }

            return bugs;
        }
    }
}
