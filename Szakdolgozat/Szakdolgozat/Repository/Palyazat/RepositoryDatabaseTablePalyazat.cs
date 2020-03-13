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

namespace TobbbformosPizzaAlkalmazasTobbTabla.Repository
{
    partial class RepositoryDatabaseTablePalyazat
    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        public RepositoryDatabaseTablePalyazat()
        {
            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();
        }

        public void createTablePalyazat()
        {
            string queryUSE = "USE palyazatszamontarto;";
            string queryCreateTable =
                "CREATE TABLE `palyazatszamontarto`.`palyazat`" +
                "( `Azonosito` VARCHAR(40) , `Palyazat_tipus` VARCHAR(30) NOT NULL, `Palyazat_neve` VARCHAR(50) NOT NULL," +
                "`Finanszirozas_tipus` VARCHAR(25) NOT NULL, `Tervezett_osszeg` FLOAT NOT NULL , `Elnyert_osszeg` FLOAT NOT NULL ," +
                "`Penznem` VARCHAR(20) NOT NULL, `Felhasznalasi_ido_kezd` DATE NOT NULL , `Felhasznalasi_ido_vege` DATE NOT NULL ," +
                "`Tudomanyterulet` VARCHAR(30) NOT NULL, PRIMARY KEY(`Azonosito`)) ENGINE = InnoDB;";

            MySqlConnection connection =
                new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmdUSE = new MySqlCommand(queryUSE, connection);
                cmdUSE.ExecuteNonQuery();
                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tábla lérehozása sikertelen.");
            }
        }
    }
}
