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
        public void deleteKoltsegTervFromList(int azonosito)
        {
            KoltsegTerv k = koltsegtervek.Find(x => x.getId() == azonosito);
            if (k != null)
                koltsegtervek.Remove(k);
            else
                throw new RepositoryExceptionCantDelete("A költségtervet nem lehetett törölni.");
        }
        public void torolAzonositokodAlapjan(int Azonositokod)
        {
            koltsegtervek.RemoveAt(koltsegtervek.FindIndex(p => p.getId() == Azonositokod));
        }
        public void updateKoltsegTervInList(int Azonosito, KoltsegTerv modified)
        {
            KoltsegTerv f = koltsegtervek.Find(x => x.getId() == Azonosito);
            if (f != null)
                f.update(modified);
            else
                throw new RepositoryExceptionCantModified("A költségterv módosítása nem sikerült");
        }

        List<KoltsegTerv> koltsegtervek;

        public List<KoltsegTerv> GetKoltsegTervek()
        {
            return koltsegtervek;
        }

        public void setKoltsegTerv(List<KoltsegTerv> koltsegtervek)
        {
            this.koltsegtervek = koltsegtervek;
        }

        public void koltsegTervHozzaadListahoz(KoltsegTerv ujKoltsegTerv)
        {
            try
            {
                koltsegtervek.Add(ujKoltsegTerv);
            }
            catch (Exception e)
            {
                throw new RepositoryExceptionCantAdd("A tényfelhasználás hozzáadása nem sikerült");
            }
        }

        public DataTable getKoltsegTervDataTableFromList()
        {
            DataTable koltsegtervDT = new DataTable();
            koltsegtervDT.Columns.Add("id", typeof(int));
            koltsegtervDT.Columns.Add("Pályázat Azonosító", typeof(string));
            koltsegtervDT.Columns.Add("Koltség Típus Azonosító", typeof(string));
            koltsegtervDT.Columns.Add("Tervezett Pénz Összeg", typeof(float));
            koltsegtervDT.Columns.Add("Módosított Pénz Összeg", typeof(float));
            foreach (KoltsegTerv k in koltsegtervek)
            {
                koltsegtervDT.Rows.Add(k.getId(), k.getPalyazatAzonosito(), k.getKoltsegTipus(), k.getTervezettOsszeg(), k.getModositottOsszeg());
            }
            return koltsegtervDT;
        }
        public void DataTableToKoltsegTervList(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string palyazatAzonosito = row[1].ToString();
                string koltsegTipus = row[2].ToString();
                float tervezettPenzOsszeg = Convert.ToSingle(row[3]);
                float modositottPenzOsszeg = Convert.ToSingle(row[4]);

                KoltsegTerv k = new KoltsegTerv(id, palyazatAzonosito, koltsegTipus, tervezettPenzOsszeg, modositottPenzOsszeg);
                koltsegtervek.Add(k);
            }
        }
    }
}
