﻿using System;
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
        List<Tenyfelhasznalas> tenyfelhasznalasok;

        public List<Tenyfelhasznalas> GetTenyfelhasznalas()
        {
            return tenyfelhasznalasok;
        }

        public void setTenyfelhasznalas(List<Tenyfelhasznalas> tenyfelhasznalasok)
        {
            this.tenyfelhasznalasok = tenyfelhasznalasok;
        }
        public DataTable TenyfelhasznalasListToDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Azonosító", typeof(int));
            dt.Columns.Add("Költség Típus Azonosító", typeof(int));
            dt.Columns.Add("Fizetett Összeg", typeof(float));
            dt.Columns.Add("Fizetés Dátuma", typeof(string));
            foreach (Tenyfelhasznalas t in tenyfelhasznalasok)
            {
                dt.Rows.Add(t.getId(), t.getKoltTipusId(), t.getFizetettOsszeg(), t.getFizetesDatuma());
            }
            return dt;
        }
        public void DataTableToTenyfelhasznalasList(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                int koltsegTipusId = Convert.ToInt32(row[1]);
                float fizetettOsszeg = Convert.ToSingle(row[2]);
                string fizetesDatuma = Convert.ToString(row[3]);

                Tenyfelhasznalas t = new Tenyfelhasznalas(id, koltsegTipusId, fizetettOsszeg, fizetesDatuma);
                tenyfelhasznalasok.Add(t);
            }
        }
    }
}