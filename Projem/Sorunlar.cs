using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projem
{
    public partial class Sorunlar : UserControl
    {
        public Sorunlar()
        {
            InitializeComponent();
        }

        private void Sorunlar_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void Yenile()
        {
            DataTable dt = VeriTabani.SorunlariGetir();
            dgvSorun.DataSource = dt;

            foreach (DataGridViewRow satir in dgvSorun.Rows)
            {
                DataRowView v = (DataRowView)satir.DataBoundItem;
                satir.DefaultCellStyle.ForeColor = v["durum"].ToString() == "Açık" ? Color.Firebrick : Color.Gray;
            }

            lblMevcutSorun.Text = dt.Select("durum = 'Açık'").Length.ToString();
            lblPompaArizasi.Text = dt.Select("Durum = 'Açık' AND [Tür] = 'Pompa Arızası'").Length.ToString();
            lblKritikStok.Text = dt.Select("Durum = 'Açık' AND [Tür] = 'Kritik Stok'").Length.ToString();
            lblCozulen.Text = dt.Select("Durum = 'Çözüldü'").Length.ToString();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}
