using QL_PhongTro.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QL_PhongTro
{
    public partial class FormChiTietPhong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DB_QLPhongTro DB = new DB_QLPhongTro();
        public FormChiTietPhong()
        {
            InitializeComponent();
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Metropolis";
        }

        private void FormChiTietPhong_Load(object sender, EventArgs e)
        {
            skin();
            cbXeMay.SelectedIndex = 0;
            cbXeMay2.SelectedIndex = cbXeMay.SelectedIndex;
            //Lay thang cua he thong gan vao groupbox
            DateTime mon = DateTime.Now;
            gbThangSau.Text = "Tháng " + mon.Month.ToString();
            if((mon.Month - 1) == 0)
            {
                gbThangTruoc.Text = "Tháng " + "12";
            }
            else
            {
                gbThangTruoc.Text = "Tháng " + (mon.Month - 1).ToString();
            }
            bbtnThanhToan.Enabled = false;
            bbtnThuePhong.Enabled = false;
            bbtnGiuCho.Enabled = false;
            bbtnLuu.Enabled = false;
            bbtnTraPhong.Enabled = false;
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bbtnThuePhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormThemKhachTro frmThemKhachTro = new FormThemKhachTro();
            frmThemKhachTro.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}