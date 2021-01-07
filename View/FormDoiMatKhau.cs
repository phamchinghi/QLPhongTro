using DevExpress.XtraEditors;
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
    public partial class FormDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        DB_QLPhongTro DB = new DB_QLPhongTro();
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Metropolis";
        }
        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            skin();
            try
            {
                List<Tài_khoản> listTaiKhoan = DB.Tài_khoản.ToList();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            List<Tài_khoản> listTaiKhoan = DB.Tài_khoản.ToList();
            Tài_khoản tk = DB.Tài_khoản.FirstOrDefault(p => p.Password == txtmkhientai.Text);
            if (checkPassword(txtmkhientai.Text))//kiểm tra mk cũ vơi mk hiện tại
            {
                if (txtmkmoi.Text == txtcapnhatmkmoi.Text)
                {
                    tk.Password = txtmkmoi.Text;
                    DB.SaveChanges();
                    MessageBox.Show("Đổi mật khẩu thành công");
                    txtmkhientai.Clear();
                    txtmkmoi.Clear();
                    txtcapnhatmkmoi.Clear();
                    txtmkhientai.Focus();
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận chưa chính xác");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ chưa chính xác");
            }
        }
        bool checkPassword(string password)
        {
            string query = "exec dbo._GetPassword @password = '" + txtmkhientai.Text + "'";
            DataConnection.Instance.ExcData(query);
            DataTable result = DataConnection.Instance.readData(query);
            return result.Rows.Count > 0;
        }
        private void BtnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}