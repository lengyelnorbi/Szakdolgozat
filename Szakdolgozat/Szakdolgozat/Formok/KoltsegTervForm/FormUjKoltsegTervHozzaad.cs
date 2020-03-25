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
    public partial class FormUjKoltsegTervHozzaad : Form
    {
        private Tarolo koltsegTervRepo = new Tarolo();
        RepositoryDatabaseTableKoltsegTervSQL repoSql = new RepositoryDatabaseTableKoltsegTervSQL();
        public FormUjKoltsegTervHozzaad(string palyazatAZ)
        {
            InitializeComponent();
            textBoxPalyazatAZ.Text = palyazatAZ;
        }

        private void buttonMegsem_Click(object sender, EventArgs e)
        {
            FormKoltsegTerv koltsegTerv = new FormKoltsegTerv(textBoxPalyazatAZ.Text);
            this.Close();
            koltsegTerv.ShowDialog();
        }

        private void buttonKoltsegTervLetrehoz_Click(object sender, EventArgs e)
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
                    errorProviderKoltsegTipus.SetError(comboBoxKoltsegTipus, "Hibás adat!");
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
                    errorProviderTervezettOsszeg.SetError(textBoxTervezettOsszeg, "Hibás adat!");
                    vanHiba = true;
                }
                if (koltsegTervRepo.IsValidValue(tervezettOsszeg) == false)
                {
                    errorProviderTervezettOsszeg.SetError(textBoxTervezettOsszeg, "Hibás adat!");
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
                        errorProviderModositottOsszeg.SetError(textBoxModositottOsszeg, "Hibás adat!");
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
                int id = repoSql.getKoltsegTervID() + 1;
                KoltsegTerv ujKoltsegTerv = new KoltsegTerv(id, textBoxPalyazatAZ.Text, comboBoxKoltsegTipus.Text, Convert.ToSingle(textBoxTervezettOsszeg.Text), Convert.ToSingle(textBoxModositottOsszeg.Text));

                koltsegTervRepo.koltsegTervHozzaadListahoz(ujKoltsegTerv);

                repoSql.insertKoltsegTervIntoDatabase(ujKoltsegTerv);

                FormKoltsegTerv koltsegTerv = new FormKoltsegTerv(textBoxPalyazatAZ.Text);
                this.Close();
                koltsegTerv.ShowDialog();
            }
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
