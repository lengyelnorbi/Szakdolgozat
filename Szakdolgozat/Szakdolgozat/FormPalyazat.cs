using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szakdolgozat
{
    public partial class FormPalyazat : Form
    {
        public FormPalyazat()
        {
            InitializeComponent();
        }
        FormPalyazatModosit FormModosit = new FormPalyazatModosit();
        FormPalyazatUjHozzaad FormUjHozzaad = new FormPalyazatUjHozzaad();
        FormTenyfelhasznalas FormTenyfelhasznalas = new FormTenyfelhasznalas();
        FormKoltsegTerv FormKoltsegTerv = new FormKoltsegTerv();
        private void buttonPalyazatUjPalyazatForm_Click(object sender, EventArgs e)
        {
            FormUjHozzaad.Show();
        }
        
        private void buttonPalyazatModositForm_Click(object sender, EventArgs e)
        {
            FormModosit.Show();
        }

        private void buttonKoltsegTerv_Click(object sender, EventArgs e)
        {
            FormKoltsegTerv.Show();
        }

        private void buttonTenyfelhasznalas_Click(object sender, EventArgs e)
        {
            FormTenyfelhasznalas.Show();
        }
    }
}
