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
    public partial class frmHome_Ks : DevExpress.XtraEditors.XtraForm
    {
        QLCode db = new QLCode();
        public frmHome_Ks()
        {
            InitializeComponent();

            dataGridView1.DataSource = db.get_ttks();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.search_ttks(txtGiatri.Text);
        }
    }
}