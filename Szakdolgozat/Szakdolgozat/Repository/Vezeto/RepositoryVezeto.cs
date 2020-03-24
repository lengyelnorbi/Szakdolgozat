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
        List<Vezeto> vezetok;

        public List<Vezeto> GetSzakmaiVezetok()
        {
            return vezetok;
        }

        public void setVezeto(List<Vezeto> vezetok)
        {
            this.vezetok = vezetok;
        }
        public void deleteVezetoFromList(int id)
        {
            Vezeto v = vezetok.Find(x => x.getId() == id);
            if (v != null)
                vezetok.Remove(v);
            else
                throw new RepositoryExceptionCantDelete("A vezetőt nem lehetett törölni.");
        }
        public void torolVezetokAzonositokodAlapjan(int id)
        {
            vezetok.RemoveAt(vezetok.FindIndex(p => p.getId() == id));
        }
        public void updateVezetokInList(int id, Vezeto modified)
        {
            Vezeto v = vezetok.Find(x => x.getId() == id);
            if (v != null)
                v.update(modified);
            else
                throw new RepositoryExceptionCantModified("A vezető módosítása nem sikerült");
        }
        public bool isVezetoInList(string vezetoNeve)
        {
            Vezeto v = vezetok.Find(x => x.getNev() == vezetoNeve);
            if (v != null)
                return true;
            return false;
        }
        public void vezetokHozzaadListahoz(Vezeto ujVezeto)
        {
            try
            {
                vezetok.Add(ujVezeto);
            }
            catch (Exception e)
            {
                throw new RepositoryExceptionCantAdd("A vezető hozzáadása nem sikerült");
            }
        }
        public DataTable getVezetokDataTableFromList()
        {
            DataTable vezetoDT = new DataTable();
            vezetoDT.Columns.Add("Azonosító", typeof(int));
            vezetoDT.Columns.Add("Név", typeof(string));
            vezetoDT.Columns.Add("Telefonszám", typeof(string));
            vezetoDT.Columns.Add("Email", typeof(string));
            foreach (Vezeto sz in vezetok)
            {
                vezetoDT.Rows.Add(sz.getId(), sz.getNev(), sz.getTelefonszam(), sz.getEmail());
            }
            return vezetoDT;
        }
        public void DataTableToVezetoList(DataTable vezetodt)
        {
            foreach (DataRow row in vezetodt.Rows)
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
