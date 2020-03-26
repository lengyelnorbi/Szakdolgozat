using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if(Convert.ToSingle(tervezettOsszeg) == 0)
            {
                textBoxTervezettOsszeg.Text = "";
            }
            else
            {
                textBoxTervezettOsszeg.Text = tervezettOsszeg;
            }
            if (Convert.ToSingle(modositottOsszeg) == 0)
            {
                textBoxModositottOsszeg.Text = "";
            }
            else
            {
                textBoxModositottOsszeg.Text = modositottOsszeg;
            }
            koltsegTervID = Convert.ToInt32(id);
        }
        private void FormKoltsegTervModosit_Load(object sender, EventArgs e)
        {
            koltsegTervRepo.setKoltsegTerv(repoSql.getKoltsegTervFromDatabaseTable(textBoxPalyazatAZ.Text));
        }

        private void buttonKoltsegTervMentes_Click(object sender, EventArgs e)
        {
            errorProviderKoltsegTipus.SetError(comboBoxKoltsegTipus, "");
            errorProviderTervezettOsszeg.SetError(textBoxTervezettOsszeg, "");
            errorProviderModositottOsszeg.SetError(textBoxModositottOsszeg, "");
            bool vanHiba = false;
            string koltsegTipus = "";
            try
            {
                koltsegTipus = Convert.ToString(comboBoxKoltsegTipus.Text);
                if (comboBoxKoltsegTipus.Text == string.Empty)
                {
                    errorProviderKoltsegTipus.SetError(comboBoxKoltsegTipus, "Kötelező kitölteni!");
                    vanHiba = true;
                }
            }
            catch (Exception ex)
            {
                errorProviderKoltsegTipus.SetError(textBoxTervezettOsszeg, "Hibás adat!");
                vanHiba = true;
            }
            string tervezettOsszeg = "";
            try
            {
                tervezettOsszeg = Convert.ToString(textBoxTervezettOsszeg.Text);
                if (textBoxTervezettOsszeg.Text == string.Empty)
                {
                    errorProviderTervezettOsszeg.SetError(textBoxTervezettOsszeg, "Kötelező kitölteni!");
                    vanHiba = true;
                }
                if (koltsegTervRepo.IsValidValue(tervezettOsszeg) == false)
                {
                    errorProviderTervezettOsszeg .SetError(textBoxTervezettOsszeg, "Az összeg nem kezdődhet nullával!");
                    vanHiba = true;
                }
            }
            catch (Exception ex)
            {
                errorProviderTervezettOsszeg.SetError(textBoxTervezettOsszeg, "Hibás adat!");
                vanHiba = true;
            }
            string modositottOsszeg = "0";
            try
            {
                if (textBoxModositottOsszeg.Text != string.Empty)
                {
                    modositottOsszeg = Convert.ToString(textBoxModositottOsszeg.Text);
                    if (koltsegTervRepo.IsValidValue(modositottOsszeg) == false)
                    {
                        errorProviderModositottOsszeg.SetError(textBoxModositottOsszeg, "Az összeg nem kezdődhet nullával!");
                        vanHiba = true;
                    }
                }
            }
            catch (Exception ex)
            {
                errorProviderModositottOsszeg.SetError(textBoxModositottOsszeg, "Hibás adat!");
                vanHiba = true;
            }
            if (!vanHiba)
            {
                textBoxModositottOsszeg.Text = modositottOsszeg;
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
        private void buttonMegsem_Click(object sender, EventArgs e)
        {
            FormKoltsegTerv koltsegTerv = new FormKoltsegTerv(textBoxPalyazatAZ.Text);
            this.Close();
            koltsegTerv.ShowDialog();
        }

        private void textBoxTervezettOsszeg_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxModositottOsszeg_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
