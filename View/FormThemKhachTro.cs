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
            cbbPhong.SelectedIndex = 0;
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
                    cbbPhong.Focus();
                    break;
                }
            }
        }

        private void vietHoaChuDau(string txt)
        {
            string strArr = txt;
            for (int i = 0; i < strArr.Length; i++)
            {
                strArr[0].ToString().ToUpper();
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


        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKhach.Text == "" || txtHoten.Text == "" || dtpNgaySinh.Value == null || dtpNgaySinh.Value == DateTime.Now || txtSDT.Text == "" || txtQueQuan.Text == "" || txtCMND.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                string maKH = txtMaKhach.Text;
                string hoTen = txtHoten.Text;
                //int ngay = dtpNgaySinh.Value.Day;
                //int thang = dtpNgaySinh.Value.Month;
                //int nam = dtpNgaySinh.Value.Year;
                //xử lý radio button
                string rbtnnam = "Nam";
                string rbtnnu = "Nữ";
                string sdt = txtSDT.Text;
                string quequan = txtQueQuan.Text;
                string cmnd = txtCMND.Text;
                string tenPhong = cbbPhong.Text;
                HOPDONG hopDong = new HOPDONG();
                Khách_hàng kh = DB.Khách_hàng.FirstOrDefault(p => p.Mã_KH == maKH);
                if(kh != null)
                {
                    MessageBox.Show("Trùng mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Khách_hàng kh1 = new Khách_hàng();// tạo mới 1 khách hàng rồi thêm vào dgv
                    kh1.Mã_KH = maKH;
                    kh1.Tên_KH = hoTen;
                    kh1.Năm_sinh = dtpNgaySinh.Value;
                    kh1.Sđt = sdt;
                    kh1.Quê_quán = quequan;
                    if(rbtnNam.Checked == true)
                    { 
                        kh1.Giới_tính = rbtnnam;
                    }
                    else
                    {
                        kh1.Giới_tính = rbtnnu;
                    }
                    hopDong.Mã_phòng = tenPhong;
                    kh1.CMND = cmnd;
                    DB.Khách_hàng.Add(kh1);
                    DB.HOPDONGs.Add(hopDong);
                    DB.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void TxtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if(!Char.IsDigit(chr) && chr != 8)//kiển tra kí tự nhậ có phải số và có khoảng trắng(số 8) hay không
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
            checkCharSDT();
        }

        private void TxtHoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra có phải là kí tự của control hay không và có pahir là số hay không
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true )
            {
                MessageBox.Show("Vui lòng nhập chữ","Thông báo");
                e.Handled = true;
            }
        }

        private void TxtQueQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            //như Họ tên
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                MessageBox.Show("Vui lòng nhập chữ","Thông báo");
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
    }
}