namespace Projem
{
    partial class Sorunlar
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlMevcutSRN = new Panel();
            lblMevcutSorun = new Label();
            panel1 = new Panel();
            lblPompaArizasi = new Label();
            panel2 = new Panel();
            lblKritikStok = new Label();
            panel3 = new Panel();
            lblCozulen = new Label();
            dgvSorun = new DataGridView();
            colTarih = new DataGridViewTextBoxColumn();
            colTur = new DataGridViewTextBoxColumn();
            colNerede = new DataGridViewTextBoxColumn();
            colMesaj = new DataGridViewTextBoxColumn();
            colDurum = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1.SuspendLayout();
            pnlMevcutSRN.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSorun).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel1.Controls.Add(pnlMevcutSRN);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1073, 159);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlMevcutSRN
            // 
            pnlMevcutSRN.BackColor = Color.Transparent;
            pnlMevcutSRN.BackgroundImage = Properties.Resources.sorun_mevcut;
            pnlMevcutSRN.BackgroundImageLayout = ImageLayout.Center;
            pnlMevcutSRN.Controls.Add(lblMevcutSorun);
            pnlMevcutSRN.Location = new Point(8, 3);
            pnlMevcutSRN.Margin = new Padding(8, 3, 3, 3);
            pnlMevcutSRN.Name = "pnlMevcutSRN";
            pnlMevcutSRN.Size = new Size(256, 153);
            pnlMevcutSRN.TabIndex = 0;
            // 
            // lblMevcutSorun
            // 
            lblMevcutSorun.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMevcutSorun.ForeColor = Color.FromArgb(236, 68, 68);
            lblMevcutSorun.ImageAlign = ContentAlignment.MiddleRight;
            lblMevcutSorun.Location = new Point(93, 70);
            lblMevcutSorun.Name = "lblMevcutSorun";
            lblMevcutSorun.Size = new Size(152, 39);
            lblMevcutSorun.TabIndex = 0;
            lblMevcutSorun.Text = "5";
            lblMevcutSorun.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.sorun_pompa_arizasi;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(lblPompaArizasi);
            panel1.Location = new Point(275, 3);
            panel1.Margin = new Padding(8, 3, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 153);
            panel1.TabIndex = 1;
            // 
            // lblPompaArizasi
            // 
            lblPompaArizasi.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPompaArizasi.ForeColor = Color.FromArgb(233, 71, 152);
            lblPompaArizasi.ImageAlign = ContentAlignment.MiddleRight;
            lblPompaArizasi.Location = new Point(93, 70);
            lblPompaArizasi.Name = "lblPompaArizasi";
            lblPompaArizasi.Size = new Size(152, 39);
            lblPompaArizasi.TabIndex = 1;
            lblPompaArizasi.Text = "5";
            lblPompaArizasi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.sorun_kritik_stok;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(lblKritikStok);
            panel2.Location = new Point(542, 3);
            panel2.Margin = new Padding(8, 3, 3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 153);
            panel2.TabIndex = 2;
            // 
            // lblKritikStok
            // 
            lblKritikStok.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKritikStok.ForeColor = Color.FromArgb(177, 88, 255);
            lblKritikStok.ImageAlign = ContentAlignment.MiddleRight;
            lblKritikStok.Location = new Point(93, 70);
            lblKritikStok.Name = "lblKritikStok";
            lblKritikStok.Size = new Size(152, 39);
            lblKritikStok.TabIndex = 1;
            lblKritikStok.Text = "5";
            lblKritikStok.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.sorun_cozulen;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Controls.Add(lblCozulen);
            panel3.Location = new Point(809, 3);
            panel3.Margin = new Padding(8, 3, 3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(256, 153);
            panel3.TabIndex = 3;
            // 
            // lblCozulen
            // 
            lblCozulen.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCozulen.ForeColor = Color.FromArgb(34, 195, 93);
            lblCozulen.ImageAlign = ContentAlignment.MiddleRight;
            lblCozulen.Location = new Point(93, 70);
            lblCozulen.Name = "lblCozulen";
            lblCozulen.Size = new Size(152, 39);
            lblCozulen.TabIndex = 1;
            lblCozulen.Text = "5";
            lblCozulen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvSorun
            // 
            dgvSorun.AllowUserToAddRows = false;
            dgvSorun.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 246, 252);
            dgvSorun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSorun.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSorun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSorun.BackgroundColor = Color.White;
            dgvSorun.BorderStyle = BorderStyle.None;
            dgvSorun.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSorun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSorun.ColumnHeadersHeight = 42;
            dgvSorun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSorun.Columns.AddRange(new DataGridViewColumn[] { colTarih, colTur, colNerede, colMesaj, colDurum });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 224, 178);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvSorun.DefaultCellStyle = dataGridViewCellStyle8;
            dgvSorun.EnableHeadersVisualStyles = false;
            dgvSorun.GridColor = Color.FromArgb(225, 228, 240);
            dgvSorun.Location = new Point(8, 214);
            dgvSorun.Name = "dgvSorun";
            dgvSorun.ReadOnly = true;
            dgvSorun.RowHeadersVisible = false;
            dgvSorun.RowTemplate.Height = 36;
            dgvSorun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSorun.Size = new Size(1057, 615);
            dgvSorun.TabIndex = 8;
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
            // colTur
            // 
            colTur.DataPropertyName = "Tür";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTur.DefaultCellStyle = dataGridViewCellStyle4;
            colTur.HeaderText = "Tür";
            colTur.Name = "colTur";
            colTur.ReadOnly = true;
            // 
            // colNerede
            // 
            colNerede.DataPropertyName = "Nerede";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            colNerede.DefaultCellStyle = dataGridViewCellStyle5;
            colNerede.HeaderText = "Nerede";
            colNerede.Name = "colNerede";
            colNerede.ReadOnly = true;
            // 
            // colMesaj
            // 
            colMesaj.DataPropertyName = "Mesaj";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = null;
            colMesaj.DefaultCellStyle = dataGridViewCellStyle6;
            colMesaj.HeaderText = "Mesaj";
            colMesaj.Name = "colMesaj";
            colMesaj.ReadOnly = true;
            // 
            // colDurum
            // 
            colDurum.DataPropertyName = "Durum";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = null;
            colDurum.DefaultCellStyle = dataGridViewCellStyle7;
            colDurum.HeaderText = "Durum";
            colDurum.Name = "colDurum";
            colDurum.ReadOnly = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // Sorunlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvSorun);
            Controls.Add(flowLayoutPanel1);
            Name = "Sorunlar";
            Size = new Size(1073, 832);
            Load += Sorunlar_Load;
            flowLayoutPanel1.ResumeLayout(false);
            pnlMevcutSRN.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSorun).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlMevcutSRN;
        private Label lblMevcutSorun;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblPompaArizasi;
        private Label lblKritikStok;
        private Label lblCozulen;
        private DataGridView dgvSorun;
        private DataGridViewTextBoxColumn colTarih;
        private DataGridViewTextBoxColumn colTur;
        private DataGridViewTextBoxColumn colNerede;
        private DataGridViewTextBoxColumn colMesaj;
        private DataGridViewTextBoxColumn colDurum;
        private System.Windows.Forms.Timer timer1;
    }
}
