using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.Model
{
    partial class Palyazat
    {
        private string azonosito;
        private string palyazatTipus;
        private string palyazatNeve;
        private string finanszirozasTipus;
        private float tervezettOsszeg;
        private float elnyertOsszeg;
        private string penznem;
        private string felhasznalasiIdoKezd;
        private string felhasznalasiIdoVege;
        private string tudomanyterulet;

        //Konstruktor
        public Palyazat(string azonosito, string palyazatTipus, string palyazatNeve, string finanszirozasTipus, float tervezettOsszeg, float elnyertOsszeg, string penznem,
            string felhasznalasiIdoKezd, string felhasznalasiIdoVege, string tudomanyterulet)
        {
            this.azonosito = azonosito;
            this.palyazatTipus = palyazatTipus;
            this.palyazatNeve = palyazatNeve;
            this.finanszirozasTipus = finanszirozasTipus;
            this.tervezettOsszeg = tervezettOsszeg;
            this.elnyertOsszeg = elnyertOsszeg;
            this.penznem = penznem;
            this.felhasznalasiIdoKezd = felhasznalasiIdoKezd;
            this.felhasznalasiIdoVege = felhasznalasiIdoVege;
            this.tudomanyterulet = tudomanyterulet;
        }

        // Setterek kezdete
        public void setAzonosito(string azonosito)
        {
            this.azonosito = azonosito;
        }

        public void setPalyazatTipus(string palyazatTipus)
        {
            this.palyazatTipus = palyazatTipus;
        }

        public void setPalyazatNeve(string palyazatNeve)
        {
            this.palyazatNeve = palyazatNeve;
        }

        public void setFinanszirozasTipus(string finanszirozasTipus)
        {
            this.finanszirozasTipus = finanszirozasTipus;
        }

        public void setTervezettOsszeg(float tervezettOsszeg)
        {
            this.tervezettOsszeg = tervezettOsszeg;
        }

        public void setElnyertOsszeg(float elnyertOsszeg)
        {
            this.elnyertOsszeg = elnyertOsszeg;
        }

        public void setPenznem(string penznem)
        {
            this.penznem = penznem;
        }

        public void setfelhasznalasiIdoKezd(string felhasznalasiIdoKezd)
        {
            this.felhasznalasiIdoKezd = felhasznalasiIdoKezd;
        }

        public void setFelhasznalasiIdoVege(string felhasznalasiIdoVege)
        {
            this.felhasznalasiIdoVege = felhasznalasiIdoVege;
        }

        public void setTudomanyterulet(string tudomanyterulet)
        {
            this.tudomanyterulet = tudomanyterulet;
        }
        // Setterek vége

        // Getterek kezdete
        public string getAzonosito()
        {
            return azonosito;
        }

        public string getPalyazatTipus()
        {
            return palyazatTipus;
        }

        public string getPalyazatNev()
        {
            return palyazatNeve;
        }

        public string getFinanszirozasTipus()
        {
            return finanszirozasTipus;
        }

        public float getTervezettOsszeg()
        {
            return tervezettOsszeg;
        }

        public float getElnyertOsszeg()
        {
            return elnyertOsszeg;
        }

        public string getPenznem()
        {
            return penznem;
        }

        public string getFelhasznalasiIdoKezd()
        {
            return felhasznalasiIdoKezd;
        }

        public string getFelhasznalasiIdoVege()
        {
            return felhasznalasiIdoVege;
        }

        public string getTudomanyterulet()
        {
            return tudomanyterulet;
        }
        // Getterek vége
    }
}
