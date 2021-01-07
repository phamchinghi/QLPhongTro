using DevExpress.XtraEditors;
using QL_PhongTro.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_PhongTro
{
    public partial class FormThemKhachTro : DevExpress.XtraEditors.XtraForm
    {
        DB_QLPhongTro DB = new DB_QLPhongTro();
        public FormThemKhachTro()
        {
            InitializeComponent();
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Metropolis";
        }
        private void FormThemKhachTro_Load(object sender, EventArgs e)
        {
            skin();
            dtpNgaySinh.MaxDate = DateTime.Now;
            dtpNgaySinh.Value.Day.ToString();
            dtpNgaySinh.Value.Month.ToString();
            dtpNgaySinh.Value.Year.ToString();
            //txtPhong.Text = "VD: 101";
            //txtPhong.ForeColor = Color.Gray;
            //=============================================Hiện tên phòng lên combobox===========================================================
            DataTable phong = DataConnection.Instance.readData("Select [Mã phòng],[Mã loại phòng] from dbo.[Phòng] ");
            cbPhong.DisplayMember = "Mã phòng";
            cbPhong.ValueMember = "Mã loại phòng";
            cbPhong.DataSource = phong;
            cbPhong.SelectedIndex = 0;
            //===========================load dữ liệu từ DB lên===================
            string query = "select * from DSKhachHang";
            DataConnection.Instance.ExcData(query);
            DataConnection.Instance.readData(query);
            dgvDSKhachTro.DataSource = DataConnection.Instance.readData(query);
        }
        private void checkCharMaKhach()
        {
            int count = txtMaKhach.TextLength;
            for (int i = 0; i < count; i++)
            {
                if (count == 5)
                {
                    MessageBox.Show("Bạn đã nhập đủ kí tự ở mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHoten.Focus();
                    //txtMaKhach.Enabled = false;
                    break;
                }
            }
        }

        private void checkCharSDT()
        {
            int count = txtSDT.TextLength;
            for (int i = 0; i < count; i++)
            {
                if (count == 10)
                {
                    txtQueQuan.Focus();
                    break;
                }
            }
        }

        private void checkCharCMND()
        {
            int count = txtCMND.TextLength;
            for (int i = 0; i < count; i++)
            {
                if (count == 9)
                {
                    cbPhong.Focus();
                    break;
                }
            }
        }



        private void TxtMaKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaKhach.CharacterCasing = CharacterCasing.Upper;
            checkCharMaKhach();

        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private string checkRadioButton()
        //{
        //    if (rbtnNam.Checked == true)
        //    {
        //        return "Nam";
        //    }
        //    else
        //    {
        //        return "Nữ";
        //    }
        //}
        public static string ConvertDateTime(string date)
        {
            string[] elements = date.Split('/');
            string dt = string.Format("{0}/{1}/{2}", elements[0], elements[1], elements[2]);
            return dt;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            FormTrangChu frmTrangChu = new FormTrangChu();
            try
            {
                if (txtMaKhach.Text == "" || txtHoten.Text == "" || dtpNgaySinh.Value == null || dtpNgaySinh.Value == DateTime.Now || txtSDT.Text == "" || txtQueQuan.Text == "" || txtCMND.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                string query = "insert into dbo.[Khách hàng]([Mã KH],[Tên KH],[Năm sinh],[Sđt],[CMND],[Quê quán],[Giới tính],[Mã phòng])" +
                               " values('" + txtMaKhach.Text + "', '" + txtHoten.Text + "', '" +  ConvertDateTime(dtpNgaySinh.Text) + "', '"+txtSDT.Text+"','"+txtCMND.Text+"', '"+txtQueQuan.Text+"', '"+cbGioitinh.Text+"', '"+cbPhong.Text+ "')" +
                               " go" +
                               " insert into dbo.HOPDONG([Mã KH],[Mã phòng])" +
                               " values('" + txtMaKhach.Text+"', '"+cbPhong.Items+"')" +
                               " go";

                DataConnection.Instance.ExcData(query);
                DataConnection.Instance.readData(query);
                if (DataConnection.Instance.ExcData(query) == true)
                {
                    MessageBox.Show("ok");
                }
                else
                {
                    MessageBox.Show("khong the them du lieu");
                }
                //DataTable data = DataConnection.Instance.readData(query);
                //DB.SaveChanges();
                //string ma = txtMaKhach.Text;
                //string hoten = txtHoten.Text;
                //string ngaysinh = dtpNgaySinh.Value.ToString();
                //string sdt = txtSDT.Text;
                //string quenquan = txtQueQuan.Text;
                //string cmnd = txtCMND.Text;
                //string phong ="P" + txtPhong.Text;
                ////Khách_hàng khachhang = new Khách_hàng();
                //Khách_hàng khachhang = DB.Khách_hàng.FirstOrDefault(p => p.Mã_KH == ma);
                //if(khachhang != null)
                //{
                //    MessageBox.Show("Trùng mã");
                //}
                //else
                //{
                //HOPDONG hopdong1 = new HOPDONG();
                //hopdong1.Khách_hàng.Mã_KH = ma;
                //hopdong1.Khách_hàng.Tên_KH = hoten;
                //hopdong1.Khách_hàng.Năm_sinh = DateTime.Parse(ngaysinh);
                //hopdong1.Khách_hàng.Giới_tính = rbtnNam.Checked ? "Nam" : "Nữ";
                //hopdong1.Khách_hàng.Sđt = sdt;
                //hopdong1.Khách_hàng.Quê_quán = quenquan;
                //hopdong1.Khách_hàng.CMND = cmnd;
                //hopdong1.Mã_phòng = phong;

                //DB.HOPDONGs.Add(hopdong1);
                ////DB.SaveChanges();
                //MessageBox.Show("ok");
                //frmTrangChu.updateGridView();
                //hopDong.Khách_hàng.Mã_KH = ma;
                //hopDong.Mã_phòng = phong;
                //hopDong.Khách_hàng.Tên_KH = hoten;
                //hopDong.Khách_hàng.Năm_sinh = DateTime.Parse(ngaysinh);
                //hopDong.Khách_hàng.Giới_tính = rbtnNam.Checked ? "Nam" : "Nữ";
                //hopDong.Khách_hàng.Sđt = sdt;
                //hopDong.Khách_hàng.Quê_quán = quenquan;
                //hopDong.Khách_hàng.CMND = cmnd;
                //DB.Khách_hàng.Add(khachhang);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)//kiển tra kí tự nhậ có phải số và có khoảng trắng(số 8) hay không
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
            checkCharSDT();
        }

        private void TxtHoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra có phải là kí tự của control hay không và có pahir là số hay không
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                MessageBox.Show("Vui lòng nhập chữ", "Thông báo");
                e.Handled = true;
            }
        }

        private void TxtQueQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            //như Họ tên
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                MessageBox.Show("Vui lòng nhập chữ", "Thông báo");
                e.Handled = true;
            }
        }

        private void TxtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)//kiển tra kí tự nhậ có phải số và có khoảng trắng(số 8) hay không
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
            checkCharCMND();
        }

        private void CbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}