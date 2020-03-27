namespace Szakdolgozat
{
    partial class FormPalyazatUjHozzaad
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
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonMegsem = new System.Windows.Forms.Button();
            this.textBoxFelhasznIdoVege = new System.Windows.Forms.TextBox();
            this.textBoxFelhasznIdoKezd = new System.Windows.Forms.TextBox();
            this.textBoxElnyertOsszeg = new System.Windows.Forms.TextBox();
            this.textBoxPalyazatNev = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSzakmaiVezeto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxPenzugyiVezeto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxPalyazatTipus = new System.Windows.Forms.ComboBox();
            this.comboBoxFinanszirozasTipus = new System.Windows.Forms.ComboBox();
            this.comboBoxTudomanyTerulet = new System.Windows.Forms.ComboBox();
            this.comboBoxPenznem = new System.Windows.Forms.ComboBox();
            this.errorProviderPalyazatTipus = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPalyazatNev = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFinanszirozasTipus = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPalyazatTudomanyterulet = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPalyazatSzakmaiVezeto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPalyazatPenzugyiVezeto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPalyazatElnyertOsszeg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPalyazatPenznem = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPalyazatFelhasznIdoKezd = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPalyazatFelhasznIdoVege = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonFormVezetok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatTipus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatNev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFinanszirozasTipus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatTudomanyterulet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatSzakmaiVezeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatPenzugyiVezeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatElnyertOsszeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatPenznem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatFelhasznIdoKezd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatFelhasznIdoVege)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(427, 239);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(121, 23);
            this.buttonMentes.TabIndex = 10;
            this.buttonMentes.Text = "Létrehoz";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // buttonMegsem
            // 
            this.buttonMegsem.Location = new System.Drawing.Point(598, 240);
            this.buttonMegsem.Name = "buttonMegsem";
            this.buttonMegsem.Size = new System.Drawing.Size(121, 23);
            this.buttonMegsem.TabIndex = 11;
            this.buttonMegsem.Text = "Mégsem";
            this.buttonMegsem.UseVisualStyleBackColor = true;
            this.buttonMegsem.Click += new System.EventHandler(this.buttonMegsem_Click);
            // 
            // textBoxFelhasznIdoVege
            // 
            this.textBoxFelhasznIdoVege.Location = new System.Drawing.Point(600, 191);
            this.textBoxFelhasznIdoVege.Name = "textBoxFelhasznIdoVege";
            this.textBoxFelhasznIdoVege.Size = new System.Drawing.Size(122, 20);
            this.textBoxFelhasznIdoVege.TabIndex = 9;
            this.textBoxFelhasznIdoVege.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFelhasznIdoVege_KeyPress);
            // 
            // textBoxFelhasznIdoKezd
            // 
            this.textBoxFelhasznIdoKezd.Location = new System.Drawing.Point(600, 150);
            this.textBoxFelhasznIdoKezd.Name = "textBoxFelhasznIdoKezd";
            this.textBoxFelhasznIdoKezd.Size = new System.Drawing.Size(121, 20);
            this.textBoxFelhasznIdoKezd.TabIndex = 8;
            this.textBoxFelhasznIdoKezd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFelhasznIdoKezd_KeyPress);
            // 
            // textBoxElnyertOsszeg
            // 
            this.textBoxElnyertOsszeg.Location = new System.Drawing.Point(600, 66);
            this.textBoxElnyertOsszeg.Name = "textBoxElnyertOsszeg";
            this.textBoxElnyertOsszeg.Size = new System.Drawing.Size(121, 20);
            this.textBoxElnyertOsszeg.TabIndex = 6;
            this.textBoxElnyertOsszeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxElnyertOsszeg_KeyPress);
            // 
            // textBoxPalyazatNev
            // 
            this.textBoxPalyazatNev.Location = new System.Drawing.Point(219, 66);
            this.textBoxPalyazatNev.Name = "textBoxPalyazatNev";
            this.textBoxPalyazatNev.Size = new System.Drawing.Size(121, 20);
            this.textBoxPalyazatNev.TabIndex = 1;
            this.textBoxPalyazatNev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPalyazatNev_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(25, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 87;
            this.label8.Text = "Tudomány terület:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(411, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 17);
            this.label9.TabIndex = 86;
            this.label9.Text = "Felhasználási idő kezdete:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(411, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 17);
            this.label10.TabIndex = 85;
            this.label10.Text = "Felhasználási idő vége:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(411, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 84;
            this.label7.Text = "Pénznem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(411, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "Elnyert összeg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(25, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Finanszírozás típusa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(25, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Pályzat neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "Pályázat típus:";
            // 
            // textBoxSzakmaiVezeto
            // 
            this.textBoxSzakmaiVezeto.Location = new System.Drawing.Point(219, 193);
            this.textBoxSzakmaiVezeto.Name = "textBoxSzakmaiVezeto";
            this.textBoxSzakmaiVezeto.Size = new System.Drawing.Size(121, 20);
            this.textBoxSzakmaiVezeto.TabIndex = 4;
            this.textBoxSzakmaiVezeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSzakmaiVezeto_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(25, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 103;
            this.label12.Text = "Szakmai vezető:";
            // 
            // textBoxPenzugyiVezeto
            // 
            this.textBoxPenzugyiVezeto.Location = new System.Drawing.Point(600, 24);
            this.textBoxPenzugyiVezeto.Name = "textBoxPenzugyiVezeto";
            this.textBoxPenzugyiVezeto.Size = new System.Drawing.Size(121, 20);
            this.textBoxPenzugyiVezeto.TabIndex = 5;
            this.textBoxPenzugyiVezeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPenzugyiVezeto_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(411, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 17);
            this.label11.TabIndex = 101;
            this.label11.Text = "Pénzügyi vezető:";
            // 
            // comboBoxPalyazatTipus
            // 
            this.comboBoxPalyazatTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPalyazatTipus.FormattingEnabled = true;
            this.comboBoxPalyazatTipus.Items.AddRange(new object[] {
            "Minisztériumi",
            "NTKA",
            "NKFIH",
            "NKA",
            "EFOP",
            "GINOP"});
            this.comboBoxPalyazatTipus.Location = new System.Drawing.Point(219, 24);
            this.comboBoxPalyazatTipus.Name = "comboBoxPalyazatTipus";
            this.comboBoxPalyazatTipus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPalyazatTipus.TabIndex = 0;
            // 
            // comboBoxFinanszirozasTipus
            // 
            this.comboBoxFinanszirozasTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFinanszirozasTipus.FormattingEnabled = true;
            this.comboBoxFinanszirozasTipus.Items.AddRange(new object[] {
            "Előfinanszírozott",
            "Utófinanszírozott"});
            this.comboBoxFinanszirozasTipus.Location = new System.Drawing.Point(219, 108);
            this.comboBoxFinanszirozasTipus.Name = "comboBoxFinanszirozasTipus";
            this.comboBoxFinanszirozasTipus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFinanszirozasTipus.TabIndex = 2;
            // 
            // comboBoxTudomanyTerulet
            // 
            this.comboBoxTudomanyTerulet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTudomanyTerulet.FormattingEnabled = true;
            this.comboBoxTudomanyTerulet.Items.AddRange(new object[] {
            "Műszaki",
            "Társadalom tudomány",
            "Természet tudomány",
            "Informatika"});
            this.comboBoxTudomanyTerulet.Location = new System.Drawing.Point(219, 152);
            this.comboBoxTudomanyTerulet.Name = "comboBoxTudomanyTerulet";
            this.comboBoxTudomanyTerulet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTudomanyTerulet.TabIndex = 3;
            // 
            // comboBoxPenznem
            // 
            this.comboBoxPenznem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPenznem.FormattingEnabled = true;
            this.comboBoxPenznem.Items.AddRange(new object[] {
            "Forint",
            "Euro",
            "Dollár"});
            this.comboBoxPenznem.Location = new System.Drawing.Point(600, 106);
            this.comboBoxPenznem.Name = "comboBoxPenznem";
            this.comboBoxPenznem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPenznem.TabIndex = 7;
            // 
            // errorProviderPalyazatTipus
            // 
            this.errorProviderPalyazatTipus.ContainerControl = this;
            // 
            // errorProviderPalyazatNev
            // 
            this.errorProviderPalyazatNev.ContainerControl = this;
            // 
            // errorProviderFinanszirozasTipus
            // 
            this.errorProviderFinanszirozasTipus.ContainerControl = this;
            // 
            // errorProviderPalyazatTudomanyterulet
            // 
            this.errorProviderPalyazatTudomanyterulet.ContainerControl = this;
            // 
            // errorProviderPalyazatSzakmaiVezeto
            // 
            this.errorProviderPalyazatSzakmaiVezeto.ContainerControl = this;
            // 
            // errorProviderPalyazatPenzugyiVezeto
            // 
            this.errorProviderPalyazatPenzugyiVezeto.ContainerControl = this;
            // 
            // errorProviderPalyazatElnyertOsszeg
            // 
            this.errorProviderPalyazatElnyertOsszeg.ContainerControl = this;
            // 
            // errorProviderPalyazatPenznem
            // 
            this.errorProviderPalyazatPenznem.ContainerControl = this;
            // 
            // errorProviderPalyazatFelhasznIdoKezd
            // 
            this.errorProviderPalyazatFelhasznIdoKezd.ContainerControl = this;
            // 
            // errorProviderPalyazatFelhasznIdoVege
            // 
            this.errorProviderPalyazatFelhasznIdoVege.ContainerControl = this;
            // 
            // buttonFormVezetok
            // 
            this.buttonFormVezetok.Location = new System.Drawing.Point(219, 239);
            this.buttonFormVezetok.Name = "buttonFormVezetok";
            this.buttonFormVezetok.Size = new System.Drawing.Size(121, 23);
            this.buttonFormVezetok.TabIndex = 110;
            this.buttonFormVezetok.Text = "Vezetők";
            this.buttonFormVezetok.UseVisualStyleBackColor = true;
            this.buttonFormVezetok.Click += new System.EventHandler(this.buttonFormVezetok_Click);
            // 
            // FormPalyazatUjHozzaad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(758, 274);
            this.Controls.Add(this.buttonFormVezetok);
            this.Controls.Add(this.comboBoxPenznem);
            this.Controls.Add(this.comboBoxTudomanyTerulet);
            this.Controls.Add(this.comboBoxFinanszirozasTipus);
            this.Controls.Add(this.comboBoxPalyazatTipus);
            this.Controls.Add(this.textBoxSzakmaiVezeto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxPenzugyiVezeto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.buttonMegsem);
            this.Controls.Add(this.textBoxFelhasznIdoVege);
            this.Controls.Add(this.textBoxFelhasznIdoKezd);
            this.Controls.Add(this.textBoxElnyertOsszeg);
            this.Controls.Add(this.textBoxPalyazatNev);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPalyazatUjHozzaad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPalyazatUjHozzaad";
            this.Load += new System.EventHandler(this.FormPalyazatUjHozzaad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatTipus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatNev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFinanszirozasTipus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatTudomanyterulet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatSzakmaiVezeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatPenzugyiVezeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatElnyertOsszeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatPenznem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatFelhasznIdoKezd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPalyazatFelhasznIdoVege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Button buttonMegsem;
        private System.Windows.Forms.TextBox textBoxFelhasznIdoVege;
        private System.Windows.Forms.TextBox textBoxFelhasznIdoKezd;
        private System.Windows.Forms.TextBox textBoxElnyertOsszeg;
        private System.Windows.Forms.TextBox textBoxPalyazatNev;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSzakmaiVezeto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxPenzugyiVezeto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxPalyazatTipus;
        private System.Windows.Forms.ComboBox comboBoxFinanszirozasTipus;
        private System.Windows.Forms.ComboBox comboBoxTudomanyTerulet;
        private System.Windows.Forms.ComboBox comboBoxPenznem;
        private System.Windows.Forms.ErrorProvider errorProviderPalyazatTipus;
        private System.Windows.Forms.ErrorProvider errorProviderPalyazatNev;
        private System.Windows.Forms.ErrorProvider errorProviderFinanszirozasTipus;
        private System.Windows.Forms.ErrorProvider errorProviderPalyazatTudomanyterulet;
        private System.Windows.Forms.ErrorProvider errorProviderPalyazatSzakmaiVezeto;
        private System.Windows.Forms.ErrorProvider errorProviderPalyazatPenzugyiVezeto;
        private System.Windows.Forms.ErrorProvider errorProviderPalyazatElnyertOsszeg;
        private System.Windows.Forms.ErrorProvider errorProviderPalyazatPenznem;
        private System.Windows.Forms.ErrorProvider errorProviderPalyazatFelhasznIdoKezd;
        private System.Windows.Forms.ErrorProvider errorProviderPalyazatFelhasznIdoVege;
        private System.Windows.Forms.Button buttonFormVezetok;
    }
}