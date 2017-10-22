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
    public partial class frmProdajaAuta : Form
    {
        public frmProdajaAuta()
        {
            InitializeComponent();


            dataGridView1.DataSource = Servis.getInfoAutaResult();
            dataGridView2.DataSource = Servis.GEtProdajaAuta();
            dataGridView3.DataSource = Servis.GetZaliheAuta();
        }

      
    }
}
