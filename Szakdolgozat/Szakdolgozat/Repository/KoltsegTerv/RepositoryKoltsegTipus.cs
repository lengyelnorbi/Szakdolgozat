using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Szakdolgozat.model;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Repository
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
            dt.Columns.Add("Pályázat Azonosító", typeof(string));
            dt.Columns.Add("Koltség Típus Azonosító", typeof(int));
            dt.Columns.Add("Tervezett Pénz Összeg", typeof(float));
            dt.Columns.Add("Módosított Pénz Összeg", typeof(float));
            foreach (KoltsegTerv k in koltsegtervek)
            {
                dt.Rows.Add(k.getPalyazatAzonosito(), k.getKoltTipusId(), k.getTervezettPenzOsszeg(), k.getModositottPenzOsszeg());
            }
            return dt;
        }
        public void DataTableToKoltsegTervList(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                string palyazatAzonosito = row[0].ToString();
                int koltsegTervId = Convert.ToInt32(row[1]);
                float tervezettPenzOsszeg = Convert.ToSingle(row[2]);
                float modositottPenzOsszeg = Convert.ToSingle(row[3]);

                KoltsegTerv k = new KoltsegTerv(palyazatAzonosito, koltsegTervId, tervezettPenzOsszeg, modositottPenzOsszeg);
                koltsegtervek.Add(k);
            }
        }
    }
}
