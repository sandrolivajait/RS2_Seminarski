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
            this.kvarBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.kvarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kvarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kvarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kvarBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewKvarovi = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumKvaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisKvaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeKvaraIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivMobitelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojMobitelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeKupcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupacIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvarBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKvarovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // kvarBindingSource4
            // 
            this.kvarBindingSource4.DataSource = typeof(Model.Models.Kvar);
            // 
            // kvarBindingSource
            // 
            this.kvarBindingSource.DataSource = typeof(Model.Models.Kvar);
            // 
            // kvarBindingSource1
            // 
            this.kvarBindingSource1.DataSource = typeof(Model.Models.Kvar);
            // 
            // kvarBindingSource2
            // 
            this.kvarBindingSource2.DataSource = typeof(Model.Models.Kvar);
            // 
            // kvarBindingSource3
            // 
            this.kvarBindingSource3.DataSource = typeof(Model.Models.Kvar);
            // 
            // dataGridViewKvarovi
            // 
            this.dataGridViewKvarovi.AutoGenerateColumns = false;
            this.dataGridViewKvarovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKvarovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKvarovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datumKvaraDataGridViewTextBoxColumn,
            this.opisKvaraDataGridViewTextBoxColumn,
            this.stanjeKvaraIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.nazivMobitelaDataGridViewTextBoxColumn,
            this.brojMobitelaDataGridViewTextBoxColumn,
            this.imeKupcaDataGridViewTextBoxColumn,
            this.kupacIdDataGridViewTextBoxColumn});
            this.dataGridViewKvarovi.DataSource = this.kvarBindingSource5;
            this.dataGridViewKvarovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKvarovi.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKvarovi.Name = "dataGridViewKvarovi";
            this.dataGridViewKvarovi.RowHeadersWidth = 51;
            this.dataGridViewKvarovi.RowTemplate.Height = 24;
            this.dataGridViewKvarovi.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewKvarovi.TabIndex = 0;
            this.dataGridViewKvarovi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKvarovi_CellDoubleClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumKvaraDataGridViewTextBoxColumn
            // 
            this.datumKvaraDataGridViewTextBoxColumn.DataPropertyName = "DatumKvara";
            this.datumKvaraDataGridViewTextBoxColumn.HeaderText = "DatumKvara";
            this.datumKvaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumKvaraDataGridViewTextBoxColumn.Name = "datumKvaraDataGridViewTextBoxColumn";
            // 
            // opisKvaraDataGridViewTextBoxColumn
            // 
            this.opisKvaraDataGridViewTextBoxColumn.DataPropertyName = "OpisKvara";
            this.opisKvaraDataGridViewTextBoxColumn.HeaderText = "OpisKvara";
            this.opisKvaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisKvaraDataGridViewTextBoxColumn.Name = "opisKvaraDataGridViewTextBoxColumn";
            // 
            // stanjeKvaraIdDataGridViewTextBoxColumn
            // 
            this.stanjeKvaraIdDataGridViewTextBoxColumn.DataPropertyName = "StanjeKvaraId";
            this.stanjeKvaraIdDataGridViewTextBoxColumn.HeaderText = "StanjeKvaraId";
            this.stanjeKvaraIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stanjeKvaraIdDataGridViewTextBoxColumn.Name = "stanjeKvaraIdDataGridViewTextBoxColumn";
            this.stanjeKvaraIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StanjeKvara";
            this.dataGridViewTextBoxColumn1.HeaderText = "StanjeKvara";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // nazivMobitelaDataGridViewTextBoxColumn
            // 
            this.nazivMobitelaDataGridViewTextBoxColumn.DataPropertyName = "NazivMobitela";
            this.nazivMobitelaDataGridViewTextBoxColumn.HeaderText = "NazivMobitela";
            this.nazivMobitelaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivMobitelaDataGridViewTextBoxColumn.Name = "nazivMobitelaDataGridViewTextBoxColumn";
            // 
            // brojMobitelaDataGridViewTextBoxColumn
            // 
            this.brojMobitelaDataGridViewTextBoxColumn.DataPropertyName = "BrojMobitela";
            this.brojMobitelaDataGridViewTextBoxColumn.HeaderText = "BrojMobitela";
            this.brojMobitelaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojMobitelaDataGridViewTextBoxColumn.Name = "brojMobitelaDataGridViewTextBoxColumn";
            // 
            // imeKupcaDataGridViewTextBoxColumn
            // 
            this.imeKupcaDataGridViewTextBoxColumn.DataPropertyName = "ImeKupca";
            this.imeKupcaDataGridViewTextBoxColumn.HeaderText = "ImeKupca";
            this.imeKupcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeKupcaDataGridViewTextBoxColumn.Name = "imeKupcaDataGridViewTextBoxColumn";
            // 
            // kupacIdDataGridViewTextBoxColumn
            // 
            this.kupacIdDataGridViewTextBoxColumn.DataPropertyName = "KupacId";
            this.kupacIdDataGridViewTextBoxColumn.HeaderText = "KupacId";
            this.kupacIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kupacIdDataGridViewTextBoxColumn.Name = "kupacIdDataGridViewTextBoxColumn";
            this.kupacIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // kvarBindingSource5
            // 
            this.kvarBindingSource5.DataSource = typeof(Model.Models.Kvar);
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
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKvarovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeKvaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kvarBindingSource;
        private System.Windows.Forms.BindingSource kvarBindingSource1;
        private System.Windows.Forms.BindingSource kvarBindingSource3;
        private System.Windows.Forms.BindingSource kvarBindingSource2;
        private System.Windows.Forms.BindingSource kvarBindingSource4;
        private System.Windows.Forms.DataGridView dataGridViewKvarovi;
        private System.Windows.Forms.BindingSource kvarBindingSource5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumKvaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisKvaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeKvaraIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivMobitelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojMobitelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeKupcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupacIdDataGridViewTextBoxColumn;
    }
}