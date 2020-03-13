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
        List<KoltsegTipus> koltsegtipusok;

        public List<KoltsegTipus> GetKoltsegTipusok()
        {
            return koltsegtipusok;
        }

        public void setKoltsegTipus(List<KoltsegTipus> koltsegtipusok)
        {
            this.koltsegtipusok = koltsegtipusok;
        }
        public DataTable KoltsegTipusokListToDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Azonosító", typeof(int));
            dt.Columns.Add("Pályázat Típus", typeof(string));
            foreach (KoltsegTipus k in koltsegtipusok)
            {
                dt.Rows.Add(k.getId(), k.getKoltsegTipus());
            }
            return dt;
        }
        public void DataTableToKoltsegTipusokList(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string palyazattipus = row[1].ToString();

                KoltsegTipus k = new KoltsegTipus(id, palyazattipus);
                koltsegtipusok.Add(k);
            }
        }
    }
}
