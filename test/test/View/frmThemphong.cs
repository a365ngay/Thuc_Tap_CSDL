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
using DAL;
using BUS;

namespace test.View
{
    public partial class frmThemphong : DevExpress.XtraEditors.XtraForm
    {
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode code = new QLCode();
        public static int x;
        public frmThemphong()
        {
            InitializeComponent();

            var query1 = (from n in dl.Phongs select n.LoaiPhong).Distinct();
            foreach (string item in query1)
            {
                cbLoaiphong.Items.Add(item);
            }

            var query2 = (from n in dl.KhachSans select n.MaKhachSan).Distinct();
            foreach (string item in query2)
            {
                txtMaks.Items.Add(item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtTenphong.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập tên phòng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                x = code.add_phong(txtTenphong.Text, cbLoaiphong.Text, txtGiaphong.Text, txtMaks.Text);
            }
        }

        private void cbLoaiphong_TextChanged(object sender, EventArgs e)
        {
            var query1 = (from n in dl.Phongs where n.LoaiPhong == cbLoaiphong.Text select n.GiaPhong).Distinct();
            foreach (int item in query1)
            {
                txtGiaphong.Text = item.ToString();
            }
        }
    }
}