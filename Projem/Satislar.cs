using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projem
{
    public partial class Satislar : UserControl
    {
        public Satislar()
        {
            InitializeComponent();
        }


        private void Yenile()
        {
            DataTable yeni = VeriTabani.SatislariGetir();
            DataTable eski = dgvSatis.DataSource as DataTable;

            if (eski != null && eski.Rows.Count == yeni.Rows.Count) return;

            dgvSatis.DataSource = yeni;

            DataRow ozet = VeriTabani.OzetGetir().Rows[0];
            lblCiro.Text = ((decimal)ozet["Ciro"]).ToString("N2") + "₺";
            lblLitre.Text = ((decimal)ozet["Litre"]).ToString("N2") + " L";
            lblOrtalama.Text = ((decimal)ozet["Ortalama"]).ToString("N2") + "₺";
        }

        private void Satislar_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Yenile();
        }


    }
}
