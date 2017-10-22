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


    public partial class frmPretragaDijelova : Form
    {
        Dijelovi d;
        public frmPretragaDijelova()
        {
            InitializeComponent();

            //bindGrid1();

            dataGridView2.DataSource = Servis.getDijlovIGEt();

            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;


        }

        private void bindGrid2()
        {
            dataGridView2.DataSource = Servis.getDijeloveNaziv(textBox2.Text.Trim(), textBox1.Text);
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[9].Visible = false;
            dataGridView2.Columns[8].Visible = false;
           



        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DataGridViewRow d = new DataGridViewRow();
        //        for (int i = 0; i < dataGridView2.Rows.Count; i++)
        //        {
        //            d = dataGridView2.Rows[i];
        //            if (Convert.ToBoolean(d.Cells[0].Value) == true)
        //            {

        //                int g = Convert.ToInt32(d.Cells[1].Value);

        //                Servis.BrisiDijelove(g);
        //                bindGrid2();

        //                MessageBox.Show(Global.GetString("delete"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Aplikacija  trenutno puca!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            bindGrid2();
        }

        private void ličniPodaci_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            d = Servis.getdijelovI(temp);
            IzmjenaDijelova i = new IzmjenaDijelova(d);
            i.ShowDialog();

            dataGridView2.DataSource = Servis.getDijlovIGEt();
        }

        private void statusniPodaci_Click(object sender, EventArgs e)
        {

            try
            {
                int temp = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                Servis.BrisiDijelove(temp);

                dataGridView2.DataSource = Servis.getDijlovIGEt();
                MessageBox.Show(Global.GetString("delete"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show(Global.GetString("cc"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Servis.getDijeloveNaziv(textBox2.Text.Trim(), textBox1.Text);
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[9].Visible = false;
            dataGridView2.Columns[8].Visible = false;
        }

        private void sdas_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            Izvjestaj.ReportDijeloviPrint frm = new Izvjestaj.ReportDijeloviPrint(temp);
            frm.Show();
        }
    }
}
