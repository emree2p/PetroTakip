using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projem
{
    public partial class Personeller : UserControl
    {
        public Personeller()
        {
            InitializeComponent();
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void Yenile()
        {
            dgvPersonel.DataSource = VeriTabani.PersonelGetir();

            lblToplam.Text = VeriTabani.PersonelSayisiGetir("").ToString();
            lblYonetici.Text = VeriTabani.PersonelSayisiGetir("Yönetici").ToString();
            lblPompaci.Text = VeriTabani.PersonelSayisiGetir("Pompacı").ToString();
            lblKasiyer.Text = VeriTabani.PersonelSayisiGetir("Kasiyer").ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() == "" || txtSoyad.Text.Trim() == "" || cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                VeriTabani.PersonelEkle(txtAd.Text.Trim(), txtSoyad.Text.Trim(), cmbRol.Text);
                txtAd.Clear();
                txtSoyad.Clear();
                cmbRol.SelectedIndex = -1;

            }
            Yenile();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvPersonel.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPersonel.SelectedRows[0].Cells["colNo"].Value);

                if (MessageBox.Show("Seçili personel silinsin mi?", "Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        VeriTabani.PersonelSil(id);
                        Yenile();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Bu personelin satış, kasa ya da rapor kaydı var, silinemez.");
                    }
                }
            }
        }
    }
}
