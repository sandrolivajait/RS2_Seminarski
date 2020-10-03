namespace Windows.Administracija.Mobiteli
{
    partial class frmMobiteli
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
            this.dgvMobiteli = new System.Windows.Forms.DataGridView();
            this.cboxProizvodjaci = new System.Windows.Forms.ComboBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.txtNazivMobitela = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numFromRange = new System.Windows.Forms.NumericUpDown();
            this.numToRange = new System.Windows.Forms.NumericUpDown();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvodjac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdanoKomada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KratkiOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StanjeNaSkladistu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMobiteli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToRange)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMobiteli
            // 
            this.dgvMobiteli.AllowUserToAddRows = false;
            this.dgvMobiteli.AllowUserToDeleteRows = false;
            this.dgvMobiteli.AllowUserToResizeColumns = false;
            this.dgvMobiteli.AllowUserToResizeRows = false;
            this.dgvMobiteli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMobiteli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMobiteli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMobiteli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMobiteli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Proizvodjac,
            this.Naziv,
            this.Cijena,
            this.ProdanoKomada,
            this.KratkiOpis,
            this.StanjeNaSkladistu,
            this.Popust,
            this.Opis});
            this.dgvMobiteli.Location = new System.Drawing.Point(12, 78);
            this.dgvMobiteli.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMobiteli.Name = "dgvMobiteli";
            this.dgvMobiteli.ReadOnly = true;
            this.dgvMobiteli.RowHeadersWidth = 51;
            this.dgvMobiteli.RowTemplate.Height = 24;
            this.dgvMobiteli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMobiteli.Size = new System.Drawing.Size(776, 360);
            this.dgvMobiteli.TabIndex = 2;
            this.dgvMobiteli.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMobiteli_CellContentDoubleClick);
            // 
            // cboxProizvodjaci
            // 
            this.cboxProizvodjaci.FormattingEnabled = true;
            this.cboxProizvodjaci.Location = new System.Drawing.Point(224, 37);
            this.cboxProizvodjaci.Name = "cboxProizvodjaci";
            this.cboxProizvodjaci.Size = new System.Drawing.Size(198, 24);
            this.cboxProizvodjaci.TabIndex = 3;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(680, 36);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(108, 23);
            this.btnPretraga.TabIndex = 4;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_ClickAsync);
            // 
            // txtNazivMobitela
            // 
            this.txtNazivMobitela.Location = new System.Drawing.Point(12, 38);
            this.txtNazivMobitela.Name = "txtNazivMobitela";
            this.txtNazivMobitela.Size = new System.Drawing.Size(206, 22);
            this.txtNazivMobitela.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv mobitela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Proizvodjac";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cijena Od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cijena Do";
            // 
            // numFromRange
            // 
            this.numFromRange.Location = new System.Drawing.Point(428, 37);
            this.numFromRange.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFromRange.Name = "numFromRange";
            this.numFromRange.Size = new System.Drawing.Size(120, 22);
            this.numFromRange.TabIndex = 10;
            // 
            // numToRange
            // 
            this.numToRange.Location = new System.Drawing.Point(554, 37);
            this.numToRange.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numToRange.Name = "numToRange";
            this.numToRange.Size = new System.Drawing.Size(120, 22);
            this.numToRange.TabIndex = 11;
            this.numToRange.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.DataPropertyName = "Proizvodjac";
            this.Proizvodjac.HeaderText = "Proizvodjac";
            this.Proizvodjac.MinimumWidth = 6;
            this.Proizvodjac.Name = "Proizvodjac";
            this.Proizvodjac.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // ProdanoKomada
            // 
            this.ProdanoKomada.DataPropertyName = "ProdanoKomada";
            this.ProdanoKomada.HeaderText = "ProdanoKomada";
            this.ProdanoKomada.MinimumWidth = 6;
            this.ProdanoKomada.Name = "ProdanoKomada";
            this.ProdanoKomada.ReadOnly = true;
            // 
            // KratkiOpis
            // 
            this.KratkiOpis.DataPropertyName = "KratkiOpis";
            this.KratkiOpis.HeaderText = "KratkiOpis";
            this.KratkiOpis.MinimumWidth = 6;
            this.KratkiOpis.Name = "KratkiOpis";
            this.KratkiOpis.ReadOnly = true;
            // 
            // StanjeNaSkladistu
            // 
            this.StanjeNaSkladistu.DataPropertyName = "StanjeNaSkladistu";
            this.StanjeNaSkladistu.HeaderText = "U skladistu";
            this.StanjeNaSkladistu.MinimumWidth = 6;
            this.StanjeNaSkladistu.Name = "StanjeNaSkladistu";
            this.StanjeNaSkladistu.ReadOnly = true;
            // 
            // Popust
            // 
            this.Popust.DataPropertyName = "KolicinaPopustaDecimalni";
            this.Popust.HeaderText = "Popust";
            this.Popust.MinimumWidth = 6;
            this.Popust.Name = "Popust";
            this.Popust.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // frmMobiteli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numToRange);
            this.Controls.Add(this.numFromRange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazivMobitela);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.cboxProizvodjaci);
            this.Controls.Add(this.dgvMobiteli);
            this.Name = "frmMobiteli";
            this.Text = "frmMobiteli";
            this.Load += new System.EventHandler(this.frmMobiteli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMobiteli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMobiteli;
        private System.Windows.Forms.ComboBox cboxProizvodjaci;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.TextBox txtNazivMobitela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numFromRange;
        private System.Windows.Forms.NumericUpDown numToRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvodjac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdanoKomada;
        private System.Windows.Forms.DataGridViewTextBoxColumn KratkiOpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn StanjeNaSkladistu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Popust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}