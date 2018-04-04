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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Diagnostics;
using System.IO;
using BUS;
using DAL;

namespace test.View
{
    public partial class frmQlnv : DevExpress.XtraEditors.XtraForm
    {
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode db = new QLCode();
        public static string ma1;
        public frmQlnv()
        {
            InitializeComponent();

            if (frmMain.idlogin == "3")
            {
                lbmanv.Visible = true;
                lbmaql.Visible = true;
                txtManv.Visible = true;
                txtMaks.Visible = true;

                var query1 = (from n in dl.KhachSans select n.MaKhachSan).Distinct();
                foreach (string item in query1)
                {
                    txtMaks.Items.Add(item);
                }
            }
            else
            {
                lbmanv.Visible = false;
                lbmaql.Visible = false;
                txtManv.Visible = false;
                txtMaks.Visible = false;
            }
            if (frmMain.idlogin == "2" || frmMain.idlogin == "3")
            {
                dpQlnv.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }
            else
            {
                dpQlnv.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            }
            var query = (from n in dl.NhanViens select n.ChucVu).Distinct();
            foreach (string item in query)
            {
                cbCv.Items.Add(item);
            }

            var query2 = (from n in dl.KhachSans select n.TenKhachSan).Distinct();
            foreach (string item in query2)
            {
                cbMaks.Items.Add(item);
            }

            dataGridView1.DataSource = db.get_nv();
        }

