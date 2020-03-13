using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Szakdolgozat.model;

namespace Szakdolgozat.Repository
{
    partial class Repository
    {
        List<KoltsegTerv> koltsegtervek;

        public List<KoltsegTerv> GetKoltsegTervek()
        {
            return koltsegtervek;
        }

        public void setKoltsegTerv(List<KoltsegTerv> koltsegtervek)
        {
            this.koltsegtervek = koltsegtervek;
        }
        public DataTable KoltsegTervekListToDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Pályázat Azonosító", typeof(string));
            dt.Columns.Add("Koltség Típus Azonosító", typeof(int));
            dt.Columns.Add("Tervezett Pénz Összeg", typeof(float));
            dt.Columns.Add("Módosított Pénz Összeg", typeof(float));
            foreach (KoltsegTerv k in koltsegtervek)
            {
                dt.Rows.Add(k.getId(), k.getPalyazatAzonosito(), k.getKoltTipusId(), k.getTervezettPenzOsszeg(), k.getModositottPenzOsszeg());
            }
            return dt;
        }
        public void DataTableToKoltsegTervList(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string palyazatAzonosito = row[1].ToString();
                int koltsegTervId = Convert.ToInt32(row[2]);
                float tervezettPenzOsszeg = Convert.ToSingle(row[3]);
                float modositottPenzOsszeg = Convert.ToSingle(row[4]);

                KoltsegTerv k = new KoltsegTerv(id, palyazatAzonosito, koltsegTervId, tervezettPenzOsszeg, modositottPenzOsszeg);
                koltsegtervek.Add(k);
            }
        }
    }
}
