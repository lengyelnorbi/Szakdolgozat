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

namespace Szakdolgozat.Formok.VezetoForm
{
    public partial class FormVezetok : Form
    {
        public FormVezetok()
        {
            InitializeComponent();
        }
        private Tarolo vezetoRepo = new Tarolo();
        private DataTable vezetoDT = new DataTable();
        RepositoryDatabaseTableVezetoSQL repoSql = new RepositoryDatabaseTableVezetoSQL();
        private void frissitAdatokkalDataGriedViewt()
        {
            vezetoDT = vezetoRepo.getVezetokDataTableFromList();
            dataGridViewVezetok.DataSource = null;
            dataGridViewVezetok.DataSource = vezetoDT;
        }
        private void beallitTenyfelhasznalasDataGriViewt()
        {
            vezetoDT.Columns[0].ColumnName = "Vezető Azonosító";
            vezetoDT.Columns[0].Caption = "Vezető Azonosító";
            vezetoDT.Columns[1].ColumnName = "Név";
            vezetoDT.Columns[1].Caption = "Név";
            vezetoDT.Columns[2].ColumnName = "Telefonszám";
            vezetoDT.Columns[2].Caption = "Telefonszám";
            vezetoDT.Columns[3].ColumnName = "Email cím";
            vezetoDT.Columns[3].Caption = "Email cím";

            dataGridViewVezetok.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVezetok.ReadOnly = true;
            dataGridViewVezetok.AllowUserToDeleteRows = false;
            dataGridViewVezetok.AllowUserToAddRows = false;
            dataGridViewVezetok.MultiSelect = false;
        }
        private void dataGridViewVezetok_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVezetok.SelectedRows.Count == 1)
            {
                textBoxVezetoNev.Text =
                    dataGridViewVezetok.SelectedRows[0].Cells[1].Value.ToString();
                textBoxVezetoTelefonszam.Text =
                    dataGridViewVezetok.SelectedRows[0].Cells[2].Value.ToString();
                textBoxVezetoEmail.Text =
                    dataGridViewVezetok.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        private void FormVezetok_Load(object sender, EventArgs e)
        {
            vezetoRepo.setVezeto(repoSql.getVezetoFromDatabaseTable());
            frissitAdatokkalDataGriedViewt();
            beallitTenyfelhasznalasDataGriViewt();
            dataGridViewVezetok.SelectionChanged += dataGridViewVezetok_SelectionChanged;
        }
    }
}
