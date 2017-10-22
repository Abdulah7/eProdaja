namespace eProdaja.Forme
{
    partial class frmPretragaAuta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPretragaAuta));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.ToolStripButton();
            this.izmjeniMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.ličniPodaci = new System.Windows.Forms.ToolStripMenuItem();
            this.statusniPodaci = new System.Windows.Forms.ToolStripMenuItem();
            this.vozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voziloIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaMotoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emisijaCO2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaThumgDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.slikaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snagaMotoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojSasijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zapreminaMotoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zapreminaGepekaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duzinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tezinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojSjedistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pogonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojVrataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisSigurnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mijenjacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potrosnjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrtniMomentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubrzanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maksimalnaBrzinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racuniStavkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 9);
            this.textBox1.MinimumSize = new System.Drawing.Size(4, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voziloIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.godisteDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.vrstaMotoraDataGridViewTextBoxColumn,
            this.emisijaCO2DataGridViewTextBoxColumn,
            this.modelIDDataGridViewTextBoxColumn,
            this.slikaThumgDataGridViewImageColumn,
            this.slikaDataGridViewImageColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.opremaDataGridViewTextBoxColumn,
            this.snagaMotoraDataGridViewTextBoxColumn,
            this.brojSasijeDataGridViewTextBoxColumn,
            this.zapreminaMotoraDataGridViewTextBoxColumn,
            this.zapreminaGepekaDataGridViewTextBoxColumn,
            this.duzinaDataGridViewTextBoxColumn,
            this.tezinaDataGridViewTextBoxColumn,
            this.klimaDataGridViewTextBoxColumn,
            this.brojSjedistaDataGridViewTextBoxColumn,
            this.pogonDataGridViewTextBoxColumn,
            this.brojVrataDataGridViewTextBoxColumn,
            this.opisSigurnostDataGridViewTextBoxColumn,
            this.mijenjacDataGridViewTextBoxColumn,
            this.potrosnjaDataGridViewTextBoxColumn,
            this.obrtniMomentDataGridViewTextBoxColumn,
            this.sirinaDataGridViewTextBoxColumn,
            this.ubrzanjeDataGridViewTextBoxColumn,
            this.maksimalnaBrzinaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.modeliDataGridViewTextBoxColumn,
            this.racuniStavkeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vozilaBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(926, 239);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv auta";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.name,
            this.izmjeniMenu});
            this.toolStrip1.Location = new System.Drawing.Point(24, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(93, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sasija";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(215, 9);
            this.textBox2.MinimumSize = new System.Drawing.Size(4, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // 
            // ličniPodaci
            // 
            this.ličniPodaci.Name = "ličniPodaci";
            this.ličniPodaci.Size = new System.Drawing.Size(154, 22);
            this.ličniPodaci.Text = "Lični podaci";
            this.ličniPodaci.Click += new System.EventHandler(this.Click1);
            // 
            // statusniPodaci
            // 
            this.statusniPodaci.Name = "statusniPodaci";
            this.statusniPodaci.Size = new System.Drawing.Size(154, 22);
            this.statusniPodaci.Text = "Ukloni podatke";
            this.statusniPodaci.Click += new System.EventHandler(this.statusniPodaci_Click);
            // 
            // vozilaBindingSource
            // 
            this.vozilaBindingSource.DataSource = typeof(eProdajaServis.Data.Vozila);
            // 
            // voziloIDDataGridViewTextBoxColumn
            // 
            this.voziloIDDataGridViewTextBoxColumn.DataPropertyName = "VoziloID";
            this.voziloIDDataGridViewTextBoxColumn.HeaderText = "VoziloID";
            this.voziloIDDataGridViewTextBoxColumn.Name = "voziloIDDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // godisteDataGridViewTextBoxColumn
            // 
            this.godisteDataGridViewTextBoxColumn.DataPropertyName = "Godiste";
            this.godisteDataGridViewTextBoxColumn.HeaderText = "Godiste";
            this.godisteDataGridViewTextBoxColumn.Name = "godisteDataGridViewTextBoxColumn";
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "Boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "Boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            // 
            // vrstaMotoraDataGridViewTextBoxColumn
            // 
            this.vrstaMotoraDataGridViewTextBoxColumn.DataPropertyName = "VrstaMotora";
            this.vrstaMotoraDataGridViewTextBoxColumn.HeaderText = "VrstaMotora";
            this.vrstaMotoraDataGridViewTextBoxColumn.Name = "vrstaMotoraDataGridViewTextBoxColumn";
            // 
            // emisijaCO2DataGridViewTextBoxColumn
            // 
            this.emisijaCO2DataGridViewTextBoxColumn.DataPropertyName = "EmisijaCO2";
            this.emisijaCO2DataGridViewTextBoxColumn.HeaderText = "EmisijaCO2";
            this.emisijaCO2DataGridViewTextBoxColumn.Name = "emisijaCO2DataGridViewTextBoxColumn";
            // 
            // modelIDDataGridViewTextBoxColumn
            // 
            this.modelIDDataGridViewTextBoxColumn.DataPropertyName = "ModelID";
            this.modelIDDataGridViewTextBoxColumn.HeaderText = "ModelID";
            this.modelIDDataGridViewTextBoxColumn.Name = "modelIDDataGridViewTextBoxColumn";
            this.modelIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // slikaThumgDataGridViewImageColumn
            // 
            this.slikaThumgDataGridViewImageColumn.DataPropertyName = "SlikaThumg";
            this.slikaThumgDataGridViewImageColumn.HeaderText = "SlikaThumg";
            this.slikaThumgDataGridViewImageColumn.Name = "slikaThumgDataGridViewImageColumn";
            this.slikaThumgDataGridViewImageColumn.Visible = false;
            // 
            // slikaDataGridViewImageColumn
            // 
            this.slikaDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.slikaDataGridViewImageColumn.DataPropertyName = "Slika";
            this.slikaDataGridViewImageColumn.HeaderText = "Pregled slike";
            this.slikaDataGridViewImageColumn.Name = "slikaDataGridViewImageColumn";
            this.slikaDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.slikaDataGridViewImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.slikaDataGridViewImageColumn.Text = "Slika";
            this.slikaDataGridViewImageColumn.UseColumnTextForLinkValue = true;
            this.slikaDataGridViewImageColumn.Width = 92;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // opremaDataGridViewTextBoxColumn
            // 
            this.opremaDataGridViewTextBoxColumn.DataPropertyName = "Oprema";
            this.opremaDataGridViewTextBoxColumn.HeaderText = "Oprema";
            this.opremaDataGridViewTextBoxColumn.Name = "opremaDataGridViewTextBoxColumn";
            // 
            // snagaMotoraDataGridViewTextBoxColumn
            // 
            this.snagaMotoraDataGridViewTextBoxColumn.DataPropertyName = "SnagaMotora";
            this.snagaMotoraDataGridViewTextBoxColumn.HeaderText = "SnagaMotora";
            this.snagaMotoraDataGridViewTextBoxColumn.Name = "snagaMotoraDataGridViewTextBoxColumn";
            // 
            // brojSasijeDataGridViewTextBoxColumn
            // 
            this.brojSasijeDataGridViewTextBoxColumn.DataPropertyName = "BrojSasije";
            this.brojSasijeDataGridViewTextBoxColumn.HeaderText = "BrojSasije";
            this.brojSasijeDataGridViewTextBoxColumn.Name = "brojSasijeDataGridViewTextBoxColumn";
            // 
            // zapreminaMotoraDataGridViewTextBoxColumn
            // 
            this.zapreminaMotoraDataGridViewTextBoxColumn.DataPropertyName = "ZapreminaMotora";
            this.zapreminaMotoraDataGridViewTextBoxColumn.HeaderText = "ZapreminaMotora";
            this.zapreminaMotoraDataGridViewTextBoxColumn.Name = "zapreminaMotoraDataGridViewTextBoxColumn";
            // 
            // zapreminaGepekaDataGridViewTextBoxColumn
            // 
            this.zapreminaGepekaDataGridViewTextBoxColumn.DataPropertyName = "ZapreminaGepeka";
            this.zapreminaGepekaDataGridViewTextBoxColumn.HeaderText = "ZapreminaGepeka";
            this.zapreminaGepekaDataGridViewTextBoxColumn.Name = "zapreminaGepekaDataGridViewTextBoxColumn";
            // 
            // duzinaDataGridViewTextBoxColumn
            // 
            this.duzinaDataGridViewTextBoxColumn.DataPropertyName = "Duzina";
            this.duzinaDataGridViewTextBoxColumn.HeaderText = "Duzina";
            this.duzinaDataGridViewTextBoxColumn.Name = "duzinaDataGridViewTextBoxColumn";
            // 
            // tezinaDataGridViewTextBoxColumn
            // 
            this.tezinaDataGridViewTextBoxColumn.DataPropertyName = "Tezina";
            this.tezinaDataGridViewTextBoxColumn.HeaderText = "Tezina";
            this.tezinaDataGridViewTextBoxColumn.Name = "tezinaDataGridViewTextBoxColumn";
            // 
            // klimaDataGridViewTextBoxColumn
            // 
            this.klimaDataGridViewTextBoxColumn.DataPropertyName = "Klima";
            this.klimaDataGridViewTextBoxColumn.HeaderText = "Klima";
            this.klimaDataGridViewTextBoxColumn.Name = "klimaDataGridViewTextBoxColumn";
            // 
            // brojSjedistaDataGridViewTextBoxColumn
            // 
            this.brojSjedistaDataGridViewTextBoxColumn.DataPropertyName = "BrojSjedista";
            this.brojSjedistaDataGridViewTextBoxColumn.HeaderText = "BrojSjedista";
            this.brojSjedistaDataGridViewTextBoxColumn.Name = "brojSjedistaDataGridViewTextBoxColumn";
            // 
            // pogonDataGridViewTextBoxColumn
            // 
            this.pogonDataGridViewTextBoxColumn.DataPropertyName = "Pogon";
            this.pogonDataGridViewTextBoxColumn.HeaderText = "Pogon";
            this.pogonDataGridViewTextBoxColumn.Name = "pogonDataGridViewTextBoxColumn";
            // 
            // brojVrataDataGridViewTextBoxColumn
            // 
            this.brojVrataDataGridViewTextBoxColumn.DataPropertyName = "BrojVrata";
            this.brojVrataDataGridViewTextBoxColumn.HeaderText = "BrojVrata";
            this.brojVrataDataGridViewTextBoxColumn.Name = "brojVrataDataGridViewTextBoxColumn";
            // 
            // opisSigurnostDataGridViewTextBoxColumn
            // 
            this.opisSigurnostDataGridViewTextBoxColumn.DataPropertyName = "OpisSigurnost";
            this.opisSigurnostDataGridViewTextBoxColumn.HeaderText = "OpisSigurnost";
            this.opisSigurnostDataGridViewTextBoxColumn.Name = "opisSigurnostDataGridViewTextBoxColumn";
            // 
            // mijenjacDataGridViewTextBoxColumn
            // 
            this.mijenjacDataGridViewTextBoxColumn.DataPropertyName = "Mijenjac";
            this.mijenjacDataGridViewTextBoxColumn.HeaderText = "Mijenjac";
            this.mijenjacDataGridViewTextBoxColumn.Name = "mijenjacDataGridViewTextBoxColumn";
            // 
            // potrosnjaDataGridViewTextBoxColumn
            // 
            this.potrosnjaDataGridViewTextBoxColumn.DataPropertyName = "Potrosnja";
            this.potrosnjaDataGridViewTextBoxColumn.HeaderText = "Potrosnja";
            this.potrosnjaDataGridViewTextBoxColumn.Name = "potrosnjaDataGridViewTextBoxColumn";
            // 
            // obrtniMomentDataGridViewTextBoxColumn
            // 
            this.obrtniMomentDataGridViewTextBoxColumn.DataPropertyName = "ObrtniMoment";
            this.obrtniMomentDataGridViewTextBoxColumn.HeaderText = "ObrtniMoment";
            this.obrtniMomentDataGridViewTextBoxColumn.Name = "obrtniMomentDataGridViewTextBoxColumn";
            // 
            // sirinaDataGridViewTextBoxColumn
            // 
            this.sirinaDataGridViewTextBoxColumn.DataPropertyName = "Sirina";
            this.sirinaDataGridViewTextBoxColumn.HeaderText = "Sirina";
            this.sirinaDataGridViewTextBoxColumn.Name = "sirinaDataGridViewTextBoxColumn";
            // 
            // ubrzanjeDataGridViewTextBoxColumn
            // 
            this.ubrzanjeDataGridViewTextBoxColumn.DataPropertyName = "Ubrzanje";
            this.ubrzanjeDataGridViewTextBoxColumn.HeaderText = "Ubrzanje";
            this.ubrzanjeDataGridViewTextBoxColumn.Name = "ubrzanjeDataGridViewTextBoxColumn";
            // 
            // maksimalnaBrzinaDataGridViewTextBoxColumn
            // 
            this.maksimalnaBrzinaDataGridViewTextBoxColumn.DataPropertyName = "MaksimalnaBrzina";
            this.maksimalnaBrzinaDataGridViewTextBoxColumn.HeaderText = "MaksimalnaBrzina";
            this.maksimalnaBrzinaDataGridViewTextBoxColumn.Name = "maksimalnaBrzinaDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // modeliDataGridViewTextBoxColumn
            // 
            this.modeliDataGridViewTextBoxColumn.DataPropertyName = "Modeli";
            this.modeliDataGridViewTextBoxColumn.HeaderText = "Modeli";
            this.modeliDataGridViewTextBoxColumn.Name = "modeliDataGridViewTextBoxColumn";
            this.modeliDataGridViewTextBoxColumn.Visible = false;
            // 
            // racuniStavkeDataGridViewTextBoxColumn
            // 
            this.racuniStavkeDataGridViewTextBoxColumn.DataPropertyName = "RacuniStavke";
            this.racuniStavkeDataGridViewTextBoxColumn.HeaderText = "RacuniStavke";
            this.racuniStavkeDataGridViewTextBoxColumn.Name = "racuniStavkeDataGridViewTextBoxColumn";
            this.racuniStavkeDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmPretragaAuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 301);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmPretragaAuta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga auta ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton name;
        private System.Windows.Forms.ToolStripDropDownButton izmjeniMenu;
        private System.Windows.Forms.ToolStripMenuItem ličniPodaci;
        private System.Windows.Forms.ToolStripMenuItem statusniPodaci;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource vozilaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaMotoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emisijaCO2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn slikaThumgDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewLinkColumn slikaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snagaMotoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojSasijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zapreminaMotoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zapreminaGepekaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duzinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tezinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojSjedistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pogonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojVrataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisSigurnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mijenjacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potrosnjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrtniMomentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubrzanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maksimalnaBrzinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racuniStavkeDataGridViewTextBoxColumn;
    }
}