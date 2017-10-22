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
    public partial class DijeloviStavke : Form
    {
        int a=0;
        public DijeloviStavke(int j)
        {
            InitializeComponent();
         a = j;
        }

        private void DijeloviStavke_Load(object sender, EventArgs e)
        {

            List<GetDijeloviRacunStavke_Result1> temp = Servis.getDijeloviStavke(a);
            ReportDataSource k = new ReportDataSource("DataSet1", temp);
            reportViewer1.LocalReport.DataSources.Add(k);
            this.reportViewer1.RefreshReport();

            List<getUkupno_Result2> xx = Servis.getAutaDijeloviUkupno(a);
            ReportDataSource y = new ReportDataSource("DataSet5", xx);
            reportViewer1.LocalReport.DataSources.Add(y);
            this.reportViewer1.RefreshReport();
            List<GetDijeloviStavke_Result> pp= Servis.StavKeDijeloviResult(a);
            ReportDataSource  ss= new ReportDataSource("DataSet3", pp);
            reportViewer1.LocalReport.DataSources.Add(ss);
            this.reportViewer1.RefreshReport();
        }
    }
}
