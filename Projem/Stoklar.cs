using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projem
{
    public partial class Stoklar : UserControl
    {
        public Stoklar()
        {
            InitializeComponent();
        }

        private void Stoklar_Load(object sender, EventArgs e)
        {
            Yenile();
            cmbYakit.SelectedItem = "Tümü";
            cmbHareket.SelectedItem = "Tümü";
        }

        private void Yenile()
        {
            dgvStok.DataSource = VeriTabani.StokHarketleriGetir();
            lblToplamStok1.Text = VeriTabani.ToplamStokGetir("Motorin").ToString("N0") + " L";
            lblToplamStok2.Text = VeriTabani.ToplamStokGetir("Benzin 95").ToString("N0") + " L";
            lblToplamStok3.Text = VeriTabani.ToplamStokGetir("LPG").ToString("N0") + " L";
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            string hareket = cmbHareket.Text == "Tümü" ? "" : cmbHareket.Text;
            string yakit = cmbYakit.Text == "Tümü" ? "" : cmbYakit.Text;

            DataTable dt = (DataTable)dgvStok.DataSource;
            dt.DefaultView.RowFilter = "Hareket LIKE '%" + hareket + "%' AND [Yakıt] LIKE '%" + yakit + "%'";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}
