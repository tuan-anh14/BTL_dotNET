﻿namespace QLHD_QC_VB.Forms
{
    partial class frmhopdong
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
            btndong = new Button();
            btnxuathopdong = new Button();
            btnlammoi = new Button();
            btnluu = new Button();
            btnsua = new Button();
            btnhuy = new Button();
            btnthemhdqc = new Button();
            DataGridView = new DataGridView();
            mskdienthoai = new MaskedTextBox();
            txtdiachi = new TextBox();
            txttenkh = new TextBox();
            cbomakh = new ComboBox();
            lbldienthoai = new Label();
            lbldiachi = new Label();
            lbltenkh = new Label();
            lblmakh = new Label();
            txttennv = new TextBox();
            cbomanv = new ComboBox();
            mskngayky = new MaskedTextBox();
            txtmahd = new TextBox();
            lbltennv = new Label();
            lblmanv = new Label();
            lblngayky = new Label();
            lblHD = new Label();
            lblmaquangcao = new Label();
            btnthemhdvb = new Button();
            cbotkmahd = new ComboBox();
            btntimkiem = new Button();
            lbltkhd = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(141, 466);
            label1.Name = "label1";
            label1.Size = new Size(199, 17);
            label1.TabIndex = 77;
            label1.Text = "Kích đúp để xem chi tiết hợp đồng";
            // 
            // btndong
            // 
            btndong.Anchor = AnchorStyles.Bottom;
            btndong.Location = new Point(713, 533);
            btndong.Name = "btndong";
            btndong.Size = new Size(87, 29);
            btndong.TabIndex = 76;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            btndong.Click += btndong_Click;
            // 
            // btnxuathopdong
            // 
            btnxuathopdong.Anchor = AnchorStyles.Bottom;
            btnxuathopdong.Location = new Point(572, 533);
            btnxuathopdong.Name = "btnxuathopdong";
            btnxuathopdong.Size = new Size(123, 29);
            btnxuathopdong.TabIndex = 75;
            btnxuathopdong.Text = "Xuất hợp đồng";
            btnxuathopdong.UseVisualStyleBackColor = true;
            btnxuathopdong.Click += btnxuathopdong_Click;
            // 
            // btnlammoi
            // 
            btnlammoi.Anchor = AnchorStyles.Bottom;
            btnlammoi.Location = new Point(713, 493);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(87, 29);
            btnlammoi.TabIndex = 71;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // btnluu
            // 
            btnluu.Anchor = AnchorStyles.Bottom;
            btnluu.Location = new Point(625, 493);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(70, 29);
            btnluu.TabIndex = 70;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btnsua
            // 
            btnsua.Anchor = AnchorStyles.Bottom;
            btnsua.Location = new Point(536, 493);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(70, 29);
            btnsua.TabIndex = 69;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnhuy
            // 
            btnhuy.Anchor = AnchorStyles.Bottom;
            btnhuy.Location = new Point(394, 493);
            btnhuy.Name = "btnhuy";
            btnhuy.Size = new Size(123, 29);
            btnhuy.TabIndex = 68;
            btnhuy.Text = "Hủy hợp đồng";
            btnhuy.UseVisualStyleBackColor = true;
            btnhuy.Click += btnhuy_Click;
            // 
            // btnthemhdqc
            // 
            btnthemhdqc.Anchor = AnchorStyles.Bottom;
            btnthemhdqc.Location = new Point(62, 493);
            btnthemhdqc.Name = "btnthemhdqc";
            btnthemhdqc.Size = new Size(150, 29);
            btnthemhdqc.TabIndex = 67;
            btnthemhdqc.Text = "Thêm hợp đồng QC";
            btnthemhdqc.UseVisualStyleBackColor = true;
            btnthemhdqc.Click += btnthemhdqc_Click;
            // 
            // DataGridView
            // 
            DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(141, 237);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(563, 218);
            DataGridView.TabIndex = 66;
            DataGridView.Click += DataGridView_Click;
            DataGridView.DoubleClick += DataGridView_DoubleClick;
            // 
            // mskdienthoai
            // 
            mskdienthoai.Anchor = AnchorStyles.Top;
            mskdienthoai.Location = new Point(623, 194);
            mskdienthoai.Mask = "(999) 000-0000";
            mskdienthoai.Name = "mskdienthoai";
            mskdienthoai.Size = new Size(177, 27);
            mskdienthoai.TabIndex = 65;
            // 
            // txtdiachi
            // 
            txtdiachi.Anchor = AnchorStyles.Top;
            txtdiachi.Location = new Point(623, 151);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(177, 27);
            txtdiachi.TabIndex = 64;
            // 
            // txttenkh
            // 
            txttenkh.Anchor = AnchorStyles.Top;
            txttenkh.Location = new Point(623, 107);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(177, 27);
            txttenkh.TabIndex = 63;
            // 
            // cbomakh
            // 
            cbomakh.Anchor = AnchorStyles.Top;
            cbomakh.FormattingEnabled = true;
            cbomakh.Location = new Point(623, 64);
            cbomakh.Name = "cbomakh";
            cbomakh.Size = new Size(177, 28);
            cbomakh.TabIndex = 62;
            cbomakh.TextChanged += cbomakh_TextChanged;
            // 
            // lbldienthoai
            // 
            lbldienthoai.Anchor = AnchorStyles.Top;
            lbldienthoai.AutoSize = true;
            lbldienthoai.Location = new Point(505, 197);
            lbldienthoai.Name = "lbldienthoai";
            lbldienthoai.Size = new Size(81, 20);
            lbldienthoai.TabIndex = 61;
            lbldienthoai.Text = "Điện thoại:";
            // 
            // lbldiachi
            // 
            lbldiachi.Anchor = AnchorStyles.Top;
            lbldiachi.AutoSize = true;
            lbldiachi.Location = new Point(505, 154);
            lbldiachi.Name = "lbldiachi";
            lbldiachi.Size = new Size(58, 20);
            lbldiachi.TabIndex = 60;
            lbldiachi.Text = "Địa chỉ:";
            // 
            // lbltenkh
            // 
            lbltenkh.Anchor = AnchorStyles.Top;
            lbltenkh.AutoSize = true;
            lbltenkh.Location = new Point(505, 110);
            lbltenkh.Name = "lbltenkh";
            lbltenkh.Size = new Size(114, 20);
            lbltenkh.TabIndex = 59;
            lbltenkh.Text = "Tên khách hàng:";
            // 
            // lblmakh
            // 
            lblmakh.Anchor = AnchorStyles.Top;
            lblmakh.AutoSize = true;
            lblmakh.Location = new Point(505, 67);
            lblmakh.Name = "lblmakh";
            lblmakh.Size = new Size(112, 20);
            lblmakh.TabIndex = 58;
            lblmakh.Text = "Mã khách hàng:";
            // 
            // txttennv
            // 
            txttennv.Anchor = AnchorStyles.Top;
            txttennv.Location = new Point(176, 194);
            txttennv.Name = "txttennv";
            txttennv.Size = new Size(183, 27);
            txttennv.TabIndex = 57;
            // 
            // cbomanv
            // 
            cbomanv.Anchor = AnchorStyles.Top;
            cbomanv.FormattingEnabled = true;
            cbomanv.Location = new Point(176, 151);
            cbomanv.Name = "cbomanv";
            cbomanv.Size = new Size(183, 28);
            cbomanv.TabIndex = 56;
            cbomanv.TextChanged += cbomanv_TextChanged;
            // 
            // mskngayky
            // 
            mskngayky.Anchor = AnchorStyles.Top;
            mskngayky.Location = new Point(176, 107);
            mskngayky.Mask = "00/00/0000";
            mskngayky.Name = "mskngayky";
            mskngayky.Size = new Size(183, 27);
            mskngayky.TabIndex = 55;
            mskngayky.ValidatingType = typeof(DateTime);
            // 
            // txtmahd
            // 
            txtmahd.Anchor = AnchorStyles.Top;
            txtmahd.Location = new Point(176, 64);
            txtmahd.Name = "txtmahd";
            txtmahd.Size = new Size(183, 27);
            txtmahd.TabIndex = 54;
            // 
            // lbltennv
            // 
            lbltennv.Anchor = AnchorStyles.Top;
            lbltennv.AutoSize = true;
            lbltennv.Location = new Point(62, 197);
            lbltennv.Name = "lbltennv";
            lbltennv.Size = new Size(102, 20);
            lbltennv.TabIndex = 53;
            lbltennv.Text = "Tên nhân viên:";
            // 
            // lblmanv
            // 
            lblmanv.Anchor = AnchorStyles.Top;
            lblmanv.AutoSize = true;
            lblmanv.Location = new Point(62, 154);
            lblmanv.Name = "lblmanv";
            lblmanv.Size = new Size(100, 20);
            lblmanv.TabIndex = 52;
            lblmanv.Text = "Mã nhân viên:";
            // 
            // lblngayky
            // 
            lblngayky.Anchor = AnchorStyles.Top;
            lblngayky.AutoSize = true;
            lblngayky.Location = new Point(62, 110);
            lblngayky.Name = "lblngayky";
            lblngayky.Size = new Size(65, 20);
            lblngayky.TabIndex = 51;
            lblngayky.Text = "Ngày ký:";
            // 
            // lblHD
            // 
            lblHD.Anchor = AnchorStyles.Top;
            lblHD.AutoSize = true;
            lblHD.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHD.Location = new Point(267, 9);
            lblHD.Name = "lblHD";
            lblHD.Size = new Size(319, 38);
            lblHD.TabIndex = 50;
            lblHD.Text = "DANH MỤC HỢP ĐỒNG";
            // 
            // lblmaquangcao
            // 
            lblmaquangcao.Anchor = AnchorStyles.Top;
            lblmaquangcao.AutoSize = true;
            lblmaquangcao.Location = new Point(62, 67);
            lblmaquangcao.Name = "lblmaquangcao";
            lblmaquangcao.Size = new Size(102, 20);
            lblmaquangcao.TabIndex = 49;
            lblmaquangcao.Text = "Mã hợp đồng:";
            // 
            // btnthemhdvb
            // 
            btnthemhdvb.Anchor = AnchorStyles.Bottom;
            btnthemhdvb.Location = new Point(227, 493);
            btnthemhdvb.Name = "btnthemhdvb";
            btnthemhdvb.Size = new Size(150, 29);
            btnthemhdvb.TabIndex = 78;
            btnthemhdvb.Text = "Thêm hợp đồng VB";
            btnthemhdvb.UseVisualStyleBackColor = true;
            btnthemhdvb.Click += btnthemhdvb_Click;
            // 
            // cbotkmahd
            // 
            cbotkmahd.Anchor = AnchorStyles.Bottom;
            cbotkmahd.FormattingEnabled = true;
            cbotkmahd.Location = new Point(133, 535);
            cbotkmahd.Name = "cbotkmahd";
            cbotkmahd.Size = new Size(177, 28);
            cbotkmahd.TabIndex = 79;
            // 
            // btntimkiem
            // 
            btntimkiem.Anchor = AnchorStyles.Bottom;
            btntimkiem.Location = new Point(316, 534);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(87, 29);
            btntimkiem.TabIndex = 80;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // lbltkhd
            // 
            lbltkhd.Anchor = AnchorStyles.Bottom;
            lbltkhd.AutoSize = true;
            lbltkhd.Location = new Point(25, 538);
            lbltkhd.Name = "lbltkhd";
            lbltkhd.Size = new Size(102, 20);
            lbltkhd.TabIndex = 81;
            lbltkhd.Text = "Mã hợp đồng:";
            // 
            // frmhopdong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 584);
            Controls.Add(lbltkhd);
            Controls.Add(btntimkiem);
            Controls.Add(cbotkmahd);
            Controls.Add(btnthemhdvb);
            Controls.Add(label1);
            Controls.Add(btndong);
            Controls.Add(btnxuathopdong);
            Controls.Add(btnlammoi);
            Controls.Add(btnluu);
            Controls.Add(btnsua);
            Controls.Add(btnhuy);
            Controls.Add(btnthemhdqc);
            Controls.Add(DataGridView);
            Controls.Add(mskdienthoai);
            Controls.Add(txtdiachi);
            Controls.Add(txttenkh);
            Controls.Add(cbomakh);
            Controls.Add(lbldienthoai);
            Controls.Add(lbldiachi);
            Controls.Add(lbltenkh);
            Controls.Add(lblmakh);
            Controls.Add(txttennv);
            Controls.Add(cbomanv);
            Controls.Add(mskngayky);
            Controls.Add(txtmahd);
            Controls.Add(lbltennv);
            Controls.Add(lblmanv);
            Controls.Add(lblngayky);
            Controls.Add(lblHD);
            Controls.Add(lblmaquangcao);
            Name = "frmhopdong";
            Text = "Hợp đồng";
            Load += Hopdong_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btndong;
        private Button btnxuathopdong;
        private Button btnlammoi;
        private Button btnluu;
        private Button btnsua;
        private Button btnhuy;
        private Button btnthemhdqc;
        private DataGridView DataGridView;
        private MaskedTextBox mskdienthoai;
        private TextBox txtdiachi;
        private TextBox txttenkh;
        private ComboBox cbomakh;
        private Label lbldienthoai;
        private Label lbldiachi;
        private Label lbltenkh;
        private Label lblmakh;
        private TextBox txttennv;
        private ComboBox cbomanv;
        private MaskedTextBox mskngayky;
        private TextBox txtmahd;
        private Label lbltennv;
        private Label lblmanv;
        private Label lblngayky;
        private Label lblHD;
        private Label lblmaquangcao;
        private Button btnthemhdvb;
        private ComboBox cbotkmahd;
        private Button btntimkiem;
        private Label lbltkhd;
    }
}