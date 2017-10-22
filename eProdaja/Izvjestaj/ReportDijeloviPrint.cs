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
    public partial class ReportDijeloviPrint : Form
    {
        int jj = 0;
        public ReportDijeloviPrint( int h)
        {
            InitializeComponent();
            jj = h;
        }

        private void ReportDijeloviPrint_Load(object sender, EventArgs e)
        {


            List<Dijelovi> temp = Servis.Dijelovigg(jj);

            ReportDataSource k = new ReportDataSource("DataSet1", temp);

            reportViewer1.LocalReport.DataSources.Add(k);

            this.reportViewer1.RefreshReport();
        }
    }
}
