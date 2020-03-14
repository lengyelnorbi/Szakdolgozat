using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.model
{
    partial class Poszt
    {
        private int id;
        private string palyazatAzonosito;
        private int vezetoId;
        private string poszt;

        //Konstruktor
        public Poszt(int id, string palyazatAzonosito, int vezetoId, string poszt)
        {
            this.id = id;
            this.palyazatAzonosito = palyazatAzonosito;
            this.vezetoId = vezetoId;
            this.poszt = poszt;
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

        public void setVezetoId(int vezetoId)
        {
            this.vezetoId = vezetoId;
        }

        public void setPoszt(string poszt)
        {
            this.poszt = poszt;
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

        public int getVezetoId()
        {
            return vezetoId;
        }

        public string getPoszt()
        {
            return poszt;
        }
        //Getterek vége
    }
}
