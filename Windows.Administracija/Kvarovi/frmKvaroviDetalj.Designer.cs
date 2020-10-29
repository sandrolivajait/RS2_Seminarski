namespace Windows.Administracija.Kvarovi
{
    partial class frmKvaroviDetalj
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
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxOpis = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStanjeKvara = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBrojMobitela = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNazivMobitela = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxImeKupca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDatum
            // 
            this.textBoxDatum.Enabled = false;
            this.textBoxDatum.Location = new System.Drawing.Point(158, 62);
            this.textBoxDatum.Name = "textBoxDatum";
            this.textBoxDatum.Size = new System.Drawing.Size(406, 22);
            this.textBoxDatum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum";
            // 
            // richTextBoxOpis
            // 
            this.richTextBoxOpis.Enabled = false;
            this.richTextBoxOpis.Location = new System.Drawing.Point(158, 104);
            this.richTextBoxOpis.Name = "richTextBoxOpis";
            this.richTextBoxOpis.Size = new System.Drawing.Size(406, 167);
            this.richTextBoxOpis.TabIndex = 2;
            this.richTextBoxOpis.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis";
            // 
            // comboBoxStanjeKvara
            // 
            this.comboBoxStanjeKvara.FormattingEnabled = true;
            this.comboBoxStanjeKvara.Location = new System.Drawing.Point(158, 28);
            this.comboBoxStanjeKvara.Name = "comboBoxStanjeKvara";
            this.comboBoxStanjeKvara.Size = new System.Drawing.Size(406, 24);
            this.comboBoxStanjeKvara.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stanje Kvara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Broj Mobitela";
            // 
            // textBoxBrojMobitela
            // 
            this.textBoxBrojMobitela.Enabled = false;
            this.textBoxBrojMobitela.Location = new System.Drawing.Point(158, 291);
            this.textBoxBrojMobitela.Name = "textBoxBrojMobitela";
            this.textBoxBrojMobitela.Size = new System.Drawing.Size(406, 22);
            this.textBoxBrojMobitela.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Naziv mobitela";
            // 
            // textBoxNazivMobitela
            // 
            this.textBoxNazivMobitela.Enabled = false;
            this.textBoxNazivMobitela.Location = new System.Drawing.Point(158, 338);
            this.textBoxNazivMobitela.Name = "textBoxNazivMobitela";
            this.textBoxNazivMobitela.Size = new System.Drawing.Size(406, 22);
            this.textBoxNazivMobitela.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ime kupca";
            // 
            // textBoxImeKupca
            // 
            this.textBoxImeKupca.Enabled = false;
            this.textBoxImeKupca.Location = new System.Drawing.Point(158, 384);
            this.textBoxImeKupca.Name = "textBoxImeKupca";
            this.textBoxImeKupca.Size = new System.Drawing.Size(406, 22);
            this.textBoxImeKupca.TabIndex = 10;
            // 
            // frmKvaroviDetalj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 443);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxImeKupca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNazivMobitela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBrojMobitela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxStanjeKvara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxOpis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDatum);
            this.Name = "frmKvaroviDetalj";
            this.Text = "Uredi stanje kvara";
            this.Load += new System.EventHandler(this.frmKvaroviDetalj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStanjeKvara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBrojMobitela;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNazivMobitela;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxImeKupca;
    }
}