namespace BTL_dotNET.Forms
{
    partial class ChiTietHDQuangCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblMabao = new Label();
            lblMadichvu = new Label();
            lblTenbao = new Label();
            lblDichvu = new Label();
            lblNgaybatdau = new Label();
            lblNgayketthuc = new Label();
            lblDongia = new Label();
            lblThanhtien = new Label();
            lblMaCTQC = new Label();
            lblBangchu = new Label();
            lblTongtien = new Label();
            dataGridView = new DataGridView();
            btnThemdichvu = new Button();
            btnCapnhat = new Button();
            btnBoqua = new Button();
            btnLuu = new Button();
            btnDong = new Button();
            lblNoidung = new Label();
            cboMabao = new ComboBox();
            cboMadichvu = new ComboBox();
            txtMaCTQC = new TextBox();
            textBox2 = new TextBox();
            txtDichvu = new TextBox();
            txtTenbao = new TextBox();
            txtDongia = new TextBox();
            txtThanhtien = new TextBox();
            txtNoidung = new TextBox();
            txtTongtien = new TextBox();
            mskNgaybatdau = new MaskedTextBox();
            mskNgayketthuc = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 9);
            label1.Name = "label1";
            label1.Size = new Size(396, 31);
            label1.TabIndex = 0;
            label1.Text = "CHI TIẾT HỢP ĐỒNG QUẢNG CÁO";
            // 
            // lblMabao
            // 
            lblMabao.AutoSize = true;
            lblMabao.Location = new Point(42, 51);
            lblMabao.Name = "lblMabao";
            lblMabao.Size = new Size(60, 20);
            lblMabao.TabIndex = 1;
            lblMabao.Text = "Mã báo";
            // 
            // lblMadichvu
            // 
            lblMadichvu.AutoSize = true;
            lblMadichvu.Location = new Point(42, 112);
            lblMadichvu.Name = "lblMadichvu";
            lblMadichvu.Size = new Size(81, 20);
            lblMadichvu.TabIndex = 2;
            lblMadichvu.Text = "Mã dịch vụ";
            // 
            // lblTenbao
            // 
            lblTenbao.AutoSize = true;
            lblTenbao.Location = new Point(295, 51);
            lblTenbao.Name = "lblTenbao";
            lblTenbao.Size = new Size(62, 20);
            lblTenbao.TabIndex = 3;
            lblTenbao.Text = "Tên báo";
            // 
            // lblDichvu
            // 
            lblDichvu.AutoSize = true;
            lblDichvu.Location = new Point(295, 90);
            lblDichvu.Name = "lblDichvu";
            lblDichvu.Size = new Size(58, 20);
            lblDichvu.TabIndex = 4;
            lblDichvu.Text = "Dịch vụ";
            // 
            // lblNgaybatdau
            // 
            lblNgaybatdau.AutoSize = true;
            lblNgaybatdau.Location = new Point(532, 51);
            lblNgaybatdau.Name = "lblNgaybatdau";
            lblNgaybatdau.Size = new Size(99, 20);
            lblNgaybatdau.TabIndex = 5;
            lblNgaybatdau.Text = "Ngày bắt đầu";
            // 
            // lblNgayketthuc
            // 
            lblNgayketthuc.AutoSize = true;
            lblNgayketthuc.Location = new Point(532, 90);
            lblNgayketthuc.Name = "lblNgayketthuc";
            lblNgayketthuc.Size = new Size(100, 20);
            lblNgayketthuc.TabIndex = 6;
            lblNgayketthuc.Text = "Ngày kết thúc";
            // 
            // lblDongia
            // 
            lblDongia.AutoSize = true;
            lblDongia.Location = new Point(809, 51);
            lblDongia.Name = "lblDongia";
            lblDongia.Size = new Size(62, 20);
            lblDongia.TabIndex = 7;
            lblDongia.Text = "Đơn giá";
            // 
            // lblThanhtien
            // 
            lblThanhtien.AutoSize = true;
            lblThanhtien.Location = new Point(809, 90);
            lblThanhtien.Name = "lblThanhtien";
            lblThanhtien.Size = new Size(78, 20);
            lblThanhtien.TabIndex = 8;
            lblThanhtien.Text = "Thành tiền";
            // 
            // lblMaCTQC
            // 
            lblMaCTQC.AutoSize = true;
            lblMaCTQC.Location = new Point(42, 174);
            lblMaCTQC.Name = "lblMaCTQC";
            lblMaCTQC.Size = new Size(71, 20);
            lblMaCTQC.TabIndex = 9;
            lblMaCTQC.Text = "Mã CTQC";
            // 
            // lblBangchu
            // 
            lblBangchu.AutoSize = true;
            lblBangchu.Location = new Point(45, 520);
            lblBangchu.Name = "lblBangchu";
            lblBangchu.Size = new Size(71, 20);
            lblBangchu.TabIndex = 10;
            lblBangchu.Text = "Bằng chữ";
            // 
            // lblTongtien
            // 
            lblTongtien.AutoSize = true;
            lblTongtien.Location = new Point(783, 473);
            lblTongtien.Name = "lblTongtien";
            lblTongtien.Size = new Size(72, 20);
            lblTongtien.TabIndex = 11;
            lblTongtien.Text = "Tổng tiền";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(45, 226);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(948, 226);
            dataGridView.TabIndex = 12;
            // 
            // btnThemdichvu
            // 
            btnThemdichvu.Location = new Point(45, 470);
            btnThemdichvu.Name = "btnThemdichvu";
            btnThemdichvu.Size = new Size(121, 29);
            btnThemdichvu.TabIndex = 13;
            btnThemdichvu.Text = "Thêm dịch vụ";
            btnThemdichvu.UseVisualStyleBackColor = true;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Location = new Point(208, 469);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(94, 29);
            btnCapnhat.TabIndex = 14;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = true;
            // 
            // btnBoqua
            // 
            btnBoqua.Location = new Point(541, 470);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new Size(94, 29);
            btnBoqua.TabIndex = 15;
            btnBoqua.Text = "Bỏ qua";
            btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(392, 470);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(902, 520);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 16;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // lblNoidung
            // 
            lblNoidung.AutoSize = true;
            lblNoidung.Location = new Point(375, 174);
            lblNoidung.Name = "lblNoidung";
            lblNoidung.Size = new Size(71, 20);
            lblNoidung.TabIndex = 17;
            lblNoidung.Text = "Nội dung";
            // 
            // cboMabao
            // 
            cboMabao.FormattingEnabled = true;
            cboMabao.Location = new Point(121, 51);
            cboMabao.Name = "cboMabao";
            cboMabao.Size = new Size(151, 28);
            cboMabao.TabIndex = 18;
            // 
            // cboMadichvu
            // 
            cboMadichvu.FormattingEnabled = true;
            cboMadichvu.Location = new Point(129, 104);
            cboMadichvu.Name = "cboMadichvu";
            cboMadichvu.Size = new Size(151, 28);
            cboMadichvu.TabIndex = 19;
            // 
            // txtMaCTQC
            // 
            txtMaCTQC.Location = new Point(121, 171);
            txtMaCTQC.Name = "txtMaCTQC";
            txtMaCTQC.Size = new Size(125, 27);
            txtMaCTQC.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(473, 266);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 21;
            // 
            // txtDichvu
            // 
            txtDichvu.Location = new Point(375, 90);
            txtDichvu.Name = "txtDichvu";
            txtDichvu.Size = new Size(125, 27);
            txtDichvu.TabIndex = 22;
            // 
            // txtTenbao
            // 
            txtTenbao.Location = new Point(375, 44);
            txtTenbao.Name = "txtTenbao";
            txtTenbao.Size = new Size(125, 27);
            txtTenbao.TabIndex = 23;
            // 
            // txtDongia
            // 
            txtDongia.Location = new Point(902, 51);
            txtDongia.Name = "txtDongia";
            txtDongia.Size = new Size(125, 27);
            txtDongia.TabIndex = 24;
            // 
            // txtThanhtien
            // 
            txtThanhtien.Location = new Point(902, 87);
            txtThanhtien.Name = "txtThanhtien";
            txtThanhtien.Size = new Size(125, 27);
            txtThanhtien.TabIndex = 25;
            // 
            // txtNoidung
            // 
            txtNoidung.Location = new Point(470, 167);
            txtNoidung.Name = "txtNoidung";
            txtNoidung.Size = new Size(484, 27);
            txtNoidung.TabIndex = 26;
            // 
            // txtTongtien
            // 
            txtTongtien.Location = new Point(871, 469);
            txtTongtien.Name = "txtTongtien";
            txtTongtien.Size = new Size(125, 27);
            txtTongtien.TabIndex = 27;
            // 
            // mskNgaybatdau
            // 
            mskNgaybatdau.Location = new Point(656, 51);
            mskNgaybatdau.Mask = "00/00/0000";
            mskNgaybatdau.Name = "mskNgaybatdau";
            mskNgaybatdau.Size = new Size(125, 27);
            mskNgaybatdau.TabIndex = 28;
            mskNgaybatdau.ValidatingType = typeof(DateTime);
            // 
            // mskNgayketthuc
            // 
            mskNgayketthuc.Location = new Point(656, 84);
            mskNgayketthuc.Mask = "00/00/0000";
            mskNgayketthuc.Name = "mskNgayketthuc";
            mskNgayketthuc.Size = new Size(125, 27);
            mskNgayketthuc.TabIndex = 29;
            mskNgayketthuc.ValidatingType = typeof(DateTime);
            // 
            // ChiTietHDQuangCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._094835hop_dong_lao_dong_vo_hieu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1071, 559);
            Controls.Add(mskNgayketthuc);
            Controls.Add(mskNgaybatdau);
            Controls.Add(txtTongtien);
            Controls.Add(txtNoidung);
            Controls.Add(txtThanhtien);
            Controls.Add(txtDongia);
            Controls.Add(txtTenbao);
            Controls.Add(txtDichvu);
            Controls.Add(textBox2);
            Controls.Add(txtMaCTQC);
            Controls.Add(cboMadichvu);
            Controls.Add(cboMabao);
            Controls.Add(lblNoidung);
            Controls.Add(btnDong);
            Controls.Add(btnLuu);
            Controls.Add(btnBoqua);
            Controls.Add(btnCapnhat);
            Controls.Add(btnThemdichvu);
            Controls.Add(dataGridView);
            Controls.Add(lblTongtien);
            Controls.Add(lblBangchu);
            Controls.Add(lblMaCTQC);
            Controls.Add(lblThanhtien);
            Controls.Add(lblDongia);
            Controls.Add(lblNgayketthuc);
            Controls.Add(lblNgaybatdau);
            Controls.Add(lblDichvu);
            Controls.Add(lblTenbao);
            Controls.Add(lblMadichvu);
            Controls.Add(lblMabao);
            Controls.Add(label1);
            Name = "ChiTietHDQuangCao";
            Text = "ChiTietHDQuangCao";
            Load += ChiTietHDQuangCao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMabao;
        private Label lblMadichvu;
        private Label lblTenbao;
        private Label lblDichvu;
        private Label lblNgaybatdau;
        private Label lblNgayketthuc;
        private Label lblDongia;
        private Label lblThanhtien;
        private Label lblMaCTQC;
        private Label lblBangchu;
        private Label lblTongtien;
        private DataGridView dataGridView;
        private Button btnThemdichvu;
        private Button btnCapnhat;
        private Button btnBoqua;
        private Button btnLuu;
        private Button btnDong;
        private Label lblNoidung;
        private ComboBox cboMabao;
        private ComboBox cboMadichvu;
        private TextBox txtMaCTQC;
        private TextBox textBox2;
        private TextBox txtDichvu;
        private TextBox txtTenbao;
        private TextBox txtDongia;
        private TextBox txtThanhtien;
        private TextBox txtNoidung;
        private TextBox txtTongtien;
        private MaskedTextBox mskNgaybatdau;
        private MaskedTextBox mskNgayketthuc;
    }
}