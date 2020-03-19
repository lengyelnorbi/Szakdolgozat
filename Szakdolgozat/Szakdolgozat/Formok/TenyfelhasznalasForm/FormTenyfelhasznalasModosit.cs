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

namespace Szakdolgozat.Formok.TenyfelhasznalasForm
{
    public partial class FormTenyfelhasznalasModosit : Form
    {
        int tenyfelhasznID;
        private Tarolo tenyfelhasznalasRepo = new Tarolo();
        RepositoryDatabaseTableTenyfelhasznalasSQL repoSql = new RepositoryDatabaseTableTenyfelhasznalasSQL();
        public FormTenyfelhasznalasModosit(string id, string palyazatAZ, string koltsegTip, string osszeg, string datum)
        {
            InitializeComponent();
            textBoxPalyazatAZ.Text = palyazatAZ;
            comboBoxKoltsegTipus.Text = koltsegTip;
            textBoxFizetettOsszeg.Text = osszeg;
            textBoxFizetesDatuma.Text = datum;
            tenyfelhasznID = Convert.ToInt32(id);
        }

        private void buttonTenyfelhasznalasModositForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormTenyfelhasznalasModosit_Load(object sender, EventArgs e)
        {
            tenyfelhasznalasRepo.setTenyfelhasznalas(repoSql.getTenyfelhasznalasFromDatabaseTable(textBoxPalyazatAZ.Text));
        }
        private void buttonTenyfelhasznMentes_Click(object sender, EventArgs e)
        {
            Tenyfelhasznalas modosult = new Tenyfelhasznalas(tenyfelhasznID, textBoxPalyazatAZ.Text,
            comboBoxKoltsegTipus.Text,
            Convert.ToSingle(textBoxFizetettOsszeg.Text),
            textBoxFizetesDatuma.Text
            );
            //1. módosítani a listába
            tenyfelhasznalasRepo.updateTenyfelhasznalasInList(tenyfelhasznID, modosult);
            //2. módosítani az adatbázisban
            repoSql.updateTenyfelhasznalasInDatabase(tenyfelhasznID, modosult);
            FormTenyfelhasznalas tenyfelhasznalas = new FormTenyfelhasznalas(textBoxPalyazatAZ.Text);
            this.Close();
            tenyfelhasznalas.ShowDialog();
        }
    }
}
