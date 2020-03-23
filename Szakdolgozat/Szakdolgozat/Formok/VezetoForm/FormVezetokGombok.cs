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
using Szakdolgozat.Formok.UjVezetoForm;
using Szakdolgozat.Repository;

namespace Szakdolgozat.Formok.VezetoForm
{
    public partial class FormVezetok : Form
    {
        int id;
        private FormUjVezetoHozzaad FormUjVezetoHozzaad;
        private FormVezetoModosit FormVezetoModosit;
        void f_Closed(object sender, EventArgs e)
        {
            FormUjVezetoHozzaad = null;
            FormVezetoModosit = null;
        }

        private void buttonUjVezetoForm_Click(object sender, EventArgs e)
        {
            if (FormUjVezetoHozzaad == null)
            {
                FormUjVezetoHozzaad = new FormUjVezetoHozzaad();
                FormUjVezetoHozzaad.Closed += f_Closed;
                FormUjVezetoHozzaad.Show();
                this.Close();
            }
        }
        private void buttonVezetoModositForm_Click(object sender, EventArgs e)
        {
            if (FormVezetoModosit == null)
            {
                FormVezetoModosit = new FormVezetoModosit(Convert.ToInt32(dataGridViewVezetok.SelectedRows[0].Cells[0].Value.ToString()), textBoxVezetoNev.Text, textBoxVezetoTelefonszam.Text, textBoxVezetoEmail.Text);
                FormVezetoModosit.Closed += f_Closed;
                FormVezetoModosit.Show();
                this.Close();
            }
        }
        private void buttonVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonVezetoTorol_Click(object sender, EventArgs e)
        {
            if ((dataGridViewVezetok.Rows == null) ||
                (dataGridViewVezetok.Rows.Count == 0))
                return;
            //A felhasználó által kiválasztott sor a DataGridView-ban
            int sor = dataGridViewVezetok.SelectedRows[0].Index;
            if (MessageBox.Show(
                "Valóban törölni akarja a sort?",
                "Törlés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridViewVezetok.SelectedRows[0].Cells[0].Value.ToString());
                //1. törölni kell a listából
                if (id <= 0)
                    return;
                try
                {
                    vezetoRepo.deleteVezetoFromList(id);
                }
                catch (RepositoryExceptionCantDelete recd)
                {
                    MessageBox.Show(recd.Message);
                    Debug.WriteLine("A vezető törlése nem sikerült, nincs a listába!");
                }
                //2. törölni kell az adatbázisból
                try
                {
                    repoSql.deleteVezetoFromDatabase(id);
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
