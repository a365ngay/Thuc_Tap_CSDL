using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace test.View
{
    public partial class frmHome : DevExpress.XtraEditors.XtraForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            frmHome_sddv ttks = new frmHome_sddv();
            if (frmMain.idlogin == "1" || frmMain.idlogin == "2" || frmMain.idlogin == "3")
            {
                ttks.Show();
            }
        }

        private void btnKhachsan_Click(object sender, EventArgs e)
        {
            frmHome_Ks ttks = new frmHome_Ks();
            ttks.Show();
        }

        private void btnDatphong_Click(object sender, EventArgs e)
        {
            
        }
    }
}