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
                    "(`id`, `Palyazat_tipus`, `Palyazat_neve`, `Finanszirozas_tipus`, `Elnyert_osszeg`, `Penznem`, `Felhasznalasi_ido_kezd`, `Felhasznalasi_ido_vege`, `Tudomanyterulet`)" +
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

        public string getUpdate(string Azonosito)
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
                   "', vezetok.Nev = '" +
                   getSzakmaiVezeto() +
                   "' WHERE palyazat.Azonosito = '" +
                   azonosito + 
                   "' AND vezetok.id = (SELECT posztok.Vezeto_id FROM posztok WHERE posztok.poszt = 'Szakmai Vezető');" +
                   " UPDATE palyazat, vezetok SET vezetok.Nev = '" +
                   getPenzugyiVezeto() +
                   "' WHERE palyazat.Azonosito = '" +
                   azonosito + "' AND vezetok.id = (SELECT posztok.Vezeto_id FROM posztok WHERE posztok.poszt = 'Pénzügyi Vezető');";
        }
        public static string getAllRecord()
        {
            return "SELECT Azonosito, Palyazat_tipus, Palyazat_neve, Finanszirozas_tipus,SUM(koltseg_terv.Tervezett_osszeg) AS Tervezett_osszeg, Elnyert_osszeg, Penznem, Felhasznalasi_ido_kezd, Felhasznalasi_ido_vege, Tudomanyterulet,(SELECT vezetok.Nev "
                + "FROM posztok INNER JOIN vezetok ON posztok.Vezeto_id = vezetok.id WHERE posztok.Poszt = 'Szakmai vezető') AS Szakmai_vezeto, "
                + "(SELECT vezetok.Nev FROM posztok INNER JOIN vezetok ON posztok.Vezeto_id = vezetok.id WHERE posztok.Poszt = 'Pénzügyi vezető') AS Penzugyi_vezeto "
                + "FROM palyazat INNER JOIN koltseg_terv ON palyazat.Azonosito = koltseg_terv.Palyazat_Azonosito GROUP BY palyazat.Azonosito";
        }
    }
}
