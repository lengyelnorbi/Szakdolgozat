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
            int id = repoSql.getKoltsegTervID() + 1;
            KoltsegTerv ujKoltsegTerv = new KoltsegTerv(id, textBoxPalyazatAZ.Text, comboBoxKoltsegTipus.Text, Convert.ToSingle(textBoxTervezettOsszeg.Text), Convert.ToSingle(textBoxModositottOsszeg.Text));

            koltsegTervRepo.koltsegTervHozzaadListahoz(ujKoltsegTerv);

            repoSql.insertKoltsegTervIntoDatabase(ujKoltsegTerv);

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
