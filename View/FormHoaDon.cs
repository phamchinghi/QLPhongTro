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
    public partial class FormHoaDon : DevExpress.XtraEditors.XtraForm
    {
        DB_QLPhongTro DB = new DB_QLPhongTro();
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            Skins();
            try
            {
                //List<Khách_hàng> listKhachtros = DB.Khách_hàng.ToList();//lay danh sach khach hang
                List<Hóa_đơn> HD = DB.Hóa_đơn.ToList();
                BindingGrid(HD);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BindingGrid(List<Hóa_đơn> hoaDon)
        {

            dgvHoaDon.Rows.Clear();
            foreach (var item in hoaDon)
            {
                int giaDien = item.Điện.Giá_điện * (item.Số_điện_tháng_này - item.Số_điện_tháng_trước);
                int giaNuoc = item.Nước.Giá_nước * (item.Số_nước_tháng_này - item.Số_nước_tháng_trước);
                int giaRac = item.Rác.Giá_rác;
                int giaWifi = item.Wifi.Giá_wifi; ;
                int giaXe = item.Xe.Giá_xe;
                int giaPhong = item.HOPDONG.Phòng.Giá_phòng;
                int index = dgvHoaDon.Rows.Add();//them vao tung vi tri
                                                 //xac dinh vi tri cac cot de them du lieu
                dgvHoaDon.Rows[index].Cells[0].Value = item.HOPDONG.Mã_phòng;
                dgvHoaDon.Rows[index].Cells[1].Value = item.Ngày_lập_hóa_đơn.ToShortDateString();
                dgvHoaDon.Rows[index].Cells[2].Value = item.Số_điện_tháng_trước;
                dgvHoaDon.Rows[index].Cells[3].Value = item.Số_điện_tháng_này;
                dgvHoaDon.Rows[index].Cells[4].Value = item.Số_nước_tháng_trước;
                dgvHoaDon.Rows[index].Cells[5].Value = item.Số_nước_tháng_này;
                dgvHoaDon.Rows[index].Cells[6].Value = giaDien;//item.Điện.Giá_điện * (item.Số_điện_tháng_này - item.Số_điện_tháng_trước);
                dgvHoaDon.Rows[index].Cells[7].Value = giaNuoc;//item.Nước.Giá_nước * (item.Số_nước_tháng_này - item.Số_nước_tháng_trước);
                dgvHoaDon.Rows[index].Cells[8].Value = giaRac;//item.Rác.Giá_rác;
                dgvHoaDon.Rows[index].Cells[9].Value = giaWifi;//item.Wifi.Giá_wifi;
                dgvHoaDon.Rows[index].Cells[10].Value = giaXe;//item.Xe.Giá_xe;
                dgvHoaDon.Rows[index].Cells[11].Value = item.HOPDONG.Phòng.Giá_phòng;
                dgvHoaDon.Rows[index].Cells[12].Value = giaDien + giaNuoc + giaRac + giaWifi + giaXe + giaPhong;
            }

            //string query = "select dbo.HOPDONG.[Mã phòng],dbo.[Hóa đơn].[Ngày lập hóa đơn],[Số điện tháng trước],[Số điện tháng này]," +
            //             "[Số nước tháng trước],[Số nước tháng này],([Số điện tháng này] - [Số điện tháng trước])*dbo.Điện.[Giá điện] as [Tiền điện],"+
            //             "([Số nước tháng này]-[Số nước tháng trước])*dbo.Nước.[Giá nước] as [Tiền nước],dbo.Rác.[Giá rác],dbo.Wifi.[Giá wifi],dbo.Xe.[Giá xe], dbo.Phòng.[Giá phòng],"+
            //             "(([Số điện tháng này] - [Số điện tháng trước])*dbo.Điện.[Giá điện]) + (([Số nước tháng này]-[Số nước tháng trước])*dbo.Nước.[Giá nước]) + (dbo.Rác.[Giá rác]) + (dbo.Wifi.[Giá wifi]) + dbo.Xe.[Giá xe] + dbo.Phòng.[Giá phòng] as [tổng tiền]" +
            //             "      from(((((((dbo.[Hóa đơn]" +
            //             "          inner join dbo.HOPDONG on dbo.HOPDONG.SoHD = dbo.[Hóa đơn].SoHD) " +
            //             "          inner join dbo.Điện on dbo.[Hóa đơn].[Mã điện] = dbo.Điện.[Mã điện])" +
            //             "			inner join dbo.Nước on dbo.[Hóa đơn].[Mã nước] = dbo.Nước.[Mã nước])" +
            //             "			inner join dbo.Rác on dbo.[Hóa đơn].[Mã rác] = dbo.Rác.[Mã rác])" +
            //             "			inner join dbo.Wifi on dbo.[Hóa đơn].[Mã wifi] = dbo.Wifi.[Mã wifi])" +
            //             "			inner join dbo.Xe on dbo.[Hóa đơn].[Mã xe] = dbo.Xe.[Mã xe])" +
            //             "          inner join dbo.Phòng on dbo.HOPDONG.[Mã phòng] = dbo.Phòng.[Mã phòng])" +
            //             " go";
            //DataConnection.Instance.ExcData(query);
            //DataConnection.Instance.readData(query);
            //dgvHoaDon.DataSource = DataConnection.Instance.readData(query);
        }



        public void Skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Metropolis";
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {

        }
    }
}