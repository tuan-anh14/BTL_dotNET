using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
namespace QLHD_QC_VB.Forms
{
    partial class frmbaocaodt : Form
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
            this.lbltieudebaocao = new System.Windows.Forms.Label();
            this.lblbangchu = new System.Windows.Forms.Label();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.btninbaocao = new System.Windows.Forms.Button();
            this.cbotobao = new System.Windows.Forms.ComboBox();
            this.lbldichvu = new System.Windows.Forms.Label();
            this.lblbao = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.lbltheloai = new System.Windows.Forms.Label();
            this.cbodichvu = new System.Windows.Forms.ComboBox();
            this.cbotheloai = new System.Windows.Forms.ComboBox();
            this.rdotheongay = new System.Windows.Forms.RadioButton();
            this.msktheongay = new System.Windows.Forms.MaskedTextBox();
            this.rdotheokhoang = new System.Windows.Forms.RadioButton();
            this.lbltungay = new System.Windows.Forms.Label();
            this.grbtheokhoang = new System.Windows.Forms.GroupBox();
            this.msktoingay = new System.Windows.Forms.MaskedTextBox();
            this.lbltoingay = new System.Windows.Forms.Label();
            this.msktungay = new System.Windows.Forms.MaskedTextBox();
            this.lbldoanhthu = new System.Windows.Forms.Label();
            this.txtdoanhthu = new System.Windows.Forms.TextBox();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.chkquangcao = new System.Windows.Forms.CheckBox();
            this.chkvietbai = new System.Windows.Forms.CheckBox();
            this.chkbao = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.grbtheokhoang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltieudebaocao
            // 
            this.lbltieudebaocao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltieudebaocao.AutoSize = true;
            this.lbltieudebaocao.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieudebaocao.Location = new System.Drawing.Point(249, 6);
            this.lbltieudebaocao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltieudebaocao.Name = "lbltieudebaocao";
            this.lbltieudebaocao.Size = new System.Drawing.Size(243, 30);
            this.lbltieudebaocao.TabIndex = 1;
            this.lbltieudebaocao.Text = "BÁO CÁO DOANH THU";
            // 
            // lblbangchu
            // 
            this.lblbangchu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblbangchu.AutoSize = true;
            this.lblbangchu.Location = new System.Drawing.Point(90, 293);
            this.lblbangchu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbangchu.Name = "lblbangchu";
            this.lblbangchu.Size = new System.Drawing.Size(56, 13);
            this.lblbangchu.TabIndex = 2;
            this.lblbangchu.Text = "Bằng chữ:";
            // 
            // lbltongtien
            // 
            this.lbltongtien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Location = new System.Drawing.Point(463, 293);
            this.lbltongtien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(55, 13);
            this.lbltongtien.TabIndex = 3;
            this.lbltongtien.Text = "Tổng tiền:";
            // 
            // txttongtien
            // 
            this.txttongtien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txttongtien.Location = new System.Drawing.Point(524, 291);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(2);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(95, 20);
            this.txttongtien.TabIndex = 4;
            // 
            // btninbaocao
            // 
            this.btninbaocao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btninbaocao.Location = new System.Drawing.Point(466, 314);
            this.btninbaocao.Margin = new System.Windows.Forms.Padding(2);
            this.btninbaocao.Name = "btninbaocao";
            this.btninbaocao.Size = new System.Drawing.Size(70, 19);
            this.btninbaocao.TabIndex = 5;
            this.btninbaocao.Text = "In báo cáo";
            this.btninbaocao.UseVisualStyleBackColor = true;
            // 
            // cbotobao
            // 
            this.cbotobao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbotobao.FormattingEnabled = true;
            this.cbotobao.Location = new System.Drawing.Point(196, 40);
            this.cbotobao.Margin = new System.Windows.Forms.Padding(2);
            this.cbotobao.Name = "cbotobao";
            this.cbotobao.Size = new System.Drawing.Size(114, 21);
            this.cbotobao.TabIndex = 6;
            // 
            // lbldichvu
            // 
            this.lbldichvu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldichvu.AutoSize = true;
            this.lbldichvu.Location = new System.Drawing.Point(447, 43);
            this.lbldichvu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldichvu.Name = "lbldichvu";
            this.lbldichvu.Size = new System.Drawing.Size(47, 13);
            this.lbldichvu.TabIndex = 7;
            this.lbldichvu.Text = "Dịch vụ:";
            // 
            // lblbao
            // 
            this.lblbao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblbao.AutoSize = true;
            this.lblbao.Location = new System.Drawing.Point(148, 42);
            this.lblbao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbao.Name = "lblbao";
            this.lblbao.Size = new System.Drawing.Size(45, 13);
            this.lblbao.TabIndex = 8;
            this.lblbao.Text = "Tờ Báo:";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(133, 146);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.Size = new System.Drawing.Size(434, 137);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // lbltheloai
            // 
            this.lbltheloai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltheloai.AutoSize = true;
            this.lbltheloai.Location = new System.Drawing.Point(447, 81);
            this.lbltheloai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltheloai.Name = "lbltheloai";
            this.lbltheloai.Size = new System.Drawing.Size(48, 13);
            this.lbltheloai.TabIndex = 9;
            this.lbltheloai.Text = "Thể loại:";
            // 
            // cbodichvu
            // 
            this.cbodichvu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbodichvu.FormattingEnabled = true;
            this.cbodichvu.Location = new System.Drawing.Point(500, 41);
            this.cbodichvu.Margin = new System.Windows.Forms.Padding(2);
            this.cbodichvu.Name = "cbodichvu";
            this.cbodichvu.Size = new System.Drawing.Size(114, 21);
            this.cbodichvu.TabIndex = 10;
            // 
            // cbotheloai
            // 
            this.cbotheloai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbotheloai.FormattingEnabled = true;
            this.cbotheloai.Location = new System.Drawing.Point(500, 77);
            this.cbotheloai.Margin = new System.Windows.Forms.Padding(2);
            this.cbotheloai.Name = "cbotheloai";
            this.cbotheloai.Size = new System.Drawing.Size(114, 21);
            this.cbotheloai.TabIndex = 11;
            // 
            // rdotheongay
            // 
            this.rdotheongay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdotheongay.AutoSize = true;
            this.rdotheongay.Location = new System.Drawing.Point(90, 77);
            this.rdotheongay.Margin = new System.Windows.Forms.Padding(2);
            this.rdotheongay.Name = "rdotheongay";
            this.rdotheongay.Size = new System.Drawing.Size(76, 17);
            this.rdotheongay.TabIndex = 14;
            this.rdotheongay.TabStop = true;
            this.rdotheongay.Text = "Theo ngày";
            this.rdotheongay.UseVisualStyleBackColor = true;
            // 
            // msktheongay
            // 
            this.msktheongay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.msktheongay.Location = new System.Drawing.Point(182, 77);
            this.msktheongay.Margin = new System.Windows.Forms.Padding(2);
            this.msktheongay.Mask = "00/00/0000";
            this.msktheongay.Name = "msktheongay";
            this.msktheongay.Size = new System.Drawing.Size(129, 20);
            this.msktheongay.TabIndex = 15;
            this.msktheongay.ValidatingType = typeof(void);
            // 
            // rdotheokhoang
            // 
            this.rdotheokhoang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdotheokhoang.AutoSize = true;
            this.rdotheokhoang.Location = new System.Drawing.Point(90, 114);
            this.rdotheokhoang.Margin = new System.Windows.Forms.Padding(2);
            this.rdotheokhoang.Name = "rdotheokhoang";
            this.rdotheokhoang.Size = new System.Drawing.Size(89, 17);
            this.rdotheokhoang.TabIndex = 16;
            this.rdotheokhoang.TabStop = true;
            this.rdotheokhoang.Text = "Theo khoảng";
            this.rdotheokhoang.UseVisualStyleBackColor = true;
            // 
            // lbltungay
            // 
            this.lbltungay.AutoSize = true;
            this.lbltungay.Location = new System.Drawing.Point(8, 14);
            this.lbltungay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltungay.Name = "lbltungay";
            this.lbltungay.Size = new System.Drawing.Size(23, 13);
            this.lbltungay.TabIndex = 17;
            this.lbltungay.Text = "Từ:";
            // 
            // grbtheokhoang
            // 
            this.grbtheokhoang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbtheokhoang.Controls.Add(this.msktoingay);
            this.grbtheokhoang.Controls.Add(this.lbltoingay);
            this.grbtheokhoang.Controls.Add(this.msktungay);
            this.grbtheokhoang.Controls.Add(this.lbltungay);
            this.grbtheokhoang.Location = new System.Drawing.Point(182, 102);
            this.grbtheokhoang.Margin = new System.Windows.Forms.Padding(2);
            this.grbtheokhoang.Name = "grbtheokhoang";
            this.grbtheokhoang.Padding = new System.Windows.Forms.Padding(2);
            this.grbtheokhoang.Size = new System.Drawing.Size(274, 35);
            this.grbtheokhoang.TabIndex = 18;
            this.grbtheokhoang.TabStop = false;
            // 
            // msktoingay
            // 
            this.msktoingay.Location = new System.Drawing.Point(174, 10);
            this.msktoingay.Margin = new System.Windows.Forms.Padding(2);
            this.msktoingay.Mask = "00/00/0000";
            this.msktoingay.Name = "msktoingay";
            this.msktoingay.Size = new System.Drawing.Size(95, 20);
            this.msktoingay.TabIndex = 21;
            this.msktoingay.ValidatingType = typeof(void);
            // 
            // lbltoingay
            // 
            this.lbltoingay.AutoSize = true;
            this.lbltoingay.Location = new System.Drawing.Point(145, 12);
            this.lbltoingay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltoingay.Name = "lbltoingay";
            this.lbltoingay.Size = new System.Drawing.Size(25, 13);
            this.lbltoingay.TabIndex = 20;
            this.lbltoingay.Text = "Tới:";
            // 
            // msktungay
            // 
            this.msktungay.Location = new System.Drawing.Point(34, 12);
            this.msktungay.Margin = new System.Windows.Forms.Padding(2);
            this.msktungay.Mask = "00/00/0000";
            this.msktungay.Name = "msktungay";
            this.msktungay.Size = new System.Drawing.Size(95, 20);
            this.msktungay.TabIndex = 19;
            this.msktungay.ValidatingType = typeof(void);
            // 
            // lbldoanhthu
            // 
            this.lbldoanhthu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldoanhthu.AutoSize = true;
            this.lbldoanhthu.Location = new System.Drawing.Point(460, 116);
            this.lbldoanhthu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldoanhthu.Name = "lbldoanhthu";
            this.lbldoanhthu.Size = new System.Drawing.Size(69, 13);
            this.lbldoanhthu.TabIndex = 19;
            this.lbldoanhthu.Text = "Doanh thu ≥:";
            // 
            // txtdoanhthu
            // 
            this.txtdoanhthu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdoanhthu.Location = new System.Drawing.Point(532, 112);
            this.txtdoanhthu.Margin = new System.Windows.Forms.Padding(2);
            this.txtdoanhthu.Name = "txtdoanhthu";
            this.txtdoanhthu.Size = new System.Drawing.Size(83, 20);
            this.txtdoanhthu.TabIndex = 20;
            // 
            // btnhienthi
            // 
            this.btnhienthi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnhienthi.Location = new System.Drawing.Point(384, 314);
            this.btnhienthi.Margin = new System.Windows.Forms.Padding(2);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(70, 19);
            this.btnhienthi.TabIndex = 21;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            // 
            // btnlammoi
            // 
            this.btnlammoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnlammoi.Location = new System.Drawing.Point(302, 314);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(70, 19);
            this.btnlammoi.TabIndex = 22;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            // 
            // btndong
            // 
            this.btndong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btndong.Location = new System.Drawing.Point(547, 314);
            this.btndong.Margin = new System.Windows.Forms.Padding(2);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(70, 19);
            this.btndong.TabIndex = 23;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            // 
            // chkquangcao
            // 
            this.chkquangcao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkquangcao.AutoSize = true;
            this.chkquangcao.Location = new System.Drawing.Point(346, 42);
            this.chkquangcao.Margin = new System.Windows.Forms.Padding(2);
            this.chkquangcao.Name = "chkquangcao";
            this.chkquangcao.Size = new System.Drawing.Size(79, 17);
            this.chkquangcao.TabIndex = 24;
            this.chkquangcao.Text = "Quảng cáo";
            this.chkquangcao.UseVisualStyleBackColor = true;
            // 
            // chkvietbai
            // 
            this.chkvietbai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkvietbai.AutoSize = true;
            this.chkvietbai.Location = new System.Drawing.Point(346, 80);
            this.chkvietbai.Margin = new System.Windows.Forms.Padding(2);
            this.chkvietbai.Name = "chkvietbai";
            this.chkvietbai.Size = new System.Drawing.Size(61, 17);
            this.chkvietbai.TabIndex = 25;
            this.chkvietbai.Text = "Viết bài";
            this.chkvietbai.UseVisualStyleBackColor = true;
            // 
            // chkbao
            // 
            this.chkbao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkbao.AutoSize = true;
            this.chkbao.Location = new System.Drawing.Point(90, 41);
            this.chkbao.Margin = new System.Windows.Forms.Padding(2);
            this.chkbao.Name = "chkbao";
            this.chkbao.Size = new System.Drawing.Size(45, 17);
            this.chkbao.TabIndex = 26;
            this.chkbao.Text = "Báo";
            this.chkbao.UseVisualStyleBackColor = true;
            // 
            // frmbaocaodt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 341);
            this.Controls.Add(this.chkbao);
            this.Controls.Add(this.chkvietbai);
            this.Controls.Add(this.chkquangcao);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.txtdoanhthu);
            this.Controls.Add(this.lbldoanhthu);
            this.Controls.Add(this.grbtheokhoang);
            this.Controls.Add(this.rdotheokhoang);
            this.Controls.Add(this.msktheongay);
            this.Controls.Add(this.rdotheongay);
            this.Controls.Add(this.cbotheloai);
            this.Controls.Add(this.cbodichvu);
            this.Controls.Add(this.lbltheloai);
            this.Controls.Add(this.lblbao);
            this.Controls.Add(this.lbldichvu);
            this.Controls.Add(this.cbotobao);
            this.Controls.Add(this.btninbaocao);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.lbltongtien);
            this.Controls.Add(this.lblbangchu);
            this.Controls.Add(this.lbltieudebaocao);
            this.Controls.Add(this.DataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmbaocaodt";
            this.Text = "Báo cáo doanh thu";
            this.Load += new System.EventHandler(this.frmbaocaodt_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.grbtheokhoang.ResumeLayout(false);
            this.grbtheokhoang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbltieudebaocao;
        private Label lblbangchu;
        private Label lbltongtien;
        private TextBox txttongtien;
        private Button btninbaocao;
        private ComboBox cbotobao;
        private Label lbldichvu;
        private Label lblbao;
        private DataGridView DataGridView;
        private Label lbltheloai;
        private ComboBox cbodichvu;
        private ComboBox cbotheloai;
        private RadioButton rdotheongay;
        private MaskedTextBox msktheongay;
        private RadioButton rdotheokhoang;
        private Label lbltungay;
        private GroupBox grbtheokhoang;
        private MaskedTextBox msktungay;
        private MaskedTextBox msktoingay;
        private Label lbltoingay;
        private Label lbldoanhthu;
        private TextBox txtdoanhthu;
        private Button btnhienthi;
        private Button btnlammoi;
        private Button btndong;
        private CheckBox chkquangcao;
        private CheckBox chkvietbai;
        private CheckBox chkbao;
    }
}