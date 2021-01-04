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
    public partial class FormDSThietBi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormDSThietBi()
        {
            InitializeComponent();
        }
        void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Metropolis";
        }
        private void BarButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void FormDSThietBi_Load(object sender, EventArgs e)
        {
            skin();
        }
    }
}