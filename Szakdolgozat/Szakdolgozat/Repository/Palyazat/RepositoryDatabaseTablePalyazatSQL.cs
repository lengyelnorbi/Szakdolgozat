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
        private readonly string connectionString2;
        private readonly string connectionString3;
        public RepositoryDatabaseTablePalyazatSQL()
        {
            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();
            connectionString2 = cs.getConnectionString();
            connectionString3 = cs.getConnectionString();
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
                string szakmaiVezetoNeve = "";
                string penzugyiVezetoNeve = "";
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
                    MySqlConnection connection2 = new MySqlConnection(connectionString2);
                    try
                    {
                        connection2.Open();
                        string query2 = Palyazat.getSzakmaiVezetoNeve(azonosito);
                        MySqlCommand cmd2 = new MySqlCommand(query2, connection2);
                        MySqlDataReader dr2;
                        dr2 = cmd2.ExecuteReader();
                        while (dr2.Read())
                        {
                            szakmaiVezetoNeve = dr2["Szakmai_vezeto"].ToString();
                        }
                        connection2.Close();
                    }
                    catch (Exception e)
                    {
                        connection2.Close();
                    }
                    string szakmaiVezeto = szakmaiVezetoNeve;
                    MySqlConnection connection3 = new MySqlConnection(connectionString3);
                    try
                    {
                        connection3.Open();
                        string query3 = Palyazat.getPenzugyiVezetoNeve(azonosito);
                        MySqlCommand cmd3 = new MySqlCommand(query3, connection3);
                        MySqlDataReader dr3;
                        dr3 = cmd3.ExecuteReader();

                        while (dr3.Read())
                        {
                            penzugyiVezetoNeve = dr3["Penzugyi_vezeto"].ToString();
                        }
                        connection3.Close();
                    }
                    catch(Exception e)
                    {
                        connection3.Close();
                    }
                    string penzugyiVezeto = penzugyiVezetoNeve;
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

        public void updatePalyazatInDatabase(/*string Azonosito,*/ Palyazat modified)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = modified.getUpdate(/*Azonosito*/);
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

        public void insertPalyazatIntoDatabase(Palyazat ujPalyazat)
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
        public void insertPosztokIntoDatabase(string palyazatAzonosito, string nev, string poszt)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Palyazat.getPosztokInsert(palyazatAzonosito, nev, poszt);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(poszt + " beszúrása adatbázisba nem sikerült.");
                throw new RepositoryException("Sikertelen beszúrás az adatbázisból.");
            }
        }
        public void insertEmptyKoltsegTervIntoDatabase(string palyazatAzonosito)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Palyazat.getInsertEmptyKoltsegTerv(palyazatAzonosito);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Üres költségterv beszúrása adatbázisba nem sikerült.");
                throw new RepositoryException("Sikertelen beszúrás az adatbázisból.");
            }
        }
    }
}
