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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtimkiemkh));
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
            lbllvhd.Location = new Point(133, 262);
            lbllvhd.Name = "lbllvhd";
            lbllvhd.Size = new Size(155, 22);
            lbllvhd.TabIndex = 0;
            lbllvhd.Text = "Lĩnh vực hoạt động:";
            // 
            // cbolvhd
            // 
            cbolvhd.Anchor = AnchorStyles.Top;
            cbolvhd.FormattingEnabled = true;
            cbolvhd.Location = new Point(296, 262);
            cbolvhd.Margin = new Padding(3, 4, 3, 4);
            cbolvhd.Name = "cbolvhd";
            cbolvhd.Size = new Size(248, 30);
            cbolvhd.TabIndex = 1;
            // 
            // btntimkiem
            // 
            btntimkiem.Anchor = AnchorStyles.Bottom;
            btntimkiem.Location = new Point(324, 620);
            btntimkiem.Margin = new Padding(3, 4, 3, 4);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(106, 32);
            btntimkiem.TabIndex = 2;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // DataGridView
            // 
            DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(133, 312);
            DataGridView.Margin = new Padding(3, 4, 3, 4);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(983, 290);
            DataGridView.TabIndex = 3;
            // 
            // btntimlai
            // 
            btntimlai.Anchor = AnchorStyles.Bottom;
            btntimlai.Location = new Point(551, 620);
            btntimlai.Margin = new Padding(3, 4, 3, 4);
            btntimlai.Name = "btntimlai";
            btntimlai.Size = new Size(106, 32);
            btntimlai.TabIndex = 4;
            btntimlai.Text = "Tìm lại";
            btntimlai.UseVisualStyleBackColor = true;
            btntimlai.Click += btntimlai_Click;
            // 
            // btndong
            // 
            btndong.Anchor = AnchorStyles.Bottom;
            btndong.Location = new Point(787, 620);
            btndong.Margin = new Padding(3, 4, 3, 4);
            btndong.Name = "btndong";
            btndong.Size = new Size(106, 32);
            btndong.TabIndex = 5;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            btndong.Click += btndong_Click;
            // 
            // lblmakh
            // 
            lblmakh.Anchor = AnchorStyles.Top;
            lblmakh.AutoSize = true;
            lblmakh.Location = new Point(133, 98);
            lblmakh.Name = "lblmakh";
            lblmakh.Size = new Size(125, 22);
            lblmakh.TabIndex = 6;
            lblmakh.Text = "Mã khách hàng:";
            // 
            // txtmakh
            // 
            txtmakh.Anchor = AnchorStyles.Top;
            txtmakh.Location = new Point(296, 95);
            txtmakh.Margin = new Padding(3, 4, 3, 4);
            txtmakh.Name = "txtmakh";
            txtmakh.Size = new Size(248, 29);
            txtmakh.TabIndex = 7;
            // 
            // lbltenkh
            // 
            lbltenkh.Anchor = AnchorStyles.Top;
            lbltenkh.AutoSize = true;
            lbltenkh.Location = new Point(133, 151);
            lbltenkh.Name = "lbltenkh";
            lbltenkh.Size = new Size(126, 22);
            lbltenkh.TabIndex = 8;
            lbltenkh.Text = "Tên khách hàng:";
            // 
            // txttenkh
            // 
            txttenkh.Anchor = AnchorStyles.Top;
            txttenkh.Location = new Point(296, 151);
            txttenkh.Margin = new Padding(3, 4, 3, 4);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(248, 29);
            txttenkh.TabIndex = 9;
            txttenkh.KeyPress += txttenkh_KeyPress;
            // 
            // lbldiachi
            // 
            lbldiachi.Anchor = AnchorStyles.Top;
            lbldiachi.AutoSize = true;
            lbldiachi.Location = new Point(133, 202);
            lbldiachi.Name = "lbldiachi";
            lbldiachi.Size = new Size(64, 22);
            lbldiachi.TabIndex = 10;
            lbldiachi.Text = "Địa chỉ:";
            // 
            // txtdiachi
            // 
            txtdiachi.Anchor = AnchorStyles.Top;
            txtdiachi.Location = new Point(296, 202);
            txtdiachi.Margin = new Padding(3, 4, 3, 4);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(248, 29);
            txtdiachi.TabIndex = 11;
            // 
            // lbltkkh
            // 
            lbltkkh.Anchor = AnchorStyles.Top;
            lbltkkh.AutoSize = true;
            lbltkkh.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltkkh.Location = new Point(459, 19);
            lbltkkh.Name = "lbltkkh";
            lbltkkh.Size = new Size(318, 38);
            lbltkkh.TabIndex = 12;
            lbltkkh.Text = "TÌM KIẾM KHÁCH HÀNG";
            // 
            // txtemail
            // 
            txtemail.Anchor = AnchorStyles.Top;
            txtemail.Location = new Point(818, 155);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(248, 29);
            txtemail.TabIndex = 16;
            // 
            // lblemail
            // 
            lblemail.Anchor = AnchorStyles.Top;
            lblemail.AutoSize = true;
            lblemail.Location = new Point(655, 155);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(55, 22);
            lblemail.TabIndex = 15;
            lblemail.Text = "Email:";
            // 
            // txtsdt
            // 
            txtsdt.Anchor = AnchorStyles.Top;
            txtsdt.Location = new Point(818, 98);
            txtsdt.Margin = new Padding(3, 4, 3, 4);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(248, 29);
            txtsdt.TabIndex = 14;
            txtsdt.KeyPress += txtsdt_KeyPress;
            // 
            // lblsdt
            // 
            lblsdt.Anchor = AnchorStyles.Top;
            lblsdt.AutoSize = true;
            lblsdt.Location = new Point(655, 101);
            lblsdt.Name = "lblsdt";
            lblsdt.Size = new Size(111, 22);
            lblsdt.TabIndex = 13;
            lblsdt.Text = "Số điện thoại:";
            // 
            // frmtimkiemkh
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1223, 686);
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
            Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
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