using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.model
{
    partial class Vezeto
    {
        public string getVezetokListaja()
        {
            return "SELECT vezetok.nev FROM vezetok;";
        }
        public static string getVezetokLegnagyobbID()
        {
            return "SELECT vezetok.id FROM vezetok;";
        }
        public string getInsertIntoVezetok()
        {
            return "INSERT INTO vezetok (`id`, `nev`, `telefonszam`, `email`)" +
                "VALUES(NULL,'" + getNev() + "', '" + getTelefonszam() + "','" + getEmail() + "');";
        }

        public string getUpdate(int id)
        {
            return
                   "UPDATE `vezetok` SET `Nev` = '" +
                   getNev() +
                   "', `telefonszam` = '" +
                   getTelefonszam() +
                   "', `email` = '" +
                   getEmail() +
                   "' WHERE `vezetok`.`id` = " +
                   id;
        }

        public static string getAllRecord()
        {
            return "SELECT * FROM vezetok";
        }
    }
}
