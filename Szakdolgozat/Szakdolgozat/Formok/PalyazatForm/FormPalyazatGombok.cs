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
            if (FormModosit == null && dataGridViewPalyazatok.SelectedRows.Count == 1)
            {
                FormModosit = new FormPalyazatModosit(this, textBoxAzonosito.Text, comboBoxPalyazatTipus.Text, textBoxPalyazatNev.Text, comboBoxFinanszirozasTipus.Text, textBoxTervezettOsszeg.Text, textBoxElnyertOsszeg.Text, comboBoxPenznem.Text, textBoxFelhasznIdoKezd.Text, textBoxFelhasznIdoVege.Text, comboBoxTudomanyterulet.Text, textBoxSzakmaiVezeto.Text, textBoxPenzugyiVezeto.Text);
                FormModosit.Closed += f_Closed;
                FormModosit.UpdateEventHandler += F2_UpdateEventHandler1;
                FormModosit.Show();
            }
        }

        private void buttonKoltsegTerv_Click(object sender, EventArgs e)
        {
            if (FormKoltsegTerv == null && dataGridViewPalyazatok.SelectedRows.Count == 1)
            {
                FormKoltsegTerv = new FormKoltsegTerv(textBoxAzonosito.Text);
                FormKoltsegTerv.Closed += f_Closed;
                FormKoltsegTerv.Show();
            }
        }

        private void buttonTenyfelhasznalas_Click(object sender, EventArgs e)
        {
            if (FormTenyfelhasznalas == null && dataGridViewPalyazatok.SelectedRows.Count == 1)
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
        private void buttonPalyazatKereses_Click(object sender, EventArgs e)
        {
            string keresesTipus = "";
            string keresettSzoveg = "";
            bool vanHiba = false;
            errorProviderKeresesTipus.SetError(textBoxKeresesSzoveg, "");
            errorProviderKeresesSzoveg.SetError(comboBoxKeresesTipus, "");
            try
            {
                if (comboBoxKeresesTipus.Text != string.Empty && textBoxKeresesSzoveg.Text != string.Empty)
                {
                    if (comboBoxKeresesTipus.Text == "Azonosító")
                    {
                        keresesTipus = "WHERE Azonosito LIKE '%";
                        keresettSzoveg = textBoxKeresesSzoveg.Text;
                        keresettSzoveg += "%' GROUP BY Azonosito";
                    }
                    else if (comboBoxKeresesTipus.Text == "Pályázat típus")
                    {
                        keresesTipus = "WHERE Palyazat_tipus LIKE '%";
                        keresettSzoveg = textBoxKeresesSzoveg.Text;
                        keresettSzoveg += "%' GROUP BY Azonosito";
                    }
                    else if (comboBoxKeresesTipus.Text == "Pályázat neve")
                    {
                        keresesTipus = "WHERE Palyazat_neve LIKE '%";
                        keresettSzoveg = textBoxKeresesSzoveg.Text;
                        keresettSzoveg += "%' GROUP BY Azonosito";
                    }
                    else if (comboBoxKeresesTipus.Text == "Finanszírozás típusa")
                    {
                        keresesTipus = "WHERE Finanszirozas_tipus LIKE '%";
                        keresettSzoveg = textBoxKeresesSzoveg.Text;
                        keresettSzoveg += "%' GROUP BY Azonosito";
                    }
                    else if(comboBoxKeresesTipus.Text == "Tudományterület")
                    {
                        keresesTipus = "WHERE Tudomanyterulet LIKE '%";
                        keresettSzoveg = textBoxKeresesSzoveg.Text;
                        keresettSzoveg += "%' GROUP BY Azonosito";
                    }
                    else if(comboBoxKeresesTipus.Text == "Tervezett összeg")
                    {
                        keresesTipus = "GROUP BY Azonosito ";
                        keresesTipus += "HAVING SUM(koltseg_terv.Tervezett_osszeg) = ";
                        keresettSzoveg = textBoxKeresesSzoveg.Text;
                    }
                    else if(comboBoxKeresesTipus.Text == "Elnyert összeg")
                    {
                        keresesTipus = "WHERE Elnyert_osszeg ='";
                        keresettSzoveg = textBoxKeresesSzoveg.Text;
                        keresettSzoveg += "' GROUP BY Azonosito";
                    }
                    else if(comboBoxKeresesTipus.Text == "Pénznem")
                    {
                        keresesTipus = "WHERE Penznem LIKE '%";
                        keresettSzoveg = textBoxKeresesSzoveg.Text;
                        keresettSzoveg += "%' GROUP BY Azonosito";
                    }
                }
                else
                {
                    try
                    {
                        if (comboBoxKeresesTipus.Text == "Minden pályázat")
                        {
                            palyazatRepo.setPalyazat(repoSql.getPalyazatokFromDatabaseTable());
                            frissitAdatokkalDataGriedViewt();
                            beallitPalyazatDataGriViewt();
                            dataGridViewPalyazatok.SelectionChanged += dataGridViewPalyazatok_SelectionChanged;
                        }
                        else
                        {
                            if(comboBoxKeresesTipus.Text == string.Empty)
                            {
                                errorProviderKeresesTipus.SetError(comboBoxKeresesTipus, "Nem lehet üres a keresés feltétele!");
                                vanHiba = true;
                            }
                            if(textBoxKeresesSzoveg.Text == string.Empty)
                            {
                                errorProviderKeresesSzoveg.SetError(textBoxKeresesSzoveg, "Nem lehet üres a keresés feltétele!");
                                vanHiba = true;
                            }
                        }
                    }
                    catch (Exception x)
                    {
                        vanHiba = true;
                    }
                }
            }
            catch (Exception ex)
            {
                vanHiba = true;
            }
            if (!vanHiba && comboBoxKeresesTipus.Text != "Minden pályázat")
            {
                palyazatRepo.setPalyazat(repoSql.getFilteredPalyazatokFromDatabaseTable(keresesTipus, keresettSzoveg));
                frissitAdatokkalDataGriedViewt();
                beallitPalyazatDataGriViewt();
                dataGridViewPalyazatok.SelectionChanged += dataGridViewPalyazatok_SelectionChanged;
            }
        }
        private void adatabazisTorolEsKilépToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseRepo.getDeleteDatabase();
            Application.Exit();
        }

        private void kilépToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormPalyazat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
