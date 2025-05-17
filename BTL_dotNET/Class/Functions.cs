using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BTL_dotNET.Class
{
    internal class Functions
    {
        public static SqlConnection conn;
        public static string stringconn;
        public static void Connect()
        {
            try
            {
                stringconn = "Data Source=THIEUTUANANH;Initial Catalog=BTLdotNet;Integrated Security=True;Encrypt=False";
                conn = new SqlConnection();
                conn.ConnectionString = stringconn;
                conn.Open();
                MessageBox.Show("Kết nối thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
    }
}
