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
    public partial class frmEvidencijaProizvodjaca : Form
    {
        public frmEvidencijaProizvodjaca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox4.Text.Contains("@") || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show(Global.GetString("fieldError"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { 
            Proizvodjaci p = new Proizvodjaci();
            p.Naziv = textBox1.Text;
            p.Adresa = textBox2.Text;
            p.Telefon = textBox3.Text;
            p.Email = textBox4.Text;

           
 
                Servis.ProizovdjacInsert(p);
                MessageBox.Show(Global.GetString("jup"), "Salon auta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }






        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
