using QL_PhongTro.Data;
using QL_PhongTro.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_PhongTro
{
    public partial class FormTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DB_QLPhongTro DB = new DB_QLPhongTro();
        public FormTrangChu()
        {
            InitializeComponent();
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Metropolis";
        }
        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();
            skin();
            try
            {
                List<Khách_hàng> listKhachtros = DB.Khách_hàng.ToList();//lay danh sach khach hang
                List<HOPDONG> HOPDONG = DB.HOPDONGs.ToList<HOPDONG>();
                BindingGrid(HOPDONG);
                //đọc dữ liệu bảng phòng để hiện lên combobox
                DataTable phong = DataConnection.Instance.readData("Select [Mã phòng],[Mã loại phòng] from dbo.[Phòng] ");
                cbPhong.DisplayMember = "Mã phòng";
                cbPhong.ValueMember = "Mã loại phòng";
                cbPhong.DataSource = phong;
                cbPhong.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Load dữ liệu khách trọ thất bại");
            }
        }
        private void BindingGrid(List<HOPDONG> hopdong)
        {
            dgvTrangChu.Rows.Clear();
            foreach (var item in hopdong)
            {
                int index = dgvTrangChu.Rows.Add();//them vao tung vi tri ở datagridview
                                                   //xac dinh vi tri cac cot de them du lieu
                dgvTrangChu.Rows[index].Cells[0].Value = item.Mã_KH;
                dgvTrangChu.Rows[index].Cells[1].Value = item.Mã_phòng;
                dgvTrangChu.Rows[index].Cells[2].Value = item.Khách_hàng.Tên_KH;
                dgvTrangChu.Rows[index].Cells[3].Value = item.Khách_hàng.Năm_sinh.ToString();
                dgvTrangChu.Rows[index].Cells[4].Value = item.Khách_hàng.Sđt;
                dgvTrangChu.Rows[index].Cells[5].Value = item.Khách_hàng.CMND;
                dgvTrangChu.Rows[index].Cells[6].Value = item.Khách_hàng.Quê_quán;
                dgvTrangChu.Rows[index].Cells[7].Value = item.Khách_hàng.Giới_tính;
            }
            //DataConnection dataConnection = new DataConnection();
            //string query = "select * from Trangchu";
            //dataConnection.ExcData(query);
            //dataConnection.readData(query);
            //dgvTrangChu.DataSource = dataConnection.readData(query);
        }
        private void BindingDataPhong(List<HOPDONG> hopDongs,Label lbl)
        {
            dgvTrangChu.Rows.Clear();//clear du lieu gridview
            foreach (var item in hopDongs)
            {
                int index = dgvTrangChu.Rows.Add();
                if(item.Mã_phòng == lbl.Text)
                {
                    dgvTrangChu.Rows[index].Cells[0].Value = item.Mã_KH;
                    dgvTrangChu.Rows[index].Cells[1].Value = item.Mã_phòng;
                    dgvTrangChu.Rows[index].Cells[2].Value = item.Khách_hàng.Tên_KH;
                    dgvTrangChu.Rows[index].Cells[3].Value = item.Khách_hàng.Năm_sinh.ToString();
                    dgvTrangChu.Rows[index].Cells[4].Value = item.Khách_hàng.Sđt;
                    dgvTrangChu.Rows[index].Cells[5].Value = item.Khách_hàng.CMND;
                    dgvTrangChu.Rows[index].Cells[6].Value = item.Khách_hàng.Quê_quán;
                    dgvTrangChu.Rows[index].Cells[7].Value = item.Khách_hàng.Giới_tính;
                }
                else
                {
                    dgvTrangChu.Rows[index].Visible = false;
                }
            }
        }
        //cập nhật lại dgv sau khi thêm khách.
      
        private void lblPhong101_Click(object sender, EventArgs e)
        {
            Label b = sender as Label;
            List<HOPDONG> HOPDONG = DB.HOPDONGs.ToList();
            switch (b.Text)
            {
                case "P101 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P102 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P103 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P104 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P105 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P106 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P107 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P108 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                default:
                    break;
            }
        }
        private void lblPhong201_Click(object sender, EventArgs e)
        {
            //Hiện thông tin cơ bản của tầng 2
            Label b = sender as Label;//gán cho nó như là 1 cái label
            List<HOPDONG> HOPDONG = DB.HOPDONGs.ToList();
            switch (b.Text)
            {
                case "P201 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P202 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P203 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P204 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P205 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P206 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P207 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P208 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                default:
                    break;
            }
        }
        private void LblPhong301_Click(object sender, EventArgs e)
        {
            Label b = sender as Label;
            List<HOPDONG> HOPDONG = DB.HOPDONGs.ToList();
            switch (b.Text)
            {
                case "P301 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P302 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P303 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P304 ":
                    BindingDataPhong(HOPDONG, b);
                    break;
                default:
                    break;
            }
        }



        private void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FormDSThietBi().Show();
        }    
