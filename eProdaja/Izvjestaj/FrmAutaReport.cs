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
    public partial class FrmAutaReport : Form
    {
        public int vozila;
        public FrmAutaReport(int v)
        {
            InitializeComponent();
            vozila=v;
        }

        private void FrmAutaReport_Load(object sender, EventArgs e)
        {
            List<Vozila> temp = Servis.IDAuta(vozila);          
            ReportDataSource k = new ReportDataSource("DataSet1", temp);
            reportViewer1.LocalReport.DataSources.Add(k);
            this.reportViewer1.RefreshReport();

        }

       
    }
}
