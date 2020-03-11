using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.model
{
    partial class KoltsegTerv
    {
        private string palyazatAzonosito;
        private int koltTipusId;
        private float tervezettPenzOsszeg;
        private float modositottPenzOsszeg;

        //Konstruktor
        public KoltsegTerv(string palyazatAzonosito, int koltTipusId, float tervezettPenzOsszeg, float modositottPenzOsszeg)
        {
            this.palyazatAzonosito = palyazatAzonosito;
            this.koltTipusId = koltTipusId;
            this.tervezettPenzOsszeg = tervezettPenzOsszeg;
            this.modositottPenzOsszeg = modositottPenzOsszeg;
        }

        //Setterek kezdete
        public void setPalyazatAzonosito(string palyazatAzonosito)
        {
            this.palyazatAzonosito = palyazatAzonosito;
        }

        public void setKoltTipusId(int koltTipusId)
        {
            this.koltTipusId = koltTipusId;
        }

        public void setTervezettPenzOsszeg(float tervezettPenzOsszeg)
        {
            this.tervezettPenzOsszeg = tervezettPenzOsszeg;
        }

        public void setModositottPenzOsszeg(float modositottPenzOsszeg)
        {
            this.modositottPenzOsszeg = modositottPenzOsszeg;
        }
        //Setterek vége

        //Getterek kezdete
        public string getPalyazatAzonosito()
        {
            return palyazatAzonosito;
        }

        public int getKoltTipusId()
        {
            return koltTipusId;
        }

        public float getTervezettPenzOsszeg()
        {
            return tervezettPenzOsszeg;
        }

        public float getModositottPenzOsszeg()
        {
            return modositottPenzOsszeg;
        }
        //Getterek vége
    }
}
