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
    public partial class KupacUpdate : Form
    {
        Kupci k;
        public KupacUpdate(Kupci l)
        {
            InitializeComponent();
            k = l;
            ucitaj();
        }

        private void ucitaj()
        {
            textBox4.Text = k.Ime;
            textBox1.Text = k.Prezime;
            textBox2.Text = k.Email;
            textBox13.Text = k.Telefon;
            textBox14.Text = k.Adresa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show(Global.GetString("fieldError"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Kupci a = new Kupci();
                a.KupacID = k.KupacID;
                a.Ime = textBox4.Text;
                a.Prezime = textBox1.Text;
                a.Email = textBox2.Text;
                a.Telefon = textBox13.Text;
                a.Adresa = textBox14.Text;
                a.Lozinka = textBox3.Text;
                Servis.KupacUp(a);
        
                MessageBox.Show(Global.GetString("update_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
