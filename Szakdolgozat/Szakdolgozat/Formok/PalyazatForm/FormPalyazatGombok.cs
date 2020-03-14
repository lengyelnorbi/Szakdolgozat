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
        void f_Closed(object sender, EventArgs e)
        {
            FormUjHozzaad = null;
            FormModosit = null;
            FormKoltsegTerv = null;
            FormTenyfelhasznalas = null;
        }
        private void buttonPalyazatUjPalyazatForm_Click(object sender, EventArgs e)
        {
            if (FormUjHozzaad == null)
            {
                FormUjHozzaad = new FormPalyazatUjHozzaad();
                FormUjHozzaad.Closed += f_Closed;
                FormUjHozzaad.Show();
            }
        }
        private void buttonPalyazatModositForm_Click(object sender, EventArgs e)
        {
            if (FormModosit == null)
            {
                FormModosit = new FormPalyazatModosit();
                FormModosit.Closed += f_Closed;
                FormModosit.Show();
            }
        }

        private void buttonKoltsegTerv_Click(object sender, EventArgs e)
        {
            if (FormKoltsegTerv == null)
            {
                FormKoltsegTerv = new FormKoltsegTerv();
                FormKoltsegTerv.Closed += f_Closed;
                FormKoltsegTerv.Show();
            }
        }
        private void buttonTenyfelhasznalas_Click(object sender, EventArgs e)
        {
            if (FormTenyfelhasznalas == null)
            {
                FormTenyfelhasznalas = new FormTenyfelhasznalas();
                FormTenyfelhasznalas.Closed += f_Closed;
                FormTenyfelhasznalas.Show();
            }
        }
    }
}