        public void export2Execl(DataGridView dg)
        {
            string tentep = "";
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < dg.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = dg.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                for (int j = 0; j < dg.Columns.Count; j++)
                {
                    if (dg.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            SaveFileDialog fsave = new SaveFileDialog();
            fsave.Filter = "(Tất cả các tệp)|*.*|(Các tệp excel)|*.xlsx";
            fsave.ShowDialog();
            if (fsave.FileName != null)
            {
                tentep = fsave.FileName;
                obj.ActiveWorkbook.SaveAs(tentep);
                obj.ActiveWorkbook.Saved = true;
                //Process.Start(tentep, Path.GetFileName(fsave.FileName));
                ProcessStartInfo info = new ProcessStartInfo(fsave.FileName + ".xlsx");
                Process.Start(info);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            export2Execl(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManv.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            ma1 = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["TenNV"].Value == null)
            {
                txtTen.Text = "";
            }
            else
            {
                txtTen.Text = dataGridView1.CurrentRow.Cells["TenNV"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["NgaySinh"].Value == null)
            {
                dtpNs.Text = "";
            }
            else
            {
                dtpNs.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["Gioitinh"].Value == null)
            {
                cbGt.Text = "";
            }
            else
            {
                cbGt.Text = dataGridView1.CurrentRow.Cells["Gioitinh"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["SoCMT"].Value == null)
            {
                txtCmt.Text = "";
            }
            else
            {
                txtCmt.Text = dataGridView1.CurrentRow.Cells["SoCMT"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["SoDT"].Value == null)
            {
                txtSdt.Text = "";
            }
            else
            {
                txtSdt.Text = dataGridView1.CurrentRow.Cells["SoDT"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["QueQuan"].Value == null)
            {
                txtQuequan.Text = "";
            }
            else
            {
                txtQuequan.Text = dataGridView1.CurrentRow.Cells["QueQuan"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["ChucVu"].Value == null)
            {
                txtCvu.Text = "";
            }
            else
            {
                txtCvu.Text = dataGridView1.CurrentRow.Cells["ChucVu"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["Luong"].Value == null)
            {
                txtLuong.Text = "";
            }
            else
            {
                txtLuong.Text = dataGridView1.CurrentRow.Cells["Luong"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["MaKS"].Value == null)
            {
                txtMaks.Text = "";
            }
            else
            {
                txtMaks.Text = dataGridView1.CurrentRow.Cells["MaKS"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.delete_nv(txtManv.Text);
                dataGridView1.DataSource = db.get_nv();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn sửa nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.edit_nv(ma1, txtManv.Text, txtTen.Text, dtpNs.Text, cbGt.Text, txtCmt.Text, txtSdt.Text, txtQuequan.Text, txtCvu.Text, txtLuong.Text, txtMaks.Text);
            }
            dataGridView1.DataSource = db.get_nv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemnv themnv = null;
            Check_Them:
            if (themnv == null || themnv.IsDisposed)
            {
                themnv = new frmThemnv();
            }
            if (themnv.ShowDialog() == DialogResult.OK)
            {
                if (frmThemnv.x == 0)
                {
                    goto Check_Them;
                }
            }
            dataGridView1.DataSource = db.get_nv();
        }
        
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.search_nv(txtGiatri.Text);
        }

        private void cbGt2_TextChanged(object sender, EventArgs e)
        {
            if (cbCv.Text == "" && cbMaks.Text == "")
            {
                dataGridView1.DataSource = db.search_nv(cbGt2.Text);
            }
            if (cbCv.Text != "" && cbMaks.Text == "")
            {
                dataGridView1.DataSource = db.search_nv(cbGt2.Text, cbCv.Text);
            }
            if(cbCv.Text == "" && cbMaks.Text != "")
            {
                KhachSan ks = dl.KhachSans.Single(a => a.TenKhachSan == cbMaks.Text);
                string maks = ks.MaKhachSan;
                dataGridView1.DataSource = db.search_nv(cbGt2.Text, maks);
            }
            if (cbCv.Text != "" && cbGt2.Text != "" && cbMaks.Text != "")
            {
                KhachSan ks = dl.KhachSans.Single(a => a.TenKhachSan == cbMaks.Text);
                string maks = ks.MaKhachSan;
                dataGridView1.DataSource = db.search_nv(cbGt2.Text, cbCv.Text, maks);
            }
        }

        private void cbCv_TextChanged(object sender, EventArgs e)
        {
            if (cbGt2.Text == "" && cbMaks.Text == "")
            {
                dataGridView1.DataSource = db.search_nv(cbCv.Text);
            }
            if (cbGt2.Text != "" && cbMaks.Text == "")
            {
                dataGridView1.DataSource = db.search_nv(cbGt2.Text, cbCv.Text);
            }
            if (cbGt2.Text == "" && cbMaks.Text != "")
            {
                KhachSan ks = dl.KhachSans.Single(a => a.TenKhachSan == cbMaks.Text);
                string maks = ks.MaKhachSan;
                dataGridView1.DataSource = db.search_nv(maks, cbCv.Text);
            }
            if(cbCv.Text != "" && cbGt2.Text != "" && cbMaks.Text != "")
            {
                KhachSan ks = dl.KhachSans.Single(a => a.TenKhachSan == cbMaks.Text);
                string maks = ks.MaKhachSan;
                dataGridView1.DataSource = db.search_nv(cbGt2.Text, cbCv.Text, maks);
            }
        }

        private void cbMaks_TextChanged(object sender, EventArgs e)
        {
            if (cbMaks.Text != "" && cbGt2.Text == "" && cbCv.Text == "")
            {
                KhachSan ks = dl.KhachSans.Single(a => a.TenKhachSan == cbMaks.Text);
                string maks = ks.MaKhachSan;
                dataGridView1.DataSource = db.search_nv(maks);
            }
            if (cbMaks.Text != "" && cbGt2.Text != "" && cbCv.Text == "")
            {
                KhachSan ks = dl.KhachSans.Single(a => a.TenKhachSan == cbMaks.Text);
                string maks = ks.MaKhachSan;
                dataGridView1.DataSource = db.search_nv(cbGt2.Text, maks);
            }
            if (cbMaks.Text != "" && cbGt2.Text == "" && cbCv.Text != "")
            {
                KhachSan ks = dl.KhachSans.Single(a => a.TenKhachSan == cbMaks.Text);
                string maks = ks.MaKhachSan;
                dataGridView1.DataSource = db.search_nv(maks, cbCv.Text);
            }
            if (cbMaks.Text != "" && cbGt2.Text != "" && cbMaks.Text != "")
            {
                KhachSan ks = dl.KhachSans.Single(a => a.TenKhachSan == cbMaks.Text);
                string maks = ks.MaKhachSan;
                dataGridView1.DataSource = db.search_nv(cbGt2.Text, cbCv.Text, maks);
            }
        }
    }
}