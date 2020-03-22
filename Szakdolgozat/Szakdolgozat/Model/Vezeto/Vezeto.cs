using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.model
{
    partial class Vezeto
    {
        private int id;
        private string nev;
        private string telefonszam;
        private string email;

        //Konstruktor
        public Vezeto(int id, string nev, string telefonszam, string email)
        {
            this.id = id;
            this.nev = nev;
            this.telefonszam = telefonszam;
            this.email = email;
        }
        public void update(Vezeto modified)
        {
            this.id = modified.id;
            this.nev = modified.nev;
            this.telefonszam = modified.telefonszam;
            this.email = modified.email;
        }
        //Setterek kezdete
        public void setId(int id)
        {
            this.id = id;
        }

        public void setNev(string nev)
        {
            this.nev = nev;
        }

        public void setTelefonszam(string telefonszam)
        {
            this.telefonszam = telefonszam;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }
        //Setterek vége

        //Getterek kezdete
        public int getId()
        {
            return id;
        }

        public string getNev()
        {
            return nev;
        }

        public string getTelefonszam()
        {
            return telefonszam;
        }

        public string getEmail()
        {
            return email;
        }
        //Getterek vége
    }
}
