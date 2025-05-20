using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

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
            btnXuathopdong.Enabled = false;
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
            btnXuathopdong.Enabled = true;
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
            btnXuathopdong.Enabled = false;
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
                btnXuathopdong.Enabled = false; //vô hiệu hóa nút xuất hợp đồng
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
            btnXuathopdong.Enabled = false; //vô hiệu hóa nút xuất hợp đồng 
            btnLammoi.Enabled = false; //vô hiệu hóa nút làm mới
        }

        private void btnXuathopdong_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select tongtien from (select coalesce(sum(nhuanbut),0) as tongtien,a.mavb as mahd from vietbai a full join chitietvietbai b on a.mavb=b.mavb group by a.mavb " +
                "union " +
                "select coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien, a.maqc as mahd " +
                "from quangcao a full join chitietquangcao b on a.maqc=b.maqc group by a.maqc) a where mahd='" + txtMahopdong.Text + "'";
            if (Class.Functions.GetFieldValues(sql) == "0")
            {
                MessageBox.Show("Hợp đồng chưa có nội dung, hãy ấn đúp vào hợp đồng " + txtMahopdong.Text + " để thêm nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            int row = 0, col = 0;
            DataTable tblhd, tblctqc, tblctvb;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = (COMExcel.Worksheet)exBook.Worksheets[1];
            exRange = (COMExcel.Range)exSheet.Cells[1, 1];

            exRange.Range["A1:H1"].MergeCells = true;
            exRange.Range["A1:H1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:H1"].Value = "Cộng hòa xã hội chủ nghĩa Việt Nam";

            exRange.Range["A2:H2"].MergeCells = true;
            exRange.Range["A2:H2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:H2"].Value = "Độc lập - Tự do - Hạnh phúc";

            exRange.Range["A3:H3"].MergeCells = true;
            exRange.Range["A3:H3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:H3"].Value = "------------------------------------------";

            exRange.Range["A7:H7"].MergeCells = true;
            exRange.Range["A7:H7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            if (txtMahopdong.Text.Substring(0, 2) == "VB")
            {
                exRange.Range["A7:H7"].Value = "HỢP ĐỒNG VIẾT BÀI";
            }
            else
            {
                exRange.Range["A7:H7"].Value = "HỢP ĐỒNG QUẢNG CÁO";
            }

            sql = "select * from (" +
                "select a.mavb as mahd,chucvu,c.dienthoai,ngayky,coalesce(sum(nhuanbut),0) as tongtien " +
                "from vietbai a full join chitietvietbai b on a.mavb=b.mavb join nhanvien c on c.manv = a.manv join chucvu d on d.macv = c.macv " +
                "group by a.mavb,a.manv,makh,ngayky,tennv,chucvu,c.dienthoai " +
                "union " +
                "select a.maqc as mahd,chucvu,c.dienthoai,ngayky,coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien " +
                "from quangcao a full join chitietquangcao b on a.maqc=b.maqc join nhanvien c on c.manv = a.manv join chucvu d on d.macv = c.macv " +
                "group by a.maqc,a.manv,makh,ngayky,tennv,chucvu,c.dienthoai) a where mahd ='" + txtMahopdong.Text + "'";
            tblhd = Class.Functions.GetDataToTable(sql);
            exRange.Range["A8:H8"].MergeCells = true;
            exRange.Range["A8:H8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A8:H8"].Value = "Số: " + tblhd.Rows[0][0].ToString();

            exRange.Range["A9:H9"].MergeCells = true;
            exRange.Range["A9:H9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A9:H9"].Value = "Căn cứ Bộ Luật Dân Sự được Quốc hội nước Cộng hòa xã hội chủ nghĩa Việt Nam thông qua ngày 24 tháng 11 năm 2015";
            exRange.Range["A9:H9"].WrapText = true;

            exRange.Range["A10:H10"].MergeCells = true;
            exRange.Range["A10:H10"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A10:H10"].Value = "Căn cứ Luật Thương mại 2015";

            exRange.Range["A11:H11"].MergeCells = true;
            exRange.Range["A11:H11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A11:H11"].Value = "Căn cứ Luật Quảng cáo 2012";

            exRange.Range["A12:H12"].MergeCells = true;
            exRange.Range["A12:H12"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A12:H12"].Value = "Căn cứ nhu cầu và khả năng của hai bên:";

            exRange.Range["A13:H13"].MergeCells = true;
            exRange.Range["A13:H13"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            DateTime d = Convert.ToDateTime(tblhd.Rows[0][3].ToString());
            exRange.Range["A13:H13"].Value = "Hôm nay, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;

            exRange.Range["A14:H14"].MergeCells = true;
            exRange.Range["A14:H14"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A14:H14"].Value = "BÊN A:";
            exRange.Range["A14:H14"].Font.Bold = true;

            exRange.Range["A15:H15"].MergeCells = true;
            exRange.Range["A15:H15"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A15:H15"].Value = "Ông/bà: " + txtTenkhachhang.Text;

            exRange.Range["A16:H16"].MergeCells = true;
            exRange.Range["A16:H16"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A16:H16"].Value = "Địa chỉ: " + txtDiachi.Text;

            exRange.Range["A17:H17"].MergeCells = true;
            exRange.Range["A17:H17"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A17:H17"].Value = "Số điện thoại: " + mskDienthoai.Text;

            exRange.Range["A18:H18"].MergeCells = true;
            exRange.Range["A18:H18"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A18:H18"].Value = "BÊN B:";
            exRange.Range["A18:H18"].Font.Bold = true;

            exRange.Range["A19:H19"].MergeCells = true;
            exRange.Range["A19:H19"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A19:H19"].Value = "Ông/bà: " + txtTennhanvien.Text;

            exRange.Range["A20:H20"].MergeCells = true;
            exRange.Range["A20:H20"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A20:H20"].Value = "Số điện thoại: " + tblhd.Rows[0][2];

            exRange.Range["A21:H21"].MergeCells = true;
            exRange.Range["A21:H21"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A21:H21"].Value = "Chức vụ: " + tblhd.Rows[0][1];

            exRange.Range["A22:H22"].MergeCells = true;
            exRange.Range["A22:H22"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A22:H22"].Value = "Sau khi bàn bạc, thỏa thuận các bên thống nhất các nội dung sau:";

            exRange.Range["A25:H25"].MergeCells = true;
            exRange.Range["A25:H25"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A25:H25"].Value = "Bên A chịu trách nhiệm đưa ra ý tưởng kịch bản và các thông tin cần viết bài cho Bên B";

            exRange.Range["A26:H26"].MergeCells = true;
            exRange.Range["A26:H26"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A26:H26"].Value = "Bên B chịu trách nhiệm đưa thông tin của Bên A dưới hình thức viết bài:";

            exRange.Range["A27:H27"].Font.Bold = true;
            exRange.Range["A27:H27"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D27:H27"].ColumnWidth = 12;
            if (txtMahopdong.Text.Substring(0, 2) == "VB")
            {
                sql = "select mabao,matheloai,tieude,noidung,ngaydang,nhuanbut from chitietvietbai where mavb = '" + txtMahopdong.Text + "'";
                tblctvb = Class.Functions.GetDataToTable(sql);
                exRange.Range["A27:A27"].Value = "STT";
                exRange.Range["B27:B27"].Value = "Báo";
                exRange.Range["C27:C27"].Value = "Thể loại";
                exRange.Range["D27:D27"].Value = "Tiêu đề";
                exRange.Range["E27:E27"].Value = "Nội dung";
                exRange.Range["F27:F27"].Value = "Ngày đăng";
                exRange.Range["G27:G27"].Value = "Nhuận bút";
                for (row = 0; row <= tblctvb.Rows.Count - 1; row++)
                {
                    exSheet.Cells[row + 28, 1] = row + 1; //điền số thứ tự vào ô đầu tiên trong mỗi hàng
                    for (col = 0; col <= tblctvb.Columns.Count - 1; col++)
                    {
                        if (tblctvb.Columns[col].ColumnName == "ngaydang")
                        {
                            exSheet.Cells[row + 28, col + 2] = Convert.ToDateTime(tblctvb.Rows[row]["ngaydang"]);
                        }
                        else
                        {
                            exSheet.Cells[row + 28, col + 2] = tblctvb.Rows[row][col].ToString();
                        }
                    }
                }
            }
            else
            {
                sql = "select madv,mabao,ngaybd,ngaykt,dongia,(dongia * abs(datediff(day,ngaykt,ngaybd))) as thanhtien,noidung from chitietquangcao where maqc = '" + txtMahopdong.Text + "'";
                tblctqc = Class.Functions.GetDataToTable(sql);
                exRange.Range["A27:A27"].Value = "STT";
                exRange.Range["B27:B27"].Value = "Dịch vụ";
                exRange.Range["C27:C27"].Value = "Báo";
                exRange.Range["D27:D27"].Value = "Ngày bắt đầu";
                exRange.Range["E27:E27"].Value = "Ngày kết thúc ";
                exRange.Range["F27:F27"].Value = "Đơn giá";
                exRange.Range["G27:G27"].Value = "Thành tiền";
                exRange.Range["H27:H27"].Value = "Nội dung";
                for (row = 0; row <= tblctqc.Rows.Count - 1; row++)
                {
                    exSheet.Cells[row + 28, 1] = row + 1; //điền số thứ tự vào ô đầu tiên trong mỗi hàng
                    for (col = 0; col <= tblctqc.Columns.Count - 1; col++)
                    {
                        if (tblctqc.Columns[col].ColumnName == "ngaybd")
                        {
                            exSheet.Cells[row + 28, col + 2] = Convert.ToDateTime(tblctqc.Rows[row]["ngaybd"]);
                        }
                        else if (tblctqc.Columns[col].ColumnName == "ngaykt")
                        {
                            exSheet.Cells[row + 28, col + 2] = Convert.ToDateTime(tblctqc.Rows[row]["ngaykt"]);
                        }
                        else
                        {
                            exSheet.Cells[row + 28, col + 2] = tblctqc.Rows[row][col].ToString();
                        }
                    }
                }
            }

            exRange = (COMExcel.Range)exSheet.Cells[row + 29, 1];
            exRange.Range["A1:H1"].MergeCells = true;
            exRange.Range["A1:H1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A1:H1"].Value = "ĐIỀU 2: GIÁ TRỊ HỢP ĐỒNG";
            exRange.Range["A1:H1"].Font.Bold = true;

            exRange = (COMExcel.Range)exSheet.Cells[row + 30, 1];
            exRange.Range["A1:H1"].MergeCells = true;
            exRange.Range["A1:H1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A1:H1"].Value = "Chi phí cho việc thực hiện nội dung công việc tại Điều 1 của hợp đồng này là: " + tblhd.Rows[0][4].ToString() +
                " (Bằng chữ: " + Class.Functions.ConvertNumberToString(tblhd.Rows[0][4].ToString()) + ")"; ;
            exRange.Range["A1:H1"].WrapText = true;

            exRange = (COMExcel.Range)exSheet.Cells[row + 31, 1];
            exRange.Range["A1:H1"].MergeCells = true;
            exRange.Range["A1:H1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A1:H1"].Value = "ĐIỀU 3: Bên A phải trả tiền đầy đủ cho bên B 01 (một) lần bằng tiền mặt và bên A phải cấp cho bên B hợp đồng đẩy đủ để có cơ sở thanh toán chi phí cho đợt quảng cáo";
            exRange.Range["A1:H1"].Font.Bold = true;
            exRange.Range["A1:H1"].WrapText = true;

            exRange = (COMExcel.Range)exSheet.Cells[row + 32, 1];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = "ĐẠI DIỆN BÊN A";
            exRange.Range["A1:C1"].Font.Bold = true;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            string[] Name_KH = txtTenkhachhang.Text.Split(" ");
            exRange.Range["A2:C2"].Value = Name_KH[2];
            exRange.Range["A3:C3"].MergeCells = true;
            exRange.Range["A3:C3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:C3"].Value = txtTenkhachhang.Text;

            exRange = (COMExcel.Range)exSheet.Cells[row + 32, 6];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = "ĐẠI DIỆN BÊN B";
            exRange.Range["A1:C1"].Font.Bold = true;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            string[] Name_NV = txtTennhanvien.Text.Split(" ");
            exRange.Range["A2:C2"].Value = Name_NV[2];
            exRange.Range["A3:C3"].MergeCells = true;
            exRange.Range["A3:C3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:C3"].Value = txtTennhanvien.Text;
            exApp.Visible = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cboMahopdong.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hợp đồng để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMahopdong.Focus();
                return;
            }
            load_data();
            cboMahopdong.SelectedIndex = -1;
            btnLammoi.Enabled = true;
        }
    }
}
