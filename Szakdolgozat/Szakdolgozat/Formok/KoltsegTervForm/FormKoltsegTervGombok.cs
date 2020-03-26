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
using Szakdolgozat.Formok.KoltsegTervForm;
using Szakdolgozat.Repository;

namespace Szakdolgozat
{
    public partial class FormKoltsegTerv : Form
    {
        private FormKoltsegTervModosit koltsegTervModosit;
        private FormUjKoltsegTervHozzaad ujKoltsegTervHozzaad;

        void f_Closed(object sender, EventArgs e)
        {
            koltsegTervModosit = null;
            ujKoltsegTervHozzaad = null;
        }
        private void buttonKoltsegTervModositForm_Click(object sender, EventArgs e)
        {
            if (koltsegTervModosit == null && dataGridViewKoltsegTerv.SelectedRows.Count == 1)
            {
                koltsegTervModosit = new FormKoltsegTervModosit(dataGridViewKoltsegTerv.SelectedRows[0].Cells[0].Value.ToString(), textBoxPalyazatAZ.Text, comboBoxKoltsegTipus.Text, textBoxTervezettOsszeg.Text, textBoxModositottOsszeg.Text);
                koltsegTervModosit.Closed += f_Closed;
                koltsegTervModosit.Show();
                this.Close();
            }
        }
        private void buttonUjKoltsegTervForm_Click(object sender, EventArgs e)
        {
            if (ujKoltsegTervHozzaad == null)
            {
                ujKoltsegTervHozzaad = new FormUjKoltsegTervHozzaad(palyazatAzonosito);
                ujKoltsegTervHozzaad.Closed += f_Closed;
                ujKoltsegTervHozzaad.Show();
                this.Close();
            }
        }
        private void buttonKoltsegTervTorol_Click(object sender, EventArgs e)
        {
            if ((dataGridViewKoltsegTerv.Rows == null) ||
                (dataGridViewKoltsegTerv.Rows.Count == 0))
                return;
            //A felhasználó által kiválasztott sor a DataGridView-ban            
            int sor = dataGridViewKoltsegTerv.SelectedRows[0].Index;
            if (MessageBox.Show(
                "Valóban törölni akarja a sort?",
                "Törlés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridViewKoltsegTerv.SelectedRows[0].Cells[0].Value.ToString());
                //1. törölni kell a listából
                if (id <= 0)
                    return;
                try
                {
                    koltsegTervRepo.deleteKoltsegTervFromList(id);
                }
                catch (RepositoryExceptionCantDelete recd)
                {
                    MessageBox.Show(recd.Message);
                    Debug.WriteLine("A költségterv törlés nem sikerült, nincs a listába!");
                }
                //2. törölni kell az adatbázisból
                try
                {
                    repoSql.deleteKoltsegTervFromDatabase(id);
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
        private void buttonVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
