namespace QLHD_QC_VB.Forms
{
    partial class frmtimkiemkh
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
            lbllvhd = new Label();
            cbolvhd = new ComboBox();
            btntimkiem = new Button();
            DataGridView = new DataGridView();
            btntimlai = new Button();
            btndong = new Button();
            lblmakh = new Label();
            txtmakh = new TextBox();
            lbltenkh = new Label();
            txttenkh = new TextBox();
            lbldiachi = new Label();
            txtdiachi = new TextBox();
            lbltkkh = new Label();
            txtemail = new TextBox();
            lblemail = new Label();
            txtsdt = new TextBox();
            lblsdt = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbllvhd
            // 
            lbllvhd.Anchor = AnchorStyles.Top;
            lbllvhd.AutoSize = true;
            lbllvhd.Location = new Point(118, 238);
            lbllvhd.Name = "lbllvhd";
            lbllvhd.Size = new Size(139, 20);
            lbllvhd.TabIndex = 0;
            lbllvhd.Text = "Lĩnh vực hoạt động:";
            // 
            // cbolvhd
            // 
            cbolvhd.Anchor = AnchorStyles.Top;
            cbolvhd.FormattingEnabled = true;
            cbolvhd.Location = new Point(263, 238);
            cbolvhd.Name = "cbolvhd";
            cbolvhd.Size = new Size(221, 28);
            cbolvhd.TabIndex = 1;
            // 
            // btntimkiem
            // 
            btntimkiem.Anchor = AnchorStyles.Bottom;
            btntimkiem.Location = new Point(288, 564);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(94, 29);
            btntimkiem.TabIndex = 2;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // DataGridView
            // 
            DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(118, 283);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(874, 263);
            DataGridView.TabIndex = 3;
            // 
            // btntimlai
            // 
            btntimlai.Anchor = AnchorStyles.Bottom;
            btntimlai.Location = new Point(490, 564);
            btntimlai.Name = "btntimlai";
            btntimlai.Size = new Size(94, 29);
            btntimlai.TabIndex = 4;
            btntimlai.Text = "Tìm lại";
            btntimlai.UseVisualStyleBackColor = true;
            btntimlai.Click += btntimlai_Click;
            // 
            // btndong
            // 
            btndong.Anchor = AnchorStyles.Bottom;
            btndong.Location = new Point(700, 564);
            btndong.Name = "btndong";
            btndong.Size = new Size(94, 29);
            btndong.TabIndex = 5;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            btndong.Click += btndong_Click;
            // 
            // lblmakh
            // 
            lblmakh.Anchor = AnchorStyles.Top;
            lblmakh.AutoSize = true;
            lblmakh.Location = new Point(118, 89);
            lblmakh.Name = "lblmakh";
            lblmakh.Size = new Size(112, 20);
            lblmakh.TabIndex = 6;
            lblmakh.Text = "Mã khách hàng:";
            // 
            // txtmakh
            // 
            txtmakh.Anchor = AnchorStyles.Top;
            txtmakh.Location = new Point(263, 86);
            txtmakh.Name = "txtmakh";
            txtmakh.Size = new Size(221, 27);
            txtmakh.TabIndex = 7;
            // 
            // lbltenkh
            // 
            lbltenkh.Anchor = AnchorStyles.Top;
            lbltenkh.AutoSize = true;
            lbltenkh.Location = new Point(118, 138);
            lbltenkh.Name = "lbltenkh";
            lbltenkh.Size = new Size(114, 20);
            lbltenkh.TabIndex = 8;
            lbltenkh.Text = "Tên khách hàng:";
            // 
            // txttenkh
            // 
            txttenkh.Anchor = AnchorStyles.Top;
            txttenkh.Location = new Point(263, 138);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(221, 27);
            txttenkh.TabIndex = 9;
            txttenkh.KeyPress += txttenkh_KeyPress;
            // 
            // lbldiachi
            // 
            lbldiachi.Anchor = AnchorStyles.Top;
            lbldiachi.AutoSize = true;
            lbldiachi.Location = new Point(118, 184);
            lbldiachi.Name = "lbldiachi";
            lbldiachi.Size = new Size(58, 20);
            lbldiachi.TabIndex = 10;
            lbldiachi.Text = "Địa chỉ:";
            // 
            // txtdiachi
            // 
            txtdiachi.Anchor = AnchorStyles.Top;
            txtdiachi.Location = new Point(263, 184);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(221, 27);
            txtdiachi.TabIndex = 11;
            // 
            // lbltkkh
            // 
            lbltkkh.Anchor = AnchorStyles.Top;
            lbltkkh.AutoSize = true;
            lbltkkh.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltkkh.Location = new Point(408, 18);
            lbltkkh.Name = "lbltkkh";
            lbltkkh.Size = new Size(318, 38);
            lbltkkh.TabIndex = 12;
            lbltkkh.Text = "TÌM KIẾM KHÁCH HÀNG";
            // 
            // txtemail
            // 
            txtemail.Anchor = AnchorStyles.Top;
            txtemail.Location = new Point(727, 141);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(221, 27);
            txtemail.TabIndex = 16;
            // 
            // lblemail
            // 
            lblemail.Anchor = AnchorStyles.Top;
            lblemail.AutoSize = true;
            lblemail.Location = new Point(582, 141);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(49, 20);
            lblemail.TabIndex = 15;
            lblemail.Text = "Email:";
            // 
            // txtsdt
            // 
            txtsdt.Anchor = AnchorStyles.Top;
            txtsdt.Location = new Point(727, 89);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(221, 27);
            txtsdt.TabIndex = 14;
            txtsdt.KeyPress += txtsdt_KeyPress;
            // 
            // lblsdt
            // 
            lblsdt.Anchor = AnchorStyles.Top;
            lblsdt.AutoSize = true;
            lblsdt.Location = new Point(582, 92);
            lblsdt.Name = "lblsdt";
            lblsdt.Size = new Size(100, 20);
            lblsdt.TabIndex = 13;
            lblsdt.Text = "Số điện thoại:";
            // 
            // frmtimkiemkh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1087, 624);
            Controls.Add(txtemail);
            Controls.Add(lblemail);
            Controls.Add(txtsdt);
            Controls.Add(lblsdt);
            Controls.Add(lbltkkh);
            Controls.Add(txtdiachi);
            Controls.Add(lbldiachi);
            Controls.Add(txttenkh);
            Controls.Add(lbltenkh);
            Controls.Add(txtmakh);
            Controls.Add(lblmakh);
            Controls.Add(btndong);
            Controls.Add(btntimlai);
            Controls.Add(DataGridView);
            Controls.Add(btntimkiem);
            Controls.Add(cbolvhd);
            Controls.Add(lbllvhd);
            DoubleBuffered = true;
            Name = "frmtimkiemkh";
            Text = "Tìm kiếm khách hàng";
            Load += frmtimkiemkh_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllvhd;
        private ComboBox cbolvhd;
        private Button btntimkiem;
        private DataGridView DataGridView;
        private Button btntimlai;
        private Button btndong;
        private Label lblmakh;
        private TextBox txtmakh;
        private Label lbltenkh;
        private TextBox txttenkh;
        private Label lbldiachi;
        private TextBox txtdiachi;
        private Label lbltkkh;
        private TextBox txtemail;
        private Label lblemail;
        private TextBox txtsdt;
        private Label lblsdt;
    }
}