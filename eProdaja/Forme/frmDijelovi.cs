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
    public partial class frmDijelovi : Form
    {
        public frmDijelovi()
        {
            InitializeComponent();

        

           

            comboBox4.DataSource = Servis.GEtallPro();
            comboBox4.ValueMember = "ProizvodjacID";
            comboBox4.DisplayMember = "Naziv";   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox2.Text == ""
                     || textBox6.Text == "")
                {
                    MessageBox.Show(Global.GetString("please"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    Dijelovi d = new Dijelovi();
                    d.Naziv = textBox1.Text;

                    d.Cijena = Convert.ToDouble(textBox3.Text);
                    d.Zalihe = Convert.ToInt32(textBox4.Text);
                    d.Sifra = textBox5.Text;

                    d.ProizvodjacID = Convert.ToInt32(comboBox4.SelectedValue);
                    d.AutaProizvedena = textBox2.Text;
                    d.Opis = textBox6.Text;
                    Servis.DijeloviInsert(d);




                    MessageBox.Show("Dodali ste zapis!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CLEAR();

                }
            }
            catch(Exception)
            {
                MessageBox.Show(Global.GetString("uhvati"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

    

        

        private void CLEAR()
        {
           
            textBox1.Text = "";
           
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";


            comboBox4.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
                
        }

       

       
    }
}
