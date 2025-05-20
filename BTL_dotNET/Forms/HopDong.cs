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

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (tblhopdong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnThemHDQuangcao.Enabled == false || btnThemHDVietbai.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtMahopdong.Text = DataGridView.CurrentRow.Cells["mahd"].Value.ToString();
            mskNgayky.Text = Class.Functions.GetFieldValues("select ngayky from (select maqc as mahd ,ngayky from quangcao union select mavb as mahd,ngayky from vietbai) a" +
                " where mahd = '" + txtMahopdong.Text + "'");
            string manv, makh;
            manv = Class.Functions.GetFieldValues("select manv from (select maqc as mahd ,ngayky,manv,makh from quangcao union select mavb as mahd,ngayky,manv,makh from vietbai) a" +
                " where mahd = '" + txtMahopdong.Text + "'");
            cboManhanvien.Text = Class.Functions.GetFieldValues("select manv from nhanvien where manv = '" + manv + "'");
            makh = Class.Functions.GetFieldValues("select makh from (select maqc as mahd ,ngayky,manv,makh from quangcao union select mavb as mahd,ngayky,manv,makh from vietbai) a" +
                " where mahd = '" + txtMahopdong.Text + "'");
            cboMakhachhang.Text = Class.Functions.GetFieldValues("select makh from khachhang where makh = '" + makh + "'");
            btnSua.Enabled = true;
            btnHuyHD.Enabled = true;
            btnLammoi.Enabled = true;
            btnXuathop.Enabled = true;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            ChiTietHDVietBai a = new ChiTietHDVietBai(); //khởi tạo đối tượng ChiTietHDVietBai (chi tiết hợp đồng viết bài)
            ChiTietHDQuangCao b = new ChiTietHDQuangCao(); //khởi tạo đối tượng ChiTietHDQuangCao (chi tiết hợp đồng quảng cáo)
            if (txtMahopdong.Text.Substring(0, 2) == "VB") //kiểm tra tiền tố mã hợp đồng
            {
                a.GetValue(txtMahopdong.Text); //gọi phương thức GetValue từ ChiTietHDVietBai
                a.StartPosition = FormStartPosition.CenterScreen; //hiển thị form ở chính giữa màn hình
                a.ShowDialog(this);//hiển thị form a
            }
            else
            {
                b.GetValue(txtMahopdong.Text); //gọi phương thức GetValue từ ChiTietHDQuangCao
                b.StartPosition = FormStartPosition.CenterScreen; //hiển thị form ở chính giữa màn hình
                b.ShowDialog(this); //hiển thị form a
            }
        }

        private void cboManhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboManhanvien.Text == "")
            {
                txtTennhanvien.Text = "";
            }
            else
            {
                txtTennhanvien.Text = Class.Functions.GetFieldValues("select tennv from nhanvien where manv = '" + cboManhanvien.SelectedValue + "'");
            }
        }

        private void cboMakhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMakhachhang.Text == "")
            {
                txtTenkhachhang.Text = "";
                txtDiachi.Text = "";
                mskDienthoai.Text = "";
            }
            else
            {
                txtTenkhachhang.Text = Class.Functions.GetFieldValues("select tenkh from khachhang where makh = '" + cboMakhachhang.SelectedValue + "'");
                txtDiachi.Text = Class.Functions.GetFieldValues("Select diachi from khachhang where makh = '" + cboMakhachhang.SelectedValue + "'");
                mskDienthoai.Text = Class.Functions.GetFieldValues("select dienthoai from khachhang where makh = '" + cboMakhachhang.SelectedValue + "'");
            }
        }


    }
}
