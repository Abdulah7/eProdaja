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
    public partial class RacunIzvjestajForma : Form
    {
        public RacunIzvjestajForma()
        {
            InitializeComponent();
        }

        private void RacunIzvjestajForma_Load(object sender, EventArgs e)
        {

        }

        private void batn_Click(object sender, EventArgs e)
        {
            List<RacunSelectByDatum_Result3> temp = Servis.SelectRacunByDatum(dateTimePicker1.Value, dateTimePicker2.Value);
            ReportDataSource k = new ReportDataSource("DataSet1", temp);
            reportViewer1.LocalReport.DataSources.Add(k);
            reportViewer1.LocalReport.SetParameters(new ReportParameter("datumP", dateTimePicker1.Value.ToShortDateString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("datumI", dateTimePicker2.Value.ToShortDateString()));
            reportViewer1.RefreshReport();

        }

       
    }
}
