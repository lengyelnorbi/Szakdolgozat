using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.model
{
    partial class Tenyfelhasznalas
    {
        public string getInsert()
        {
            return "INSERT INTO `tenyfelhasznalas`" +
                    "(`id`, `KoltTip_id`, `Fizetett_osszeg`, `Fizetes_datum`)" +
                    "VALUES ('" +
                    id +
                    "', '" +
                    getKoltTipusId() +
                    "', '" +
                    getFizetettOsszeg() +
                    "', '" +
                    getFizetesDatuma() +
                    "');";
        }

        public string getUpdate()
        {
            return
                   "UPDATE `tenyfelhasznalas` SET `KoltTip_id ` = '" +
                   getKoltTipusId() +
                   "', `Fizetett_osszeg` = '" +
                   getFizetettOsszeg() +
                   "', `Fizetes_datum` = '" +
                   getFizetesDatuma() +
                   "' WHERE `tenyfelhasznalas`.`id` = " +
                   id;
        }

        public static string getAllRecord()
        {
            return "SELECT * FROM tenyfelhasznalas";
        }

        public static string getDeleteAllRecord()
        {
            return "DELETE FROM tenyfelhasznalas";
        }
    }
}
