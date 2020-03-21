using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szakdolgozat.Formok.VezetoForm
{
    public partial class FormVezetoModosit : Form
    {
        public FormVezetoModosit()
        {
            InitializeComponent();
        }

        private void buttonMegsem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
