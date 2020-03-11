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
        List<Vezeto> vezetok;

        public List<Vezeto> GetSzakmaiVezetok()
        {
            return vezetok;
        }

        public void setVezeto(List<Vezeto> vezetok)
        {
            this.vezetok = vezetok;
        }
        public DataTable VezetoListToDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Azonosító", typeof(int));
            dt.Columns.Add("Nev", typeof(string));
            dt.Columns.Add("Telefonszám", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            foreach (Vezeto sz in vezetok)
            {
                dt.Rows.Add(sz.getId(), sz.getNev(), sz.getTelefonszam(), sz.getEmail());
            }
            return dt;
        }
        public void DataTableToVezetoList(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string nev = row[1].ToString();
                string telefonszam = row[2].ToString();
                string email = row[3].ToString();

                Vezeto sz = new Vezeto(id, nev, telefonszam, email);
                vezetok.Add(sz);
            }
        }
    }
}
