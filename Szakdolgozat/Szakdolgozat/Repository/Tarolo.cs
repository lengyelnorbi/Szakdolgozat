using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        }
    }
}
