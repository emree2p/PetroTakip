using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projem
{
    public partial class Raporlar : UserControl
    {
        int seciliRapor = 0;
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            dtpBaslangic.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpBitis.Value = DateTime.Today;
        }

        private void pnlRaporKasa_Click(object sender, EventArgs e)
        {
            seciliRapor = 1;
            lblSecilen.Text = "Seçilen Rapor: Kasa Raporu";
        }

        private void pnlRaporSatis_Click(object sender, EventArgs e)
        {
            seciliRapor = 2;
            lblSecilen.Text = "Seçilen Rapor: Satış Raporu";
        }

        private void pnlRaporStok_Click(object sender, EventArgs e)
        {
            seciliRapor = 3;
            lblSecilen.Text = "Seçilen Rapor: Stok Raporu"; 
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (seciliRapor == 1)
            {
                RaporOlustur();
            }
            else if (seciliRapor == 2)
            {
                RaporOlustur();
            }
            else if (seciliRapor == 3)
            {
                RaporOlustur();
            }
            else
            {
                MessageBox.Show("Lütfen bir rapor türü seçin.");
            }
        }

        private void btnDisaAktar_Click(object sender, EventArgs e)
        {
            if (dgvRapor.Rows.Count == 0) return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Dosyası|*.csv";
            sfd.FileName = "Rapor.csv";
            if(sfd.ShowDialog() != DialogResult.OK) return;

            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewColumn kolon in dgvRapor.Columns)
            
                sb.Append(kolon.HeaderText + ";");
                sb.AppendLine();


            foreach (DataGridViewRow satir in dgvRapor.Rows)
            {
                foreach (DataGridViewCell hucre in satir.Cells)
                {
                    sb.Append(hucre.FormattedValue + ";");
                sb.AppendLine();
                }

                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
            }
        }

        private void RaporOlustur()
        {
            DateTime bas = dtpBaslangic.Value.Date;
            DateTime bit = dtpBitis.Value.Date;

            if (bas > bit)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden sonra olamaz.");
                return;
            }

            dgvRapor.Columns.Clear();

            if(seciliRapor == 1) dgvRapor.DataSource = VeriTabani.KasaRaporuGetir(bas, bit);
            else if (seciliRapor == 2) dgvRapor.DataSource = VeriTabani.SatisRaporuGetir(bas, bit);
            else if (seciliRapor == 3 ) dgvRapor.DataSource = VeriTabani.StokRaporuGetir(bas, bit);

            foreach (DataGridViewColumn kolon in dgvRapor.Columns)
            {
                if (kolon.ValueType == typeof(decimal)) kolon.DefaultCellStyle.Format = "N2";
                else if (kolon.ValueType == typeof(DateTime)) kolon.DefaultCellStyle.Format = "dd.MM.yyyy";
            }

            lblOzet.Text = dgvRapor.Rows.Count + " kayıt listelendi.";
        }


    }
}
