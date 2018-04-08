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
using BUS;
using DAL;

namespace test.View
{
    public partial class frmBaocaothuephong : DevExpress.XtraEditors.XtraForm
    {
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode db = new QLCode();
        private static string makh;
        public frmBaocaothuephong()
        {
            InitializeComponent();

            var query2 = (from n in dl.KhachSans select n.TenKhachSan);
            foreach (string item in query2)
            {
                cbTenks.Items.Add(item);
            }
        }

        private void cbTenks_TextChanged(object sender, EventArgs e)
        {
            if (cbTenphong.Items != null)
            {
                cbTenphong.Items.Clear();
            }
            cbTenphong.Text = "";
            if (cbTenks.Text != "")
            {
                KhachSan ks = dl.KhachSans.Single(a => a.TenKhachSan == cbTenks.Text);
                string maks = ks.MaKhachSan;
                var query = (from n in dl.Phongs where n.MaKS == maks select n.TenPhong);
                foreach (string item in query)
                {
                    cbTenphong.Items.Add(item);
                }
            }
        }

        private void btnLocnhanh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  db.get_thuephong(cbTenphong.Text);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.get_thuephong(txtGiatri.Text);
        }
    }
}