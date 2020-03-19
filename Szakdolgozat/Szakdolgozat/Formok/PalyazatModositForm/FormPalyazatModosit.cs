﻿using System;
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
    public partial class FormPalyazatModosit : Form
    {
        private FormPalyazat FormModosit;
        void f_Closed(object sender, EventArgs e)
        {
            FormModosit = null;
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

        string Azonosito;
        private Tarolo palyazatRepo = new Tarolo();
        private DataTable palyazatDT = new DataTable();
        RepositoryDatabaseTablePalyazatSQL repoSql = new RepositoryDatabaseTablePalyazatSQL();
        public FormPalyazatModosit(FormPalyazat form1, string pAZ, string pTipus, string pNev, string pFin, string pTOszz, string pEOssz, string pPenznem, string pFIK, string pFIV, string pTudomany, string pSzvezeto, string pPenzvezeto)
        {
            InitializeComponent();
            textBoxPalyazatAzonosito.Text = pAZ;
            comboBoxPalyazatTipus.Text = pTipus;
            textBoxPalyazatNev.Text = pNev;
            comboBoxFinanszirozasTipus.Text = pFin;
            textBoxTervezettOsszeg.Text = pTOszz;
            textBoxElnyertOsszeg.Text = pEOssz;
            comboBoxPenznem.Text = pPenznem;
            textBoxFelhasznIdoKezd.Text = pFIK;
            textBoxFelhasznIdoVege.Text = pFIV;
            comboBoxTudomanyTerulet.Text = pTudomany;
            textBoxSzakmaiVezeto.Text = pSzvezeto;
            textBoxPenzugyiVezeto.Text = pPenzvezeto;
        }

        public void formModosit()
        {
            update();
            this.Close();
        }

        private void FormPalyazatModosit_Load(object sender, EventArgs e)
        {
            palyazatRepo.setPalyazat(repoSql.getPalyazatokFromDatabaseTable());
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            Palyazat modosult = new Palyazat(textBoxPalyazatAzonosito.Text,
            comboBoxPalyazatTipus.Text,
            textBoxPalyazatNev.Text,
            comboBoxFinanszirozasTipus.Text,
            Convert.ToInt32(textBoxTervezettOsszeg.Text),
            Convert.ToInt32(textBoxElnyertOsszeg.Text),
            comboBoxPenznem.Text,
            textBoxFelhasznIdoKezd.Text,
            textBoxFelhasznIdoVege.Text,
            comboBoxTudomanyTerulet.Text,
            textBoxSzakmaiVezeto.Text,
            textBoxPenzugyiVezeto.Text
            );
            Azonosito = textBoxPalyazatAzonosito.Text;
            //1. módosítani a listába
            palyazatRepo.updatePalyazatInList(Azonosito, modosult);
            //2. módosítani az adatbázisban
            repoSql.updatePalyazatInDatabase(Azonosito, modosult);
            formModosit();
        }
        private void buttonVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
