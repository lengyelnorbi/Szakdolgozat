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
    partial class RepositoryDatabaseTablePalyazatSQL
    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;
        public RepositoryDatabaseTablePalyazatSQL()
        {
            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();
        }

        public List<Palyazat> getPalyazatokFromDatabaseTable()
        {
            List<Palyazat> palyazatok = new List<Palyazat>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Palyazat.getAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string azonosito = dr["Azonosito"].ToString();
                    string palyazatTipus = dr["Palyazat_tipus"].ToString();
                    string palyazatNev = dr["Palyazat_neve"].ToString();
                    string finanszirozasTipus = dr["Finanszirozas_tipus"].ToString();
                    float tervezettOsszeg = Convert.ToSingle(dr["Tervezett_osszeg"]);
                    float elnyertOsszeg = Convert.ToSingle(dr["Elnyert_osszeg"]);
                    string penznem = dr["Penznem"].ToString();
                    string felhasznIdoKezd = dr["Felhasznalasi_ido_kezd"].ToString();
                    string felhasznIdoVege = dr["Felhasznalasi_ido_vege"].ToString();
                    string tudomanyterulet = dr["Tudomanyterulet"].ToString();
                    string szakmaiVezeto = dr["Szakmai_vezeto"].ToString();
                    string penzugyiVezeto = dr["Penzugyi_vezeto"].ToString();
                    Palyazat p = new Palyazat(azonosito, palyazatTipus, palyazatNev, finanszirozasTipus, tervezettOsszeg, elnyertOsszeg, penznem, felhasznIdoKezd, felhasznIdoVege, tudomanyterulet, szakmaiVezeto, penzugyiVezeto);
                    palyazatok.Add(p);
                }
                connection.Close();
            } 
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Pályázat adatok beolvasása az adatbázisból nem sikerült!");
            }
            return palyazatok;
        }

        public void deletePalyazatFromDatabase(string Azonosito)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryDelete = "DELETE FROM palyazat WHERE Azonosito = " + "'" + Azonosito + "'";
                MySqlCommand cmd = new MySqlCommand(queryDelete, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(Azonosito + " -jú palyazat törlése nem sikerült.");
                throw new RepositoryException("Sikertelen törlés az adatbázisból.");
            }
        }

        public void updatePalyazatInDatabase(string Azonosito, Palyazat modified)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = modified.getUpdate(Azonosito);
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
