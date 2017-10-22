using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using eProdajaServis.Data;
using eProdajaServis.Util;
using System.Net.Mail;

namespace eProdaja
{
    public partial class frmServis : Form
    {
        public eProdajaServis.Data.Korisnici servis { get; set; }
        public frmServis(eProdajaServis.Data.Korisnici s)
        {
            InitializeComponent();
            comboBox1.DataSource = Servis.getSalon();
            comboBox1.ValueMember = "SalonID";
            comboBox1.DisplayMember = "Naziv";




        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (!textBox4.Text.Contains("@") || textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || maskedTextBox1.Text == "" || textBox6.Text == "" ||

             textBox5.Text == "")
            {
                MessageBox.Show(Global.GetString("fieldError"), "Salon auta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

           

            else
            {
                eProdajaServis.Data.Korisnici s = new eProdajaServis.Data.Korisnici();

                s.Prezime = textBox1.Text.Trim();
                s.Adresa = textBox2.Text.Trim();
                s.Telefon = maskedTextBox1.Text.Trim();




                s.Ime = textBox6.Text.Trim();

                s.Email = textBox4.Text;

                s.LozinkaSalt = UIHelper.GenerateSalt();
                s.LozinkaHash = UIHelper.GenerateHash(textBox5.Text, s.LozinkaSalt);
                s.SalonID = Convert.ToInt32(comboBox1.SelectedValue);
                s.Status = checkBox1.Checked;





                Servis.insertkorisnik(s);

                MessageBox.Show(Global.GetString("jup"), "Salon auta", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            


        }



      









        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            checkBox1.Checked = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        
    }




}
