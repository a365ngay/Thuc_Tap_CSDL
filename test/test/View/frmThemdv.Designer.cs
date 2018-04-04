namespace test.View
{
    partial class frmThemdv
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMadv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbMadv = new DevComponents.DotNetBar.LabelX();
            this.txtGiadv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTendv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.cbLoaidv = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLoaidv);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.txtMadv);
            this.groupBox1.Controls.Add(this.lbMadv);
            this.groupBox1.Controls.Add(this.txtGiadv);
            this.groupBox1.Controls.Add(this.txtTendv);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // txtMadv
            // 
            // 
            // 
            // 
            this.txtMadv.Border.Class = "TextBoxBorder";
            this.txtMadv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMadv.Location = new System.Drawing.Point(141, 186);
            this.txtMadv.Name = "txtMadv";
            this.txtMadv.PreventEnterBeep = true;
            this.txtMadv.Size = new System.Drawing.Size(109, 21);
            this.txtMadv.TabIndex = 11;
            // 
            // lbMadv
            // 
            // 
            // 
            // 
            this.lbMadv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbMadv.Location = new System.Drawing.Point(44, 186);
            this.lbMadv.Name = "lbMadv";
            this.lbMadv.Size = new System.Drawing.Size(75, 23);
            this.lbMadv.TabIndex = 10;
            this.lbMadv.Text = "Mã dịch vụ";
            // 
            // txtGiadv
            // 
            // 
            // 
            // 
            this.txtGiadv.Border.Class = "TextBoxBorder";
            this.txtGiadv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiadv.Location = new System.Drawing.Point(141, 80);
            this.txtGiadv.Name = "txtGiadv";
            this.txtGiadv.PreventEnterBeep = true;
            this.txtGiadv.Size = new System.Drawing.Size(109, 21);
            this.txtGiadv.TabIndex = 9;
            // 
            // txtTendv
            // 
            // 
            // 
            // 
            this.txtTendv.Border.Class = "TextBoxBorder";
            this.txtTendv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTendv.Location = new System.Drawing.Point(141, 29);
            this.txtTendv.Name = "txtTendv";
            this.txtTendv.PreventEnterBeep = true;
            this.txtTendv.Size = new System.Drawing.Size(109, 21);
            this.txtTendv.TabIndex = 7;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(44, 80);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Giá dịch vụ";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(44, 29);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Tên dịch vụ";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(241, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(134, 284);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.TabIndex = 32;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbLoaidv
            // 
            this.cbLoaidv.DisplayMember = "Text";
            this.cbLoaidv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaidv.FormattingEnabled = true;
            this.cbLoaidv.ItemHeight = 16;
            this.cbLoaidv.Location = new System.Drawing.Point(141, 136);
            this.cbLoaidv.Name = "cbLoaidv";
            this.cbLoaidv.Size = new System.Drawing.Size(109, 22);
            this.cbLoaidv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLoaidv.TabIndex = 44;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(44, 134);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 43;
            this.labelX5.Text = "Loại dịch vụ";
            // 
            // frmThemdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 333);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThemdv";
            this.Text = "Thêm dịch vụ";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMadv;
        private DevComponents.DotNetBar.LabelX lbMadv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiadv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTendv;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLoaidv;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}