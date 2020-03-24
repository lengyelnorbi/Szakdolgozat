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
    public partial class FormUjTenyfelhasznHozzaad : Form
    {
        private Tarolo tenyfelhasznalasRepo = new Tarolo();
        RepositoryDatabaseTableTenyfelhasznalasSQL repoSql = new RepositoryDatabaseTableTenyfelhasznalasSQL();
        public FormUjTenyfelhasznHozzaad(string palyazatAZ)
        {
            InitializeComponent();
            textBoxPalyazatAZ.Text = palyazatAZ;
        }
        private void buttonMegsem_Click(object sender, EventArgs e)
        {
            FormTenyfelhasznalas tenyfelhasznalas = new FormTenyfelhasznalas(textBoxPalyazatAZ.Text);
            this.Close();
            tenyfelhasznalas.ShowDialog();
        }

        private void buttonTenyfelhasznalasLetrehoz_Click(object sender, EventArgs e)
        {
            int id = repoSql.getTenyfelhasznalasID() + 1;
            Tenyfelhasznalas ujTenyfelhasznalas = new Tenyfelhasznalas(id, textBoxPalyazatAZ.Text, comboBoxKoltsegTipus.Text, Convert.ToSingle(textBoxFizetettOsszeg.Text), textBoxFizetesDatuma.Text);

            tenyfelhasznalasRepo.tenyfelhasznalasHozzaadListahoz(ujTenyfelhasznalas);

            repoSql.insertTenyfelhasznalasIntoDatabase(ujTenyfelhasznalas);

            FormTenyfelhasznalas tenyfelhasznalas = new FormTenyfelhasznalas(textBoxPalyazatAZ.Text);
            this.Close();
            tenyfelhasznalas.ShowDialog();
        }

        private void textBoxFizetettOsszeg_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxFizetesDatuma_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
