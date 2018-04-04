namespace test.View
{
    partial class frmQLkhachsan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLkhachsan));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnIn = new DevComponents.DotNetBar.ButtonX();
            this.btnTimkiem = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiatri = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaKhachSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpqlks = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.cbMaql = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtDiachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbMaql = new DevComponents.DotNetBar.LabelX();
            this.lbMaks = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txtTenks = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dpqlks.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(231, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnIn);
            this.splitContainer1.Panel1.Controls.Add(this.btnTimkiem);
            this.splitContainer1.Panel1.Controls.Add(this.labelX2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(793, 493);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.TabIndex = 6;
            // 
            // btnIn
            // 
            this.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnIn.Location = new System.Drawing.Point(696, 62);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(85, 51);
            this.btnIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIn.TabIndex = 9;
            this.btnIn.Text = "IN";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnTimkiem.Location = new System.Drawing.Point(590, 62);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(100, 51);
            this.btnTimkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimkiem.TabIndex = 8;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Blue;
            this.labelX2.Location = new System.Drawing.Point(80, 14);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(486, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Thông tin khách sạn";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtGiatri);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(80, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm khách sạn";
            // 
            // txtGiatri
            // 
            this.txtGiatri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtGiatri.Border.Class = "TextBoxBorder";
            this.txtGiatri.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiatri.Location = new System.Drawing.Point(185, 20);
            this.txtGiatri.Name = "txtGiatri";
            this.txtGiatri.PreventEnterBeep = true;
            this.txtGiatri.Size = new System.Drawing.Size(275, 21);
            this.txtGiatri.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(10, 20);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(169, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Nhập thông tin tìm kiếm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhachSan,
            this.TenKhachSan,
            this.DiaChi,
            this.MaNQL});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 351);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaKhachSan
            // 
            this.MaKhachSan.DataPropertyName = "MaKhachSan";
            this.MaKhachSan.HeaderText = "#";
            this.MaKhachSan.Name = "MaKhachSan";
            this.MaKhachSan.Visible = false;
            this.MaKhachSan.Width = 50;
            // 
            // TenKhachSan
            // 
            this.TenKhachSan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhachSan.DataPropertyName = "TenKhachSan";
            this.TenKhachSan.FillWeight = 72.68041F;
            this.TenKhachSan.HeaderText = "Tên khách sạn";
            this.TenKhachSan.Name = "TenKhachSan";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.FillWeight = 72.68041F;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // MaNQL
            // 
            this.MaNQL.DataPropertyName = "MaNQL";
            this.MaNQL.FillWeight = 154.6392F;
            this.MaNQL.HeaderText = "#";
            this.MaNQL.Name = "MaNQL";
            this.MaNQL.Visible = false;
            this.MaNQL.Width = 50;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpqlks});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dpqlks
            // 
            this.dpqlks.Controls.Add(this.dockPanel1_Container);
            this.dpqlks.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dpqlks.ID = new System.Guid("5dc47b77-5ccb-4078-b5dd-59be360973cb");
            this.dpqlks.Location = new System.Drawing.Point(0, 0);
            this.dpqlks.Name = "dpqlks";
            this.dpqlks.OriginalSize = new System.Drawing.Size(231, 200);
            this.dpqlks.Size = new System.Drawing.Size(231, 493);
            this.dpqlks.Text = "Quản lý dữ liệu khách sạn";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.cbMaql);
            this.dockPanel1_Container.Controls.Add(this.btnXoa);
            this.dockPanel1_Container.Controls.Add(this.btnSua);
            this.dockPanel1_Container.Controls.Add(this.btnThem);
            this.dockPanel1_Container.Controls.Add(this.labelX8);
            this.dockPanel1_Container.Controls.Add(this.txtDiachi);
            this.dockPanel1_Container.Controls.Add(this.txtMaks);
            this.dockPanel1_Container.Controls.Add(this.lbMaql);
            this.dockPanel1_Container.Controls.Add(this.lbMaks);
            this.dockPanel1_Container.Controls.Add(this.labelX12);
            this.dockPanel1_Container.Controls.Add(this.txtTenks);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(223, 466);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // cbMaql
            // 
            this.cbMaql.DisplayMember = "Text";
            this.cbMaql.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaql.FormattingEnabled = true;
            this.cbMaql.ItemHeight = 16;
            this.cbMaql.Location = new System.Drawing.Point(98, 153);
            this.cbMaql.Name = "cbMaql";
            this.cbMaql.Size = new System.Drawing.Size(103, 22);
            this.cbMaql.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMaql.TabIndex = 33;
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnXoa.Location = new System.Drawing.Point(8, 366);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 41);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnSua.Location = new System.Drawing.Point(117, 366);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 41);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnThem.Location = new System.Drawing.Point(62, 309);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 42);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(15, 44);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 22;
            this.labelX8.Text = "Tên khách sạn";
            // 
            // txtDiachi
            // 
            // 
            // 
            // 
            this.txtDiachi.Border.Class = "TextBoxBorder";
            this.txtDiachi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiachi.Location = new System.Drawing.Point(96, 95);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.PreventEnterBeep = true;
            this.txtDiachi.Size = new System.Drawing.Size(104, 21);
            this.txtDiachi.TabIndex = 23;
            // 
            // txtMaks
            // 
            // 
            // 
            // 
            this.txtMaks.Border.Class = "TextBoxBorder";
            this.txtMaks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaks.Location = new System.Drawing.Point(96, 203);
            this.txtMaks.Name = "txtMaks";
            this.txtMaks.PreventEnterBeep = true;
            this.txtMaks.Size = new System.Drawing.Size(104, 21);
            this.txtMaks.TabIndex = 20;
            this.txtMaks.Visible = false;
            // 
            // lbMaql
            // 
            // 
            // 
            // 
            this.lbMaql.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbMaql.Location = new System.Drawing.Point(16, 152);
            this.lbMaql.Name = "lbMaql";
            this.lbMaql.Size = new System.Drawing.Size(75, 23);
            this.lbMaql.TabIndex = 24;
            this.lbMaql.Text = "Mã quản lý";
            // 
            // lbMaks
            // 
            // 
            // 
            // 
            this.lbMaks.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbMaks.Location = new System.Drawing.Point(15, 203);
            this.lbMaks.Name = "lbMaks";
            this.lbMaks.Size = new System.Drawing.Size(75, 23);
            this.lbMaks.TabIndex = 19;
            this.lbMaks.Text = "Mã khách sạn";
            this.lbMaks.Visible = false;
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(15, 93);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(75, 23);
            this.labelX12.TabIndex = 21;
            this.labelX12.Text = "Địa chỉ";
            // 
            // txtTenks
            // 
            // 
            // 
            // 
            this.txtTenks.Border.Class = "TextBoxBorder";
            this.txtTenks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenks.Location = new System.Drawing.Point(96, 45);
            this.txtTenks.Name = "txtTenks";
            this.txtTenks.PreventEnterBeep = true;
            this.txtTenks.Size = new System.Drawing.Size(105, 21);
            this.txtTenks.TabIndex = 25;
            // 
            // frmQLkhachsan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 493);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dpqlks);
            this.Name = "frmQLkhachsan";
            this.Text = "Quản lý khách sạn";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dpqlks.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiatri;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.ButtonX btnIn;
        private DevComponents.DotNetBar.ButtonX btnTimkiem;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dpqlks;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiachi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaks;
        private DevComponents.DotNetBar.LabelX lbMaql;
        private DevComponents.DotNetBar.LabelX lbMaks;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenks;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNQL;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMaql;
    }
}