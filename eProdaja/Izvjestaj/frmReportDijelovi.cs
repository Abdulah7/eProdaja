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
    public partial class frmReportDijelovi : Form
    {
        int gg = 0;
      
        public frmReportDijelovi(int v)
        {
            
              InitializeComponent();
            gg = v;
        }

        private void frmReportDijelovi_Load(object sender, EventArgs e)
        {
            List<GetAutaRacunStavke_Result> temp =Servis.getReportDijelovi(gg);
            ReportDataSource k = new ReportDataSource("DataSet1", temp);
            reportViewer1.LocalReport.DataSources.Add(k);
            this.reportViewer1.RefreshReport();

            List<getUkupno_Result2> ss = Servis.getAutaDijeloviUkupno(gg);
            ReportDataSource w = new ReportDataSource("DataSet3", ss);
            reportViewer1.LocalReport.DataSources.Add(w);
            this.reportViewer1.RefreshReport();


            List<GetAutaStavke_Result> pp = Servis.StavkeAutaResult(gg);
            ReportDataSource dd = new ReportDataSource("DataSet2", pp);
            reportViewer1.LocalReport.DataSources.Add(dd);
            this.reportViewer1.RefreshReport();
        }
    }
}
