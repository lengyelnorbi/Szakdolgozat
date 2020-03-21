namespace Szakdolgozat.Formok.UjVezetoForm
{
    partial class FormUjVezetoHozzaad
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
            this.buttonVezetoFelvetele = new System.Windows.Forms.Button();
            this.buttonMegsem = new System.Windows.Forms.Button();
            this.textBoxVezetoEmail = new System.Windows.Forms.TextBox();
            this.textBoxVezetoNev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVezetoTelefonszam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonVezetoFelvetele
            // 
            this.buttonVezetoFelvetele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonVezetoFelvetele.Location = new System.Drawing.Point(53, 218);
            this.buttonVezetoFelvetele.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVezetoFelvetele.Name = "buttonVezetoFelvetele";
            this.buttonVezetoFelvetele.Size = new System.Drawing.Size(151, 28);
            this.buttonVezetoFelvetele.TabIndex = 44;
            this.buttonVezetoFelvetele.Text = "Hozzáad";
            this.buttonVezetoFelvetele.UseVisualStyleBackColor = true;
            // 
            // buttonMegsem
            // 
            this.buttonMegsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonMegsem.Location = new System.Drawing.Point(246, 218);
            this.buttonMegsem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMegsem.Name = "buttonMegsem";
            this.buttonMegsem.Size = new System.Drawing.Size(151, 28);
            this.buttonMegsem.TabIndex = 43;
            this.buttonMegsem.Text = "Mégsem";
            this.buttonMegsem.UseVisualStyleBackColor = true;
            // 
            // textBoxVezetoEmail
            // 
            this.textBoxVezetoEmail.Location = new System.Drawing.Point(248, 162);
            this.textBoxVezetoEmail.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxVezetoEmail.Name = "textBoxVezetoEmail";
            this.textBoxVezetoEmail.Size = new System.Drawing.Size(149, 22);
            this.textBoxVezetoEmail.TabIndex = 41;
            // 
            // textBoxVezetoNev
            // 
            this.textBoxVezetoNev.Location = new System.Drawing.Point(248, 47);
            this.textBoxVezetoNev.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxVezetoNev.Name = "textBoxVezetoNev";
            this.textBoxVezetoNev.Size = new System.Drawing.Size(149, 22);
            this.textBoxVezetoNev.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(51, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Email cím:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(51, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Telefonszám:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Név:";
            // 
            // textBoxVezetoTelefonszam
            // 
            this.textBoxVezetoTelefonszam.Location = new System.Drawing.Point(248, 105);
            this.textBoxVezetoTelefonszam.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxVezetoTelefonszam.Name = "textBoxVezetoTelefonszam";
            this.textBoxVezetoTelefonszam.Size = new System.Drawing.Size(149, 22);
            this.textBoxVezetoTelefonszam.TabIndex = 48;
            // 
            // FormUjVezetoHozzaad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 278);
            this.Controls.Add(this.textBoxVezetoTelefonszam);
            this.Controls.Add(this.buttonVezetoFelvetele);
            this.Controls.Add(this.buttonMegsem);
            this.Controls.Add(this.textBoxVezetoEmail);
            this.Controls.Add(this.textBoxVezetoNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUjVezetoHozzaad";
            this.Text = "FormUjVezetoHozzaad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonVezetoFelvetele;
        private System.Windows.Forms.Button buttonMegsem;
        private System.Windows.Forms.TextBox textBoxVezetoEmail;
        private System.Windows.Forms.TextBox textBoxVezetoNev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVezetoTelefonszam;
    }
}