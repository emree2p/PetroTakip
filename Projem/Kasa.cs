using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projem
{
    public partial class Kasa : UserControl
    {
        public Kasa()
        {
            InitializeComponent();
        }

        decimal KarZarar = Convert.ToDecimal(VeriTabani.KasaKarZarar().Rows[0]["KarZarar"]);

        private void Kasa_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void Yenile()
        {

            dgvStok.DataSource = VeriTabani.KasaGetir();

            DataRow ozet = VeriTabani.OzetGetir().Rows[0];

            lblAy.Text = Convert.ToDecimal(VeriTabani.KasaAyBasi().Rows[0]["ToplamAyBasi"]).ToString("N2") + "₺";
            lblGiren.Text = Convert.ToDecimal(VeriTabani.KasaGiren().Rows[0]["ToplamGiren"]).ToString("N2") + "₺";
            lblCikan.Text = Convert.ToDecimal(VeriTabani.KasaCikan().Rows[0]["ToplamCikan"]).ToString("N2") + "₺";
            lblKarZarar.Text = Convert.ToDecimal(VeriTabani.KasaKarZarar().Rows[0]["KarZarar"]).ToString("N2") + "₺";
            lblCiro1.Text = ((decimal)ozet["Ciro"]).ToString("N2") + "₺";
            lblLitre1.Text = ((decimal)ozet["Litre"]).ToString("N2") + " L";
            lblOrtalama1.Text = ((decimal)ozet["Ortalama"]).ToString("N2") + "₺";

            if (KarZarar < 0)
            {
                pnlZarar.BackgroundImage = Properties.Resources.kasa_zarar;
                lblKarZarar.ForeColor = Color.FromArgb(239, 68, 68);
            }
            else
            {
                pnlZarar.BackgroundImage = Properties.Resources.kasa_kar;
                lblKarZarar.ForeColor = Color.FromArgb(6, 182, 212);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Yenile();
        }

        private void dgvStok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
