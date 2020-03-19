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
        private string koltsegTipus;
        private float fizetettOsszeg;
        private string fizetesDatuma;

        //Konstruktor
        public Tenyfelhasznalas(int id, string palyazatAzonosito, string koltsegTipus, float fizetettOsszeg, string fizetesDatuma)
        {
            this.palyazatAzonosito = palyazatAzonosito;
            this.id = id;
            this.koltsegTipus = koltsegTipus;
            this.fizetettOsszeg = fizetettOsszeg;
            this.fizetesDatuma = fizetesDatuma;
        }

        public void update(Tenyfelhasznalas modified)
        {
            this.id = modified.id;
            this.koltsegTipus = modified.koltsegTipus;
            this.fizetettOsszeg = modified.fizetettOsszeg;
            this.fizetesDatuma = modified.fizetesDatuma;
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

        public void setKoltsegTipus(string koltsegTipus)
        {
            this.koltsegTipus = koltsegTipus;
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

        public string getKoltsegTipus()
        {
            return koltsegTipus;
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
