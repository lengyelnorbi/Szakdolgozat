namespace Szakdolgozat.Formok.TenyfelhasznalasForm
{
    partial class FormUjTenyfelhasznHozzaad
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
            this.comboBoxKoltsegTipus = new System.Windows.Forms.ComboBox();
            this.buttonTenyfelhasznalasLetrehoz = new System.Windows.Forms.Button();
            this.buttonMegsem = new System.Windows.Forms.Button();
            this.textBoxFizetesDatuma = new System.Windows.Forms.TextBox();
            this.textBoxFizetettOsszeg = new System.Windows.Forms.TextBox();
            this.textBoxPalyazatAZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.comboBoxKoltsegTipus.Location = new System.Drawing.Point(195, 79);
            this.comboBoxKoltsegTipus.Name = "comboBoxKoltsegTipus";
            this.comboBoxKoltsegTipus.Size = new System.Drawing.Size(113, 21);
            this.comboBoxKoltsegTipus.TabIndex = 35;
            // 
            // buttonTenyfelhasznalasLetrehoz
            // 
            this.buttonTenyfelhasznalasLetrehoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonTenyfelhasznalasLetrehoz.Location = new System.Drawing.Point(50, 222);
            this.buttonTenyfelhasznalasLetrehoz.Name = "buttonTenyfelhasznalasLetrehoz";
            this.buttonTenyfelhasznalasLetrehoz.Size = new System.Drawing.Size(113, 23);
            this.buttonTenyfelhasznalasLetrehoz.TabIndex = 34;
            this.buttonTenyfelhasznalasLetrehoz.Text = "Hozzáad";
            this.buttonTenyfelhasznalasLetrehoz.UseVisualStyleBackColor = true;
            this.buttonTenyfelhasznalasLetrehoz.Click += new System.EventHandler(this.buttonTenyfelhasznalasLetrehoz_Click);
            // 
            // buttonMegsem
            // 
            this.buttonMegsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonMegsem.Location = new System.Drawing.Point(195, 222);
            this.buttonMegsem.Name = "buttonMegsem";
            this.buttonMegsem.Size = new System.Drawing.Size(113, 23);
            this.buttonMegsem.TabIndex = 33;
            this.buttonMegsem.Text = "Mégsem";
            this.buttonMegsem.UseVisualStyleBackColor = true;
            this.buttonMegsem.Click += new System.EventHandler(this.buttonMegsem_Click);
            // 
            // textBoxFizetesDatuma
            // 
            this.textBoxFizetesDatuma.Location = new System.Drawing.Point(195, 173);
            this.textBoxFizetesDatuma.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFizetesDatuma.Name = "textBoxFizetesDatuma";
            this.textBoxFizetesDatuma.Size = new System.Drawing.Size(113, 20);
            this.textBoxFizetesDatuma.TabIndex = 32;
            this.textBoxFizetesDatuma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFizetesDatuma_KeyPress);
            // 
            // textBoxFizetettOsszeg
            // 
            this.textBoxFizetettOsszeg.Location = new System.Drawing.Point(195, 127);
            this.textBoxFizetettOsszeg.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFizetettOsszeg.Name = "textBoxFizetettOsszeg";
            this.textBoxFizetettOsszeg.Size = new System.Drawing.Size(113, 20);
            this.textBoxFizetettOsszeg.TabIndex = 31;
            this.textBoxFizetettOsszeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFizetettOsszeg_KeyPress);
            // 
            // textBoxPalyazatAZ
            // 
            this.textBoxPalyazatAZ.Enabled = false;
            this.textBoxPalyazatAZ.Location = new System.Drawing.Point(195, 33);
            this.textBoxPalyazatAZ.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPalyazatAZ.Name = "textBoxPalyazatAZ";
            this.textBoxPalyazatAZ.Size = new System.Drawing.Size(113, 20);
            this.textBoxPalyazatAZ.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(47, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Összeg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(47, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fizetés dátuma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(47, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Költség típus:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Pályázat azonosító:";
            // 
            // FormUjTenyfelhasznHozzaad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 267);
            this.Controls.Add(this.comboBoxKoltsegTipus);
            this.Controls.Add(this.buttonTenyfelhasznalasLetrehoz);
            this.Controls.Add(this.buttonMegsem);
            this.Controls.Add(this.textBoxFizetesDatuma);
            this.Controls.Add(this.textBoxFizetettOsszeg);
            this.Controls.Add(this.textBoxPalyazatAZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUjTenyfelhasznHozzaad";
            this.Text = "FormUjTenyfelhasznHozzaad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKoltsegTipus;
        private System.Windows.Forms.Button buttonTenyfelhasznalasLetrehoz;
        private System.Windows.Forms.Button buttonMegsem;
        private System.Windows.Forms.TextBox textBoxFizetesDatuma;
        private System.Windows.Forms.TextBox textBoxFizetettOsszeg;
        private System.Windows.Forms.TextBox textBoxPalyazatAZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}