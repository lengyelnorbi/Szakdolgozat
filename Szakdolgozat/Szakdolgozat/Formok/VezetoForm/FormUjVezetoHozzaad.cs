using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat.Formok.VezetoForm;
using Szakdolgozat.model;
using Szakdolgozat.Repository;

namespace Szakdolgozat.Formok.UjVezetoForm
{
    public partial class FormUjVezetoHozzaad : Form
    {
        private Tarolo vezetoRepo = new Tarolo();
        RepositoryDatabaseTableVezetoSQL repoSql = new RepositoryDatabaseTableVezetoSQL();
        private Validations valdiationsRepo = new Validations();
        public FormUjVezetoHozzaad()
        {
            InitializeComponent();
        }

        private void buttonMegsem_Click(object sender, EventArgs e)
        {
            FormVezetok vezetok = new FormVezetok();
            this.Close();
            vezetok.ShowDialog();
        }

        private void buttonVezetoFelvetele_Click(object sender, EventArgs e)
        {
            errorProviderVezetoNev.SetError(textBoxVezetoNev, "");
            errorProviderVezetoTelefonszam.SetError(textBoxVezetoTelefonszam, "");
            errorProviderVezetoEmail.SetError(textBoxVezetoEmail, "");
            bool vanHiba = false;
            string vezetoNev = "";
            try
            {
                vezetoNev = Convert.ToString(textBoxVezetoNev.Text);
                if(textBoxVezetoNev.Text == string.Empty)
                {
                    errorProviderVezetoNev.SetError(textBoxVezetoNev, "Kötelező kitölteni!");
                    vanHiba = true;
                }
                else
                {
                    if(valdiationsRepo.IsValidName(vezetoNev) == false)
                    {
                        errorProviderVezetoNev.SetError(textBoxVezetoNev, "A név nem megfelelő!");
                        vanHiba = true;
                    }
                    else
                    {
                        if(vezetoRepo.isVezetoInList(vezetoNev) == true)
                        {
                            errorProviderVezetoNev.SetError(textBoxVezetoNev, "Hibás adat!");
                            vanHiba = true;
                        }
                    }
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
                    errorProviderVezetoTelefonszam.SetError(textBoxVezetoTelefonszam, "Kötelező kitölteni!");
                    vanHiba = true;
                }
                if (vezetoTelefonszam.Length > 12)
                {
                    errorProviderVezetoTelefonszam.SetError(textBoxVezetoTelefonszam, "A telefonszám túl hosszú!");
                    vanHiba = true;
                }
                if (valdiationsRepo.IsValidPhoneNumber(vezetoTelefonszam) == false)
                {
                    errorProviderVezetoTelefonszam.SetError(textBoxVezetoTelefonszam, "A telefonszám hibásan lett megadva! Példa: +3611234567/0611234567");
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
                if (textBoxVezetoEmail.Text == string.Empty)
                {
                    errorProviderVezetoEmail.SetError(textBoxVezetoEmail, "Kötelező kitölteni!");
                    vanHiba = true;
                }
                else
                {
                    if (valdiationsRepo.IsValidEmail(vezetoEmail) == false)
                    {
                        errorProviderVezetoEmail.SetError(textBoxVezetoEmail, "Az email nem megfelelő!");
                        vanHiba = true;
                    }
                    else
                    {
                        if (vezetoRepo.isEmailInList(vezetoEmail) == true)
                        {
                            errorProviderVezetoEmail.SetError(textBoxVezetoEmail, "Az email már hozzá van adva egy másik vezetőhöz!");
                            vanHiba = true;
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
                int id = repoSql.getVezetoID() + 1;
                Vezeto ujVezeto = new Vezeto(id, textBoxVezetoNev.Text, textBoxVezetoTelefonszam.Text, textBoxVezetoEmail.Text);

                vezetoRepo.vezetokHozzaadListahoz(ujVezeto);

                repoSql.insertVezetoIntoDatabase(ujVezeto);

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
            if (!Char.IsLetter(ch) && !Char.IsWhiteSpace(ch))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
