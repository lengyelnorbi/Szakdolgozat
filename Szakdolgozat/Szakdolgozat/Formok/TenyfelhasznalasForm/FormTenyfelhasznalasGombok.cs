﻿using System;
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
    public partial class FormTenyfelhasznalas : Form
    {
        private void buttonHozzaad_Click(object sender, EventArgs e)
        {

        }

        private void buttonModosit_Click(object sender, EventArgs e)
        {

        }

        private void buttonTorol_Click(object sender, EventArgs e)
        {
            if ((dataGridViewTenyfelhasznalas.Rows == null) ||
                (dataGridViewTenyfelhasznalas.Rows.Count == 0))
                return;
            //A felhasználó által kiválasztott sor a DataGridView-ban            
            int sor = dataGridViewTenyfelhasznalas.SelectedRows[0].Index;
            if (MessageBox.Show(
                "Valóban törölni akarja a sort?",
                "Törlés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridViewTenyfelhasznalas.SelectedRows[0].Cells[0].Value.ToString());
                //1. törölni kell a listából
                if (id <= 0)
                    return;
                try
                {
                    tenyfelhasznalasRepo.deleteTenyfelhasznalasFromList(id);
                }
                catch (RepositoryExceptionCantDelete recd)
                {
                    MessageBox.Show(recd.Message);
                    Debug.WriteLine("A tényfelhasználás törlés nem sikerült, nincs a listába!");
                }
                //2. törölni kell az adatbázisból
                try
                {
                    repoSql.deleteTenyfelhasznalasFromDatabase(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //3. frissíteni kell a DataGridView-t  
                frissitAdatokkalDataGriedViewt();
                //beallitFutarDataGriViewt();
            }
        }
    }
}
