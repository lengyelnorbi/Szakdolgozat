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
            this.textBoxTervezettOsszeg = new System.Windows.Forms.TextBox();
            this.textBoxModositottOsszeg = new System.Windows.Forms.TextBox();
            this.buttonUjKoltsegTervForm = new System.Windows.Forms.Button();
            this.buttonKoltsegTervModositForm = new System.Windows.Forms.Button();
            this.buttonKoltsegTervTorol = new System.Windows.Forms.Button();
            this.buttonVissza = new System.Windows.Forms.Button();
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
            this.label1.TabIndex = 8;
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
            this.label3.TabIndex = 5;
            this.label3.Text = "Módosított összeg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(39, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tervezett összeg:";
            // 
            // textBoxPalyazatAZ
            // 
            this.textBoxPalyazatAZ.Enabled = false;
            this.textBoxPalyazatAZ.Location = new System.Drawing.Point(175, 24);
            this.textBoxPalyazatAZ.Name = "textBoxPalyazatAZ";
            this.textBoxPalyazatAZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxPalyazatAZ.TabIndex = 4;
            // 
            // textBoxTervezettOsszeg
            // 
            this.textBoxTervezettOsszeg.Enabled = false;
            this.textBoxTervezettOsszeg.Location = new System.Drawing.Point(175, 116);
            this.textBoxTervezettOsszeg.Name = "textBoxTervezettOsszeg";
            this.textBoxTervezettOsszeg.Size = new System.Drawing.Size(100, 20);
            this.textBoxTervezettOsszeg.TabIndex = 1;
            // 
            // textBoxModositottOsszeg
            // 
            this.textBoxModositottOsszeg.Enabled = false;
            this.textBoxModositottOsszeg.Location = new System.Drawing.Point(457, 24);
            this.textBoxModositottOsszeg.Name = "textBoxModositottOsszeg";
            this.textBoxModositottOsszeg.Size = new System.Drawing.Size(100, 20);
            this.textBoxModositottOsszeg.TabIndex = 2;
            // 
            // buttonUjKoltsegTervForm
            // 
            this.buttonUjKoltsegTervForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonUjKoltsegTervForm.Location = new System.Drawing.Point(317, 69);
            this.buttonUjKoltsegTervForm.Name = "buttonUjKoltsegTervForm";
            this.buttonUjKoltsegTervForm.Size = new System.Drawing.Size(98, 23);
            this.buttonUjKoltsegTervForm.TabIndex = 23;
            this.buttonUjKoltsegTervForm.Text = "Hozzáad";
            this.buttonUjKoltsegTervForm.UseVisualStyleBackColor = true;
            this.buttonUjKoltsegTervForm.Click += new System.EventHandler(this.buttonUjKoltsegTervForm_Click);
            // 
            // buttonKoltsegTervModositForm
            // 
            this.buttonKoltsegTervModositForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonKoltsegTervModositForm.Location = new System.Drawing.Point(457, 69);
            this.buttonKoltsegTervModositForm.Name = "buttonKoltsegTervModositForm";
            this.buttonKoltsegTervModositForm.Size = new System.Drawing.Size(98, 23);
            this.buttonKoltsegTervModositForm.TabIndex = 22;
            this.buttonKoltsegTervModositForm.Text = "Módosít";
            this.buttonKoltsegTervModositForm.UseVisualStyleBackColor = true;
            this.buttonKoltsegTervModositForm.Click += new System.EventHandler(this.buttonKoltsegTervModositForm_Click);
            // 
            // buttonKoltsegTervTorol
            // 
            this.buttonKoltsegTervTorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonKoltsegTervTorol.Location = new System.Drawing.Point(317, 116);
            this.buttonKoltsegTervTorol.Name = "buttonKoltsegTervTorol";
            this.buttonKoltsegTervTorol.Size = new System.Drawing.Size(98, 23);
            this.buttonKoltsegTervTorol.TabIndex = 21;
            this.buttonKoltsegTervTorol.Text = "Töröl";
            this.buttonKoltsegTervTorol.UseVisualStyleBackColor = true;
            this.buttonKoltsegTervTorol.Click += new System.EventHandler(this.buttonKoltsegTervTorol_Click);
            // 
            // buttonVissza
            // 
            this.buttonVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonVissza.Location = new System.Drawing.Point(457, 116);
            this.buttonVissza.Name = "buttonVissza";
            this.buttonVissza.Size = new System.Drawing.Size(98, 23);
            this.buttonVissza.TabIndex = 25;
            this.buttonVissza.Text = "Vissza";
            this.buttonVissza.UseVisualStyleBackColor = true;
            this.buttonVissza.Click += new System.EventHandler(this.buttonVissza_Click);
            // 
            // comboBoxKoltsegTipus
            // 
            this.comboBoxKoltsegTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKoltsegTipus.Enabled = false;
            this.comboBoxKoltsegTipus.FormattingEnabled = true;
            this.comboBoxKoltsegTipus.Items.AddRange(new object[] {
            "Bérköltség",
            "Járulék",
            "Szakmai anyag",
            "Szolgáltatás",
            "Rezsi",
            "Tárgyi eszköz",
            "Beruházás/Felújítás"});
            this.comboBoxKoltsegTipus.Location = new System.Drawing.Point(175, 71);
            this.comboBoxKoltsegTipus.Name = "comboBoxKoltsegTipus";
            this.comboBoxKoltsegTipus.Size = new System.Drawing.Size(100, 21);
            this.comboBoxKoltsegTipus.TabIndex = 0;
            // 
            // FormKoltsegTerv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(592, 370);
            this.Controls.Add(this.comboBoxKoltsegTipus);
            this.Controls.Add(this.buttonVissza);
            this.Controls.Add(this.buttonUjKoltsegTervForm);
            this.Controls.Add(this.buttonKoltsegTervModositForm);
            this.Controls.Add(this.buttonKoltsegTervTorol);
            this.Controls.Add(this.textBoxModositottOsszeg);
            this.Controls.Add(this.textBoxTervezettOsszeg);
            this.Controls.Add(this.textBoxPalyazatAZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKoltsegTerv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKoltsegTerv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.Load += new System.EventHandler(this.FormKoltsegTerv_Load);
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
        private System.Windows.Forms.TextBox textBoxTervezettOsszeg;
        private System.Windows.Forms.TextBox textBoxModositottOsszeg;
        private System.Windows.Forms.Button buttonUjKoltsegTervForm;
        private System.Windows.Forms.Button buttonKoltsegTervModositForm;
        private System.Windows.Forms.Button buttonKoltsegTervTorol;
        private System.Windows.Forms.Button buttonVissza;
        private System.Windows.Forms.ComboBox comboBoxKoltsegTipus;
    }
}