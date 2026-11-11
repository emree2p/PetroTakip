using System.Drawing.Drawing2D;

namespace Projem;

public partial class kntPanel : Form
{
    private Pompalar pompalar;
    private Tanklar tanklar;
    private Satislar satislar;
    private Stoklar stoklar;
    private Kasa kasa;
    private Personeller personel;
    private Raporlar raporlar;
    private Sorunlar sorunlar;

    private UserControl aktifKontrol;

    private void ModulGoster(UserControl kontrol)
    {
        if (kontrol == null) return;
        if (aktifKontrol == kontrol) return;

        if (aktifKontrol != null)
            pnlIcerik.Controls.Remove(aktifKontrol);

        kontrol.Dock = DockStyle.Fill;
        pnlIcerik.Controls.Add(kontrol);
        kontrol.BringToFront();
        aktifKontrol = kontrol;
    }

    public kntPanel()
    {
        InitializeComponent();
    }
    // 34, 197, 94
    private void btnKontrol_Click(object sender, EventArgs e)
    {
        if (aktifKontrol != null)
        {
            pnlIcerik.Controls.Remove(aktifKontrol);
            aktifKontrol = null;
        }

        Text = "PetroTakip Akaryakıt Sistemi - Kontrol Paneli";
    }

    private void btnPompa_Click(object sender, EventArgs e)
    {

        if (pompalar == null)
            pompalar = new Pompalar();
        ModulGoster(pompalar);

        Text = "PetroTakip Akaryakıt Sistemi - Pompalar";
    }

    private void btnTank_Click(object sender, EventArgs e)
    {
        if (tanklar == null)
        {
            tanklar = new Tanklar();
        }
        ModulGoster(tanklar);
        Text = "PetroTakip Akaryakıt Sistemi - Tanklar";
    }

    private void btnSatis_Click(object sender, EventArgs e)
    {
        if (satislar == null)
        {
            satislar = new Satislar();
        }
        ModulGoster(satislar);
        Text = "PetroTakip Akaryakıt Sistemi - Satışlar";
    }

    private void btnStok_Click(object sender, EventArgs e)
    {
        if (stoklar == null)
        {
            stoklar = new Stoklar();
        }
        ModulGoster(stoklar);
        Text = "PetroTakip Akaryakıt Sistemi - Stoklar";
    }

    private void btnKasa_Click(object sender, EventArgs e)
    {
        if (kasa == null)
        {
            kasa = new Kasa();
        }
        ModulGoster(kasa);
        Text = "PetroTakip Akaryakıt Sistemi - Kasa";
    }

    private void btnPersonel_Click(object sender, EventArgs e)
    {
        if (personel == null)
        {
            personel = new Personeller();
        }
        ModulGoster(personel);
        Text = "PetroTakip Akaryakıt Sistemi - Personeller";
    }

    private void btnRaporlar_Click(object sender, EventArgs e)
    {
        if (raporlar == null)
        {
            raporlar = new Raporlar();
        }
        ModulGoster(raporlar);
        Text = "PetroTakip Akaryakıt Sistemi - Raporlar";
    }

    private void btnpnlAcKapa_Click(object sender, EventArgs e)
    {
        if (pnlMenu.Width > 100)
        {
            pnlMenu.Width = 62;
        }
        else
        {
            pnlMenu.Width = 230;
        }

        if (pctIcon.Visible == false)
        {
            pctIcon.Visible = true;
        }
        else
        {
            pctIcon.Visible = false;
        }

        if (btnKontrol.Text == "Kontrol Paneli")
        {
            btnKontrol.Text = "";
        }
        else
        {
            btnKontrol.Text = "Kontrol Paneli";
        }

        if (btnPompa.Text == "Pompalar")
        {
            btnPompa.Text = "";
        }
        else
        {
            btnPompa.Text = "Pompalar";
        }

        if (btnTank.Text == "Tanklar")
        {
            btnTank.Text = "";
        }
        else
        {
            btnTank.Text = "Tanklar";
        }

        if (btnSatis.Text == "Satışlar")
        {
            btnSatis.Text = "";
        }
        else
        {
            btnSatis.Text = "Satışlar";
        }

        if (btnStok.Text == "Stok")
        {
            btnStok.Text = "";
        }
        else
        {
            btnStok.Text = "Stok";
        }

        if (btnKasa.Text == "Kasa")
        {
            btnKasa.Text = "";
        }
        else
        {
            btnKasa.Text = "Kasa";
        }

        if (btnPersonel.Text == "Personel")
        {
            btnPersonel.Text = "";
        }
        else
        {
            btnPersonel.Text = "Personel";
        }

        if (btnRaporlar.Text == "Raporlar")
        {
            btnRaporlar.Text = "";
        }
        else
        {
            btnRaporlar.Text = "Raporlar";
        }

        if (btnSorunlar.Text == "Sorunlar")
        {
            btnSorunlar.Text = "";
        }
        else
        {
            btnSorunlar.Text = "Sorunlar";
        }
    }

