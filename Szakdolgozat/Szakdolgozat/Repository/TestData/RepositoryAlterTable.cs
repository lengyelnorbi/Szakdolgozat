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
        public void getAlterTableAddForeignKeysToTenyfelhasznalas()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryForeignKeys = "ALTER TABLE tenyfelhasznalas ADD FOREIGN KEY IF NOT EXISTS (Palyazat_Azonosito) REFERENCES palyazat(Azonosito) ON DELETE CASCADE;" +
                                          "ALTER TABLE tenyfelhasznalas ADD FOREIGN KEY IF NOT EXISTS (KoltTip_id) REFERENCES koltseg_tipusok(id);";
                MySqlCommand cmd = new MySqlCommand(queryForeignKeys, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Tenyfelhasznalas idegenkulcsainak létrehozása nem sikerült.");
                throw new RepositoryException("Sikertelen idegenkulcs hozzáadása az adatbázisban.");
            }
        }
        public void getAlterTableAddForeignKeysToPosztok()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryForeignKeys = "ALTER TABLE posztok ADD FOREIGN KEY IF NOT EXISTS (Palyazat_Azonosito) REFERENCES palyazat(Azonosito) ON UPDATE CASCADE ON DELETE CASCADE;" +
                                          "ALTER TABLE posztok ADD FOREIGN KEY IF NOT EXISTS (Vezeto_id) REFERENCES vezetok(id) ON UPDATE CASCADE ON DELETE CASCADE;";

                MySqlCommand cmd = new MySqlCommand(queryForeignKeys, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Posztok idegenkulcsainak létrehozása nem sikerült.");
                throw new RepositoryException("Sikertelen idegenkulcs hozzáadása az adatbázisban.");
            }
        }
        public void getAlterTableAddForeignKeysToKoltsegTerv()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryForeignKeys = "ALTER TABLE koltseg_terv ADD FOREIGN KEY IF NOT EXISTS (KoltTip_id) REFERENCES koltseg_tipusok(id);" +
                                          "ALTER TABLE koltseg_terv ADD FOREIGN KEY IF NOT EXISTS (Palyazat_Azonosito) REFERENCES palyazat(Azonosito) ON DELETE CASCADE;";
                MySqlCommand cmd = new MySqlCommand(queryForeignKeys, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("Költségterv idegenkulcsainak létrehozása nem sikerült.");
                throw new RepositoryException("Sikertelen idegenkulcs hozzáadása az adatbázisban.");
            }
        }
    }
}
