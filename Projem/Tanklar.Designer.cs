namespace Projem
{
    partial class Tanklar
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flpTank = new FlowLayoutPanel();
            pnlTank1 = new Panel();
            barTank1 = new ProgressBar();
            lblTankKalan1 = new Label();
            lblYakıtTank1 = new Label();
            lblMotorin1 = new Label();
            pnlTank2 = new Panel();
            lblTankKalan2 = new Label();
            lblYakıtTank2 = new Label();
            lblMotorin2 = new Label();
            barTank2 = new ProgressBar();
            pnlTank3 = new Panel();
            lblTankKalan3 = new Label();
            lblYakıtTank3 = new Label();
            lblBenzin1 = new Label();
            barTank3 = new ProgressBar();
            pnlTank4 = new Panel();
            lblTankKalan4 = new Label();
            lblYakıtTank4 = new Label();
            lblBenzin2 = new Label();
            barTank4 = new ProgressBar();
            pnlTank5 = new Panel();
            lblTankKalan5 = new Label();
            lblYakıtTank5 = new Label();
            lblLPG1 = new Label();
            barTank5 = new ProgressBar();
            pnlTank6 = new Panel();
            lblTankKalan6 = new Label();
            lblYakıtTank6 = new Label();
            lblLPG2 = new Label();
            barTank6 = new ProgressBar();
            pnlTankIslem = new Panel();
            TankSec = new Label();
            numTankLitre = new NumericUpDown();
            label1 = new Label();
            txtTedarikciAd = new TextBox();
            btnDolum = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            flpTank.SuspendLayout();
            pnlTank1.SuspendLayout();
            pnlTank2.SuspendLayout();
            pnlTank3.SuspendLayout();
            pnlTank4.SuspendLayout();
            pnlTank5.SuspendLayout();
            pnlTank6.SuspendLayout();
            pnlTankIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTankLitre).BeginInit();
            SuspendLayout();
            // 
            // flpTank
            // 
            flpTank.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flpTank.BackColor = Color.White;
            flpTank.Controls.Add(pnlTank1);
            flpTank.Controls.Add(pnlTank2);
            flpTank.Controls.Add(pnlTank3);
            flpTank.Controls.Add(pnlTank4);
            flpTank.Controls.Add(pnlTank5);
            flpTank.Controls.Add(pnlTank6);
            flpTank.Location = new Point(0, 0);
            flpTank.Name = "flpTank";
            flpTank.Size = new Size(780, 832);
            flpTank.TabIndex = 0;
            // 
            // pnlTank1
            // 
            pnlTank1.BackColor = Color.Transparent;
            pnlTank1.BackgroundImage = Properties.Resources.motorin_tank;
            pnlTank1.BackgroundImageLayout = ImageLayout.Zoom;
            pnlTank1.Controls.Add(barTank1);
            pnlTank1.Controls.Add(lblTankKalan1);
            pnlTank1.Controls.Add(lblYakıtTank1);
            pnlTank1.Controls.Add(lblMotorin1);
            pnlTank1.Location = new Point(3, 3);
            pnlTank1.Margin = new Padding(3, 3, 7, 35);
            pnlTank1.Name = "pnlTank1";
            pnlTank1.Size = new Size(380, 238);
            pnlTank1.TabIndex = 0;
            pnlTank1.Click += pnlTank1_Click;
            // 
            // barTank1
            // 
            barTank1.Location = new Point(53, 106);
            barTank1.Name = "barTank1";
            barTank1.Size = new Size(275, 38);
            barTank1.TabIndex = 0;
            barTank1.Click += pnlTank1_Click;
            // 
            // lblTankKalan1
            // 
            lblTankKalan1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTankKalan1.Location = new Point(107, 145);
            lblTankKalan1.Name = "lblTankKalan1";
            lblTankKalan1.Size = new Size(135, 23);
            lblTankKalan1.TabIndex = 3;
            lblTankKalan1.TextAlign = ContentAlignment.MiddleCenter;
            lblTankKalan1.Click += pnlTank1_Click;
            // 
            // lblYakıtTank1
            // 
            lblYakıtTank1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakıtTank1.Location = new Point(170, 80);
            lblYakıtTank1.Name = "lblYakıtTank1";
            lblYakıtTank1.Size = new Size(100, 23);
            lblYakıtTank1.TabIndex = 2;
            lblYakıtTank1.Text = "Tank - 1";
            lblYakıtTank1.TextAlign = ContentAlignment.MiddleCenter;
            lblYakıtTank1.Click += pnlTank1_Click;
            // 
            // lblMotorin1
            // 
            lblMotorin1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMotorin1.Location = new Point(170, 57);
            lblMotorin1.Name = "lblMotorin1";
            lblMotorin1.Size = new Size(100, 23);
            lblMotorin1.TabIndex = 1;
            lblMotorin1.Text = "MOTORİN";
            lblMotorin1.TextAlign = ContentAlignment.MiddleCenter;
            lblMotorin1.Click += pnlTank1_Click;
            // 
            // pnlTank2
            // 
            pnlTank2.BackColor = Color.Transparent;
            pnlTank2.BackgroundImage = Properties.Resources.motorin_tank;
            pnlTank2.BackgroundImageLayout = ImageLayout.Zoom;
            pnlTank2.Controls.Add(lblTankKalan2);
            pnlTank2.Controls.Add(lblYakıtTank2);
            pnlTank2.Controls.Add(lblMotorin2);
            pnlTank2.Controls.Add(barTank2);
            pnlTank2.Location = new Point(393, 3);
            pnlTank2.Margin = new Padding(3, 3, 7, 35);
            pnlTank2.Name = "pnlTank2";
            pnlTank2.Size = new Size(380, 238);
            pnlTank2.TabIndex = 1;
            pnlTank2.Click += pnlTank2_Click;
            // 
            // lblTankKalan2
            // 
            lblTankKalan2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTankKalan2.Location = new Point(106, 145);
            lblTankKalan2.Name = "lblTankKalan2";
            lblTankKalan2.Size = new Size(135, 23);
            lblTankKalan2.TabIndex = 5;
            lblTankKalan2.TextAlign = ContentAlignment.MiddleCenter;
            lblTankKalan2.Click += pnlTank2_Click;
            // 
            // lblYakıtTank2
            // 
            lblYakıtTank2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakıtTank2.Location = new Point(169, 80);
            lblYakıtTank2.Name = "lblYakıtTank2";
            lblYakıtTank2.Size = new Size(100, 23);
            lblYakıtTank2.TabIndex = 4;
            lblYakıtTank2.Text = "Tank - 2";
            lblYakıtTank2.TextAlign = ContentAlignment.MiddleCenter;
            lblYakıtTank2.Click += pnlTank2_Click;
            // 
            // lblMotorin2
            // 
            lblMotorin2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMotorin2.Location = new Point(169, 57);
            lblMotorin2.Name = "lblMotorin2";
            lblMotorin2.Size = new Size(100, 23);
            lblMotorin2.TabIndex = 3;
            lblMotorin2.Text = "MOTORİN";
            lblMotorin2.TextAlign = ContentAlignment.MiddleCenter;
            lblMotorin2.Click += pnlTank2_Click;
            // 
            // barTank2
            // 
            barTank2.Location = new Point(53, 106);
            barTank2.Name = "barTank2";
            barTank2.Size = new Size(275, 38);
            barTank2.TabIndex = 1;
            barTank2.Click += pnlTank2_Click;
            // 
            // pnlTank3
            // 
            pnlTank3.BackColor = Color.Transparent;
            pnlTank3.BackgroundImage = Properties.Resources.benzin_tank;
            pnlTank3.BackgroundImageLayout = ImageLayout.Zoom;
            pnlTank3.Controls.Add(lblTankKalan3);
            pnlTank3.Controls.Add(lblYakıtTank3);
            pnlTank3.Controls.Add(lblBenzin1);
            pnlTank3.Controls.Add(barTank3);
            pnlTank3.Location = new Point(3, 279);
            pnlTank3.Margin = new Padding(3, 3, 7, 35);
            pnlTank3.Name = "pnlTank3";
            pnlTank3.Size = new Size(380, 238);
            pnlTank3.TabIndex = 2;
            pnlTank3.Click += pnlTank3_Click;
            // 
            // lblTankKalan3
            // 
            lblTankKalan3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTankKalan3.Location = new Point(107, 145);
            lblTankKalan3.Name = "lblTankKalan3";
            lblTankKalan3.Size = new Size(135, 23);
            lblTankKalan3.TabIndex = 5;
            lblTankKalan3.TextAlign = ContentAlignment.MiddleCenter;
            lblTankKalan3.Click += pnlTank3_Click;
            // 
            // lblYakıtTank3
            // 
            lblYakıtTank3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakıtTank3.Location = new Point(170, 79);
            lblYakıtTank3.Name = "lblYakıtTank3";
            lblYakıtTank3.Size = new Size(100, 23);
            lblYakıtTank3.TabIndex = 4;
            lblYakıtTank3.Text = "Tank - 3";
            lblYakıtTank3.TextAlign = ContentAlignment.MiddleCenter;
            lblYakıtTank3.Click += pnlTank3_Click;
            // 
            // lblBenzin1
            // 
            lblBenzin1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBenzin1.Location = new Point(170, 56);
            lblBenzin1.Name = "lblBenzin1";
            lblBenzin1.Size = new Size(100, 23);
            lblBenzin1.TabIndex = 3;
            lblBenzin1.Text = "BENZİN";
            lblBenzin1.TextAlign = ContentAlignment.MiddleCenter;
            lblBenzin1.Click += pnlTank3_Click;
            // 
            // barTank3
            // 
            barTank3.Location = new Point(53, 106);
            barTank3.Name = "barTank3";
            barTank3.Size = new Size(275, 38);
            barTank3.TabIndex = 1;
            barTank3.Click += pnlTank3_Click;
            // 
            // pnlTank4
            // 
            pnlTank4.BackColor = Color.Transparent;
            pnlTank4.BackgroundImage = Properties.Resources.benzin_tank;
            pnlTank4.BackgroundImageLayout = ImageLayout.Zoom;
            pnlTank4.Controls.Add(lblTankKalan4);
            pnlTank4.Controls.Add(lblYakıtTank4);
            pnlTank4.Controls.Add(lblBenzin2);
            pnlTank4.Controls.Add(barTank4);
            pnlTank4.Location = new Point(393, 279);
            pnlTank4.Margin = new Padding(3, 3, 7, 35);
            pnlTank4.Name = "pnlTank4";
            pnlTank4.Size = new Size(380, 238);
            pnlTank4.TabIndex = 3;
            pnlTank4.Click += pnlTank4_Click;
            // 
            // lblTankKalan4
            // 
            lblTankKalan4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTankKalan4.Location = new Point(106, 147);
            lblTankKalan4.Name = "lblTankKalan4";
            lblTankKalan4.Size = new Size(135, 23);
            lblTankKalan4.TabIndex = 7;
            lblTankKalan4.TextAlign = ContentAlignment.MiddleCenter;
            lblTankKalan4.Click += pnlTank4_Click;
            // 
            // lblYakıtTank4
            // 
            lblYakıtTank4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakıtTank4.Location = new Point(169, 79);
            lblYakıtTank4.Name = "lblYakıtTank4";
            lblYakıtTank4.Size = new Size(100, 23);
            lblYakıtTank4.TabIndex = 6;
            lblYakıtTank4.Text = "Tank - 4";
            lblYakıtTank4.TextAlign = ContentAlignment.MiddleCenter;
            lblYakıtTank4.Click += pnlTank4_Click;
            // 
            // lblBenzin2
            // 
            lblBenzin2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBenzin2.Location = new Point(169, 56);
            lblBenzin2.Name = "lblBenzin2";
            lblBenzin2.Size = new Size(100, 23);
            lblBenzin2.TabIndex = 5;
            lblBenzin2.Text = "BENZİN";
            lblBenzin2.TextAlign = ContentAlignment.MiddleCenter;
            lblBenzin2.Click += pnlTank4_Click;
            // 
            // barTank4
            // 
            barTank4.Location = new Point(53, 106);
            barTank4.Name = "barTank4";
            barTank4.Size = new Size(275, 38);
            barTank4.TabIndex = 1;
            barTank4.Click += pnlTank4_Click;
            // 
            // pnlTank5
            // 
            pnlTank5.BackColor = Color.Transparent;
            pnlTank5.BackgroundImage = Properties.Resources.lpg_tank;
            pnlTank5.BackgroundImageLayout = ImageLayout.Zoom;
            pnlTank5.Controls.Add(lblTankKalan5);
            pnlTank5.Controls.Add(lblYakıtTank5);
            pnlTank5.Controls.Add(lblLPG1);
            pnlTank5.Controls.Add(barTank5);
            pnlTank5.Location = new Point(3, 555);
            pnlTank5.Margin = new Padding(3, 3, 7, 35);
            pnlTank5.Name = "pnlTank5";
            pnlTank5.Size = new Size(380, 238);
            pnlTank5.TabIndex = 4;
            pnlTank5.Click += pnlTank5_Click;
            // 
            // lblTankKalan5
            // 
            lblTankKalan5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTankKalan5.Location = new Point(107, 145);
            lblTankKalan5.Name = "lblTankKalan5";
            lblTankKalan5.Size = new Size(135, 23);
            lblTankKalan5.TabIndex = 7;
            lblTankKalan5.TextAlign = ContentAlignment.MiddleCenter;
            lblTankKalan5.Click += pnlTank5_Click;
            // 
            // lblYakıtTank5
            // 
            lblYakıtTank5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakıtTank5.Location = new Point(170, 77);
            lblYakıtTank5.Name = "lblYakıtTank5";
            lblYakıtTank5.Size = new Size(100, 23);
            lblYakıtTank5.TabIndex = 6;
            lblYakıtTank5.Text = "Tank - 5";
            lblYakıtTank5.TextAlign = ContentAlignment.MiddleCenter;
            lblYakıtTank5.Click += pnlTank5_Click;
            // 
            // lblLPG1
            // 
            lblLPG1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLPG1.Location = new Point(170, 54);
            lblLPG1.Name = "lblLPG1";
            lblLPG1.Size = new Size(100, 23);
            lblLPG1.TabIndex = 5;
            lblLPG1.Text = "LPG";
            lblLPG1.TextAlign = ContentAlignment.MiddleCenter;
            lblLPG1.Click += pnlTank5_Click;
            // 
            // barTank5
            // 
            barTank5.Location = new Point(54, 104);
            barTank5.Name = "barTank5";
            barTank5.Size = new Size(275, 38);
            barTank5.TabIndex = 1;
            barTank5.Click += pnlTank5_Click;
            // 
            // pnlTank6
            // 
            pnlTank6.BackColor = Color.Transparent;
            pnlTank6.BackgroundImage = Properties.Resources.lpg_tank;
            pnlTank6.BackgroundImageLayout = ImageLayout.Zoom;
            pnlTank6.Controls.Add(lblTankKalan6);
            pnlTank6.Controls.Add(lblYakıtTank6);
            pnlTank6.Controls.Add(lblLPG2);
            pnlTank6.Controls.Add(barTank6);
            pnlTank6.Location = new Point(393, 555);
            pnlTank6.Margin = new Padding(3, 3, 7, 35);
            pnlTank6.Name = "pnlTank6";
            pnlTank6.Size = new Size(380, 238);
            pnlTank6.TabIndex = 5;
            pnlTank6.Click += pnlTank6_Click;
            // 
            // lblTankKalan6
            // 
            lblTankKalan6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTankKalan6.Location = new Point(106, 145);
            lblTankKalan6.Name = "lblTankKalan6";
            lblTankKalan6.Size = new Size(135, 23);
            lblTankKalan6.TabIndex = 8;
            lblTankKalan6.TextAlign = ContentAlignment.MiddleCenter;
            lblTankKalan6.Click += pnlTank6_Click;
            // 
            // lblYakıtTank6
            // 
            lblYakıtTank6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakıtTank6.Location = new Point(169, 77);
            lblYakıtTank6.Name = "lblYakıtTank6";
            lblYakıtTank6.Size = new Size(100, 23);
            lblYakıtTank6.TabIndex = 6;
            lblYakıtTank6.Text = "Tank - 6";
            lblYakıtTank6.TextAlign = ContentAlignment.MiddleCenter;
            lblYakıtTank6.Click += pnlTank6_Click;
            // 
            // lblLPG2
            // 
            lblLPG2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLPG2.Location = new Point(169, 54);
            lblLPG2.Name = "lblLPG2";
            lblLPG2.Size = new Size(100, 23);
            lblLPG2.TabIndex = 5;
            lblLPG2.Text = "LPG";
            lblLPG2.TextAlign = ContentAlignment.MiddleCenter;
            lblLPG2.Click += pnlTank6_Click;
            // 
            // barTank6
            // 
            barTank6.Location = new Point(53, 104);
            barTank6.Name = "barTank6";
            barTank6.Size = new Size(275, 38);
            barTank6.TabIndex = 1;
            barTank6.Click += pnlTank6_Click;
            // 
            // pnlTankIslem
            // 
            pnlTankIslem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlTankIslem.BackColor = Color.FromArgb(22, 27, 34);
            pnlTankIslem.Controls.Add(TankSec);
            pnlTankIslem.Controls.Add(numTankLitre);
            pnlTankIslem.Controls.Add(label1);
            pnlTankIslem.Controls.Add(txtTedarikciAd);
            pnlTankIslem.Controls.Add(btnDolum);
            pnlTankIslem.Enabled = false;
            pnlTankIslem.Location = new Point(779, 0);
            pnlTankIslem.Name = "pnlTankIslem";
            pnlTankIslem.Size = new Size(294, 832);
            pnlTankIslem.TabIndex = 1;
            // 
            // TankSec
            // 
            TankSec.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TankSec.BackColor = Color.Transparent;
            TankSec.CausesValidation = false;
            TankSec.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TankSec.ForeColor = Color.White;
            TankSec.Location = new Point(0, 27);
            TankSec.Name = "TankSec";
            TankSec.Size = new Size(291, 41);
            TankSec.TabIndex = 12;
            TankSec.Text = "TANK SEÇİN";
            TankSec.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numTankLitre
            // 
            numTankLitre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numTankLitre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numTankLitre.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numTankLitre.Location = new Point(7, 83);
            numTankLitre.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            numTankLitre.Name = "numTankLitre";
            numTankLitre.Size = new Size(277, 29);
            numTankLitre.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.CausesValidation = false;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 120);
            label1.Name = "label1";
            label1.Size = new Size(287, 30);
            label1.TabIndex = 16;
            label1.Text = "Tedarikçi Ad";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTedarikciAd
            // 
            txtTedarikciAd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTedarikciAd.BackColor = Color.White;
            txtTedarikciAd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtTedarikciAd.Location = new Point(7, 153);
            txtTedarikciAd.Name = "txtTedarikciAd";
            txtTedarikciAd.Size = new Size(277, 29);
            txtTedarikciAd.TabIndex = 15;
            // 
            // btnDolum
            // 
            btnDolum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDolum.BackColor = Color.White;
            btnDolum.FlatAppearance.BorderSize = 0;
            btnDolum.FlatStyle = FlatStyle.Flat;
            btnDolum.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDolum.ForeColor = Color.Black;
            btnDolum.Location = new Point(7, 207);
            btnDolum.Name = "btnDolum";
            btnDolum.Size = new Size(277, 45);
            btnDolum.TabIndex = 14;
            btnDolum.Text = "DOLUMU KAYDET";
            btnDolum.UseVisualStyleBackColor = false;
            btnDolum.Click += btnDolum_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // Tanklar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlTankIslem);
            Controls.Add(flpTank);
            Name = "Tanklar";
            Size = new Size(1073, 832);
            Load += Tanklar_Load;
            flpTank.ResumeLayout(false);
            pnlTank1.ResumeLayout(false);
            pnlTank2.ResumeLayout(false);
            pnlTank3.ResumeLayout(false);
            pnlTank4.ResumeLayout(false);
            pnlTank5.ResumeLayout(false);
            pnlTank6.ResumeLayout(false);
            pnlTankIslem.ResumeLayout(false);
            pnlTankIslem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTankLitre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpTank;
        private Panel pnlTankIslem;
        private Panel pnlTank1;
        private Label lblMotorin1;
        private ProgressBar barTank1;
        private Panel pnlTank2;
        private ProgressBar barTank2;
        private Panel pnlTank3;
        private ProgressBar barTank3;
        private Panel pnlTank4;
        private ProgressBar barTank4;
        private Panel pnlTank5;
        private ProgressBar barTank5;
        private Panel pnlTank6;
        private ProgressBar barTank6;
        private Label lblYakıtTank1;
        private Label lblYakıtTank2;
        private Label lblMotorin2;
        private Label lblYakıtTank3;
        private Label lblBenzin1;
        private Label lblYakıtTank4;
        private Label lblBenzin2;
        private Label lblYakıtTank5;
        private Label lblLPG1;
        private Label lblYakıtTank6;
        private Label lblLPG2;
        private Label lblTankKalan1;
        private Label lblTankKalan2;
        private Label lblTankKalan3;
        private Label lblTankKalan4;
        private Label lblTankKalan5;
        private Label lblTankKalan6;
        private System.Windows.Forms.Timer timer1;
        private Label TankSec;
        private NumericUpDown numTankLitre;
        private Button btnDolum;
        private TextBox txtTedarikciAd;
        private Label label1;
    }
}
