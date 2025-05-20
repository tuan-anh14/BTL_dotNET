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
    public partial class HopDong : Form
    {
        public HopDong()
        {
            InitializeComponent();
        }

        DataTable tblhopdong;

        public void resetvalues()
        {
            txtMahopdong.Text = "";
            mskNgayky.Text = "";
            cboMakhachhang.Text = "";
            cboManhanvien.Text = "";
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            load_data();
            txtMahopdong.ReadOnly = true;
            txtTenkhachhang.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            txtTenkhachhang.ReadOnly = true;
            mskDienthoai.ReadOnly = true;
            txtTennhanvien.ReadOnly = true;
            Class.Functions.Fillcombo("select manv,tennv from nhanvien", cboManhanvien, "manv", "manv");
            cboManhanvien.SelectedIndex = -1;
            Class.Functions.Fillcombo("select makh,tenkh from khachhang", cboMakhachhang, "makh", "makh");
            cboMakhachhang.SelectedIndex = -1;
            btnSua.Enabled = false;
            btnHuyHD.Enabled = false;
            btnLuu.Enabled = false;
            btnLammoi.Enabled = false;
            btnXuathop.Enabled = false;
            Class.Functions.Fillcombo("select maqc as mahd ,ngayky from quangcao union select mavb as mahd,ngayky from vietbai", cboMahopdong, "mahd", "mahd");
            cboMahopdong.SelectedIndex = -1;
        }

        private void load_data()
        {
            string sql;
            if (cboMahopdong.Text == "")
            {
                sql = "select a.mavb as mahd,a.manv,a.makh,ngayky,coalesce(sum(nhuanbut),0) as tongtien from vietbai a full join chitietvietbai b on a.mavb=b.mavb " +
                    "group by a.mavb,a.manv,a.makh,ngayky " +
                    "union " +
                    "select a.maqc as mahd,manv,makh,ngayky,coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien " +
                    "from quangcao a full join chitietquangcao b on a.maqc=b.maqc " +
                    "group by a.maqc,manv,makh,ngayky";
            }
            else
            {
                sql = "select * from (" +
                    "select a.mavb as mahd,a.manv,a.makh,ngayky,coalesce(sum(nhuanbut),0) as tongtien " +
                    "from vietbai a full join chitietvietbai b on a.mavb=b.mavb " +
                    "group by a.mavb,a.manv,a.makh,ngayky " +
                    "union " +
                    "select a.maqc as mahd,manv,makh,ngayky,coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien " +
                    "from quangcao a full join chitietquangcao b on a.maqc=b.maqc " +
                    "group by a.maqc,manv,makh,ngayky ) a where mahd ='" + cboMahopdong.Text + "'";
            }
            tblhopdong = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblhopdong;
            DataGridView.Columns[0].HeaderText = "Mã hợp đồng";
            DataGridView.Columns[1].HeaderText = "Mã nhân viên";
            DataGridView.Columns[2].HeaderText = "Mã khách hàng";
            DataGridView.Columns[3].HeaderText = "Ngày ký";
            DataGridView.Columns[4].HeaderText = "Tổng tiền";
            DataGridView.Columns[0].Width = 170;
            DataGridView.Columns[1].Width = 153;
            DataGridView.Columns[2].Width = 153;
            DataGridView.Columns[3].Width = 125;
            DataGridView.Columns[4].Width = 135;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
