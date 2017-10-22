using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using eProdajaServis.Data;
using eProdajaServis.Util;
namespace eProdaja.Forme
{
    public partial class frmNovoAuto : Form
    {
        private Vozila abdo { get; set; }
        public frmNovoAuto()
        {
            InitializeComponent();
            //comboBox2.DataSource = Servis.GetServis();
            //comboBox2.ValueMember = "KorisnikID";
            //comboBox2.DisplayMember = "Ime";

        }

        private void frmNovoAuto_Load(object sender, EventArgs e)
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
          

        }

       

  

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                abdo = new Vozila();

                openFileDialog.ShowDialog();
                textBox6.Text = openFileDialog.FileName;

                Image image = Image.FromFile(textBox6.Text);

                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                abdo.Slika = ms.ToArray();

                if (image.Width > 200)
                {
                    Image resizedImage = UIHelper.ResizeImage(image, new Size(200, 180));
                    Image croppedImage = resizedImage;

                    if (resizedImage.Width >= 160 && resizedImage.Height >= 140)
                        croppedImage = UIHelper.CropImage(resizedImage, new Rectangle(40, 40, 120, 100));

                     ms = new MemoryStream();

                    croppedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    abdo.SlikaThumg = ms.ToArray();

                    slika.Image = croppedImage;
                }
                else
                {
                    abdo.Slika = ms.ToArray();
                    slika.Image = image;
                }
        }
            catch (Exception)
            {
                MessageBox.Show(Global.GetString("slika"), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox1.Text == "" || textBox1.Text == "" || textBox1.Text == ""
                                        || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""
                                        || textBox5.Text == "" || textBox12.Text == "" || textBox13.Text == ""
                                        || textBox14.Text == "" || textBox44.Text == "" || textBox30.Text == "" || textBox36.Text == "" || textBox37.Text == ""
                                        || textBox38.Text == "" || textBox39.Text == "" || textBox40.Text == "" || textBox41.Text == "" || textBox42.Text == ""
                                        || textBox43.Text == "" || textBox28.Text == "" || textBox25.Text == "" || textBox26.Text == "" || textBox8.Text == ""
                                        || textBox8.Text == "" || textBox10.Text == "" || textBox7.Text == "" || textBox6.Text == "" || comboBox1.SelectedIndex == 0)

                {
                    MessageBox.Show(Global.GetString("please"), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {


                    //try
                    //{
                    if (abdo == null)

                        abdo = new Vozila();


                    if (comboBox1.SelectedIndex > 0)

                        abdo.ModelID = Convert.ToInt32(comboBox1.SelectedValue);

                    abdo.Naziv = textBox1.Text.Trim();
                    abdo.Godiste = textBox2.Text.Trim();
                    abdo.Boja = textBox3.Text.Trim();
                    abdo.VrstaMotora = textBox4.Text.Trim();
                    abdo.EmisijaCO2 = textBox5.Text.Trim();
                    abdo.Cijena = (float)Convert.ToDouble(textBox7.Text);
                    abdo.ZapreminaMotora = textBox12.Text;
                    abdo.ZapreminaGepeka = textBox13.Text;
                    abdo.Duzina = textBox14.Text;
                    abdo.Tezina = textBox44.Text;
                    abdo.Klima = textBox30.Text;
                    abdo.BrojSjedista = Convert.ToInt32(textBox36.Text);
                    abdo.Pogon = textBox37.Text;
                    abdo.BrojVrata = Convert.ToInt32(textBox38.Text);
                    abdo.OpisSigurnost = textBox39.Text;
                    abdo.Mijenjac = textBox40.Text;
                    abdo.Potrosnja = textBox41.Text;
                    abdo.ObrtniMoment = textBox42.Text;
                    abdo.Sirina = textBox43.Text;
                    abdo.Ubrzanje = textBox28.Text;
                    abdo.MaksimalnaBrzina = textBox25.Text;
                    abdo.Kolicina = Convert.ToInt32(textBox26.Text);


                    abdo.Oprema = textBox8.Text;
                    abdo.SnagaMotora = textBox9.Text;
                    abdo.BrojSasije = textBox10.Text;




                    Servis.insertVOZILA(abdo);
                    MessageBox.Show("Dodali ste zapis!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                }
                catch (Exception)
            {
                MessageBox.Show(Global.GetString("uhvati"), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button2_Click(object sender, EventArgs e)
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

           slika.Image=null;
                

            textBox25.Text = "";
            textBox26.Text = "";


        

    }
}

    
}
