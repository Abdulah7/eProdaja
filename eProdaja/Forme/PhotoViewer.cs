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
    public partial class PhotoViewer : Form
    {
       
        int v { get; set; }
        public PhotoViewer(int vozila)
        {
            InitializeComponent();
            v = vozila;
           
        }
        int a = 5027;
        int b = 5028;
        int c = 5029;
        int d = 5030;
        int aa = 5032;
        int f = 5033;
        int g = 5036;
        int h = 5037;
        int i = 5038;
        int j = 6118;
        private void PhotoViewer_Load(object sender, EventArgs e)
        {

            if (v == a)

            {



          

                pictureBox1.Image = Properties.Resources.a;
            

            }
            if(v==b)
            {

               
                pictureBox1.Image = Properties.Resources.golf;
                
            }
            if(v==c)
            {

               
                pictureBox1.Image = Properties.Resources.ferari;
             
            }
            if (v == d)
            {

              
                pictureBox1.Image = Properties.Resources.lamb;
             
            }
            if (v==aa)
            {

               
                pictureBox1.Image = Properties.Resources.mercedes_s;
              
            }
            if (v == f)
            {

             
                pictureBox1.Image = Properties.Resources.mb;
               
            }
            if (v == g)
            {
                
                pictureBox1.Image = Properties.Resources.bm;
               
            }
            if (v == h)
            {

                
                pictureBox1.Image = Properties.Resources.mazda;
               
            }
            if (v == i)
            {

                
                pictureBox1.Image = Properties.Resources.pegeout;
              
            }
            if (v == j)
            {

               
                pictureBox1.Image = Properties.Resources.bu;
              
            }
        }

    }
}
