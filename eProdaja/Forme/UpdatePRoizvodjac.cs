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
    public partial class UpdatePRoizvodjac : Form
    {
        Proizvodjaci p;
        public UpdatePRoizvodjac(Proizvodjaci a)
        {
            InitializeComponent();
            p = a;
            ucitaj();
        }

        private void ucitaj()
        {
            textBox1.Text = p.Naziv;
            textBox2.Text = p.Adresa;
            textBox3.Text = p.Telefon;
            textBox4.Text = p.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show(Global.GetString("fieldError"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Proizvodjaci temp = new Proizvodjaci();
                temp.ProizvodjacID = p.ProizvodjacID;
                temp.Naziv = textBox1.Text;
                temp.Adresa = textBox2.Text;
                temp.Telefon = textBox3.Text;
                temp.Email = textBox4.Text;
                Servis.UpdateProizvodjac(temp);
                MessageBox.Show(Global.GetString("update_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
