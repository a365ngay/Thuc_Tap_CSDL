namespace test.View
{
    partial class frmQLphong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLphong));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtGiatri = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnIn = new DevComponents.DotNetBar.ButtonX();
            this.btnTimkiem = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.txtMaks = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtGiaphong = new System.Windows.Forms.TextBox();
            this.lbMaks = new DevComponents.DotNetBar.LabelX();
            this.btnChinhphong = new DevComponents.DotNetBar.ButtonX();
            this.cbLoaiphong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtTenphong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.cbLoaiphong2 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhong,
            this.LoaiPhong,
            this.GiaPhong,
            this.MaKS});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(967, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.txtGiatri.Size = new System.Drawing.Size(449, 21);
            this.txtGiatri.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnIn.Location = new System.Drawing.Point(870, 62);
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
            this.btnTimkiem.Location = new System.Drawing.Point(764, 62);
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
            this.labelX2.Size = new System.Drawing.Size(660, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Thông tin phòng khách sạn";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtGiatri);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(80, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm phòng khách sạn";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(254, 75);
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
            this.splitContainer1.Size = new System.Drawing.Size(967, 425);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.TabIndex = 8;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1,
            this.dockPanel2});
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
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("4b0081db-ee70-49cb-99cd-7e8895c41066");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(254, 200);
            this.dockPanel1.Size = new System.Drawing.Size(254, 500);
            this.dockPanel1.Text = "Quản lý dữ liệu phòng khách sạn";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.txtMaks);
            this.dockPanel1_Container.Controls.Add(this.txtGiaphong);
            this.dockPanel1_Container.Controls.Add(this.lbMaks);
            this.dockPanel1_Container.Controls.Add(this.btnChinhphong);
            this.dockPanel1_Container.Controls.Add(this.cbLoaiphong);
            this.dockPanel1_Container.Controls.Add(this.labelX5);
            this.dockPanel1_Container.Controls.Add(this.txtTenphong);
            this.dockPanel1_Container.Controls.Add(this.labelX4);
            this.dockPanel1_Container.Controls.Add(this.labelX3);
            this.dockPanel1_Container.Controls.Add(this.btnXoa);
            this.dockPanel1_Container.Controls.Add(this.btnThem);
            this.dockPanel1_Container.Controls.Add(this.btnSua);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(246, 473);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // txtMaks
            // 
            this.txtMaks.DisplayMember = "Text";
            this.txtMaks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtMaks.FormattingEnabled = true;
            this.txtMaks.ItemHeight = 16;
            this.txtMaks.Location = new System.Drawing.Point(101, 216);
            this.txtMaks.Name = "txtMaks";
            this.txtMaks.Size = new System.Drawing.Size(100, 22);
            this.txtMaks.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtMaks.TabIndex = 48;
            // 
            // txtGiaphong
            // 
            this.txtGiaphong.Enabled = false;
            this.txtGiaphong.Location = new System.Drawing.Point(101, 152);
            this.txtGiaphong.Name = "txtGiaphong";
            this.txtGiaphong.Size = new System.Drawing.Size(100, 21);
            this.txtGiaphong.TabIndex = 41;
            // 
            // lbMaks
            // 
            // 
            // 
            // 
            this.lbMaks.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbMaks.Location = new System.Drawing.Point(19, 215);
            this.lbMaks.Name = "lbMaks";
            this.lbMaks.Size = new System.Drawing.Size(75, 23);
            this.lbMaks.TabIndex = 42;
            this.lbMaks.Text = "Mã khách sạn";
            // 
            // btnChinhphong
            // 
            this.btnChinhphong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChinhphong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChinhphong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChinhphong.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnChinhphong.Location = new System.Drawing.Point(19, 281);
            this.btnChinhphong.Name = "btnChinhphong";
            this.btnChinhphong.Size = new System.Drawing.Size(207, 42);
            this.btnChinhphong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChinhphong.TabIndex = 34;
            this.btnChinhphong.Text = "Tùy chỉnh phòng";
            this.btnChinhphong.Click += new System.EventHandler(this.btnChinhphong_Click);
            // 
            // cbLoaiphong
            // 
            this.cbLoaiphong.DisplayMember = "Text";
            this.cbLoaiphong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiphong.FormattingEnabled = true;
            this.cbLoaiphong.ItemHeight = 16;
            this.cbLoaiphong.Location = new System.Drawing.Point(101, 89);
            this.cbLoaiphong.Name = "cbLoaiphong";
            this.cbLoaiphong.Size = new System.Drawing.Size(100, 22);
            this.cbLoaiphong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLoaiphong.TabIndex = 40;
            this.cbLoaiphong.TextChanged += new System.EventHandler(this.cbLoaiphong_TextChanged);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(19, 150);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 38;
            this.labelX5.Text = "Giá phòng";
            // 
            // txtTenphong
            // 
            // 
            // 
            // 
            this.txtTenphong.Border.Class = "TextBoxBorder";
            this.txtTenphong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenphong.Location = new System.Drawing.Point(101, 26);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.PreventEnterBeep = true;
            this.txtTenphong.Size = new System.Drawing.Size(100, 21);
            this.txtTenphong.TabIndex = 37;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(19, 88);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 38;
            this.labelX4.Text = "Loại phòng";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(19, 24);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 36;
            this.labelX3.Text = "Tên phòng";
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnXoa.Location = new System.Drawing.Point(19, 399);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 41);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnThem.Location = new System.Drawing.Point(73, 342);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 42);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnSua.Location = new System.Drawing.Point(128, 399);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 41);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dockPanel2.ID = new System.Guid("18163896-0366-4011-bbc5-4aa2e11e07df");
            this.dockPanel2.Location = new System.Drawing.Point(254, 0);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 75);
            this.dockPanel2.Size = new System.Drawing.Size(967, 75);
            this.dockPanel2.Text = "Tìm kiếm nhanh";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.cbLoaiphong2);
            this.dockPanel2_Container.Controls.Add(this.labelX6);
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(959, 48);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // cbLoaiphong2
            // 
            this.cbLoaiphong2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLoaiphong2.DisplayMember = "Text";
            this.cbLoaiphong2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiphong2.FormattingEnabled = true;
            this.cbLoaiphong2.ItemHeight = 16;
            this.cbLoaiphong2.Location = new System.Drawing.Point(383, 12);
            this.cbLoaiphong2.Name = "cbLoaiphong2";
            this.cbLoaiphong2.Size = new System.Drawing.Size(232, 22);
            this.cbLoaiphong2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLoaiphong2.TabIndex = 42;
            this.cbLoaiphong2.TextChanged += new System.EventHandler(this.comboBoxEx1_TextChanged);
            // 
            // labelX6
            // 
            this.labelX6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(301, 11);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(207, 23);
            this.labelX6.TabIndex = 41;
            this.labelX6.Text = "Loại phòng";
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.Name = "LoaiPhong";
            // 
            // GiaPhong
            // 
            this.GiaPhong.DataPropertyName = "GiaPhong";
            this.GiaPhong.HeaderText = "Giá phòng (VND)";
            this.GiaPhong.Name = "GiaPhong";
            this.GiaPhong.Width = 200;
            // 
            // MaKS
            // 
            this.MaKS.DataPropertyName = "MaKS";
            this.MaKS.HeaderText = "Mã khách sạn";
            this.MaKS.Name = "MaKS";
            this.MaKS.Visible = false;
            // 
            // frmQLphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 500);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dockPanel2);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmQLphong";
            this.Text = "Quản lý phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiatri;
        private DevComponents.DotNetBar.ButtonX btnIn;
        private DevComponents.DotNetBar.ButtonX btnTimkiem;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLoaiphong;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenphong;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnChinhphong;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLoaiphong2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.TextBox txtGiaphong;
        private DevComponents.DotNetBar.LabelX lbMaks;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtMaks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKS;
    }
}