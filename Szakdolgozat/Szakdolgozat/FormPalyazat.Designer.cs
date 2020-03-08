namespace Szakdolgozat
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
            this.dataGridViewPalyazatok = new System.Windows.Forms.DataGridView();
            this.textBoxPalyazatAzonosito = new System.Windows.Forms.TextBox();
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
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPalyazatNev = new System.Windows.Forms.TextBox();
            this.textBoxElnyertOsszeg = new System.Windows.Forms.TextBox();
            this.textBoxTervezettOsszeg = new System.Windows.Forms.TextBox();
            this.textBoxFelhasznIdoKezd = new System.Windows.Forms.TextBox();
            this.textBoxTudomanyTerulet = new System.Windows.Forms.TextBox();
            this.textBoxPenznem = new System.Windows.Forms.TextBox();
            this.textBoxTenyfelhasznalasAZ = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPalyazatok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPalyazatok
            // 
            this.dataGridViewPalyazatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPalyazatok.Location = new System.Drawing.Point(13, 249);
            this.dataGridViewPalyazatok.Name = "dataGridViewPalyazatok";
            this.dataGridViewPalyazatok.Size = new System.Drawing.Size(1118, 361);
            this.dataGridViewPalyazatok.TabIndex = 0;
            // 
            // textBoxPalyazatAzonosito
            // 
            this.textBoxPalyazatAzonosito.Enabled = false;
            this.textBoxPalyazatAzonosito.Location = new System.Drawing.Point(211, 35);
            this.textBoxPalyazatAzonosito.Name = "textBoxPalyazatAzonosito";
            this.textBoxPalyazatAzonosito.Size = new System.Drawing.Size(121, 20);
            this.textBoxPalyazatAzonosito.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(62, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Azonosító kód:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(62, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pályázat típus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(62, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pályzat neve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(62, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Finanszírozás típusa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(457, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tervezett összeg:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(457, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Elnyert összeg:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(457, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pénznem:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(62, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tudomány terület:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(457, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Felhasználási idő kezdete:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(457, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Felhasználási idő vége:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(838, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tényfelhasználás azonosító:";
            // 
            // textBoxPalyazatNev
            // 
            this.textBoxPalyazatNev.Location = new System.Drawing.Point(211, 119);
            this.textBoxPalyazatNev.Name = "textBoxPalyazatNev";
            this.textBoxPalyazatNev.Size = new System.Drawing.Size(121, 20);
            this.textBoxPalyazatNev.TabIndex = 14;
            // 
            // textBoxElnyertOsszeg
            // 
            this.textBoxElnyertOsszeg.Location = new System.Drawing.Point(645, 76);
            this.textBoxElnyertOsszeg.Name = "textBoxElnyertOsszeg";
            this.textBoxElnyertOsszeg.Size = new System.Drawing.Size(121, 20);
            this.textBoxElnyertOsszeg.TabIndex = 17;
            // 
            // textBoxTervezettOsszeg
            // 
            this.textBoxTervezettOsszeg.Location = new System.Drawing.Point(645, 35);
            this.textBoxTervezettOsszeg.Name = "textBoxTervezettOsszeg";
            this.textBoxTervezettOsszeg.Size = new System.Drawing.Size(121, 20);
            this.textBoxTervezettOsszeg.TabIndex = 16;
            // 
            // textBoxFelhasznIdoKezd
            // 
            this.textBoxFelhasznIdoKezd.Location = new System.Drawing.Point(645, 162);
            this.textBoxFelhasznIdoKezd.Name = "textBoxFelhasznIdoKezd";
            this.textBoxFelhasznIdoKezd.Size = new System.Drawing.Size(121, 20);
            this.textBoxFelhasznIdoKezd.TabIndex = 20;
            // 
            // textBoxTudomanyTerulet
            // 
            this.textBoxTudomanyTerulet.Location = new System.Drawing.Point(211, 201);
            this.textBoxTudomanyTerulet.Name = "textBoxTudomanyTerulet";
            this.textBoxTudomanyTerulet.Size = new System.Drawing.Size(121, 20);
            this.textBoxTudomanyTerulet.TabIndex = 19;
            // 
            // textBoxPenznem
            // 
            this.textBoxPenznem.Location = new System.Drawing.Point(645, 116);
            this.textBoxPenznem.Name = "textBoxPenznem";
            this.textBoxPenznem.Size = new System.Drawing.Size(121, 20);
            this.textBoxPenznem.TabIndex = 18;
            // 
            // textBoxTenyfelhasznalasAZ
            // 
            this.textBoxTenyfelhasznalasAZ.Enabled = false;
            this.textBoxTenyfelhasznalasAZ.Location = new System.Drawing.Point(1032, 35);
            this.textBoxTenyfelhasznalasAZ.Name = "textBoxTenyfelhasznalasAZ";
            this.textBoxTenyfelhasznalasAZ.Size = new System.Drawing.Size(99, 20);
            this.textBoxTenyfelhasznalasAZ.TabIndex = 22;
            // 
            // textBoxFelhasznIdoVege
            // 
            this.textBoxFelhasznIdoVege.Location = new System.Drawing.Point(646, 201);
            this.textBoxFelhasznIdoVege.Name = "textBoxFelhasznIdoVege";
            this.textBoxFelhasznIdoVege.Size = new System.Drawing.Size(120, 20);
            this.textBoxFelhasznIdoVege.TabIndex = 21;
            // 
            // comboBoxPalyazatTipus
            // 
            this.comboBoxPalyazatTipus.FormattingEnabled = true;
            this.comboBoxPalyazatTipus.Location = new System.Drawing.Point(211, 77);
            this.comboBoxPalyazatTipus.Name = "comboBoxPalyazatTipus";
            this.comboBoxPalyazatTipus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPalyazatTipus.TabIndex = 23;
            // 
            // comboBoxKeresesTipus
            // 
            this.comboBoxKeresesTipus.FormattingEnabled = true;
            this.comboBoxKeresesTipus.Location = new System.Drawing.Point(841, 159);
            this.comboBoxKeresesTipus.Name = "comboBoxKeresesTipus";
            this.comboBoxKeresesTipus.Size = new System.Drawing.Size(185, 21);
            this.comboBoxKeresesTipus.TabIndex = 24;
            // 
            // buttonPalyazatKereses
            // 
            this.buttonPalyazatKereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonPalyazatKereses.Location = new System.Drawing.Point(1049, 156);
            this.buttonPalyazatKereses.Name = "buttonPalyazatKereses";
            this.buttonPalyazatKereses.Size = new System.Drawing.Size(82, 23);
            this.buttonPalyazatKereses.TabIndex = 25;
            this.buttonPalyazatKereses.Text = "Keresés";
            this.buttonPalyazatKereses.UseVisualStyleBackColor = true;
            // 
            // textBoxKeresesSzoveg
            // 
            this.textBoxKeresesSzoveg.Location = new System.Drawing.Point(841, 204);
            this.textBoxKeresesSzoveg.Name = "textBoxKeresesSzoveg";
            this.textBoxKeresesSzoveg.Size = new System.Drawing.Size(290, 20);
            this.textBoxKeresesSzoveg.TabIndex = 26;
            // 
            // comboBoxFinanszirozasTipus
            // 
            this.comboBoxFinanszirozasTipus.FormattingEnabled = true;
            this.comboBoxFinanszirozasTipus.Location = new System.Drawing.Point(211, 159);
            this.comboBoxFinanszirozasTipus.Name = "comboBoxFinanszirozasTipus";
            this.comboBoxFinanszirozasTipus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFinanszirozasTipus.TabIndex = 27;
            // 
            // buttonKoltsegTerv
            // 
            this.buttonKoltsegTerv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonKoltsegTerv.Location = new System.Drawing.Point(841, 72);
            this.buttonKoltsegTerv.Name = "buttonKoltsegTerv";
            this.buttonKoltsegTerv.Size = new System.Drawing.Size(131, 23);
            this.buttonKoltsegTerv.TabIndex = 28;
            this.buttonKoltsegTerv.Text = "Költség terv";
            this.buttonKoltsegTerv.UseVisualStyleBackColor = true;
            // 
            // buttonTenyfelhasznalas
            // 
            this.buttonTenyfelhasznalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonTenyfelhasznalas.Location = new System.Drawing.Point(999, 71);
            this.buttonTenyfelhasznalas.Name = "buttonTenyfelhasznalas";
            this.buttonTenyfelhasznalas.Size = new System.Drawing.Size(132, 23);
            this.buttonTenyfelhasznalas.TabIndex = 29;
            this.buttonTenyfelhasznalas.Text = "Tényfelhasználás";
            this.buttonTenyfelhasznalas.UseVisualStyleBackColor = true;
            // 
            // buttonPalyazatUjPalyazatForm
            // 
            this.buttonPalyazatUjPalyazatForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonPalyazatUjPalyazatForm.Location = new System.Drawing.Point(841, 115);
            this.buttonPalyazatUjPalyazatForm.Name = "buttonPalyazatUjPalyazatForm";
            this.buttonPalyazatUjPalyazatForm.Size = new System.Drawing.Size(82, 23);
            this.buttonPalyazatUjPalyazatForm.TabIndex = 30;
            this.buttonPalyazatUjPalyazatForm.Text = "Új pályázat";
            this.buttonPalyazatUjPalyazatForm.UseVisualStyleBackColor = true;
            // 
            // buttonPalyazatTorol
            // 
            this.buttonPalyazatTorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonPalyazatTorol.Location = new System.Drawing.Point(1049, 116);
            this.buttonPalyazatTorol.Name = "buttonPalyazatTorol";
            this.buttonPalyazatTorol.Size = new System.Drawing.Size(82, 23);
            this.buttonPalyazatTorol.TabIndex = 31;
            this.buttonPalyazatTorol.Text = "Töröl";
            this.buttonPalyazatTorol.UseVisualStyleBackColor = true;
            // 
            // buttonPalyazatModositForm
            // 
            this.buttonPalyazatModositForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonPalyazatModositForm.Location = new System.Drawing.Point(944, 116);
            this.buttonPalyazatModositForm.Name = "buttonPalyazatModositForm";
            this.buttonPalyazatModositForm.Size = new System.Drawing.Size(82, 23);
            this.buttonPalyazatModositForm.TabIndex = 32;
            this.buttonPalyazatModositForm.Text = "Módosít";
            this.buttonPalyazatModositForm.UseVisualStyleBackColor = true;
            // 
            // FormPalyazat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 622);
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
            this.Controls.Add(this.textBoxTenyfelhasznalasAZ);
            this.Controls.Add(this.textBoxFelhasznIdoVege);
            this.Controls.Add(this.textBoxFelhasznIdoKezd);
            this.Controls.Add(this.textBoxTudomanyTerulet);
            this.Controls.Add(this.textBoxPenznem);
            this.Controls.Add(this.textBoxElnyertOsszeg);
            this.Controls.Add(this.textBoxTervezettOsszeg);
            this.Controls.Add(this.textBoxPalyazatNev);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPalyazatAzonosito);
            this.Controls.Add(this.dataGridViewPalyazatok);
            this.Name = "FormPalyazat";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPalyazatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPalyazatok;
        private System.Windows.Forms.TextBox textBoxPalyazatAzonosito;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPalyazatNev;
        private System.Windows.Forms.TextBox textBoxElnyertOsszeg;
        private System.Windows.Forms.TextBox textBoxTervezettOsszeg;
        private System.Windows.Forms.TextBox textBoxFelhasznIdoKezd;
        private System.Windows.Forms.TextBox textBoxTudomanyTerulet;
        private System.Windows.Forms.TextBox textBoxPenznem;
        private System.Windows.Forms.TextBox textBoxTenyfelhasznalasAZ;
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
    }
}

