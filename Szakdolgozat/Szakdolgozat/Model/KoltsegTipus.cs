using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.model
{
    partial class KoltsegTipus
    {
        private int id;
        private string koltsegTipus;

        //Konstruktor
        public KoltsegTipus(int id, string koltsegTipus)
        {
            this.id = id;
            this.koltsegTipus = koltsegTipus;
        }

        //Setterek kezdete
        public void setId(int id)
        {
            this.id = id;
        }

        public void setKoltsegTipus(string koltsegTipus)
        {
            this.koltsegTipus = koltsegTipus;
        }
        //Setterek vége

        //Getterek kezdete
        public int getId()
        {
            return id;
        }

        public string getKoltsegTipus()
        {
            return koltsegTipus;
        }
        //Getterek vége
    }
}
