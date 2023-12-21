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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 644);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 342);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btnExportExcel);
            this.panel2.Controls.Add(this.btnreset);
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
            this.panel2.Location = new System.Drawing.Point(107, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 342);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(582, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 25;
            this.button1.Text = "Xuất ALL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(453, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "SDT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(389, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.Location = new System.Drawing.Point(453, 289);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(75, 31);
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
            this.btnreset.Location = new System.Drawing.Point(12, 289);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(82, 31);
            this.btnreset.TabIndex = 20;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txtTenNv
            // 
            this.txtTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNv.Location = new System.Drawing.Point(114, 91);
            this.txtTenNv.Name = "txtTenNv";
            this.txtTenNv.Size = new System.Drawing.Size(149, 24);
            this.txtTenNv.TabIndex = 4;
            this.txtTenNv.TextChanged += new System.EventHandler(this.txtTenNv_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(140, 232);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 24);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLuong.Location = new System.Drawing.Point(406, 105);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(188, 24);
            this.txtLuong.TabIndex = 12;
            this.txtLuong.TextChanged += new System.EventHandler(this.txtLuong_TextChanged);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiachi.Location = new System.Drawing.Point(406, 52);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(188, 24);
            this.txtDiachi.TabIndex = 10;
            this.txtDiachi.TextChanged += new System.EventHandler(this.txtDiachi_TextChanged);
            // 
            // txtMaNv
            // 
            this.txtMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNv.Location = new System.Drawing.Point(114, 52);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(149, 24);
            this.txtMaNv.TabIndex = 2;
            this.txtMaNv.TextChanged += new System.EventHandler(this.txtMaNv_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(346, 289);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(229, 289);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(114, 289);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 31);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.Location = new System.Drawing.Point(29, 230);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(96, 28);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lblMaPb
            // 
            this.lblMaPb.AutoSize = true;
            this.lblMaPb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaPb.Location = new System.Drawing.Point(334, 150);
            this.lblMaPb.Name = "lblMaPb";
            this.lblMaPb.Size = new System.Drawing.Size(29, 18);
            this.lblMaPb.TabIndex = 13;
            this.lblMaPb.Text = "Ca";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLuong.Location = new System.Drawing.Point(334, 108);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(54, 18);
            this.lblLuong.TabIndex = 11;
            this.lblLuong.Text = "Lương";
            this.lblLuong.Click += new System.EventHandler(this.lblLuong_Click);
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaysinh.Location = new System.Drawing.Point(26, 146);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(82, 18);
            this.lblNgaysinh.TabIndex = 5;
            this.lblNgaysinh.Text = "Ngày sinh";
            this.lblNgaysinh.Click += new System.EventHandler(this.lblNgaysinh_Click);
            // 
            // lblTenNv
            // 
            this.lblTenNv.AutoSize = true;
            this.lblTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenNv.Location = new System.Drawing.Point(36, 91);
            this.lblTenNv.Name = "lblTenNv";
            this.lblTenNv.Size = new System.Drawing.Size(58, 18);
            this.lblTenNv.TabIndex = 3;
            this.lblTenNv.Text = "Họ tên";
            // 
            // lblMaNv
            // 
            this.lblMaNv.AutoSize = true;
            this.lblMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaNv.Location = new System.Drawing.Point(36, 52);
            this.lblMaNv.Name = "lblMaNv";
            this.lblMaNv.Size = new System.Drawing.Size(58, 18);
            this.lblMaNv.TabIndex = 1;
            this.lblMaNv.Text = "Mã NV";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiachi.Location = new System.Drawing.Point(334, 55);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(60, 18);
            this.lblDiachi.TabIndex = 9;
            this.lblDiachi.Text = "Địa chỉ";
            this.lblDiachi.Click += new System.EventHandler(this.lblDiachi_Click);
            // 
            // lblTieude
            // 
            this.lblTieude.AutoSize = true;
            this.lblTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieude.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTieude.Location = new System.Drawing.Point(241, 8);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(180, 24);
            this.lblTieude.TabIndex = 0;
            this.lblTieude.Text = "Quản lý nhân viên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvNhanVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(107, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(718, 240);
            this.panel3.TabIndex = 2;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.Size = new System.Drawing.Size(718, 240);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(107, 597);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 44);
            this.panel4.TabIndex = 3;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaysinh.Location = new System.Drawing.Point(114, 140);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(151, 24);
            this.dtpNgaysinh.TabIndex = 6;
            this.dtpNgaysinh.ValueChanged += new System.EventHandler(this.dtpNgaysinh_ValueChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Trở lại";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 26;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Quản_Lý_Nhân_Viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 644);
            this.Controls.Add(this.tableLayoutPanel1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Label label2;
    }
}