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
    public partial class IzvjestajProdajaAuta : Form
    {
        public IzvjestajProdajaAuta()
        {
            InitializeComponent();
        }

        private void IzvjestajProdajaAuta_Load(object sender, EventArgs e)
        {
            List<ProdajaAutaInfoU_Result2> temp = Servis.getProdajaAuta();
            ReportDataSource k = new ReportDataSource("DataSet1", temp);

            reportViewer1.LocalReport.DataSources.Add(k);

            reportViewer1.RefreshReport();
        
        }
    }
}
