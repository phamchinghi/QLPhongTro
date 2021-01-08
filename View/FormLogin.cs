using QL_PhongTro.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_PhongTro
{
    public partial class FormLogin : Form
    {
        DB_QLPhongTro DB = new DB_QLPhongTro();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<Tài_khoản> listTaiKhoan = DB.Tài_khoản.ToList();//lay danh sach khach hang
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Tài_khoản> listTaiKhoan = DB.Tài_khoản.ToList();
            if (txtUserName.Text == " " || txtpassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (var item in listTaiKhoan)
                {
                    if (item.User_name == txtUserName.Text && item.Password == txtpassword.Text)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu", "Note", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
            }
        }


        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }


    }
}
