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
using Microsoft.Reporting.WinForms;
namespace eProdaja.Izvjestaj
{
    public partial class frmRacunDijelovi : Form
    {
        public frmRacunDijelovi()
        {
            InitializeComponent();
        }

        private void frmRacunDijelovi_Load(object sender, EventArgs e)
        {

            List<RacuniDijelovi_Result2> temp = Servis.getRacunDijelvi();
            ReportDataSource k = new ReportDataSource("DataSet1", temp);

            reportViewer2.LocalReport.DataSources.Add(k);

            reportViewer2.RefreshReport();
           
        }
    }
}
