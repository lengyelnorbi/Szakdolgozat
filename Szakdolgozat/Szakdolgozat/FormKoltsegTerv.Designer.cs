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
            this.textBoxKoltsegTipus = new System.Windows.Forms.TextBox();
            this.textBoxOsszeg = new System.Windows.Forms.TextBox();
            this.textBoxModositottOsszeg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoltsegTerv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKoltsegTerv
            // 
            this.dataGridViewKoltsegTerv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKoltsegTerv.Location = new System.Drawing.Point(37, 115);
            this.dataGridViewKoltsegTerv.Name = "dataGridViewKoltsegTerv";
            this.dataGridViewKoltsegTerv.Size = new System.Drawing.Size(439, 150);
            this.dataGridViewKoltsegTerv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pályázat azonosító:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Költség típus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Módosított összeg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Összeg:";
            // 
            // textBoxPalyazatAZ
            // 
            this.textBoxPalyazatAZ.Location = new System.Drawing.Point(137, 32);
            this.textBoxPalyazatAZ.Name = "textBoxPalyazatAZ";
            this.textBoxPalyazatAZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxPalyazatAZ.TabIndex = 5;
            // 
            // textBoxKoltsegTipus
            // 
            this.textBoxKoltsegTipus.Location = new System.Drawing.Point(137, 70);
            this.textBoxKoltsegTipus.Name = "textBoxKoltsegTipus";
            this.textBoxKoltsegTipus.Size = new System.Drawing.Size(100, 20);
            this.textBoxKoltsegTipus.TabIndex = 6;
            // 
            // textBoxOsszeg
            // 
            this.textBoxOsszeg.Location = new System.Drawing.Point(376, 32);
            this.textBoxOsszeg.Name = "textBoxOsszeg";
            this.textBoxOsszeg.Size = new System.Drawing.Size(100, 20);
            this.textBoxOsszeg.TabIndex = 7;
            // 
            // textBoxModositottOsszeg
            // 
            this.textBoxModositottOsszeg.Location = new System.Drawing.Point(376, 73);
            this.textBoxModositottOsszeg.Name = "textBoxModositottOsszeg";
            this.textBoxModositottOsszeg.Size = new System.Drawing.Size(100, 20);
            this.textBoxModositottOsszeg.TabIndex = 8;
            // 
            // FormKoltsegTerv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 310);
            this.Controls.Add(this.textBoxModositottOsszeg);
            this.Controls.Add(this.textBoxOsszeg);
            this.Controls.Add(this.textBoxKoltsegTipus);
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
        private System.Windows.Forms.TextBox textBoxKoltsegTipus;
        private System.Windows.Forms.TextBox textBoxOsszeg;
        private System.Windows.Forms.TextBox textBoxModositottOsszeg;
    }
}