//==================================HIện danh sach tất cả khach ở trọ==========================
        //các thao tác quản lý khách
        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDSKhachTro frmKhachTro = new FormDSKhachTro();
            frmKhachTro.Show();
        }
//===========================Thêm mới khách hàng==================================
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKH.Text == "" || txtHoten.Text == "" || dtpNamSinh.Value == null || dtpNamSinh.Value == DateTime.Now || txtSDT.Text == "" || txtQueQuan.Text == "" || txtCMND.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                checkCharMaKhach();
                checkCharSDT();
                checkCharCMND();

                //set cho kí tự đầu tiên của chuỗi tên viết hoa(dùng thư viện System.Globalization để sử dụng)
                txtHoten.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtHoten.Text.ToLower());
                txtQueQuan.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtQueQuan.Text.ToLower());
                string ma = txtMaKH.Text;
                string hoten = txtHoten.Text;
                string ngaysinh = dtpNamSinh.Value.ToString();
                string sdt = txtSDT.Text;
                string quenquan = txtQueQuan.Text;
                string cmnd = txtCMND.Text;
                string maphong = cbPhong.SelectedValue.ToString();
                string tenphong = cbPhong.Text;
                //Phòng phong = new Phòng();
                //maphong = phong.Mã_phòng;
                //tenphong = phong.Mã_phòng;
                Khách_hàng khachhang = DB.Khách_hàng.FirstOrDefault(p => p.Mã_KH == ma);
                if (khachhang != null)
                {
                    MessageBox.Show("Trùng mã");
                }
                else
                {
                    try
                    {
                        //Tạo 1 đối tượng mới rồi thêm vào DB
                        Khách_hàng khachhang1 = new Khách_hàng();
                        khachhang1.Mã_KH = ma;
                        khachhang1.Tên_KH = hoten;
                        khachhang1.Năm_sinh = DateTime.Parse(ngaysinh);
                        khachhang1.Giới_tính = rbtnNam.Checked ? "Nam" : "Nữ";
                        khachhang1.Sđt = sdt;
                        khachhang1.Quê_quán = quenquan;
                        khachhang1.CMND = cmnd;
                        khachhang1.Mã_phòng = cbPhong.Text;
                        DB.Khách_hàng.Add(khachhang1);
                        HOPDONG hopdong1 = new HOPDONG();
                        hopdong1.Mã_KH = khachhang1.Mã_KH;
                        hopdong1.Mã_phòng = khachhang1.Mã_phòng;
                        DB.HOPDONGs.Add(hopdong1);
                        DB.SaveChanges();//Lưu lại DB sau khi thêm
                        dgvTrangChu.Rows.Clear();
                        updateGridView();
                        MessageBox.Show("Thêm thông tin thành công", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Không thể thêm thông tin khách");
                    }
                }
            }
        }

        //thực hiện thêm bằng truy vấn không được nên thêm bằng cách bằng cách đơn giản như ở trên========================

        //if (txtMaKH.Text == "" || txtHoten.Text == "" || dtpNamSinh.Value == null || dtpNamSinh.Value == DateTime.Now || txtSDT.Text == "" || txtQueQuan.Text == "" || txtCMND.Text == "")
        //{
        //    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //}
        //string query = "insert into dbo.[Khách hàng]([Mã KH],[Tên KH],[Năm sinh],[Sđt],[CMND],[Quê quán],[Giới tính],[Mã phòng])" +
        //               " values('" + txtMaKH.Text + "', '" + txtHoten.Text + "', '" + dtpNamSinh.Value.ToShortDateString().ToString() + "', '" + txtSDT.Text + "','" + txtCMND.Text + "', '" + txtQueQuan.Text + "', '" + checkRadioButton() + "', '" + cbPhong.Text + "')" +
        //               " go";// +
        //                     //" insert into dbo.HOPDONG([Mã KH],[Mã phòng])" +
        //                     //" values('" + txtMaKH.Text + "', '" + cbPhong.Text + "')" +
        //                     //" go";

        //if (DataConnection.Instance.ExcData(query))
        //{
        //    MessageBox.Show("ok");
        //    DataConnection.Instance.readData(query);
        //}
        //else
        //{
        //    MessageBox.Show("no");
        //}

        //============================Load lại datagridview sau khi thêm khách====================
        public void updateGridView()
        {
            List<HOPDONG> listHopDong = DB.HOPDONGs.ToList<HOPDONG>();
            foreach (HOPDONG item in listHopDong)
            {
                dgvTrangChu.Rows.Add(1);
                int count = dgvTrangChu.Rows.Count - 1;
                dgvTrangChu.Rows[count].Cells[0].Value = item.Mã_KH;
                dgvTrangChu.Rows[count].Cells[1].Value = item.Mã_phòng;
                dgvTrangChu.Rows[count].Cells[2].Value = item.Khách_hàng.Tên_KH;
                dgvTrangChu.Rows[count].Cells[3].Value = item.Khách_hàng.Năm_sinh.ToString();
                dgvTrangChu.Rows[count].Cells[4].Value = item.Khách_hàng.Sđt;
                dgvTrangChu.Rows[count].Cells[5].Value = item.Khách_hàng.CMND;
                dgvTrangChu.Rows[count].Cells[6].Value = item.Khách_hàng.Quê_quán;
                dgvTrangChu.Rows[count].Cells[7].Value = item.Khách_hàng.Giới_tính;
            }
        }
        private void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ma = txtMaKH.Text;
            string hoten = txtHoten.Text;
            string ngaysinh = dtpNamSinh.Value.ToString();
            string sdt = txtSDT.Text;
            string quenquan = txtQueQuan.Text;
            string cmnd = txtCMND.Text;
            string maphong = cbPhong.SelectedValue.ToString();
            string tenphong = cbPhong.Text;
            Phòng phong = new Phòng();
            maphong = phong.Mã_phòng;
            tenphong = phong.Mã_phòng;
            Khách_hàng khachhang = DB.Khách_hàng.FirstOrDefault(p => p.Mã_KH == ma);
            if (khachhang != null)
            {
                var result = MessageBox.Show("Bạn muốn xóa", "Xóa", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DB.Khách_hàng.Remove(khachhang);
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK);
                    DB.SaveChanges();
                    dgvTrangChu.Rows.Clear();
                    updateGridView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //===============================================================Sửa khách trọ====================================================================
        private void BarButtonItem5_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtMaKH.Text == "" || txtHoten.Text == "" || dtpNamSinh.Value == null || dtpNamSinh.Value == DateTime.Now || txtSDT.Text == "" || txtQueQuan.Text == "" || txtCMND.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string ma = txtMaKH.Text;
                    string hoten = txtHoten.Text;
                    string ngaysinh = dtpNamSinh.Value.ToString();
                    string sdt = txtSDT.Text;
                    string quenquan = txtQueQuan.Text;
                    string cmnd = txtCMND.Text;
                    string maphong = cbPhong.SelectedValue.ToString();
                    string tenphong = cbPhong.Text;
                    Phòng phong = new Phòng();
                    maphong = phong.Mã_phòng;
                    tenphong = phong.Mã_phòng;
                    Khách_hàng khachhang = DB.Khách_hàng.FirstOrDefault(p => p.Mã_KH == ma);
                    if (khachhang != null)
                    {
                        //khachhang.Mã_KH = ma;                  Không được sửa mã vì mã là khóa chính ở DB
                        khachhang.Tên_KH = hoten;
                        khachhang.Năm_sinh = DateTime.Parse(ngaysinh);
                        khachhang.Giới_tính = rbtnNam.Checked ? "Nam" : "Nữ";
                        khachhang.Sđt = sdt;
                        khachhang.Quê_quán = quenquan;
                        khachhang.CMND = cmnd;
                        khachhang.Mã_phòng = cbPhong.Text;
                        HOPDONG hopdong1 = new HOPDONG();
                        hopdong1.Mã_KH = khachhang.Mã_KH;
                        hopdong1.Mã_phòng = khachhang.Mã_phòng;
                        DB.SaveChanges();
                        MessageBox.Show("Đã cập nhật thông tin khách trọ", "Thông báo", MessageBoxButtons.OK);
                        dgvTrangChu.Rows.Clear();
                        updateGridView();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin khách hàng");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void RibbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void BarButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void BarButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Label7_MouseHover(object sender, EventArgs e)
        {
            //set màu cho label khi chuột hover vô
            Label lbl = sender as Label;
            if(lbl.BackColor == Color.WhiteSmoke)
            {
                lbl.BackColor = Color.LightGray;
            }
        }

        private void Label5_MouseLeave(object sender, EventArgs e)
        {
            //set màu cho label khi chuột hover ra
            Label lbl = sender as Label;
            if (lbl.BackColor == Color.LightGray)
            {
                lbl.BackColor = Color.WhiteSmoke;
            }
        }
//====================================================Đổ dữ liệu lại vào các textbox để sửa=======================================
        private void DgvTrangChu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvTrangChu.CurrentRow.Index;

            txtMaKH.Text    = dgvTrangChu.Rows[i].Cells[0].Value.ToString();
            cbPhong.Text    = dgvTrangChu.Rows[i].Cells[1].Value.ToString();
            txtHoten.Text   = dgvTrangChu.Rows[i].Cells[2].Value.ToString();
            dtpNamSinh.Text = dgvTrangChu.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text     = dgvTrangChu.Rows[i].Cells[4].Value.ToString();
            txtCMND.Text    = dgvTrangChu.Rows[i].Cells[5].Value.ToString();
            txtQueQuan.Text = dgvTrangChu.Rows[i].Cells[6].Value.ToString();
            if (dgvTrangChu.Rows[i].Cells[7].Value.ToString() == "Nam")
            {
                rbtnNam.Checked = true;
            }
            else
            {
                rbtnNu.Checked = true;

            }
        }
        //Hàm kiểm tra mã phòng để hiện text của Form chi tiết phòng
        private void checkMaPhong(Label lbl)
        {
            //Hiện form thêm thiết bị
            FormChiTietPhong frmChiTietPhong = new FormChiTietPhong();
            frmChiTietPhong.Show();
            frmChiTietPhong.Text = frmChiTietPhong.Text + " " + lbl.Text;
        }
        private void LblPhong101_DoubleClick(object sender, EventArgs e)
        {
            Label b = sender as Label;
            switch (b.Text)
            {
                case "P101 ":
                    checkMaPhong( b);
                    break;
                case "P102 ":
                    checkMaPhong( b);
                    break;
                case "P103 ":
                    checkMaPhong(b);
                    break;
                case "P104 ":
                    checkMaPhong( b);
                    break;
                case "P105 ":
                    checkMaPhong( b);
                    break;
                case "P106 ":
                    checkMaPhong( b);
                    break;
                case "P107 ":
                    checkMaPhong( b);
                    break;
                case "P108 ":
                    checkMaPhong( b);
                    break;
                default:
                    break;
            }
        }
        private void LblPhong201_DoubleClick(object sender, EventArgs e)
        {
            Label b = sender as Label;
            switch (b.Text)
            {
                case "P201 ":
                    checkMaPhong(b);
                    break;
                case "P202 ":
                    checkMaPhong(b);
                    break;
                case "P203 ":
                    checkMaPhong(b);
                    break;
                case "P204 ":
                    checkMaPhong(b);
                    break;
                case "P205 ":
                    checkMaPhong(b);
                    break;
                case "P206 ":
                    checkMaPhong(b);
                    break;
                case "P207 ":
                    checkMaPhong(b);
                    break;
                case "P208 ":
                    checkMaPhong(b);
                    break;
                default:
                    break;
            }
        }

        private void LblPhong301_DoubleClick(object sender, EventArgs e)
        {
            Label b = sender as Label;
            switch (b.Text)
            {
                case "P301 ":
                    checkMaPhong(b);
                    break;
                case "P302 ":
                    checkMaPhong(b);
                    break;
                case "P303 ":
                    checkMaPhong(b);
                    break;
                case "P304 ":
                    checkMaPhong(b);
                    break;
                default:
                    break;
            }
        }
        private void BarButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormThemThietBi frmThemThietBi = new FormThemThietBi();
            frmThemThietBi.Show();
        }

        private void BarButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Hiện form xóa thiết bị
            FormXoaThietBi frmXoaThietBi = new FormXoaThietBi();
            frmXoaThietBi.Show();
        }

        private void BarButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSuaTB frmSuaThietBi = new FormSuaTB();
            frmSuaThietBi.Show();
        }

        private void BarButtonItem12_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCapNhat frmCapnhat = new FormCapNhat();
            frmCapnhat.ShowDialog();
        }

        private void BarButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDoiMatKhau frmDoiMatKhau = new FormDoiMatKhau();
            frmDoiMatKhau.ShowDialog();
        }

        private void BarButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDoanhThu frmdoanhThu = new FormDoanhThu();
            frmdoanhThu.ShowDialog();
        }
        private void checkCharMaKhach()
        {
            int count = txtMaKH.TextLength;
            for (int i = 0; i < count; i++)
            {
                if (count > 5)
                {
                    MessageBox.Show("Chỉ được nhập 5 kí tự ở trường Mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHoten.Focus();
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
                    txtQueQuan.Focus();
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
                    txtCMND.Focus();
                    break;
                }
            }
        }
        private void TxtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaKH.CharacterCasing = CharacterCasing.Upper;
            checkCharMaKhach();
        }

        private void TxtHoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra có phải là kí tự của control hay không và có pahir là số hay không
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;//Không cho nhập tiếp (set bằng false là cho phép gõ kí tự)
                MessageBox.Show("Vui lòng nhập chữ", "Thông báo");
            }
            else
            {
                
            }
        }

        private void TxtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)//kiển tra kí tự nhập có phải số và có khoảng trắng(số 8) hay không
            {
                e.Handled = true;//Không cho nhập tiếp (set bằng false là cho phép gõ kí tự)
                MessageBox.Show("Vui lòng nhập số");
            }
            checkCharSDT();
        }

        private void TxtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)//kiển tra kí tự nhập có phải số và có khoảng trắng(số 8) hay không
            {
                e.Handled = true;//Không cho nhập tiếp (set bằng false là cho phép gõ kí tự)
                MessageBox.Show("Vui lòng nhập số");
            }
            checkCharCMND();
        }

        private void TxtMaKH_Leave(object sender, EventArgs e)
        {
            txtMaKH.CharacterCasing = CharacterCasing.Upper;
            checkCharMaKhach();
        }
    }
}
