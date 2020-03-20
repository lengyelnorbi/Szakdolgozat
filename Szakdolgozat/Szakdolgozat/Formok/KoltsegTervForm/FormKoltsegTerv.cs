using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat.Repository;

namespace Szakdolgozat
{
    public partial class FormKoltsegTerv : Form
    {
        string palyazatAzonosito;
        private Tarolo koltsegTervRepo = new Tarolo();
        private DataTable koltsegtervDT = new DataTable();
        RepositoryDatabaseTableKoltsegTervSQL repoSql = new RepositoryDatabaseTableKoltsegTervSQL();
        public FormKoltsegTerv(string palyazatAZ)
        {
            InitializeComponent();
            palyazatAzonosito = palyazatAZ;
        }
        private void FormKoltsegTerv_Load(object sender, EventArgs e)
        {
            koltsegTervRepo.setKoltsegTerv(repoSql.getKoltsegTervFromDatabaseTable(palyazatAzonosito));
            frissitAdatokkalDataGriedViewt();
            beallitTenyfelhasznalasDataGriViewt();
            dataGridViewKoltsegTerv.SelectionChanged += dataGridViewKoltsegTerv_SelectionChanged;
        }
        private void frissitAdatokkalDataGriedViewt()
        {
            koltsegtervDT = koltsegTervRepo.getKoltsegTervDataTableFromList();
            dataGridViewKoltsegTerv.DataSource = null;
            dataGridViewKoltsegTerv.DataSource = koltsegtervDT;
        }
        private void beallitTenyfelhasznalasDataGriViewt()
        {
            koltsegtervDT.Columns[0].ColumnName = "Költségterv Azonosító";
            koltsegtervDT.Columns[0].Caption = "Költségterv Azonosító";
            koltsegtervDT.Columns[1].ColumnName = "Pályázat Azonosító";
            koltsegtervDT.Columns[1].Caption = "Pályázat Azonosító";
            koltsegtervDT.Columns[2].ColumnName = "Költség típus";
            koltsegtervDT.Columns[2].Caption = "Költség típus";
            koltsegtervDT.Columns[3].ColumnName = "Tervezett összeg";
            koltsegtervDT.Columns[3].Caption = "Tervezett összeg";
            koltsegtervDT.Columns[4].ColumnName = "Módosított összeg";
            koltsegtervDT.Columns[4].Caption = "Módosított összeg";

            dataGridViewKoltsegTerv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKoltsegTerv.ReadOnly = true;
            dataGridViewKoltsegTerv.AllowUserToDeleteRows = false;
            dataGridViewKoltsegTerv.AllowUserToAddRows = false;
            dataGridViewKoltsegTerv.MultiSelect = false;
        }
        private void dataGridViewKoltsegTerv_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewKoltsegTerv.SelectedRows.Count == 1)
            {
                textBoxPalyazatAZ.Text =
                    dataGridViewKoltsegTerv.SelectedRows[0].Cells[1].Value.ToString();
                comboBoxKoltsegTipus.Text =
                    dataGridViewKoltsegTerv.SelectedRows[0].Cells[2].Value.ToString();
                textBoxTervezettOsszeg.Text =
                    dataGridViewKoltsegTerv.SelectedRows[0].Cells[3].Value.ToString();
                textBoxModositottOsszeg.Text =
                    dataGridViewKoltsegTerv.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
