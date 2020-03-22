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

namespace Szakdolgozat.Formok.VezetoForm
{
    public partial class FormVezetoModosit : Form
    {
        int vezetoID;
        private Tarolo vezetoRepo = new Tarolo();
        RepositoryDatabaseTableVezetoSQL repoSql = new RepositoryDatabaseTableVezetoSQL();
        public FormVezetoModosit(int id, string nev, string telefonszam, string email)
        {
            InitializeComponent();
            vezetoID = id;
            textBoxVezetoNev.Text = nev;
            textBoxVezetoTelefonszam.Text = telefonszam;
            textBoxVezetoEmail.Text = email;
        }

        private void buttonMegsem_Click(object sender, EventArgs e)
        {
            FormVezetok vezetok = new FormVezetok();
            this.Close();
            vezetok.ShowDialog();
        }

        private void FormVezetoModosit_Load(object sender, EventArgs e)
        {
            vezetoRepo.setVezeto(repoSql.getVezetoFromDatabaseTable());
        }

        private void buttonVezetoModositMentes_Click(object sender, EventArgs e)
        {
            Vezeto modosult = new Vezeto(vezetoID, textBoxVezetoNev.Text,
            textBoxVezetoTelefonszam.Text,
            textBoxVezetoEmail.Text
            );
            //1. módosítani a listába
            vezetoRepo.updateVezetokInList(vezetoID, modosult);
            //2. módosítani az adatbázisban
            repoSql.updateVezetokInDatabase(vezetoID, modosult);
            FormVezetok vezetok = new FormVezetok();
            this.Close();
            vezetok.ShowDialog();
        }
    }
}
