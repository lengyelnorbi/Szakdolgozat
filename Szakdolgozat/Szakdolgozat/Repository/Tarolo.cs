using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"+"@"+@"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            Regex reg = new Regex(pattern);
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
            string[] nevDarabok = nev.Split(null);
            if(nevDarabok.Length < 2)
            {
                return false;
            }
            Regex reg = new Regex("^([A-Z]|[ÍÉÁŐŰÚÓ]){1}([a-z]|[íéáőűúó]){1,}$");
            int joDarabok = 0;
            for(int i = 0; i < nevDarabok.Length; i++)
            {
                bool result = reg.IsMatch(nevDarabok[i]);
                if(result == true)
                {
                    joDarabok += 1;
                }
            }
            if(nevDarabok.Length == joDarabok)
            {
                return true;
            }
            return false;
        }
        public bool IsValidPhoneNumber(string telefonszam)
        {
            Regex reg = new Regex(@"^(((\+)(3)(6)|(0)(6))(((1)[0-9]{7})|((2)(0)|(3)(0)|(5)(0)|(7)(0))[0-9]{7}|((6)(2)[0-9]{6})))$");
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
