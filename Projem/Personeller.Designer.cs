namespace Projem
{
    partial class Personeller
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
            lblPersonelEkle = new Label();
            panel5 = new Panel();
            btnSil = new Button();
            btnEkle = new Button();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            lblRol = new Label();
            cmbRol = new ComboBox();
            lblSoyad = new Label();
            lblAd = new Label();
            panel4 = new Panel();
            lblKasiyer = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            lblPompaci = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            lblYonetici = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            lblToplam = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flpPersonel = new FlowLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            dgvPersonel = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colAd = new DataGridViewTextBoxColumn();
            colSoyad = new DataGridViewTextBoxColumn();
            colRol = new DataGridViewTextBoxColumn();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flpPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
            SuspendLayout();
            // 
            // lblPersonelEkle
            // 
            lblPersonelEkle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPersonelEkle.ForeColor = Color.White;
            lblPersonelEkle.Location = new Point(1, 20);
            lblPersonelEkle.Name = "lblPersonelEkle";
            lblPersonelEkle.Size = new Size(250, 30);
            lblPersonelEkle.TabIndex = 7;
            lblPersonelEkle.Text = "PERSONEL EKLE";
            lblPersonelEkle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.BackColor = Color.MidnightBlue;
            panel5.Controls.Add(btnSil);
            panel5.Controls.Add(btnEkle);
            panel5.Controls.Add(txtAd);
            panel5.Controls.Add(txtSoyad);
            panel5.Controls.Add(lblRol);
            panel5.Controls.Add(cmbRol);
            panel5.Controls.Add(lblSoyad);
            panel5.Controls.Add(lblAd);
            panel5.Controls.Add(lblPersonelEkle);
            panel5.Location = new Point(821, 154);
            panel5.Name = "panel5";
            panel5.Size = new Size(252, 665);
            panel5.TabIndex = 8;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.White;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(130, 222);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(117, 44);
            btnSil.TabIndex = 15;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.White;
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(5, 222);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(117, 44);
            btnEkle.TabIndex = 14;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(5, 87);
            txtAd.Name = "txtAd";
            txtAd.PlaceholderText = "Adı Giriniz.";
            txtAd.Size = new Size(117, 29);
            txtAd.TabIndex = 10;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(130, 87);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.PlaceholderText = "Soyadı Giriniz.";
            txtSoyad.Size = new Size(117, 29);
            txtSoyad.TabIndex = 11;
            // 
            // lblRol
            // 
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblRol.ForeColor = Color.White;
            lblRol.Location = new Point(95, 127);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(63, 30);
            lblRol.TabIndex = 12;
            lblRol.Text = "Rol";
            lblRol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Yönetici", "Pompacı", "Kasiyer" });
            cmbRol.Location = new Point(4, 166);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(242, 29);
            cmbRol.TabIndex = 13;
            // 
            // lblSoyad
            // 
            lblSoyad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSoyad.ForeColor = Color.White;
            lblSoyad.Location = new Point(157, 54);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(63, 30);
            lblSoyad.TabIndex = 9;
            lblSoyad.Text = "Soyad";
            lblSoyad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAd
            // 
            lblAd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAd.ForeColor = Color.White;
            lblAd.Location = new Point(41, 54);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(44, 30);
            lblAd.TabIndex = 8;
            lblAd.Text = "Ad";
            lblAd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(lblKasiyer);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(834, 3);
            panel4.Margin = new Padding(33, 3, 30, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(204, 128);
            panel4.TabIndex = 3;
            // 
            // lblKasiyer
            // 
            lblKasiyer.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKasiyer.ForeColor = Color.White;
            lblKasiyer.Location = new Point(100, 62);
            lblKasiyer.Name = "lblKasiyer";
            lblKasiyer.Size = new Size(101, 66);
            lblKasiyer.TabIndex = 3;
            lblKasiyer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 9);
            label8.Name = "label8";
            label8.Size = new Size(198, 35);
            label8.TabIndex = 1;
            label8.Text = "Kasiyer Sayısı";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.kasiyer_icon;
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Location = new Point(0, 47);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(94, 95);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(lblPompaci);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(567, 3);
            panel3.Margin = new Padding(33, 3, 30, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 129);
            panel3.TabIndex = 2;
            // 
            // lblPompaci
            // 
            lblPompaci.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPompaci.ForeColor = Color.White;
            lblPompaci.Location = new Point(100, 62);
            lblPompaci.Name = "lblPompaci";
            lblPompaci.Size = new Size(101, 66);
            lblPompaci.TabIndex = 3;
            lblPompaci.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(198, 35);
            label6.TabIndex = 1;
            label6.Text = "Pompacı Sayısı";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.pompaci_icon;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(0, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(94, 95);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblYonetici);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(300, 3);
            panel2.Margin = new Padding(33, 3, 30, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 129);
            panel2.TabIndex = 1;
            // 
            // lblYonetici
            // 
            lblYonetici.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYonetici.ForeColor = Color.White;
            lblYonetici.Location = new Point(100, 62);
            lblYonetici.Name = "lblYonetici";
            lblYonetici.Size = new Size(101, 66);
            lblYonetici.TabIndex = 3;
            lblYonetici.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(198, 35);
            label4.TabIndex = 1;
            label4.Text = "Yönetici Sayısı";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.yonetici_icon;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(0, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblToplam);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(33, 3);
            panel1.Margin = new Padding(33, 3, 30, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 129);
            panel1.TabIndex = 0;
            // 
            // lblToplam
            // 
            lblToplam.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplam.ForeColor = Color.White;
            lblToplam.Location = new Point(100, 62);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(101, 66);
            lblToplam.TabIndex = 2;
            lblToplam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 35);
            label1.TabIndex = 1;
            label1.Text = "Personel Sayısı";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.personel_icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(0, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flpPersonel
            // 
            flpPersonel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpPersonel.BackColor = Color.MidnightBlue;
            flpPersonel.Controls.Add(panel1);
            flpPersonel.Controls.Add(panel2);
            flpPersonel.Controls.Add(panel3);
            flpPersonel.Controls.Add(panel4);
            flpPersonel.Location = new Point(0, 0);
            flpPersonel.Name = "flpPersonel";
            flpPersonel.Size = new Size(1073, 132);
            flpPersonel.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // dgvPersonel
            // 
            dgvPersonel.AllowUserToAddRows = false;
            dgvPersonel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 246, 252);
            dgvPersonel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPersonel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonel.BackgroundColor = Color.White;
            dgvPersonel.BorderStyle = BorderStyle.None;
            dgvPersonel.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPersonel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPersonel.ColumnHeadersHeight = 42;
            dgvPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPersonel.Columns.AddRange(new DataGridViewColumn[] { colNo, colAd, colSoyad, colRol });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 224, 178);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvPersonel.DefaultCellStyle = dataGridViewCellStyle7;
            dgvPersonel.EnableHeadersVisualStyles = false;
            dgvPersonel.GridColor = Color.FromArgb(225, 228, 240);
            dgvPersonel.Location = new Point(3, 154);
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.ReadOnly = true;
            dgvPersonel.RowHeadersVisible = false;
            dgvPersonel.RowTemplate.Height = 36;
            dgvPersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonel.Size = new Size(812, 658);
            dgvPersonel.TabIndex = 9;
            // 
            // colNo
            // 
            colNo.DataPropertyName = "No";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNo.DefaultCellStyle = dataGridViewCellStyle3;
            colNo.HeaderText = "No";
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colAd
            // 
            colAd.DataPropertyName = "Ad";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            colAd.DefaultCellStyle = dataGridViewCellStyle4;
            colAd.HeaderText = "Ad";
            colAd.Name = "colAd";
            colAd.ReadOnly = true;
            // 
            // colSoyad
            // 
            colSoyad.DataPropertyName = "Soyad";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            colSoyad.DefaultCellStyle = dataGridViewCellStyle5;
            colSoyad.HeaderText = "Soyad";
            colSoyad.Name = "colSoyad";
            colSoyad.ReadOnly = true;
            // 
            // colRol
            // 
            colRol.DataPropertyName = "Rol";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = null;
            colRol.DefaultCellStyle = dataGridViewCellStyle6;
            colRol.HeaderText = "Rol";
            colRol.Name = "colRol";
            colRol.ReadOnly = true;
            // 
            // Personeller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvPersonel);
            Controls.Add(flpPersonel);
            Controls.Add(panel5);
            Name = "Personeller";
            Size = new Size(1073, 819);
            Load += Personeller_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flpPersonel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblPersonelEkle;
        private Panel panel5;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label lblSoyad;
        private Label lblAd;
        private Label lblRol;
        private ComboBox cmbRol;
        private Button btnEkle;
        private Panel panel4;
        private Label lblKasiyer;
        private Label label8;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Label lblPompaci;
        private Label label6;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Label lblYonetici;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label lblToplam;
        private Label label1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flpPersonel;
        private System.Windows.Forms.Timer timer1;
        private Button btnSil;
        private DataGridView dgvPersonel;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewTextBoxColumn colSoyad;
        private DataGridViewTextBoxColumn colRol;
    }
}
