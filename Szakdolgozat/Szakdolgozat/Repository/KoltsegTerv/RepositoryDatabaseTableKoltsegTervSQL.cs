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
    partial class RepositoryDatabaseTableKoltsegTervSQL
    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;
        public RepositoryDatabaseTableKoltsegTervSQL()
        {
            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();
        }

        public List<KoltsegTerv> getKoltsegTervFromDatabaseTable(string Azonosito)
        {
            List<KoltsegTerv> koltsegtervek = new List<KoltsegTerv>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = KoltsegTerv.getKoltsegTervRecords(Azonosito);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id"]);
                    string palyazatAzonosito = dr["Palyazat_Azonosito"].ToString();
                    string koltsegTipus = dr["Koltseg_tipus"].ToString();
                    float tervezettOsszeg = Convert.ToSingle(dr["Tervezett_osszeg"]);
                    float modositottOsszeg = Convert.ToSingle(dr["Modositott_osszeg"]);
                    KoltsegTerv k = new KoltsegTerv(id, palyazatAzonosito, koltsegTipus, tervezettOsszeg, modositottOsszeg);
                    koltsegtervek.Add(k);
                }
                connection.Close();
            } 
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Költségterv adatok beolvasása az adatbázisból nem sikerült!");
            }
            return koltsegtervek;
        }

        public void deleteKoltsegTervFromDatabase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryDelete = "DELETE FROM koltseg_terv WHERE id = " + id;
                MySqlCommand cmd = new MySqlCommand(queryDelete, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(id + " -jú költségterv törlése nem sikerült.");
                throw new RepositoryException("Sikertelen törlés az adatbázisból.");
            }
        }

        public void updateKoltsegTervInDatabase(int id, KoltsegTerv modified)
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
                Debug.WriteLine("Költségterv módosítása nem sikerült.");
                throw new RepositoryException("Sikertelen módosítás az adatbázisból.");
            }
        }

        public int getKoltsegTervID()
        {
            int legnagyobbID;
            List<int> id = new List<int>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = KoltsegTerv.getLegnagyobbKoltsegTervID();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int koltsegTervID = Convert.ToInt32(dr["id"]);
                    id.Add(koltsegTervID);
                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("A legnagyobb költségterv id lekérése nem sikerült az adatbázisból nem sikerült!");
            }
            legnagyobbID = id.Max();
            return legnagyobbID;
        }

        public void insertKoltsegTervIntoDatabase(KoltsegTerv ujKoltsegTerv)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = ujKoltsegTerv.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(ujKoltsegTerv + " költségterv beszúrása adatbázisba nem sikerült.");
                throw new RepositoryException("Sikertelen beszúrás az adatbázisból.");
            }
        }
    }
}
