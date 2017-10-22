using eProdaja.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja
{
    public partial class MainForma : Form
    {
        public MainForma()
        {
            InitializeComponent();
        }

     

      
        private void podaciOServisuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServis s = new frmServis(null);
            s.MdiParent = this;
            s.Show();
        }

        private void pretragaKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPretragaKorisnika p = new frmPretragaKorisnika();
            p.MdiParent = this;
            p.Show();
        }

        private void novoAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmNovoAuto n = new frmNovoAuto();
            n.MdiParent = this;
            n.Show();

        }

        //private void autaToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    Izvjestaj.Vozila izvjestaj = new Izvjestaj.Vozila();
        //    izvjestaj.WindowState = FormWindowState.Maximized;
        //    izvjestaj.MdiParent = this;
        //    izvjestaj.Show();
        //}

   

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Izvjestaj.RacunIzvjestajForma izvjestaj = new Izvjestaj.RacunIzvjestajForma();
            izvjestaj.WindowState = FormWindowState.Maximized;
            izvjestaj.MdiParent = this;
            izvjestaj.Show();
        }

      

        private void evidencijaProizvođačaIModelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvidencijaProizvodjaca frm = new frmEvidencijaProizvodjaca();
            frm.Show();
        }

       

    

      
      

     

        private void pretragaIUklanjanjeAutaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPretragaAuta frm = new frmPretragaAuta();
            frm.Show();
        }

      

        private void pretragaIBrisanjeKupacaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPretragaKupaca frm = new frmPretragaKupaca();
            frm.MdiParent = this;
            frm.Show();

        }

        private void dodajDijeloveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDijelovi frm = new frmDijelovi();
            frm.MdiParent=this;
            frm.Show();
        }

        private void pretragaIBrisaanejDijelovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPretragaDijelova frm = new frmPretragaDijelova();
            frm.Show();
        }

      

        private void izdavanjeFaktureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzdavanjeFakture frm = new frmIzdavanjeFakture();
            frm.MdiParent = this;
            frm.Show();
        }

        private void noviKupacToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Forme.FrmRacunAuta frm = new FrmRacunAuta();
            frm.MdiParent = this;
            frm.Show();

        }

        private void pregledProdajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forme.PregledProdajeZarade frm = new PregledProdajeZarade();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvjestaj.ProdajaIzvjestaj t = new Izvjestaj.ProdajaIzvjestaj();

            t.MdiParent = this;
            t.Show();
        }

        private void vrsteDijelovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvjestaj.Vrste_dijelova t = new Izvjestaj.Vrste_dijelova();
            t.MdiParent = this;
            t.Show();
        }

        private void pregledProdajeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProdajaAuta f = new frmProdajaAuta();
            f.MdiParent = this;
            f.Show();
        }

        private void prodajaDijelovaDetaljiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvjestaj.ProdajaDijelovaDetalji t = new Izvjestaj.ProdajaDijelovaDetalji();
            t.MdiParent = this;
            t.Show();
        }

        private void prodajaAutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvjestaj.IzvjestajProdajaAuta t = new Izvjestaj.IzvjestajProdajaAuta();
            t.MdiParent = this;
            t.Show();
        }

        private void prodajaAutaDetaljiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvjestaj.ProdajaAutaDetalji t = new Izvjestaj.ProdajaAutaDetalji();
            t.MdiParent = this;
            t.Show();
        }

        private void evidencijaKupcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvidencijaKupaca frm = new frmEvidencijaKupaca();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaKupacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPretragaKupaca frm = new frmPretragaKupaca();
            frm.MdiParent = this;
            frm.Show();

        }

        private void pregledFakturaDijelovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledFakturaDijelova frm = new frmPregledFakturaDijelova();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledFakturaAutomobilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledRacunaAuta frm = new frmPregledRacunaAuta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void racuniDijelovaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Izvjestaj.frmRacunDijelovi frm = new Izvjestaj.frmRacunDijelovi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModel t = new frmModel();
            t.MdiParent = this;
            t.Show();
        }



        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Izvjestaj.RacunIzvjestajForma izvjestaj = new Izvjestaj.RacunIzvjestajForma();
            //izvjestaj.MdiParent = this;

            izvjestaj.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Izvjestaj.ProdajaIzvjestaj izvjestaj = new Izvjestaj.ProdajaIzvjestaj();
            //izvjestaj.MdiParent = this;

            izvjestaj.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

            Izvjestaj.Vrste_dijelova izvjestaj = new Izvjestaj.Vrste_dijelova();
            //izvjestaj.MdiParent = this;

            izvjestaj.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Izvjestaj.ProdajaDijelovaDetalji izvjestaj = new Izvjestaj.ProdajaDijelovaDetalji();
            //izvjestaj.MdiParent = this;

            izvjestaj.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Izvjestaj.IzvjestajProdajaAuta izvjestaj = new Izvjestaj.IzvjestajProdajaAuta();
            //izvjestaj.MdiParent = this;

            izvjestaj.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Izvjestaj.ProdajaAutaDetalji izvjestaj = new Izvjestaj.ProdajaAutaDetalji();
            //izvjestaj.MdiParent = this;

            izvjestaj.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Izvjestaj.frmRacunDijelovi izvjestaj = new Izvjestaj.frmRacunDijelovi();
            //izvjestaj.MdiParent = this;

            izvjestaj.Show();
        }

        private void pregledProizvodjacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPretragaProizvodjaca frm = new frmPretragaProizvodjaca();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaModelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretragaModela frm = new PretragaModela();
            //frm.MdiParent = this;
            frm.Show();
        }
    }
}
