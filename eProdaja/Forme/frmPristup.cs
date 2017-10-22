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
    public partial class frmPristup : Form
    {
        private eProdajaServis.Data.Korisnici s;
        public frmPristup(eProdajaServis.Data.Korisnici servis)
        {
            InitializeComponent();
            if(servis!=null)
            {
                s = servis;
                ucitajpodatke();


            }
        }

        private void ucitajpodatke()
        {
            textBox1.Text = s.Ime;
            checkBox1.Checked =Convert.ToBoolean(s.Status);

        }

  

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox2.Text!="")
            {
                s.LozinkaSalt = UIHelper.GenerateSalt();
                s.LozinkaHash = UIHelper.GenerateHash(textBox2.Text, s.LozinkaSalt);
                Servis.ResetLozninka(s);
            }
            string poruka = "";

            //if (s.KorisnikID == Global.prijavakorisnika.KorisnikID && checkBox1.Checked)
            //{
            //    MessageBox.Show(Global.GetString("temp"), "Salon auta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else



            //    Servis.updateStatus(s.KorisnikID, checkBox1.Checked);

            MessageBox.Show(poruka+ "\n"+Global.GetString("update_succ"), "Izmjena", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
