using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenQuangKhai.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance { get { if (instance == null) instance = new AccountDAO() ; return AccountDAO.instance; } private set { instance = value; } }

        private AccountDAO()
        {

        }
        public bool Login(string account, string pass)
        {

            string query = "SELECT * FROM dbo.TaiKhoan where TenTaiKhoan='" + account + "' AND MatKhau='" + pass + "'";

            Object res = DataProvider.Instance.ExecuteScalar(query);

            if(res != null)
            {
                return true;
            }
            return false;
        }
    }
}
