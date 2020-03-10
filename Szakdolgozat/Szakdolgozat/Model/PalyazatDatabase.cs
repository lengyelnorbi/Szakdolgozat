using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.Model
{
    partial class Palyazat
    {
        /*public string getInsert()
        {
            return "INSERT INTO `palyazat`" +
                    "(`id`, `Palyazat_tipus`, `Palyazat_neve`, `Finanszirozas_típus`, `Devizanem`, `Tervezett_osszeg`, `TervOssz_penznem`, `Elnyert_osszeg`, `ElnyOssz_penznem`, `Felhasznalasi_ido_kezd`, `Felhasznalasi_ido_vege`, `Penzugyi_vezeto_kod`, `Szakmai_vezeto_kod`, `Tudomanyterulet`, `Tenyfelhasznalas_kod`)" +
                    "VALUES ('" +
                    id +
                    "', '" +
                    getPalyazatTipus() +
                    "', '" +
                    getPalyazatNev() +
                    "', '" +
                    getFinanszirozasTipus() +
                    "', '" +
                    getDevizanem() +
                    "', '" +
                    getTervezettOsszeg() +
                    "', '" +
                    getTervOsszPenznem() +
                    "', '" +
                    getElnyertOsszeg() +
                    "', '" +
                    getElnyertOsszPenznem() +
                    "', '" +
                    getFelhasznalasiIdoKezd() +
                    "', '" +
                    getFelhasznalasiIdoVege() +
                    "', '" +
                    getPenzugyiVezetoKod() +
                    "', '" +
                    getSzakmaiVezetoKod() +
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
                   "', `Finanszirozas_típus` = '" +
                   getFinanszirozasTipus() +
                   "', `Devizanem` = '" +
                   getDevizanem() +
                   "', `Tervezett_osszeg  ` = '" +
                   getTervezettOsszeg() +
                   "', `TervOssz_penznem  ` = '" +
                   getTervOsszPenznem() +
                   "', `Elnyert_osszeg  ` = '" +
                   getElnyertOsszeg() +
                   "', `ElnyOssz_penznem  ` = '" +
                   getElnyertOsszPenznem() +
                   "', `Felhasznalasi_ido_kezd 	 ` = '" +
                   getFelhasznalasiIdoKezd() +
                   "', `Felhasznalasi_ido_vege ` = '" +
                   getFelhasznalasiIdoVege() +
                   "', `Penzugyi_vezeto_kod ` = '" +
                   getPenzugyiVezetoKod() +
                   "', `Szakmai_vezeto_kod ` = '" +
                   getSzakmaiVezetoKod() +
                   "', `Tudomanyterulet` = '" +
                   getTudomanyterulet() +
                   "', `Tenyfelhasznalas_kod` = '" +
                   getTenyfelhasznalasKod() +
                   "' WHERE `palyazat`.`id` = " +
                   id;
        }
        public static string getAllRecord()
        {
            return "SELECT * FROM palyazat";
        }

        public static string getDeleteAllRecord()
        {
            return "DELETE FROM palyazat";
        }*/
    }
}
