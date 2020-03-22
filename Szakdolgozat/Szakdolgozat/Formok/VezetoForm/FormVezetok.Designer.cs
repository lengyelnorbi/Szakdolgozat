namespace Szakdolgozat.Formok.VezetoForm
{
    partial class FormVezetok
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
            this.dataGridViewVezetok = new System.Windows.Forms.DataGridView();
            this.textBoxVezetoTelefonszam = new System.Windows.Forms.TextBox();
            this.buttonUjVezetoForm = new System.Windows.Forms.Button();
            this.buttonVezetoModositForm = new System.Windows.Forms.Button();
            this.textBoxVezetoEmail = new System.Windows.Forms.TextBox();
            this.textBoxVezetoNev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVezetoTorol = new System.Windows.Forms.Button();
            this.buttonVissza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVezetok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVezetok
            // 
            this.dataGridViewVezetok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVezetok.Location = new System.Drawing.Point(39, 167);
            this.dataGridViewVezetok.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewVezetok.Name = "dataGridViewVezetok";
            this.dataGridViewVezetok.RowHeadersWidth = 51;
            this.dataGridViewVezetok.RowTemplate.Height = 24;
            this.dataGridViewVezetok.Size = new System.Drawing.Size(424, 122);
            this.dataGridViewVezetok.TabIndex = 2;
            // 
            // textBoxVezetoTelefonszam
            // 
            this.textBoxVezetoTelefonszam.Enabled = false;
            this.textBoxVezetoTelefonszam.Location = new System.Drawing.Point(148, 79);
            this.textBoxVezetoTelefonszam.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVezetoTelefonszam.Name = "textBoxVezetoTelefonszam";
            this.textBoxVezetoTelefonszam.Size = new System.Drawing.Size(113, 20);
            this.textBoxVezetoTelefonszam.TabIndex = 58;
            // 
            // buttonUjVezetoForm
            // 
            this.buttonUjVezetoForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonUjVezetoForm.Location = new System.Drawing.Point(291, 54);
            this.buttonUjVezetoForm.Name = "buttonUjVezetoForm";
            this.buttonUjVezetoForm.Size = new System.Drawing.Size(72, 23);
            this.buttonUjVezetoForm.TabIndex = 55;
            this.buttonUjVezetoForm.Text = "Új vezető";
            this.buttonUjVezetoForm.UseVisualStyleBackColor = true;
            this.buttonUjVezetoForm.Click += new System.EventHandler(this.buttonUjVezetoForm_Click);
            // 
            // buttonVezetoModositForm
            // 
            this.buttonVezetoModositForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonVezetoModositForm.Location = new System.Drawing.Point(392, 54);
            this.buttonVezetoModositForm.Name = "buttonVezetoModositForm";
            this.buttonVezetoModositForm.Size = new System.Drawing.Size(72, 23);
            this.buttonVezetoModositForm.TabIndex = 54;
            this.buttonVezetoModositForm.Text = "Módosít";
            this.buttonVezetoModositForm.UseVisualStyleBackColor = true;
            this.buttonVezetoModositForm.Click += new System.EventHandler(this.buttonVezetoModositForm_Click);
            // 
            // textBoxVezetoEmail
            // 
            this.textBoxVezetoEmail.Enabled = false;
            this.textBoxVezetoEmail.Location = new System.Drawing.Point(148, 128);
            this.textBoxVezetoEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVezetoEmail.Name = "textBoxVezetoEmail";
            this.textBoxVezetoEmail.Size = new System.Drawing.Size(113, 20);
            this.textBoxVezetoEmail.TabIndex = 53;
            // 
            // textBoxVezetoNev
            // 
            this.textBoxVezetoNev.Enabled = false;
            this.textBoxVezetoNev.Location = new System.Drawing.Point(148, 32);
            this.textBoxVezetoNev.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVezetoNev.Name = "textBoxVezetoNev";
            this.textBoxVezetoNev.Size = new System.Drawing.Size(113, 20);
            this.textBoxVezetoNev.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(37, 128);
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
            this.label2.Location = new System.Drawing.Point(35, 79);
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
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Vezető neve:";
            // 
            // buttonVezetoTorol
            // 
            this.buttonVezetoTorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonVezetoTorol.Location = new System.Drawing.Point(291, 102);
            this.buttonVezetoTorol.Name = "buttonVezetoTorol";
            this.buttonVezetoTorol.Size = new System.Drawing.Size(72, 23);
            this.buttonVezetoTorol.TabIndex = 59;
            this.buttonVezetoTorol.Text = "Töröl";
            this.buttonVezetoTorol.UseVisualStyleBackColor = true;
            this.buttonVezetoTorol.Click += new System.EventHandler(this.buttonVezetoTorol_Click);
            // 
            // buttonVissza
            // 
            this.buttonVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonVissza.Location = new System.Drawing.Point(392, 102);
            this.buttonVissza.Name = "buttonVissza";
            this.buttonVissza.Size = new System.Drawing.Size(72, 23);
            this.buttonVissza.TabIndex = 60;
            this.buttonVissza.Text = "Vissza";
            this.buttonVissza.UseVisualStyleBackColor = true;
            this.buttonVissza.Click += new System.EventHandler(this.buttonVissza_Click);
            // 
            // FormVezetok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 314);
            this.Controls.Add(this.buttonVissza);
            this.Controls.Add(this.buttonVezetoTorol);
            this.Controls.Add(this.textBoxVezetoTelefonszam);
            this.Controls.Add(this.buttonUjVezetoForm);
            this.Controls.Add(this.buttonVezetoModositForm);
            this.Controls.Add(this.textBoxVezetoEmail);
            this.Controls.Add(this.textBoxVezetoNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVezetok);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVezetok";
            this.Text = "FormVezetok";
            this.Load += new System.EventHandler(this.FormVezetok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVezetok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewVezetok;
        private System.Windows.Forms.TextBox textBoxVezetoTelefonszam;
        private System.Windows.Forms.Button buttonUjVezetoForm;
        private System.Windows.Forms.Button buttonVezetoModositForm;
        private System.Windows.Forms.TextBox textBoxVezetoEmail;
        private System.Windows.Forms.TextBox textBoxVezetoNev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVezetoTorol;
        private System.Windows.Forms.Button buttonVissza;
    }
}