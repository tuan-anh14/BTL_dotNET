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
    public partial class ChiTietHDVietBai : Form
    {
        DataTable tblcthopdong;
        public ChiTietHDVietBai()
        {
            InitializeComponent();
        }

        string mavb;
        public void GetValue(string value)
        {
            mavb = value;
        }

        public void resetvalues()
        {
            txtmactvb.Text = "";
            cbomabao.Text = "";
            cbomatheloai.Text = "";
            mskngaydang.Text = "";
            txtnhuanbut.Text = "0";
            txttieude.Text = "";
            txtnoidung.Text = "";
            txttongtien.Text = Convert.ToString(Class.Functions.GetFieldValues("select coalesce(sum(nhuanbut),0) as tongtien " +
                "from vietbai a full join chitietvietbai b on a.mavb=b.mavb where a.mavb='" + mavb + "' " + "group by a.mavb"));
            if (txttongtien.Text != "0")
            {
                lblbangchu.Text = "Bằng chữ: " + Class.Functions.ConvertNumberToString(txttongtien.Text);
            }
            else
            {
                lblbangchu.Text = "Bằng chữ: Không đồng";
            }
        }



        private void lblchitiethopdong_Click(object sender, EventArgs e)
        {

        }

        private void ChiTietHDVietBai_Load(object sender, EventArgs e)
        {
            txtmactvb.ReadOnly = true;
            Class.Functions.Fillcombo("select mabao, tenbao from bao", cbomabao, "mabao", "mabao");
            cbomabao.SelectedIndex = -1;
            txttenbao.ReadOnly = true;
            Class.Functions.Fillcombo("select matheloai, theloai from theloai", cbomatheloai, "matheloai", "matheloai");
            cbomatheloai.SelectedIndex = -1;
            txttheloai.ReadOnly = true;
            txtnhuanbut.ReadOnly = true;
            txtnhuanbut.Text = "0";
            load_data();
            btnthem.Enabled = true;
            btncapnhat.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            btndong.Enabled = true;
            txttongtien.ReadOnly = true;
            txttongtien.Text = Convert.ToString(Class.Functions.GetFieldValues("select coalesce(sum(nhuanbut),0) as tongtien " +
                "from vietbai a full join chitietvietbai b on a.mavb=b.mavb where a.mavb='" + mavb + "' " + "group by a.mavb"));
            if (txttongtien.Text != "0")
            {
                lblbangchu.Text = "Bằng chữ: " + Class.Functions.ConvertNumberToString(txttongtien.Text);
            }
            else
            {
                lblbangchu.Text = "Bằng chữ: Không đồng";
            }
        }

        private void load_data()
        {
            string sql;
            sql = "select mactvb,mabao,matheloai,tieude,noidung,ngaydang,nhuanbut from chitietvietbai where mavb = '" + mavb + "'";
            tblcthopdong = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblcthopdong;
            DataGridView.Columns[0].HeaderText = "Mã CTVB";
            DataGridView.Columns[1].HeaderText = "Mã báo";
            DataGridView.Columns[2].HeaderText = "Mã thể loại";
            DataGridView.Columns[3].HeaderText = "Tiêu đề";
            DataGridView.Columns[4].HeaderText = "Nội dung";
            DataGridView.Columns[5].HeaderText = "Ngày đăng";
            DataGridView.Columns[6].HeaderText = "Nhuận bút";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 90;
            DataGridView.Columns[2].Width = 150;
            DataGridView.Columns[3].Width = 200;
            DataGridView.Columns[4].Width = 200;
            DataGridView.Columns[5].Width = 130;
            DataGridView.Columns[6].Width = 90;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


    }
}
