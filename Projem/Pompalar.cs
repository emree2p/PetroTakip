namespace Projem
{
    public partial class Pompalar : UserControl
    {
        public Pompalar()
        {
            InitializeComponent();
        }
        private Label Etiket(string ad)
        {
            return (Label)Controls.Find(ad + calisanPompa, true)[0];
        }
        int secilenPompa = 0;
        int calisanPompa = 0, calisanPersonel = 0;
        string calisanPlaka = "";
        decimal sayac = 0, hedef = 0, fiyat = 0, hedeftutar = 0;

        private void ArizaAcKapa()
        {
            if (secilenPompa == 0)
            {
                btnArizaGider.Visible = false;
                return;
            }

            Label durum = (Label)Controls.Find("lblDurum" + secilenPompa, true)[0];
            btnArizaGider.Visible = durum.Text.Contains("Arızalı");
        }

        private void FiyatYaz()
        {
            lblFiyat1.Text = VeriTabani.FiyatGetir(1).ToString("N2") + "₺ / L";
            lblFiyat2.Text = VeriTabani.FiyatGetir(2).ToString("N2") + "₺ / L";
            lblFiyat3.Text = VeriTabani.FiyatGetir(3).ToString("N2") + "₺ / L";
            lblFiyat4.Text = VeriTabani.FiyatGetir(4).ToString("N2") + "₺ / L";
            lblFiyat5.Text = VeriTabani.FiyatGetir(5).ToString("N2") + "₺ / L";
            lblFiyat6.Text = VeriTabani.FiyatGetir(6).ToString("N2") + "₺ / L";
        }

        private void satisibitir(decimal tutar)
        {
            timer1.Stop();

            VeriTabani.SatisYap(calisanPompa, calisanPersonel, calisanPlaka, sayac, Math.Round(tutar, 2));

            Etiket("lblDurum").Text = "● Boşta";
            Etiket("lblDurum").ForeColor = Color.FromArgb(74, 222, 128);
            VeriTabani.PompaDurumYaz(calisanPompa, "Boşta");
        }

        private void DurumGoster(Label lbl, int pompaId)
        {
            if (VeriTabani.DurumGetir(pompaId) == "Arızalı")
            {
                lbl.Text = "● Arızalı";
                lbl.ForeColor = Color.FromArgb(248, 113, 113);
            }
        }
        private void Pompalar_Load(object sender, EventArgs e)
        {
            FiyatYaz();
            ArizaAcKapa();
            DurumGoster(lblDurum1, 1);
            DurumGoster(lblDurum2, 2);
            DurumGoster(lblDurum3, 3);
            DurumGoster(lblDurum4, 4);
            DurumGoster(lblDurum5, 5);
            DurumGoster(lblDurum6, 6);

            cmbPersonel.DataSource = VeriTabani.PompaciGetir();
            cmbPersonel.DisplayMember = "adsoyad";
            cmbPersonel.ValueMember = "personel_id";
            cmbPersonel.SelectedIndex = -1;
        }

        private void pnlPompa1_Click(object sender, EventArgs e)
        {
            secilenPompa = 1;
            lblIslemBaslik.Text = "POMPA 1";
            lblYakit.Text = "MOTORİN";
            pnlIslem.Enabled = true;
            ArizaAcKapa();
        }

        private void pnlPompa2_Click(object sender, EventArgs e)
        {
            secilenPompa = 2;
            lblIslemBaslik.Text = "POMPA 2";
            lblYakit.Text = "MOTORİN";
            pnlIslem.Enabled = true;
            ArizaAcKapa();
        }

        private void pnlPompa3_Click(object sender, EventArgs e)
        {
            secilenPompa = 3;
            lblIslemBaslik.Text = "POMPA 3";
            lblYakit.Text = "BENZİN";
            pnlIslem.Enabled = true;
            ArizaAcKapa();
        }

        private void pnlPompa4_Click(object sender, EventArgs e)
        {
            secilenPompa = 4;
            lblIslemBaslik.Text = "POMPA 4";
            lblYakit.Text = "BENZİN";
            pnlIslem.Enabled = true;
            ArizaAcKapa();
        }

        private void pnlPompa5_Click(object sender, EventArgs e)
        {
            secilenPompa = 5;
            lblIslemBaslik.Text = "POMPA 5";
            lblYakit.Text = "LPG";
            pnlIslem.Enabled = true;
            ArizaAcKapa();
        }

        private void pnlPompa6_Click(object sender, EventArgs e)
        {
            secilenPompa = 6;
            lblIslemBaslik.Text = "POMPA 6";
            lblYakit.Text = "LPG";
            pnlIslem.Enabled = true;
            ArizaAcKapa();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;

            calisanPompa = secilenPompa;

            if (Etiket("lblDurum").Text.Contains("Arızalı")) return;

            decimal girilenTutar = 0;
            decimal.TryParse(txtFiyat.Text.Replace('.', ','), out girilenTutar);

            if (cmbPersonel.SelectedIndex == -1 || txtPlaka.Text.Trim() == "")
            {
                MessageBox.Show("Pompacı ve plaka girin.");
                return;
            }
            if (numLitre.Value == 0 && girilenTutar == 0)
            {
                MessageBox.Show("Litre ya da tutar girin.");
                return;
            }
            if (numLitre.Value > 0 && girilenTutar > 0)
            {
                MessageBox.Show("Litre ve tutardan sadece birini girin.");
                return;
            }

            fiyat = VeriTabani.FiyatGetir(calisanPompa);

            if (girilenTutar > 0)
            {
                hedef = Math.Round(girilenTutar / fiyat, 2);
                hedeftutar = girilenTutar;
            }
            else
            {
                hedef = numLitre.Value;
                hedeftutar = 0;
            }

            if (hedef <= 0)
            {
                MessageBox.Show("Miktar çok küçük.");
                return;
            }
            if (VeriTabani.TankSeviyeGetir(calisanPompa) < hedef)
            {
                MessageBox.Show("Tankta yeterli yakıt yok.");
                return;
            }

            calisanPersonel = (int)cmbPersonel.SelectedValue;
            calisanPlaka = txtPlaka.Text.Trim();
            sayac = 0;

            Etiket("lblDurum").Text = "● Aktif";
            Etiket("lblDurum").ForeColor = Color.FromArgb(96, 165, 250);
            VeriTabani.PompaDurumYaz(calisanPompa, "Aktif");
            timer1.Start();
        }

        private void btnArizali_Click(object sender, EventArgs e)
        {
            Label durum = (Label)Controls.Find("lblDurum" + secilenPompa, true)[0];

            durum.Text = "● Arızalı";
            durum.ForeColor = Color.FromArgb(248, 113, 113);
            VeriTabani.PompaDurumYaz(secilenPompa, "Arızalı");
            ArizaAcKapa();
        }

        private void btnArizaGider_Click(object sender, EventArgs e)
        {
            Label durum = (Label)Controls.Find("lblDurum" + secilenPompa, true)[0];

            durum.Text = "● Boşta";
            durum.ForeColor = Color.FromArgb(74, 222, 128);
            VeriTabani.PompaDurumYaz(secilenPompa, "Boşta");
            ArizaAcKapa();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac = Math.Min(sayac + 0.2m, hedef);

            decimal tutar = sayac * fiyat;
            if (hedeftutar > 0 && sayac == hedef) tutar = hedeftutar;

            Etiket("lblLitre").Text = sayac.ToString("N2") + " L";
            Etiket("lblTutar").Text = tutar.ToString("N2") + " TL";

            if (sayac == hedef) satisibitir(tutar);
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                MessageBox.Show("Satış devam ediyor.");
                return;
            }

            if (calisanPompa != 0)
            {
                Etiket("lblLitre").Text = "0,00 L";
                Etiket("lblTutar").Text = "0,00 TL";
            }

            txtPlaka.Clear();
            txtFiyat.Clear();
            numLitre.Value = 0;
            cmbPersonel.SelectedIndex = -1;
        }

        private void pnlPompa1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
