namespace Projem
{
    partial class Pompalar
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
            flpPompalar = new FlowLayoutPanel();
            pnlPompa1 = new Panel();
            lblFiyat1 = new Label();
            lblDurum1 = new Label();
            lblTutar1 = new Label();
            lblLitre1 = new Label();
            lblYakitMotorin1 = new Label();
            lblPompaNo1 = new Label();
            pnlPompa2 = new Panel();
            lblFiyat2 = new Label();
            lblDurum2 = new Label();
            lblTutar2 = new Label();
            lblLitre2 = new Label();
            lblYakitMotorin2 = new Label();
            lblPompaNo2 = new Label();
            pnlPompa3 = new Panel();
            lblFiyat3 = new Label();
            lblDurum3 = new Label();
            lblTutar3 = new Label();
            lblLitre3 = new Label();
            lblYakitBenzin1 = new Label();
            lblPompaNo3 = new Label();
            pnlPompa4 = new Panel();
            lblFiyat4 = new Label();
            lblDurum4 = new Label();
            lblTutar4 = new Label();
            lblLitre4 = new Label();
            lblYakitBenzin2 = new Label();
            lblPompaNo4 = new Label();
            pnlPompa5 = new Panel();
            lblFiyat5 = new Label();
            lblDurum5 = new Label();
            lblTutar5 = new Label();
            lblLitre5 = new Label();
            lblYakitLPG1 = new Label();
            lblPompaNo5 = new Label();
            pnlPompa6 = new Panel();
            lblFiyat6 = new Label();
            lblDurum6 = new Label();
            lblTutar6 = new Label();
            lblLitre6 = new Label();
            lblYakitLPG2 = new Label();
            lblPompaNo6 = new Label();
            pnlIslem = new Panel();
            labelTutarTL = new Label();
            txtFiyat = new TextBox();
            txtPlaka = new TextBox();
            lblPlaka = new Label();
            btnArizaGider = new Button();
            lblYakit = new Label();
            cmbPersonel = new ComboBox();
            btnArizali = new Button();
            btnTamamla = new Button();
            btnBaslat = new Button();
            numLitre = new NumericUpDown();
            labelMiktraL = new Label();
            lblPersonel = new Label();
            lblIslemBaslik = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            flpPompalar.SuspendLayout();
            pnlPompa1.SuspendLayout();
            pnlPompa2.SuspendLayout();
            pnlPompa3.SuspendLayout();
            pnlPompa4.SuspendLayout();
            pnlPompa5.SuspendLayout();
            pnlPompa6.SuspendLayout();
            pnlIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLitre).BeginInit();
            SuspendLayout();
            // 
            // flpPompalar
            // 
            flpPompalar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flpPompalar.AutoScroll = true;
            flpPompalar.BackColor = Color.White;
            flpPompalar.Controls.Add(pnlPompa1);
            flpPompalar.Controls.Add(pnlPompa2);
            flpPompalar.Controls.Add(pnlPompa3);
            flpPompalar.Controls.Add(pnlPompa4);
            flpPompalar.Controls.Add(pnlPompa5);
            flpPompalar.Controls.Add(pnlPompa6);
            flpPompalar.Location = new Point(0, 0);
            flpPompalar.Name = "flpPompalar";
            flpPompalar.Size = new Size(780, 832);
            flpPompalar.TabIndex = 0;
            // 
            // pnlPompa1
            // 
            pnlPompa1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPompa1.BackColor = Color.Transparent;
            pnlPompa1.BackgroundImage = Properties.Resources.kart_motorin;
            pnlPompa1.BackgroundImageLayout = ImageLayout.Stretch;
            pnlPompa1.Controls.Add(lblFiyat1);
            pnlPompa1.Controls.Add(lblDurum1);
            pnlPompa1.Controls.Add(lblTutar1);
            pnlPompa1.Controls.Add(lblLitre1);
            pnlPompa1.Controls.Add(lblYakitMotorin1);
            pnlPompa1.Controls.Add(lblPompaNo1);
            pnlPompa1.Location = new Point(10, 10);
            pnlPompa1.Margin = new Padding(10);
            pnlPompa1.Name = "pnlPompa1";
            pnlPompa1.Size = new Size(235, 395);
            pnlPompa1.TabIndex = 18;
            pnlPompa1.Click += pnlPompa1_Click;
            // 
            // lblFiyat1
            // 
            lblFiyat1.BackColor = Color.Transparent;
            lblFiyat1.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFiyat1.ForeColor = Color.FromArgb(156, 163, 175);
            lblFiyat1.Location = new Point(111, 333);
            lblFiyat1.Name = "lblFiyat1";
            lblFiyat1.Size = new Size(115, 43);
            lblFiyat1.TabIndex = 6;
            lblFiyat1.TextAlign = ContentAlignment.MiddleRight;
            lblFiyat1.Click += pnlPompa1_Click;
            // 
            // lblDurum1
            // 
            lblDurum1.BackColor = Color.Transparent;
            lblDurum1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDurum1.ForeColor = Color.FromArgb(74, 222, 128);
            lblDurum1.Location = new Point(12, 338);
            lblDurum1.Name = "lblDurum1";
            lblDurum1.Size = new Size(102, 28);
            lblDurum1.TabIndex = 5;
            lblDurum1.Text = "● Boşta";
            lblDurum1.TextAlign = ContentAlignment.MiddleCenter;
            lblDurum1.Click += pnlPompa1_Click;
            // 
            // lblTutar1
            // 
            lblTutar1.BackColor = Color.Transparent;
            lblTutar1.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTutar1.ForeColor = Color.FromArgb(250, 204, 21);
            lblTutar1.Location = new Point(29, 234);
            lblTutar1.Name = "lblTutar1";
            lblTutar1.Size = new Size(180, 45);
            lblTutar1.TabIndex = 4;
            lblTutar1.Text = "0,00 TL";
            lblTutar1.TextAlign = ContentAlignment.MiddleRight;
            lblTutar1.Click += pnlPompa1_Click;
            // 
            // lblLitre1
            // 
            lblLitre1.BackColor = Color.Transparent;
            lblLitre1.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLitre1.ForeColor = Color.FromArgb(250, 204, 21);
            lblLitre1.Location = new Point(29, 114);
            lblLitre1.Name = "lblLitre1";
            lblLitre1.Size = new Size(180, 45);
            lblLitre1.TabIndex = 3;
            lblLitre1.Text = "0,00 L";
            lblLitre1.TextAlign = ContentAlignment.MiddleRight;
            lblLitre1.Click += pnlPompa1_Click;
            // 
            // lblYakitMotorin1
            // 
            lblYakitMotorin1.BackColor = Color.Transparent;
            lblYakitMotorin1.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakitMotorin1.ForeColor = Color.FromArgb(255, 255, 255);
            lblYakitMotorin1.Location = new Point(110, 26);
            lblYakitMotorin1.Name = "lblYakitMotorin1";
            lblYakitMotorin1.Size = new Size(118, 34);
            lblYakitMotorin1.TabIndex = 2;
            lblYakitMotorin1.Text = "MOTORİN";
            lblYakitMotorin1.TextAlign = ContentAlignment.MiddleCenter;
            lblYakitMotorin1.Click += pnlPompa1_Click;
            // 
            // lblPompaNo1
            // 
            lblPompaNo1.BackColor = Color.Transparent;
            lblPompaNo1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPompaNo1.ForeColor = Color.FromArgb(255, 255, 255);
            lblPompaNo1.Location = new Point(3, 14);
            lblPompaNo1.Name = "lblPompaNo1";
            lblPompaNo1.Size = new Size(113, 58);
            lblPompaNo1.TabIndex = 1;
            lblPompaNo1.Text = "POMPA 1";
            lblPompaNo1.TextAlign = ContentAlignment.MiddleLeft;
            lblPompaNo1.Click += pnlPompa1_Click;
            // 
            // pnlPompa2
            // 
            pnlPompa2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPompa2.BackColor = Color.Transparent;
            pnlPompa2.BackgroundImage = Properties.Resources.kart_motorin;
            pnlPompa2.BackgroundImageLayout = ImageLayout.Stretch;
            pnlPompa2.Controls.Add(lblFiyat2);
            pnlPompa2.Controls.Add(lblDurum2);
            pnlPompa2.Controls.Add(lblTutar2);
            pnlPompa2.Controls.Add(lblLitre2);
            pnlPompa2.Controls.Add(lblYakitMotorin2);
            pnlPompa2.Controls.Add(lblPompaNo2);
            pnlPompa2.Location = new Point(265, 10);
            pnlPompa2.Margin = new Padding(10);
            pnlPompa2.Name = "pnlPompa2";
            pnlPompa2.Size = new Size(235, 395);
            pnlPompa2.TabIndex = 19;
            pnlPompa2.Click += pnlPompa2_Click;
            // 
            // lblFiyat2
            // 
            lblFiyat2.BackColor = Color.Transparent;
            lblFiyat2.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFiyat2.ForeColor = Color.FromArgb(156, 163, 175);
            lblFiyat2.Location = new Point(111, 333);
            lblFiyat2.Name = "lblFiyat2";
            lblFiyat2.Size = new Size(115, 43);
            lblFiyat2.TabIndex = 6;
            lblFiyat2.TextAlign = ContentAlignment.MiddleRight;
            lblFiyat2.Click += pnlPompa2_Click;
            // 
            // lblDurum2
            // 
            lblDurum2.BackColor = Color.Transparent;
            lblDurum2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDurum2.ForeColor = Color.FromArgb(74, 222, 128);
            lblDurum2.Location = new Point(12, 338);
            lblDurum2.Name = "lblDurum2";
            lblDurum2.Size = new Size(102, 28);
            lblDurum2.TabIndex = 5;
            lblDurum2.Text = "● Boşta";
            lblDurum2.TextAlign = ContentAlignment.MiddleCenter;
            lblDurum2.Click += pnlPompa2_Click;
            // 
            // lblTutar2
            // 
            lblTutar2.BackColor = Color.Transparent;
            lblTutar2.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTutar2.ForeColor = Color.FromArgb(250, 204, 21);
            lblTutar2.Location = new Point(29, 234);
            lblTutar2.Name = "lblTutar2";
            lblTutar2.Size = new Size(180, 45);
            lblTutar2.TabIndex = 4;
            lblTutar2.Text = "0,00 TL";
            lblTutar2.TextAlign = ContentAlignment.MiddleRight;
            lblTutar2.Click += pnlPompa2_Click;
            // 
            // lblLitre2
            // 
            lblLitre2.BackColor = Color.Transparent;
            lblLitre2.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLitre2.ForeColor = Color.FromArgb(250, 204, 21);
            lblLitre2.Location = new Point(29, 114);
            lblLitre2.Name = "lblLitre2";
            lblLitre2.Size = new Size(180, 45);
            lblLitre2.TabIndex = 3;
            lblLitre2.Text = "0,00 L";
            lblLitre2.TextAlign = ContentAlignment.MiddleRight;
            lblLitre2.Click += pnlPompa2_Click;
            // 
            // lblYakitMotorin2
            // 
            lblYakitMotorin2.BackColor = Color.Transparent;
            lblYakitMotorin2.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakitMotorin2.ForeColor = Color.FromArgb(255, 255, 255);
            lblYakitMotorin2.Location = new Point(110, 26);
            lblYakitMotorin2.Name = "lblYakitMotorin2";
            lblYakitMotorin2.Size = new Size(118, 34);
            lblYakitMotorin2.TabIndex = 2;
            lblYakitMotorin2.Text = "MOTORİN";
            lblYakitMotorin2.TextAlign = ContentAlignment.MiddleCenter;
            lblYakitMotorin2.Click += pnlPompa2_Click;
            // 
            // lblPompaNo2
            // 
            lblPompaNo2.BackColor = Color.Transparent;
            lblPompaNo2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPompaNo2.ForeColor = Color.FromArgb(255, 255, 255);
            lblPompaNo2.Location = new Point(3, 14);
            lblPompaNo2.Name = "lblPompaNo2";
            lblPompaNo2.Size = new Size(113, 58);
            lblPompaNo2.TabIndex = 1;
            lblPompaNo2.Text = "POMPA 2";
            lblPompaNo2.TextAlign = ContentAlignment.MiddleLeft;
            lblPompaNo2.Click += pnlPompa2_Click;
            // 
            // pnlPompa3
            // 
            pnlPompa3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPompa3.BackColor = Color.Transparent;
            pnlPompa3.BackgroundImage = Properties.Resources.kart_benzin;
            pnlPompa3.BackgroundImageLayout = ImageLayout.Stretch;
            pnlPompa3.Controls.Add(lblFiyat3);
            pnlPompa3.Controls.Add(lblDurum3);
            pnlPompa3.Controls.Add(lblTutar3);
            pnlPompa3.Controls.Add(lblLitre3);
            pnlPompa3.Controls.Add(lblYakitBenzin1);
            pnlPompa3.Controls.Add(lblPompaNo3);
            pnlPompa3.Location = new Point(520, 10);
            pnlPompa3.Margin = new Padding(10);
            pnlPompa3.Name = "pnlPompa3";
            pnlPompa3.Size = new Size(235, 395);
            pnlPompa3.TabIndex = 20;
            pnlPompa3.Click += pnlPompa3_Click;
            // 
            // lblFiyat3
            // 
            lblFiyat3.BackColor = Color.Transparent;
            lblFiyat3.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFiyat3.ForeColor = Color.FromArgb(156, 163, 175);
            lblFiyat3.Location = new Point(111, 333);
            lblFiyat3.Name = "lblFiyat3";
            lblFiyat3.Size = new Size(115, 43);
            lblFiyat3.TabIndex = 6;
            lblFiyat3.TextAlign = ContentAlignment.MiddleRight;
            lblFiyat3.Click += pnlPompa3_Click;
            // 
            // lblDurum3
            // 
            lblDurum3.BackColor = Color.Transparent;
            lblDurum3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDurum3.ForeColor = Color.FromArgb(74, 222, 128);
            lblDurum3.Location = new Point(12, 338);
            lblDurum3.Name = "lblDurum3";
            lblDurum3.Size = new Size(102, 28);
            lblDurum3.TabIndex = 5;
            lblDurum3.Text = "● Boşta";
            lblDurum3.TextAlign = ContentAlignment.MiddleCenter;
            lblDurum3.Click += pnlPompa3_Click;
            // 
            // lblTutar3
            // 
            lblTutar3.BackColor = Color.Transparent;
            lblTutar3.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTutar3.ForeColor = Color.FromArgb(250, 204, 21);
            lblTutar3.Location = new Point(29, 234);
            lblTutar3.Name = "lblTutar3";
            lblTutar3.Size = new Size(180, 45);
            lblTutar3.TabIndex = 4;
            lblTutar3.Text = "0,00 TL";
            lblTutar3.TextAlign = ContentAlignment.MiddleRight;
            lblTutar3.Click += pnlPompa3_Click;
            // 
            // lblLitre3
            // 
            lblLitre3.BackColor = Color.Transparent;
            lblLitre3.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLitre3.ForeColor = Color.FromArgb(250, 204, 21);
            lblLitre3.Location = new Point(29, 114);
            lblLitre3.Name = "lblLitre3";
            lblLitre3.Size = new Size(180, 45);
            lblLitre3.TabIndex = 3;
            lblLitre3.Text = "0,00 L";
            lblLitre3.TextAlign = ContentAlignment.MiddleRight;
            lblLitre3.Click += pnlPompa3_Click;
            // 
            // lblYakitBenzin1
            // 
            lblYakitBenzin1.BackColor = Color.Transparent;
            lblYakitBenzin1.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakitBenzin1.ForeColor = Color.FromArgb(255, 255, 255);
            lblYakitBenzin1.Location = new Point(110, 26);
            lblYakitBenzin1.Name = "lblYakitBenzin1";
            lblYakitBenzin1.Size = new Size(118, 34);
            lblYakitBenzin1.TabIndex = 2;
            lblYakitBenzin1.Text = "BENZİN";
            lblYakitBenzin1.TextAlign = ContentAlignment.MiddleCenter;
            lblYakitBenzin1.Click += pnlPompa3_Click;
            // 
            // lblPompaNo3
            // 
            lblPompaNo3.BackColor = Color.Transparent;
            lblPompaNo3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPompaNo3.ForeColor = Color.FromArgb(255, 255, 255);
            lblPompaNo3.Location = new Point(3, 14);
            lblPompaNo3.Name = "lblPompaNo3";
            lblPompaNo3.Size = new Size(113, 58);
            lblPompaNo3.TabIndex = 1;
            lblPompaNo3.Text = "POMPA 3";
            lblPompaNo3.TextAlign = ContentAlignment.MiddleLeft;
            lblPompaNo3.Click += pnlPompa3_Click;
            // 
            // pnlPompa4
            // 
            pnlPompa4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPompa4.BackColor = Color.Transparent;
            pnlPompa4.BackgroundImage = Properties.Resources.kart_benzin;
            pnlPompa4.BackgroundImageLayout = ImageLayout.Stretch;
            pnlPompa4.Controls.Add(lblFiyat4);
            pnlPompa4.Controls.Add(lblDurum4);
            pnlPompa4.Controls.Add(lblTutar4);
            pnlPompa4.Controls.Add(lblLitre4);
            pnlPompa4.Controls.Add(lblYakitBenzin2);
            pnlPompa4.Controls.Add(lblPompaNo4);
            pnlPompa4.Location = new Point(10, 425);
            pnlPompa4.Margin = new Padding(10);
            pnlPompa4.Name = "pnlPompa4";
            pnlPompa4.Size = new Size(235, 395);
            pnlPompa4.TabIndex = 21;
            pnlPompa4.Click += pnlPompa4_Click;
            // 
            // lblFiyat4
            // 
            lblFiyat4.BackColor = Color.Transparent;
            lblFiyat4.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFiyat4.ForeColor = Color.FromArgb(156, 163, 175);
            lblFiyat4.Location = new Point(111, 333);
            lblFiyat4.Name = "lblFiyat4";
            lblFiyat4.Size = new Size(115, 43);
            lblFiyat4.TabIndex = 6;
            lblFiyat4.TextAlign = ContentAlignment.MiddleRight;
            lblFiyat4.Click += pnlPompa4_Click;
            // 
            // lblDurum4
            // 
            lblDurum4.BackColor = Color.Transparent;
            lblDurum4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDurum4.ForeColor = Color.FromArgb(74, 222, 128);
            lblDurum4.Location = new Point(14, 338);
            lblDurum4.Name = "lblDurum4";
            lblDurum4.Size = new Size(102, 28);
            lblDurum4.TabIndex = 5;
            lblDurum4.Text = "● Boşta";
            lblDurum4.TextAlign = ContentAlignment.MiddleCenter;
            lblDurum4.Click += pnlPompa4_Click;
            // 
            // lblTutar4
            // 
            lblTutar4.BackColor = Color.Transparent;
            lblTutar4.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTutar4.ForeColor = Color.FromArgb(250, 204, 21);
            lblTutar4.Location = new Point(29, 234);
            lblTutar4.Name = "lblTutar4";
            lblTutar4.Size = new Size(180, 45);
            lblTutar4.TabIndex = 4;
            lblTutar4.Text = "0,00 TL";
            lblTutar4.TextAlign = ContentAlignment.MiddleRight;
            lblTutar4.Click += pnlPompa4_Click;
            // 
            // lblLitre4
            // 
            lblLitre4.BackColor = Color.Transparent;
            lblLitre4.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLitre4.ForeColor = Color.FromArgb(250, 204, 21);
            lblLitre4.Location = new Point(29, 114);
            lblLitre4.Name = "lblLitre4";
            lblLitre4.Size = new Size(180, 45);
            lblLitre4.TabIndex = 3;
            lblLitre4.Text = "0,00 L";
            lblLitre4.TextAlign = ContentAlignment.MiddleRight;
            lblLitre4.Click += pnlPompa4_Click;
            // 
            // lblYakitBenzin2
            // 
            lblYakitBenzin2.BackColor = Color.Transparent;
            lblYakitBenzin2.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakitBenzin2.ForeColor = Color.FromArgb(255, 255, 255);
            lblYakitBenzin2.Location = new Point(110, 26);
            lblYakitBenzin2.Name = "lblYakitBenzin2";
            lblYakitBenzin2.Size = new Size(118, 34);
            lblYakitBenzin2.TabIndex = 2;
            lblYakitBenzin2.Text = "BENZİN";
            lblYakitBenzin2.TextAlign = ContentAlignment.MiddleCenter;
            lblYakitBenzin2.Click += pnlPompa4_Click;
            // 
            // lblPompaNo4
            // 
            lblPompaNo4.BackColor = Color.Transparent;
            lblPompaNo4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPompaNo4.ForeColor = Color.FromArgb(255, 255, 255);
            lblPompaNo4.Location = new Point(3, 14);
            lblPompaNo4.Name = "lblPompaNo4";
            lblPompaNo4.Size = new Size(113, 58);
            lblPompaNo4.TabIndex = 1;
            lblPompaNo4.Text = "POMPA 4";
            lblPompaNo4.TextAlign = ContentAlignment.MiddleLeft;
            lblPompaNo4.Click += pnlPompa4_Click;
            // 
            // pnlPompa5
            // 
            pnlPompa5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPompa5.BackColor = Color.Transparent;
            pnlPompa5.BackgroundImage = Properties.Resources.kart_lpg;
            pnlPompa5.BackgroundImageLayout = ImageLayout.Stretch;
            pnlPompa5.Controls.Add(lblFiyat5);
            pnlPompa5.Controls.Add(lblDurum5);
            pnlPompa5.Controls.Add(lblTutar5);
            pnlPompa5.Controls.Add(lblLitre5);
            pnlPompa5.Controls.Add(lblYakitLPG1);
            pnlPompa5.Controls.Add(lblPompaNo5);
            pnlPompa5.Location = new Point(265, 425);
            pnlPompa5.Margin = new Padding(10);
            pnlPompa5.Name = "pnlPompa5";
            pnlPompa5.Size = new Size(235, 395);
            pnlPompa5.TabIndex = 22;
            pnlPompa5.Click += pnlPompa5_Click;
            // 
            // lblFiyat5
            // 
            lblFiyat5.BackColor = Color.Transparent;
            lblFiyat5.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFiyat5.ForeColor = Color.FromArgb(156, 163, 175);
            lblFiyat5.Location = new Point(111, 333);
            lblFiyat5.Name = "lblFiyat5";
            lblFiyat5.Size = new Size(115, 43);
            lblFiyat5.TabIndex = 6;
            lblFiyat5.TextAlign = ContentAlignment.MiddleRight;
            lblFiyat5.Click += pnlPompa5_Click;
            // 
            // lblDurum5
            // 
            lblDurum5.BackColor = Color.Transparent;
            lblDurum5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDurum5.ForeColor = Color.FromArgb(74, 222, 128);
            lblDurum5.Location = new Point(14, 338);
            lblDurum5.Name = "lblDurum5";
            lblDurum5.Size = new Size(102, 28);
            lblDurum5.TabIndex = 5;
            lblDurum5.Text = "● Boşta";
            lblDurum5.TextAlign = ContentAlignment.MiddleCenter;
            lblDurum5.Click += pnlPompa5_Click;
            // 
            // lblTutar5
            // 
            lblTutar5.BackColor = Color.Transparent;
            lblTutar5.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTutar5.ForeColor = Color.FromArgb(250, 204, 21);
            lblTutar5.Location = new Point(29, 234);
            lblTutar5.Name = "lblTutar5";
            lblTutar5.Size = new Size(180, 45);
            lblTutar5.TabIndex = 4;
            lblTutar5.Text = "0,00 TL";
            lblTutar5.TextAlign = ContentAlignment.MiddleRight;
            lblTutar5.Click += pnlPompa5_Click;
            // 
            // lblLitre5
            // 
            lblLitre5.BackColor = Color.Transparent;
            lblLitre5.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLitre5.ForeColor = Color.FromArgb(250, 204, 21);
            lblLitre5.Location = new Point(29, 114);
            lblLitre5.Name = "lblLitre5";
            lblLitre5.Size = new Size(180, 45);
            lblLitre5.TabIndex = 3;
            lblLitre5.Text = "0,00 L";
            lblLitre5.TextAlign = ContentAlignment.MiddleRight;
            lblLitre5.Click += pnlPompa5_Click;
            // 
            // lblYakitLPG1
            // 
            lblYakitLPG1.BackColor = Color.Transparent;
            lblYakitLPG1.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakitLPG1.ForeColor = Color.FromArgb(255, 255, 255);
            lblYakitLPG1.Location = new Point(110, 26);
            lblYakitLPG1.Name = "lblYakitLPG1";
            lblYakitLPG1.Size = new Size(118, 34);
            lblYakitLPG1.TabIndex = 2;
            lblYakitLPG1.Text = "LPG";
            lblYakitLPG1.TextAlign = ContentAlignment.MiddleCenter;
            lblYakitLPG1.Click += pnlPompa5_Click;
            // 
            // lblPompaNo5
            // 
            lblPompaNo5.BackColor = Color.Transparent;
            lblPompaNo5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPompaNo5.ForeColor = Color.FromArgb(255, 255, 255);
            lblPompaNo5.Location = new Point(3, 14);
            lblPompaNo5.Name = "lblPompaNo5";
            lblPompaNo5.Size = new Size(113, 58);
            lblPompaNo5.TabIndex = 1;
            lblPompaNo5.Text = "POMPA 5";
            lblPompaNo5.TextAlign = ContentAlignment.MiddleLeft;
            lblPompaNo5.Click += pnlPompa5_Click;
            // 
            // pnlPompa6
            // 
            pnlPompa6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPompa6.BackColor = Color.Transparent;
            pnlPompa6.BackgroundImage = Properties.Resources.kart_lpg;
            pnlPompa6.BackgroundImageLayout = ImageLayout.Stretch;
            pnlPompa6.Controls.Add(lblFiyat6);
            pnlPompa6.Controls.Add(lblDurum6);
            pnlPompa6.Controls.Add(lblTutar6);
            pnlPompa6.Controls.Add(lblLitre6);
            pnlPompa6.Controls.Add(lblYakitLPG2);
            pnlPompa6.Controls.Add(lblPompaNo6);
            pnlPompa6.Location = new Point(520, 425);
            pnlPompa6.Margin = new Padding(10);
            pnlPompa6.Name = "pnlPompa6";
            pnlPompa6.Size = new Size(235, 395);
            pnlPompa6.TabIndex = 23;
            pnlPompa6.Click += pnlPompa6_Click;
            // 
            // lblFiyat6
            // 
            lblFiyat6.BackColor = Color.Transparent;
            lblFiyat6.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFiyat6.ForeColor = Color.FromArgb(156, 163, 175);
            lblFiyat6.Location = new Point(111, 333);
            lblFiyat6.Name = "lblFiyat6";
            lblFiyat6.Size = new Size(115, 43);
            lblFiyat6.TabIndex = 6;
            lblFiyat6.TextAlign = ContentAlignment.MiddleRight;
            lblFiyat6.Click += pnlPompa6_Click;
            // 
            // lblDurum6
            // 
            lblDurum6.BackColor = Color.Transparent;
            lblDurum6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDurum6.ForeColor = Color.FromArgb(74, 222, 128);
            lblDurum6.Location = new Point(14, 338);
            lblDurum6.Name = "lblDurum6";
            lblDurum6.Size = new Size(102, 28);
            lblDurum6.TabIndex = 5;
            lblDurum6.Text = "● Boşta";
            lblDurum6.TextAlign = ContentAlignment.MiddleCenter;
            lblDurum6.Click += pnlPompa6_Click;
            // 
            // lblTutar6
            // 
            lblTutar6.BackColor = Color.Transparent;
            lblTutar6.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTutar6.ForeColor = Color.FromArgb(250, 204, 21);
            lblTutar6.Location = new Point(29, 234);
            lblTutar6.Name = "lblTutar6";
            lblTutar6.Size = new Size(180, 45);
            lblTutar6.TabIndex = 4;
            lblTutar6.Text = "0,00 TL";
            lblTutar6.TextAlign = ContentAlignment.MiddleRight;
            lblTutar6.Click += pnlPompa6_Click;
            // 
            // lblLitre6
            // 
            lblLitre6.BackColor = Color.Transparent;
            lblLitre6.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLitre6.ForeColor = Color.FromArgb(250, 204, 21);
            lblLitre6.Location = new Point(29, 114);
            lblLitre6.Name = "lblLitre6";
            lblLitre6.Size = new Size(180, 45);
            lblLitre6.TabIndex = 3;
            lblLitre6.Text = "0,00 L";
            lblLitre6.TextAlign = ContentAlignment.MiddleRight;
            lblLitre6.Click += pnlPompa6_Click;
            // 
            // lblYakitLPG2
            // 
            lblYakitLPG2.BackColor = Color.Transparent;
            lblYakitLPG2.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakitLPG2.ForeColor = Color.FromArgb(255, 255, 255);
            lblYakitLPG2.Location = new Point(110, 26);
            lblYakitLPG2.Name = "lblYakitLPG2";
            lblYakitLPG2.Size = new Size(118, 34);
            lblYakitLPG2.TabIndex = 2;
            lblYakitLPG2.Text = "LPG";
            lblYakitLPG2.TextAlign = ContentAlignment.MiddleCenter;
            lblYakitLPG2.Click += pnlPompa6_Click;
            // 
            // lblPompaNo6
            // 
            lblPompaNo6.BackColor = Color.Transparent;
            lblPompaNo6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPompaNo6.ForeColor = Color.FromArgb(255, 255, 255);
            lblPompaNo6.Location = new Point(3, 14);
            lblPompaNo6.Name = "lblPompaNo6";
            lblPompaNo6.Size = new Size(113, 58);
            lblPompaNo6.TabIndex = 1;
            lblPompaNo6.Text = "POMPA 6";
            lblPompaNo6.TextAlign = ContentAlignment.MiddleLeft;
            lblPompaNo6.Click += pnlPompa6_Click;
            // 
            // pnlIslem
            // 
            pnlIslem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlIslem.BackColor = Color.FromArgb(22, 27, 34);
            pnlIslem.Controls.Add(labelTutarTL);
            pnlIslem.Controls.Add(txtFiyat);
            pnlIslem.Controls.Add(txtPlaka);
            pnlIslem.Controls.Add(lblPlaka);
            pnlIslem.Controls.Add(btnArizaGider);
            pnlIslem.Controls.Add(lblYakit);
            pnlIslem.Controls.Add(cmbPersonel);
            pnlIslem.Controls.Add(btnArizali);
            pnlIslem.Controls.Add(btnTamamla);
            pnlIslem.Controls.Add(btnBaslat);
            pnlIslem.Controls.Add(numLitre);
            pnlIslem.Controls.Add(labelMiktraL);
            pnlIslem.Controls.Add(lblPersonel);
            pnlIslem.Controls.Add(lblIslemBaslik);
            pnlIslem.Enabled = false;
            pnlIslem.Location = new Point(779, 0);
            pnlIslem.Name = "pnlIslem";
            pnlIslem.Size = new Size(294, 832);
            pnlIslem.TabIndex = 1;
            // 
            // labelTutarTL
            // 
            labelTutarTL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelTutarTL.BackColor = Color.Transparent;
            labelTutarTL.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelTutarTL.ForeColor = Color.White;
            labelTutarTL.Location = new Point(150, 223);
            labelTutarTL.Name = "labelTutarTL";
            labelTutarTL.Size = new Size(136, 21);
            labelTutarTL.TabIndex = 16;
            labelTutarTL.Text = "Tutar / TL";
            // 
            // txtFiyat
            // 
            txtFiyat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtFiyat.BackColor = Color.White;
            txtFiyat.CharacterCasing = CharacterCasing.Upper;
            txtFiyat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtFiyat.Location = new Point(151, 247);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(136, 29);
            txtFiyat.TabIndex = 15;
            // 
            // txtPlaka
            // 
            txtPlaka.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtPlaka.BackColor = Color.White;
            txtPlaka.CharacterCasing = CharacterCasing.Upper;
            txtPlaka.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtPlaka.Location = new Point(9, 181);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(277, 29);
            txtPlaka.TabIndex = 14;
            // 
            // lblPlaka
            // 
            lblPlaka.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPlaka.BackColor = Color.Transparent;
            lblPlaka.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPlaka.ForeColor = Color.White;
            lblPlaka.Location = new Point(0, 157);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(294, 21);
            lblPlaka.TabIndex = 13;
            lblPlaka.Text = "Plaka";
            lblPlaka.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnArizaGider
            // 
            btnArizaGider.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnArizaGider.BackColor = Color.DimGray;
            btnArizaGider.FlatAppearance.BorderSize = 0;
            btnArizaGider.FlatStyle = FlatStyle.Flat;
            btnArizaGider.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnArizaGider.ForeColor = Color.White;
            btnArizaGider.Location = new Point(0, 434);
            btnArizaGider.Name = "btnArizaGider";
            btnArizaGider.Size = new Size(294, 45);
            btnArizaGider.TabIndex = 12;
            btnArizaGider.Text = "ARIZA GİDER";
            btnArizaGider.UseVisualStyleBackColor = false;
            btnArizaGider.Click += btnArizaGider_Click;
            // 
            // lblYakit
            // 
            lblYakit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblYakit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakit.ForeColor = Color.White;
            lblYakit.ImageAlign = ContentAlignment.MiddleLeft;
            lblYakit.Location = new Point(7, 47);
            lblYakit.Name = "lblYakit";
            lblYakit.Size = new Size(287, 23);
            lblYakit.TabIndex = 11;
            lblYakit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbPersonel
            // 
            cmbPersonel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cmbPersonel.BackColor = Color.White;
            cmbPersonel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbPersonel.FormattingEnabled = true;
            cmbPersonel.Location = new Point(9, 119);
            cmbPersonel.Margin = new Padding(6);
            cmbPersonel.Name = "cmbPersonel";
            cmbPersonel.Size = new Size(277, 28);
            cmbPersonel.TabIndex = 10;
            // 
            // btnArizali
            // 
            btnArizali.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnArizali.BackColor = Color.FromArgb(55, 65, 81);
            btnArizali.FlatAppearance.BorderSize = 0;
            btnArizali.FlatStyle = FlatStyle.Flat;
            btnArizali.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnArizali.ForeColor = Color.White;
            btnArizali.Location = new Point(0, 366);
            btnArizali.Name = "btnArizali";
            btnArizali.Size = new Size(294, 45);
            btnArizali.TabIndex = 9;
            btnArizali.Text = "ARIZALI";
            btnArizali.UseVisualStyleBackColor = false;
            btnArizali.Click += btnArizali_Click;
            // 
            // btnTamamla
            // 
            btnTamamla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnTamamla.BackColor = Color.FromArgb(245, 158, 11);
            btnTamamla.FlatAppearance.BorderSize = 0;
            btnTamamla.FlatStyle = FlatStyle.Flat;
            btnTamamla.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTamamla.ForeColor = Color.White;
            btnTamamla.ImageAlign = ContentAlignment.MiddleLeft;
            btnTamamla.Location = new Point(151, 300);
            btnTamamla.Name = "btnTamamla";
            btnTamamla.Size = new Size(136, 45);
            btnTamamla.TabIndex = 8;
            btnTamamla.Text = "SATIŞI TAMAMLA";
            btnTamamla.UseVisualStyleBackColor = false;
            btnTamamla.Click += btnTamamla_Click;
            // 
            // btnBaslat
            // 
            btnBaslat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnBaslat.BackColor = Color.FromArgb(34, 197, 94);
            btnBaslat.FlatAppearance.BorderSize = 0;
            btnBaslat.FlatStyle = FlatStyle.Flat;
            btnBaslat.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBaslat.ForeColor = Color.White;
            btnBaslat.Location = new Point(9, 300);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(136, 45);
            btnBaslat.TabIndex = 6;
            btnBaslat.Text = "BAŞLAT";
            btnBaslat.UseVisualStyleBackColor = false;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // numLitre
            // 
            numLitre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            numLitre.DecimalPlaces = 2;
            numLitre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numLitre.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numLitre.Location = new Point(9, 247);
            numLitre.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numLitre.Name = "numLitre";
            numLitre.Size = new Size(136, 29);
            numLitre.TabIndex = 5;
            // 
            // labelMiktraL
            // 
            labelMiktraL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelMiktraL.BackColor = Color.Transparent;
            labelMiktraL.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelMiktraL.ForeColor = Color.White;
            labelMiktraL.Location = new Point(8, 223);
            labelMiktraL.Name = "labelMiktraL";
            labelMiktraL.Size = new Size(136, 21);
            labelMiktraL.TabIndex = 4;
            labelMiktraL.Text = "Miktar / L";
            // 
            // lblPersonel
            // 
            lblPersonel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPersonel.BackColor = Color.Transparent;
            lblPersonel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPersonel.ForeColor = Color.White;
            lblPersonel.Location = new Point(0, 92);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(294, 21);
            lblPersonel.TabIndex = 3;
            lblPersonel.Text = "Pompacı";
            lblPersonel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIslemBaslik
            // 
            lblIslemBaslik.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblIslemBaslik.BackColor = Color.Transparent;
            lblIslemBaslik.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblIslemBaslik.ForeColor = Color.White;
            lblIslemBaslik.Location = new Point(0, 0);
            lblIslemBaslik.Name = "lblIslemBaslik";
            lblIslemBaslik.Size = new Size(294, 52);
            lblIslemBaslik.TabIndex = 0;
            lblIslemBaslik.Text = "Pompa Seçin";
            lblIslemBaslik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Pompalar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlIslem);
            Controls.Add(flpPompalar);
            Name = "Pompalar";
            Size = new Size(1073, 832);
            Load += Pompalar_Load;
            flpPompalar.ResumeLayout(false);
            pnlPompa1.ResumeLayout(false);
            pnlPompa2.ResumeLayout(false);
            pnlPompa3.ResumeLayout(false);
            pnlPompa4.ResumeLayout(false);
            pnlPompa5.ResumeLayout(false);
            pnlPompa6.ResumeLayout(false);
            pnlIslem.ResumeLayout(false);
            pnlIslem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numLitre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpPompalar;
        private Panel pnlPompa1;
        private Label lblFiyat1;
        private Label lblDurum1;
        private Label lblTutar1;
        private Label lblLitre1;
        private Label lblYakitMotorin1;
        private Label lblPompaNo1;
        private Panel pnlPompa2;
        private Label lblFiyat2;
        private Label lblDurum2;
        private Label lblTutar2;
        private Label lblLitre2;
        private Label lblYakitMotorin2;
        private Label lblPompaNo2;
        private Panel pnlPompa3;
        private Label lblFiyat3;
        private Label lblDurum3;
        private Label lblTutar3;
        private Label lblLitre3;
        private Label lblYakitBenzin1;
        private Label lblPompaNo3;
        private Panel pnlPompa4;
        private Label lblFiyat4;
        private Label lblDurum4;
        private Label lblTutar4;
        private Label lblLitre4;
        private Label lblYakitBenzin2;
        private Label lblPompaNo4;
        private Panel pnlPompa5;
        private Label lblFiyat5;
        private Label lblDurum5;
        private Label lblTutar5;
        private Label lblLitre5;
        private Label lblYakitLPG1;
        private Label lblPompaNo5;
        private Panel pnlPompa6;
        private Label lblFiyat6;
        private Label lblDurum6;
        private Label lblTutar6;
        private Label lblLitre6;
        private Label lblYakitLPG2;
        private Label lblPompaNo6;
        private Panel pnlIslem;
        private Label lblIslemBaslik;
        private Label lblPersonel;
        private NumericUpDown numLitre;
        private Label labelMiktraL;
        private Button btnArizali;
        private Button btnTamamla;
        private Button btnBaslat;
        private ComboBox cmbPersonel;
        private System.Windows.Forms.Timer timer1;
        private Label lblYakit;
        private Button btnArizaGider;
        private TextBox txtPlaka;
        private Label lblPlaka;
        private Label labelTutarTL;
        private TextBox txtFiyat;
    }
}
