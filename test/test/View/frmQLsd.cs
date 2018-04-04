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

namespace test.View
{
    public partial class frmQLsd : DevExpress.XtraEditors.XtraForm
    {
        QLCode db = new QLCode();
        public frmQLsd()
        {
            InitializeComponent();

            dataGridView1.DataSource = db.get_user();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtPass.Text = dataGridView1.CurrentRow.Cells["Pass"].Value.ToString();
            cbQuyen.Text = dataGridView1.CurrentRow.Cells["Quyen"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            db.edit_user(txtName.Text, txtPass.Text, cbQuyen.Text);
            dataGridView1.DataSource = db.get_user();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            db.delete_user(txtName.Text);
            dataGridView1.DataSource = db.get_user();
        }
    }
}