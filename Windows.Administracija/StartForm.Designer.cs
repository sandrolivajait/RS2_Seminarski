namespace Windows.Administracija
{
    partial class StartForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mobiteliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naruzbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.narudzbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mobiteliToolStripMenuItem,
            this.naruzbeToolStripMenuItem,
            this.narudzbeToolStripMenuItem,
            this.reportiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mobiteliToolStripMenuItem
            // 
            this.mobiteliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.dodavanjeToolStripMenuItem});
            this.mobiteliToolStripMenuItem.Name = "mobiteliToolStripMenuItem";
            this.mobiteliToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.mobiteliToolStripMenuItem.Text = "Mobiteli";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // dodavanjeToolStripMenuItem
            // 
            this.dodavanjeToolStripMenuItem.Name = "dodavanjeToolStripMenuItem";
            this.dodavanjeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodavanjeToolStripMenuItem.Text = "Dodavanje";
            // 
            // naruzbeToolStripMenuItem
            // 
            this.naruzbeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem1});
            this.naruzbeToolStripMenuItem.Name = "naruzbeToolStripMenuItem";
            this.naruzbeToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.naruzbeToolStripMenuItem.Text = "Kupci";
            // 
            // pretragaToolStripMenuItem1
            // 
            this.pretragaToolStripMenuItem1.Name = "pretragaToolStripMenuItem1";
            this.pretragaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.pretragaToolStripMenuItem1.Text = "Pretraga";
            // 
            // narudzbeToolStripMenuItem
            // 
            this.narudzbeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem2});
            this.narudzbeToolStripMenuItem.Name = "narudzbeToolStripMenuItem";
            this.narudzbeToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.narudzbeToolStripMenuItem.Text = "Narudzbe";
            // 
            // pretragaToolStripMenuItem2
            // 
            this.pretragaToolStripMenuItem2.Name = "pretragaToolStripMenuItem2";
            this.pretragaToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.pretragaToolStripMenuItem2.Text = "Pretraga";
            // 
            // reportiToolStripMenuItem
            // 
            this.reportiToolStripMenuItem.Name = "reportiToolStripMenuItem";
            this.reportiToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportiToolStripMenuItem.Text = "Reporti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mobiteliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naruzbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem narudzbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reportiToolStripMenuItem;
    }
}

