namespace Windows.Administracija.Administratori
{
    partial class frmNarudzbe
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
            this.dataGridViewZavrsene = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNezavrsene = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.narudzbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnaCijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupacIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimeKupcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kantonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postanskiBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narucenoStavkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnaCijenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktTelefonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupacIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimeKupcaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kantonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postanskiBrojDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narucenoStavkiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZavrsene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNezavrsene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZavrsene
            // 
            this.dataGridViewZavrsene.AllowUserToAddRows = false;
            this.dataGridViewZavrsene.AllowUserToDeleteRows = false;
            this.dataGridViewZavrsene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewZavrsene.AutoGenerateColumns = false;
            this.dataGridViewZavrsene.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewZavrsene.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewZavrsene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZavrsene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.ukupnaCijenaDataGridViewTextBoxColumn1,
            this.datumDataGridViewTextBoxColumn1,
            this.stanjeDataGridViewTextBoxColumn1,
            this.kontaktTelefonDataGridViewTextBoxColumn1,
            this.kupacIdDataGridViewTextBoxColumn1,
            this.imePrezimeKupcaDataGridViewTextBoxColumn1,
            this.opcinaDataGridViewTextBoxColumn1,
            this.kantonDataGridViewTextBoxColumn1,
            this.postanskiBrojDataGridViewTextBoxColumn1,
            this.ulicaDataGridViewTextBoxColumn1,
            this.narucenoStavkiDataGridViewTextBoxColumn1});
            this.dataGridViewZavrsene.DataSource = this.narudzbaBindingSource1;
            this.dataGridViewZavrsene.Location = new System.Drawing.Point(12, 458);
            this.dataGridViewZavrsene.Name = "dataGridViewZavrsene";
            this.dataGridViewZavrsene.ReadOnly = true;
            this.dataGridViewZavrsene.RowHeadersWidth = 51;
            this.dataGridViewZavrsene.RowTemplate.Height = 24;
            this.dataGridViewZavrsene.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZavrsene.Size = new System.Drawing.Size(1749, 433);
            this.dataGridViewZavrsene.TabIndex = 0;
            this.dataGridViewZavrsene.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdministratori_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zavrsene";
            // 
            // dataGridViewNezavrsene
            // 
            this.dataGridViewNezavrsene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNezavrsene.AutoGenerateColumns = false;
            this.dataGridViewNezavrsene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNezavrsene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ukupnaCijenaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.stanjeDataGridViewTextBoxColumn,
            this.kontaktTelefonDataGridViewTextBoxColumn,
            this.kupacIdDataGridViewTextBoxColumn,
            this.imePrezimeKupcaDataGridViewTextBoxColumn,
            this.opcinaDataGridViewTextBoxColumn,
            this.kantonDataGridViewTextBoxColumn,
            this.postanskiBrojDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.narucenoStavkiDataGridViewTextBoxColumn});
            this.dataGridViewNezavrsene.DataSource = this.narudzbaBindingSource;
            this.dataGridViewNezavrsene.Location = new System.Drawing.Point(12, 37);
            this.dataGridViewNezavrsene.Name = "dataGridViewNezavrsene";
            this.dataGridViewNezavrsene.RowHeadersWidth = 51;
            this.dataGridViewNezavrsene.RowTemplate.Height = 24;
            this.dataGridViewNezavrsene.Size = new System.Drawing.Size(1749, 395);
            this.dataGridViewNezavrsene.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nezavrsene";
            // 
            // narudzbaBindingSource
            // 
            this.narudzbaBindingSource.DataSource = typeof(Model.Models.Narudzba);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // ukupnaCijenaDataGridViewTextBoxColumn
            // 
            this.ukupnaCijenaDataGridViewTextBoxColumn.DataPropertyName = "UkupnaCijena";
            this.ukupnaCijenaDataGridViewTextBoxColumn.HeaderText = "UkupnaCijena";
            this.ukupnaCijenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ukupnaCijenaDataGridViewTextBoxColumn.Name = "ukupnaCijenaDataGridViewTextBoxColumn";
            this.ukupnaCijenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 125;
            // 
            // stanjeDataGridViewTextBoxColumn
            // 
            this.stanjeDataGridViewTextBoxColumn.DataPropertyName = "Stanje";
            this.stanjeDataGridViewTextBoxColumn.HeaderText = "Stanje";
            this.stanjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stanjeDataGridViewTextBoxColumn.Name = "stanjeDataGridViewTextBoxColumn";
            this.stanjeDataGridViewTextBoxColumn.Width = 125;
            // 
            // kontaktTelefonDataGridViewTextBoxColumn
            // 
            this.kontaktTelefonDataGridViewTextBoxColumn.DataPropertyName = "KontaktTelefon";
            this.kontaktTelefonDataGridViewTextBoxColumn.HeaderText = "KontaktTelefon";
            this.kontaktTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kontaktTelefonDataGridViewTextBoxColumn.Name = "kontaktTelefonDataGridViewTextBoxColumn";
            this.kontaktTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // kupacIdDataGridViewTextBoxColumn
            // 
            this.kupacIdDataGridViewTextBoxColumn.DataPropertyName = "KupacId";
            this.kupacIdDataGridViewTextBoxColumn.HeaderText = "KupacId";
            this.kupacIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kupacIdDataGridViewTextBoxColumn.Name = "kupacIdDataGridViewTextBoxColumn";
            this.kupacIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // imePrezimeKupcaDataGridViewTextBoxColumn
            // 
            this.imePrezimeKupcaDataGridViewTextBoxColumn.DataPropertyName = "ImePrezimeKupca";
            this.imePrezimeKupcaDataGridViewTextBoxColumn.HeaderText = "ImePrezimeKupca";
            this.imePrezimeKupcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imePrezimeKupcaDataGridViewTextBoxColumn.Name = "imePrezimeKupcaDataGridViewTextBoxColumn";
            this.imePrezimeKupcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // opcinaDataGridViewTextBoxColumn
            // 
            this.opcinaDataGridViewTextBoxColumn.DataPropertyName = "Opcina";
            this.opcinaDataGridViewTextBoxColumn.HeaderText = "Opcina";
            this.opcinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opcinaDataGridViewTextBoxColumn.Name = "opcinaDataGridViewTextBoxColumn";
            this.opcinaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kantonDataGridViewTextBoxColumn
            // 
            this.kantonDataGridViewTextBoxColumn.DataPropertyName = "Kanton";
            this.kantonDataGridViewTextBoxColumn.HeaderText = "Kanton";
            this.kantonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kantonDataGridViewTextBoxColumn.Name = "kantonDataGridViewTextBoxColumn";
            this.kantonDataGridViewTextBoxColumn.Width = 125;
            // 
            // postanskiBrojDataGridViewTextBoxColumn
            // 
            this.postanskiBrojDataGridViewTextBoxColumn.DataPropertyName = "PostanskiBroj";
            this.postanskiBrojDataGridViewTextBoxColumn.HeaderText = "PostanskiBroj";
            this.postanskiBrojDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postanskiBrojDataGridViewTextBoxColumn.Name = "postanskiBrojDataGridViewTextBoxColumn";
            this.postanskiBrojDataGridViewTextBoxColumn.Width = 125;
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            this.ulicaDataGridViewTextBoxColumn.Width = 125;
            // 
            // narucenoStavkiDataGridViewTextBoxColumn
            // 
            this.narucenoStavkiDataGridViewTextBoxColumn.DataPropertyName = "NarucenoStavki";
            this.narucenoStavkiDataGridViewTextBoxColumn.HeaderText = "NarucenoStavki";
            this.narucenoStavkiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.narucenoStavkiDataGridViewTextBoxColumn.Name = "narucenoStavkiDataGridViewTextBoxColumn";
            this.narucenoStavkiDataGridViewTextBoxColumn.Width = 125;
            // 
            // narudzbaBindingSource1
            // 
            this.narudzbaBindingSource1.DataSource = typeof(Model.Models.Narudzba);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ukupnaCijenaDataGridViewTextBoxColumn1
            // 
            this.ukupnaCijenaDataGridViewTextBoxColumn1.DataPropertyName = "UkupnaCijena";
            this.ukupnaCijenaDataGridViewTextBoxColumn1.HeaderText = "UkupnaCijena";
            this.ukupnaCijenaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ukupnaCijenaDataGridViewTextBoxColumn1.Name = "ukupnaCijenaDataGridViewTextBoxColumn1";
            this.ukupnaCijenaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn1
            // 
            this.datumDataGridViewTextBoxColumn1.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn1.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.datumDataGridViewTextBoxColumn1.Name = "datumDataGridViewTextBoxColumn1";
            this.datumDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stanjeDataGridViewTextBoxColumn1
            // 
            this.stanjeDataGridViewTextBoxColumn1.DataPropertyName = "Stanje";
            this.stanjeDataGridViewTextBoxColumn1.HeaderText = "Stanje";
            this.stanjeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stanjeDataGridViewTextBoxColumn1.Name = "stanjeDataGridViewTextBoxColumn1";
            this.stanjeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kontaktTelefonDataGridViewTextBoxColumn1
            // 
            this.kontaktTelefonDataGridViewTextBoxColumn1.DataPropertyName = "KontaktTelefon";
            this.kontaktTelefonDataGridViewTextBoxColumn1.HeaderText = "KontaktTelefon";
            this.kontaktTelefonDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kontaktTelefonDataGridViewTextBoxColumn1.Name = "kontaktTelefonDataGridViewTextBoxColumn1";
            this.kontaktTelefonDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kupacIdDataGridViewTextBoxColumn1
            // 
            this.kupacIdDataGridViewTextBoxColumn1.DataPropertyName = "KupacId";
            this.kupacIdDataGridViewTextBoxColumn1.HeaderText = "KupacId";
            this.kupacIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kupacIdDataGridViewTextBoxColumn1.Name = "kupacIdDataGridViewTextBoxColumn1";
            this.kupacIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // imePrezimeKupcaDataGridViewTextBoxColumn1
            // 
            this.imePrezimeKupcaDataGridViewTextBoxColumn1.DataPropertyName = "ImePrezimeKupca";
            this.imePrezimeKupcaDataGridViewTextBoxColumn1.HeaderText = "ImePrezimeKupca";
            this.imePrezimeKupcaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.imePrezimeKupcaDataGridViewTextBoxColumn1.Name = "imePrezimeKupcaDataGridViewTextBoxColumn1";
            this.imePrezimeKupcaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // opcinaDataGridViewTextBoxColumn1
            // 
            this.opcinaDataGridViewTextBoxColumn1.DataPropertyName = "Opcina";
            this.opcinaDataGridViewTextBoxColumn1.HeaderText = "Opcina";
            this.opcinaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.opcinaDataGridViewTextBoxColumn1.Name = "opcinaDataGridViewTextBoxColumn1";
            this.opcinaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kantonDataGridViewTextBoxColumn1
            // 
            this.kantonDataGridViewTextBoxColumn1.DataPropertyName = "Kanton";
            this.kantonDataGridViewTextBoxColumn1.HeaderText = "Kanton";
            this.kantonDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kantonDataGridViewTextBoxColumn1.Name = "kantonDataGridViewTextBoxColumn1";
            this.kantonDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // postanskiBrojDataGridViewTextBoxColumn1
            // 
            this.postanskiBrojDataGridViewTextBoxColumn1.DataPropertyName = "PostanskiBroj";
            this.postanskiBrojDataGridViewTextBoxColumn1.HeaderText = "PostanskiBroj";
            this.postanskiBrojDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.postanskiBrojDataGridViewTextBoxColumn1.Name = "postanskiBrojDataGridViewTextBoxColumn1";
            this.postanskiBrojDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ulicaDataGridViewTextBoxColumn1
            // 
            this.ulicaDataGridViewTextBoxColumn1.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn1.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ulicaDataGridViewTextBoxColumn1.Name = "ulicaDataGridViewTextBoxColumn1";
            this.ulicaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // narucenoStavkiDataGridViewTextBoxColumn1
            // 
            this.narucenoStavkiDataGridViewTextBoxColumn1.DataPropertyName = "NarucenoStavki";
            this.narucenoStavkiDataGridViewTextBoxColumn1.HeaderText = "NarucenoStavki";
            this.narucenoStavkiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.narucenoStavkiDataGridViewTextBoxColumn1.Name = "narucenoStavkiDataGridViewTextBoxColumn1";
            this.narucenoStavkiDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // frmNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 903);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewNezavrsene);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewZavrsene);
            this.Name = "frmNarudzbe";
            this.Text = "Narudzbe";
            this.Load += new System.EventHandler(this.frmNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZavrsene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNezavrsene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZavrsene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNezavrsene;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnaCijenaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktTelefonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupacIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeKupcaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kantonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn postanskiBrojDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn narucenoStavkiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource narudzbaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnaCijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupacIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeKupcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kantonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postanskiBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narucenoStavkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource narudzbaBindingSource;
    }
}