namespace eProdaja.Forme
{
    partial class frmPretragaProizvodjaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPretragaProizvodjaca));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.name = new System.Windows.Forms.ToolStripButton();
            this.izmjeniMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.ličniPodaci = new System.Windows.Forms.ToolStripMenuItem();
            this.statusniPodaci = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.name,
            this.izmjeniMenu});
            this.toolStrip1.Location = new System.Drawing.Point(9, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(124, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
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
            this.ličniPodaci.Click += new System.EventHandler(this.ličniPodaci_Click);
            // 
            // statusniPodaci
            // 
            this.statusniPodaci.Name = "statusniPodaci";
            this.statusniPodaci.Size = new System.Drawing.Size(154, 22);
            this.statusniPodaci.Text = "Ukloni podatke";
            this.statusniPodaci.Click += new System.EventHandler(this.statusniPodaci_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(394, 199);
            this.dataGridView1.TabIndex = 6;
            // 
            // frmPretragaProizvodjaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPretragaProizvodjaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled proizvodjaca";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton name;
        private System.Windows.Forms.ToolStripDropDownButton izmjeniMenu;
        private System.Windows.Forms.ToolStripMenuItem ličniPodaci;
        private System.Windows.Forms.ToolStripMenuItem statusniPodaci;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}