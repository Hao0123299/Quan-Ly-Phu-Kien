namespace GUI
{
    partial class Nhanvien
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
            this.groupBoxThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.dtgvThongTin = new System.Windows.Forms.DataGridView();
            this.sHOPDataSet = new GUI.SHOPDataSet();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sHOPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxThongTinNhanVien.SuspendLayout();
            this.groupBoxThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxThongTinNhanVien
            // 
            this.groupBoxThongTinNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxThongTinNhanVien.Controls.Add(this.txtCMND);
            this.groupBoxThongTinNhanVien.Controls.Add(this.lblCMND);
            this.groupBoxThongTinNhanVien.Controls.Add(this.txtSoDT);
            this.groupBoxThongTinNhanVien.Controls.Add(this.lblSoDT);
            this.groupBoxThongTinNhanVien.Controls.Add(this.txtHoTen);
            this.groupBoxThongTinNhanVien.Controls.Add(this.lblHoTen);
            this.groupBoxThongTinNhanVien.Controls.Add(this.txtMa);
            this.groupBoxThongTinNhanVien.Controls.Add(this.lblMa);
            this.groupBoxThongTinNhanVien.Location = new System.Drawing.Point(12, 2);
            this.groupBoxThongTinNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxThongTinNhanVien.Name = "groupBoxThongTinNhanVien";
            this.groupBoxThongTinNhanVien.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxThongTinNhanVien.Size = new System.Drawing.Size(999, 70);
            this.groupBoxThongTinNhanVien.TabIndex = 0;
            this.groupBoxThongTinNhanVien.TabStop = false;
            this.groupBoxThongTinNhanVien.Text = "Thông tin nhân vien";
            // 
            // txtCMND
            // 
            this.txtCMND.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCMND.Location = new System.Drawing.Point(786, 31);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(144, 21);
            this.txtCMND.TabIndex = 4;
            // 
            // lblCMND
            // 
            this.lblCMND.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(703, 31);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(64, 13);
            this.lblCMND.TabIndex = 0;
            this.lblCMND.Text = "Chứng minh";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoDT.Location = new System.Drawing.Point(549, 31);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(144, 21);
            this.txtSoDT.TabIndex = 3;
            // 
            // lblSoDT
            // 
            this.lblSoDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(463, 31);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(69, 13);
            this.lblSoDT.TabIndex = 0;
            this.lblSoDT.Text = "Số điện thoại";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHoTen.Location = new System.Drawing.Point(309, 31);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(144, 21);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(255, 31);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(39, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtMa
            // 
            this.txtMa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMa.Location = new System.Drawing.Point(101, 31);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(144, 21);
            this.txtMa.TabIndex = 1;
            // 
            // lblMa
            // 
            this.lblMa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(14, 31);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(71, 13);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã nhân viên";
            // 
            // groupBoxThongTinChiTiet
            // 
            this.groupBoxThongTinChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxThongTinChiTiet.Controls.Add(this.dtgvThongTin);
            this.groupBoxThongTinChiTiet.Location = new System.Drawing.Point(12, 14);
            this.groupBoxThongTinChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            this.groupBoxThongTinChiTiet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxThongTinChiTiet.Size = new System.Drawing.Size(999, 311);
            this.groupBoxThongTinChiTiet.TabIndex = 1;
            this.groupBoxThongTinChiTiet.TabStop = false;
            this.groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // dtgvThongTin
            // 
            this.dtgvThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThongTin.Location = new System.Drawing.Point(6, 20);
            this.dtgvThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvThongTin.Name = "dtgvThongTin";
            this.dtgvThongTin.RowTemplate.Height = 24;
            this.dtgvThongTin.Size = new System.Drawing.Size(993, 291);
            this.dtgvThongTin.TabIndex = 0;
            this.dtgvThongTin.Click += new System.EventHandler(this.dtgvThongTin_Click);
            // 
            // sHOPDataSet
            // 
            this.sHOPDataSet.DataSetName = "SHOPDataSet";
            this.sHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnXem
            // 
            this.btnXem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXem.Location = new System.Drawing.Point(271, 8);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(86, 73);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Location = new System.Drawing.Point(379, 8);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 73);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Location = new System.Drawing.Point(487, 8);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 73);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Location = new System.Drawing.Point(595, 8);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 73);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBoxThongTinNhanVien);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 81);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnXem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Location = new System.Drawing.Point(10, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 93);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.groupBoxThongTinChiTiet);
            this.panel3.Location = new System.Drawing.Point(10, 200);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1025, 325);
            this.panel3.TabIndex = 5;
            // 
            // sHOPDataSetBindingSource
            // 
            this.sHOPDataSetBindingSource.AllowNew = true;
            this.sHOPDataSetBindingSource.DataSource = this.sHOPDataSet;
            this.sHOPDataSetBindingSource.Position = 0;
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 535);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Nhanvien";
            this.Text = "Nhân viên";
            this.groupBoxThongTinNhanVien.ResumeLayout(false);
            this.groupBoxThongTinNhanVien.PerformLayout();
            this.groupBoxThongTinChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sHOPDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTinNhanVien;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvThongTin;
        private SHOPDataSet sHOPDataSet;
        public System.Windows.Forms.BindingSource sHOPDataSetBindingSource;
    }
}