﻿namespace eProdaja.Forme
{
    partial class PretragaModela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PretragaModela));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.name = new System.Windows.Forms.ToolStripButton();
            this.izmjeniMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.ličniPodaci = new System.Windows.Forms.ToolStripMenuItem();
            this.statusniPodaci = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(258, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vrsta";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.name,
            this.izmjeniMenu});
            this.toolStrip1.Location = new System.Drawing.Point(9, 46);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(93, 25);
            this.toolStrip1.TabIndex = 6;
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
            // PretragaModela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(254, 272);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PretragaModela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga modela";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton name;
        private System.Windows.Forms.ToolStripDropDownButton izmjeniMenu;
        private System.Windows.Forms.ToolStripMenuItem ličniPodaci;
        private System.Windows.Forms.ToolStripMenuItem statusniPodaci;
    }
}