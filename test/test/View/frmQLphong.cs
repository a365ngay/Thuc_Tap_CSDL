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
    public partial class frmQLphong : DevExpress.XtraEditors.XtraForm
    {
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode db = new QLCode();
        public static string maphongbd;
        public frmQLphong()
        {
            InitializeComponent();

            var query1 = (from n in dl.Phongs select n.LoaiPhong).Distinct();
            foreach (string item in query1)
            {
                cbLoaiphong.Items.Add(item);
                cbLoaiphong2.Items.Add(item);
            }

            var query2 = (from n in dl.KhachSans select n.MaKhachSan).Distinct();
            foreach (string item in query2)
            {
                txtMaks.Items.Add(item);
            }

            dataGridView1.DataSource = db.get_phong();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenphong.Text = dataGridView1.CurrentRow.Cells["TenPhong"].Value.ToString();
            maphongbd = dataGridView1.CurrentRow.Cells["TenPhong"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["LoaiPhong"].Value == null)
            {
                cbLoaiphong.Text = "";
            }
            else
            {
                cbLoaiphong.Text = dataGridView1.CurrentRow.Cells["LoaiPhong"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["GiaPhong"].Value == null)
            {
                txtGiaphong.Text = "";
            }
            else
            {
                txtGiaphong.Text = dataGridView1.CurrentRow.Cells["GiaPhong"].Value.ToString();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemphong themphong = null;
            Check_Them:
            if (themphong == null || themphong.IsDisposed)
            {
                themphong = new frmThemphong();
            }
            if (themphong.ShowDialog() == DialogResult.OK)
            {
                if (frmThemphong.x == 0)
                {
                    goto Check_Them;
                }
            }
            dataGridView1.DataSource = db.get_phong();
        }

        private void btnChinhphong_Click(object sender, EventArgs e)
        {
            frmChinhphong phong = null;
            Check_Them:
            if (phong == null || phong.IsDisposed)
            {
                phong = new frmChinhphong();
            }
            if (phong.ShowDialog() == DialogResult.OK)
            {
                if (frmChinhphong.x == 0)
                {
                    goto Check_Them;
                }
            }
            dataGridView1.DataSource = db.get_phong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa phòng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.delete_phong(txtTenphong.Text);
                dataGridView1.DataSource = db.get_phong();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn sửa phòng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.edit_phong(maphongbd, txtTenphong.Text, cbLoaiphong.Text, txtGiaphong.Text, txtMaks.Text);
                dataGridView1.DataSource = db.get_phong();
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.search_phong(txtGiatri.Text);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            export2Execl(dataGridView1);
        }

        private void comboBoxEx1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  db.search_phong(cbLoaiphong2.Text);
        }
    }
}