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
                List<Tài_khoản> listTaiKhoan = DB.Tài_khoản.ToList();//lấy danh sách tài khoản
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
            //Close();
            System.Windows.Forms.Application.Exit();
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
                //for(int i = 0; i < listTaiKhoan.Count; i++)
                //{
                //    if (DB.Tài_khoản.ToString() == txtUserName.Text && DB.Tài_khoản.ToString() == txtpassword.Text)
                //    {
                //        this.Close();
                //    }
                //    else
                //    {
                //        txtUserName.Clear();
                //        txtpassword.Clear();
                //        txtUserName.Focus();
                //    }
                //}
                foreach (var item in listTaiKhoan)
                {
                    if (item.User_name == txtUserName.Text && item.Password == txtpassword.Text)
                    {
                        this.Close();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUserName.Clear();
                        txtpassword.Clear();
                        txtUserName.Focus();
                        break;
                    }
                }
            }
        }


        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }


    }
}
