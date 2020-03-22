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
                    "(`id`, `Palyazat_Azonosito`, `KoltTip_id`, `Fizetett_osszeg`, `Fizetes_datum`)" +
                    "VALUES ('" +
                    getId() +
                    "', '" +
                    getPalyazatAzonosito() +
                    "', " +
                    "(SELECT koltseg_tipusok.id FROM koltseg_tipusok WHERE koltseg_tipusok.Koltseg_tipus = '" + getKoltsegTipus() +
                    "'), '" +
                    getFizetettOsszeg() +
                    "', '" +
                    getFizetesDatuma() +
                    "');";
        }

        public string getUpdate(int id)
        {
            return
                   "UPDATE `tenyfelhasznalas` SET `Palyazat_Azonosito` = '" +
                   getPalyazatAzonosito() +
                   "', `KoltTip_id` = " +
                   "(SELECT Koltseg_tipusok.id FROM Koltseg_tipusok WHERE koltseg_tipusok.Koltseg_tipus = '" + getKoltsegTipus() + "')" +
                   ", `Fizetett_osszeg` = '" +
                   getFizetettOsszeg() +
                   "', `Fizetes_datum` = '" +
                   getFizetesDatuma() +
                   "' WHERE `tenyfelhasznalas`.`id` = " +
                   id;
        }
        public static string getTenyfelhasznalasRecords(string palyazatAzonosito)
        {
            return "SELECT tenyfelhasznalas.id, tenyfelhasznalas.Palyazat_Azonosito, koltseg_tipusok.Koltseg_tipus, tenyfelhasznalas.Fizetett_osszeg, tenyfelhasznalas.Fizetes_datum "
                + "FROM tenyfelhasznalas INNER JOIN palyazat ON tenyfelhasznalas.Palyazat_Azonosito = palyazat.Azonosito INNER JOIN koltseg_tipusok ON tenyfelhasznalas.KoltTip_id = koltseg_tipusok.id WHERE tenyfelhasznalas.Palyazat_Azonosito = '"
                + palyazatAzonosito + "' ;";
        }

        public static string getLegnagyobbTenyfelhasznalasID()
        {
            return "SELECT tenyfelhasznalas.id FROM tenyfelhasznalas";
        }
    }
}
