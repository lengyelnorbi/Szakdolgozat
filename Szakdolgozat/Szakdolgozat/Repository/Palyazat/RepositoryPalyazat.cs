using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Szakdolgozat.model;
using Szakdolgozat.Model;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Repository
{
    partial class Repository
    {
        List<Palyazat> palyazatok;

        public List<Palyazat> getPalyazatok()
        {
            return palyazatok;
        }
        public void setPalyazat(List<Palyazat> palyazatok)
        {
            this.palyazatok = palyazatok;
        }
        public DataTable getPalyazatListToDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Azonosito", typeof(string));
            dt.Columns.Add("Tipus", typeof(string));
            dt.Columns.Add("Név", typeof(string));
            dt.Columns.Add("Finanszírozás Típus", typeof(string));
            dt.Columns.Add("Tervezett Összeg", typeof(float));
            dt.Columns.Add("Elnyert Összeg", typeof(float));
            dt.Columns.Add("Pénznem", typeof(string));
            dt.Columns.Add("Felhasználási Idő Kezdete", typeof(string));
            dt.Columns.Add("Felhasználási Idő Vége", typeof(string));
            dt.Columns.Add("Tudományterület", typeof(string));
            foreach (Palyazat p in palyazatok)
            {
                dt.Rows.Add(p.getAzonosito(), p.getPalyazatTipus(), p.getPalyazatNev(), p.getFinanszirozasTipus(), p.getTervezettOsszeg(), p.getElnyertOsszeg(), p.getPenznem(),
                    p.getFelhasznalasiIdoKezd(), p.getFelhasznalasiIdoVege(), p.getTudomanyterulet());
            }
            return dt;
        }
        public void fillDataTableToPalyazatList(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                string Azonosito = row[0].ToString();
                string palyazatTipus = row[1].ToString();
                string palyazatNev = row[2].ToString();
                string finanszirozasTipus = row[3].ToString();
                float tervezettOsszeg = Convert.ToSingle(row[4]);
                float elnyertOsszeg = Convert.ToSingle(row[5]);
                string penznem = row[6].ToString();
                string felhasznalasiIdoKezdete = row[7].ToString();
                string felhasznalasiIdoVege = row[8].ToString();
                string tudomanyterulet = row[9].ToString();
                Palyazat p = new Palyazat(Azonosito, palyazatTipus, palyazatNev, finanszirozasTipus, tervezettOsszeg, elnyertOsszeg, penznem, felhasznalasiIdoKezdete,
                    felhasznalasiIdoVege, tudomanyterulet);
                palyazatok.Add(p);
            }
        }
    }
}
