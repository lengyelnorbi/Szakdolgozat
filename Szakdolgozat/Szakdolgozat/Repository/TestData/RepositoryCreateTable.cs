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
        public void getCreatePalyazatTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryPalyazat = "CREATE TABLE IF NOT EXISTS `palyazatszamontarto`.`palyazat` ( `Azonosito` VARCHAR(40) NOT NULL ," +
                                       "`Palyazat_tipus` VARCHAR(30) NOT NULL ," +
                                       "`Palyazat_neve` VARCHAR(50) NOT NULL ," +
                                       "`Finanszirozas_tipus` VARCHAR(25) NOT NULL," +
                                       "`Elnyert_osszeg` FLOAT NULL," +
                                       "`Penznem` VARCHAR(10) ," +
                                       "`Felhasznalasi_ido_kezd` VARCHAR(11)," +
                                       "`Felhasznalasi_ido_vege` VARCHAR(11)," +
                                       "`Tudomanyterulet` VARCHAR(30) NOT NULL," +
                                       "PRIMARY KEY(`Azonosito`)) ENGINE = InnoDB; ";
                MySqlCommand cmd = new MySqlCommand(queryPalyazat, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Palyazat tábla létrehozása nem sikerült.");
                throw new RepositoryException("Sikertelen táblalétrehozás adatbázisban.");
            }
        }
        public void getCreateKoltsegTervTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryKoltsegTerv = "CREATE TABLE IF NOT EXISTS `palyazatszamontarto`.`koltseg_terv` ( `id` INT AUTO_INCREMENT ," +
                                       "`Palyazat_Azonosito` VARCHAR(40) NOT NULL ," +
                                       "`KoltTip_id` INT NOT NULL ," +
                                       "`Tervezett_osszeg` INT NOT NULL ," +
                                       "`Modositott_Osszeg` FLOAT," +
                                       "PRIMARY KEY (`id`)) ENGINE = InnoDB;";
                MySqlCommand cmd = new MySqlCommand(queryKoltsegTerv, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("KoltsegTerv tábla létrehozása nem sikerült.");
                throw new RepositoryException("Sikertelen táblalétrehozás adatbázisban.");
            }
        }
        public void getCreateTenyfelhasznalasTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryTenyfelhasznalas = "CREATE TABLE IF NOT EXISTS `palyazatszamontarto`.`tenyfelhasznalas` ( `id` INT AUTO_INCREMENT ," +
                                          "`Palyazat_Azonosito` VARCHAR(40) NOT NULL ," +
                                          "`KoltTip_id` INT NOT NULL ," +
                                          "`Fizetett_osszeg` INT NOT NULL ," +
                                          "`Fizetes_datum` VARCHAR(11) NOT NULL ," +
                                          "PRIMARY KEY (`id`)) ENGINE = InnoDB;";
                MySqlCommand cmd = new MySqlCommand(queryTenyfelhasznalas, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Tenyfelhasznalas tábla létrehozása nem sikerült.");
                throw new RepositoryException("Sikertelen táblalétrehozás adatbázisban.");
            }
        }
        public void getCreateKoltsegTipusTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryKoltsegTipus = "CREATE TABLE IF NOT EXISTS `palyazatszamontarto`.`koltseg_tipusok` ( `id` INT NOT NULL AUTO_INCREMENT ," +
                                               "`Koltseg_tipus` VARCHAR(30) UNIQUE NOT NULL ," +
                                               "PRIMARY KEY (`id`)) ENGINE = InnoDB;";
                MySqlCommand cmd = new MySqlCommand(queryKoltsegTipus, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("KoltsegTipus tábla létrehozása nem sikerült.");
                throw new RepositoryException("Sikertelen táblalétrehozás adatbázisban.");
            }
        }
        public void getCreateVezetokTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryVezetok = "CREATE TABLE IF NOT EXISTS `palyazatszamontarto`.`vezetok` ( `id` INT AUTO_INCREMENT ," +
                                           "`Nev` VARCHAR(30) NOT NULL UNIQUE," +
                                           "`Telefonszam` VARCHAR(20)," +
                                           "`Email` VARCHAR(50) UNIQUE," +
                                           "PRIMARY KEY (`id`)) ENGINE = InnoDB;";
                MySqlCommand cmd = new MySqlCommand(queryVezetok, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Vezetok tábla létrehozása nem sikerült.");
                throw new RepositoryException("Sikertelen táblalétrehozás adatbázisban.");
            }
        }
        public void getCreatePosztokTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryPosztok = "CREATE TABLE IF NOT EXISTS `palyazatszamontarto`.`posztok` ( `id` INT AUTO_INCREMENT ," +
                                      "`Palyazat_Azonosito` VARCHAR(40) NOT NULL ," +
                                      "`Vezeto_id` INT NOT NULL," +
                                      "`Poszt` VARCHAR(30) NOT NULL ," +
                                      "PRIMARY KEY(`id`)) ENGINE = InnoDB;";
                MySqlCommand cmd = new MySqlCommand(queryPosztok, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Posztok tábla létrehozása nem sikerült.");
                throw new RepositoryException("Sikertelen táblalétrehozás adatbázisban.");
            }
        }
        public void getCreateFelhasznalokTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryFelhasznalok = "CREATE TABLE IF NOT EXISTS `palyazatszamontarto`.`felhasznalok` (id INT PRIMARY KEY AUTO_INCREMENT," +
                    "felhasznalo_nev VARCHAR(20) NOT NULL UNIQUE," +
                    "jelszo VARCHAR(32) NOT NULL);";
                MySqlCommand cmd = new MySqlCommand(queryFelhasznalok, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Felhasznalok tábla létrehozása nem sikerült.");
                throw new RepositoryException("Sikertelen táblalétrehozás adatbázisban.");
            }
        }
    }
}
