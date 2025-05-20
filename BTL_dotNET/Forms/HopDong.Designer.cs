namespace BTL_dotNET.Forms
{
    partial class HopDong
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
            lblHopDong = new Label();
            lblMahopdong = new Label();
            lblNgayky = new Label();
            lblManhanvien = new Label();
            lblTennhanvien = new Label();
            lblMakhachhang = new Label();
            lblTenkhachhang = new Label();
            lblDiachi = new Label();
            lblDienthoai = new Label();
            label9 = new Label();
            btnThemHDQuangcao = new Button();
            btnThemHDVietbai = new Button();
            btnHuyHD = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnLammoi = new Button();
            btnTimkiem = new Button();
            btnXuathop = new Button();
            btnDong = new Button();
            DataGridView = new DataGridView();
            txtMahopdong = new TextBox();
            txtTennhanvien = new TextBox();
            txtTenkhachhang = new TextBox();
            txtDiachi = new TextBox();
            cboManhanvien = new ComboBox();
            cboMakhachhang = new ComboBox();
            cboMahopdong = new ComboBox();
            mskNgayky = new MaskedTextBox();
            mskDienthoai = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblHopDong
            // 
            lblHopDong.AutoSize = true;
            lblHopDong.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHopDong.Location = new Point(353, 9);
            lblHopDong.Name = "lblHopDong";
            lblHopDong.Size = new Size(369, 41);
            lblHopDong.TabIndex = 0;
            lblHopDong.Text = "DANH MỤC HỢP ĐỒNG";
            // 
            // lblMahopdong
            // 
            lblMahopdong.AutoSize = true;
            lblMahopdong.Location = new Point(74, 61);
            lblMahopdong.Name = "lblMahopdong";
            lblMahopdong.Size = new Size(99, 20);
            lblMahopdong.TabIndex = 1;
            lblMahopdong.Text = "Mã hợp đồng";
            // 
            // lblNgayky
            // 
            lblNgayky.AutoSize = true;
            lblNgayky.Location = new Point(74, 108);
            lblNgayky.Name = "lblNgayky";
            lblNgayky.Size = new Size(62, 20);
            lblNgayky.TabIndex = 2;
            lblNgayky.Text = "Ngày ký";
            // 
            // lblManhanvien
            // 
            lblManhanvien.AutoSize = true;
            lblManhanvien.Location = new Point(74, 160);
            lblManhanvien.Name = "lblManhanvien";
            lblManhanvien.Size = new Size(97, 20);
            lblManhanvien.TabIndex = 3;
            lblManhanvien.Text = "Mã nhân viên";
            // 
            // lblTennhanvien
            // 
            lblTennhanvien.AutoSize = true;
            lblTennhanvien.Location = new Point(74, 214);
            lblTennhanvien.Name = "lblTennhanvien";
            lblTennhanvien.Size = new Size(99, 20);
            lblTennhanvien.TabIndex = 4;
            lblTennhanvien.Text = "Tên nhân viên";
            // 
            // lblMakhachhang
            // 
            lblMakhachhang.AutoSize = true;
            lblMakhachhang.Location = new Point(652, 61);
            lblMakhachhang.Name = "lblMakhachhang";
            lblMakhachhang.Size = new Size(109, 20);
            lblMakhachhang.TabIndex = 5;
            lblMakhachhang.Text = "Mã khách hàng";
            // 
            // lblTenkhachhang
            // 
            lblTenkhachhang.AutoSize = true;
            lblTenkhachhang.Location = new Point(652, 108);
            lblTenkhachhang.Name = "lblTenkhachhang";
            lblTenkhachhang.Size = new Size(111, 20);
            lblTenkhachhang.TabIndex = 6;
            lblTenkhachhang.Text = "Tên khách hàng";
            // 
            // lblDiachi
            // 
            lblDiachi.AutoSize = true;
            lblDiachi.Location = new Point(652, 151);
            lblDiachi.Name = "lblDiachi";
            lblDiachi.Size = new Size(55, 20);
            lblDiachi.TabIndex = 7;
            lblDiachi.Text = "Địa chỉ";
            // 
            // lblDienthoai
            // 
            lblDienthoai.AutoSize = true;
            lblDienthoai.Location = new Point(652, 202);
            lblDienthoai.Name = "lblDienthoai";
            lblDienthoai.Size = new Size(78, 20);
            lblDienthoai.TabIndex = 8;
            lblDienthoai.Text = "Điện thoại";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(74, 505);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 9;
            label9.Text = "Mã hợp đồng";
            // 
            // btnThemHDQuangcao
            // 
            btnThemHDQuangcao.Location = new Point(74, 441);
            btnThemHDQuangcao.Name = "btnThemHDQuangcao";
            btnThemHDQuangcao.Size = new Size(159, 29);
            btnThemHDQuangcao.TabIndex = 10;
            btnThemHDQuangcao.Text = "Thêm HĐ Quảng Cáo";
            btnThemHDQuangcao.UseVisualStyleBackColor = true;
            // 
            // btnThemHDVietbai
            // 
            btnThemHDVietbai.Location = new Point(249, 441);
            btnThemHDVietbai.Name = "btnThemHDVietbai";
            btnThemHDVietbai.Size = new Size(142, 29);
            btnThemHDVietbai.TabIndex = 11;
            btnThemHDVietbai.Text = "Thêm HĐ Viết Bài";
            btnThemHDVietbai.UseVisualStyleBackColor = true;
            // 
            // btnHuyHD
            // 
            btnHuyHD.Location = new Point(471, 441);
            btnHuyHD.Name = "btnHuyHD";
            btnHuyHD.Size = new Size(94, 29);
            btnHuyHD.TabIndex = 12;
            btnHuyHD.Text = "Huỷ HĐ";
            btnHuyHD.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(613, 441);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(723, 441);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnLammoi
            // 
            btnLammoi.Location = new Point(841, 441);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(94, 29);
            btnLammoi.TabIndex = 15;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(420, 501);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(94, 29);
            btnTimkiem.TabIndex = 16;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // btnXuathop
            // 
            btnXuathop.Location = new Point(723, 501);
            btnXuathop.Name = "btnXuathop";
            btnXuathop.Size = new Size(94, 29);
            btnXuathop.TabIndex = 17;
            btnXuathop.Text = "Xuất hợp đồng";
            btnXuathop.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(841, 501);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 18;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(74, 255);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(868, 170);
            DataGridView.TabIndex = 19;
            DataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // txtMahopdong
            // 
            txtMahopdong.Location = new Point(229, 61);
            txtMahopdong.Name = "txtMahopdong";
            txtMahopdong.Size = new Size(151, 27);
            txtMahopdong.TabIndex = 20;
            // 
            // txtTennhanvien
            // 
            txtTennhanvien.Location = new Point(229, 207);
            txtTennhanvien.Name = "txtTennhanvien";
            txtTennhanvien.Size = new Size(151, 27);
            txtTennhanvien.TabIndex = 21;
            // 
            // txtTenkhachhang
            // 
            txtTenkhachhang.Location = new Point(791, 101);
            txtTenkhachhang.Name = "txtTenkhachhang";
            txtTenkhachhang.Size = new Size(151, 27);
            txtTenkhachhang.TabIndex = 22;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(791, 151);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(151, 27);
            txtDiachi.TabIndex = 23;
            // 
            // cboManhanvien
            // 
            cboManhanvien.FormattingEnabled = true;
            cboManhanvien.Location = new Point(229, 152);
            cboManhanvien.Name = "cboManhanvien";
            cboManhanvien.Size = new Size(151, 28);
            cboManhanvien.TabIndex = 24;
            cboManhanvien.SelectedIndexChanged += cboManhanvien_SelectedIndexChanged;
            // 
            // cboMakhachhang
            // 
            cboMakhachhang.FormattingEnabled = true;
            cboMakhachhang.Location = new Point(791, 53);
            cboMakhachhang.Name = "cboMakhachhang";
            cboMakhachhang.Size = new Size(151, 28);
            cboMakhachhang.TabIndex = 25;
            cboMakhachhang.SelectedIndexChanged += cboMakhachhang_SelectedIndexChanged;
            // 
            // cboMahopdong
            // 
            cboMahopdong.FormattingEnabled = true;
            cboMahopdong.Location = new Point(192, 501);
            cboMahopdong.Name = "cboMahopdong";
            cboMahopdong.Size = new Size(199, 28);
            cboMahopdong.TabIndex = 26;
            // 
            // mskNgayky
            // 
            mskNgayky.Location = new Point(229, 108);
            mskNgayky.Mask = "00/00/0000";
            mskNgayky.Name = "mskNgayky";
            mskNgayky.Size = new Size(151, 27);
            mskNgayky.TabIndex = 27;
            mskNgayky.ValidatingType = typeof(DateTime);
            // 
            // mskDienthoai
            // 
            mskDienthoai.Location = new Point(791, 207);
            mskDienthoai.Mask = "(999) 000-0000";
            mskDienthoai.Name = "mskDienthoai";
            mskDienthoai.Size = new Size(151, 27);
            mskDienthoai.TabIndex = 28;
            // 
            // HopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources._094835hop_dong_lao_dong_vo_hieu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1046, 544);
            Controls.Add(mskDienthoai);
            Controls.Add(mskNgayky);
            Controls.Add(cboMahopdong);
            Controls.Add(cboMakhachhang);
            Controls.Add(cboManhanvien);
            Controls.Add(txtDiachi);
            Controls.Add(txtTenkhachhang);
            Controls.Add(txtTennhanvien);
            Controls.Add(txtMahopdong);
            Controls.Add(DataGridView);
            Controls.Add(btnDong);
            Controls.Add(btnXuathop);
            Controls.Add(btnTimkiem);
            Controls.Add(btnLammoi);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnHuyHD);
            Controls.Add(btnThemHDVietbai);
            Controls.Add(btnThemHDQuangcao);
            Controls.Add(label9);
            Controls.Add(lblDienthoai);
            Controls.Add(lblDiachi);
            Controls.Add(lblTenkhachhang);
            Controls.Add(lblMakhachhang);
            Controls.Add(lblTennhanvien);
            Controls.Add(lblManhanvien);
            Controls.Add(lblNgayky);
            Controls.Add(lblMahopdong);
            Controls.Add(lblHopDong);
            Name = "HopDong";
            Text = "Hợp Đồng";
            Load += HopDong_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHopDong;
        private Label lblMahopdong;
        private Label lblNgayky;
        private Label lblManhanvien;
        private Label lblTennhanvien;
        private Label lblMakhachhang;
        private Label lblTenkhachhang;
        private Label lblDiachi;
        private Label lblDienthoai;
        private Label label9;
        private Button btnThemHDQuangcao;
        private Button btnThemHDVietbai;
        private Button btnHuyHD;
        private Button btnSua;
        private Button btnLuu;
        private Button btnLammoi;
        private Button btnTimkiem;
        private Button btnXuathop;
        private Button btnDong;
        private DataGridView DataGridView;
        private TextBox txtMahopdong;
        private TextBox txtTennhanvien;
        private TextBox txtTenkhachhang;
        private TextBox txtDiachi;
        private ComboBox cboManhanvien;
        private ComboBox cboMakhachhang;
        private ComboBox cboMahopdong;
        private MaskedTextBox mskNgayky;
        private MaskedTextBox mskDienthoai;
    }
}