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
    public partial class FormSuaTB : DevExpress.XtraEditors.XtraForm
    {
        public FormSuaTB()
        {
            InitializeComponent();
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Metropolis";
        }
        private void FormSuaTB_Load(object sender, EventArgs e)
        {
            skin();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}