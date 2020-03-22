using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Szakdolgozat.model;
using Szakdolgozat.Model;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Szakdolgozat.Repository
{
    partial class RepositoryDatabaseTableVezetoSQL
    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;
        public RepositoryDatabaseTableVezetoSQL()
        {
            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();
        }
        public List<Vezeto> getVezetoFromDatabaseTable()
        {
            List<Vezeto> vezetok = new List<Vezeto>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Vezeto.getAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id"]);
                    string nev = dr["Nev"].ToString();
                    string telefonszam = dr["Telefonszam"].ToString();
                    string email = dr["Email"].ToString();
                    Vezeto t = new Vezeto(id, nev, telefonszam, email);
                    vezetok.Add(t);
                }
                connection.Close();
            } 
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Vezető adatainak beolvasása az adatbázisból nem sikerült!");
            }
            return vezetok;
        }

        public void deleteVezetoFromDatabase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryDelete = "DELETE FROM vezetok WHERE id = " + id;
                MySqlCommand cmd = new MySqlCommand(queryDelete, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(id + " -jú vezető törlése nem sikerült.");
                throw new RepositoryException("Sikertelen törlés az adatbázisból.");
            }
        }

        public void updateVezetokInDatabase(int id, Vezeto modified)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = modified.getUpdate(id);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Vezető módosítása nem sikerült.");
                throw new RepositoryException("Sikertelen módosítás az adatbázisból.");
            }
        }

        public void insertVezetoIntoDatabase(Vezeto ujVezeto)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = ujVezeto.getInsertIntoVezetok();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(ujVezeto + " vezető beszúrása adatbázisba nem sikerült.");
                throw new RepositoryException("Sikertelen beszúrás az adatbázisba.");
            }
        }
        public int getVezetoID()
        {
            int legnagyobbID;
            List<int> id = new List<int>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Vezeto.getVezetokLegnagyobbID();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int vezetoID = Convert.ToInt32(dr["id"]);
                    id.Add(vezetoID);
                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("A legnagyobb vezető id lekérése nem sikerült az adatbázisból nem sikerült!");
            }
            legnagyobbID = id.Max();
            return legnagyobbID;
        }
    }
}
