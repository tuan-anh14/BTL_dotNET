using System.Windows.Forms;
using System.Drawing;
namespace QLHD_QC_VB.Forms
{
    partial class frmbao : Form
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
            this.lbldmbao = new System.Windows.Forms.Label();
            this.lblmabao = new System.Windows.Forms.Label();
            this.lbltenbao = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lbldienthoai = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.dgvBao = new System.Windows.Forms.DataGridView();
            this.btnthemmoi = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.txttenbao = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtmabao = new System.Windows.Forms.TextBox();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBao)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldmbao
            // 
            this.lbldmbao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldmbao.AutoSize = true;
            this.lbldmbao.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmbao.Location = new System.Drawing.Point(304, 6);
            this.lbldmbao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldmbao.Name = "lbldmbao";
            this.lbldmbao.Size = new System.Drawing.Size(179, 30);
            this.lbldmbao.TabIndex = 0;
            this.lbldmbao.Text = "DANH MỤC BÁO";
            // 
            // lblmabao
            // 
            this.lblmabao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblmabao.AutoSize = true;
            this.lblmabao.Location = new System.Drawing.Point(56, 46);
            this.lblmabao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmabao.Name = "lblmabao";
            this.lblmabao.Size = new System.Drawing.Size(46, 13);
            this.lblmabao.TabIndex = 1;
            this.lblmabao.Text = "Mã báo:";
            // 
            // lbltenbao
            // 
            this.lbltenbao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltenbao.AutoSize = true;
            this.lbltenbao.Location = new System.Drawing.Point(56, 82);
            this.lbltenbao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltenbao.Name = "lbltenbao";
            this.lbltenbao.Size = new System.Drawing.Size(50, 13);
            this.lbltenbao.TabIndex = 2;
            this.lbltenbao.Text = "Tên báo:";
            // 
            // lbldiachi
            // 
            this.lbldiachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(56, 120);
            this.lbldiachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(43, 13);
            this.lbldiachi.TabIndex = 3;
            this.lbldiachi.Text = "Địa chỉ:";
            // 
            // lbldienthoai
            // 
            this.lbldienthoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldienthoai.AutoSize = true;
            this.lbldienthoai.Location = new System.Drawing.Point(418, 46);
            this.lbldienthoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldienthoai.Name = "lbldienthoai";
            this.lbldienthoai.Size = new System.Drawing.Size(58, 13);
            this.lbldienthoai.TabIndex = 4;
            this.lbldienthoai.Text = "Điện thoại:";
            // 
            // lblemail
            // 
            this.lblemail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(418, 82);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "Email:";
            // 
            // dgvBao
            // 
            this.dgvBao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBao.Location = new System.Drawing.Point(32, 146);
            this.dgvBao.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBao.Name = "dgvBao";
            this.dgvBao.RowHeadersWidth = 51;
            this.dgvBao.Size = new System.Drawing.Size(695, 191);
            this.dgvBao.TabIndex = 7;
            this.dgvBao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnthemmoi.Location = new System.Drawing.Point(55, 353);
            this.btnthemmoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(70, 19);
            this.btnthemmoi.TabIndex = 8;
            this.btnthemmoi.Text = "Thêm mới";
            this.btnthemmoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnthemmoi.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnsua.Location = new System.Drawing.Point(167, 353);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(70, 19);
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnxoa.Location = new System.Drawing.Point(286, 353);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(70, 19);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnluu.Location = new System.Drawing.Point(404, 353);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(70, 19);
            this.btnluu.TabIndex = 11;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btnlammoi
            // 
            this.btnlammoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnlammoi.Location = new System.Drawing.Point(519, 353);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(70, 19);
            this.btnlammoi.TabIndex = 12;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            // 
            // btndong
            // 
            this.btndong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btndong.Location = new System.Drawing.Point(631, 353);
            this.btndong.Margin = new System.Windows.Forms.Padding(2);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(70, 19);
            this.btndong.TabIndex = 13;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            // 
            // txttenbao
            // 
            this.txttenbao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txttenbao.Location = new System.Drawing.Point(106, 80);
            this.txttenbao.Margin = new System.Windows.Forms.Padding(2);
            this.txttenbao.Name = "txttenbao";
            this.txttenbao.Size = new System.Drawing.Size(232, 20);
            this.txttenbao.TabIndex = 14;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdiachi.Location = new System.Drawing.Point(106, 118);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(575, 20);
            this.txtdiachi.TabIndex = 15;
            // 
            // txtmabao
            // 
            this.txtmabao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtmabao.Location = new System.Drawing.Point(106, 44);
            this.txtmabao.Margin = new System.Windows.Forms.Padding(2);
            this.txtmabao.Name = "txtmabao";
            this.txtmabao.Size = new System.Drawing.Size(232, 20);
            this.txtmabao.TabIndex = 16;
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskdienthoai.Location = new System.Drawing.Point(482, 44);
            this.mskdienthoai.Margin = new System.Windows.Forms.Padding(2);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(200, 20);
            this.mskdienthoai.TabIndex = 17;
            // 
            // txtemail
            // 
            this.txtemail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtemail.Location = new System.Drawing.Point(482, 80);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 20);
            this.txtemail.TabIndex = 18;
            // 
            // frmbao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 386);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.mskdienthoai);
            this.Controls.Add(this.txtmabao);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttenbao);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthemmoi);
            this.Controls.Add(this.dgvBao);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbldienthoai);
            this.Controls.Add(this.lbldiachi);
            this.Controls.Add(this.lbltenbao);
            this.Controls.Add(this.lblmabao);
            this.Controls.Add(this.lbldmbao);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmbao";
            this.Text = "Danh mục Báo";
            this.Load += new System.EventHandler(this.frmbao_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbldmbao;
        private Label lblmabao;
        private Label lbltenbao;
        private Label lbldiachi;
        private Label lbldienthoai;
        private Label lblemail;
        private DataGridView dgvBao;
        private Button btnthemmoi;
        private Button btnsua;
        private Button btnxoa;
        private Button btnluu;
        private Button btnlammoi;
        private Button btndong;
        private TextBox txttenbao;
        private TextBox txtdiachi;
        private TextBox txtmabao;
        private MaskedTextBox mskdienthoai;
        private TextBox txtemail;
    }
}