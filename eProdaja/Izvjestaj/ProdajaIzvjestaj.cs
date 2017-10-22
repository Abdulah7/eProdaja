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
    public partial class ProdajaIzvjestaj : Form
    {
        public ProdajaIzvjestaj()
        {
            InitializeComponent();
        }

        private void ProdajaIzvjestaj_Load(object sender, EventArgs e)
        {
            List<GETProdajaInfo_Result> temp = Servis.getinfoProdaja();
            ReportDataSource k = new ReportDataSource("DataSet1", temp);
            reportViewer1.LocalReport.DataSources.Add(k);
       
            reportViewer1.RefreshReport();
          
        }
    }
}
