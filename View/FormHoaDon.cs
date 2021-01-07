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
            //foreach (var item in hoaDon)
            //{
            //    int index = dgwHoaDon.Rows.Add();//them vao tung vi tri
            //                                     //xac dinh vi tri cac cot de them du lieu
            //    dgwHoaDon.Rows[index].Cells[0].Value = item.HOPDONG.Mã_phòng;
            //    dgwHoaDon.Rows[index].Cells[1].Value = item.Ngày_lập_hóa_đơn;
            //    dgwHoaDon.Rows[index].Cells[2].Value = item.Số_điện_tháng_trước;
            //    dgwHoaDon.Rows[index].Cells[3].Value = item.Số_điện_tháng_này;
            //    dgwHoaDon.Rows[index].Cells[4].Value = item.Khách_hàng.Sđt;
            //    dgwHoaDon.Rows[index].Cells[5].Value = item.Khách_hàng.CMND;
            //    dgwHoaDon.Rows[index].Cells[6].Value = item.Khách_hàng.Quê_quán;
            //    dgwHoaDon.Rows[index].Cells[7].Value = item.Khách_hàng.Giới_tính;
            //}
            string query = "select * from DSKhachHang";
            DataConnection.Instance.ExcData(query);
            DataConnection.Instance.readData(query);
            dgvHoaDon.DataSource = DataConnection.Instance.readData(query);
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