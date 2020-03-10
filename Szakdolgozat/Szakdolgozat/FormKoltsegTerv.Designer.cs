namespace Szakdolgozat
{
    partial class FormKoltsegTerv
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
            this.dataGridViewKoltsegTerv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPalyazatAZ = new System.Windows.Forms.TextBox();
            this.textBoxOsszeg = new System.Windows.Forms.TextBox();
            this.textBoxModositottOsszeg = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxKoltsegTipus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoltsegTerv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKoltsegTerv
            // 
            this.dataGridViewKoltsegTerv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKoltsegTerv.Location = new System.Drawing.Point(42, 159);
            this.dataGridViewKoltsegTerv.Name = "dataGridViewKoltsegTerv";
            this.dataGridViewKoltsegTerv.Size = new System.Drawing.Size(516, 182);
            this.dataGridViewKoltsegTerv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pályázat azonosító:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Költség típus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(322, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Módosított összeg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(39, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Összeg:";
            // 
            // textBoxPalyazatAZ
            // 
            this.textBoxPalyazatAZ.Enabled = false;
            this.textBoxPalyazatAZ.Location = new System.Drawing.Point(175, 24);
            this.textBoxPalyazatAZ.Name = "textBoxPalyazatAZ";
            this.textBoxPalyazatAZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxPalyazatAZ.TabIndex = 5;
            // 
            // textBoxOsszeg
            // 
            this.textBoxOsszeg.Location = new System.Drawing.Point(175, 116);
            this.textBoxOsszeg.Name = "textBoxOsszeg";
            this.textBoxOsszeg.Size = new System.Drawing.Size(100, 20);
            this.textBoxOsszeg.TabIndex = 7;
            // 
            // textBoxModositottOsszeg
            // 
            this.textBoxModositottOsszeg.Location = new System.Drawing.Point(457, 24);
            this.textBoxModositottOsszeg.Name = "textBoxModositottOsszeg";
            this.textBoxModositottOsszeg.Size = new System.Drawing.Size(100, 20);
            this.textBoxModositottOsszeg.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button3.Location = new System.Drawing.Point(317, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Hozzáad";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.Location = new System.Drawing.Point(457, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Módosít";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(389, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Töröl";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxKoltsegTipus
            // 
            this.comboBoxKoltsegTipus.FormattingEnabled = true;
            this.comboBoxKoltsegTipus.Location = new System.Drawing.Point(175, 71);
            this.comboBoxKoltsegTipus.Name = "comboBoxKoltsegTipus";
            this.comboBoxKoltsegTipus.Size = new System.Drawing.Size(100, 21);
            this.comboBoxKoltsegTipus.TabIndex = 24;
            // 
            // FormKoltsegTerv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 370);
            this.Controls.Add(this.comboBoxKoltsegTipus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxModositottOsszeg);
            this.Controls.Add(this.textBoxOsszeg);
            this.Controls.Add(this.textBoxPalyazatAZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKoltsegTerv);
            this.Name = "FormKoltsegTerv";
            this.Text = "FormKoltsegTerv";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoltsegTerv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKoltsegTerv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPalyazatAZ;
        private System.Windows.Forms.TextBox textBoxOsszeg;
        private System.Windows.Forms.TextBox textBoxModositottOsszeg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxKoltsegTipus;
    }
}