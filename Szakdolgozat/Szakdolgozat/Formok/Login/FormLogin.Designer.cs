namespace Szakdolgozat.Formok.Login
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFelhasznalonev = new System.Windows.Forms.TextBox();
            this.textBoxJelszo = new System.Windows.Forms.TextBox();
            this.buttonBelep = new System.Windows.Forms.Button();
            this.labelHiba = new System.Windows.Forms.Label();
            this.checkBoxJelszoElrejt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "BELÉPÉS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Felhasználónév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(20, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jelszó:";
            // 
            // textBoxFelhasznalonev
            // 
            this.textBoxFelhasznalonev.Location = new System.Drawing.Point(147, 142);
            this.textBoxFelhasznalonev.Name = "textBoxFelhasznalonev";
            this.textBoxFelhasznalonev.Size = new System.Drawing.Size(117, 20);
            this.textBoxFelhasznalonev.TabIndex = 3;
            // 
            // textBoxJelszo
            // 
            this.textBoxJelszo.Location = new System.Drawing.Point(147, 190);
            this.textBoxJelszo.Name = "textBoxJelszo";
            this.textBoxJelszo.Size = new System.Drawing.Size(117, 20);
            this.textBoxJelszo.TabIndex = 4;
            // 
            // buttonBelep
            // 
            this.buttonBelep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonBelep.Location = new System.Drawing.Point(80, 234);
            this.buttonBelep.Name = "buttonBelep";
            this.buttonBelep.Size = new System.Drawing.Size(172, 44);
            this.buttonBelep.TabIndex = 5;
            this.buttonBelep.Text = "BELÉP";
            this.buttonBelep.UseVisualStyleBackColor = true;
            this.buttonBelep.Click += new System.EventHandler(this.buttonBelep_Click);
            // 
            // labelHiba
            // 
            this.labelHiba.AutoSize = true;
            this.labelHiba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelHiba.ForeColor = System.Drawing.Color.Red;
            this.labelHiba.Location = new System.Drawing.Point(20, 104);
            this.labelHiba.Name = "labelHiba";
            this.labelHiba.Size = new System.Drawing.Size(0, 17);
            this.labelHiba.TabIndex = 6;
            // 
            // checkBoxJelszoElrejt
            // 
            this.checkBoxJelszoElrejt.AutoSize = true;
            this.checkBoxJelszoElrejt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxJelszoElrejt.Location = new System.Drawing.Point(279, 190);
            this.checkBoxJelszoElrejt.Name = "checkBoxJelszoElrejt";
            this.checkBoxJelszoElrejt.Size = new System.Drawing.Size(59, 21);
            this.checkBoxJelszoElrejt.TabIndex = 7;
            this.checkBoxJelszoElrejt.Text = "Elrejt";
            this.checkBoxJelszoElrejt.UseVisualStyleBackColor = true;
            this.checkBoxJelszoElrejt.CheckedChanged += new System.EventHandler(this.checkBoxJelszoElrejt_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(350, 299);
            this.Controls.Add(this.checkBoxJelszoElrejt);
            this.Controls.Add(this.labelHiba);
            this.Controls.Add(this.buttonBelep);
            this.Controls.Add(this.textBoxJelszo);
            this.Controls.Add(this.textBoxFelhasznalonev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFelhasznalonev;
        private System.Windows.Forms.TextBox textBoxJelszo;
        private System.Windows.Forms.Button buttonBelep;
        private System.Windows.Forms.Label labelHiba;
        private System.Windows.Forms.CheckBox checkBoxJelszoElrejt;
    }
}