using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.model
{
    partial class KoltsegTipus
    {
        public string getInsert()
        {
            return "INSERT INTO `koltseg_tipusok`" +
                    "(`id`, `Koltseg_tipus`)" +
                    "VALUES ('" +
                    id +
                    "', '" +
                    getKoltsegTipus() +
                    "');";
        }

        public string getUpdate()
        {
            return
                   "UPDATE `koltseg_tipusok` SET `Koltseg_tipus ` = '" +
                   getKoltsegTipus() +
                   "' WHERE `koltseg_tipusok`.`id` = " +
                   id;
        }

        public static string getAllRecord()
        {
            return "SELECT * FROM koltseg_tipusok";
        }

        public static string getDeleteAllRecord()
        {
            return "DELETE FROM koltseg_tipusok";
        }
    }
}
