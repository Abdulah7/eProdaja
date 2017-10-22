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
    public partial class frmPretragaProizvodjaca : Form
    {
        Proizvodjaci p;
        public frmPretragaProizvodjaca()
        {
            InitializeComponent();
            dataGridView1.DataSource = Servis.GEtAllPro();
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].Visible = false;

        }

        private void ličniPodaci_Click(object sender, EventArgs e)
        {
            
            int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            p = Servis.ProizvodjacID(a);
            UpdatePRoizvodjac u = new UpdatePRoizvodjac(p);
            u.ShowDialog();
            dataGridView1.DataSource = Servis.GEtAllPro();

        }

        private void statusniPodaci_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Servis.ProizvodjacDelete(a);
            MessageBox.Show(Global.GetString("delete"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.DataSource = Servis.GEtAllPro();
        }
    }
}
