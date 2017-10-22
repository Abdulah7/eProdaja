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
    public partial class UpdateModel : Form
    {
        Modeli m;
        public UpdateModel(Modeli k)
        {
            InitializeComponent();
            m = k;
            ucitaj();
            comboBox1.DataSource = Servis.GetProizvodjac();
            comboBox1.ValueMember = "ProizvodjacID";
            comboBox1.DisplayMember = "Naziv";
        }

        private void ucitaj()
        {
            textBox6.Text = m.Naziv;
            textBox5.Text = m.VrstaModela;
            comboBox1.SelectedValue = m.ProizvodjacID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || textBox5.Text == "" || comboBox1.Text=="")
            {
                MessageBox.Show(Global.GetString("please"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                Modeli j = new Modeli();
                j.ModelID = m.ModelID;
                j.Naziv = textBox6.Text;
                j.VrstaModela = textBox5.Text;
                j.ProizvodjacID = Convert.ToInt32(comboBox1.SelectedValue);
                Servis.UModel(j);
                MessageBox.Show(Global.GetString("update_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
