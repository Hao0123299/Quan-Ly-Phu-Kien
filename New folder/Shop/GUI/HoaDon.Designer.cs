namespace GUI
{
    partial class HoaDon
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHoaDon = new System.Windows.Forms.TextBox();
            this.lblSOHD = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvDSHH = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvDSHD1 = new System.Windows.Forms.DataGridView();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sHOP2DataSet2 = new GUI.SHOP2DataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNhanVienLap = new System.Windows.Forms.Label();
            this.lblSoHoaDon = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.txtSoHoaDon = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hOADONTableAdapter = new GUI.SHOP2DataSet2TableAdapters.HOADONTableAdapter();
            this.sOHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHOP2DataSet5 = new GUI.SHOP2DataSet5();
            this.cTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTHDTableAdapter = new GUI.SHOP2DataSet5TableAdapters.CTHDTableAdapter();
            this.sOHDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHH)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOP2DataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sHOP2DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtHoaDon);
            this.groupBox3.Controls.Add(this.lblSOHD);
            this.groupBox3.Controls.Add(this.txtSL);
            this.groupBox3.Controls.Add(this.lblSoLuong);
            this.groupBox3.Controls.Add(this.txtMaSP);
            this.groupBox3.Controls.Add(this.lblMaSP);
            this.groupBox3.Location = new System.Drawing.Point(3, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(458, 92);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // txtHoaDon
            // 
            this.txtHoaDon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTHDBindingSource, "SOHD", true));
            this.txtHoaDon.Location = new System.Drawing.Point(147, 19);
            this.txtHoaDon.Name = "txtHoaDon";
            this.txtHoaDon.Size = new System.Drawing.Size(259, 21);
            this.txtHoaDon.TabIndex = 0;
            // 
            // lblSOHD
            // 
            this.lblSOHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSOHD.AutoSize = true;
            this.lblSOHD.Location = new System.Drawing.Point(70, 23);
            this.lblSOHD.Name = "lblSOHD";
            this.lblSOHD.Size = new System.Drawing.Size(61, 13);
            this.lblSOHD.TabIndex = 1;
            this.lblSOHD.Text = "Số hóa đơn";
            // 
            // txtSL
            // 
            this.txtSL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTHDBindingSource, "SL", true));
            this.txtSL.Location = new System.Drawing.Point(353, 47);
            this.txtSL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(56, 21);
            this.txtSL.TabIndex = 2;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(289, 50);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(49, 13);
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaSP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTHDBindingSource, "MASP", true));
            this.txtMaSP.Location = new System.Drawing.Point(145, 47);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(138, 21);
            this.txtMaSP.TabIndex = 1;
            // 
            // lblMaSP
            // 
            this.lblMaSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(70, 50);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(70, 13);
            this.lblMaSP.TabIndex = 1;
            this.lblMaSP.Text = "Mã sản phẩm";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dtgvDSHH);
            this.groupBox4.Location = new System.Drawing.Point(9, 161);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(452, 412);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hàng hóa";
            // 
            // dtgvDSHH
            // 
            this.dtgvDSHH.AllowUserToAddRows = false;
            this.dtgvDSHH.AllowUserToDeleteRows = false;
            this.dtgvDSHH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDSHH.AutoGenerateColumns = false;
            this.dtgvDSHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sOHDDataGridViewTextBoxColumn1,
            this.mASPDataGridViewTextBoxColumn,
            this.sLDataGridViewTextBoxColumn});
            this.dtgvDSHH.DataSource = this.cTHDBindingSource;
            this.dtgvDSHH.Location = new System.Drawing.Point(6, 16);
            this.dtgvDSHH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvDSHH.Name = "dtgvDSHH";
            this.dtgvDSHH.ReadOnly = true;
            this.dtgvDSHH.Size = new System.Drawing.Size(440, 392);
            this.dtgvDSHH.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(246, 104);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 51);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm chi tiết hóa đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHoaDon.Location = new System.Drawing.Point(252, 102);
            this.btnThemHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(64, 55);
            this.btnThemHoaDon.TabIndex = 7;
            this.btnThemHoaDon.Text = "Thêm thông tin hóa đơn";
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgvDSHD1);
            this.groupBox2.Location = new System.Drawing.Point(3, 161);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(545, 414);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dtgvDSHD1
            // 
            this.dtgvDSHD1.AllowUserToAddRows = false;
            this.dtgvDSHD1.AllowUserToDeleteRows = false;
            this.dtgvDSHD1.AutoGenerateColumns = false;
            this.dtgvDSHD1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHD1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHD1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sOHDDataGridViewTextBoxColumn,
            this.mANVDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn});
            this.dtgvDSHD1.DataSource = this.hOADONBindingSource;
            this.dtgvDSHD1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSHD1.Location = new System.Drawing.Point(3, 16);
            this.dtgvDSHD1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvDSHD1.Name = "dtgvDSHD1";
            this.dtgvDSHD1.ReadOnly = true;
            this.dtgvDSHD1.Size = new System.Drawing.Size(539, 396);
            this.dtgvDSHD1.TabIndex = 0;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.sHOP2DataSet2;
            // 
            // sHOP2DataSet2
            // 
            this.sHOP2DataSet2.DataSetName = "SHOP2DataSet2";
            this.sHOP2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNhanVienLap);
            this.groupBox1.Controls.Add(this.lblSoHoaDon);
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.txtSoHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(545, 92);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "SOLUONG", true));
            this.txtSoLuong.Location = new System.Drawing.Point(126, 52);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(187, 21);
            this.txtSoLuong.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số lượng";
            // 
            // lblNhanVienLap
            // 
            this.lblNhanVienLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNhanVienLap.AutoSize = true;
            this.lblNhanVienLap.Location = new System.Drawing.Point(336, 28);
            this.lblNhanVienLap.Name = "lblNhanVienLap";
            this.lblNhanVienLap.Size = new System.Drawing.Size(72, 13);
            this.lblNhanVienLap.TabIndex = 1;
            this.lblNhanVienLap.Text = "Nhân viên lập";
            // 
            // lblSoHoaDon
            // 
            this.lblSoHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSoHoaDon.AutoSize = true;
            this.lblSoHoaDon.Location = new System.Drawing.Point(50, 28);
            this.lblSoHoaDon.Name = "lblSoHoaDon";
            this.lblSoHoaDon.Size = new System.Drawing.Size(61, 13);
            this.lblSoHoaDon.TabIndex = 1;
            this.lblSoHoaDon.Text = "Số hóa đơn";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MANV", true));
            this.txtNhanVien.Location = new System.Drawing.Point(417, 26);
            this.txtNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(92, 21);
            this.txtNhanVien.TabIndex = 2;
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoHoaDon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "SOHD", true));
            this.txtSoHoaDon.Location = new System.Drawing.Point(126, 26);
            this.txtSoHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(188, 21);
            this.txtSoHoaDon.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Location = new System.Drawing.Point(175, 104);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(64, 51);
            this.btnXem.TabIndex = 12;
            this.btnXem.Text = "Xem chi tiết hóa đơn";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemThongTin.Location = new System.Drawing.Point(172, 102);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(64, 55);
            this.btnXemThongTin.TabIndex = 13;
            this.btnXemThongTin.Text = "Xem thông tin hóa đơn";
            this.btnXemThongTin.UseVisualStyleBackColor = true;
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btnXemThongTin);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnThemHoaDon);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 577);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnXem);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(574, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 577);
            this.panel2.TabIndex = 15;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // sOHDDataGridViewTextBoxColumn
            // 
            this.sOHDDataGridViewTextBoxColumn.DataPropertyName = "SOHD";
            this.sOHDDataGridViewTextBoxColumn.HeaderText = "Số hóa đơn";
            this.sOHDDataGridViewTextBoxColumn.Name = "sOHDDataGridViewTextBoxColumn";
            this.sOHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            this.sOLUONGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sHOP2DataSet5
            // 
            this.sHOP2DataSet5.DataSetName = "SHOP2DataSet5";
            this.sHOP2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTHDBindingSource
            // 
            this.cTHDBindingSource.DataMember = "CTHD";
            this.cTHDBindingSource.DataSource = this.sHOP2DataSet5;
            // 
            // cTHDTableAdapter
            // 
            this.cTHDTableAdapter.ClearBeforeFill = true;
            // 
            // sOHDDataGridViewTextBoxColumn1
            // 
            this.sOHDDataGridViewTextBoxColumn1.DataPropertyName = "SOHD";
            this.sOHDDataGridViewTextBoxColumn1.HeaderText = "Số hóa đơn";
            this.sOHDDataGridViewTextBoxColumn1.Name = "sOHDDataGridViewTextBoxColumn1";
            this.sOHDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mASPDataGridViewTextBoxColumn
            // 
            this.mASPDataGridViewTextBoxColumn.DataPropertyName = "MASP";
            this.mASPDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.mASPDataGridViewTextBoxColumn.Name = "mASPDataGridViewTextBoxColumn";
            this.mASPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sLDataGridViewTextBoxColumn
            // 
            this.sLDataGridViewTextBoxColumn.DataPropertyName = "SL";
            this.sLDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sLDataGridViewTextBoxColumn.Name = "sLDataGridViewTextBoxColumn";
            this.sLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HoaDon";
            this.ShowInTaskbar = false;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOP2DataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sHOP2DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvDSHH;
        private System.Windows.Forms.Label lblSOHD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvDSHD1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNhanVienLap;
        private System.Windows.Forms.Label lblSoHoaDon;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.TextBox txtSoHoaDon;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private SHOP2DataSet2 sHOP2DataSet2;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private SHOP2DataSet2TableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private SHOP2DataSet5 sHOP2DataSet5;
        private System.Windows.Forms.BindingSource cTHDBindingSource;
        private SHOP2DataSet5TableAdapters.CTHDTableAdapter cTHDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOHDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDataGridViewTextBoxColumn;
    }
}