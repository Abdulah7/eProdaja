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

namespace eProdaja
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eProdajaServis.Data.Korisnici s = Servis.SelectImeKorisnika(textBox1.Text, textBox2.Text);



            if (s != null)
            {
               
                

                    Global.prijavakorisnika = s;
                    this.DialogResult = DialogResult.OK;
                

            }
            else
            {
                textBox1.Text = "";

                MessageBox.Show(Global.GetString("Login_error"), "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
   


     
    }
}
