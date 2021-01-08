using QL_PhongTro.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void BtnT1P1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Metropolis";
        }
        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            //FormLogin frmLogin = new FormLogin();
            //frmLogin.ShowDialog();
            skin();
            try
            {
                //List<Khách_hàng> listKhachtros = DB.Khách_hàng.ToList();//lay danh sach khach hang
                List<HOPDONG> HOPDONG = DB.HOPDONGs.ToList();
                BindingGrid(HOPDONG);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void BindingGrid( List<HOPDONG> hopDongs)
        {
            dgvTrangChu.Rows.Clear();
           foreach (var item in hopDongs)
           {
                    int index = dgvTrangChu.Rows.Add();//them vao tung vi tri
                    //xac dinh vi tri cac cot de them du lieu
                dgvTrangChu.Rows[index].Cells[0].Value = item.Mã_KH;
                dgvTrangChu.Rows[index].Cells[1].Value = item.Mã_phòng;
                dgvTrangChu.Rows[index].Cells[2].Value = item.Khách_hàng.Tên_KH;
                dgvTrangChu.Rows[index].Cells[3].Value = item.Khách_hàng.Năm_sinh.ToShortDateString();
                dgvTrangChu.Rows[index].Cells[4].Value = item.Khách_hàng.Sđt;
                dgvTrangChu.Rows[index].Cells[5].Value = item.Khách_hàng.CMND;
                dgvTrangChu.Rows[index].Cells[6].Value = item.Khách_hàng.Quê_quán;
                dgvTrangChu.Rows[index].Cells[7].Value = item.Khách_hàng.Giới_tính;
           }
        }
        private void BindingDataPhong(List<HOPDONG> hopDongs,Label lbl)
        {
            dgvTrangChu.Rows.Clear();//clear du lieu grid
            foreach (var item in hopDongs)
            {
                int index = dgvTrangChu.Rows.Add();
                if(item.Mã_phòng == lbl.Text)
                {
                    dgvTrangChu.Rows[index].Cells[0].Value = item.Mã_KH;
                    dgvTrangChu.Rows[index].Cells[1].Value = item.Mã_phòng;
                    dgvTrangChu.Rows[index].Cells[2].Value = item.Khách_hàng.Tên_KH;
                    dgvTrangChu.Rows[index].Cells[3].Value = item.Khách_hàng.Năm_sinh.ToShortDateString();
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
        private void checkDataPhong(List<HOPDONG> hopDongs, Label lbl)
        {
            foreach(var item in hopDongs)
            {
                if(dgvTrangChu.Rows.Count > 0)
                {

                }
            }
        }
        private void lblPhong101_Click(object sender, EventArgs e)
        {
            Label b = sender as Label;
            List<HOPDONG> HOPDONG = DB.HOPDONGs.ToList();
            switch (b.Text)
            {
                case "P101 ":
                    lblChiTietSoPhong.Text = "101";
                    lblDientich.Text = "20";
                    lblGiaPhong.Text = "2,300,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P102 ":
                    lblChiTietSoPhong.Text = "102";
                    lblDientich.Text = "20";
                    lblGiaPhong.Text = "2,300,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P103 ":
                    lblChiTietSoPhong.Text = "103";
                    lblDientich.Text = "20";
                    lblGiaPhong.Text = "2,300,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P104 ":
                    lblChiTietSoPhong.Text = "104";
                    lblDientich.Text = "20";
                    lblGiaPhong.Text = "2,300,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P105 ":
                    lblChiTietSoPhong.Text = "105";
                    lblDientich.Text = "20";
                    lblGiaPhong.Text = "2,300,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P106 ":
                    lblChiTietSoPhong.Text = "106";
                    lblDientich.Text = "25";
                    lblGiaPhong.Text = "2,500,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P107 ":
                    lblChiTietSoPhong.Text = "107";
                    lblDientich.Text = "25";
                    lblGiaPhong.Text = "2,500,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P108 ":
                    lblChiTietSoPhong.Text = "108";
                    lblDientich.Text = "20";
                    lblGiaPhong.Text = "2,300,000";
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
                    lblChiTietSoPhong.Text = "201";
                    lblDientich.Text = "30";
                    lblGiaPhong.Text = "3,000,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P202 ":
                    lblChiTietSoPhong.Text = "202";
                    lblDientich.Text = "30";
                    lblGiaPhong.Text = "3,000,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P203 ":
                    lblChiTietSoPhong.Text = "203";
                    lblDientich.Text = "25";
                    lblGiaPhong.Text = "2,500,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P204 ":
                    lblChiTietSoPhong.Text = "204";
                    lblDientich.Text = "25";
                    lblGiaPhong.Text = "2,500,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P205 ":
                    lblChiTietSoPhong.Text = "205";
                    lblDientich.Text = "25";
                    lblGiaPhong.Text = "2,500,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P206 ":
                    lblChiTietSoPhong.Text = "206";
                    lblDientich.Text = "25";
                    lblGiaPhong.Text = "2,500,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P207 ":
                    lblChiTietSoPhong.Text = "207";
                    lblDientich.Text = "25";
                    lblGiaPhong.Text = "2,500,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P208 ":
                    lblChiTietSoPhong.Text = "208";
                    lblDientich.Text = "30";
                    lblGiaPhong.Text = "2,500,000";
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
                    lblChiTietSoPhong.Text = "301";
                    lblDientich.Text = "35";
                    lblGiaPhong.Text = "3,500,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P302 ":
                    lblChiTietSoPhong.Text = "302";
                    lblDientich.Text = "35";
                    lblGiaPhong.Text = "3,500,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P303 ":
                    lblChiTietSoPhong.Text = "303";
                    lblDientich.Text = "35";
                    lblGiaPhong.Text = "3,500,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                case "P304 ":
                    lblChiTietSoPhong.Text = "304";
                    lblDientich.Text = "35";
                    lblGiaPhong.Text = "3,500,000";
                    BindingDataPhong(HOPDONG, b);
                    break;
                default:
                    break;
            }
        }
        private void Button15_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FormDSThietBi().Show();
        }

        private void BarButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Button22_Click(object sender, EventArgs e)
        {
        }

    
      
        //các thao tác quản lý khách
        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDSKhachTro frmKhachTro = new FormDSKhachTro();
            frmKhachTro.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormThemKhachTro frmThemKhachTro = new FormThemKhachTro();
            frmThemKhachTro.Show();
        }
        private void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormXoaKhachTro frmXoaKhachTro = new FormXoaKhachTro();
            frmXoaKhachTro.ShowDialog();
        }

        private void BarButtonItem5_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSuaKhachTro frmSuaKhachTro = new FormSuaKhachTro();
            frmSuaKhachTro.Show();
        }
        private void RibbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void TclTang1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }


        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void LblPhong103_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void LblPhong104_Click(object sender, EventArgs e)
        {

        }

        private void DgvTrangChu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LblPhong101_DoubleClick(object sender, EventArgs e)
        {
            FormChiTietPhong frmChiTietPhong = new FormChiTietPhong();
            frmChiTietPhong.ShowDialog();
        }

        private void BarButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Hiện form thêm thiết bị
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

    }
}
