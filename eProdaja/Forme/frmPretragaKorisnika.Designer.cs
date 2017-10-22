namespace eProdaja.Forme
{
    partial class frmPretragaKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPretragaKorisnika));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.korisnikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Deaktiviraj = new System.Windows.Forms.ToolStripButton();
            this.name = new System.Windows.Forms.ToolStripButton();
            this.izmjeniMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.ličniPodaci = new System.Windows.Forms.ToolStripMenuItem();
            this.statusniPodaci = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnikIDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.korisniciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 232);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // korisnikIDDataGridViewTextBoxColumn
            // 
            this.korisnikIDDataGridViewTextBoxColumn.DataPropertyName = "KorisnikID";
            this.korisnikIDDataGridViewTextBoxColumn.HeaderText = "KorisnikID";
            this.korisnikIDDataGridViewTextBoxColumn.Name = "korisnikIDDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataSource = typeof(eProdajaServis.Data.Korisnici);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretraga po imenu";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Deaktiviraj,
            this.name,
            this.izmjeniMenu,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(13, 49);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(139, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Deaktiviraj
            // 
            this.Deaktiviraj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Deaktiviraj.Image = ((System.Drawing.Image)(resources.GetObject("Deaktiviraj.Image")));
            this.Deaktiviraj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Deaktiviraj.Name = "Deaktiviraj";
            this.Deaktiviraj.Size = new System.Drawing.Size(23, 22);
            this.Deaktiviraj.Text = "Deaktiviraj";
            this.Deaktiviraj.Click += new System.EventHandler(this.Deaktiviraj_Click);
            // 
            // name
            // 
            this.name.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.name.Image = ((System.Drawing.Image)(resources.GetObject("name.Image")));
            this.name.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(23, 22);
            this.name.Text = "Izmjeni";
            // 
            // izmjeniMenu
            // 
            this.izmjeniMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.izmjeniMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ličniPodaci,
            this.statusniPodaci});
            this.izmjeniMenu.Image = ((System.Drawing.Image)(resources.GetObject("izmjeniMenu.Image")));
            this.izmjeniMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.izmjeniMenu.Name = "izmjeniMenu";
            this.izmjeniMenu.Size = new System.Drawing.Size(58, 22);
            this.izmjeniMenu.Text = "Izmjeni";
            this.izmjeniMenu.Click += new System.EventHandler(this.izmjeniMenu_Click);
            // 
            // ličniPodaci
            // 
            this.ličniPodaci.Name = "ličniPodaci";
            this.ličniPodaci.Size = new System.Drawing.Size(154, 22);
            this.ličniPodaci.Text = "Lični podaci";
            this.ličniPodaci.Click += new System.EventHandler(this.ličniPodaci_Click);
            // 
            // statusniPodaci
            // 
            this.statusniPodaci.Name = "statusniPodaci";
            this.statusniPodaci.Size = new System.Drawing.Size(154, 22);
            this.statusniPodaci.Text = "Ukloni podatke";
            this.statusniPodaci.Click += new System.EventHandler(this.statusniPodaci_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Aktiviraj";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmPretragaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 312);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPretragaKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga korisnika";
            this.Load += new System.EventHandler(this.frmPretragaKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton name;
        private System.Windows.Forms.ToolStripDropDownButton izmjeniMenu;
        private System.Windows.Forms.ToolStripMenuItem ličniPodaci;
        private System.Windows.Forms.ToolStripMenuItem statusniPodaci;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private System.Windows.Forms.ToolStripButton Deaktiviraj;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewTextBoxColumn;
    }
}