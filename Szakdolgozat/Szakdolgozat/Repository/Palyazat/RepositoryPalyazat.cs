using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Szakdolgozat.Model;
using System.Diagnostics;

namespace Szakdolgozat.Repository
{
    partial class Tarolo
    {
        List<Palyazat> palyazatok;

        public void deletePalyazatFromList(string azonosito)
        {
            int palyazatCount = palyazatok.Count();
            Palyazat f = palyazatok.Find(x => x.getAzonosito() == azonosito);
            if (f != null)
                palyazatok.Remove(f);
            else
                throw new RepositoryExceptionCantDelete("A pályázatot nem lehetett törölni.");
        }
        public void torolAzonositokodAlapjan(string Azonositokod)
        {
            palyazatok.RemoveAt(palyazatok.FindIndex(p => p.getAzonosito() == Azonositokod));
        }
        public void updatePalyazatInList(string Azonosito, Palyazat modified)
        {
            Palyazat f = palyazatok.Find(x => x.getAzonosito() == Azonosito);
            if (f != null)
                f.update(modified);
            else
                throw new RepositoryExceptionCantModified("A pályázat módosítása nem sikerült");
        }
        public List<Palyazat> getPalyazatok()
        {
            return palyazatok;
        }
        public void setPalyazat(List<Palyazat> palyazatok)
        {
            this.palyazatok = palyazatok;
        }
        public DataTable getPalyazatDataTableFromList()
        {
            DataTable palyazatDT = new DataTable();
            palyazatDT.Columns.Add("Azonosito", typeof(string));
            palyazatDT.Columns.Add("Palyazat_tipus", typeof(string));
            palyazatDT.Columns.Add("Palyazat_neve", typeof(string));
            palyazatDT.Columns.Add("Finanszirozas_tipus", typeof(string));
            palyazatDT.Columns.Add("Tervezett_osszeg", typeof(float));    
            palyazatDT.Columns.Add("Elnyert_osszeg", typeof(float));    
            palyazatDT.Columns.Add("Penznem", typeof(string));
            palyazatDT.Columns.Add("Felhasznalasi_ido_kezd", typeof(string));
            palyazatDT.Columns.Add("Felhasznalasi_ido_vege", typeof(string));
            palyazatDT.Columns.Add("Tudomanyterulet", typeof(string));
            palyazatDT.Columns.Add("Szakmai_vezeto", typeof(string));
            palyazatDT.Columns.Add("Penzugyi_vezeto", typeof(string));
            foreach (Palyazat p in palyazatok)
            {
                palyazatDT.Rows.Add(p.getAzonosito(), p.getPalyazatTipus(), p.getPalyazatNev(), p.getFinanszirozasTipus(), p.getTervezettOsszeg(), p.getElnyertOsszeg(), p.getPenznem(),
                    p.getFelhasznalasiIdoKezd(), p.getFelhasznalasiIdoVege(), p.getTudomanyterulet(), p.getSzakmaiVezeto(), p.getPenzugyiVezeto());
            }
            return palyazatDT;
        }
        public void fillPalyazatListFromDataTable(DataTable palyazatdt)
        {
            foreach (DataRow row in palyazatdt.Rows)
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
                string szakmaiVezeto = row[10].ToString();
                string penzugyiVezeto = row[11].ToString();
                Palyazat p = new Palyazat(Azonosito, palyazatTipus, palyazatNev, finanszirozasTipus, tervezettOsszeg, elnyertOsszeg, penznem, felhasznalasiIdoKezdete,
                    felhasznalasiIdoVege, tudomanyterulet, szakmaiVezeto, penzugyiVezeto);
                palyazatok.Add(p);
            }
        }
    }
}
