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
    public partial class frmPretragaKupaca : Form
    {
        Kupci kupci;
        public frmPretragaKupaca()
        {
            InitializeComponent();

            dataGridView1.DataSource = Servis.Klient();
            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[7].Visible = false;
            //dataGridView1.Columns[8].Visible = false;
            //dataGridView1.Columns[9].Visible = false;
            //dataGridView1.Columns[10].Visible = false;
        
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

        }

        private void BindGrid()
        {
            dataGridView1.DataSource = Servis.getKupciALL(textBox1.Text.Trim(),textBox2.Text);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                DataGridViewRow d = new DataGridViewRow();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    d = dataGridView1.Rows[i];
                    if (Convert.ToBoolean(d.Cells[0].Value) == true)
                    {

                        int g = Convert.ToInt32(d.Cells[1].Value);

                        Servis.KupacDelete(g);



                        BindGrid();


                        MessageBox.Show(Global.GetString("delete"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Aplikacija  trenutno puca!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servis.getKupciALL(textBox1.Text.Trim(), textBox2.Text);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
           

        }

        private void ličniPodaci_Click(object sender, EventArgs e)
        {
         
               int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
              kupci = Servis.KupacID(a);
            KupacUpdate k = new KupacUpdate(kupci);
            k.ShowDialog();
            dataGridView1.DataSource = Servis.Klient();
        }

       

        private void statusniPodaci_Click(object sender, EventArgs e)
        {
            try
            { 
            int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Servis.KupacDelete(a);
            dataGridView1.DataSource = Servis.Klient();
            MessageBox.Show(Global.GetString("delete"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
            catch (Exception)
            {
                MessageBox.Show(Global.GetString("cc"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


}
    }
}
