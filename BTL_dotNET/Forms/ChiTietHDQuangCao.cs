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
                lblBangchu.Text = "Bằng chữ: " + Class.Functions.ConvertNumberToString(txtTongtien.Text);
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

        private void cboMadichvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMadichvu_TextChanged(object sender, EventArgs e)
        {
            if (cboMadichvu.Text == "")
            {
                txtDichvu.Text = "";
            }
            else if (cboMadichvu.Text != "" && cboMabao.Text == "")
            {
                txtDichvu.Text = Class.Functions.GetFieldValues("select dichvu from dichvu where madv ='" + cboMadichvu.SelectedValue + "'");
                txtDongia.Text = "0";
            }
            else
            {
                txtDichvu.Text = Class.Functions.GetFieldValues("select dichvu from dichvu where madv ='" + cboMadichvu.SelectedValue + "'");
                txtDongia.Text = Class.Functions.GetFieldValues("select dongia from banggiaqc where mabao = '" + cboMabao.SelectedValue + "' and madv = '" + cboMadichvu.SelectedValue + "'");
            }
        }

        private void cboMabao_TextChanged(object sender, EventArgs e)
        {
            if (cboMabao.Text == "")
            {
                txtTenbao.Text = "";
            }
            else if (cboMadichvu.Text == "" && cboMabao.Text != "")
            {
                txtTenbao.Text = Class.Functions.GetFieldValues("select tenbao from bao where mabao ='" + cboMabao.SelectedValue + "'");
                txtDongia.Text = "0";
            }
            else
            {
                txtTenbao.Text = Class.Functions.GetFieldValues("select tenbao from bao where mabao ='" + cboMabao.SelectedValue + "'");
                txtDongia.Text = Class.Functions.GetFieldValues("select dongia from banggiaqc where mabao = '" + cboMabao.SelectedValue + "' and madv = '" + cboMadichvu.SelectedValue + "'");
            }
        }

        private void cboMabao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetvalues();
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThemdichvu.Enabled = true;
            btnCapnhat.Enabled = false;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (cboMabao.Text == "" && cboMadichvu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (mskNgaybatdau.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaybatdau.Focus();
                return;
            }
            if (mskNgayketthuc.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayketthuc.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskNgaybatdau.Text) && !Class.Functions.Isdate(mskNgayketthuc.Text))
            {
                MessageBox.Show("Sai định dạng ngày, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaybatdau.Focus();
                mskNgaybatdau.Text = "";
                mskNgayketthuc.Text = "";
                return;
            }
            if (!Class.Functions.Isdate(mskNgaybatdau.Text))
            {
                MessageBox.Show("Sai định dạng ngày tháng, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaybatdau.Focus();
                mskNgaybatdau.Text = "";
                return;
            }
            if (!Class.Functions.Isdate(mskNgayketthuc.Text))
            {
                MessageBox.Show("Sai định dạng ngày tháng, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayketthuc.Focus();
                mskNgayketthuc.Text = "";
                return;
            }
            if (Convert.ToInt32(txtThanhtien.Text) == 0)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayketthuc.Focus();
                mskNgayketthuc.Text = "";
                return;
            }
            if (txtNoidung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập nội dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoidung.Focus();
                return;
            }
            string sql;
            sql = "update chitietquangcao set mabao ='" + cboMabao.SelectedValue.ToString() + "', madv ='" + cboMadichvu.SelectedValue.ToString() + "', noidung =N'" +
                txtNoidung.Text + "', ngaybd ='" + Class.Functions.ConvertDate(mskNgaybatdau.Text) + "', ngaykt ='" + Class.Functions.ConvertDate(mskNgayketthuc.Text) +
                "', dongia ='" + txtDongia.Text + "' where mactqc ='" + txtMaCTQC.Text + "'";
            Class.Functions.Runsql(sql);
            load_data();
            resetvalues();
            btnCapnhat.Enabled = false;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemdichvu_Click(object sender, EventArgs e)
        {
            resetvalues();
            btnThemdichvu.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            btnCapnhat.Enabled = false;
            txtMaCTQC.Text = Class.Functions.CreateKey("CTQC");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboMabao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn mã báo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMabao.Focus();
                return;
            }
            if (cboMadichvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn mã dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMadichvu.Focus();
                return;
            }
            if (mskNgaybatdau.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaybatdau.Focus();
                return;
            }
            if (mskNgayketthuc.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayketthuc.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskNgaybatdau.Text) && !Class.Functions.Isdate(mskNgayketthuc.Text))
            {
                MessageBox.Show("Sai định dạng ngày, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaybatdau.Focus();
                mskNgaybatdau.Text = "";
                mskNgayketthuc.Text = "";
                return;
            }
            if (!Class.Functions.Isdate(mskNgaybatdau.Text))
            {
                MessageBox.Show("Sai định dạng ngày, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaybatdau.Focus();
                mskNgaybatdau.Text = "";
                return;
            }
            if (!Class.Functions.Isdate(mskNgayketthuc.Text))
            {
                MessageBox.Show("Sai định dạng ngày, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayketthuc.Focus();
                mskNgayketthuc.Text = "";
                return;
            }
            if (Convert.ToInt32(txtThanhtien.Text) == 0)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayketthuc.Focus();
                mskNgayketthuc.Text = "";
                return;
            }
            if (txtNoidung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa điền nội dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoidung.Focus();
                return;
            }
            string sql;
            sql = "insert into chitietquangcao (mactqc,mabao,madv,noidung,ngaybd,ngaykt,dongia,maqc) values ('" + txtMaCTQC.Text + "','" + cboMabao.SelectedValue.ToString() + "','" +
                cboMadichvu.SelectedValue.ToString() + "',N'" + txtNoidung.Text + "','" + Class.Functions.ConvertDate(mskNgaybatdau.Text) + "','" +
                Class.Functions.ConvertDate(mskNgayketthuc.Text) + "'," + txtDongia.Text + ",'" + maqc + "')";
            Class.Functions.Runsql(sql);
            load_data();
            resetvalues();
            btnLuu.Enabled = false;
            btnThemdichvu.Enabled = true;
            btnBoqua.Enabled = false;
        }

        private void mskNgaybatdau_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskNgaybatdau_TextChanged(object sender, EventArgs e)
        {
            if (mskNgaybatdau.Text.Length == 10 && mskNgaybatdau.Text.IndexOf(' ') == -1 && mskNgayketthuc.Text.Length == 10 && mskNgayketthuc.Text.IndexOf(' ') == -1
                && Class.Functions.Isdate(mskNgaybatdau.Text) && Class.Functions.Isdate(mskNgayketthuc.Text))
            {
                txtThanhtien.Text = Convert.ToString(Class.Functions.DateDiff(mskNgaybatdau.Text, mskNgayketthuc.Text) * Convert.ToInt32(txtDongia.Text));
            }
            else
            {
                txtThanhtien.Text = "0";
            }
        }

        private void mskNgayketthuc_TextChanged(object sender, EventArgs e)
        {
            if (mskNgayketthuc.Text.Length == 10 && mskNgayketthuc.Text.IndexOf(' ') == -1 && mskNgayketthuc.Text.Length == 10 && mskNgayketthuc.Text.IndexOf(' ') == -1
                && Class.Functions.Isdate(mskNgaybatdau.Text) && Class.Functions.Isdate(mskNgayketthuc.Text))
            {
                txtThanhtien.Text = Convert.ToString(Class.Functions.DateDiff(mskNgaybatdau.Text, mskNgayketthuc.Text) * Convert.ToInt32(txtDongia.Text));
            }
            else
            {
                txtThanhtien.Text = "0";
            }
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ quảng cáo này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql;
                sql = "delete from chitietquangcao where mactqc = '" + txtMaCTQC.Text + "'";
                Class.Functions.Runsqldel(sql);
                load_data();
                resetvalues();
                btnBoqua.Enabled = false;
                btnCapnhat.Enabled = false;
            }
        }


        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            if (txtDongia.Text != "" && mskNgayketthuc.Text.Length == 10 && mskNgayketthuc.Text.IndexOf(' ') == -1 && mskNgayketthuc.Text.Length == 10 && mskNgayketthuc.Text.IndexOf(' ') == -1
                && Class.Functions.Isdate(mskNgaybatdau.Text) && Class.Functions.Isdate(mskNgayketthuc.Text))
            {
                txtThanhtien.Text = Convert.ToString(Class.Functions.DateDiff(mskNgaybatdau.Text, mskNgayketthuc.Text) * Convert.ToInt32(txtDongia.Text));
            }
            else
            {
                txtThanhtien.Text = "0";
            }
        }

        private void txtThanhtien_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtThanhtien.Text) < 0)
            {
                MessageBox.Show("Hãy nhập ngày kết thúc lớn hơn ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayketthuc.Text = "";
                mskNgayketthuc.Focus();
                return;
            }
        }
    }
}
