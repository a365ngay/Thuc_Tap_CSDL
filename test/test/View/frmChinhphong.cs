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
    public partial class frmChinhphong : DevExpress.XtraEditors.XtraForm
    {
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode code = new QLCode();
        public static int x;
        public frmChinhphong()
        {
            InitializeComponent();


            var query1 = (from n in dl.Phongs select n.LoaiPhong).Distinct();
            foreach (string item in query1)
            {
                cbLoaiphong.Items.Add(item);
            }
        }

        private void cbLoaiphong_TextChanged(object sender, EventArgs e)
        {
            var query1 = (from n in dl.Phongs where n.LoaiPhong == cbLoaiphong.Text select n.GiaPhong).Distinct();
            foreach (int item in query1)
            {
                txtGiaphong.Text = item.ToString();
            }
            txtLoaiphong2.Text = cbLoaiphong.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn sửa loại phòng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                 x = code.edit_loai_phong(cbLoaiphong.Text, txtLoaiphong2.Text, txtGiaphong2.Text);
            }
        }
    }
}