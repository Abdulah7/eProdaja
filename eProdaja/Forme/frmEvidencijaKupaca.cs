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
    public partial class frmEvidencijaKupaca : Form
    {
        int uu = 0;
         Kupci kupci;
        public frmEvidencijaKupaca()
        {
            InitializeComponent();

            dataGridView1.DataSource = Servis.KupciGET();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;

            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;


            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!textBox2.Text.Contains("@") || textBox4.Text == "" || textBox1.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox2.Text == "" || textBox5.Text=="")
            {
                MessageBox.Show(Global.GetString("fieldError"), "Salon auta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                Kupci k = new Kupci();
                k.Ime = textBox4.Text;
                k.Prezime = textBox1.Text;
                k.Email = textBox2.Text;
                k.Telefon = textBox13.Text;
                k.Adresa = textBox14.Text;
                k.Lozinka = textBox5.Text;
                Servis.KupciInsert(k);



                MessageBox.Show(Global.GetString("jup"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void ads_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    uu = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    kupci = Servis.KupacID(uu);


                    if (kupci != null)
                    {


                        textBox4.Text = kupci.Ime;
                        textBox1.Text = kupci.Prezime;
                        textBox2.Text = kupci.Email;
                        textBox13.Text = kupci.Telefon;
                        textBox14.Text = kupci.Adresa;
                        textBox5.Text = kupci.Lozinka;


                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[3].Visible = false;
                        dataGridView1.Columns[4].Visible = false;
                        dataGridView1.Columns[5].Visible = false;

                        dataGridView1.Columns[7].Visible = false;
                        dataGridView1.Columns[6].Visible = false;
                        dataGridView1.Columns[8].Visible = false;
                        dataGridView1.Columns[9].Visible = false;
                        dataGridView1.Columns[10].Visible = false;

                    }

                }
                catch (Exception)
                {
                    MessageBox.Show(Global.GetString("gridError"), "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servis.getKupciALL(textBox12.Text,textBox3.Text);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servis.getKupciALL(textBox12.Text,textBox3.Text);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }
    }
}
