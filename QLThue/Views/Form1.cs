using QLThue.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Modify modify = new Modify();
        private void LoginAcc_Click(object sender, EventArgs e)
        {
            string tentk = textBox1.Text;
            string matkhau = textBox2.Text;
            if(tentk.Trim( ) == "" ) { MessageBox.Show("Vui lòng nhập tên tài khoản!");  }
            else if(matkhau.Trim( ) == "" ) { MessageBox.Show("Vui lòng nhập mật khẩu!");  }
            else
            {
                string query = "Select * from tknhanvien where taikhoan = '" + tentk + "' and matkhau ='" + matkhau + "'";
                if(modify.TaiKhoans(query).Count>0)
                {
                    MessageBox.Show("Đăng nhập thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    this.Close();
                }   
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mặt khẩu không chính xác!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }    
            }    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
