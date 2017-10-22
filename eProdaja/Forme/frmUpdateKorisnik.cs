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
using eProdajaServis.Util;
namespace eProdaja.Forme
{
    public partial class frmUpdateKorisnik : Form
    {
        public eProdajaServis.Data.Korisnici servis { get; set; }
        public frmUpdateKorisnik(eProdajaServis.Data.Korisnici s)
        {
            InitializeComponent();

            servis = s;
            ucitaj();
        }
        private void ucitaj()
        {

      
            button1.Text = "Sačuvaj";
            this.Text = "Izmjena podataka";
      
            textBox1.Text = servis.Prezime;
            textBox6.Text = servis.Ime;
            textBox2.Text = servis.Adresa;
            maskedTextBox1.Text = servis.Telefon;

            textBox4.Text = servis.Email;

            textBox3.Text = servis.LozinkaSalt;
            textBox5.Text = servis.SalonID.ToString();


            checkBox1.Checked =Convert.ToBoolean(servis.Status);

        }



        private void button1_Click(object sender, EventArgs e)
        {


            if (!textBox4.Text.Contains("@") || textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || maskedTextBox1.Text == "" || textBox6.Text == "" ||

             textBox5.Text == "")
            {
                MessageBox.Show(Global.GetString("fieldError"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                eProdajaServis.Data.Korisnici s = new eProdajaServis.Data.Korisnici();
                s.KorisnikID = servis.KorisnikID;

                s.Prezime = textBox1.Text.Trim();
                s.Adresa = textBox2.Text.Trim();
                s.Telefon = maskedTextBox1.Text.Trim();
                s.Email = textBox4.Text.Trim();

                s.Ime = textBox6.Text.Trim();
                s.LozinkaSalt = UIHelper.GenerateSalt();
                s.LozinkaHash = UIHelper.GenerateHash(textBox3.Text, s.LozinkaSalt);
                s.SalonID = Convert.ToInt32(textBox5.Text);

                s.Status = checkBox1.Checked;

                Servis.UpdateServis(s);

                MessageBox.Show(Global.GetString("update_succ"), "Izmjena podataka o korisniku", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
