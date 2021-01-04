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
                List<DỊch_vụ> listdv = DB.DỊch_vụ.ToList();
                Bingrid(listdv);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void Bingrid(List<DỊch_vụ> listdv)
        {
            foreach(TextBox txt in pnlGiaTruoc.Controls)
            {
                txt.ReadOnly = true;
            }
            DỊch_vụ dbDien = DB.DỊch_vụ.FirstOrDefault(p => p.Mã_DV == "DD");
            txtGiaDienTruoc.Text = dbDien.Giá_DV.ToString().Trim();

            DỊch_vụ dbNuoc = DB.DỊch_vụ.FirstOrDefault(p => p.Mã_DV == "NN");
            txtGiaNuocTruoc.Text = dbNuoc.Giá_DV.ToString().Trim();

            DỊch_vụ dbWifi = DB.DỊch_vụ.FirstOrDefault(p => p.Mã_DV == "WF");
            txtGiaWifiTruoc.Text = dbWifi.Giá_DV.ToString().Trim();

            DỊch_vụ dbXe = DB.DỊch_vụ.FirstOrDefault(p => p.Mã_DV == "GX");
            txtGiaXeTruoc.Text = dbXe.Giá_DV.ToString().Trim();

            DỊch_vụ dbRac = DB.DỊch_vụ.FirstOrDefault(p => p.Mã_DV == "RC");
            txtGiaRacTruoc.Text = dbRac.Giá_DV.ToString().Trim();
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCapnhat_Click_1(object sender, EventArgs e)
        {
            List<DỊch_vụ> listDV = DB.DỊch_vụ.ToList();
            DỊch_vụ dbGiaDien = DB.DỊch_vụ.FirstOrDefault(p => p.Mã_DV == "DD");
            DỊch_vụ dbGiaNuoc = DB.DỊch_vụ.FirstOrDefault(p => p.Mã_DV == "NN");
            DỊch_vụ dbGiaXe = DB.DỊch_vụ.FirstOrDefault(p => p.Mã_DV == "GX");
            DỊch_vụ dbWifi = DB.DỊch_vụ.FirstOrDefault(p => p.Mã_DV == "WF");
            DỊch_vụ dbRac = DB.DỊch_vụ.FirstOrDefault(p => p.Mã_DV == "RC");

            dbGiaDien.Giá_DV = int.Parse(txtGiaDienSau.Text);
            dbGiaNuoc.Giá_DV = int.Parse(txtGiaNuocSau.Text);
            dbGiaXe.Giá_DV = int.Parse(txtGiaXeSau.Text);
            dbWifi.Giá_DV = int.Parse(txtGiaWifiSau.Text);
            dbRac.Giá_DV = int.Parse(txtGiaRacSau.Text);
            DB.SaveChanges();
            foreach(TextBox txt in pnlSau.Controls)
            {
                txt.Clear();
            }
            Bingrid(listDV);
            MessageBox.Show("Cập nhật thành công","Thông báo");
        }
    }
}