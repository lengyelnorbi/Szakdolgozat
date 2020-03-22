﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat.Formok.VezetoForm;
using Szakdolgozat.Model;
using Szakdolgozat.Repository;

namespace Szakdolgozat
{
    public partial class FormPalyazatUjHozzaad : Form
    {
        string Azonosito;
        private Tarolo palyazatRepo = new Tarolo();
        RepositoryDatabaseTablePalyazatSQL repoSql = new RepositoryDatabaseTablePalyazatSQL();
        FormVezetok FormVezetok;
        public FormPalyazatUjHozzaad()
        {
            InitializeComponent();
        }

        void f_Closed(object sender, EventArgs e)
        {
            FormVezetok = null;
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
            string palyazatAzonosito = comboBoxPalyazatTipus.Text + "1";
            Palyazat ujPalyazat = new Palyazat(palyazatAzonosito, comboBoxPalyazatTipus.Text, textBoxPalyazatNev.Text, comboBoxFinanszirozasTipus.Text,0,
                Convert.ToSingle(textBoxElnyertOsszeg.Text), comboBoxPenznem.Text, textBoxFelhasznIdoKezd.Text, textBoxFelhasznIdoVege.Text, comboBoxTudomanyTerulet.Text, textBoxSzakmaiVezeto.Text, textBoxPenzugyiVezeto.Text);

            palyazatRepo.palyazatHozzaadListahoz(ujPalyazat);

            repoSql.insertPalyazatIntoDatabase(ujPalyazat);
            repoSql.insertPosztokIntoDatabase(palyazatAzonosito, textBoxSzakmaiVezeto.Text, "Szakmai vezető");
            repoSql.insertPosztokIntoDatabase(palyazatAzonosito, textBoxPenzugyiVezeto.Text, "Pénzügyi vezető");
            repoSql.insertEmptyKoltsegTervIntoDatabase(palyazatAzonosito);

            formModosit();
            this.Close();
        }

        private void buttonVezetokForm_Click_1(object sender, EventArgs e)
        {

            if (FormVezetok == null)
            {
                FormVezetok = new FormVezetok();
                FormVezetok.Closed += f_Closed;
                FormVezetok.Show();
                this.Close();
            }
        }
    }
}
