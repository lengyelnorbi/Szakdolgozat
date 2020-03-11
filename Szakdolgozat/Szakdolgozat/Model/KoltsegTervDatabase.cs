using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.model
{
    partial class KoltsegTerv
    {
        public string getInsert()
        {
            return "INSERT INTO `koltseg_terv`" +
                    "(`Palyazat_Azonosito`, `KoltTip_id`, `Tervezett_penzosszeg`, `Modositott_penzosszeg`)" +
                    "VALUES ('" +
                    getPalyazatAzonosito() +
                    "', '" +
                    getKoltTipusId() +
                    "', '" +
                    getTervezettPenzOsszeg() +
                    "', '" +
                    getModositottPenzOsszeg() +
                    "');";
        }

        public string getUpdate()
        {
            return
                   "UPDATE `koltseg_terv` SET `KoltTip_id ` = '" +
                   getKoltTipusId() +
                   "', `Tervezett_penzosszeg` = '" +
                   getTervezettPenzOsszeg() +
                   "', `Modositott_penzosszeg` = '" +
                   getModositottPenzOsszeg() +
                   "' WHERE `koltseg_terv`.`Palyazat_Azonosito` = " +
                   getPalyazatAzonosito();
        }

        public static string getAllRecord()
        {
            return "SELECT * FROM koltseg_terv";
        }

        public static string getDeleteAllRecord()
        {
            return "DELETE FROM koltseg_terv";
        }
    }
}
