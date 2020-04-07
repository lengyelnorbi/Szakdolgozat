using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.Model
{
    partial class Palyazat
    {
        /// <summary>
        /// Új record felvétele a pályázatok táblába.
        /// </summary>
        /// <returns></returns>
        public string getInsert()
        {
            return "INSERT INTO `palyazat`" +
                    "(`Azonosito`, `Palyazat_tipus`, `Palyazat_neve`, `Finanszirozas_tipus`, `Elnyert_osszeg`," +
                    "`Penznem`, `Felhasznalasi_ido_kezd`, `Felhasznalasi_ido_vege`, `Tudomanyterulet`)" +
                    "VALUES ('" +
                    getAzonosito() +
                    "', '" +
                    getPalyazatTipus() +
                    "', '" +
                    getPalyazatNev() +
                    "', '" +
                    getFinanszirozasTipus() +
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
                    "');";
        }

        public string getUpdatePalyazat(string azonosito)
        {
            return
                   "UPDATE palyazat, posztok, vezetok SET Palyazat_tipus = '" +
                   getPalyazatTipus() +
                   "', Palyazat_neve = '" +
                   getPalyazatNev() +
                   "', Finanszirozas_tipus = '" +
                   getFinanszirozasTipus() +
                   "', Elnyert_osszeg = '" +
                   getElnyertOsszeg() +
                   "', Penznem = '" +
                   getPenznem() +
                   "', Felhasznalasi_ido_kezd = '" +
                   getFelhasznalasiIdoKezd() +
                   "', Felhasznalasi_ido_vege = '" +
                   getFelhasznalasiIdoVege() +
                   "', Tudomanyterulet = '" +
                   getTudomanyterulet() +
                   "' WHERE palyazat.Azonosito = '" +
                   azonosito + "';";
        }
        public static string getAllRecord()
        {
            return "SELECT ALL Azonosito, Palyazat_tipus, Palyazat_neve, Finanszirozas_tipus, SUM(koltseg_terv.Tervezett_osszeg) AS Tervezett_osszeg, Elnyert_osszeg, Penznem, Felhasznalasi_ido_kezd, Felhasznalasi_ido_vege, Tudomanyterulet FROM palyazat inner join koltseg_terv on palyazat.Azonosito = koltseg_terv.Palyazat_Azonosito GROUP BY Azonosito";
        }
        public static string getFilteredRecords(string keresesTipus, string keresettSzoveg)
        {
            return "SELECT ALL Azonosito, Palyazat_tipus, Palyazat_neve, Finanszirozas_tipus, SUM(koltseg_terv.Tervezett_osszeg) AS Tervezett_osszeg, Elnyert_osszeg, Penznem, Felhasznalasi_ido_kezd, Felhasznalasi_ido_vege, Tudomanyterulet FROM palyazat inner join koltseg_terv on palyazat.Azonosito = koltseg_terv.Palyazat_Azonosito " + keresesTipus + keresettSzoveg + ";";
        }
        public static string getSzakmaiVezetoNeve(string palyazatAZ)
        {
            return "SELECT (CASE WHEN vezetok.nev IS NOT NULL THEN vezetok.Nev ELSE NULL END) AS Szakmai_vezeto FROM palyazat inner join posztok on palyazat.Azonosito = posztok.Palyazat_Azonosito inner join vezetok on posztok.Vezeto_id = vezetok.id WHERE Azonosito = '" + palyazatAZ + "' AND posztok.poszt = 'Szakmai vezető';";
        }
        public static string getPenzugyiVezetoNeve(string palyazatAZ)
        {
            return "SELECT (CASE WHEN vezetok.nev IS NOT NULL THEN vezetok.Nev ELSE NULL END) AS Penzugyi_vezeto FROM palyazat inner join posztok on palyazat.Azonosito = posztok.Palyazat_Azonosito inner join vezetok on posztok.Vezeto_id = vezetok.id WHERE Azonosito = '" + palyazatAZ + "' AND posztok.poszt = 'Pénzügyi vezető';";
        }
        public static string getPosztokInsert(string palyazatAzonosito, string nev, string poszt)
        {
            return "INSERT INTO posztok (`id`, `Palyazat_Azonosito`, `Vezeto_id`, `poszt`) VALUES (NULL,'" + palyazatAzonosito + "',(SELECT id FROM vezetok WHERE vezetok.nev = '" + nev + "'),'" + poszt + "');";
        }
        //Üres recordot ad meg a pályázat azonosítójával
        public static string getInsertEmptyKoltsegTerv(string palyazatAzonosito)
        {
            return "INSERT INTO `koltseg_terv` (`id`, `Palyazat_Azonosito`, `KoltTip_id`, `Tervezett_osszeg`, `Modositott_Osszeg`)" +
                " VALUES ('NULL', '" + palyazatAzonosito + "', '1', '', '');";
        }
        //Üres leírás sort ad a pályázat azonosítójával
        public static string getInsertEmptyLeiras(string palyazatAzonosito)
        {
            return "INSERT INTO `leirasok` (`id`, `Palyazat_Azonosito`, `Leiras`) VALUES ('NULL', '" + palyazatAzonosito + "','');";
        }
        public static string getDeletePoszt(string palyazatAzonosito, string poszt)
        {
            return "DELETE FROM Posztok WHERE Palyazat_Azonosito = '" + palyazatAzonosito +"' AND poszt = '" + poszt + "';";
        }
        public static string updatePoszt(string palyazatAzonosito, string poszt, string vezetoNev)
        {
            return "UPDATE Posztok SET posztok.vezeto_id = (SELECT vezetok.id FROM vezetok WHERE vezetok.nev = '" + vezetoNev + "') WHERE posztok.Palyazat_Azonosito = '" + palyazatAzonosito + "' AND posztok.poszt = '" + poszt + "';";
        }
    }
}
