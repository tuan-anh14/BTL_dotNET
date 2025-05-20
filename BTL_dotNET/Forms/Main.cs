using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_dotNET.Forms
{
    public partial class frmMainQL : Form
    {
        public frmMainQL()
        {
            InitializeComponent();
        }

        private void frmMainQL_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void mnuHopDong_Click(object sender, EventArgs e)
        {

            HopDong a = new HopDong();
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            a.TopLevel = false;
            a.TopMost = true;
            pnlcontent.Controls.Clear();
            pnlcontent.Controls.Add(a);
            a.Show();
        }

        private void mnuCTHDQuangcao_Click(object sender, EventArgs e)
        {
            ChiTietHDQuangCao a = new ChiTietHDQuangCao();
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            a.TopLevel = false;
            a.TopMost = true;
            pnlcontent.Controls.Clear();
            pnlcontent.Controls.Add(a);
            a.Show();
        }
    }
}
