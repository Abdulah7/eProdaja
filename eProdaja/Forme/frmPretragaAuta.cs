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
    public partial class frmPretragaAuta : Form
    {
        Vozila v;
        List<Vozila> auto = new List<Vozila>();
        public frmPretragaAuta()
        {

       
            InitializeComponent();
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource = Servis.GEEEETAuta();

            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[6].Visible = false;

            //dataGridView1.Columns[30].Visible = false;

            //dataGridView1.Columns[29].Visible = false;



        }

        private void binForm()
        {
            dataGridView1.DataSource = Servis.PretragNNNNNNazivAuta(textBox1.Text.Trim(),textBox2.Text);

            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[29].Visible = false;

            //dataGridView1.Columns[30].Visible = false;

            //dataGridView1.Columns[29].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            binForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
            DataGridViewRow d = new DataGridViewRow();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                     d=dataGridView1.Rows[i];
                     if (Convert.ToBoolean(d.Cells[0].Value) == true)
                     {

                         int g = Convert.ToInt32(d.Cells[1].Value);

                         Servis.BrisiAuto(g);

                         binForm();
                   

                         MessageBox.Show(Global.GetString("delete"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     }
            }
            
          }
            catch (Exception)
            {
                MessageBox.Show("Aplikacija  trenutno puca!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

       

        private void Click1(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            v = Servis.getVoziloID(temp);
            frmUpdateAuta frm = new frmUpdateAuta(v);
            frm.ShowDialog();
            dataGridView1.DataSource = Servis.GEEEETAuta();
        }

        private void statusniPodaci_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Servis.DeleteAuta(temp);
                dataGridView1.DataSource = Servis.GEEEETAuta();
                MessageBox.Show(Global.GetString("delete"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show(Global.GetString("cc"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

     

       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int h;
            int temp = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            h = temp;
            PhotoViewer f = new PhotoViewer(h);
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            Izvjestaj.FrmAutaReport frm = new Izvjestaj.FrmAutaReport(temp);
        
            frm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Servis.PretragNNNNNNazivAuta(textBox1.Text.Trim(), textBox2.Text);
        }
    }
}
