using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat.Formok.TenyfelhasznalasForm;
using Szakdolgozat.Repository;

namespace Szakdolgozat
{
    public partial class FormTenyfelhasznalas : Form
    {

        string Azonosito;
        private Tarolo tenyfelhasznalasRepo = new Tarolo();
        private DataTable tenyfelhasznalasDT = new DataTable();
        RepositoryDatabaseTableTenyfelhasznalasSQL repoSql = new RepositoryDatabaseTableTenyfelhasznalasSQL();
        public FormTenyfelhasznalas(string palyazatAZ)
        {
            InitializeComponent();
            Azonosito = palyazatAZ;
        }
        private void FormTenyfelhasznalas_Load(object sender, EventArgs e)
        {
            tenyfelhasznalasRepo.setTenyfelhasznalas(repoSql.getTenyfelhasznalasFromDatabaseTable(Azonosito));
            frissitAdatokkalDataGriedViewt();
            beallitTenyfelhasznalasDataGriViewt();
            dataGridViewTenyfelhasznalas.SelectionChanged += dataGridViewTenyfelhasznalas_SelectionChanged;
        }
        private void frissitAdatokkalDataGriedViewt()
        {
            tenyfelhasznalasDT = tenyfelhasznalasRepo.getTenyfelhasznalasDataTableFromList();
            dataGridViewTenyfelhasznalas.DataSource = null;
            dataGridViewTenyfelhasznalas.DataSource = tenyfelhasznalasDT;
        }
        private void beallitTenyfelhasznalasDataGriViewt()
        {
            tenyfelhasznalasDT.Columns[0].ColumnName = "Tényfelhasználás Azonosító";
            tenyfelhasznalasDT.Columns[0].Caption = "Tényfelhasználás Azonosító";
            tenyfelhasznalasDT.Columns[1].ColumnName = "Pályázat Azonosító";
            tenyfelhasznalasDT.Columns[1].Caption = "Pályázat Azonosító";
            tenyfelhasznalasDT.Columns[2].ColumnName = "Költség típus";
            tenyfelhasznalasDT.Columns[2].Caption = "Költség típus";
            tenyfelhasznalasDT.Columns[3].ColumnName = "Fizetett összeg";
            tenyfelhasznalasDT.Columns[3].Caption = "Fizetett összeg";
            tenyfelhasznalasDT.Columns[4].ColumnName = "Fizetés dátuma";
            tenyfelhasznalasDT.Columns[4].Caption = "Fizetés dátuma";

            dataGridViewTenyfelhasznalas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTenyfelhasznalas.ReadOnly = true;
            dataGridViewTenyfelhasznalas.AllowUserToDeleteRows = false;
            dataGridViewTenyfelhasznalas.AllowUserToAddRows = false;
            dataGridViewTenyfelhasznalas.MultiSelect = false;
        }
        private void dataGridViewTenyfelhasznalas_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTenyfelhasznalas.SelectedRows.Count == 1)
            {
                textBoxPalyazatAZ.Text =
                    dataGridViewTenyfelhasznalas.SelectedRows[0].Cells[1].Value.ToString();
                comboBoxKoltsegTipus.Text =
                    dataGridViewTenyfelhasznalas.SelectedRows[0].Cells[2].Value.ToString();
                textBoxFizetettOsszeg.Text =
                    dataGridViewTenyfelhasznalas.SelectedRows[0].Cells[3].Value.ToString();
                textBoxFizetesDatuma.Text =
                    dataGridViewTenyfelhasznalas.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
