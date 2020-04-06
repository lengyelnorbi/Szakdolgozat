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
using Szakdolgozat.Model;
using Szakdolgozat.Repository;

namespace Szakdolgozat
{
    public partial class FormPalyazatUjHozzaad : Form
    {
        private Tarolo palyazatRepo = new Tarolo();
        RepositoryDatabaseTablePalyazatSQL repoSql = new RepositoryDatabaseTablePalyazatSQL();
        RepositoryDatabaseTableVezetoSQL vezetoRepoSql = new RepositoryDatabaseTableVezetoSQL();
        private Validations valdiationsRepo = new Validations();
        private FormVezetok FormVezetok;
        public FormPalyazatUjHozzaad()
        {
            InitializeComponent();
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        void f_Closed(object sender, EventArgs e)
        {
            FormVezetok = null;
        }
        protected void update()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        public void formModosit()
        {
            update();
            this.Close();
        }
        private void buttonMegsem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormPalyazatUjHozzaad_Load(object sender, EventArgs e)
        {
            palyazatRepo.setVezeto(vezetoRepoSql.getVezetoFromDatabaseTable());
            palyazatRepo.setPalyazat(repoSql.getPalyazatokFromDatabaseTable());
        }
        private void buttonFormVezetok_Click(object sender, EventArgs e)
        {
            if (FormVezetok == null)
            {
                FormVezetok = new FormVezetok();
                FormVezetok.Closed += f_Closed;
                FormVezetok.Show();
            }
        }
        private void buttonMentes_Click(object sender, EventArgs e)
        {
            palyazatRepo.setVezeto(vezetoRepoSql.getVezetoFromDatabaseTable());
            errorProviderPalyazatTipus.SetError(comboBoxPalyazatTipus, "");
            errorProviderPalyazatNev.SetError(textBoxPalyazatNev, "");
            errorProviderFinanszirozasTipus.SetError(comboBoxFinanszirozasTipus, "");
            errorProviderPalyazatTudomanyterulet.SetError(comboBoxTudomanyTerulet, "");
            errorProviderPalyazatSzakmaiVezeto.SetError(textBoxSzakmaiVezeto, "");
            errorProviderPalyazatPenzugyiVezeto.SetError(textBoxPenzugyiVezeto, "");
            errorProviderPalyazatElnyertOsszeg.SetError(textBoxElnyertOsszeg, "");
            errorProviderPalyazatPenznem.SetError(comboBoxPenznem, "");
            errorProviderPalyazatFelhasznIdoKezd.SetError(textBoxFelhasznIdoKezd, "");
            errorProviderPalyazatFelhasznIdoVege.SetError(textBoxFelhasznIdoVege, "");
            bool vanHiba = false;
            bool nincsSzakmaiVezeto = false;
            bool nincsPenzugyiVezeto = false;
            string palyazatTipus = "";
            try
            {
                palyazatTipus = Convert.ToString(comboBoxPalyazatTipus.Text);
                if (comboBoxPalyazatTipus.Text == string.Empty)
                {
                    errorProviderPalyazatTipus.SetError(comboBoxPalyazatTipus, "Kötelező kitölteni!");
                    vanHiba = true;
                }
            }
            catch (Exception ex)
            {
                errorProviderPalyazatTipus.SetError(comboBoxPalyazatTipus, "Hibás adat!");
                vanHiba = true;
            }
            string palyazatNev = "";
            try
            {
                palyazatNev = Convert.ToString(textBoxPalyazatNev.Text);
                if (textBoxPalyazatNev.Text == string.Empty)
                {
                    errorProviderPalyazatNev.SetError(textBoxPalyazatNev, "Kötelező kitölteni!");
                    vanHiba = true;
                }
            }
            catch (Exception ex)
            {
                errorProviderPalyazatNev.SetError(textBoxPalyazatNev, "Hibás adat!");
                vanHiba = true;
            }
            string finanszirozasTipus = "";
            try
            {
                finanszirozasTipus = Convert.ToString(comboBoxFinanszirozasTipus.Text);
                if (comboBoxFinanszirozasTipus.Text == string.Empty)
                {
                    errorProviderFinanszirozasTipus.SetError(comboBoxFinanszirozasTipus, "Kötelező kitölteni!");
                    vanHiba = true;
                }
            }
            catch (Exception ex)
            {
                errorProviderFinanszirozasTipus.SetError(comboBoxFinanszirozasTipus, "Hibás adat!");
                vanHiba = true;
            }
            string tudomanyterulet = "";
            try
            {
                tudomanyterulet = Convert.ToString(comboBoxTudomanyTerulet.Text);
                if (comboBoxTudomanyTerulet.Text == string.Empty)
                {
                    errorProviderPalyazatTudomanyterulet.SetError(comboBoxTudomanyTerulet, "Kötelező kitölteni!");
                    vanHiba = true;
                }
            }
            catch (Exception ex)
            {
                errorProviderPalyazatTudomanyterulet.SetError(comboBoxTudomanyTerulet, "Hibás adat!");
                vanHiba = true;
            }
            string szakmaiVezeto = "";
            try
            {
                szakmaiVezeto = Convert.ToString(textBoxSzakmaiVezeto.Text);
                if (textBoxSzakmaiVezeto.Text == string.Empty)
                {
                    nincsSzakmaiVezeto = true; 
                }
                else
                {
                    if (valdiationsRepo.IsValidName(szakmaiVezeto) == false)
                    {
                        errorProviderPalyazatSzakmaiVezeto.SetError(textBoxSzakmaiVezeto, "A vezető neve nem megfelelő!");
                        vanHiba = true;
                    }
                    else
                    {
                        if (palyazatRepo.isVezetoInList(szakmaiVezeto) == false)
                        {
                            errorProviderPalyazatSzakmaiVezeto.SetError(textBoxSzakmaiVezeto, "A vezető nincs benne az adatbázisban!");
                            vanHiba = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorProviderPalyazatSzakmaiVezeto.SetError(textBoxSzakmaiVezeto, "Hibás adat!");
                vanHiba = true;
            }
            string penzugyiVezeto = "";
            try
            {
                penzugyiVezeto = Convert.ToString(textBoxPenzugyiVezeto.Text);
                if(textBoxPenzugyiVezeto.Text == string.Empty)
                {
                    nincsPenzugyiVezeto = true;
                }
                else
                {
                    if(valdiationsRepo.IsValidName(penzugyiVezeto) == false)
                    {
                        errorProviderPalyazatPenzugyiVezeto.SetError(textBoxPenzugyiVezeto, "A vezető neve nem megfelelő!");
                        vanHiba = true;
                    }
                    else
                    {
                        if (palyazatRepo.isVezetoInList(penzugyiVezeto) == false)
                        {
                            errorProviderPalyazatPenzugyiVezeto.SetError(textBoxPenzugyiVezeto, "A vezető nincs benne az adatbázisban!");
                            vanHiba = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorProviderPalyazatPenzugyiVezeto.SetError(textBoxPenzugyiVezeto, "Hibás adat!");
                vanHiba = true;
            }
            string elnyertOsszeg = "";
            try
            {
                elnyertOsszeg = Convert.ToString(textBoxElnyertOsszeg.Text);
                if (textBoxElnyertOsszeg.Text == string.Empty)
                {
                    textBoxElnyertOsszeg.Text = "0";
                }
                else
                {
                    if (textBoxElnyertOsszeg.Text != string.Empty && textBoxElnyertOsszeg.Text != "0")
                    {
                        if (valdiationsRepo.IsValidValue(elnyertOsszeg) == false)
                        {
                            errorProviderPalyazatElnyertOsszeg.SetError(textBoxElnyertOsszeg, "Az összeg nem kezdődhet nullával!");
                            vanHiba = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorProviderPalyazatElnyertOsszeg.SetError(textBoxElnyertOsszeg, "Hibás adat!");
                vanHiba = true;
            }
            string penznem = "";
            try
            {
                penznem = Convert.ToString(comboBoxPenznem.Text);
            }
            catch (Exception ex)
            {
                errorProviderPalyazatPenznem.SetError(comboBoxPenznem, "Hibás adat!");
                vanHiba = true;
            }
            string felhasznalasiIdoKezd = "";
            try
            {
                felhasznalasiIdoKezd = Convert.ToString(textBoxFelhasznIdoKezd.Text);
                if (textBoxFelhasznIdoVege.Text != string.Empty)
                {
                    if (valdiationsRepo.IsValidDate(felhasznalasiIdoKezd) == false)
                    {
                        errorProviderPalyazatFelhasznIdoKezd.SetError(textBoxFelhasznIdoKezd, "A dátum formája nem megfelelő!");
                        vanHiba = true;
                    }
                }
            }
            catch (Exception ex)
            {
                errorProviderPalyazatFelhasznIdoKezd.SetError(textBoxFelhasznIdoKezd, "Hibás adat!");
                vanHiba = true;
            }
            string felhasznalasiIdoVege = "";
            try
            {
                felhasznalasiIdoVege = Convert.ToString(textBoxFelhasznIdoVege.Text);
                if (textBoxFelhasznIdoVege.Text != string.Empty)
                {
                    if (valdiationsRepo.IsValidDate(felhasznalasiIdoVege) == false)
                    {
                        errorProviderPalyazatFelhasznIdoVege.SetError(textBoxFelhasznIdoVege, "A dátum formája nem megfelelő!");
                        vanHiba = true;
                    }
                }
            }
            catch (Exception ex)
            {
                errorProviderPalyazatFelhasznIdoVege.SetError(textBoxFelhasznIdoVege, "Hibás adat!");
                vanHiba = true;
            }
            if (!vanHiba)
            {
                string palyazatAzonosito;
                do
                {
                    palyazatAzonosito = "";
                    char[] chars = "qwertzuiopasdfghjklyxcvbnm1234567890QWERTZUUIOPASDFGHJKLYXCVBNM".ToCharArray();
                    Random r = new Random();
                    for (int i = 0; i < 10; i++)
                    {
                        palyazatAzonosito += chars[r.Next(0, 63)].ToString();
                    }
                }
                while (!palyazatRepo.isPalyazatAzonositoInList(palyazatAzonosito));

                Palyazat ujPalyazat = new Palyazat(palyazatAzonosito, comboBoxPalyazatTipus.Text, textBoxPalyazatNev.Text, comboBoxFinanszirozasTipus.Text, 0,
                    Convert.ToSingle(textBoxElnyertOsszeg.Text), comboBoxPenznem.Text, textBoxFelhasznIdoKezd.Text, textBoxFelhasznIdoVege.Text, comboBoxTudomanyTerulet.Text, textBoxSzakmaiVezeto.Text, textBoxPenzugyiVezeto.Text);

                palyazatRepo.palyazatHozzaadListahoz(ujPalyazat);

                repoSql.insertPalyazatIntoDatabase(ujPalyazat);
                repoSql.insertEmptyKoltsegTervIntoDatabase(palyazatAzonosito);
                repoSql.insertEmptyLeirasIntoDatabase(palyazatAzonosito);
                if (!nincsSzakmaiVezeto)
                {
                    repoSql.insertPosztokIntoDatabase(palyazatAzonosito, textBoxSzakmaiVezeto.Text, "Szakmai vezető");
                }
                if (!nincsPenzugyiVezeto)
                {
                    repoSql.insertPosztokIntoDatabase(palyazatAzonosito, textBoxPenzugyiVezeto.Text, "Pénzügyi vezető");
                }
                formModosit();
                this.Close();
            }
        }
    }
}
