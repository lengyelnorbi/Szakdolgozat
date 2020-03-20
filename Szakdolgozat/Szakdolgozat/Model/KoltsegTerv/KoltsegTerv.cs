using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.model
{
    partial class KoltsegTerv
    {
        private int id;
        private string palyazatAzonosito;
        private string koltsegTipus;
        private float tervezettOsszeg;
        private float modositottOsszeg;

        //Konstruktor
        public KoltsegTerv(int id, string palyazatAzonosito, string koltsegTipus, float tervezettOsszeg, float modositottOsszeg)
        {
            this.id = id;
            this.palyazatAzonosito = palyazatAzonosito;
            this.koltsegTipus = koltsegTipus;
            this.tervezettOsszeg = tervezettOsszeg;
            this.modositottOsszeg = modositottOsszeg;
        }
        public void update(KoltsegTerv modified)
        {
            this.id = modified.id;
            this.koltsegTipus = modified.koltsegTipus;
            this.tervezettOsszeg = modified.tervezettOsszeg;
            this.modositottOsszeg = modified.modositottOsszeg;
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

        public void setTervezettPenzOsszeg(float tervezettOsszeg)
        {
            this.tervezettOsszeg = tervezettOsszeg;
        }

        public void setModositottOsszeg(float modositottOsszeg)
        {
            this.modositottOsszeg = modositottOsszeg;
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

        public float getTervezettOsszeg()
        {
            return tervezettOsszeg;
        }

        public float getModositottOsszeg()
        {
            return modositottOsszeg;
        }
        //Getterek vége
    }
}
