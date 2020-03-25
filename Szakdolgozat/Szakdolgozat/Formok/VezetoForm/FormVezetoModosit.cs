using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat.model;
using Szakdolgozat.Repository;

namespace Szakdolgozat.Formok.VezetoForm
{
    public partial class FormVezetoModosit : Form
    {
        int vezetoID;
        string vezetoKezdoEmail = "";
        private Tarolo vezetoRepo = new Tarolo();
        RepositoryDatabaseTableVezetoSQL repoSql = new RepositoryDatabaseTableVezetoSQL();
        public FormVezetoModosit(int id, string nev, string telefonszam, string email)
        {
            InitializeComponent();
            vezetoID = id;
            textBoxVezetoNev.Text = nev;
            textBoxVezetoTelefonszam.Text = telefonszam;
            textBoxVezetoEmail.Text = email;
            vezetoKezdoEmail = email;
        }

        private void buttonMegsem_Click(object sender, EventArgs e)
        {
            FormVezetok vezetok = new FormVezetok();
            this.Close();
            vezetok.ShowDialog();
        }

        private void FormVezetoModosit_Load(object sender, EventArgs e)
        {
            vezetoRepo.setVezeto(repoSql.getVezetoFromDatabaseTable());
        }

        private void buttonVezetoModositMentes_Click(object sender, EventArgs e)
        {
            errorProviderVezetoNev.SetError(textBoxVezetoNev, "");
            errorProviderVezetoTelefonszam.SetError(textBoxVezetoTelefonszam, "");
            errorProviderVezetoEmail.SetError(textBoxVezetoEmail, "");
            bool vanHiba = false;
            string vezetoNev = "";
            try
            {
                vezetoNev = Convert.ToString(textBoxVezetoNev.Text);
                if (textBoxVezetoNev.Text == string.Empty)
                {
                    errorProviderVezetoNev.SetError(textBoxVezetoNev, "Hibás adat!");
                    vanHiba = true;
                }
            }
            catch (Exception ex)
            {
                errorProviderVezetoNev.SetError(textBoxVezetoNev, "Hibás adat!");
                vanHiba = true;
            }
            string vezetoTelefonszam = "";
            try
            {
                vezetoTelefonszam = Convert.ToString(textBoxVezetoTelefonszam.Text);
                if (textBoxVezetoTelefonszam.Text == string.Empty)
                {
                    errorProviderVezetoTelefonszam.SetError(textBoxVezetoTelefonszam, "Hibás adat!");
                    vanHiba = true;
                }
            }
            catch (Exception ex)
            {
                errorProviderVezetoTelefonszam.SetError(textBoxVezetoTelefonszam, "Hibás adat!");
                vanHiba = true;
            }
            string vezetoEmail = "";
            try
            {
                vezetoEmail = Convert.ToString(textBoxVezetoEmail.Text);
                if (vezetoEmail != vezetoKezdoEmail)
                {
                    if(textBoxVezetoEmail.Text == string.Empty)
                    {
                        errorProviderVezetoEmail.SetError(textBoxVezetoEmail, "Hibás adat!");
                        vanHiba = true;
                    }
                    else
                    {
                        if (vezetoRepo.IsValidEmail(vezetoEmail) == false)
                        {
                            errorProviderVezetoEmail.SetError(textBoxVezetoEmail, "Hibás adat!");
                            vanHiba = true;
                        }
                        else
                        {
                            if (vezetoRepo.isEmailInList(vezetoEmail) == false)
                            {
                            }
                            else
                            {
                                errorProviderVezetoEmail.SetError(textBoxVezetoEmail, "Hibás adat!");
                                vanHiba = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorProviderVezetoEmail.SetError(textBoxVezetoEmail, "Hibás adat!");
                vanHiba = true;
            }
            if (!vanHiba)
            {
                Vezeto modosult = new Vezeto(vezetoID, textBoxVezetoNev.Text,
                                            textBoxVezetoTelefonszam.Text,
                                            textBoxVezetoEmail.Text
                                            );
                //1. módosítani a listába
                vezetoRepo.updateVezetokInList(vezetoID, modosult);
                //2. módosítani az adatbázisban
                repoSql.updateVezetokInDatabase(vezetoID, modosult);
                FormVezetok vezetok = new FormVezetok();
                this.Close();
                vezetok.ShowDialog();
            }
        }

        private void textBoxVezetoNev_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void textBoxVezetoTelefonszam_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
