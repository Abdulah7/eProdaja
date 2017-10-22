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
namespace eProdaja.Forme
{
    public partial class frmPretragaKorisnika : Form
    {

        eProdajaServis.Data.Korisnici servis;
        public frmPretragaKorisnika()
        {
           
            InitializeComponent();

            BindGrid();
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            //dataGridView1.Columns[7].Visible = false;
            //dataGridView1.Columns[8].Visible = false;
            //dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[0].Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
           
        }

        private void BindGrid()
        {
            dataGridView1.DataSource = Servis.esp_SelektBy_Name(textBox1.Text.Trim());
            dataGridView1.Columns[0].Visible = false;

            //dataGridView1.Columns[7].Visible = false;
            //dataGridView1.Columns[8].Visible = false;
            //dataGridView1.Columns[9].Visible = false;

            servis = null;
        }

        private void frmPretragaKorisnika_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

    

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {



                int temp = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);


                servis = Servis.seletBYId(temp);



            }
            catch(Exception)
            {

                MessageBox.Show(Global.GetString("temp"), "Salon auta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Deaktiviraj_Click(object sender, EventArgs e)
        {
            if (servis != null)
            {

                if ((bool)dataGridView1.SelectedRows[0].Cells[6].Value  && servis.KorisnikID!=Global.prijavakorisnika.KorisnikID)
                {
                    Servis.updateStatus(servis.KorisnikID, false);
                    BindGrid();
                    MessageBox.Show(Global.GetString("status"), "Salon auta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
             
            }
        }

        private void ličniPodaci_Click(object sender, EventArgs e)
        {
            if (servis != null)
            {

                frmUpdateKorisnik updatekorisnik = new frmUpdateKorisnik(servis);
                updatekorisnik.ShowDialog();
                BindGrid();
            }
        }

        private void izmjeniMenu_Click(object sender, EventArgs e)
        {
            izmjeniMenu.DropDown.AutoClose = true;
        }

        private void statusniPodaci_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Servis.korisnikDelete(temp);
                MessageBox.Show(Global.GetString("delete"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGrid();

            }
            catch (Exception)
            {
                MessageBox.Show(Global.GetString("cc"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (servis != null)
            {

                if ((bool)dataGridView1.SelectedRows[0].Cells[6].Value==false && servis.KorisnikID != Global.prijavakorisnika.KorisnikID)
                {
                    Servis.UpdataStatusTr(servis.KorisnikID, true);
                    BindGrid();

                    MessageBox.Show(Global.GetString("status"), "Salon auta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

       
    }
}
