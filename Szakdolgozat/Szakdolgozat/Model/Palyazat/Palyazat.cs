﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat.Repository;

namespace Szakdolgozat.Model
{
    partial class Palyazat
    {
        private string azonosito;
        private string palyazatTipus;
        private string palyazatNeve;
        private string finanszirozasTipus;
        private double tervezettOsszeg;
        private double elnyertOsszeg;
        private string penznem;
        private string felhasznalasiIdoKezd;
        private string felhasznalasiIdoVege;
        private string tudomanyterulet;
        private string szakmaiVezeto;
        private string penzugyiVezeto;

        Tarolo tarolo = new Tarolo();
        //Konstruktor
        public Palyazat(string azonosito, string palyazatTipus, string palyazatNeve, string finanszirozasTipus, float tervezettOsszeg, float elnyertOsszeg, string penznem,
            string felhasznalasiIdoKezd, string felhasznalasiIdoVege, string tudomanyterulet, string szakmaiVezeto, string penzugyiVezeto)
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
            this.szakmaiVezeto = szakmaiVezeto;
            this.penzugyiVezeto = penzugyiVezeto;
        }
        public void update(Palyazat modified)
        {
            this.azonosito = modified.getAzonosito();
            this.palyazatTipus = modified.getPalyazatTipus();
            this.palyazatNeve = modified.getPalyazatNev();
            this.finanszirozasTipus = modified.getFinanszirozasTipus();
            this.tervezettOsszeg = modified.getTervezettOsszeg();
            this.elnyertOsszeg = modified.getElnyertOsszeg();
            this.penznem = modified.getPenznem();
            this.felhasznalasiIdoKezd = modified.getFelhasznalasiIdoKezd();
            this.felhasznalasiIdoVege = modified.getFelhasznalasiIdoVege();
            this.tudomanyterulet = modified.getTudomanyterulet();
            this.szakmaiVezeto = modified.getSzakmaiVezeto();
            this.penzugyiVezeto = modified.getPenzugyiVezeto();
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

        public void setTervezettOsszeg(double tervezettOsszeg)
        {
            this.tervezettOsszeg = tervezettOsszeg;
        }

        public void setElnyertOsszeg(double elnyertOsszeg)
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
        public void setSzakmaiVezeto(string szakmaiVezeto)
        {
            this.szakmaiVezeto = szakmaiVezeto;
        }
        public void setPenzugyiVezeto(string penzugyiVezeto)
        {
            this.penzugyiVezeto = penzugyiVezeto;
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

        public double getTervezettOsszeg()
        {
            return tervezettOsszeg;
        }

        public double getElnyertOsszeg()
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
        public string getSzakmaiVezeto()
        {
            return szakmaiVezeto;
        }
        public string getPenzugyiVezeto()
        {
            return penzugyiVezeto;
        }
        // Getterek vége
    }
}
