using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdajaServis.Data;
namespace eProdaja.Forme
{
    public partial class PretragaModela : Form
    {
        public PretragaModela()
        {
            InitializeComponent();

            dataGridView1.DataSource = Servis.ModeliAll();
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[4].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servis.ModeliGetAll(textBox1.Text, textBox2.Text);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servis.ModeliGetAll(textBox1.Text, textBox2.Text);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void ličniPodaci_Click(object sender, EventArgs e)
        {
            Modeli g;
            int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            g = Servis.ModeliID(a);
            UpdateModel frm = new UpdateModel(g);
            frm.ShowDialog();
            dataGridView1.DataSource = Servis.ModeliAll();
        }

        private void statusniPodaci_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Servis.ModelDelete(a);
            MessageBox.Show(Global.GetString("delete"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.DataSource = Servis.ModeliAll();
        }
    }
}
