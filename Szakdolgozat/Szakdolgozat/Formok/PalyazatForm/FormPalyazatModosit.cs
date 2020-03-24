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
        string szakmaiVezetoNev = "";
        string penzugyiVezetoNev = "";
        private Tarolo palyazatRepo = new Tarolo();
        RepositoryDatabaseTablePalyazatSQL palyazatRepoSql = new RepositoryDatabaseTablePalyazatSQL();
        RepositoryDatabaseTableVezetoSQL vezetoRepoSql = new RepositoryDatabaseTableVezetoSQL();
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
            if(szakmaiVezetoNev != string.Empty)
            {
                vaneSzakmaiVezeto = true;
            }
            if (penzugyiVezetoNev != string.Empty)
            {
                vanePenzugyiVezeto = true;
            }
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
                    errorProviderPalyazatTipus.SetError(comboBoxPalyazatTipus, "Hibás adat!");
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
                    errorProviderPalyazatNev.SetError(textBoxPalyazatNev, "Hibás adat!");
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
                    errorProviderFinanszirozasTipus.SetError(comboBoxFinanszirozasTipus, "Hibás adat!");
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
                    errorProviderTudomanyTerulet.SetError(comboBoxTudomanyTerulet, "Hibás adat!");
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
                                                Convert.ToInt32(textBoxTervezettOsszeg.Text),
                                                Convert.ToInt32(textBoxElnyertOsszeg.Text),
                                                comboBoxPenznem.Text,
                                                textBoxFelhasznIdoKezd.Text,
                                                textBoxFelhasznIdoVege.Text,
                                                comboBoxTudomanyTerulet.Text,
                                                textBoxSzakmaiVezeto.Text,
                                                textBoxPenzugyiVezeto.Text
                                                );
                Azonosito = textBoxPalyazatAzonosito.Text;
                if (vaneSzakmaiVezeto == false)
                {
                        if (palyazatRepo.isVezetoInList(textBoxSzakmaiVezeto.Text) == true)
                        {
                            palyazatRepoSql.insertPosztokIntoDatabase(Azonosito, textBoxSzakmaiVezeto.Text, "Szakmai vezető");
                        }
                        else
                        {
                        errorProviderSzakmaiVezeto.SetError(textBoxSzakmaiVezeto, "Hiba!");
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
                                errorProviderSzakmaiVezeto.SetError(textBoxSzakmaiVezeto, "Hibás adat!");
                            }
                        }
                    }
                }
                if (vanePenzugyiVezeto == false)
                {
                    if (palyazatRepo.isVezetoInList(textBoxPenzugyiVezeto.Text) == true)
                    {
                        palyazatRepoSql.insertPosztokIntoDatabase(Azonosito, textBoxPenzugyiVezeto.Text, "Pénzügyi vezető");
                    }
                    else
                    {
                        errorProviderPenzugyiVezeto.SetError(textBoxPenzugyiVezeto, "Hibás adat!");
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
                                errorProviderSzakmaiVezeto.SetError(textBoxPenzugyiVezeto, "Hibás adat!");
                            }
                        }
                    }
                }
                //Nem működik rendesen, mert minden if else ágon végigjut és az errorokat nem jelzi
                palyazatRepo.updatePalyazatInList(Azonosito, modosult);
                palyazatRepoSql.updatePalyazatInDatabase(Azonosito, modosult);
                formModosit();
            }
        }

        private void buttonMegsem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
