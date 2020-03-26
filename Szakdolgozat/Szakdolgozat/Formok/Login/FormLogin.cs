using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat.Model;
using Szakdolgozat.Repository;
using Szakdolgozat.Repository.TestDatabase;

namespace Szakdolgozat.Formok.Login
{
    public partial class FormLogin : Form
    {
        Tarolo tarolo = new Tarolo();
        private RepositoryDatabase databaseRepo = new RepositoryDatabase();
        int i;
        ConnectionString cs = new ConnectionString();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //Adatbázis létrehozása
            databaseRepo.getCreateDatabase();
            //felhasznalok és jelszavak táblák létrehozása
            databaseRepo.getCreateFelhasznalokTable();
            //felhasznalok és jelszavak tábla adatainak insertálása
            databaseRepo.getInsertFelhasznalokIntoDatabase();
            textBoxJelszo.UseSystemPasswordChar = true;
            checkBoxJelszoElrejt.Checked = true;
        }

        private void buttonBelep_Click(object sender, EventArgs e)
        {
            i = 0;
            string felhasznalonev = textBoxFelhasznalonev.Text;
            string jelszo = textBoxJelszo.Text;
            MySqlConnection connection = new MySqlConnection(cs.getConnectionString());
            connection.Open();
            string query = "SELECT * FROM felhasznalok WHERE felhasznalo_nev = '" + felhasznalonev + "' AND jelszo = '" + jelszo + "';";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                labelHiba.Text = "Rossz felhasználónév vagy jelszó!";
                textBoxFelhasznalonev.Text = "";
                textBoxJelszo.Text = "";
            }
            else
            {
                FormPalyazat formPalyazat = new FormPalyazat();
                formPalyazat.Show();
                this.Hide();
            }

        }

        private void checkBoxJelszoElrejt_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJelszoElrejt.Checked)
            {
                textBoxJelszo.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxJelszo.UseSystemPasswordChar = false;
            }
        }
    }
}
