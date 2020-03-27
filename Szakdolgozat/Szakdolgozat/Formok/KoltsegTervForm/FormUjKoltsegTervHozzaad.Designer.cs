namespace Szakdolgozat.Formok.KoltsegTervForm
{
    partial class FormUjKoltsegTervHozzaad
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
            this.comboBoxKoltsegTipus = new System.Windows.Forms.ComboBox();
            this.buttonKoltsegTervLetrehoz = new System.Windows.Forms.Button();
            this.buttonMegsem = new System.Windows.Forms.Button();
            this.textBoxModositottOsszeg = new System.Windows.Forms.TextBox();
            this.textBoxTervezettOsszeg = new System.Windows.Forms.TextBox();
            this.textBoxPalyazatAZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderKoltsegTipus = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTervezettOsszeg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderModositottOsszeg = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKoltsegTipus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTervezettOsszeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModositottOsszeg)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKoltsegTipus
            // 
            this.comboBoxKoltsegTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKoltsegTipus.FormattingEnabled = true;
            this.comboBoxKoltsegTipus.Items.AddRange(new object[] {
            "Bérköltség",
            "Járulék",
            "Szakmai anyag",
            "Szolgáltatás",
            "Rezsi",
            "Tárgyi eszköz",
            "Beruházás/Felújítás"});
            this.comboBoxKoltsegTipus.Location = new System.Drawing.Point(185, 69);
            this.comboBoxKoltsegTipus.Name = "comboBoxKoltsegTipus";
            this.comboBoxKoltsegTipus.Size = new System.Drawing.Size(113, 21);
            this.comboBoxKoltsegTipus.TabIndex = 0;
            // 
            // buttonKoltsegTervLetrehoz
            // 
            this.buttonKoltsegTervLetrehoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonKoltsegTervLetrehoz.Location = new System.Drawing.Point(40, 212);
            this.buttonKoltsegTervLetrehoz.Name = "buttonKoltsegTervLetrehoz";
            this.buttonKoltsegTervLetrehoz.Size = new System.Drawing.Size(113, 23);
            this.buttonKoltsegTervLetrehoz.TabIndex = 3;
            this.buttonKoltsegTervLetrehoz.Text = "Hozzáad";
            this.buttonKoltsegTervLetrehoz.UseVisualStyleBackColor = true;
            this.buttonKoltsegTervLetrehoz.Click += new System.EventHandler(this.buttonKoltsegTervLetrehoz_Click);
            // 
            // buttonMegsem
            // 
            this.buttonMegsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonMegsem.Location = new System.Drawing.Point(185, 212);
            this.buttonMegsem.Name = "buttonMegsem";
            this.buttonMegsem.Size = new System.Drawing.Size(113, 23);
            this.buttonMegsem.TabIndex = 4;
            this.buttonMegsem.Text = "Mégsem";
            this.buttonMegsem.UseVisualStyleBackColor = true;
            this.buttonMegsem.Click += new System.EventHandler(this.buttonMegsem_Click);
            // 
            // textBoxModositottOsszeg
            // 
            this.textBoxModositottOsszeg.Location = new System.Drawing.Point(185, 163);
            this.textBoxModositottOsszeg.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModositottOsszeg.Name = "textBoxModositottOsszeg";
            this.textBoxModositottOsszeg.Size = new System.Drawing.Size(113, 20);
            this.textBoxModositottOsszeg.TabIndex = 2;
            this.textBoxModositottOsszeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxModositottOsszeg_KeyPress);
            // 
            // textBoxTervezettOsszeg
            // 
            this.textBoxTervezettOsszeg.Location = new System.Drawing.Point(185, 117);
            this.textBoxTervezettOsszeg.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTervezettOsszeg.Name = "textBoxTervezettOsszeg";
            this.textBoxTervezettOsszeg.Size = new System.Drawing.Size(113, 20);
            this.textBoxTervezettOsszeg.TabIndex = 1;
            this.textBoxTervezettOsszeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTervezettOsszeg_KeyPress);
            // 
            // textBoxPalyazatAZ
            // 
            this.textBoxPalyazatAZ.Enabled = false;
            this.textBoxPalyazatAZ.Location = new System.Drawing.Point(185, 23);
            this.textBoxPalyazatAZ.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPalyazatAZ.Name = "textBoxPalyazatAZ";
            this.textBoxPalyazatAZ.Size = new System.Drawing.Size(113, 20);
            this.textBoxPalyazatAZ.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(37, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tervezett összeg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(37, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Módosított összeg:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Költség típus:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Pályázat azonosító:";
            // 
            // errorProviderKoltsegTipus
            // 
            this.errorProviderKoltsegTipus.ContainerControl = this;
            // 
            // errorProviderTervezettOsszeg
            // 
            this.errorProviderTervezettOsszeg.ContainerControl = this;
            // 
            // errorProviderModositottOsszeg
            // 
            this.errorProviderModositottOsszeg.ContainerControl = this;
            // 
            // FormUjKoltsegTervHozzaad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(346, 270);
            this.Controls.Add(this.comboBoxKoltsegTipus);
            this.Controls.Add(this.buttonKoltsegTervLetrehoz);
            this.Controls.Add(this.buttonMegsem);
            this.Controls.Add(this.textBoxModositottOsszeg);
            this.Controls.Add(this.textBoxTervezettOsszeg);
            this.Controls.Add(this.textBoxPalyazatAZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUjKoltsegTervHozzaad";
            this.Text = "FormUjKoltsegTervHozzaad";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKoltsegTipus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTervezettOsszeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModositottOsszeg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKoltsegTipus;
        private System.Windows.Forms.Button buttonKoltsegTervLetrehoz;
        private System.Windows.Forms.Button buttonMegsem;
        private System.Windows.Forms.TextBox textBoxModositottOsszeg;
        private System.Windows.Forms.TextBox textBoxTervezettOsszeg;
        private System.Windows.Forms.TextBox textBoxPalyazatAZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderKoltsegTipus;
        private System.Windows.Forms.ErrorProvider errorProviderTervezettOsszeg;
        private System.Windows.Forms.ErrorProvider errorProviderModositottOsszeg;
    }
}