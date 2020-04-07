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
    public partial class FormPalyazatModosit : Form
    {
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void update()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        string Azonosito;
        bool vaneSzakmaiVezeto = false;
        bool vanePenzugyiVezeto = false;
        bool vaneElnyertOsszeg = false;
        string szakmaiVezetoNev = "";
        string penzugyiVezetoNev = "";
        string elnyertOsszegKezd = "";
        private FormVezetok FormVezetok;
        private Tarolo palyazatRepo = new Tarolo();
        RepositoryDatabaseTablePalyazatSQL palyazatRepoSql = new RepositoryDatabaseTablePalyazatSQL();
        RepositoryDatabaseTableVezetoSQL vezetoRepoSql = new RepositoryDatabaseTableVezetoSQL();
        private Validations valdiationsRepo = new Validations();
        public FormPalyazatModosit(FormPalyazat form1, string pAZ, string pTipus, string pNev, string pFin, string pTOszz, string pEOssz, string pPenznem, string pFIK, string pFIV, string pTudomany, string pSzvezeto, string pPenzvezeto)
        {
            InitializeComponent();
            textBoxPalyazatAzonosito.Text = pAZ;
            comboBoxPalyazatTipus.Text = pTipus;
            textBoxPalyazatNev.Text = pNev;
            comboBoxFinanszirozasTipus.Text = pFin;
            textBoxTervezettOsszeg.Text = pTOszz;
            textBoxElnyertOsszeg.Text = pEOssz;
            comboBoxPenznem.Text = pPenznem;
            textBoxFelhasznIdoKezd.Text = pFIK;
            textBoxFelhasznIdoVege.Text = pFIV;
            comboBoxTudomanyTerulet.Text = pTudomany;
            textBoxSzakmaiVezeto.Text = pSzvezeto;
            textBoxPenzugyiVezeto.Text = pPenzvezeto;
            szakmaiVezetoNev = pSzvezeto;
            penzugyiVezetoNev = pPenzvezeto;
            elnyertOsszegKezd = pEOssz;
            //az adatok ellenőrzése, hogy üresek-e a betöltés során
            if(szakmaiVezetoNev != string.Empty)
            {
                vaneSzakmaiVezeto = true;
            }
            if (penzugyiVezetoNev != string.Empty)
            {
                vanePenzugyiVezeto = true;
            }
            if(elnyertOsszegKezd != "0")
            {
                vaneElnyertOsszeg = true;
            }
        }
        void f_Closed(object sender, EventArgs e)
        {
            FormVezetok = null;
        }
        public void formModosit()
        {
            update();
            this.Close();
        }

        private void FormPalyazatModosit_Load(object sender, EventArgs e)
        {
            palyazatRepo.setVezeto(vezetoRepoSql.getVezetoFromDatabaseTable());
            palyazatRepo.setPalyazat(palyazatRepoSql.getPalyazatokFromDatabaseTable());
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
            errorProviderPalyazatTipus.SetError(comboBoxPalyazatTipus, "");
            errorProviderPalyazatNev.SetError(textBoxPalyazatNev, "");
            errorProviderFinanszirozasTipus.SetError(comboBoxFinanszirozasTipus, "");
            errorProviderTudomanyTerulet.SetError(comboBoxTudomanyTerulet, "");
            errorProviderSzakmaiVezeto.SetError(textBoxSzakmaiVezeto, "");
            errorProviderPenzugyiVezeto.SetError(textBoxPenzugyiVezeto, "");
            errorProviderElnyertOsszeg.SetError(textBoxElnyertOsszeg, "");
            errorProviderPenznem.SetError(comboBoxPenznem, "");
            errorProviderFelhasznIdoKezd.SetError(textBoxFelhasznIdoKezd, "");
            errorProviderFelhasznIdoVege.SetError(textBoxFelhasznIdoVege, "");
            bool vanHiba = false;
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
                    errorProviderTudomanyTerulet.SetError(comboBoxTudomanyTerulet, "Kötelező kitölteni!");
                    vanHiba = true;
                }
            }
            catch (Exception ex)
            {
                errorProviderTudomanyTerulet.SetError(comboBoxTudomanyTerulet, "Hibás adat!");
                vanHiba = true;
            }
            string szakmaiVezeto = "";
            try
            {
                szakmaiVezeto = Convert.ToString(textBoxSzakmaiVezeto.Text);

                if (szakmaiVezeto == string.Empty)
                {

                }
                else
                {
                    if (valdiationsRepo.IsValidName(szakmaiVezeto) == false)
                    {
                        errorProviderSzakmaiVezeto.SetError(textBoxSzakmaiVezeto, "A vezető neve nem megfelelő!");
                        vanHiba = true;
                    }
                }
            }
            catch (Exception ex)
            {
                errorProviderSzakmaiVezeto.SetError(textBoxSzakmaiVezeto, "Hibás adat!");
                vanHiba = true;
            }
            string penzugyiVezeto = "";
            try
            {
                penzugyiVezeto = Convert.ToString(textBoxPenzugyiVezeto.Text);
                if (penzugyiVezeto == string.Empty)
                {

                }
                else
                {
                    if (valdiationsRepo.IsValidName(penzugyiVezeto) == false)
                    {
                        errorProviderPenzugyiVezeto.SetError(textBoxPenzugyiVezeto, "A vezető neve nem megfelelő!");
                        vanHiba = true;
                    }
                }
            }
            catch (Exception ex)
            {
                errorProviderPenzugyiVezeto.SetError(textBoxPenzugyiVezeto, "Hibás adat!");
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
                    if (textBoxElnyertOsszeg.Text != string.Empty && Convert.ToInt32(textBoxElnyertOsszeg.Text) != 0)
                    {
                        if (valdiationsRepo.IsValidValue(elnyertOsszeg) == false)
                        {
                            errorProviderElnyertOsszeg.SetError(textBoxElnyertOsszeg, "Az összeg nem kezdődhet nullával!");
                            vanHiba = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorProviderElnyertOsszeg.SetError(textBoxElnyertOsszeg, "Hibás adat!");
                vanHiba = true;
            }
            string penznem = "";
            try
            {
                penznem = Convert.ToString(comboBoxPenznem.Text);
            }
            catch (Exception ex)
            {
                errorProviderPenznem.SetError(comboBoxPenznem, "Hibás adat!");
                vanHiba = true;
            }
            string felhasznalasiIdoKezd = "";
            try
            {
                felhasznalasiIdoKezd = Convert.ToString(textBoxFelhasznIdoKezd.Text);
                if(textBoxFelhasznIdoKezd.Text != string.Empty)
                {
                    if (valdiationsRepo.IsValidDate(felhasznalasiIdoKezd) == false)
                    {
                        errorProviderFelhasznIdoKezd.SetError(textBoxFelhasznIdoKezd, "A dátum formája nem megfelelő!");
                        vanHiba = true;
                    }
                }
            }
            catch (Exception ex)
            {
                errorProviderFelhasznIdoKezd.SetError(textBoxFelhasznIdoKezd, "Hibás adat!");
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
                        errorProviderFelhasznIdoVege.SetError(textBoxFelhasznIdoVege, "A dátum formája nem megfelelő!");
                        vanHiba = true;
                    }
                }
            }
            catch (Exception ex)
            {
                errorProviderFelhasznIdoVege.SetError(textBoxFelhasznIdoVege, "Hibás adat!");
                vanHiba = true;
            }
            if (!vanHiba)
            {
                    Palyazat modosult = new Palyazat(Azonosito,
                                                    comboBoxPalyazatTipus.Text,
                                                    textBoxPalyazatNev.Text,
                                                    comboBoxFinanszirozasTipus.Text,
                                                    Convert.ToSingle(textBoxTervezettOsszeg.Text),
                                                    Convert.ToSingle(textBoxElnyertOsszeg.Text),
                                                    comboBoxPenznem.Text,
                                                    textBoxFelhasznIdoKezd.Text,
                                                    textBoxFelhasznIdoVege.Text,
                                                    comboBoxTudomanyTerulet.Text,
                                                    textBoxSzakmaiVezeto.Text,
                                                    textBoxPenzugyiVezeto.Text
                                                    );
                    Azonosito = textBoxPalyazatAzonosito.Text;
                try { 
                    if (vaneSzakmaiVezeto == false)
                    {
                        if(szakmaiVezetoNev == szakmaiVezeto)
                        {

                        }
                        else
                        {
                            if (palyazatRepo.isVezetoInList(textBoxSzakmaiVezeto.Text) == true)
                            {
                                palyazatRepoSql.insertPosztokIntoDatabase(Azonosito, textBoxSzakmaiVezeto.Text, "Szakmai vezető");
                            }
                            else
                            {
                                errorProviderSzakmaiVezeto.SetError(textBoxSzakmaiVezeto, "A vezető nincs benne az adatbázisban!");
                                vanHiba = true;
                            }
                        }
                    }
                    else
                    {
                        if (szakmaiVezetoNev == textBoxSzakmaiVezeto.Text)
                        {
                        }
                        else
                        {
                            if (textBoxSzakmaiVezeto.Text == string.Empty)
                            {
                                vezetoRepoSql.deletePosztFromDatabase(textBoxPalyazatAzonosito.Text, "Szakmai vezető");
                            }
                            else
                            {
                                if (palyazatRepo.isVezetoInList(textBoxSzakmaiVezeto.Text) == true)
                                {
                                    vezetoRepoSql.updatePosztInDatabase(textBoxPalyazatAzonosito.Text, textBoxSzakmaiVezeto.Text, "Szakmai vezető");
                                }
                                else
                                {
                                    errorProviderSzakmaiVezeto.SetError(textBoxSzakmaiVezeto, "A vezető nincs benne az adatbázisban!");
                                    vanHiba = true;
                                }
                            }
                        }
                    }
                    if (vanePenzugyiVezeto == false)
                    {
                        if (penzugyiVezetoNev == penzugyiVezeto)
                        {

                        }
                        else
                        {
                            if (palyazatRepo.isVezetoInList(textBoxPenzugyiVezeto.Text) == true)
                            {
                                palyazatRepoSql.insertPosztokIntoDatabase(Azonosito, textBoxPenzugyiVezeto.Text, "Pénzügyi vezető");
                            }
                            else
                            {
                                errorProviderPenzugyiVezeto.SetError(textBoxPenzugyiVezeto, "A vezető nincs benne az adatbázisban!");
                                vanHiba = true;
                            }
                        }
                    }
                    else
                    {
                        if (penzugyiVezetoNev == textBoxPenzugyiVezeto.Text)
                        {

                        }
                        else
                        {
                            if (textBoxPenzugyiVezeto.Text == string.Empty)
                            {
                                vezetoRepoSql.deletePosztFromDatabase(textBoxPalyazatAzonosito.Text, "Pénzügyi vezető");
                            }
                            else
                            {
                                if (palyazatRepo.isVezetoInList(textBoxPenzugyiVezeto.Text) == true)
                                {
                                    vezetoRepoSql.updatePosztInDatabase(textBoxPalyazatAzonosito.Text, textBoxPenzugyiVezeto.Text, "Pénzügyi vezető");
                                }
                                else
                                {
                                    errorProviderSzakmaiVezeto.SetError(textBoxPenzugyiVezeto, "A vezető nincs benne az adatbázisban!");
                                    vanHiba = true;
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    vanHiba = true;
                }
                if (!vanHiba)
                {
                    palyazatRepo.updatePalyazatInList(Azonosito, modosult);
                    palyazatRepoSql.updatePalyazatInDatabase(Azonosito, modosult);
                    formModosit();
                }
            }
        }
        private void buttonMegsem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
