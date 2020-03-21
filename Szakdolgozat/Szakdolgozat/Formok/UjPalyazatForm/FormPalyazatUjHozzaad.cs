using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat.Model;
using Szakdolgozat.Repository;

namespace Szakdolgozat
{
    public partial class FormPalyazatUjHozzaad : Form
    {
        string Azonosito;
        private Tarolo palyazatRepo = new Tarolo();
        RepositoryDatabaseTablePalyazatSQL repoSql = new RepositoryDatabaseTablePalyazatSQL();
        public FormPalyazatUjHozzaad()
        {
            InitializeComponent();
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void update()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        public void formModosit()
        {
            update();
            this.Close();
        }
        private void buttonMegsem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPalyazatUjHozzaad_Load(object sender, EventArgs e)
        {
            palyazatRepo.setPalyazat(repoSql.getPalyazatokFromDatabaseTable());
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            Palyazat ujPalyazat = new Palyazat(textBoxPalyazatAzonosito.Text + "Pótlék azonosító", comboBoxPalyazatTipus.Text, textBoxPalyazatNev.Text, comboBoxFinanszirozasTipus.Text,
                Convert.ToSingle(textBoxTervezettOsszeg.Text), Convert.ToSingle(textBoxElnyertOsszeg.Text), textBoxPenznem.Text, textBoxFelhasznIdoKezd.Text, textBoxFelhasznIdoVege.Text, textBoxTudomanyTerulet.Text, textBoxSzakmaiVezeto.Text, textBoxPenzugyiVezeto.Text);

            palyazatRepo.palyazatHozzaadListahoz(ujPalyazat);

            repoSql.insertPalyazatIntoDatabase(ujPalyazat);

            formModosit();
            this.Close();
        }
    }
}
