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
        private void FormTenyfelhasznalasModosit_Load(object sender, EventArgs e)
        {
            tenyfelhasznalasRepo.setTenyfelhasznalas(repoSql.getTenyfelhasznalasFromDatabaseTable(textBoxPalyazatAZ.Text));
        }
        private void buttonTenyfelhasznMentes_Click(object sender, EventArgs e)
        {
            errorProviderTenyfelhasznalasKoltsegTipus.SetError(comboBoxKoltsegTipus, "");
            errorProviderTenyfelhasznalasOsszeg.SetError(textBoxFizetettOsszeg, "");
            errorProviderTenyfelhasznalasFizetesDatum.SetError(textBoxFizetesDatuma, "");
            bool vanHiba = false;
            string vezetoNev = "";
            try
            {
                vezetoNev = Convert.ToString(comboBoxKoltsegTipus.Text);
                if (comboBoxKoltsegTipus.Text == string.Empty)
                {
                    errorProviderTenyfelhasznalasKoltsegTipus.SetError(comboBoxKoltsegTipus, "Hibás adat!");
                    vanHiba = true;
                }
            }
            catch (Exception ex)
            {
                errorProviderTenyfelhasznalasKoltsegTipus.SetError(comboBoxKoltsegTipus, "Hibás adat!");
                vanHiba = true;
            }
            string vezetoTelefonszam = "";
            try
            {
                vezetoTelefonszam = Convert.ToString(textBoxFizetettOsszeg.Text);
                if (textBoxFizetettOsszeg.Text == string.Empty)
                {
                    errorProviderTenyfelhasznalasOsszeg.SetError(textBoxFizetettOsszeg, "Hibás adat!");
                    vanHiba = true;
                }
            }
            catch (Exception ex)
            {
                errorProviderTenyfelhasznalasOsszeg.SetError(textBoxFizetettOsszeg, "Hibás adat!");
                vanHiba = true;
            }
            string vezetoEmail = "";
            try
            {
                vezetoEmail = Convert.ToString(textBoxFizetesDatuma.Text);
                if (textBoxFizetesDatuma.Text == string.Empty)
                {
                    errorProviderTenyfelhasznalasFizetesDatum.SetError(textBoxFizetesDatuma, "Hibás adat!");
                    vanHiba = true;
                }
            }
            catch (Exception ex)
            {
                errorProviderTenyfelhasznalasFizetesDatum.SetError(textBoxFizetesDatuma, "Hibás adat!");
                vanHiba = true;
            }
            if (!vanHiba)
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

        private void buttonMegsem_Click(object sender, EventArgs e)
        {
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
