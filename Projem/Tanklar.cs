using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projem
{
    public partial class Tanklar : UserControl
    {
        int secilenTank = 0;
        public Tanklar()
        {
            InitializeComponent();

        }


        private void TanklariGuncelle()
        {
            DataTable dt = VeriTabani.TanklariGetir();

            TankGoster(barTank1, lblTankKalan1, dt.Rows[0]);
            TankGoster(barTank2, lblTankKalan2, dt.Rows[1]);
            TankGoster(barTank3, lblTankKalan3, dt.Rows[2]);
            TankGoster(barTank4, lblTankKalan4, dt.Rows[3]);
            TankGoster(barTank5, lblTankKalan5, dt.Rows[4]);
            TankGoster(barTank6, lblTankKalan6, dt.Rows[5]);
        }

        private void TankGoster(ProgressBar bar, Label lbl, DataRow satir)
        {
            decimal kapasite = (decimal)satir["kapasite"];
            decimal mevcut = (decimal)satir["mevcut_seviye"];
            decimal kritik = (decimal)satir["kritik_seviye"];

            bar.Maximum = (int)kapasite;
            bar.Value = (int)Math.Min(mevcut, kapasite);

            lbl.Text = mevcut.ToString("N0") + "L / " + kapasite.ToString("N0") + "L";
            lbl.ForeColor = mevcut <= kritik ? Color.Red : Color.Black;
        }

        private void Tanklar_Load(object sender, EventArgs e)
        {
            TanklariGuncelle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TanklariGuncelle();
        }

        private void pnlTank1_Click(object sender, EventArgs e)
        {
            secilenTank = 1;
            TankSec.Text = "TANK 1 - MOTORİN";
            pnlTankIslem.Enabled = true;
        }

        private void pnlTank2_Click(object sender, EventArgs e)
        {
            secilenTank = 2;
            TankSec.Text = "TANK 2 - MOTORİN";
            pnlTankIslem.Enabled = true;
        }

        private void pnlTank3_Click(object sender, EventArgs e)
        {
            secilenTank = 3;
            TankSec.Text = "TANK 3 - BENZİN";
            pnlTankIslem.Enabled = true;
        }

        private void pnlTank4_Click(object sender, EventArgs e)
        {
            secilenTank = 4;
            TankSec.Text = "TANK 4 - BENZİN";
            pnlTankIslem.Enabled = true;
        }

        private void pnlTank5_Click(object sender, EventArgs e)
        {
            secilenTank = 5;
            TankSec.Text = "TANK 5 - LPG";
            pnlTankIslem.Enabled = true;
        }

        private void pnlTank6_Click(object sender, EventArgs e)
        {
            secilenTank = 6;
            TankSec.Text = "TANK 6 - LPG";
            pnlTankIslem.Enabled = true;
        }

        private void btnDolum_Click(object sender, EventArgs e)
        {
            if (numTankLitre.Value == 0 || txtTedarikciAd.Text == "") return;

            decimal bosYer = VeriTabani.TankBosYer(secilenTank);

            if (numTankLitre.Value > bosYer)
            {
                MessageBox.Show("Tank kapasitesi aşılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VeriTabani.TankDolumYap(secilenTank, numTankLitre.Value, txtTedarikciAd.Text);
            MessageBox.Show("Tank dolumu başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            numTankLitre.Value = 0;
            txtTedarikciAd.Clear();
            TanklariGuncelle();
        }
    }
}
