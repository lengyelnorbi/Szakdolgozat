namespace Szakdolgozat.Formok.KoltsegTervForm
{
    partial class FormKoltsegTervModosit
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
            this.textBoxTervezettOsszeg = new System.Windows.Forms.TextBox();
            this.textBoxPalyazatAZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModositottOsszeg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMegsem = new System.Windows.Forms.Button();
            this.buttonKoltsegTervMentes = new System.Windows.Forms.Button();
            this.comboBoxKoltsegTipus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxTervezettOsszeg
            // 
            this.textBoxTervezettOsszeg.Location = new System.Drawing.Point(177, 130);
            this.textBoxTervezettOsszeg.Name = "textBoxTervezettOsszeg";
            this.textBoxTervezettOsszeg.Size = new System.Drawing.Size(100, 20);
            this.textBoxTervezettOsszeg.TabIndex = 29;
            // 
            // textBoxPalyazatAZ
            // 
            this.textBoxPalyazatAZ.Enabled = false;
            this.textBoxPalyazatAZ.Location = new System.Drawing.Point(177, 38);
            this.textBoxPalyazatAZ.Name = "textBoxPalyazatAZ";
            this.textBoxPalyazatAZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxPalyazatAZ.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(41, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Összeg:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(41, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Költség típus:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Pályázat azonosító:";
            // 
            // textBoxModositottOsszeg
            // 
            this.textBoxModositottOsszeg.Location = new System.Drawing.Point(176, 175);
            this.textBoxModositottOsszeg.Name = "textBoxModositottOsszeg";
            this.textBoxModositottOsszeg.Size = new System.Drawing.Size(100, 20);
            this.textBoxModositottOsszeg.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(41, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Módosított összeg:";
            // 
            // buttonMegsem
            // 
            this.buttonMegsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonMegsem.Location = new System.Drawing.Point(176, 222);
            this.buttonMegsem.Name = "buttonMegsem";
            this.buttonMegsem.Size = new System.Drawing.Size(101, 23);
            this.buttonMegsem.TabIndex = 34;
            this.buttonMegsem.Text = "Mégsem";
            this.buttonMegsem.UseVisualStyleBackColor = true;
            this.buttonMegsem.Click += new System.EventHandler(this.buttonMegsem_Click);
            // 
            // buttonKoltsegTervMentes
            // 
            this.buttonKoltsegTervMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonKoltsegTervMentes.Location = new System.Drawing.Point(44, 222);
            this.buttonKoltsegTervMentes.Name = "buttonKoltsegTervMentes";
            this.buttonKoltsegTervMentes.Size = new System.Drawing.Size(105, 23);
            this.buttonKoltsegTervMentes.TabIndex = 33;
            this.buttonKoltsegTervMentes.Text = "Mentés";
            this.buttonKoltsegTervMentes.UseVisualStyleBackColor = true;
            this.buttonKoltsegTervMentes.Click += new System.EventHandler(this.buttonKoltsegTervMentes_Click);
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
            this.comboBoxKoltsegTipus.Location = new System.Drawing.Point(177, 86);
            this.comboBoxKoltsegTipus.Name = "comboBoxKoltsegTipus";
            this.comboBoxKoltsegTipus.Size = new System.Drawing.Size(100, 21);
            this.comboBoxKoltsegTipus.TabIndex = 35;
            // 
            // FormKoltsegTervModosit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 283);
            this.Controls.Add(this.comboBoxKoltsegTipus);
            this.Controls.Add(this.buttonMegsem);
            this.Controls.Add(this.buttonKoltsegTervMentes);
            this.Controls.Add(this.textBoxModositottOsszeg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTervezettOsszeg);
            this.Controls.Add(this.textBoxPalyazatAZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKoltsegTervModosit";
            this.Text = "FormKoltsegTervModosit";
            this.Load += new System.EventHandler(this.FormKoltsegTervModosit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTervezettOsszeg;
        private System.Windows.Forms.TextBox textBoxPalyazatAZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxModositottOsszeg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMegsem;
        private System.Windows.Forms.Button buttonKoltsegTervMentes;
        private System.Windows.Forms.ComboBox comboBoxKoltsegTipus;
    }
}