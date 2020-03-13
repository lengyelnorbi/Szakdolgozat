using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.model
{
    partial class Tenyfelhasznalas
    {
        private int id;
        private string palyazatAzonosito;
        private int koltTipusId;
        private float fizetettOsszeg;
        private string fizetesDatuma;

        //Konstruktor
        public Tenyfelhasznalas(string palyazatAzonosito, int id, int koltTipusId, float fizetettOsszeg, string fizetesDatuma)
        {
            this.palyazatAzonosito = palyazatAzonosito;
            this.id = id;
            this.koltTipusId = koltTipusId;
            this.fizetettOsszeg = fizetettOsszeg;
            this.fizetesDatuma = fizetesDatuma;
        }

        //Setterek kezdete
        public void setId(int id)
        {
            this.id = id;
        }

        public void setPalyazatAzonosito(string palyazatAzonosito)
        {
            this.palyazatAzonosito = palyazatAzonosito;
        }

        public void setKoltTipusId(int koltTipusId)
        {
            this.koltTipusId = koltTipusId;
        }

        public void setFizetettOsszeg(float fizetettOsszeg)
        {
            this.fizetettOsszeg = fizetettOsszeg;
        }

        public void setFizetesDatuma(string fizetesDatuma)
        {
            this.fizetesDatuma = fizetesDatuma;
        }
        //Setterek vége

        //Getterek kezdete
        public int getId()
        {
            return id;
        }

        public string getPalyazatAzonosito()
        {
            return palyazatAzonosito;
        }

        public int getKoltTipusId()
        {
            return koltTipusId;
        }

        public float getFizetettOsszeg()
        {
            return fizetettOsszeg;
        }

        public string getFizetesDatuma()
        {
            return fizetesDatuma;
        }
        //Getterek vége
    }
}
