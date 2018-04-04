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
    public partial class frmTinhtrangphong : DevExpress.XtraEditors.XtraForm
    {
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode db = new QLCode();
        public frmTinhtrangphong()
        {
            InitializeComponent();

            dataGridView1.DataSource = db.get_ttphong();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.search_ttphong(txtGiatri.Text);
        }

        private void btnTinhtrangphong_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn sửa tình trạng phòng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.edit_ttphong(txtTenphong.Text, cbTinhtrangphong.Text);
            }
            dataGridView1.DataSource = db.get_ttphong();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenphong.Text = dataGridView1.CurrentRow.Cells["TenPhong"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["TinhTrangPhong"].Value == null)
            {
                cbTinhtrangphong.Text = "";
            }
            else
            {
                cbTinhtrangphong.Text = dataGridView1.CurrentRow.Cells["TinhTrangPhong"].Value.ToString();
            }
        }
    }
}