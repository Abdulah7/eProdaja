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
    public partial class IzmjenaDijelova : Form
    {
        Dijelovi d;
        public IzmjenaDijelova(Dijelovi dijelovi)
        {
            InitializeComponent();
            d = dijelovi;
            ucitaj();
            comboBox4.DataSource = Servis.GEtallPro();
            comboBox4.ValueMember = "ProizvodjacID";
            comboBox4.DisplayMember = "Naziv";
        }

        private void ucitaj()
        {
           
            textBox1.Text = d.Naziv;
            textBox6.Text = d.Opis;
            textBox4.Text = Convert.ToString(d.Zalihe);
            textBox5.Text = d.Sifra;
            textBox2.Text = d.AutaProizvedena;
            comboBox4.SelectedValue = d.ProizvodjacID;
            textBox3.Text =Convert.ToString(d.Cijena);
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""
                 || textBox6.Text == "" || comboBox4.Text == "")
            {
                MessageBox.Show(Global.GetString("please"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Dijelovi a = new Dijelovi();
                a.DioID = d.DioID;
                a.Naziv = textBox1.Text;
                a.Opis = textBox6.Text;
                a.Zalihe = Convert.ToInt32(textBox4.Text);
                a.Sifra = textBox5.Text;
                a.AutaProizvedena = textBox2.Text;
                a.ProizvodjacID = Convert.ToInt32(comboBox4.SelectedValue);
                a.Cijena = Convert.ToDouble(textBox3.Text);

                Servis.UpDijelova(a);
                MessageBox.Show(Global.GetString("update_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
