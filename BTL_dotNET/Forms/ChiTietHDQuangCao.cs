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
    public partial class ChiTietHDQuangCao : Form
    {
        public ChiTietHDQuangCao()
        {
            InitializeComponent();
        }

        string maqc;
        public void GetValue(string value)
        {
            maqc = value;
        }

        public void resetvalues()
        {
            cboMabao.Text = "";
            cboMadichvu.Text = "";
            mskNgaybatdau.Text = "";
            mskNgayketthuc.Text = "";
            txtDongia.Text = "0";
            txtNoidung.Text = "";
            txtThanhtien.Text = "0";
            txtMaCTQC.Text = "";
            txtTongtien.Text = Convert.ToString(Class.Functions.GetFieldValues("select coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien " +
                "from quangcao a full join chitietquangcao b on a.maqc=b.maqc where a.maqc='" + maqc + "' " + "group by a.maqc"));
            if (txtTongtien.Text != "0")
            {
                lblBangchu.Text = "Bằng chữ: " + Class.Functions.ConvertNumberToString(txtTongtien.Text);
            }
            else
            {
                lblBangchu.Text = "Bằng chữ: Không đồng";
            }

        }

        private void ChiTietHDQuangCao_Load(object sender, EventArgs e)
        {
            load_data();
            txtMaCTQC.ReadOnly = true;
            txtDichvu.ReadOnly = true;
            txtTenbao.ReadOnly = true;
            txtDongia.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            txtTongtien.ReadOnly = true;
            Class.Functions.Fillcombo("select mabao,tenbao from bao", cboMabao, "mabao", "mabao");
            cboMabao.SelectedIndex = -1;
            Class.Functions.Fillcombo("select madv,dichvu from dichvu", cboMadichvu, "madv", "madv");
            cboMadichvu.SelectedIndex = -1;
            txtDongia.Text = "0";
            txtThanhtien.Text = "0";
            btnThemdichvu.Enabled = true;
            btnCapnhat.Enabled = false;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtTongtien.Text = Convert.ToString(Class.Functions.GetFieldValues("select coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien " +
                "from quangcao a full join chitietquangcao b on a.maqc=b.maqc where a.maqc='" + maqc + "' " + "group by a.maqc"));
            if (txtTongtien.Text != "0")
            {
                lblBangchu.Text = "Bằng chữ: " + Class.Functions.ConvertNumberToString(txttongtien.Text);
            }
            else
            {
                lblBangchu.Text = "Bằng chữ: Không đồng";
            }
        }

        DataTable tblcthopdong;

        private void load_data()
        {
            string sql;
            sql = "select mactqc,mabao,madv,noidung,ngaybd,ngaykt,dongia,(dongia * abs(datediff(day,ngaykt,ngaybd))) as thanhtien from chitietquangcao where maqc = '" + maqc + "'";
            tblcthopdong = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblcthopdong;
            DataGridView.Columns[0].HeaderText = "Mã CTQC";
            DataGridView.Columns[1].HeaderText = "Mã báo";
            DataGridView.Columns[2].HeaderText = "Mã dịch vụ";
            DataGridView.Columns[3].HeaderText = "Nội dung";
            DataGridView.Columns[4].HeaderText = "Ngày bắt đầu";
            DataGridView.Columns[5].HeaderText = "Ngày kết thúc";
            DataGridView.Columns[6].HeaderText = "Đơn giá";
            DataGridView.Columns[7].HeaderText = "Thành tiền";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 90;
            DataGridView.Columns[2].Width = 115;
            DataGridView.Columns[3].Width = 200;
            DataGridView.Columns[4].Width = 130;
            DataGridView.Columns[5].Width = 130;
            DataGridView.Columns[6].Width = 90;
            DataGridView.Columns[7].Width = 90;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (tblcthopdong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnThemdichvu.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtMaCTQC.Text = DataGridView.CurrentRow.Cells["mactqc"].Value.ToString();
            string mabao, madv;
            mabao = DataGridView.CurrentRow.Cells["mabao"].Value.ToString();
            cboMabao.Text = Class.Functions.GetFieldValues("select mabao from bao where mabao ='" + mabao + "'");
            madv = DataGridView.CurrentRow.Cells["madv"].Value.ToString();
            cboMadichvu.Text = Class.Functions.GetFieldValues("select madv from dichvu where madv ='" + madv + "'");
            txtNoidung.Text = DataGridView.CurrentRow.Cells["noidung"].Value.ToString();
            txtDongia.Text = Class.Functions.GetFieldValues("Select dongia from banggiaqc where mabao ='" + mabao + "' and madv = '" + madv + "'");
            mskNgaybatdau.Text = DataGridView.CurrentRow.Cells["ngaybd"].Value.ToString();
            mskNgayketthuc.Text = DataGridView.CurrentRow.Cells["ngaykt"].Value.ToString();
            txtThanhtien.Text = DataGridView.CurrentRow.Cells["thanhtien"].Value.ToString();
            btnCapnhat.Enabled = true;
            btnBoqua.Enabled = true;
        }



        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
