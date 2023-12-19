namespace BTL
{
    partial class Quản_Lý_Nhân_Viên
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quản_Lý_Nhân_Viên));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtTenNv = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtMaNv = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblMaPb = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblTenNv = new System.Windows.Forms.Label();
            this.lblMaNv = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTieude = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.id_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1001, 607);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 300);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 39);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Trở lại";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.btnExportExcel);
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.dtpNgaysinh);
            this.panel2.Controls.Add(this.txtTenNv);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.txtLuong);
            this.panel2.Controls.Add(this.txtDiachi);
            this.panel2.Controls.Add(this.txtMaNv);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.lblMaPb);
            this.panel2.Controls.Add(this.lblLuong);
            this.panel2.Controls.Add(this.lblNgaysinh);
            this.panel2.Controls.Add(this.lblTenNv);
            this.panel2.Controls.Add(this.lblMaNv);
            this.panel2.Controls.Add(this.lblDiachi);
            this.panel2.Controls.Add(this.lblTieude);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(143, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 300);
            this.panel2.TabIndex = 1;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.Location = new System.Drawing.Point(587, 249);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(100, 38);
            this.btnExportExcel.TabIndex = 21;
            this.btnExportExcel.Text = "Xuất ";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.Location = new System.Drawing.Point(79, 249);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(109, 38);
            this.btnreset.TabIndex = 20;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaysinh.Location = new System.Drawing.Point(152, 151);
            this.dtpNgaysinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(200, 29);
            this.dtpNgaysinh.TabIndex = 6;
            this.dtpNgaysinh.ValueChanged += new System.EventHandler(this.dtpNgaysinh_ValueChanged);
            // 
            // txtTenNv
            // 
            this.txtTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNv.Location = new System.Drawing.Point(152, 112);
            this.txtTenNv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNv.Name = "txtTenNv";
            this.txtTenNv.Size = new System.Drawing.Size(197, 29);
            this.txtTenNv.TabIndex = 4;
            this.txtTenNv.TextChanged += new System.EventHandler(this.txtTenNv_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(183, 193);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 29);
            this.txtSearch.TabIndex = 8;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLuong.Location = new System.Drawing.Point(541, 110);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(197, 29);
            this.txtLuong.TabIndex = 12;
            this.txtLuong.TextChanged += new System.EventHandler(this.txtLuong_TextChanged);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiachi.Location = new System.Drawing.Point(541, 59);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(197, 29);
            this.txtDiachi.TabIndex = 10;
            this.txtDiachi.TextChanged += new System.EventHandler(this.txtDiachi_TextChanged);
            // 
            // txtMaNv
            // 
            this.txtMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNv.Location = new System.Drawing.Point(152, 64);
            this.txtMaNv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(197, 29);
            this.txtMaNv.TabIndex = 2;
            this.txtMaNv.TextChanged += new System.EventHandler(this.txtMaNv_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(461, 249);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 38);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(341, 249);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 38);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(211, 249);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 38);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.Location = new System.Drawing.Point(47, 188);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(128, 34);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // lblMaPb
            // 
            this.lblMaPb.AutoSize = true;
            this.lblMaPb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaPb.Location = new System.Drawing.Point(469, 159);
            this.lblMaPb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPb.Name = "lblMaPb";
            this.lblMaPb.Size = new System.Drawing.Size(35, 24);
            this.lblMaPb.TabIndex = 13;
            this.lblMaPb.Text = "Ca";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLuong.Location = new System.Drawing.Point(404, 114);
            this.lblLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(69, 24);
            this.lblLuong.TabIndex = 11;
            this.lblLuong.Text = "Lương";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaysinh.Location = new System.Drawing.Point(35, 155);
            this.lblNgaysinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(103, 24);
            this.lblNgaysinh.TabIndex = 5;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblTenNv
            // 
            this.lblTenNv.AutoSize = true;
            this.lblTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenNv.Location = new System.Drawing.Point(48, 112);
            this.lblTenNv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNv.Name = "lblTenNv";
            this.lblTenNv.Size = new System.Drawing.Size(72, 24);
            this.lblTenNv.TabIndex = 3;
            this.lblTenNv.Text = "Họ tên";
            // 
            // lblMaNv
            // 
            this.lblMaNv.AutoSize = true;
            this.lblMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaNv.Location = new System.Drawing.Point(48, 64);
            this.lblMaNv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNv.Name = "lblMaNv";
            this.lblMaNv.Size = new System.Drawing.Size(73, 24);
            this.lblMaNv.TabIndex = 1;
            this.lblMaNv.Text = "Mã NV";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiachi.Location = new System.Drawing.Point(404, 64);
            this.lblDiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(74, 24);
            this.lblDiachi.TabIndex = 9;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblTieude
            // 
            this.lblTieude.AutoSize = true;
            this.lblTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieude.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTieude.Location = new System.Drawing.Point(267, 10);
            this.lblTieude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(219, 29);
            this.lblTieude.TabIndex = 0;
            this.lblTieude.Text = "Quản lý nhân viên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvNhanVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(143, 312);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 229);
            this.panel3.TabIndex = 2;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Nv,
            this.nam_Nv,
            this.ngaysinh_Nv,
            this.diachi_Nv,
            this.luong_Nv,
            this.Ca});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.Size = new System.Drawing.Size(753, 229);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // id_Nv
            // 
            this.id_Nv.DataPropertyName = "id_Nv";
            this.id_Nv.HeaderText = "Mã NV";
            this.id_Nv.MinimumWidth = 6;
            this.id_Nv.Name = "id_Nv";
            this.id_Nv.ReadOnly = true;
            this.id_Nv.Width = 70;
            // 
            // nam_Nv
            // 
            this.nam_Nv.DataPropertyName = "name_Nv";
            this.nam_Nv.HeaderText = "Họ Tên";
            this.nam_Nv.MinimumWidth = 6;
            this.nam_Nv.Name = "nam_Nv";
            this.nam_Nv.ReadOnly = true;
            this.nam_Nv.Width = 125;
            // 
            // ngaysinh_Nv
            // 
            this.ngaysinh_Nv.DataPropertyName = "ngaysinh_Nv";
            this.ngaysinh_Nv.HeaderText = "Ngày sinh";
            this.ngaysinh_Nv.MinimumWidth = 6;
            this.ngaysinh_Nv.Name = "ngaysinh_Nv";
            this.ngaysinh_Nv.ReadOnly = true;
            this.ngaysinh_Nv.Width = 80;
            // 
            // diachi_Nv
            // 
            this.diachi_Nv.DataPropertyName = "diachi_Nv";
            this.diachi_Nv.HeaderText = "Địa chỉ";
            this.diachi_Nv.MinimumWidth = 6;
            this.diachi_Nv.Name = "diachi_Nv";
            this.diachi_Nv.ReadOnly = true;
            this.diachi_Nv.Width = 80;
            // 
            // luong_Nv
            // 
            this.luong_Nv.DataPropertyName = "luong_Nv";
            this.luong_Nv.HeaderText = "Lương";
            this.luong_Nv.MinimumWidth = 6;
            this.luong_Nv.Name = "luong_Nv";
            this.luong_Nv.ReadOnly = true;
            this.luong_Nv.Width = 70;
            // 
            // Ca
            // 
            this.Ca.HeaderText = "Ca";
            this.Ca.MinimumWidth = 6;
            this.Ca.Name = "Ca";
            this.Ca.ReadOnly = true;
            this.Ca.Width = 125;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(143, 549);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(753, 54);
            this.panel4.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(541, 159);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 21);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sáng";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(541, 189);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 21);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Trưa";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(541, 222);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(49, 21);
            this.radioButton3.TabIndex = 24;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Tối";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Quản_Lý_Nhân_Viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 607);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Quản_Lý_Nhân_Viên";
            this.Text = "Quản_Lý_Nhân_Viên";
            this.Load += new System.EventHandler(this.Quản_Lý_Nhân_Viên_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtTenNv;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblMaPb;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblTenNv;
        private System.Windows.Forms.Label lblMaNv;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTieude;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}