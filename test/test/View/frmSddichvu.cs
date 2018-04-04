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
    public partial class frmSddichvu : DevExpress.XtraEditors.XtraForm
    {
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode db = new QLCode();
        public static string makh;
        public static string mahd;
        public static string tenkh;
        public static string tendvbd;

        public frmSddichvu()
        {
            InitializeComponent();

            if(frmMain.idlogin == "3")
            {
                lbMakh.Visible = true;
                txtMakh.Visible = true;
                lbMahd.Visible = true;
                txtMahd.Visible = true;
            }
            else
            {
                lbMakh.Visible = false;
                txtMakh.Visible = false;
                lbMahd.Visible = false;
                txtMahd.Visible = false;
            }

            var query3 = (from n in dl.KhachHangs select n.TenKH);
            foreach (string item in query3)
            {
                cbTenkh.Items.Add(item);
            }

            var query2 = (from n in dl.DichVus select n.TenDV);
            foreach (string item in query2)
            {
                cbTendv.Items.Add(item);
            }

            dataGridView1.DataSource = db.get_sddv();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["MaHD"].Value == null)
            {
                txtMahd.Text = "";
            }
            else
            {
                txtMahd.Text = dataGridView1.CurrentRow.Cells["MaHD"].Value.ToString();
                mahd = txtMahd.Text;
            }
            if (dataGridView1.CurrentRow.Cells["MaKH"].Value == null)
            {
                txtMakh.Text = "";
            }
            else
            {
                txtMakh.Text = dataGridView1.CurrentRow.Cells["MaKH"].Value.ToString();
                makh = txtMakh.Text;
            }
            if (dataGridView1.CurrentRow.Cells["TenKH"].Value == null)
            {
                cbTenkh.Text = "";
            }
            else
            {
                cbTenkh.Text = dataGridView1.CurrentRow.Cells["TenKH"].Value.ToString();
                tenkh = cbTenkh.Text;
            }
            if (dataGridView1.CurrentRow.Cells["TenDV"].Value == null)
            {
                cbTendv.Text = "";
            }
            else
            {
                cbTendv.Text = dataGridView1.CurrentRow.Cells["TenDV"].Value.ToString();
                tendvbd = cbTendv.Text;
            }
            if (dataGridView1.CurrentRow.Cells["SoLuongDV"].Value == null)
            {
                txtSl.Text = "";
            }
            else
            {
                txtSl.Text = dataGridView1.CurrentRow.Cells["SoLuongDV"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["ThanhTien"].Value == null)
            {
                txtTien.Text = "";
            }
            else
            {
                txtTien.Text = dataGridView1.CurrentRow.Cells["ThanhTien"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["TenNV"].Value == null)
            {
                cbTennv.Text = "";
            }
            else
            {
                cbTennv.Text = dataGridView1.CurrentRow.Cells["TenNV"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["NgayLapHD"].Value == null)
            {
                dtpN.Text = "";
            }
            else
            {
                dtpN.Text = dataGridView1.CurrentRow.Cells["NgayLapHD"].Value.ToString();
            }
        }

        private void cbTendv_TextChanged(object sender, EventArgs e)
        {
            if (cbTennv.Items != null)
            {
                cbTennv.Items.Clear();
            }
            var query4 = (from n in dl.DichVus where n.TenDV == cbTendv.Text select n.LoaiDV).Distinct();
            string x = "";
            foreach (string item1 in query4)
            {
                x = item1;
            }
            var query3 = (from n in dl.NhanViens where n.ChucVu == x select n.TenNV).Distinct();
            foreach (string item2 in query3)
            {
                cbTennv.Items.Add(item2);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmThemngsddv themdv = null;
            Check_Them:
            if (themdv == null || themdv.IsDisposed)
            {
                themdv = new frmThemngsddv();
            }
            if (themdv.ShowDialog() == DialogResult.OK)
            {
                if (frmThemngsddv.x == 0)
                {
                    goto Check_Them;
                }
            }
            dataGridView1.DataSource = db.get_sddv();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmSuasddv themdv = null;
            Check_Them:
            if (themdv == null || themdv.IsDisposed)
            {
                themdv = new frmSuasddv();
            }
            if (themdv.ShowDialog() == DialogResult.OK)
            {
                if (frmSuasddv.x == 0)
                {
                    goto Check_Them;
                }
            }
            dataGridView1.DataSource = db.get_sddv();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmSudungthemdv themdv = null;
            Check_Them:
            if (themdv == null || themdv.IsDisposed)
            {
                themdv = new frmSudungthemdv();
            }
            if (themdv.ShowDialog() == DialogResult.OK)
            {
                if (frmSudungthemdv.x == 0)
                {
                    goto Check_Them;
                }
            }
            dataGridView1.DataSource = db.get_sddv();
        }

        private void txtSl_TextChanged(object sender, EventArgs e)
        {
            if (txtSl.Text != "")
            {
                DichVu dv = dl.DichVus.Single(a => a.TenDV == cbTendv.Text);
                string money = dv.GiaDV.ToString();
                txtTien.Text = Convert.ToString(Convert.ToInt32(money) * Convert.ToInt32(txtSl.Text));
            }
            else
            {
                txtTien.Text = "";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn hủy sử dụng dịch vụ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DichVu dv = dl.DichVus.Single(a => a.TenDV == cbTendv.Text);
                string madv = dv.MaDV;
                db.huy_dv(txtMahd.Text, madv);
                dataGridView1.DataSource = db.get_sddv();
            }
        }
    }
}