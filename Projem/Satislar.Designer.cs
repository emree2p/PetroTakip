namespace Projem
{
    partial class Satislar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            flpSatis = new FlowLayoutPanel();
            panel1 = new Panel();
            lblCiro = new Label();
            panel2 = new Panel();
            lblLitre = new Label();
            panel3 = new Panel();
            lblOrtalama = new Label();
            dgvSatis = new DataGridView();
            colTarih = new DataGridViewTextBoxColumn();
            colPompa = new DataGridViewTextBoxColumn();
            colYakit = new DataGridViewTextBoxColumn();
            colPompaci = new DataGridViewTextBoxColumn();
            colPlaka = new DataGridViewTextBoxColumn();
            colLitre = new DataGridViewTextBoxColumn();
            colBirimFiyat = new DataGridViewTextBoxColumn();
            Tutar = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            flpSatis.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSatis).BeginInit();
            SuspendLayout();
            // 
            // flpSatis
            // 
            flpSatis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flpSatis.BackColor = Color.White;
            flpSatis.Controls.Add(panel1);
            flpSatis.Controls.Add(panel2);
            flpSatis.Controls.Add(panel3);
            flpSatis.Location = new Point(0, 0);
            flpSatis.Name = "flpSatis";
            flpSatis.Size = new Size(1073, 163);
            flpSatis.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.satislar_bciro;
            panel1.Controls.Add(lblCiro);
            panel1.Location = new Point(20, 3);
            panel1.Margin = new Padding(20, 3, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 153);
            panel1.TabIndex = 0;
            // 
            // lblCiro
            // 
            lblCiro.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCiro.ForeColor = Color.FromArgb(245, 158, 11);
            lblCiro.Location = new Point(96, 77);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(236, 30);
            lblCiro.TabIndex = 0;
            lblCiro.Text = "₺";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.satislar_blitre;
            panel2.Controls.Add(lblLitre);
            panel2.Location = new Point(368, 3);
            panel2.Margin = new Padding(10, 3, 3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 153);
            panel2.TabIndex = 1;
            // 
            // lblLitre
            // 
            lblLitre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLitre.ForeColor = Color.FromArgb(20, 184, 166);
            lblLitre.Location = new Point(96, 77);
            lblLitre.Name = "lblLitre";
            lblLitre.Size = new Size(236, 30);
            lblLitre.TabIndex = 1;
            lblLitre.Text = "₺";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.satislar_ortalama;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Controls.Add(lblOrtalama);
            panel3.Location = new Point(716, 3);
            panel3.Margin = new Padding(10, 3, 3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 153);
            panel3.TabIndex = 2;
            // 
            // lblOrtalama
            // 
            lblOrtalama.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOrtalama.ForeColor = Color.FromArgb(139, 92, 246);
            lblOrtalama.Location = new Point(96, 77);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(236, 30);
            lblOrtalama.TabIndex = 1;
            lblOrtalama.Text = "₺";
            lblOrtalama.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvSatis
            // 
            dgvSatis.AllowUserToAddRows = false;
            dgvSatis.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 246, 252);
            dgvSatis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSatis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSatis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSatis.BackgroundColor = Color.White;
            dgvSatis.BorderStyle = BorderStyle.None;
            dgvSatis.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSatis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSatis.ColumnHeadersHeight = 42;
            dgvSatis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSatis.Columns.AddRange(new DataGridViewColumn[] { colTarih, colPompa, colYakit, colPompaci, colPlaka, colLitre, colBirimFiyat, Tutar });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 224, 178);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvSatis.DefaultCellStyle = dataGridViewCellStyle7;
            dgvSatis.EnableHeadersVisualStyles = false;
            dgvSatis.GridColor = Color.FromArgb(225, 228, 240);
            dgvSatis.Location = new Point(6, 200);
            dgvSatis.Name = "dgvSatis";
            dgvSatis.ReadOnly = true;
            dgvSatis.RowHeadersVisible = false;
            dgvSatis.RowTemplate.Height = 36;
            dgvSatis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSatis.Size = new Size(1064, 629);
            dgvSatis.TabIndex = 7;
            // 
            // colTarih
            // 
            colTarih.DataPropertyName = "Tarih";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            colTarih.DefaultCellStyle = dataGridViewCellStyle3;
            colTarih.HeaderText = "Tarih";
            colTarih.Name = "colTarih";
            colTarih.ReadOnly = true;
            // 
            // colPompa
            // 
            colPompa.DataPropertyName = "Pompa";
            colPompa.HeaderText = "Pompa";
            colPompa.Name = "colPompa";
            colPompa.ReadOnly = true;
            // 
            // colYakit
            // 
            colYakit.DataPropertyName = "Yakıt";
            colYakit.HeaderText = "Yakıt";
            colYakit.Name = "colYakit";
            colYakit.ReadOnly = true;
            // 
            // colPompaci
            // 
            colPompaci.DataPropertyName = "Pompacı";
            colPompaci.HeaderText = "Pompacı";
            colPompaci.Name = "colPompaci";
            colPompaci.ReadOnly = true;
            // 
            // colPlaka
            // 
            colPlaka.DataPropertyName = "Plaka";
            colPlaka.HeaderText = "Plaka";
            colPlaka.Name = "colPlaka";
            colPlaka.ReadOnly = true;
            // 
            // colLitre
            // 
            colLitre.DataPropertyName = "Litre";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            colLitre.DefaultCellStyle = dataGridViewCellStyle4;
            colLitre.HeaderText = "Litre";
            colLitre.Name = "colLitre";
            colLitre.ReadOnly = true;
            // 
            // colBirimFiyat
            // 
            colBirimFiyat.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            colBirimFiyat.DefaultCellStyle = dataGridViewCellStyle5;
            colBirimFiyat.HeaderText = "Birim Fiyat";
            colBirimFiyat.Name = "colBirimFiyat";
            colBirimFiyat.ReadOnly = true;
            // 
            // Tutar
            // 
            Tutar.DataPropertyName = "Tutar";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            Tutar.DefaultCellStyle = dataGridViewCellStyle6;
            Tutar.HeaderText = "Tutar";
            Tutar.Name = "Tutar";
            Tutar.ReadOnly = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // Satislar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvSatis);
            Controls.Add(flpSatis);
            Name = "Satislar";
            Size = new Size(1073, 832);
            Load += Satislar_Load;
            flpSatis.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSatis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpSatis;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvSatis;
        private Label lblCiro;
        private Label lblLitre;
        private Label lblOrtalama;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn colTarih;
        private DataGridViewTextBoxColumn colPompa;
        private DataGridViewTextBoxColumn colYakit;
        private DataGridViewTextBoxColumn colPompaci;
        private DataGridViewTextBoxColumn colPlaka;
        private DataGridViewTextBoxColumn colLitre;
        private DataGridViewTextBoxColumn colBirimFiyat;
        private DataGridViewTextBoxColumn Tutar;
    }
}
