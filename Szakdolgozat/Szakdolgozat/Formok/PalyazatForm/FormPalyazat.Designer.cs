﻿namespace Szakdolgozat
{
    partial class FormPalyazat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewPalyazatok = new System.Windows.Forms.DataGridView();
            this.textBoxAzonosito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPalyazatNev = new System.Windows.Forms.TextBox();
            this.textBoxElnyertOsszeg = new System.Windows.Forms.TextBox();
            this.textBoxTervezettOsszeg = new System.Windows.Forms.TextBox();
            this.textBoxFelhasznIdoKezd = new System.Windows.Forms.TextBox();
            this.textBoxFelhasznIdoVege = new System.Windows.Forms.TextBox();
            this.comboBoxPalyazatTipus = new System.Windows.Forms.ComboBox();
            this.comboBoxKeresesTipus = new System.Windows.Forms.ComboBox();
            this.buttonPalyazatKereses = new System.Windows.Forms.Button();
            this.textBoxKeresesSzoveg = new System.Windows.Forms.TextBox();
            this.comboBoxFinanszirozasTipus = new System.Windows.Forms.ComboBox();
            this.buttonKoltsegTerv = new System.Windows.Forms.Button();
            this.buttonTenyfelhasznalas = new System.Windows.Forms.Button();
            this.buttonPalyazatUjPalyazatForm = new System.Windows.Forms.Button();
            this.buttonPalyazatTorol = new System.Windows.Forms.Button();
            this.buttonPalyazatModositForm = new System.Windows.Forms.Button();
            this.comboBoxTudomanyterulet = new System.Windows.Forms.ComboBox();
            this.comboBoxPenznem = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPenzugyiVezeto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSzakmaiVezeto = new System.Windows.Forms.TextBox();
            this.buttonDataTableFrissit = new System.Windows.Forms.Button();
            this.buttonVezetok = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adatabazisTorolEsKilépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProviderKeresesSzoveg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderKeresesTipus = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPalyazatok)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKeresesSzoveg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKeresesTipus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPalyazatok
            // 
            this.dataGridViewPalyazatok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPalyazatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPalyazatok.Location = new System.Drawing.Point(12, 228);
            this.dataGridViewPalyazatok.Name = "dataGridViewPalyazatok";
            this.dataGridViewPalyazatok.Size = new System.Drawing.Size(1405, 361);
            this.dataGridViewPalyazatok.TabIndex = 0;
            // 
            // textBoxAzonosito
            // 
            this.textBoxAzonosito.Enabled = false;
            this.textBoxAzonosito.Location = new System.Drawing.Point(233, 35);
            this.textBoxAzonosito.Name = "textBoxAzonosito";
            this.textBoxAzonosito.Size = new System.Drawing.Size(121, 20);
            this.textBoxAzonosito.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Azonosító kód:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(62, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pályázat típus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(62, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pályázat neve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(62, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Finanszírozás típusa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(457, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tervezett összeg:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(457, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Elnyert összeg:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(457, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pénznem:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(62, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tudomány terület:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(457, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Felhasználási idő kezdete:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(457, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Felhasználási idő vége:";
            // 
            // textBoxPalyazatNev
            // 
            this.textBoxPalyazatNev.Enabled = false;
            this.textBoxPalyazatNev.Location = new System.Drawing.Point(233, 119);
            this.textBoxPalyazatNev.Name = "textBoxPalyazatNev";
            this.textBoxPalyazatNev.Size = new System.Drawing.Size(121, 20);
            this.textBoxPalyazatNev.TabIndex = 14;
            // 
            // textBoxElnyertOsszeg
            // 
            this.textBoxElnyertOsszeg.Enabled = false;
            this.textBoxElnyertOsszeg.Location = new System.Drawing.Point(664, 76);
            this.textBoxElnyertOsszeg.Name = "textBoxElnyertOsszeg";
            this.textBoxElnyertOsszeg.Size = new System.Drawing.Size(121, 20);
            this.textBoxElnyertOsszeg.TabIndex = 17;
            // 
            // textBoxTervezettOsszeg
            // 
            this.textBoxTervezettOsszeg.Enabled = false;
            this.textBoxTervezettOsszeg.Location = new System.Drawing.Point(664, 35);
            this.textBoxTervezettOsszeg.Name = "textBoxTervezettOsszeg";
            this.textBoxTervezettOsszeg.Size = new System.Drawing.Size(121, 20);
            this.textBoxTervezettOsszeg.TabIndex = 16;
            // 
            // textBoxFelhasznIdoKezd
            // 
            this.textBoxFelhasznIdoKezd.Enabled = false;
            this.textBoxFelhasznIdoKezd.Location = new System.Drawing.Point(664, 162);
            this.textBoxFelhasznIdoKezd.Name = "textBoxFelhasznIdoKezd";
            this.textBoxFelhasznIdoKezd.Size = new System.Drawing.Size(121, 20);
            this.textBoxFelhasznIdoKezd.TabIndex = 20;
            // 
            // textBoxFelhasznIdoVege
            // 
            this.textBoxFelhasznIdoVege.Enabled = false;
            this.textBoxFelhasznIdoVege.Location = new System.Drawing.Point(665, 201);
            this.textBoxFelhasznIdoVege.Name = "textBoxFelhasznIdoVege";
            this.textBoxFelhasznIdoVege.Size = new System.Drawing.Size(120, 20);
            this.textBoxFelhasznIdoVege.TabIndex = 21;
            // 
            // comboBoxPalyazatTipus
            // 
            this.comboBoxPalyazatTipus.Enabled = false;
            this.comboBoxPalyazatTipus.FormattingEnabled = true;
            this.comboBoxPalyazatTipus.Items.AddRange(new object[] {
            "Minisztériumi",
            "NTKA",
            "NKFIH",
            "NKA",
            "EFOP",
            "GINOP"});
            this.comboBoxPalyazatTipus.Location = new System.Drawing.Point(233, 77);
            this.comboBoxPalyazatTipus.Name = "comboBoxPalyazatTipus";
            this.comboBoxPalyazatTipus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPalyazatTipus.TabIndex = 23;
            // 
            // comboBoxKeresesTipus
            // 
            this.comboBoxKeresesTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeresesTipus.FormattingEnabled = true;
            this.comboBoxKeresesTipus.Items.AddRange(new object[] {
            "Minden pályázat",
            "Azonosító",
            "Pályázat típus",
            "Pályázat neve",
            "Finanszírozás típusa",
            "Tudományterület",
            "Tervezett összeg",
            "Elnyert összeg",
            "Pénznem"});
            this.comboBoxKeresesTipus.Location = new System.Drawing.Point(839, 146);
            this.comboBoxKeresesTipus.Name = "comboBoxKeresesTipus";
            this.comboBoxKeresesTipus.Size = new System.Drawing.Size(185, 21);
            this.comboBoxKeresesTipus.TabIndex = 24;
            this.comboBoxKeresesTipus.SelectedIndexChanged += new System.EventHandler(this.comboBoxKeresesTipus_SelectedIndexChanged);
            // 
            // buttonPalyazatKereses
            // 
            this.buttonPalyazatKereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonPalyazatKereses.Location = new System.Drawing.Point(1047, 146);
            this.buttonPalyazatKereses.Name = "buttonPalyazatKereses";
            this.buttonPalyazatKereses.Size = new System.Drawing.Size(82, 23);
            this.buttonPalyazatKereses.TabIndex = 25;
            this.buttonPalyazatKereses.Text = "Keresés";
            this.buttonPalyazatKereses.UseVisualStyleBackColor = true;
            this.buttonPalyazatKereses.Click += new System.EventHandler(this.buttonPalyazatKereses_Click);
            // 
            // textBoxKeresesSzoveg
            // 
            this.textBoxKeresesSzoveg.Location = new System.Drawing.Point(839, 190);
            this.textBoxKeresesSzoveg.Name = "textBoxKeresesSzoveg";
            this.textBoxKeresesSzoveg.Size = new System.Drawing.Size(290, 20);
            this.textBoxKeresesSzoveg.TabIndex = 26;
            // 
            // comboBoxFinanszirozasTipus
            // 
            this.comboBoxFinanszirozasTipus.Enabled = false;
            this.comboBoxFinanszirozasTipus.FormattingEnabled = true;
            this.comboBoxFinanszirozasTipus.Items.AddRange(new object[] {
            "Előfinanszírozott",
            "Utófinanszírozott"});
            this.comboBoxFinanszirozasTipus.Location = new System.Drawing.Point(233, 159);
            this.comboBoxFinanszirozasTipus.Name = "comboBoxFinanszirozasTipus";
            this.comboBoxFinanszirozasTipus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFinanszirozasTipus.TabIndex = 27;
            // 
            // buttonKoltsegTerv
            // 
            this.buttonKoltsegTerv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonKoltsegTerv.Location = new System.Drawing.Point(1162, 146);
            this.buttonKoltsegTerv.Name = "buttonKoltsegTerv";
            this.buttonKoltsegTerv.Size = new System.Drawing.Size(254, 24);
            this.buttonKoltsegTerv.TabIndex = 28;
            this.buttonKoltsegTerv.Text = "Pályázat költségtervének lékérése";
            this.buttonKoltsegTerv.UseVisualStyleBackColor = true;
            this.buttonKoltsegTerv.Click += new System.EventHandler(this.buttonKoltsegTerv_Click);
            // 
            // buttonTenyfelhasznalas
            // 
            this.buttonTenyfelhasznalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonTenyfelhasznalas.Location = new System.Drawing.Point(1162, 186);
            this.buttonTenyfelhasznalas.Name = "buttonTenyfelhasznalas";
            this.buttonTenyfelhasznalas.Size = new System.Drawing.Size(254, 24);
            this.buttonTenyfelhasznalas.TabIndex = 29;
            this.buttonTenyfelhasznalas.Text = "Pályázat tényfelhasználásának lekérése";
            this.buttonTenyfelhasznalas.UseVisualStyleBackColor = true;
            this.buttonTenyfelhasznalas.Click += new System.EventHandler(this.buttonTenyfelhasznalas_Click);
            // 
            // buttonPalyazatUjPalyazatForm
            // 
            this.buttonPalyazatUjPalyazatForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonPalyazatUjPalyazatForm.Location = new System.Drawing.Point(1195, 31);
            this.buttonPalyazatUjPalyazatForm.Name = "buttonPalyazatUjPalyazatForm";
            this.buttonPalyazatUjPalyazatForm.Size = new System.Drawing.Size(103, 23);
            this.buttonPalyazatUjPalyazatForm.TabIndex = 30;
            this.buttonPalyazatUjPalyazatForm.Text = "Új pályázat";
            this.buttonPalyazatUjPalyazatForm.UseVisualStyleBackColor = true;
            this.buttonPalyazatUjPalyazatForm.Click += new System.EventHandler(this.buttonPalyazatUjPalyazatForm_Click);
            // 
            // buttonPalyazatTorol
            // 
            this.buttonPalyazatTorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonPalyazatTorol.Location = new System.Drawing.Point(1195, 71);
            this.buttonPalyazatTorol.Name = "buttonPalyazatTorol";
            this.buttonPalyazatTorol.Size = new System.Drawing.Size(103, 23);
            this.buttonPalyazatTorol.TabIndex = 31;
            this.buttonPalyazatTorol.Text = "Töröl";
            this.buttonPalyazatTorol.UseVisualStyleBackColor = true;
            this.buttonPalyazatTorol.Click += new System.EventHandler(this.buttonPalyazatTorol_Click);
            // 
            // buttonPalyazatModositForm
            // 
            this.buttonPalyazatModositForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonPalyazatModositForm.Location = new System.Drawing.Point(1313, 31);
            this.buttonPalyazatModositForm.Name = "buttonPalyazatModositForm";
            this.buttonPalyazatModositForm.Size = new System.Drawing.Size(103, 23);
            this.buttonPalyazatModositForm.TabIndex = 32;
            this.buttonPalyazatModositForm.Text = "Módosít";
            this.buttonPalyazatModositForm.UseVisualStyleBackColor = true;
            this.buttonPalyazatModositForm.Click += new System.EventHandler(this.buttonPalyazatModositForm_Click);
            // 
            // comboBoxTudomanyterulet
            // 
            this.comboBoxTudomanyterulet.Enabled = false;
            this.comboBoxTudomanyterulet.FormattingEnabled = true;
            this.comboBoxTudomanyterulet.Items.AddRange(new object[] {
            "Műszaki",
            "Társadalom tudomány",
            "Természet tudomány",
            "Informatika"});
            this.comboBoxTudomanyterulet.Location = new System.Drawing.Point(233, 201);
            this.comboBoxTudomanyterulet.Name = "comboBoxTudomanyterulet";
            this.comboBoxTudomanyterulet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTudomanyterulet.TabIndex = 33;
            // 
            // comboBoxPenznem
            // 
            this.comboBoxPenznem.Enabled = false;
            this.comboBoxPenznem.FormattingEnabled = true;
            this.comboBoxPenznem.Items.AddRange(new object[] {
            "Forint",
            "Euro",
            "Dollár"});
            this.comboBoxPenznem.Location = new System.Drawing.Point(664, 119);
            this.comboBoxPenznem.Name = "comboBoxPenznem";
            this.comboBoxPenznem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPenznem.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(837, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Pénzügyi vezető:";
            // 
            // textBoxPenzugyiVezeto
            // 
            this.textBoxPenzugyiVezeto.Enabled = false;
            this.textBoxPenzugyiVezeto.Location = new System.Drawing.Point(995, 90);
            this.textBoxPenzugyiVezeto.Name = "textBoxPenzugyiVezeto";
            this.textBoxPenzugyiVezeto.Size = new System.Drawing.Size(172, 20);
            this.textBoxPenzugyiVezeto.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(837, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Szakmai vezető:";
            // 
            // textBoxSzakmaiVezeto
            // 
            this.textBoxSzakmaiVezeto.Enabled = false;
            this.textBoxSzakmaiVezeto.Location = new System.Drawing.Point(995, 35);
            this.textBoxSzakmaiVezeto.Name = "textBoxSzakmaiVezeto";
            this.textBoxSzakmaiVezeto.Size = new System.Drawing.Size(172, 20);
            this.textBoxSzakmaiVezeto.TabIndex = 38;
            // 
            // buttonDataTableFrissit
            // 
            this.buttonDataTableFrissit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonDataTableFrissit.Location = new System.Drawing.Point(1313, 71);
            this.buttonDataTableFrissit.Name = "buttonDataTableFrissit";
            this.buttonDataTableFrissit.Size = new System.Drawing.Size(103, 23);
            this.buttonDataTableFrissit.TabIndex = 39;
            this.buttonDataTableFrissit.Text = "Frissít";
            this.buttonDataTableFrissit.UseVisualStyleBackColor = true;
            this.buttonDataTableFrissit.Click += new System.EventHandler(this.buttonDataTableFrissit_Click);
            // 
            // buttonVezetok
            // 
            this.buttonVezetok.Location = new System.Drawing.Point(1244, 113);
            this.buttonVezetok.Name = "buttonVezetok";
            this.buttonVezetok.Size = new System.Drawing.Size(121, 23);
            this.buttonVezetok.TabIndex = 106;
            this.buttonVezetok.Text = "Vezetők kezelése";
            this.buttonVezetok.UseVisualStyleBackColor = true;
            this.buttonVezetok.Click += new System.EventHandler(this.buttonVezetok_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adatabazisTorolEsKilépToolStripMenuItem,
            this.kilépToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1438, 28);
            this.menuStrip1.TabIndex = 107;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adatabazisTorolEsKilépToolStripMenuItem
            // 
            this.adatabazisTorolEsKilépToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.adatabazisTorolEsKilépToolStripMenuItem.Name = "adatabazisTorolEsKilépToolStripMenuItem";
            this.adatabazisTorolEsKilépToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.adatabazisTorolEsKilépToolStripMenuItem.Text = "Adatbázis törlése és kilépés";
            this.adatabazisTorolEsKilépToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.adatabazisTorolEsKilépToolStripMenuItem.Click += new System.EventHandler(this.adatabazisTorolEsKilépToolStripMenuItem_Click);
            // 
            // kilépToolStripMenuItem
            // 
            this.kilépToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.kilépToolStripMenuItem.Name = "kilépToolStripMenuItem";
            this.kilépToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.kilépToolStripMenuItem.Text = "Kilép";
            this.kilépToolStripMenuItem.Click += new System.EventHandler(this.kilépToolStripMenuItem_Click);
            // 
            // errorProviderKeresesSzoveg
            // 
            this.errorProviderKeresesSzoveg.ContainerControl = this;
            // 
            // errorProviderKeresesTipus
            // 
            this.errorProviderKeresesTipus.ContainerControl = this;
            // 
            // FormPalyazat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1438, 622);
            this.Controls.Add(this.buttonVezetok);
            this.Controls.Add(this.buttonDataTableFrissit);
            this.Controls.Add(this.textBoxSzakmaiVezeto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxPenzugyiVezeto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxPenznem);
            this.Controls.Add(this.comboBoxTudomanyterulet);
            this.Controls.Add(this.buttonPalyazatModositForm);
            this.Controls.Add(this.buttonPalyazatTorol);
            this.Controls.Add(this.buttonPalyazatUjPalyazatForm);
            this.Controls.Add(this.buttonTenyfelhasznalas);
            this.Controls.Add(this.buttonKoltsegTerv);
            this.Controls.Add(this.comboBoxFinanszirozasTipus);
            this.Controls.Add(this.textBoxKeresesSzoveg);
            this.Controls.Add(this.buttonPalyazatKereses);
            this.Controls.Add(this.comboBoxKeresesTipus);
            this.Controls.Add(this.comboBoxPalyazatTipus);
            this.Controls.Add(this.textBoxFelhasznIdoVege);
            this.Controls.Add(this.textBoxFelhasznIdoKezd);
            this.Controls.Add(this.textBoxElnyertOsszeg);
            this.Controls.Add(this.textBoxTervezettOsszeg);
            this.Controls.Add(this.textBoxPalyazatNev);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAzonosito);
            this.Controls.Add(this.dataGridViewPalyazatok);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPalyazat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pályázatok";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPalyazat_FormClosed);
            this.Load += new System.EventHandler(this.FormPalyazat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPalyazatok)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKeresesSzoveg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKeresesTipus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPalyazatok;
        private System.Windows.Forms.TextBox textBoxAzonosito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPalyazatNev;
        private System.Windows.Forms.TextBox textBoxElnyertOsszeg;
        private System.Windows.Forms.TextBox textBoxTervezettOsszeg;
        private System.Windows.Forms.TextBox textBoxFelhasznIdoKezd;
        private System.Windows.Forms.TextBox textBoxFelhasznIdoVege;
        private System.Windows.Forms.ComboBox comboBoxPalyazatTipus;
        private System.Windows.Forms.ComboBox comboBoxKeresesTipus;
        private System.Windows.Forms.Button buttonPalyazatKereses;
        private System.Windows.Forms.TextBox textBoxKeresesSzoveg;
        private System.Windows.Forms.ComboBox comboBoxFinanszirozasTipus;
        private System.Windows.Forms.Button buttonKoltsegTerv;
        private System.Windows.Forms.Button buttonTenyfelhasznalas;
        private System.Windows.Forms.Button buttonPalyazatUjPalyazatForm;
        private System.Windows.Forms.Button buttonPalyazatTorol;
        private System.Windows.Forms.Button buttonPalyazatModositForm;
        private System.Windows.Forms.ComboBox comboBoxTudomanyterulet;
        private System.Windows.Forms.ComboBox comboBoxPenznem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPenzugyiVezeto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSzakmaiVezeto;
        private System.Windows.Forms.Button buttonDataTableFrissit;
        private System.Windows.Forms.Button buttonVezetok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adatabazisTorolEsKilépToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProviderKeresesSzoveg;
        private System.Windows.Forms.ErrorProvider errorProviderKeresesTipus;
        private System.Windows.Forms.ToolStripMenuItem kilépToolStripMenuItem;
    }
}

