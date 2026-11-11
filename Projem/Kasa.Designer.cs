namespace Projem
{
    partial class Kasa
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            flpKasa = new FlowLayoutPanel();
            pnlGiren = new Panel();
            lblGiren = new Label();
            pnlCikan = new Panel();
            lblCikan = new Label();
            pnlZarar = new Panel();
            lblKarZarar = new Label();
            pnlAy = new Panel();
            lblAy = new Label();
            flpSatis = new FlowLayoutPanel();
            pnlCiro1 = new Panel();
            lblCiro1 = new Label();
            pnlLitre2 = new Panel();
            lblLitre1 = new Label();
            pnlOrtalama = new Panel();
            lblOrtalama1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            dgvStok = new DataGridView();
            colTarih = new DataGridViewTextBoxColumn();
            İşlem = new DataGridViewTextBoxColumn();
            colGelir = new DataGridViewTextBoxColumn();
            colGider = new DataGridViewTextBoxColumn();
            colLitre = new DataGridViewTextBoxColumn();
            flpKasa.SuspendLayout();
            pnlGiren.SuspendLayout();
            pnlCikan.SuspendLayout();
            pnlZarar.SuspendLayout();
            pnlAy.SuspendLayout();
            flpSatis.SuspendLayout();
            pnlCiro1.SuspendLayout();
            pnlLitre2.SuspendLayout();
            pnlOrtalama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStok).BeginInit();
            SuspendLayout();
            // 
            // flpKasa
            // 
            flpKasa.Anchor = AnchorStyles.Top;
            flpKasa.BackColor = Color.White;
            flpKasa.Controls.Add(pnlGiren);
            flpKasa.Controls.Add(pnlCikan);
            flpKasa.Controls.Add(pnlZarar);
            flpKasa.Controls.Add(pnlAy);
            flpKasa.Location = new Point(0, 0);
            flpKasa.Name = "flpKasa";
            flpKasa.Size = new Size(1073, 163);
            flpKasa.TabIndex = 2;
            // 
            // pnlGiren
            // 
            pnlGiren.BackColor = Color.Transparent;
            pnlGiren.BackgroundImage = Properties.Resources.kasa_giren;
            pnlGiren.Controls.Add(lblGiren);
            pnlGiren.Location = new Point(8, 3);
            pnlGiren.Margin = new Padding(8, 3, 3, 3);
            pnlGiren.Name = "pnlGiren";
            pnlGiren.Size = new Size(256, 153);
            pnlGiren.TabIndex = 0;
            // 
            // lblGiren
            // 
            lblGiren.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGiren.ForeColor = Color.FromArgb(34, 197, 94);
            lblGiren.Location = new Point(76, 73);
            lblGiren.Name = "lblGiren";
            lblGiren.Size = new Size(177, 30);
            lblGiren.TabIndex = 1;
            lblGiren.Text = "₺";
            // 
            // pnlCikan
            // 
            pnlCikan.BackColor = Color.Transparent;
            pnlCikan.BackgroundImage = Properties.Resources.kasa_cikan;
            pnlCikan.Controls.Add(lblCikan);
            pnlCikan.Location = new Point(275, 3);
            pnlCikan.Margin = new Padding(8, 3, 3, 3);
            pnlCikan.Name = "pnlCikan";
            pnlCikan.Size = new Size(256, 153);
            pnlCikan.TabIndex = 1;
            // 
            // lblCikan
            // 
            lblCikan.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCikan.ForeColor = Color.FromArgb(59, 130, 246);
            lblCikan.Location = new Point(76, 73);
            lblCikan.Name = "lblCikan";
            lblCikan.Size = new Size(177, 30);
            lblCikan.TabIndex = 2;
            lblCikan.Text = "₺";
            // 
            // pnlZarar
            // 
            pnlZarar.BackColor = Color.Transparent;
            pnlZarar.BackgroundImage = Properties.Resources.kasa_zarar;
            pnlZarar.Controls.Add(lblKarZarar);
            pnlZarar.Location = new Point(542, 3);
            pnlZarar.Margin = new Padding(8, 3, 3, 3);
            pnlZarar.Name = "pnlZarar";
            pnlZarar.Size = new Size(256, 153);
            pnlZarar.TabIndex = 2;
            // 
            // lblKarZarar
            // 
            lblKarZarar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKarZarar.ForeColor = Color.FromArgb(239, 68, 68);
            lblKarZarar.Location = new Point(76, 73);
            lblKarZarar.Name = "lblKarZarar";
            lblKarZarar.Size = new Size(177, 30);
            lblKarZarar.TabIndex = 2;
            lblKarZarar.Text = "₺";
            // 
            // pnlAy
            // 
            pnlAy.BackColor = Color.Transparent;
            pnlAy.BackgroundImage = Properties.Resources.kasa_ay;
            pnlAy.Controls.Add(lblAy);
            pnlAy.Location = new Point(809, 3);
            pnlAy.Margin = new Padding(8, 3, 3, 3);
            pnlAy.Name = "pnlAy";
            pnlAy.Size = new Size(256, 153);
            pnlAy.TabIndex = 3;
            // 
            // lblAy
            // 
            lblAy.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAy.ForeColor = Color.FromArgb(250, 204, 21);
            lblAy.Location = new Point(76, 73);
            lblAy.Name = "lblAy";
            lblAy.Size = new Size(177, 30);
            lblAy.TabIndex = 2;
            lblAy.Text = "₺";
            // 
            // flpSatis
            // 
            flpSatis.Anchor = AnchorStyles.Top;
            flpSatis.BackColor = Color.White;
            flpSatis.Controls.Add(pnlCiro1);
            flpSatis.Controls.Add(pnlLitre2);
            flpSatis.Controls.Add(pnlOrtalama);
            flpSatis.Location = new Point(0, 163);
            flpSatis.Name = "flpSatis";
            flpSatis.Size = new Size(1073, 163);
            flpSatis.TabIndex = 4;
            // 
            // pnlCiro1
            // 
            pnlCiro1.BackColor = Color.Transparent;
            pnlCiro1.BackgroundImage = Properties.Resources.satislar_bciro;
            pnlCiro1.Controls.Add(lblCiro1);
            pnlCiro1.Location = new Point(22, 3);
            pnlCiro1.Margin = new Padding(22, 3, 3, 3);
            pnlCiro1.Name = "pnlCiro1";
            pnlCiro1.Size = new Size(335, 153);
            pnlCiro1.TabIndex = 0;
            // 
            // lblCiro1
            // 
            lblCiro1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCiro1.ForeColor = Color.FromArgb(245, 158, 11);
            lblCiro1.Location = new Point(96, 77);
            lblCiro1.Name = "lblCiro1";
            lblCiro1.Size = new Size(236, 30);
            lblCiro1.TabIndex = 0;
            lblCiro1.Text = "₺";
            // 
            // pnlLitre2
            // 
            pnlLitre2.BackColor = Color.Transparent;
            pnlLitre2.BackgroundImage = Properties.Resources.satislar_blitre;
            pnlLitre2.Controls.Add(lblLitre1);
            pnlLitre2.Location = new Point(370, 3);
            pnlLitre2.Margin = new Padding(10, 3, 3, 3);
            pnlLitre2.Name = "pnlLitre2";
            pnlLitre2.Size = new Size(335, 153);
            pnlLitre2.TabIndex = 1;
            // 
            // lblLitre1
            // 
            lblLitre1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLitre1.ForeColor = Color.FromArgb(20, 184, 166);
            lblLitre1.Location = new Point(96, 77);
            lblLitre1.Name = "lblLitre1";
            lblLitre1.Size = new Size(236, 30);
            lblLitre1.TabIndex = 2;
            lblLitre1.Text = "₺";
            // 
            // pnlOrtalama
            // 
            pnlOrtalama.BackColor = Color.Transparent;
            pnlOrtalama.BackgroundImage = Properties.Resources.satislar_ortalama;
            pnlOrtalama.BackgroundImageLayout = ImageLayout.Center;
            pnlOrtalama.Controls.Add(lblOrtalama1);
            pnlOrtalama.Location = new Point(718, 3);
            pnlOrtalama.Margin = new Padding(10, 3, 3, 3);
            pnlOrtalama.Name = "pnlOrtalama";
            pnlOrtalama.Size = new Size(335, 153);
            pnlOrtalama.TabIndex = 2;
            // 
            // lblOrtalama1
            // 
            lblOrtalama1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOrtalama1.ForeColor = Color.FromArgb(139, 92, 246);
            lblOrtalama1.Location = new Point(93, 77);
            lblOrtalama1.Name = "lblOrtalama1";
            lblOrtalama1.Size = new Size(236, 30);
            lblOrtalama1.TabIndex = 2;
            lblOrtalama1.Text = "₺";
            lblOrtalama1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 15000;
            timer1.Tick += timer1_Tick;
            // 
            // dgvStok
            // 
            dgvStok.AllowUserToAddRows = false;
            dgvStok.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(244, 246, 252);
            dgvStok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvStok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStok.BackgroundColor = Color.White;
            dgvStok.BorderStyle = BorderStyle.None;
            dgvStok.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvStok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvStok.ColumnHeadersHeight = 42;
            dgvStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStok.Columns.AddRange(new DataGridViewColumn[] { colTarih, İşlem, colGelir, colGider, colLitre });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Window;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle16.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(255, 224, 178);
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dgvStok.DefaultCellStyle = dataGridViewCellStyle16;
            dgvStok.EnableHeadersVisualStyles = false;
            dgvStok.GridColor = Color.FromArgb(225, 228, 240);
            dgvStok.Location = new Point(8, 332);
            dgvStok.Name = "dgvStok";
            dgvStok.ReadOnly = true;
            dgvStok.RowHeadersVisible = false;
            dgvStok.RowTemplate.Height = 36;
            dgvStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStok.Size = new Size(1057, 479);
            dgvStok.TabIndex = 7;
            dgvStok.CellContentClick += dgvStok_CellContentClick;
            // 
            // colTarih
            // 
            colTarih.DataPropertyName = "Tarih";
            dataGridViewCellStyle11.Format = "g";
            dataGridViewCellStyle11.NullValue = null;
            colTarih.DefaultCellStyle = dataGridViewCellStyle11;
            colTarih.HeaderText = "Tarih";
            colTarih.Name = "colTarih";
            colTarih.ReadOnly = true;
            // 
            // İşlem
            // 
            İşlem.DataPropertyName = "Islem";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            İşlem.DefaultCellStyle = dataGridViewCellStyle12;
            İşlem.HeaderText = "İşlem";
            İşlem.Name = "İşlem";
            İşlem.ReadOnly = true;
            // 
            // colGelir
            // 
            colGelir.DataPropertyName = "Gelir";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            colGelir.DefaultCellStyle = dataGridViewCellStyle13;
            colGelir.HeaderText = "Gelir";
            colGelir.Name = "colGelir";
            colGelir.ReadOnly = true;
            // 
            // colGider
            // 
            colGider.DataPropertyName = "Gider";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            colGider.DefaultCellStyle = dataGridViewCellStyle14;
            colGider.HeaderText = "Gider";
            colGider.Name = "colGider";
            colGider.ReadOnly = true;
            // 
            // colLitre
            // 
            colLitre.DataPropertyName = "Litre";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            colLitre.DefaultCellStyle = dataGridViewCellStyle15;
            colLitre.HeaderText = "Litre";
            colLitre.Name = "colLitre";
            colLitre.ReadOnly = true;
            // 
            // Kasa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvStok);
            Controls.Add(flpKasa);
            Controls.Add(flpSatis);
            Name = "Kasa";
            Size = new Size(1073, 832);
            Load += Kasa_Load;
            flpKasa.ResumeLayout(false);
            pnlGiren.ResumeLayout(false);
            pnlCikan.ResumeLayout(false);
            pnlZarar.ResumeLayout(false);
            pnlAy.ResumeLayout(false);
            flpSatis.ResumeLayout(false);
            pnlCiro1.ResumeLayout(false);
            pnlLitre2.ResumeLayout(false);
            pnlOrtalama.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStok).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flpKasa;
        private Panel pnlGiren;
        private Panel pnlCikan;
        private Panel pnlZarar;
        private Panel pnlAy;
        private Label lblGiren;
        private Label lblCikan;
        private Label lblKarZarar;
        private Label lblAy;
        private FlowLayoutPanel flpSatis;
        private Panel pnlCiro1;
        private Label lblCiro1;
        private Panel pnlLitre2;
        private Label lblLitre1;
        private Panel pnlOrtalama;
        private Label lblOrtalama1;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dgvStok;
        private DataGridViewTextBoxColumn colTarih;
        private DataGridViewTextBoxColumn İşlem;
        private DataGridViewTextBoxColumn colGelir;
        private DataGridViewTextBoxColumn colGider;
        private DataGridViewTextBoxColumn colLitre;
    }
}
