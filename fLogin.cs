using NguyenQuangKhai.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenQuangKhai
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String acc = txt_account.Text;
            String pass = txt_password.Text;
            try
            {
                if (acc != "")
                {
                    if (pass != "")
                    {
                        if (Login(acc, pass))
                        {
                            MessageBox.Show("Đăng nhập thành công!");
                            fTableManager fBookManage = new fTableManager();
                            this.Hide();
                            //fBookManage
                            fBookManage.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không được để trống!");
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không được để trống!");
                }
                
                bool Login(string account, string password)
                {
                    return AccountDAO.Instance.Login(account,password);
                }


    }
            catch(Exception err)
            {
                MessageBox.Show("đã có lỗi! "+err);
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn đóng ứng dụng!","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
