namespace BTL_dotNET.Forms
{
    partial class frmMainQL
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
            mnusQL = new MenuStrip();
            mnuQuanLy = new ToolStripMenuItem();
            mnuHopDong = new ToolStripMenuItem();
            mnuBaoCao = new ToolStripMenuItem();
            mnuTimKiem = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuBao = new ToolStripMenuItem();
            mnuTKKhachHang = new ToolStripMenuItem();
            mnuTKHopDong = new ToolStripMenuItem();
            mnuHDQuangCao = new ToolStripMenuItem();
            mnuHDVietBai = new ToolStripMenuItem();
            mnusQL.SuspendLayout();
            SuspendLayout();
            // 
            // mnusQL
            // 
            mnusQL.BackColor = Color.LightSteelBlue;
            mnusQL.BackgroundImageLayout = ImageLayout.Stretch;
            mnusQL.ImageScalingSize = new Size(20, 20);
            mnusQL.Items.AddRange(new ToolStripItem[] { mnuQuanLy, mnuHopDong, mnuBaoCao, mnuTimKiem, mnuThoat });
            mnusQL.Location = new Point(0, 0);
            mnusQL.Name = "mnusQL";
            mnusQL.Size = new Size(1160, 28);
            mnusQL.TabIndex = 0;
            mnusQL.Text = "menuStrip1";
            mnusQL.ItemClicked += this.mnusQL_ItemClicked;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuNhanVien, mnuKhachHang, mnuBao });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(73, 24);
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuHopDong
            // 
            mnuHopDong.DropDownItems.AddRange(new ToolStripItem[] { mnuHDQuangCao, mnuHDVietBai });
            mnuHopDong.Name = "mnuHopDong";
            mnuHopDong.Size = new Size(91, 24);
            mnuHopDong.Text = "Hợp đồng";
            // 
            // mnuBaoCao
            // 
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.Size = new Size(77, 24);
            mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuTimKiem
            // 
            mnuTimKiem.DropDownItems.AddRange(new ToolStripItem[] { mnuTKKhachHang, mnuTKHopDong });
            mnuTimKiem.Name = "mnuTimKiem";
            mnuTimKiem.Size = new Size(84, 24);
            mnuTimKiem.Text = "Tìm kiếm";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(61, 24);
            mnuThoat.Text = "Thoát";
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(224, 26);
            mnuNhanVien.Text = "Nhân viên";
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(224, 26);
            mnuKhachHang.Text = "Khách hàng";
            // 
            // mnuBao
            // 
            mnuBao.Name = "mnuBao";
            mnuBao.Size = new Size(224, 26);
            mnuBao.Text = "Báo";
            // 
            // mnuTKKhachHang
            // 
            mnuTKKhachHang.Name = "mnuTKKhachHang";
            mnuTKKhachHang.Size = new Size(224, 26);
            mnuTKKhachHang.Text = "Khách hàng";
            // 
            // mnuTKHopDong
            // 
            mnuTKHopDong.Name = "mnuTKHopDong";
            mnuTKHopDong.Size = new Size(224, 26);
            mnuTKHopDong.Text = "Hợp đồng";
            // 
            // mnuHDQuangCao
            // 
            mnuHDQuangCao.Name = "mnuHDQuangCao";
            mnuHDQuangCao.Size = new Size(282, 26);
            mnuHDQuangCao.Text = "Chi tiết hợp đồng quảng cáo";
            // 
            // mnuHDVietBai
            // 
            mnuHDVietBai.Name = "mnuHDVietBai";
            mnuHDVietBai.Size = new Size(282, 26);
            mnuHDVietBai.Text = "Chi tiết hợp đồng viết bài";
            // 
            // frmMainQL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.mot_so_bat_cap_trong_quy_dinh_ve_hop_dong_vi_loi_ich_cua_nguoi_thu_ba;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1160, 627);
            Controls.Add(mnusQL);
            MainMenuStrip = mnusQL;
            Name = "frmMainQL";
            Text = "Quản lý Hợp đồng Quảng cáo và Viết bài";
            Load += this.Main_Load;
            mnusQL.ResumeLayout(false);
            mnusQL.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnusQL;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuBao;
        private ToolStripMenuItem mnuHopDong;
        private ToolStripMenuItem mnuHDQuangCao;
        private ToolStripMenuItem mnuHDVietBai;
        private ToolStripMenuItem mnuBaoCao;
        private ToolStripMenuItem mnuTimKiem;
        private ToolStripMenuItem mnuTKKhachHang;
        private ToolStripMenuItem mnuTKHopDong;
        private ToolStripMenuItem mnuThoat;
    }
}