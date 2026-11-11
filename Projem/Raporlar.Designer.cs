namespace Projem
{
    partial class Raporlar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvRapor = new DataGridView();
            dtpBaslangic = new DateTimePicker();
            btnDisaAktar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlRaporKasa = new Panel();
            pnlRaporSatis = new Panel();
            pnlRaporStok = new Panel();
            lblOzet = new Label();
            dtpBitis = new DateTimePicker();
            btnOlustur = new Button();
            lblBaslangic = new Label();
            label2 = new Label();
            lblSecilen = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRapor
            // 
            dgvRapor.AllowUserToAddRows = false;
            dgvRapor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 246, 252);
            dgvRapor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRapor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRapor.BackgroundColor = Color.White;
            dgvRapor.BorderStyle = BorderStyle.None;
            dgvRapor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRapor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRapor.ColumnHeadersHeight = 42;
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 224, 178);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRapor.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRapor.EnableHeadersVisualStyles = false;
            dgvRapor.GridColor = Color.FromArgb(225, 228, 240);
            dgvRapor.Location = new Point(3, 219);
            dgvRapor.Name = "dgvRapor";
            dgvRapor.ReadOnly = true;
            dgvRapor.RowHeadersVisible = false;
            dgvRapor.RowTemplate.Height = 36;
            dgvRapor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRapor.Size = new Size(1067, 610);
            dgvRapor.TabIndex = 9;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Anchor = AnchorStyles.Top;
            dtpBaslangic.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dtpBaslangic.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(12, 165);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(134, 35);
            dtpBaslangic.TabIndex = 11;
            // 
            // btnDisaAktar
            // 
            btnDisaAktar.Anchor = AnchorStyles.Top;
            btnDisaAktar.BackColor = Color.Peru;
            btnDisaAktar.FlatAppearance.BorderSize = 0;
            btnDisaAktar.FlatStyle = FlatStyle.Flat;
            btnDisaAktar.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDisaAktar.ForeColor = Color.White;
            btnDisaAktar.Location = new Point(315, 178);
            btnDisaAktar.Name = "btnDisaAktar";
            btnDisaAktar.Size = new Size(170, 34);
            btnDisaAktar.TabIndex = 14;
            btnDisaAktar.Text = "DIŞA AKTAR";
            btnDisaAktar.UseVisualStyleBackColor = false;
            btnDisaAktar.Click += btnDisaAktar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel1.Controls.Add(pnlRaporKasa);
            flowLayoutPanel1.Controls.Add(pnlRaporSatis);
            flowLayoutPanel1.Controls.Add(pnlRaporStok);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1073, 125);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // pnlRaporKasa
            // 
            pnlRaporKasa.BackColor = Color.Transparent;
            pnlRaporKasa.BackgroundImage = Properties.Resources.rapor_kasa;
            pnlRaporKasa.Location = new Point(12, 3);
            pnlRaporKasa.Margin = new Padding(12, 3, 3, 3);
            pnlRaporKasa.Name = "pnlRaporKasa";
            pnlRaporKasa.Size = new Size(340, 122);
            pnlRaporKasa.TabIndex = 0;
            pnlRaporKasa.Click += pnlRaporKasa_Click;
            // 
            // pnlRaporSatis
            // 
            pnlRaporSatis.BackColor = Color.Transparent;
            pnlRaporSatis.BackgroundImage = Properties.Resources.rapor_satis;
            pnlRaporSatis.Location = new Point(367, 3);
            pnlRaporSatis.Margin = new Padding(12, 3, 3, 3);
            pnlRaporSatis.Name = "pnlRaporSatis";
            pnlRaporSatis.Size = new Size(340, 122);
            pnlRaporSatis.TabIndex = 1;
            pnlRaporSatis.Click += pnlRaporSatis_Click;
            // 
            // pnlRaporStok
            // 
            pnlRaporStok.BackColor = Color.Transparent;
            pnlRaporStok.BackgroundImage = Properties.Resources.rapor_stok;
            pnlRaporStok.Location = new Point(722, 3);
            pnlRaporStok.Margin = new Padding(12, 3, 3, 3);
            pnlRaporStok.Name = "pnlRaporStok";
            pnlRaporStok.Size = new Size(340, 122);
            pnlRaporStok.TabIndex = 2;
            pnlRaporStok.Click += pnlRaporStok_Click;
            // 
            // lblOzet
            // 
            lblOzet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOzet.BackColor = Color.Transparent;
            lblOzet.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOzet.ForeColor = Color.MidnightBlue;
            lblOzet.Location = new Point(491, 178);
            lblOzet.Name = "lblOzet";
            lblOzet.Size = new Size(579, 38);
            lblOzet.TabIndex = 17;
            lblOzet.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpBitis
            // 
            dtpBitis.Anchor = AnchorStyles.Top;
            dtpBitis.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dtpBitis.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(165, 165);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(134, 35);
            dtpBitis.TabIndex = 18;
            // 
            // btnOlustur
            // 
            btnOlustur.Anchor = AnchorStyles.Top;
            btnOlustur.BackColor = Color.MidnightBlue;
            btnOlustur.FlatAppearance.BorderSize = 0;
            btnOlustur.FlatStyle = FlatStyle.Flat;
            btnOlustur.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOlustur.ForeColor = Color.White;
            btnOlustur.Location = new Point(315, 137);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(170, 34);
            btnOlustur.TabIndex = 19;
            btnOlustur.Text = "RAPOR OLUŞTUR";
            btnOlustur.UseVisualStyleBackColor = false;
            btnOlustur.Click += btnOlustur_Click;
            // 
            // lblBaslangic
            // 
            lblBaslangic.Anchor = AnchorStyles.Top;
            lblBaslangic.BackColor = Color.Transparent;
            lblBaslangic.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslangic.Location = new Point(29, 136);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(100, 35);
            lblBaslangic.TabIndex = 20;
            lblBaslangic.Text = "Başlangıç";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(205, 136);
            label2.Name = "label2";
            label2.Size = new Size(55, 35);
            label2.TabIndex = 21;
            label2.Text = "Bitiş";
            // 
            // lblSecilen
            // 
            lblSecilen.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSecilen.Location = new Point(630, 137);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(443, 34);
            lblSecilen.TabIndex = 22;
            lblSecilen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Raporlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblSecilen);
            Controls.Add(dtpBaslangic);
            Controls.Add(dtpBitis);
            Controls.Add(label2);
            Controls.Add(lblBaslangic);
            Controls.Add(btnOlustur);
            Controls.Add(lblOzet);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnDisaAktar);
            Controls.Add(dgvRapor);
            Name = "Raporlar";
            Size = new Size(1073, 832);
            Load += Raporlar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRapor;
        private DateTimePicker dtpBaslangic;
        private Button btnDisaAktar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlRaporKasa;
        private Panel pnlRaporSatis;
        private Panel pnlRaporStok;
        private Label lblOzet;
        private DateTimePicker dtpBitis;
        private Button btnOlustur;
        private Label lblBaslangic;
        private Label label2;
        private Label lblSecilen;
    }
}
