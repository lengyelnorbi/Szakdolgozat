using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.model
{
    partial class Poszt
    {
        public string getUpdate()
        {
            return
                   "UPDATE `posztok` SET `Palyazat_Azonosito` = '" +
                   getPalyazatAzonosito() +
                   "', `Vezeto_id` = '" +
                   getVezetoId() +
                   "', `Poszt` = '" +
                   getPoszt() +
                   "' WHERE `posztok`.`id` = " +
                   id;
        }

        public static string getAllRecord()
        {
            return "SELECT * FROM posztok";
        }

        public static string getDeleteAllRecord()
        {
            return "DELETE FROM posztok";
        }
    }
}
