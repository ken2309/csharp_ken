using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NguyenQuangKhai.DAO;

namespace NguyenQuangKhai
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadListAccount();
        }

        void LoadListAccount()
        {
            string query = "SELECT TenTaiKhoan as [Tên hiển thị],Email,SDT as [Số điện thoại],DiaChi as [Địa chỉ],HoTen as [Họ và tên]  from dbo.TaiKhoan";

            dtgv_account.DataSource = DataProvider.Instance.ExecuteQuery(query);
           
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
