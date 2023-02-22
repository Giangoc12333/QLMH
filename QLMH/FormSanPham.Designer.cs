
namespace QLMH
{
    partial class FormSanPham
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.cbbTenDM = new Guna.UI.WinForms.GunaComboBox();
            this.cbbMaDM = new Guna.UI.WinForms.GunaComboBox();
            this.cbbTenNcc = new Guna.UI.WinForms.GunaComboBox();
            this.cbbMaNCC = new Guna.UI.WinForms.GunaComboBox();
            this.txtGia = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSP = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenSP = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            this.dgrSanPham = new System.Windows.Forms.DataGridView();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnKhoiTao = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.TimKiem = new Guna.UI.WinForms.GunaTextBox();
            this.btnTimkiem = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThemDM = new FontAwesome.Sharp.IconButton();
            this.btnThemNCC = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.qLNS_SPDataSet = new QLMH.QLNS_SPDataSet();
            this.qLNSSPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNS_SPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSSPDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(554, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(488, 54);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "THÔNG TIN SẢN PHẨM";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.cbbTenDM);
            this.gunaGroupBox1.Controls.Add(this.cbbMaDM);
            this.gunaGroupBox1.Controls.Add(this.cbbTenNcc);
            this.gunaGroupBox1.Controls.Add(this.cbbMaNCC);
            this.gunaGroupBox1.Controls.Add(this.txtGia);
            this.gunaGroupBox1.Controls.Add(this.label8);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.txtSoLuong);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.txtMaSP);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.label9);
            this.gunaGroupBox1.Controls.Add(this.txtTenSP);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(38, 31);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(710, 457);
            this.gunaGroupBox1.TabIndex = 2;
            this.gunaGroupBox1.Text = "Thông tin sản phẩm";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cbbTenDM
            // 
            this.cbbTenDM.BackColor = System.Drawing.Color.Transparent;
            this.cbbTenDM.BaseColor = System.Drawing.Color.White;
            this.cbbTenDM.BorderColor = System.Drawing.Color.Silver;
            this.cbbTenDM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTenDM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenDM.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTenDM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTenDM.ForeColor = System.Drawing.Color.Black;
            this.cbbTenDM.FormattingEnabled = true;
            this.cbbTenDM.Location = new System.Drawing.Point(473, 210);
            this.cbbTenDM.Name = "cbbTenDM";
            this.cbbTenDM.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbTenDM.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbTenDM.Size = new System.Drawing.Size(185, 26);
            this.cbbTenDM.TabIndex = 15;
            // 
            // cbbMaDM
            // 
            this.cbbMaDM.BackColor = System.Drawing.Color.Transparent;
            this.cbbMaDM.BaseColor = System.Drawing.Color.White;
            this.cbbMaDM.BorderColor = System.Drawing.Color.Silver;
            this.cbbMaDM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaDM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaDM.FocusedColor = System.Drawing.Color.Empty;
            this.cbbMaDM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMaDM.ForeColor = System.Drawing.Color.Black;
            this.cbbMaDM.FormattingEnabled = true;
            this.cbbMaDM.Location = new System.Drawing.Point(473, 160);
            this.cbbMaDM.Name = "cbbMaDM";
            this.cbbMaDM.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbMaDM.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbMaDM.Size = new System.Drawing.Size(185, 26);
            this.cbbMaDM.TabIndex = 13;
            // 
            // cbbTenNcc
            // 
            this.cbbTenNcc.BackColor = System.Drawing.Color.Transparent;
            this.cbbTenNcc.BaseColor = System.Drawing.Color.White;
            this.cbbTenNcc.BorderColor = System.Drawing.Color.Silver;
            this.cbbTenNcc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTenNcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenNcc.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTenNcc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTenNcc.ForeColor = System.Drawing.Color.Black;
            this.cbbTenNcc.FormattingEnabled = true;
            this.cbbTenNcc.Location = new System.Drawing.Point(473, 109);
            this.cbbTenNcc.Name = "cbbTenNcc";
            this.cbbTenNcc.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbTenNcc.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbTenNcc.Size = new System.Drawing.Size(185, 26);
            this.cbbTenNcc.TabIndex = 11;
            // 
            // cbbMaNCC
            // 
            this.cbbMaNCC.BackColor = System.Drawing.Color.Transparent;
            this.cbbMaNCC.BaseColor = System.Drawing.Color.White;
            this.cbbMaNCC.BorderColor = System.Drawing.Color.Silver;
            this.cbbMaNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNCC.FocusedColor = System.Drawing.Color.Empty;
            this.cbbMaNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMaNCC.ForeColor = System.Drawing.Color.Black;
            this.cbbMaNCC.FormattingEnabled = true;
            this.cbbMaNCC.Location = new System.Drawing.Point(473, 58);
            this.cbbMaNCC.Name = "cbbMaNCC";
            this.cbbMaNCC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbMaNCC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbMaNCC.Size = new System.Drawing.Size(185, 26);
            this.cbbMaNCC.TabIndex = 9;
            // 
            // txtGia
            // 
            this.txtGia.BaseColor = System.Drawing.Color.White;
            this.txtGia.BorderColor = System.Drawing.Color.Silver;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGia.HideSelection = false;
            this.txtGia.Location = new System.Drawing.Point(149, 210);
            this.txtGia.Name = "txtGia";
            this.txtGia.PasswordChar = '\0';
            this.txtGia.SelectedText = "";
            this.txtGia.Size = new System.Drawing.Size(160, 30);
            this.txtGia.TabIndex = 7;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nhập giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nhập tên danh mục";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BaseColor = System.Drawing.Color.White;
            this.txtSoLuong.BorderColor = System.Drawing.Color.Silver;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSoLuong.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSoLuong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.Location = new System.Drawing.Point(149, 160);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(160, 30);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhập danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhập tên NCC";
            // 
            // txtMaSP
            // 
            this.txtMaSP.BaseColor = System.Drawing.Color.White;
            this.txtMaSP.BorderColor = System.Drawing.Color.Silver;
            this.txtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSP.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaSP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaSP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaSP.Location = new System.Drawing.Point(149, 58);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.PasswordChar = '\0';
            this.txtMaSP.SelectedText = "";
            this.txtMaSP.Size = new System.Drawing.Size(160, 30);
            this.txtMaSP.TabIndex = 1;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nhập mã NCC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nhập mã sản phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BaseColor = System.Drawing.Color.White;
            this.txtTenSP.BorderColor = System.Drawing.Color.Silver;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenSP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenSP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenSP.Location = new System.Drawing.Point(149, 109);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.Size = new System.Drawing.Size(160, 30);
            this.txtTenSP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập tên sản phẩm";
            // 
            // dgrSanPham
            // 
            this.dgrSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSanPham.Location = new System.Drawing.Point(781, 210);
            this.dgrSanPham.Name = "dgrSanPham";
            this.dgrSanPham.Size = new System.Drawing.Size(744, 310);
            this.dgrSanPham.TabIndex = 11;
            this.dgrSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrSanPham_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThoat.IconColor = System.Drawing.Color.Black;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.Location = new System.Drawing.Point(577, 569);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 44);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.BackColor = System.Drawing.Color.White;
            this.btnKhoiTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoiTao.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiTao.ForeColor = System.Drawing.Color.Blue;
            this.btnKhoiTao.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnKhoiTao.IconColor = System.Drawing.Color.Black;
            this.btnKhoiTao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhoiTao.Location = new System.Drawing.Point(465, 569);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(106, 44);
            this.btnKhoiTao.TabIndex = 6;
            this.btnKhoiTao.Text = "Khởi tạo";
            this.btnKhoiTao.UseVisualStyleBackColor = false;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSua.IconColor = System.Drawing.Color.Black;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.Location = new System.Drawing.Point(353, 569);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 44);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoa.IconColor = System.Drawing.Color.Black;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.Location = new System.Drawing.Point(240, 569);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 44);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThem.IconColor = System.Drawing.Color.Black;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.Location = new System.Drawing.Point(128, 569);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 44);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // TimKiem
            // 
            this.TimKiem.BaseColor = System.Drawing.Color.White;
            this.TimKiem.BorderColor = System.Drawing.Color.Silver;
            this.TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimKiem.FocusedBaseColor = System.Drawing.Color.White;
            this.TimKiem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TimKiem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimKiem.Location = new System.Drawing.Point(873, 135);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.PasswordChar = '\0';
            this.TimKiem.SelectedText = "";
            this.TimKiem.Size = new System.Drawing.Size(489, 41);
            this.TimKiem.TabIndex = 9;
            this.TimKiem.TextChanged += new System.EventHandler(this.TimKiem_TextChanged);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.White;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiem.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTimkiem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTimkiem.IconColor = System.Drawing.Color.Black;
            this.btnTimkiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimkiem.Location = new System.Drawing.Point(1388, 132);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(106, 44);
            this.btnTimkiem.TabIndex = 10;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(777, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Từ khoá";
            // 
            // btnThemDM
            // 
            this.btnThemDM.BackColor = System.Drawing.Color.White;
            this.btnThemDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDM.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDM.ForeColor = System.Drawing.Color.Blue;
            this.btnThemDM.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemDM.IconColor = System.Drawing.Color.Black;
            this.btnThemDM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemDM.Location = new System.Drawing.Point(781, 569);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(216, 44);
            this.btnThemDM.TabIndex = 12;
            this.btnThemDM.Text = "Thêm danh mục";
            this.btnThemDM.UseVisualStyleBackColor = false;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.BackColor = System.Drawing.Color.White;
            this.btnThemNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNCC.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNCC.ForeColor = System.Drawing.Color.Blue;
            this.btnThemNCC.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemNCC.IconColor = System.Drawing.Color.Black;
            this.btnThemNCC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemNCC.Location = new System.Drawing.Point(1306, 569);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(216, 44);
            this.btnThemNCC.TabIndex = 13;
            this.btnThemNCC.Text = "Thêm nhà cung cấp";
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1531, 75);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gunaGroupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1531, 696);
            this.panel2.TabIndex = 1;
            // 
            // qLNS_SPDataSet
            // 
            this.qLNS_SPDataSet.DataSetName = "QLNS_SPDataSet";
            this.qLNS_SPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNSSPDataSetBindingSource
            // 
            this.qLNSSPDataSetBindingSource.DataSource = this.qLNS_SPDataSet;
            this.qLNSSPDataSetBindingSource.Position = 0;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1531, 771);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.btnThemDM);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgrSanPham);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSanPham";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLNS_SPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSSPDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataGridView dgrSanPham;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnKhoiTao;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
        private Guna.UI.WinForms.GunaTextBox TimKiem;
        private FontAwesome.Sharp.IconButton btnTimkiem;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaTextBox txtGia;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtMaSP;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtTenSP;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cbbTenDM;
        private Guna.UI.WinForms.GunaComboBox cbbMaDM;
        private Guna.UI.WinForms.GunaComboBox cbbTenNcc;
        private Guna.UI.WinForms.GunaComboBox cbbMaNCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnThemDM;
        private FontAwesome.Sharp.IconButton btnThemNCC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private QLNS_SPDataSet qLNS_SPDataSet;
        private System.Windows.Forms.BindingSource qLNSSPDataSetBindingSource;
    }
}