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
            if (txtUserName.Text == " " || txtpassword.Text == " ")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (checkLogin(txtUserName.Text,txtpassword.Text))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Clear();
                    txtpassword.Clear();
                    txtUserName.Focus();
                }
            }
        }
        bool checkLogin(string userName, string password)
        {
            string query = "exec dbo._GetAccount @username = '" + userName +"', @password = '" + password + "' ";//lấy text của username và password để thực thi duyệt ở sql
            DataConnection.Instance.ExcData(query);
            DataTable result =  DataConnection.Instance.readData(query);
            return result.Rows.Count > 0;//trả về số dòng đúng dữ liệu
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void checkUsername()
        {

            //if (txtUserName.TextLength >= 10)
            //{
            //    txtUserName.BackColor = Color.LawnGreen;
            //}
            //else
            //{
            //    txtUserName.BackColor = Color.Red;
            //}
        }
        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            checkUsername();
        }
    }
}
