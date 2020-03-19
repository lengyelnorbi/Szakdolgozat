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
        public void torolTenyfelhasznalasAzonositokodAlapjan(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM `tenyfelhasznalas` WHERE id=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(id + " record törlése nem sikerült!");
                throw new TaroloException("Adatbázis törlése nem sikerült");
            }
        }

        //public void hozzaadPalyazatot(Palyazat p)
        //{
        //    MySqlConnection connection = new MySqlConnection(connectionString);
        //    try
        //    {
        //        connection.Open();
        //        string query = p.getInsert();
        //        MySqlCommand cmd = new MySqlCommand(query, connection);
        //        cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        connection.Close();
        //        Debug.WriteLine(p + " pályázat mentése adatbázisba nem sikerült");
        //        throw new TaroloException("Adatbázis record mentési hiba");
        //    }
        //}

        //public void modositPalyazatot(int Azonositokod, Palyazat p)
        //{
        //    MySqlConnection connection = new MySqlConnection(connectionString);
        //    try
        //    {
        //        connection.Open();
        //        string query = p.getUpdate(Azonositokod);
        //        MySqlCommand cmd = new MySqlCommand(query, connection);
        //        cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        connection.Close();
        //        Debug.WriteLine(Azonositokod + " pályázat módosítása " + p + " pályázatra nem sikerült");
        //        throw new TaroloException("Adatbázis record módosítási hiba hiba");
        //    }
        //}
    }
}
