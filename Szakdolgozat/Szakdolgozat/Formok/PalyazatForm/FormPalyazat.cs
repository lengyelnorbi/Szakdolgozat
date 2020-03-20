using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat.Repository;

namespace Szakdolgozat
{
    public partial class FormPalyazat : Form
    {
        private void F2_UpdateEventHandler1(object sender, FormPalyazatModosit.UpdateEventArgs args)
        {
            palyazatRepo.setPalyazat(repoSql.getPalyazatokFromDatabaseTable());
            frissitAdatokkalDataGriedViewt();
        }

        public FormPalyazat()
        {
            InitializeComponent();
        }
        string Azonosito;
        private Tarolo palyazatRepo = new Tarolo();
        private DataTable palyazatDT = new DataTable();
        RepositoryDatabaseTablePalyazatSQL repoSql = new RepositoryDatabaseTablePalyazatSQL();
        private FormPalyazatModosit FormModosit;
        private FormPalyazatUjHozzaad FormUjHozzaad;
        private FormKoltsegTerv FormKoltsegTerv;
        private FormTenyfelhasznalas FormTenyfelhasznalas;
        private void FormPalyazat_Load(object sender, EventArgs e)
        {
            palyazatRepo.setPalyazat(repoSql.getPalyazatokFromDatabaseTable());
            frissitAdatokkalDataGriedViewt();
            beallitPalyazatDataGriViewt();
            dataGridViewPalyazatok.SelectionChanged += dataGridViewPalyazatok_SelectionChanged;
        }
        private void frissitAdatokkalDataGriedViewt()
        {
            palyazatDT = palyazatRepo.getPalyazatDataTableFromList();//szarul frissít
            dataGridViewPalyazatok.DataSource = null;
            dataGridViewPalyazatok.DataSource = palyazatDT;
        }
        private void beallitPalyazatDataGriViewt()
        {
            palyazatDT.Columns[0].ColumnName = "Azonosító";
            palyazatDT.Columns[0].Caption = "Azonosító";
            palyazatDT.Columns[1].ColumnName = "Pályázat Típus";
            palyazatDT.Columns[1].Caption = "Pályázat Típus";
            palyazatDT.Columns[2].ColumnName = "Pályázat Név";
            palyazatDT.Columns[2].Caption = "Pályázat Név";
            palyazatDT.Columns[3].ColumnName = "Finanszírozás Típus";
            palyazatDT.Columns[3].Caption = "Finanszírozás Típus";
            palyazatDT.Columns[4].ColumnName = "Tervezett Összeg";
            palyazatDT.Columns[4].Caption = "Tervezett Összeg";
            palyazatDT.Columns[5].ColumnName = "Elnyert Összeg";
            palyazatDT.Columns[5].Caption = "Elnyert Összeg";
            palyazatDT.Columns[6].ColumnName = "Pénznem";
            palyazatDT.Columns[6].Caption = "Pénznem";
            palyazatDT.Columns[7].ColumnName = "Felhasználási idő kezdete";
            palyazatDT.Columns[7].Caption = "Felhasználási idő kezdete";
            palyazatDT.Columns[8].ColumnName = "Felhasználási idő vége";
            palyazatDT.Columns[8].Caption = "Felhasználási idő vége";
            palyazatDT.Columns[9].ColumnName = "Tudományterület";
            palyazatDT.Columns[9].Caption = "Tudományterület";
            palyazatDT.Columns[10].ColumnName = "Szakmai vezető";
            palyazatDT.Columns[10].Caption = "Szakmai vezető";
            palyazatDT.Columns[11].ColumnName = "Pénzügyi vezető";
            palyazatDT.Columns[11].Caption = "Pénzügyi vezető";

            dataGridViewPalyazatok.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPalyazatok.ReadOnly = true;
            dataGridViewPalyazatok.AllowUserToDeleteRows = false;
            dataGridViewPalyazatok.AllowUserToAddRows = false;
            dataGridViewPalyazatok.MultiSelect = false;
        }
        private void dataGridViewPalyazatok_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPalyazatok.SelectedRows.Count == 1)
            {
                textBoxAzonosito.Text =
                    dataGridViewPalyazatok.SelectedRows[0].Cells[0].Value.ToString();
                comboBoxPalyazatTipus.Text =
                    dataGridViewPalyazatok.SelectedRows[0].Cells[1].Value.ToString();
                textBoxPalyazatNev.Text =
                    dataGridViewPalyazatok.SelectedRows[0].Cells[2].Value.ToString();
                comboBoxFinanszirozasTipus.Text =
                    dataGridViewPalyazatok.SelectedRows[0].Cells[3].Value.ToString();
                textBoxTervezettOsszeg.Text =
                    dataGridViewPalyazatok.SelectedRows[0].Cells[4].Value.ToString();
                textBoxElnyertOsszeg.Text =
                    dataGridViewPalyazatok.SelectedRows[0].Cells[5].Value.ToString();
                comboBoxPenznem.Text =
                    dataGridViewPalyazatok.SelectedRows[0].Cells[6].Value.ToString();
                textBoxFelhasznIdoKezd.Text =
                    dataGridViewPalyazatok.SelectedRows[0].Cells[7].Value.ToString();
                textBoxFelhasznIdoVege.Text =
                    dataGridViewPalyazatok.SelectedRows[0].Cells[8].Value.ToString();
                comboBoxTudomanyterulet.Text =
                    dataGridViewPalyazatok.SelectedRows[0].Cells[9].Value.ToString();
                textBoxSzakmaiVezeto.Text = 
                    dataGridViewPalyazatok.SelectedRows[0].Cells[10].Value.ToString();
                textBoxPenzugyiVezeto.Text =
                    dataGridViewPalyazatok.SelectedRows[0].Cells[11].Value.ToString();
            }
        }

        private void buttonDataTableFrissit_Click(object sender, EventArgs e)
        {
            palyazatRepo.setPalyazat(repoSql.getPalyazatokFromDatabaseTable());
            frissitAdatokkalDataGriedViewt();
            beallitPalyazatDataGriViewt();
            dataGridViewPalyazatok.SelectionChanged += dataGridViewPalyazatok_SelectionChanged;
        }
    }
}
