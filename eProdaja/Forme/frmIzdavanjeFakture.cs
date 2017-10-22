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
using System.Data.SqlClient;

namespace eProdaja.Forme
{

    public partial class frmIzdavanjeFakture : Form
    {
        double ad = 0;
        double ee = 0;
        int f = 1;
        double sum1 = 0;
        double sum = 0;
        double yx=1.17;
        private Kupci kupci = new Kupci();
        int qq = Global.prijavakorisnika.KorisnikID;
        Racuni r = new Racuni();
        protected int k { get; set; }

        public frmIzdavanjeFakture()
        {


            InitializeComponent();
            gridDijelovi.DataSource = Servis.getDijlovIGEt();



            comboBox3.DataSource = Servis.getPlacananje();
            comboBox3.ValueMember = "PlacanjeID";
            comboBox3.DisplayMember = "Naziv";


            dataGridView3.DataSource = Servis.KupciGET();


           // dataGridView3.Columns[0].Visible = false;


   
            gridDijelovi.Columns[0].Visible = false;

           //// dataGridView1.Columns[0].Visible = false;

           
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            {

                if (textBox7.Text == "" || comboBox3.Text == "" || textBox9.Text == "" || textBox16.Text == "")
                {
                    MessageBox.Show(Global.GetString("please"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {


             

                    r.KorisnikID = qq;
                    r.PlacanjeID = Convert.ToInt32(comboBox3.SelectedValue);
                    r.Komentar = textBox7.Text;
                    r.Cijena = Convert.ToDouble(textBox16.Text);
                    r.NacinIsporuke = textBox9.Text;
                    r.DatumFakture = Convert.ToDateTime(dateTimePicker3.Text);
                    r.DatumIsporuke = Convert.ToDateTime(dateTimePicker4.Text);

                    r.Ukupno = Convert.ToDouble(label29.Text);
                    r.PDV = yx;
                  int ee = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value);
                    r.KupacID = ee;


                    Servis.RacunInsert(r);






                    GetIDKupacRacun_Result3 temp = Servis.RacunID(qq);
                    int rr = temp.RacunID;


                   double sum3 = 0;
                    double sum2 = 0;
                    int sum4 = 0;
                  
                    RacuniStavke stavke = new RacuniStavke();

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {

                        stavke.DijeloviID = 0;
                        stavke.Kolicina = 0;
                        stavke.Popust = 0;
                        stavke.Rabat = 0;

                        stavke.DijeloviID = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                        stavke.RacunID = rr;
                        sum4 = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                        stavke.Kolicina = sum4;
                        string oo = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                        if (oo!="")
                        {
                            sum2 = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                            stavke.Popust = sum2;
                        }
                        string ff = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                        if (ff!="")
                        {
                            sum3 = Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                            stavke.Rabat = sum3;
                        }
                        

                        Servis.RacunStavkeinsert(stavke);

                    }




                    MessageBox.Show(Global.GetString("great"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  

                    Izvjestaj.DijeloviStavke bb = new Izvjestaj.DijeloviStavke(rr);
                    bb.Show();



                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gridDijelovi.DataSource = Servis.getDijeloveNaziv(textBox3.Text.Trim(), textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            gridDijelovi.DataSource = Servis.getDijeloveNaziv(textBox3.Text.Trim(), textBox1.Text);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = Servis.KupciPretraaga(textBox13.Text, textBox14.Text);

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = Servis.KupciPretraaga(textBox13.Text, textBox14.Text);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {



            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "^[a-zA-Z]") || textBox5.Text == "" || System.Text.RegularExpressions.Regex.IsMatch(textBox12.Text, "^[a-zA-Z]") || System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Molimo popunite sva polja ili unesite broj!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //DialogResult dr = MessageBox.Show("Da li želite dodati podatke?", "Title", MessageBoxButtons.YesNoCancel,
                //   MessageBoxIcon.Information);

                //if (dr == DialogResult.Yes)
                //{

             
                int hh = Convert.ToInt32(gridDijelovi.SelectedRows[0].Cells[2].Value);



                int temp1 = Convert.ToInt32(gridDijelovi.SelectedRows[0].Cells[3].Value);


                double racun = 0, racun2 = 0;
                double racun1 = 0;

                racun = temp1 * Convert.ToInt32(textBox5.Text);

                racun1 = racun *0.17;


                //  a = racun - racun1;
                racun2 = racun + racun1;


                int d = Convert.ToInt32(gridDijelovi.SelectedRows[0].Cells[0].Value);
                string s = Convert.ToString(gridDijelovi.SelectedRows[0].Cells[1].Value);


                dataGridView1.Rows.Add(f, d, s, temp1, textBox5.Text, racun2, textBox8.Text, textBox12.Text, hh, racun1);
                f++;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Selected = true;

                }

                double sum3 = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)


                
                    if (dataGridView1.Rows[i].Selected == true)

                    {
                        sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);


                        sum1 += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);

                        textBox16.Text = sum1.ToString();
                   
                        ee += Convert.ToDouble(dataGridView1.Rows[i].Cells[9].Value);


                    }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string ff = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                    if (ff != "")
                    {
                        sum3 += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                    }

                }
              
                

                double tott = Math.Round(sum, 2);
                label2.Text = tott.ToString();

                double t = Math.Round(sum3, 2);

                label26.Text = t.ToString();

                double tt = sum - sum3;

                double ww = Math.Round(tt, 2);
                label27.Text = ww.ToString();

                double qq = Math.Round(ee, 2);

                label28.Text = qq.ToString();

                //double pp = 0;
                //pp = tt + qq;
                // ad = Math.Round(pp, 2);

                label29.Text = ww.ToString();

                int vv = 0;
                int abdo = 0;
                vv = Convert.ToInt32(gridDijelovi.SelectedRows[0].Cells[2].Value);

                abdo = vv - Convert.ToInt32(textBox5.Text);

                Servis.DijeloviUpdate(Convert.ToInt32(gridDijelovi.SelectedRows[0].Cells[0].Value), abdo);


                gridDijelovi.DataSource = Servis.getDijlovIGEt();

            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox16.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            dateTimePicker3.Text = "";
            dateTimePicker4.Text = "";
            dataGridView1.Rows.Clear();
            //textBox11.Text = "";
            sum = 0;
            sum1 = 0;
            textBox8.Text = "";
            comboBox3.Text = "";
            textBox5.Text = "";
            f = 1;
            textBox1.Text = "";
            textBox12.Text = "";
            textBox3.Text = "";
            label26.Text = "";
            label2.Text = "";
            label27.Text = "";
            label28.Text = "";
            label29.Text = "";
        }

     
    }
}