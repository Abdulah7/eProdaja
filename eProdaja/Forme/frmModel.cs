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
    public partial class frmModel : Form
    {
        public frmModel()
        {
            InitializeComponent();
            comboBox1.DataSource = Servis.GetProizvodjac();
            comboBox1.ValueMember = "ProizvodjacID";
            comboBox1.DisplayMember = "Naziv";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show(Global.GetString("please"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            { 
            Modeli m = new Modeli();
               
                    m.ProizvodjacID = Convert.ToInt32(comboBox1.SelectedValue);
                    m.Naziv = textBox6.Text;
                    m.VrstaModela = textBox5.Text;

           
           
            
           
                Servis.ModelInsert(m);
          
       
    
            MessageBox.Show(Global.GetString("jup"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox1.DataSource = Servis.GetProizvodjac();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEvidencijaProizvodjaca frm = new frmEvidencijaProizvodjaca();
           
            frm.Show();
              
        }
    }
    }

 
    