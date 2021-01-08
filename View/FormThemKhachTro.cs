using DevExpress.XtraEditors;
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
    public partial class FormThemKhachTro : DevExpress.XtraEditors.XtraForm
    {
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
        }
        void checkChar()
        {
            int count = txtMaKhach.Text.Length;
           for(int i = 0; i < count; i++)
           {
                if(count == 10)
                {
                    MessageBox.Show("You entered 10 characters");
                    break;
                }else if(count > 10)
                {
                    MessageBox.Show("Nhap du");
                    break;
                }
           }

        }
        private void TxtMaKhach_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtMaKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtMaKhach_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}