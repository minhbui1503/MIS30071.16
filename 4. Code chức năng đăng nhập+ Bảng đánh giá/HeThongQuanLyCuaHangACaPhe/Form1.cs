using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyCuaHangACaPhe
{
    public partial class Form1 : Form
    {
        string taikhoan = "admin";
        string matkhau = "admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(textBox1.Text, textBox2.Text)) 
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài Khoản/ Mật Khẩu không chính xác. Vui lòng thử lại", "Đăng Nhập Thất Bại");
                textBox1.Focus();
            }
            
        }
        bool KiemTraDangNhap(string taikhoan, string matkhau)
        {
            if(taikhoan == this.taikhoan && matkhau == this.matkhau)
            {
                return true;
            }
            return false;

        }
    }
}
