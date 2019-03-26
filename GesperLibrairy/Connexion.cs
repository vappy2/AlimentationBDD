using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GesperLibrary
{
    public class Connexion
    {
        private MySqlConnection cnx;

        public MySqlConnection getcnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public Connexion (string user, string password, string host, string database)
        {
            string sConnexion = String.Format("host ={0}; user={1}; password={2}; database={3}", host, user, password, database);
            cnx = new MySqlConnection(sConnexion);
                               }

        public void DeConnexion()
        {
            cnx.Close();
        }

        public void Ouvrir() {
            cnx.Open();
        }
    }
}
