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
    public partial class frmPregledFakturaDijelova : Form
    {
        public frmPregledFakturaDijelova()
        {
            InitializeComponent();

            dataGridView1.DataSource = Servis.getRacunDijelvi();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            //dataGridView1.Columns[13].Visible = false;
        }
    }
}
