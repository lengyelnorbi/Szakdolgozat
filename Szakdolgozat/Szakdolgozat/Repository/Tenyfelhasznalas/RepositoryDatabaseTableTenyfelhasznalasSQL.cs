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
    partial class RepositoryDatabaseTableTenyfelhasznalasSQL
    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;
        public RepositoryDatabaseTableTenyfelhasznalasSQL()
        {
            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();
        }

        public List<Tenyfelhasznalas> getTenyfelhasznalasFromDatabaseTable(string Azonosito)
        {
            List<Tenyfelhasznalas> tenyfelhasznalas = new List<Tenyfelhasznalas>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Tenyfelhasznalas.getTenyfelhasznalasRecords(Azonosito);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id"]);
                    string palyazatAzonosito = dr["Palyazat_Azonosito"].ToString();
                    string koltsegTipus = dr["Koltseg_tipus"].ToString();
                    float fizetettOsszeg = Convert.ToSingle(dr["Fizetett_osszeg"]);
                    string fizetesDatuma = dr["Fizetes_datum"].ToString();
                    Tenyfelhasznalas t = new Tenyfelhasznalas(id, palyazatAzonosito, koltsegTipus, fizetettOsszeg, fizetesDatuma);
                    tenyfelhasznalas.Add(t);
                }
                connection.Close();
            } 
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tényfelhasználás adatok beolvasása az adatbázisból nem sikerült!");
            }
            return tenyfelhasznalas;
        }

        public void deleteTenyfelhasznalasFromDatabase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryDelete = "DELETE FROM tenyfelhasznalas WHERE id = " + id;
                MySqlCommand cmd = new MySqlCommand(queryDelete, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(id + " -jú tényfelhasználás törlése nem sikerült.");
                throw new RepositoryException("Sikertelen törlés az adatbázisból.");
            }
        }

        public void updateTenyfelhasznalasInDatabase(int id, Tenyfelhasznalas modified)
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
                Debug.WriteLine("Pályázat módosítása nem sikerült.");
                throw new RepositoryException("Sikertelen módosítás az adatbázisból.");
            }
        }

        public void insertPalyazatToDatabase(Palyazat ujPalyazat)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = ujPalyazat.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(ujPalyazat + " palyazat beszúrása adatbázisba nem sikerült.");
                throw new RepositoryException("Sikertelen beszúrás az adatbázisból.");
            }
        }
    }
}
