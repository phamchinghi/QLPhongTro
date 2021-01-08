using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace QL_PhongTro 
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormChiTietPhong());
            Application.Run(new FormTrangChu());
            //Application.Run(new FormLogin());
            //Application.Run(new FormThemKhachTro());
            //Application.Run(new FormThemThietBi());
            //Application.Run(new FormXoaKhachTro());
            //Application.Run(new FormXoaThietBi());
            //Application.Run(new FormSuaKhachTro());
            //Application.Run(new FormSuaTB());
            //Application.Run(new FormDoiMatKhau());
            //Application.Run(new FormCapNhat());
            //Application.Run(new FormDSKhachTro());
            //Application.Run(new FormDSThietBi());
            //Application.Run(new FormHoaDon());
        }
    }
}
