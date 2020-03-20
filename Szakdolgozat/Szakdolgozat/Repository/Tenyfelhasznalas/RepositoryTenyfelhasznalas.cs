using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Szakdolgozat.model;

namespace Szakdolgozat.Repository
{
    partial class Tarolo
    {
        List<Tenyfelhasznalas> tenyfelhasznalasok;

        public void deleteTenyfelhasznalasFromList(int id)
        {
            Tenyfelhasznalas f = tenyfelhasznalasok.Find(x => x.getId() == id);
            if (f != null)
                tenyfelhasznalasok.Remove(f);
            else
                throw new RepositoryExceptionCantDelete("A tényfelhasználást nem lehetett törölni.");
        }
        public void torolTenyfelhasznalasAzonositokodAlapjan(int id)
        {
            tenyfelhasznalasok.RemoveAt(tenyfelhasznalasok.FindIndex(p => p.getId() == id));
        }
        public void updateTenyfelhasznalasInList(int id, Tenyfelhasznalas modified)
        {
            Tenyfelhasznalas f = tenyfelhasznalasok.Find(x => x.getId() == id);
            if (f != null)
                f.update(modified);
            else
                throw new RepositoryExceptionCantModified("A tényfelhasználás módosítása nem sikerült");
        }
        public void tenyfelhasznalasHozzaadListahoz(Tenyfelhasznalas ujTenyfelhasznalas)
        {
            try
            {
                tenyfelhasznalasok.Add(ujTenyfelhasznalas);
            }
            catch (Exception e)
            {
                throw new RepositoryExceptionCantAdd("A tényfelhasználás hozzáadása nem sikerült");
            }
        }
        public List<Tenyfelhasznalas> GetTenyfelhasznalas()
        {
            return tenyfelhasznalasok;
        }

        public void setTenyfelhasznalas(List<Tenyfelhasznalas> tenyfelhasznalasok)
        {
            this.tenyfelhasznalasok = tenyfelhasznalasok;
        }
        public DataTable getTenyfelhasznalasDataTableFromList()
        {
            DataTable tenyfelhasznalasDT = new DataTable();
            tenyfelhasznalasDT.Columns.Add("Azonosító", typeof(int));
            tenyfelhasznalasDT.Columns.Add("Pályázat Azonosító", typeof(string));
            tenyfelhasznalasDT.Columns.Add("Költség Típus", typeof(string));
            tenyfelhasznalasDT.Columns.Add("Fizetett Összeg", typeof(float));
            tenyfelhasznalasDT.Columns.Add("Fizetés Dátuma", typeof(string));
            foreach (Tenyfelhasznalas t in tenyfelhasznalasok)
            {
                tenyfelhasznalasDT.Rows.Add(t.getId(), t.getPalyazatAzonosito(), t.getKoltsegTipus(), t.getFizetettOsszeg(), t.getFizetesDatuma());
            }
            return tenyfelhasznalasDT;
        }
        public void fillTenyfelhasznalasListFromDataTable(DataTable tenyfelhasznalasdt)
        {
            foreach (DataRow row in tenyfelhasznalasdt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string palyazatAzonosito = row[1].ToString();
                string koltsegTipus = row[2].ToString();
                float fizetettOsszeg = Convert.ToSingle(row[3]);
                string fizetesDatuma = Convert.ToString(row[4]);

                Tenyfelhasznalas t = new Tenyfelhasznalas(id, palyazatAzonosito, koltsegTipus, fizetettOsszeg, fizetesDatuma);
                tenyfelhasznalasok.Add(t);
            }
        }
    }
}
