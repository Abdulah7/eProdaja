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
    public partial class Vrste_dijelova : Form
    {
        public Vrste_dijelova()
        {
            InitializeComponent();
        }

        private void Vrste_dijelova_Load(object sender, EventArgs e)
        {
            List<Dijelovi> temp = Servis.DijeloviGET();
            ReportDataSource k = new ReportDataSource("DataSet1", temp);

            reportViewer1.LocalReport.DataSources.Add(k);

            reportViewer1.RefreshReport();
        }
    }
}
