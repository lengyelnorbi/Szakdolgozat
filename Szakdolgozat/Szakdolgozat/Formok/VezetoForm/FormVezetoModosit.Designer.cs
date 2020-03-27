namespace Szakdolgozat.Formok.VezetoForm
{
    partial class FormVezetoModosit
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
            this.textBoxVezetoTelefonszam = new System.Windows.Forms.TextBox();
            this.buttonVezetoModositMentes = new System.Windows.Forms.Button();
            this.buttonMegsem = new System.Windows.Forms.Button();
            this.textBoxVezetoEmail = new System.Windows.Forms.TextBox();
            this.textBoxVezetoNev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderVezetoNev = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderVezetoTelefonszam = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderVezetoEmail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVezetoNev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVezetoTelefonszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVezetoEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxVezetoTelefonszam
            // 
            this.textBoxVezetoTelefonszam.Location = new System.Drawing.Point(182, 83);
            this.textBoxVezetoTelefonszam.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVezetoTelefonszam.Name = "textBoxVezetoTelefonszam";
            this.textBoxVezetoTelefonszam.Size = new System.Drawing.Size(113, 20);
            this.textBoxVezetoTelefonszam.TabIndex = 1;
            this.textBoxVezetoTelefonszam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVezetoTelefonszam_KeyPress);
            // 
            // buttonVezetoModositMentes
            // 
            this.buttonVezetoModositMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonVezetoModositMentes.Location = new System.Drawing.Point(37, 175);
            this.buttonVezetoModositMentes.Name = "buttonVezetoModositMentes";
            this.buttonVezetoModositMentes.Size = new System.Drawing.Size(115, 23);
            this.buttonVezetoModositMentes.TabIndex = 3;
            this.buttonVezetoModositMentes.Text = "Mentes";
            this.buttonVezetoModositMentes.UseVisualStyleBackColor = true;
            this.buttonVezetoModositMentes.Click += new System.EventHandler(this.buttonVezetoModositMentes_Click);
            // 
            // buttonMegsem
            // 
            this.buttonMegsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonMegsem.Location = new System.Drawing.Point(182, 175);
            this.buttonMegsem.Name = "buttonMegsem";
            this.buttonMegsem.Size = new System.Drawing.Size(113, 23);
            this.buttonMegsem.TabIndex = 4;
            this.buttonMegsem.Text = "Mégsem";
            this.buttonMegsem.UseVisualStyleBackColor = true;
            this.buttonMegsem.Click += new System.EventHandler(this.buttonMegsem_Click);
            // 
            // textBoxVezetoEmail
            // 
            this.textBoxVezetoEmail.Location = new System.Drawing.Point(182, 129);
            this.textBoxVezetoEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVezetoEmail.Name = "textBoxVezetoEmail";
            this.textBoxVezetoEmail.Size = new System.Drawing.Size(113, 20);
            this.textBoxVezetoEmail.TabIndex = 2;
            // 
            // textBoxVezetoNev
            // 
            this.textBoxVezetoNev.Location = new System.Drawing.Point(182, 36);
            this.textBoxVezetoNev.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVezetoNev.Name = "textBoxVezetoNev";
            this.textBoxVezetoNev.Size = new System.Drawing.Size(113, 20);
            this.textBoxVezetoNev.TabIndex = 0;
            this.textBoxVezetoNev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVezetoNev_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(34, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Email cím:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Telefonszám:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Név:";
            // 
            // errorProviderVezetoNev
            // 
            this.errorProviderVezetoNev.ContainerControl = this;
            // 
            // errorProviderVezetoTelefonszam
            // 
            this.errorProviderVezetoTelefonszam.ContainerControl = this;
            // 
            // errorProviderVezetoEmail
            // 
            this.errorProviderVezetoEmail.ContainerControl = this;
            // 
            // FormVezetoModosit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(354, 217);
            this.Controls.Add(this.textBoxVezetoTelefonszam);
            this.Controls.Add(this.buttonVezetoModositMentes);
            this.Controls.Add(this.buttonMegsem);
            this.Controls.Add(this.textBoxVezetoEmail);
            this.Controls.Add(this.textBoxVezetoNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVezetoModosit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVezetoModosit";
            this.Load += new System.EventHandler(this.FormVezetoModosit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVezetoNev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVezetoTelefonszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVezetoEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVezetoTelefonszam;
        private System.Windows.Forms.Button buttonVezetoModositMentes;
        private System.Windows.Forms.Button buttonMegsem;
        private System.Windows.Forms.TextBox textBoxVezetoEmail;
        private System.Windows.Forms.TextBox textBoxVezetoNev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderVezetoNev;
        private System.Windows.Forms.ErrorProvider errorProviderVezetoTelefonszam;
        private System.Windows.Forms.ErrorProvider errorProviderVezetoEmail;
    }
}