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
    public partial class PregledProdajeZarade : Form
    {
        public PregledProdajeZarade()
        {
            InitializeComponent();

            dataGridView1.DataSource = Servis.getInfo();


            dataGridView2.DataSource = Servis.getInfoUkupno();
            dataGridView3.DataSource = Servis.ZaliheGet();
           
        }
    }
}
