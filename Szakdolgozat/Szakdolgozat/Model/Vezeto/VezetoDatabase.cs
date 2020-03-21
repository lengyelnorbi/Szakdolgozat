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
        public string getVezetokLegnagyobbID()
        {
            return "SELECT vezetok.id FROM vezetok;";
        }
        public string getInsertIntoVezetok(string palyazatAzonosito, string poszt)
        {
            return "INSERT INTO vezetok (`id`, `nev`, `telefonszam`, `email`)" +
                "VALUES(NULL,'" + getNev() + "', " + getTelefonszam() + ",' " + getEmail() + "');" + 
                "INSERT INTO posztok (`id`, `Palyazat_Azonosito`, `Vezeto_id`, `poszt`)" +
                "VALUES(NULL,'" + palyazatAzonosito + "',(SELECT vezetok.id FROM vezetok WHERE vezetok.nev = '" + getNev() + "), '" + poszt + "');";
        }

        public string getUpdate()
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

        public static string getDeleteAllRecord()
        {
            return "DELETE FROM vezetok";
        }
    }
}
