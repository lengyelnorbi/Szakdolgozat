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
        public void getInsertPalyazatIntoDatabase()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryInsert = "INSERT INTO `palyazat` (`Azonosito`, `Palyazat_tipus`, `Palyazat_neve`, `Finanszirozas_tipus`, `Elnyert_osszeg`, `Penznem`," +
                                                             "`Felhasznalasi_ido_kezd`, `Felhasznalasi_ido_vege`, `Tudomanyterulet`)" +
                                     "VALUES('NKFIH1', 'NKFIH', 'Lengyel Kft', 'Előfinanszírozott', '10000000', 'Forint', '2020.03.12', '2020.03.31', 'Informatika')," +
                                           "('Minisztériumi1', 'Minisztériumi', 'Lengyel Kft', 'Utófinanszírozott', '2500000', 'Forint', '2020.03.13', '2020.04.06', 'Műszaki')," +
                                           "('GINOP1', 'GINOP', 'Lengyel Kft', 'Utófinanszírozott', '500000', 'Euró', '2020.03.23', '2020.03.31', 'Műszaki')," +
                                           "('EFOP1', 'EFOP', 'Lengyel Kft', 'Előfinanszírozott', '1000000', 'Dollár', '2020.06.01', '2020.06.06', 'Társadalom tudomány')," +
                                           "('NTKA1', 'NTKA', 'Lengyel Kft', 'Előfinanszírozott', '3450000', 'Forint', '2020.06.06', '2020.06.16', 'Természet tudomány')," +
                                           "('NKA1', 'NKA', 'Lengyel Kft', 'Utófinanszírozott', '100000', 'Euró', '2020.07.01', '2020.09.01', 'Társadalom tudomány');";
                MySqlCommand cmd = new MySqlCommand(queryInsert, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Pályázat adatainak insertálása nem sikerült.");
                throw new RepositoryException("Sikertelen adatbeszúrás az adatbázisban.");
            }
        }
        public void getInsertKoltsegTipusokIntoDatabase()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryInsert = "INSERT INTO `koltseg_tipusok` (`id`, `Koltseg_tipus`)" +
                                     "VALUES (NULL, 'Költség_típus')," +
                                            "(NULL, 'Bérköltség')," +
                                            "(NULL, 'Járulék')," +
                                            "(NULL, 'Szakmai anyag')," +
                                            "(NULL, 'Szolgáltatás')," +
                                            "(NULL, 'Rezsi')," +
                                            "(NULL, 'Tárgyi eszköz')," +
                                            "(NULL, 'Beruházás/Felújítás');";
                MySqlCommand cmd = new MySqlCommand(queryInsert, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Költség típusok adatainak insertálása nem sikerült.");
                throw new RepositoryException("Sikertelen adatbeszúrás az adatbázisban.");
            }
        }
        public void getInsertTenyfelhasznalasIntoDatabase()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryInsert = "INSERT INTO `tenyfelhasznalas` (`id`, `Palyazat_Azonosito`, `KoltTip_id`, `Fizetett_osszeg`, `Fizetes_datum`)" +
                                     "VALUES ('null', 'NKFIH1', '2', '1500000', '2020.03.23')," +
                                            "('null', 'NKFIH1', '3', '3000000', '2020.03.23')," +
                                            "('null', 'Minisztériumi1', '3', '1000000', '2020.03.23')," +
                                            "('null', 'Minisztériumi1', '5', '400000', '2020.03.23')," +
                                            "('null', 'GINOP1', '4', '150000', '2020.03.23')," +
                                            "('null', 'GINOP1', '2', '50000', '2020.03.23')," +
                                            "('null', 'EFOP1', '6', '200000', '2020.03.23')," +
                                            "('null', 'EFOP1', '7', '175000', '2020.03.23')," +
                                            "('null', 'NTKA1', '8', '450000', '2020.03.23')," +
                                            "('null', 'NTKA1', '8', '550000', '2020.03.23')," +
                                            "('null', 'NKA1', '3', '1000', '2020.03.23')," +
                                            "('null', 'NKA1', '4', '3200', '2020.03.23');";
                MySqlCommand cmd = new MySqlCommand(queryInsert, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Tényfelhasználás adatainak insertálása nem sikerült.");
                throw new RepositoryException("Sikertelen adatbeszúrás az adatbázisban.");
            }
        }
        public void getInsertKoltsegTervIntoDatabase()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryInsert = "INSERT INTO `koltseg_terv` (`id`, `Palyazat_Azonosito`, `KoltTip_id`, `Tervezett_osszeg`, `Modositott_Osszeg`)" +
                                     "VALUES ('NULL', 'NKFIH1', '3', '102121', '')," +
                                            "('NULL', 'NKFIH1', '3', '102121', '')," +
                                            "('NULL', 'NKFIH1', '2', '102121', '')," +
                                            "('NULL', 'Minisztériumi1', '4', '102121', '')," +
                                            "('NULL', 'Minisztériumi1', '2', '102121', '')," +
                                            "('NULL', 'Minisztériumi1', '7', '102121', '')," +
                                            "('NULL', 'GINOP1', '7', '102121', '')," +
                                            "('NULL', 'GINOP1', '6', '102121', '')," +
                                            "('NULL', 'GINOP1', '2', '102121', '')," +
                                            "('NULL', 'EFOP1', '8', '102121', '')," +
                                            "('NULL', 'EFOP1', '8', '102121', '')," +
                                            "('NULL', 'EFOP1', '4', '102121', '')," +
                                            "('NULL', 'NTKA1', '4', '102121', '')," +
                                            "('NULL', 'NTKA1', '2', '102121', '')," +
                                            "('NULL', 'NTKA1', '8', '102121', '')," +
                                            "('NULL', 'NKA1', '3', '102121', '')," +
                                            "('NULL', 'NKA1', '5', '102121', '')," +
                                            "('NULL', 'NKA1', '5', '102121', '');";
                MySqlCommand cmd = new MySqlCommand(queryInsert, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Költségterv adatainak insertálása nem sikerült.");
                throw new RepositoryException("Sikertelen adatbeszúrás az adatbázisban.");
            }
        }
        public void getInsertVezetokIntoDatabase()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryInsert = "INSERT INTO `vezetok` (`id`, `Nev`, `Telefonszam`, `Email`)" +
                                     "VALUES (NULL, 'Lengyel Norbert', '06501234567', 'lengyelnorbi5@gmail.com')," +
                                            "(NULL, 'Lengyel Péter', '06306515234', 'lenpet@gmail.com')," +
                                            "(NULL, 'Pördi Jóska', '06700156568', 'unknown@gmail.com')," +
                                            "(NULL, 'Teleki Pál', '06209856471', 'qwerty@gmail.com')," +
                                            "(NULL, 'Husz János', '06301985648', 'abc123@gmail.com')," +
                                            "(NULL, 'Herceg Gyöngyi', '06305684313', 'username@gmail.com')," +
                                            "(NULL, 'Lengyelné Katona Tímea', '06705681468', 'lengyelne@gmail.com')," +
                                            "(NULL, 'Farkas Bertalan', '06507413548', 'urhajos@gmail.com')," +
                                            "(NULL, 'Neumann János', '06200112498', 'feltalalo@gmail.com');";

                MySqlCommand cmd = new MySqlCommand(queryInsert, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Vezetők adatainak insertálása nem sikerült.");
                throw new RepositoryException("Sikertelen adatbeszúrás az adatbázisban.");
            }
        }
        public void getInsertPosztokIntoDatabase()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryInsert = "INSERT INTO `posztok` (`id`, `Palyazat_Azonosito`, `Vezeto_id`, `Poszt`)" +
                                     "VALUES (NULL, 'NKFIH1', '1', 'Szakmai Vezető')," +
                                            "(NULL, 'NKFIH1', '4', 'Pénzügyi Vezető')," +
                                            "(NULL, 'Minisztériumi1', '2', 'Pénzügyi Vezető')," +
                                            "(NULL, 'Minisztériumi1', '5', 'Szakmai Vezető')," +
                                            "(NULL, 'GINOP1', '7', 'Pénzügyi Vezető')," +
                                            "(NULL, 'GINOP1', '7', 'Szakmai Vezető')," +
                                            "(NULL, 'EFOP1', '3', 'Pénzügyi Vezető')," +
                                            "(NULL, 'EFOP1', '8', 'Szakmai Vezető')," +
                                            "(NULL, 'NTKA1', '9', 'Pénzügyi Vezető')," +
                                            "(NULL, 'NTKA1', '4', 'Szakmai Vezető')," +
                                            "(NULL, 'NKA1', '1', 'Pénzügyi Vezető')," +
                                            "(NULL, 'NKA1', '6', 'Szakmai Vezető');";
                MySqlCommand cmd = new MySqlCommand(queryInsert, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Posztok adatainak insertálása nem sikerült.");
                throw new RepositoryException("Sikertelen adatbeszúrás az adatbázisban.");
            }
        }
    }
}
