using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.Model
{
    partial class Palyazat
    {
        public string getInsert()
        {
            return "INSERT INTO `palyazat`" +
                    "(`id`, `Palyazat_tipus`, `Palyazat_neve`, `Finanszirozas_tipus`, `Tervezett_osszeg`, `Elnyert_osszeg`, `Penznem`, `Felhasznalasi_ido_kezd`, `Felhasznalasi_ido_vege`, `Tudomanyterulet`, `Tenyfelhasznalas_kod`)" +
                    "VALUES ('" +
                    getAzonosito() +
                    "', '" +
                    getPalyazatTipus() +
                    "', '" +
                    getPalyazatNev() +
                    "', '" +
                    getFinanszirozasTipus() +
                    "', '" +
                    getTervezettOsszeg() +
                    "', '" +
                    getElnyertOsszeg() +
                    "', '" +
                    getPenznem() +
                    "', '" +
                    getFelhasznalasiIdoKezd() +
                    "', '" +
                    getFelhasznalasiIdoVege() +
                    "', '" +
                    getTudomanyterulet() +
                    "', '" +
                    getTenyfelhasznalasKod() +
                    "');";
        }

        public string getUpdate()
        {
            return
                   "UPDATE `palyazat` SET `Palyazat_tipus ` = '" +
                   getPalyazatTipus() +
                   "', `Palyazat_neve ` = '" +
                   getPalyazatNev() +
                   "', `Finanszirozas_tipus` = '" +
                   getFinanszirozasTipus() +
                   "', `Tervezett_osszeg  ` = '" +
                   getTervezettOsszeg() +
                   "', `Elnyert_osszeg  ` = '" +
                   getElnyertOsszeg() + 
                   "', `Penznem` = '" +
                   getPenznem() +
                   "', `Felhasznalasi_ido_kezd` = '" +
                   getFelhasznalasiIdoKezd() +
                   "', `Felhasznalasi_ido_vege` = '" +
                   getFelhasznalasiIdoVege() +
                   "', `Tudomanyterulet` = '" +
                   getTudomanyterulet() +
                   "', `Tenyfelhasznalas_kod` = '" +
                   getTenyfelhasznalasKod() +
                   "' WHERE `palyazat`.`Azonosito` = " +
                   getAzonosito();
        }
        public static string getAllRecord()
        {
            return "SELECT * FROM palyazat";
        }

        public static string getDeleteAllRecord()
        {
            return "DELETE FROM palyazat";
        }
    }
}
