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
        List<Poszt> posztok;

        public List<Poszt> GetPosztok()
        {
            return posztok;
        }

        public void setPosztok(List<Poszt> posztok)
        {
            this.posztok = posztok;
        }
        public DataTable PosztokListToDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Azonosító", typeof(int));
            dt.Columns.Add("Pályázat Azonosító", typeof(string));
            dt.Columns.Add("Vezető Azonosító", typeof(int));
            dt.Columns.Add("Poszt", typeof(string));
            foreach (Poszt p in posztok)
            {
                dt.Rows.Add(p.getId(), p.getPalyazatAzonosito(), p.getVezetoId(), p.getPoszt());
            }
            return dt;
        }
        public void DataTableToPosztList(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string palyazatAzonosito = row[1].ToString();
                int vezetoId = Convert.ToInt32(row[2]);
                string poszt = row[3].ToString();

                Poszt p = new Poszt(id, palyazatAzonosito, vezetoId, poszt);
                posztok.Add(p);
            }
        }
    }
}
