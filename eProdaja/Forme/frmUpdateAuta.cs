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
using System.IO;

namespace eProdaja.Forme
{
    public partial class frmUpdateAuta : Form
    {
        eProdajaServis.Data.Vozila kk = new eProdajaServis.Data.Vozila();
        private Vozila aa { get; set; }
        public frmUpdateAuta( Vozila v)
        {
            InitializeComponent();
            aa = v;
            ucitaj();
        }

        private void ucitaj()
        {

      comboBox1.SelectedValue=aa.Modeli.Naziv;

            textBox1.Text = aa.Naziv;
            textBox2.Text = aa.Godiste;
             textBox3.Text = aa.Boja;
            textBox4.Text = aa.VrstaMotora;
            textBox5.Text = aa.EmisijaCO2;
            textBox7.Text =Convert.ToString(aa.Cijena);
            textBox12.Text = aa.ZapreminaMotora;
            textBox13.Text = aa.ZapreminaGepeka;
            textBox14.Text = aa.Duzina;
            textBox44.Text = aa.Tezina;
            textBox30.Text = aa.Klima;
            textBox36.Text =Convert.ToString(aa.BrojSjedista);
            textBox37.Text = aa.Pogon;
            textBox38.Text =Convert.ToString(aa.BrojVrata);
            textBox39.Text = aa.OpisSigurnost;
            textBox40.Text = aa.Mijenjac;
            textBox41.Text = aa.Potrosnja;
            textBox42.Text = aa.ObrtniMoment;
            textBox43.Text = aa.Sirina;
            textBox28.Text = aa.Ubrzanje;
            textBox25.Text = aa.MaksimalnaBrzina;
            textBox26.Text =Convert.ToString(aa.Kolicina);


             textBox8.Text= aa.Oprema;
            textBox9.Text = aa.SnagaMotora;
             textBox10.Text= aa.BrojSasije;
        }

        private void frmUpdateAuta_Load(object sender, EventArgs e)
        {

            bindModel();
        }

        private void bindModel()
        {
            comboBox1.DataSource = Servis.GetModel();
            comboBox1.ValueMember = "ModelID";
            comboBox1.DisplayMember = "Naziv";
        }

        private void clear()
        {
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            textBox7.Text = "";
            comboBox1.SelectedValue = "";

            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox12.Text = "";
            textBox44.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";

            textBox30.Text = "";
            textBox28.Text = "";
            textBox36.Text = "";
            textBox37.Text = "";
            textBox38.Text = "";
            textBox39.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
            textBox42.Text = "";
            textBox43.Text = "";




            textBox25.Text = "";
            textBox26.Text = "";
            textBox25.Text = "";

        }





      

       

        private void button3_Click_1(object sender, EventArgs e)
            
              
        {
        
            try
            {
                kk = new Vozila();

                openFileDialog.ShowDialog();
                textBox6.Text = openFileDialog.FileName;

                Image image = Image.FromFile(textBox6.Text);

                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                kk.Slika = ms.ToArray();

                if (image.Width > 200)
                {
                    Image resizedImage = UIHelper.ResizeImage(image, new Size(200, 180));
                    Image croppedImage = resizedImage;

                    if (resizedImage.Width >= 160 && resizedImage.Height >= 140)
                        croppedImage = UIHelper.CropImage(resizedImage, new Rectangle(40, 40, 120, 100));

                    ms = new MemoryStream();

                    croppedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    kk.SlikaThumg = ms.ToArray();

                    slika.Image = croppedImage;
                }
                else
                {
                    kk.Slika = ms.ToArray();
                    slika.Image = image;
                }
           
            }
            catch (Exception)
            {
                MessageBox.Show(Global.GetString("fieldError"), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        

        private void button1_Click_1(object sender, EventArgs e)
        
           
            {

            if (textBox1.Text == "" || textBox1.Text == "" || textBox1.Text == "" || textBox1.Text == ""
                          || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""
                          || textBox5.Text == "" || textBox12.Text == "" || textBox13.Text == ""
                          || textBox14.Text == "" || textBox44.Text == "" || textBox30.Text == "" || textBox36.Text == "" || textBox37.Text == ""
                          || textBox38.Text == "" || textBox39.Text == "" || textBox40.Text == "" || textBox41.Text == "" || textBox42.Text == ""
                          || textBox43.Text == "" || textBox28.Text == "" || textBox25.Text == "" || textBox26.Text == "" || textBox8.Text == ""
                          || textBox8.Text == "" || textBox10.Text == "" || textBox7.Text == "" || textBox6.Text == "" || comboBox1.Text =="")

            {
                MessageBox.Show(Global.GetString("please"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {


                //try
                //{
                if (kk == null)


                    kk = new Vozila();
                if (comboBox1.SelectedIndex > 0)

                kk.ModelID = Convert.ToInt32(comboBox1.SelectedValue);
                kk.VoziloID = aa.VoziloID;
                kk.Naziv = textBox1.Text.Trim();
                kk.Godiste = textBox2.Text.Trim();
                kk.Boja = textBox3.Text.Trim();
                kk.VrstaMotora = textBox4.Text.Trim();
                kk.EmisijaCO2 = textBox5.Text.Trim();
                kk.Cijena = (float)Convert.ToDouble(textBox7.Text);
                kk.ZapreminaMotora = textBox12.Text;
                kk.ZapreminaGepeka = textBox13.Text;
                kk.Duzina = textBox14.Text;
                kk.Tezina = textBox44.Text;
                kk.Klima = textBox30.Text;
                kk.BrojSjedista = Convert.ToInt32(textBox36.Text);
                kk.Pogon = textBox37.Text;
                kk.BrojVrata = Convert.ToInt32(textBox38.Text);
                kk.OpisSigurnost = textBox39.Text;
                kk.Mijenjac = textBox40.Text;
                kk.Potrosnja = textBox41.Text;
                kk.ObrtniMoment = textBox42.Text;
                kk.Sirina = textBox43.Text;
                kk.Ubrzanje = textBox28.Text;
                kk.MaksimalnaBrzina = textBox25.Text;
                kk.Kolicina = Convert.ToInt32(textBox26.Text);


                kk.Oprema = textBox8.Text;
                kk.SnagaMotora = textBox9.Text;
                kk.BrojSasije = textBox10.Text;




                Servis.AutaIzmjena(kk);
                MessageBox.Show(Global.GetString("update_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();


            }

            
        }

        
    }

}
