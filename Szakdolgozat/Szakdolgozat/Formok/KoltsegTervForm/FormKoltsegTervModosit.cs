using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat.model;
using Szakdolgozat.Repository;

namespace Szakdolgozat.Formok.KoltsegTervForm
{
    public partial class FormKoltsegTervModosit : Form
    {
        int koltsegTervID;
        private Tarolo koltsegTervRepo = new Tarolo();
        RepositoryDatabaseTableKoltsegTervSQL repoSql = new RepositoryDatabaseTableKoltsegTervSQL();
        public FormKoltsegTervModosit(string id, string palyazatAZ, string koltsegTip, string tervezettOsszeg, string modositottOsszeg)
        {
            InitializeComponent();
            textBoxPalyazatAZ.Text = palyazatAZ;
            comboBoxKoltsegTipus.Text = koltsegTip;
            textBoxTervezettOsszeg.Text = tervezettOsszeg;
            textBoxModositottOsszeg.Text = modositottOsszeg;
            koltsegTervID = Convert.ToInt32(id);
        }

        private void buttonVissza_Click(object sender, EventArgs e)
        {
            FormKoltsegTerv koltsegTerv = new FormKoltsegTerv(textBoxPalyazatAZ.Text);
            this.Close();
            koltsegTerv.ShowDialog();
        }

        private void FormKoltsegTervModosit_Load(object sender, EventArgs e)
        {
            koltsegTervRepo.setKoltsegTerv(repoSql.getKoltsegTervFromDatabaseTable(textBoxPalyazatAZ.Text));
        }

        private void buttonKoltsegTervMentes_Click(object sender, EventArgs e)
        {
            KoltsegTerv modosult = new KoltsegTerv(koltsegTervID, textBoxPalyazatAZ.Text,
            comboBoxKoltsegTipus.Text,
            Convert.ToSingle(textBoxTervezettOsszeg.Text),
            Convert.ToSingle(textBoxModositottOsszeg.Text)
            );
            //1. módosítani a listába
            koltsegTervRepo.updateKoltsegTervInList(koltsegTervID, modosult);
            //2. módosítani az adatbázisban
            repoSql.updateKoltsegTervInDatabase(koltsegTervID, modosult);
            FormKoltsegTerv koltsegTerv = new FormKoltsegTerv(textBoxPalyazatAZ.Text);
            this.Close();
            koltsegTerv.ShowDialog();
        }
    }
}
