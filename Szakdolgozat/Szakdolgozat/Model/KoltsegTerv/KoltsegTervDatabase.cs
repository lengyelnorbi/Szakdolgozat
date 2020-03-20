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
                    "(`id`, `Palyazat_Azonosito`, `KoltTip_id`, `Tervezett_penzosszeg`, `Modositott_penzosszeg`)" +
                    "VALUES ('" +
                    id +
                    "', '" +
                    getPalyazatAzonosito() +
                    "', '" +
                    getKoltsegTipus() +
                    "', '" +
                    getTervezettOsszeg() +
                    "', '" +
                    getModositottOsszeg() +
                    "');";
        }

        public string getUpdate(int id)
        {
            return
                   "UPDATE `koltseg_terv` SET `Palyazat_Azonosito` = '" +
                   getPalyazatAzonosito() +
                   "', `KoltTip_id` = " +
                   "(SELECT Koltseg_tipusok.id FROM Koltseg_tipusok WHERE koltseg_tipusok.Koltseg_tipus = '" + getKoltsegTipus() + "')" +
                   ", `Tervezett_osszeg` = '" +
                   getTervezettOsszeg() +
                   "', `Modositott_osszeg` = '" +
                   getModositottOsszeg() +
                   "' WHERE `koltseg_terv`.`id` = " +
                   id;
        }

        public static string getKoltsegTervRecords(string palyazatAzonosito)
        {
            return "SELECT koltseg_terv.id, koltseg_terv.Palyazat_Azonosito, koltseg_tipusok.Koltseg_tipus, koltseg_terv.Tervezett_osszeg, koltseg_terv.Modositott_osszeg "
                + "FROM koltseg_terv INNER JOIN palyazat ON koltseg_terv.Palyazat_Azonosito = palyazat.Azonosito INNER JOIN koltseg_tipusok ON koltseg_terv.KoltTip_id = koltseg_tipusok.id WHERE koltseg_terv.Palyazat_Azonosito = '"
                + palyazatAzonosito + "' ;";
        }
    }
}
