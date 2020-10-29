namespace Windows.Administracija.Kvarovi
{
    partial class frmKvarovi
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
            this.dataGridViewKvarovi = new System.Windows.Forms.DataGridView();
            this.datumKvaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisKvaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeKvaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivMobitelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojMobitelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeKupcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupacIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKvarovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKvarovi
            // 
            this.dataGridViewKvarovi.AllowUserToAddRows = false;
            this.dataGridViewKvarovi.AllowUserToDeleteRows = false;
            this.dataGridViewKvarovi.AutoGenerateColumns = false;
            this.dataGridViewKvarovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKvarovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumKvaraDataGridViewTextBoxColumn,
            this.opisKvaraDataGridViewTextBoxColumn,
            this.stanjeKvaraDataGridViewTextBoxColumn,
            this.nazivMobitelaDataGridViewTextBoxColumn,
            this.brojMobitelaDataGridViewTextBoxColumn,
            this.imeKupcaDataGridViewTextBoxColumn,
            this.kupacIdDataGridViewTextBoxColumn});
            this.dataGridViewKvarovi.DataSource = this.kvarBindingSource;
            this.dataGridViewKvarovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKvarovi.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKvarovi.Name = "dataGridViewKvarovi";
            this.dataGridViewKvarovi.RowHeadersWidth = 51;
            this.dataGridViewKvarovi.RowTemplate.Height = 24;
            this.dataGridViewKvarovi.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewKvarovi.TabIndex = 0;
            this.dataGridViewKvarovi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKvarovi_CellDoubleClick);
            // 
            // datumKvaraDataGridViewTextBoxColumn
            // 
            this.datumKvaraDataGridViewTextBoxColumn.DataPropertyName = "DatumKvara";
            this.datumKvaraDataGridViewTextBoxColumn.HeaderText = "DatumKvara";
            this.datumKvaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumKvaraDataGridViewTextBoxColumn.Name = "datumKvaraDataGridViewTextBoxColumn";
            this.datumKvaraDataGridViewTextBoxColumn.Width = 125;
            // 
            // opisKvaraDataGridViewTextBoxColumn
            // 
            this.opisKvaraDataGridViewTextBoxColumn.DataPropertyName = "OpisKvara";
            this.opisKvaraDataGridViewTextBoxColumn.HeaderText = "OpisKvara";
            this.opisKvaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisKvaraDataGridViewTextBoxColumn.Name = "opisKvaraDataGridViewTextBoxColumn";
            this.opisKvaraDataGridViewTextBoxColumn.Width = 125;
            // 
            // stanjeKvaraDataGridViewTextBoxColumn
            // 
            this.stanjeKvaraDataGridViewTextBoxColumn.DataPropertyName = "StanjeKvara";
            this.stanjeKvaraDataGridViewTextBoxColumn.HeaderText = "StanjeKvara";
            this.stanjeKvaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stanjeKvaraDataGridViewTextBoxColumn.Name = "stanjeKvaraDataGridViewTextBoxColumn";
            this.stanjeKvaraDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazivMobitelaDataGridViewTextBoxColumn
            // 
            this.nazivMobitelaDataGridViewTextBoxColumn.DataPropertyName = "NazivMobitela";
            this.nazivMobitelaDataGridViewTextBoxColumn.HeaderText = "NazivMobitela";
            this.nazivMobitelaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivMobitelaDataGridViewTextBoxColumn.Name = "nazivMobitelaDataGridViewTextBoxColumn";
            this.nazivMobitelaDataGridViewTextBoxColumn.Width = 125;
            // 
            // brojMobitelaDataGridViewTextBoxColumn
            // 
            this.brojMobitelaDataGridViewTextBoxColumn.DataPropertyName = "BrojMobitela";
            this.brojMobitelaDataGridViewTextBoxColumn.HeaderText = "BrojMobitela";
            this.brojMobitelaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojMobitelaDataGridViewTextBoxColumn.Name = "brojMobitelaDataGridViewTextBoxColumn";
            this.brojMobitelaDataGridViewTextBoxColumn.Width = 125;
            // 
            // imeKupcaDataGridViewTextBoxColumn
            // 
            this.imeKupcaDataGridViewTextBoxColumn.DataPropertyName = "ImeKupca";
            this.imeKupcaDataGridViewTextBoxColumn.HeaderText = "ImeKupca";
            this.imeKupcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeKupcaDataGridViewTextBoxColumn.Name = "imeKupcaDataGridViewTextBoxColumn";
            this.imeKupcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kupacIdDataGridViewTextBoxColumn
            // 
            this.kupacIdDataGridViewTextBoxColumn.DataPropertyName = "KupacId";
            this.kupacIdDataGridViewTextBoxColumn.HeaderText = "KupacId";
            this.kupacIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kupacIdDataGridViewTextBoxColumn.Name = "kupacIdDataGridViewTextBoxColumn";
            this.kupacIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kvarBindingSource
            // 
            this.kvarBindingSource.DataSource = typeof(Model.Models.Kvar);
            // 
            // frmKvarovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewKvarovi);
            this.Name = "frmKvarovi";
            this.Text = "Kvarovi";
            this.Load += new System.EventHandler(this.frmKvarovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKvarovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKvarovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumKvaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisKvaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeKvaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivMobitelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojMobitelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeKupcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupacIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kvarBindingSource;
    }
}