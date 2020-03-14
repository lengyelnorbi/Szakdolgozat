using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.model
{
    partial class Vezeto
    {
        public string getInsert()
        {
            return "INSERT INTO `vezetok`" +
                    "(`id`, `Nev`, `telefonszam`, `email`)" +
                    "VALUES ('" +
                    id +
                    "', '" +
                    getNev() +
                    "', '" +
                    getTelefonszam() +
                    "', '" +
                    getEmail() +
                    "');";
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
