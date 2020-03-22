using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat.Formok.VezetoForm;
using Szakdolgozat.model;
using Szakdolgozat.Repository;

namespace Szakdolgozat.Formok.UjVezetoForm
{
    public partial class FormUjVezetoHozzaad : Form
    {
        private Tarolo vezetoRepo = new Tarolo();
        RepositoryDatabaseTableVezetoSQL repoSql = new RepositoryDatabaseTableVezetoSQL();
        public FormUjVezetoHozzaad()
        {
            InitializeComponent();
        }

        private void buttonMegsem_Click(object sender, EventArgs e)
        {
            FormVezetok vezetok = new FormVezetok();
            this.Close();
            vezetok.ShowDialog();
        }

        private void buttonVezetoFelvetele_Click(object sender, EventArgs e)
        {
            int id = repoSql.getVezetoID() + 1;
            Vezeto ujVezeto = new Vezeto(id, textBoxVezetoNev.Text, textBoxVezetoTelefonszam.Text, textBoxVezetoEmail.Text);

            vezetoRepo.vezetokHozzaadListahoz(ujVezeto);

            repoSql.insertVezetoIntoDatabase(ujVezeto);

            FormVezetok vezetok = new FormVezetok();
            this.Close();
            vezetok.ShowDialog();
        }
    }
}
