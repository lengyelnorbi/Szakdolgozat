using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Szakdolgozat.model;
using Szakdolgozat.Model;

namespace Szakdolgozat.Repository
{
    partial class Tarolo
    {
        public Tarolo()
        {
            palyazatok = new List<Palyazat>();
            tenyfelhasznalasok = new List<Tenyfelhasznalas>();
            koltsegtervek = new List<KoltsegTerv>();
            vezetok = new List<Vezeto>();
        }
        public bool IsValidEmail(string email)
        {
            Regex reg = new Regex(@"^[\w!#$%&'+-/=?^_`{|}~]+(.[\w!#$%&'+-/=?^_`{|}~]+)*@((([-\w]+.)+[a-zA-Z]{2,4})|(([0-9]{1,3}.){3}[0-9]{1,3}))\z");
            bool result = reg.IsMatch(email);
            if(result == true)
            {
                return true;
            }
            return false;
        }
        public bool IsValidValue(string osszeg)
        {
            Regex reg = new Regex("^[1-9]");
            bool result = reg.IsMatch(osszeg);
            if(result == false)
            {
                return false;
            }
            return true;
        }
        public bool IsValidName(string nev)
        {
            Regex reg = new Regex("");
            bool result = reg.IsMatch(nev);
            if(result == true)
            {
                return true;
            }
            return false;
        }
        public bool IsValidPhoneNumber(string telefonszam)
        {
            Regex reg = new Regex("");
            bool result = reg.IsMatch(telefonszam);
            if(result == true)
            {
                return true;
            }
            return false;
        }
        public bool IsValidDate(string datum)
        {
            Regex reg = new Regex(@"^\d{4}[/.-]((0\d)|(1[012]))[/.-](([012]\d)|3[01])$");
            bool result = reg.IsMatch(datum);
            if (result == true)
            {
                return true;
            }
            return false;
        }
    }
}
