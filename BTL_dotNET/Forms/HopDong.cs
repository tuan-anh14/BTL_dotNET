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

        private void btnThemHDQuangcao_Click(object sender, EventArgs e)
        {
            btnThemHDQuangcao.Enabled = false;
            btnThemHDVietbai.Enabled = false;
            btnLammoi.Enabled = true;
            btnLuu.Enabled = true;
            resetvalues();
            btnSua.Enabled = false;
            btnHuyHD.Enabled = false;
            txtMahopdong.Text = Class.Functions.CreateKey("QC");
        }

        private void btnThemHDVietbai_Click(object sender, EventArgs e)
        {
            btnThemHDVietbai.Enabled = false;
            btnThemHDQuangcao.Enabled = false;
            btnLammoi.Enabled = true;
            btnLuu.Enabled = true;
            resetvalues();
            btnSua.Enabled = false;
            btnHuyHD.Enabled = false;
            txtMahopdong.Text = Class.Functions.CreateKey("VB");
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            btnLammoi.Enabled = false; //vô hiệu hóa nút làm mới
            resetvalues(); //gọi phương thức resetvalues() để làm mới giá trị trên form
            btnThemHDQuangcao.Enabled = true; //kích hoạt nút thêm hợp đồng quảng cáo
            btnThemHDVietbai.Enabled = true; //kích hoạt nút thêm hợp đồng viết bài
            btnLuu.Enabled = false; //vô hiệu hóa nút lưu
            btnSua.Enabled = false; //vô hiệu hóa nút sửa
            btnHuyHD.Enabled = false; //vô hiệu hóa nút hủy
            load_data(); //gọi phương thức load_data() để chạy lại dữ liệu
            btnXuathop.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (mskNgayky.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayky.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskNgayky.Text))
            {
                MessageBox.Show("Sai định dạng ngày ký, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayky.Focus();
                mskNgayky.Text = "";
                return;
            }
            if (cboManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboManhanvien.Focus();
                return;
            }
            if (cboMakhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMakhachhang.Focus();
                return;
            }
            string sql;
            if (txtMahopdong.Text.Substring(0, 2) == "VB") //kiểm tra tiền tố mã hợp đồng
            {
                sql = "insert into vietbai (mavb,manv,makh,ngayky) values ('" + txtMahopdong.Text + "','" +
                cboManhanvien.SelectedValue.ToString() + "','" +
                cboMakhachhang.SelectedValue.ToString() + "','" +
                Class.Functions.ConvertDate(mskNgayky.Text) + "')";
            }
            else
            {
                sql = "insert into quangcao (maqc,manv,makh,ngayky) values ('" + txtMahopdong.Text + "','" +
                cboManhanvien.SelectedValue.ToString() + "','" +
                cboMakhachhang.SelectedValue.ToString() + "','" +
                Class.Functions.ConvertDate(mskNgayky.Text) + "')";
            }
            Class.Functions.Runsql(sql); //gọi phương thức Runsql từ Class Functions để thực hiện lệnh sql
            load_data(); //gọi phương thức load_data() để chạy lại dữ liệu
            resetvalues(); //gọi phương thức resetvalues() để làm mới giá trị trên form
            btnLuu.Enabled = false; //vô hiệu hóa nút lưu
            btnThemHDVietbai.Enabled = true; //kích hoạt nút thêm hợp đồng viết bài
            btnThemHDQuangcao.Enabled = true; //kích hoạt nút thêm hợp đồng quảng cáo
            btnLammoi.Enabled = false; //vô hiệu hóa nút làm mới
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hợp đồng " + txtMahopdong.Text + " khỏi bảng?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql;
                if (txtMahopdong.Text.Substring(0, 2) == "VB") //kiểm tra tiền tố mã hợp đồng
                {
                    sql = "delete from vietbai where mavb ='" + txtMahopdong.Text + "'";
                }
                else
                {
                    sql = "delete from quangcao where maqc ='" + txtMahopdong.Text + "'";
                }
                Class.Functions.Runsqldel(sql); //gọi phương thức Runsqldel từ Class Functions để thực hiện lệnh sql
                load_data(); //gọi phương thức load_data() để chạy lại dữ liệu
                resetvalues(); //gọi phương thức resetvalues() để làm mới giá trị trên form
                btnSua.Enabled = false; //vô hiệu hóa nút sửa
                btnLammoi.Enabled = false; //vô hiệu hóa nút làm mới 
                btnXuathop.Enabled = false; //vô hiệu hóa nút xuất hợp đồng
                btnHuyHD.Enabled = false; //vô hiệu hóa nút hủy
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (mskNgayky.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayky.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskNgayky.Text))
            {
                MessageBox.Show("Sai định dạng ngày ký, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayky.Focus();
                mskNgayky.Text = "";
                return;
            }
            if (cboManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboManhanvien.Focus();
                return;
            }
            if (cboMakhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMakhachhang.Focus();
                return;
            }
            string sql;
            if (txtMahopdong.Text.Substring(0, 2) == "VB") //kiểm tra tiền tố mã hợp đồng
            {
                sql = "update vietbai set ngayky = '" + Class.Functions.ConvertDate(mskNgayky.Text)
                + "', manv ='" + cboManhanvien.SelectedValue
                + "', makh ='" + cboMakhachhang.SelectedValue + "' where mavb ='" + txtMahopdong.Text + "'";
            }
            else
            {
                sql = "update quangcao set ngayky = '" + Class.Functions.ConvertDate(mskNgayky.Text)
                + "', manv ='" + cboManhanvien.SelectedValue
                + "', makh ='" + cboMakhachhang.SelectedValue + "' where maqc ='" + txtMahopdong.Text + "'";
            }
            Class.Functions.Runsql(sql); //gọi phương thức Runsql từ Class Functions để thực hiện lệnh sql
            load_data(); //gọi phương thức load_data() để chạy lại dữ liệu
            resetvalues(); //gọi phương thức resetvalues() để làm mới giá trị trên form
            btnSua.Enabled = false; //vô hiệu hóa nút sửa
            btnHuyHD.Enabled = false; //vô hiệu hóa nút hủy
            btnXuathop.Enabled = false; //vô hiệu hóa nút xuất hợp đồng 
            btnLammoi.Enabled = false; //vô hiệu hóa nút làm mới
        }
    }
}
