using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat.Model;

namespace Szakdolgozat.Repository.TestDatabase
{
    partial class RepositoryDatabase
    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        public RepositoryDatabase()
        {
            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();
        }

        public void getCreateDatabase()
        {
            MySqlConnection connection =
                new MySqlConnection(connectionStringCreate);
            try
            {
                connection.Open();
                string queryCreateDatabase = "CREATE DATABASE IF NOT EXISTS `palyazatszamontarto` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;" +
                               "USE `palyazatszamontarto`;";
                MySqlCommand cmd = new MySqlCommand(queryCreateDatabase, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Adatbázis létrehozás nem sikerült vagy már létezik.");
            }
        }

        public void getDeleteDatabase()
        {
            MySqlConnection connection =
                new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryDeleteDatabase = "DROP DATABASE palyazatszamontarto";
                MySqlCommand cmd = new MySqlCommand(queryDeleteDatabase, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Adatbázis törlése nem sikerült.");
            }
        }
    }
}
