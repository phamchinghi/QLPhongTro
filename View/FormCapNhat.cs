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
    public partial class FormCapNhat : DevExpress.XtraEditors.XtraForm
    {
        DB_QLPhongTro DB = new DB_QLPhongTro();
        public FormCapNhat()
        {
            InitializeComponent();
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Metropolis";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCapNhat_Load(object sender, EventArgs e)
        {
            skin();
            try
            {
                Bingrid();
            }
            catch
            {
                MessageBox.Show("Không thể load dữ liệu lên hoặc không có dữ liệu để load","Thông báo");
            }
        }
        private void Bingrid()
        {
            //List<Điện> listDien;
            //List<Nước> listNuoc;
            //List<Wifi> listWifi;
            //List<Rác> listRac;
            //List<Xe> listGiuXe;              
            foreach (TextBox txt in pnlGiaTruoc.Controls)
            {
                txt.ReadOnly = true;
            }
            Điện dbDien = DB.Điện.FirstOrDefault(p => p.Mã_điện == "DD");
            txtGiaDienTruoc.Text = dbDien.Giá_điện.ToString().Trim();

            Nước dbNuoc = DB.Nước.FirstOrDefault(p => p.Mã_nước == "NN");
            txtGiaNuocTruoc.Text = dbNuoc.Giá_nước.ToString().Trim();

            Wifi dbWifi = DB.Wifis.FirstOrDefault(p => p.Mã_wifi == "WF");
            txtGiaWifiTruoc.Text = dbWifi.Giá_wifi.ToString().Trim();

            Xe dbXe = DB.Xes.FirstOrDefault(p => p.Mã_xe == "GX");
            txtGiaXeTruoc.Text = dbXe.Giá_xe.ToString().Trim();

            Rác dbRac = DB.Rác.FirstOrDefault(p => p.Mã_rác == "RC");
            txtGiaRacTruoc.Text = dbRac.Giá_rác.ToString().Trim();
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCapnhat_Click_1(object sender, EventArgs e)
        {
            if(txtGiaDienSau.Text != "" || txtGiaNuocSau.Text != "" || txtGiaRacSau.Text != "" || txtGiaWifiSau.Text != "" | txtGiaXeSau.Text != "")
            {
                //List<Điện> listDV = DB.DỊch_vụ.ToList();
                Điện dbGiaDien = DB.Điện.FirstOrDefault(p => p.Mã_điện == "DD");
                Nước dbGiaNuoc = DB.Nước.FirstOrDefault(p => p.Mã_nước == "NN");
                Xe dbGiaXe = DB.Xes.FirstOrDefault(p => p.Mã_xe== "GX");
                Wifi dbWifi = DB.Wifis.FirstOrDefault(p => p.Mã_wifi == "WF");
                Rác dbRac = DB.Rác.FirstOrDefault(p => p.Mã_rác == "RC");

                dbGiaDien.Giá_điện = int.Parse(txtGiaDienSau.Text);
                dbGiaNuoc.Giá_nước = int.Parse(txtGiaNuocSau.Text);
                dbGiaXe.Giá_xe     = int.Parse(txtGiaXeSau.Text);
                dbWifi.Giá_wifi    = int.Parse(txtGiaWifiSau.Text);
                dbRac.Giá_rác      = int.Parse(txtGiaRacSau.Text);
                DB.SaveChanges();
                foreach(TextBox txt in pnlSau.Controls)
                {
                    txt.Clear();
                }
                Bingrid();
                MessageBox.Show("Cập nhật thành công","Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}