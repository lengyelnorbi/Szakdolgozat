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
using Szakdolgozat.Formok.VezetoForm;
using Szakdolgozat.Repository;

namespace Szakdolgozat
{
    public partial class FormPalyazat : Form
    {
        void f_Closed(object sender, EventArgs e)
        {
            FormUjHozzaad = null;
            FormModosit = null;
            FormKoltsegTerv = null;
            FormTenyfelhasznalas = null;
            FormVezetok = null;
        }
        private void buttonPalyazatUjPalyazatForm_Click(object sender, EventArgs e)
        {
            if (FormUjHozzaad == null)
            {
                FormUjHozzaad = new FormPalyazatUjHozzaad();
                FormUjHozzaad.Closed += f_Closed;
                FormUjHozzaad.UpdateEventHandler += F3_UpdateEventHandler1;
                FormUjHozzaad.Show();
            }
        }
        private void buttonPalyazatModositForm_Click(object sender, EventArgs e)
        {
            if (FormModosit == null)
            {
                FormModosit = new FormPalyazatModosit(this, textBoxAzonosito.Text, comboBoxPalyazatTipus.Text, textBoxPalyazatNev.Text, comboBoxFinanszirozasTipus.Text, textBoxTervezettOsszeg.Text, textBoxElnyertOsszeg.Text, comboBoxPenznem.Text, textBoxFelhasznIdoKezd.Text, textBoxFelhasznIdoVege.Text, comboBoxTudomanyterulet.Text, textBoxSzakmaiVezeto.Text, textBoxPenzugyiVezeto.Text);
                FormModosit.Closed += f_Closed;
                FormModosit.UpdateEventHandler += F2_UpdateEventHandler1;
                FormModosit.Show();
            }
        }

        private void buttonKoltsegTerv_Click(object sender, EventArgs e)
        {
            if (FormKoltsegTerv == null)
            {
                FormKoltsegTerv = new FormKoltsegTerv(textBoxAzonosito.Text);
                FormKoltsegTerv.Closed += f_Closed;
                FormKoltsegTerv.Show();
            }
        }

        private void buttonTenyfelhasznalas_Click(object sender, EventArgs e)
        {
            if (FormTenyfelhasznalas == null)
            {
                FormTenyfelhasznalas = new FormTenyfelhasznalas(textBoxAzonosito.Text);
                FormTenyfelhasznalas.Closed += f_Closed;
                FormTenyfelhasznalas.Show();
            }
        }
        private void buttonVezetok_Click(object sender, EventArgs e)
        {
            if (FormVezetok == null)
            {
                FormVezetok = new FormVezetok();
                FormVezetok.Closed += f_Closed;
                FormVezetok.Show();
            }
        }
        private void buttonPalyazatTorol_Click(object sender, EventArgs e)
        {
            if ((dataGridViewPalyazatok.Rows == null) ||
                (dataGridViewPalyazatok.Rows.Count == 0))
                return;
            //A felhasználó által kiválasztott sor a DataGridView-ban            
            int sor = dataGridViewPalyazatok.SelectedRows[0].Index;
            if (MessageBox.Show(
                "Valóban törölni akarja a sort?",
                "Törlés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Azonosito = textBoxAzonosito.Text;
                //1. törölni kell a listából
                if (Azonosito == string.Empty)
                    return;
                try
                {
                    palyazatRepo.deletePalyazatFromList(Azonosito);
                }
                catch (RepositoryExceptionCantDelete recd)
                {
                    MessageBox.Show(recd.Message);
                    Debug.WriteLine("A pályázat törlés nem sikerült, nincs a listába!");
                }
                //2. törölni kell az adatbázisból
                try
                {
                    repoSql.deletePalyazatFromDatabase(Azonosito);
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
        private void kilépToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseRepo.getDeleteDatabase();
            Application.Exit();
        }
    }
}