    private void btnSorunlar_Click(object sender, EventArgs e)
    {
        if (sorunlar == null)
        {
            sorunlar = new Sorunlar();
        }
        ModulGoster(sorunlar);
        Text = "PetroTakip Akaryakıt Sistemi - Sorunlar";
    }
    private async void kntPanel_Load(object sender, EventArgs e)
    {
        try
        {
            await VeriTabani.FiyatGuncelle();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Fiyat güncelleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        Yenile();
    }

    private void Yenile()
    {
        DataTable sorunlar = VeriTabani.SorunlariGetir();
        DataRow ay = VeriTabani.KasaOzetGetir(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)); DataRow ozet = VeriTabani.OzetGetir().Rows[0];
        KpCiro.Text = ((decimal)ozet["Ciro"]).ToString("N2") + "₺";
        KpLitre.Text = ((decimal)ozet["Litre"]).ToString("N2") + " L";
        int ariza = sorunlar.Select("Durum = 'Açık' AND [Tür] = 'Pompa Arızası'").Length;
        int kritik = sorunlar.Select("Durum = 'Açık' AND [Tür] = 'Kritik Stok'").Length;
        UyariSayi.Text = (ariza + kritik).ToString();
        UyariYazi.Text = ariza + " arıza, " + kritik + " kritik stok";
        decimal net = (decimal)ay["Giren"] - (decimal)ay["Cikan"];
        KpNet.Text = net.ToString("N2") + " ₺";
        if (net < 0)
        {
            pnlKpNet.BackgroundImage = Properties.Resources.kp_netZarar;
            KpNet.ForeColor = Color.FromArgb(248, 113, 113);
        }
        else
        {
            pnlKpNet.BackgroundImage = Properties.Resources.kp_netKar;
            KpNet.ForeColor = Color.FromArgb(74, 222, 128);
        }

        PompalariYaz();
        TanklariYaz();
        sonsatis();
    }

    private void TankGoster(ProgressBar bar, Label lbl, DataRow satir)
    {
        decimal kapasite = (decimal)satir["kapasite"];
        decimal mevcut = (decimal)satir["mevcut_seviye"];
        decimal kritik = (decimal)satir["kritik_seviye"];

        bar.Maximum = (int)kapasite;
        bar.Value = (int)Math.Min(mevcut, kapasite);

        lbl.Text = mevcut.ToString("N0") + " L / " + kapasite.ToString("N0") + " L";
        lbl.ForeColor = mevcut <= kritik ? Color.FromArgb(248, 113, 113) : Color.White;
    }

    private void TanklariYaz()
    {
        DataTable dt = VeriTabani.TanklariGetir();

        TankGoster(barTank1, lblTankKapasite1, dt.Rows[0]);
        TankGoster(barTank2, lblTankKapasite2, dt.Rows[1]);
        TankGoster(barTank3, lblTankKapasite3, dt.Rows[2]);
        TankGoster(barTank4, lblTankKapasite4, dt.Rows[3]);
        TankGoster(barTank5, lblTankKapasite5, dt.Rows[4]);
        TankGoster(barTank6, lblTankKapasite6, dt.Rows[5]);
    }

    private void DurumYaz(Label lbl, string durum)
    {
        lbl.Text = "● " + durum;

        if (durum == "Aktif") lbl.ForeColor = Color.FromArgb(96, 165, 250);
        else if (durum == "Arızalı") lbl.ForeColor = Color.FromArgb(248, 113, 113);
        else lbl.ForeColor = Color.FromArgb(74, 222, 128);
    }

    private void PompalariYaz()
    {
        DataTable dt = VeriTabani.PompaDurumLariGetir();
        DurumYaz(KpDurum1, dt.Rows[0]["durum"].ToString());
        DurumYaz(KpDurum2, dt.Rows[1]["durum"].ToString());
        DurumYaz(KpDurum3, dt.Rows[2]["durum"].ToString());
        DurumYaz(KpDurum4, dt.Rows[3]["durum"].ToString());
        DurumYaz(KpDurum5, dt.Rows[4]["durum"].ToString());
        DurumYaz(KpDurum6, dt.Rows[5]["durum"].ToString());

        int aktif = dt.Select("durum = 'Aktif'").Length;
        int bosta = dt.Select("durum = 'Boşta'").Length;
        int ariza = dt.Select("durum = 'Arızalı'").Length;

        UyariSayiYazi.Text = aktif + " çalışan, " + bosta + " boşta, " + ariza + " arızalı";
        UyariSayiYazi.ForeColor = ariza > 0 ? Color.FromArgb(137, 150, 163) : Color.FromArgb(137, 150, 163);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        Yenile();
    }

    private void sonsatis()
    {
        DataTable sonsatislar = VeriTabani.SonSatislar();
        dgvKPSatis.DataSource = VeriTabani.SonSatislar();
    }
    private void timer2_Tick(object sender, EventArgs e)
    {
        sonsatis();
    }
}
