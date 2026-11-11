namespace Projem
{
    partial class Stoklar
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            flpStoklar = new FlowLayoutPanel();
            panel1 = new Panel();
            lblAlt1 = new Label();
            lblToplamStok1 = new Label();
            lblBaslik1 = new Label();
            panel3 = new Panel();
            lblAlt2 = new Label();
            lblToplamStok2 = new Label();
            lblBaslik2 = new Label();
            panel2 = new Panel();
            lblAlt3 = new Label();
            lblToplamStok3 = new Label();
            lblBaslik3 = new Label();
            lblHareket = new Label();
            cmbHareket = new ComboBox();
            lblYakit = new Label();
            cmbYakit = new ComboBox();
            btnFiltrele = new Button();
            dgvStok = new DataGridView();
            colTarih = new DataGridViewTextBoxColumn();
            colTank = new DataGridViewTextBoxColumn();
            colYakit = new DataGridViewTextBoxColumn();
            colHareket = new DataGridViewTextBoxColumn();
            colLitre = new DataGridViewTextBoxColumn();
            colTedarikci = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            flpStoklar.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStok).BeginInit();
            SuspendLayout();
            // 
            // flpStoklar
            // 
            flpStoklar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpStoklar.Controls.Add(panel1);
            flpStoklar.Controls.Add(panel3);
            flpStoklar.Controls.Add(panel2);
            flpStoklar.Location = new Point(0, 0);
            flpStoklar.Name = "flpStoklar";
            flpStoklar.Size = new Size(1073, 123);
            flpStoklar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.stok_motorin;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblAlt1);
            panel1.Controls.Add(lblToplamStok1);
            panel1.Controls.Add(lblBaslik1);
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 110);
            panel1.TabIndex = 0;
            // 
            // lblAlt1
            // 
            lblAlt1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAlt1.ForeColor = Color.FromArgb(156, 163, 175);
            lblAlt1.Location = new Point(16, 80);
            lblAlt1.Name = "lblAlt1";
            lblAlt1.Size = new Size(303, 18);
            lblAlt1.TabIndex = 2;
            lblAlt1.Text = "Tüm Tanklardaki Toplam.";
            lblAlt1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblToplamStok1
            // 
            lblToplamStok1.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamStok1.ForeColor = Color.FromArgb(250, 204, 21);
            lblToplamStok1.Location = new Point(16, 37);
            lblToplamStok1.Name = "lblToplamStok1";
            lblToplamStok1.Size = new Size(303, 40);
            lblToplamStok1.TabIndex = 1;
            lblToplamStok1.Text = "0 L";
            lblToplamStok1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBaslik1
            // 
            lblBaslik1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik1.ForeColor = Color.White;
            lblBaslik1.Location = new Point(16, 12);
            lblBaslik1.Name = "lblBaslik1";
            lblBaslik1.Size = new Size(200, 26);
            lblBaslik1.TabIndex = 0;
            lblBaslik1.Text = "MOTORİN";
            lblBaslik1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.stok_benzin;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(lblAlt2);
            panel3.Controls.Add(lblToplamStok2);
            panel3.Controls.Add(lblBaslik2);
            panel3.Location = new Point(365, 10);
            panel3.Margin = new Padding(10);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 110);
            panel3.TabIndex = 2;
            // 
            // lblAlt2
            // 
            lblAlt2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAlt2.ForeColor = Color.FromArgb(156, 163, 175);
            lblAlt2.Location = new Point(16, 80);
            lblAlt2.Name = "lblAlt2";
            lblAlt2.Size = new Size(303, 18);
            lblAlt2.TabIndex = 5;
            lblAlt2.Text = "Tüm Tanklardaki Toplam.";
            lblAlt2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblToplamStok2
            // 
            lblToplamStok2.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamStok2.ForeColor = Color.FromArgb(34, 197, 94);
            lblToplamStok2.Location = new Point(16, 37);
            lblToplamStok2.Name = "lblToplamStok2";
            lblToplamStok2.Size = new Size(303, 40);
            lblToplamStok2.TabIndex = 4;
            lblToplamStok2.Text = "0 L";
            lblToplamStok2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBaslik2
            // 
            lblBaslik2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik2.ForeColor = Color.White;
            lblBaslik2.Location = new Point(16, 12);
            lblBaslik2.Name = "lblBaslik2";
            lblBaslik2.Size = new Size(200, 26);
            lblBaslik2.TabIndex = 3;
            lblBaslik2.Text = "BENZİN 95";
            lblBaslik2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.stok_lpg;
            panel2.Controls.Add(lblAlt3);
            panel2.Controls.Add(lblToplamStok3);
            panel2.Controls.Add(lblBaslik3);
            panel2.Location = new Point(720, 10);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 110);
            panel2.TabIndex = 1;
            // 
            // lblAlt3
            // 
            lblAlt3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAlt3.ForeColor = Color.FromArgb(156, 163, 175);
            lblAlt3.Location = new Point(16, 80);
            lblAlt3.Name = "lblAlt3";
            lblAlt3.Size = new Size(303, 18);
            lblAlt3.TabIndex = 5;
            lblAlt3.Text = "Tüm Tanklardaki Toplam.";
            lblAlt3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblToplamStok3
            // 
            lblToplamStok3.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamStok3.ForeColor = Color.FromArgb(59, 130, 246);
            lblToplamStok3.Location = new Point(16, 37);
            lblToplamStok3.Name = "lblToplamStok3";
            lblToplamStok3.Size = new Size(303, 40);
            lblToplamStok3.TabIndex = 4;
            lblToplamStok3.Text = "0 L";
            lblToplamStok3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBaslik3
            // 
            lblBaslik3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik3.ForeColor = Color.White;
            lblBaslik3.Location = new Point(16, 12);
            lblBaslik3.Name = "lblBaslik3";
            lblBaslik3.Size = new Size(200, 26);
            lblBaslik3.TabIndex = 3;
            lblBaslik3.Text = "LPG";
            lblBaslik3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHareket
            // 
            lblHareket.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblHareket.BackColor = Color.Transparent;
            lblHareket.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHareket.ForeColor = Color.FromArgb(31, 41, 55);
            lblHareket.Location = new Point(20, 150);
            lblHareket.Name = "lblHareket";
            lblHareket.Size = new Size(100, 20);
            lblHareket.TabIndex = 1;
            lblHareket.Text = "Hareket";
            lblHareket.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbHareket
            // 
            cmbHareket.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbHareket.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHareket.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbHareket.FormattingEnabled = true;
            cmbHareket.Items.AddRange(new object[] { "Tümü", "Giriş", "Çıkış" });
            cmbHareket.Location = new Point(20, 172);
            cmbHareket.Name = "cmbHareket";
            cmbHareket.Size = new Size(180, 28);
            cmbHareket.TabIndex = 2;
            // 
            // lblYakit
            // 
            lblYakit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblYakit.BackColor = Color.Transparent;
            lblYakit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakit.ForeColor = Color.FromArgb(31, 41, 55);
            lblYakit.Location = new Point(220, 150);
            lblYakit.Name = "lblYakit";
            lblYakit.Size = new Size(100, 20);
            lblYakit.TabIndex = 3;
            lblYakit.Text = "Yakıt";
            lblYakit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbYakit
            // 
            cmbYakit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbYakit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYakit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbYakit.FormattingEnabled = true;
            cmbYakit.Items.AddRange(new object[] { "Tümü", "Motorin", "Benzin 95", "LPG" });
            cmbYakit.Location = new Point(220, 172);
            cmbYakit.Name = "cmbYakit";
            cmbYakit.Size = new Size(180, 28);
            cmbYakit.TabIndex = 4;
            // 
            // btnFiltrele
            // 
            btnFiltrele.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnFiltrele.BackColor = Color.MidnightBlue;
            btnFiltrele.FlatAppearance.BorderSize = 0;
            btnFiltrele.FlatStyle = FlatStyle.Flat;
            btnFiltrele.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFiltrele.ForeColor = Color.White;
            btnFiltrele.Location = new Point(420, 170);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(140, 34);
            btnFiltrele.TabIndex = 5;
            btnFiltrele.Text = "FİLTRELE";
            btnFiltrele.UseVisualStyleBackColor = false;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // dgvStok
            // 
            dgvStok.AllowUserToAddRows = false;
            dgvStok.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(244, 246, 252);
            dgvStok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvStok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStok.BackgroundColor = Color.White;
            dgvStok.BorderStyle = BorderStyle.None;
            dgvStok.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvStok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvStok.ColumnHeadersHeight = 42;
            dgvStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStok.Columns.AddRange(new DataGridViewColumn[] { colTarih, colTank, colYakit, colHareket, colLitre, colTedarikci });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(255, 224, 178);
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvStok.DefaultCellStyle = dataGridViewCellStyle10;
            dgvStok.EnableHeadersVisualStyles = false;
            dgvStok.GridColor = Color.FromArgb(225, 228, 240);
            dgvStok.Location = new Point(20, 220);
            dgvStok.Name = "dgvStok";
            dgvStok.ReadOnly = true;
            dgvStok.RowHeadersVisible = false;
            dgvStok.RowTemplate.Height = 36;
            dgvStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStok.Size = new Size(1045, 590);
            dgvStok.TabIndex = 6;
            // 
            // colTarih
            // 
            colTarih.DataPropertyName = "Tarih";
            dataGridViewCellStyle8.Format = "g";
            dataGridViewCellStyle8.NullValue = null;
            colTarih.DefaultCellStyle = dataGridViewCellStyle8;
            colTarih.HeaderText = "Tarih";
            colTarih.Name = "colTarih";
            colTarih.ReadOnly = true;
            // 
            // colTank
            // 
            colTank.DataPropertyName = "Tank";
            colTank.HeaderText = "Tank";
            colTank.Name = "colTank";
            colTank.ReadOnly = true;
            // 
            // colYakit
            // 
            colYakit.DataPropertyName = "Yakıt";
            colYakit.HeaderText = "Yakıt";
            colYakit.Name = "colYakit";
            colYakit.ReadOnly = true;
            // 
            // colHareket
            // 
            colHareket.DataPropertyName = "Hareket";
            colHareket.HeaderText = "Hareket";
            colHareket.Name = "colHareket";
            colHareket.ReadOnly = true;
            // 
            // colLitre
            // 
            colLitre.DataPropertyName = "Litre";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            colLitre.DefaultCellStyle = dataGridViewCellStyle9;
            colLitre.HeaderText = "Litre";
            colLitre.Name = "colLitre";
            colLitre.ReadOnly = true;
            // 
            // colTedarikci
            // 
            colTedarikci.DataPropertyName = "Tedarikçi";
            colTedarikci.HeaderText = "Tedarikçi";
            colTedarikci.Name = "colTedarikci";
            colTedarikci.ReadOnly = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // Stoklar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 248);
            Controls.Add(lblHareket);
            Controls.Add(lblYakit);
            Controls.Add(flpStoklar);
            Controls.Add(dgvStok);
            Controls.Add(btnFiltrele);
            Controls.Add(cmbYakit);
            Controls.Add(cmbHareket);
            Name = "Stoklar";
            Size = new Size(1073, 832);
            Load += Stoklar_Load;
            flpStoklar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStok).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpStoklar;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label lblBaslik1;
        private Label lblToplamStok1;
        private Label lblAlt1;
        private Label lblAlt2;
        private Label lblToplamStok2;
        private Label lblBaslik2;
        private Label lblAlt3;
        private Label lblToplamStok3;
        private Label lblBaslik3;
        private Label lblHareket;
        private ComboBox cmbHareket;
        private Label lblYakit;
        private ComboBox cmbYakit;
        private Button btnFiltrele;
        private DataGridView dgvStok;
        private DataGridViewTextBoxColumn colTarih;
        private DataGridViewTextBoxColumn colTank;
        private DataGridViewTextBoxColumn colYakit;
        private DataGridViewTextBoxColumn colHareket;
        private DataGridViewTextBoxColumn colLitre;
        private DataGridViewTextBoxColumn colTedarikci;
        private System.Windows.Forms.Timer timer1;
    }
}
