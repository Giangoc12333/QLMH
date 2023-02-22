
namespace QLMH
{
    partial class FormKhachHang
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.group = new Guna.UI.WinForms.GunaGroupBox();
            this.txtDiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCMT = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaKH = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenKH = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrkhachHang = new System.Windows.Forms.DataGridView();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnKhoiTao = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTimkiem = new FontAwesome.Sharp.IconButton();
            this.TimKiem = new Guna.UI.WinForms.GunaTextBox();
            this.btnNo = new FontAwesome.Sharp.IconButton();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrkhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(526, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(546, 54);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "THÔNG TIN KHÁCH HÀNG";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.Transparent;
            this.group.BaseColor = System.Drawing.Color.White;
            this.group.BorderColor = System.Drawing.Color.Gainsboro;
            this.group.Controls.Add(this.txtDiaChi);
            this.group.Controls.Add(this.label8);
            this.group.Controls.Add(this.txtDate);
            this.group.Controls.Add(this.label5);
            this.group.Controls.Add(this.txtCMT);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.txtSDT);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.txtEmail);
            this.group.Controls.Add(this.label6);
            this.group.Controls.Add(this.txtMaKH);
            this.group.Controls.Add(this.label9);
            this.group.Controls.Add(this.txtTenKH);
            this.group.Controls.Add(this.label1);
            this.group.LineColor = System.Drawing.Color.Gainsboro;
            this.group.Location = new System.Drawing.Point(35, 102);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(645, 384);
            this.group.TabIndex = 1;
            this.group.Text = "Thông tin khách hàng";
            this.group.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BaseColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderColor = System.Drawing.Color.Silver;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDiaChi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDiaChi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi.Location = new System.Drawing.Point(139, 202);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(160, 30);
            this.txtDiaChi.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-3, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nhập địa chỉ";
            // 
            // txtDate
            // 
            this.txtDate.BaseColor = System.Drawing.Color.White;
            this.txtDate.BorderColor = System.Drawing.Color.Silver;
            this.txtDate.CustomFormat = "yyyy-MM-dd";
            this.txtDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDate.ForeColor = System.Drawing.Color.Black;
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(467, 156);
            this.txtDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDate.OnPressedColor = System.Drawing.Color.Black;
            this.txtDate.Size = new System.Drawing.Size(160, 30);
            this.txtDate.TabIndex = 6;
            this.txtDate.Text = "02/02/2023";
            this.txtDate.Value = new System.DateTime(2023, 2, 2, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nhập ngày sinh";
            // 
            // txtCMT
            // 
            this.txtCMT.BaseColor = System.Drawing.Color.White;
            this.txtCMT.BorderColor = System.Drawing.Color.Silver;
            this.txtCMT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCMT.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCMT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCMT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCMT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCMT.Location = new System.Drawing.Point(467, 101);
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.PasswordChar = '\0';
            this.txtCMT.SelectedText = "";
            this.txtCMT.Size = new System.Drawing.Size(160, 30);
            this.txtCMT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nhập chứng minh thư";
            // 
            // txtSDT
            // 
            this.txtSDT.BaseColor = System.Drawing.Color.White;
            this.txtSDT.BorderColor = System.Drawing.Color.Silver;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.Location = new System.Drawing.Point(139, 152);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(160, 30);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập số điện thoại";
            // 
            // txtEmail
            // 
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(467, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(160, 30);
            this.txtEmail.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nhập Email";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BaseColor = System.Drawing.Color.White;
            this.txtMaKH.BorderColor = System.Drawing.Color.Silver;
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaKH.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaKH.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKH.Location = new System.Drawing.Point(139, 50);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.Size = new System.Drawing.Size(160, 30);
            this.txtMaKH.TabIndex = 0;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-3, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nhập mã khách hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BaseColor = System.Drawing.Color.White;
            this.txtTenKH.BorderColor = System.Drawing.Color.Silver;
            this.txtTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenKH.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenKH.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKH.Location = new System.Drawing.Point(139, 101);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.Size = new System.Drawing.Size(160, 30);
            this.txtTenKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập tên khách hàng";
            // 
            // dgrkhachHang
            // 
            this.dgrkhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrkhachHang.Location = new System.Drawing.Point(710, 176);
            this.dgrkhachHang.Name = "dgrkhachHang";
            this.dgrkhachHang.Size = new System.Drawing.Size(744, 310);
            this.dgrkhachHang.TabIndex = 10;
            this.dgrkhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrkhachHang_CellContentClick);
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
            this.btnThoat.Location = new System.Drawing.Point(535, 492);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 44);
            this.btnThoat.TabIndex = 6;
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
            this.btnKhoiTao.Location = new System.Drawing.Point(423, 492);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(106, 44);
            this.btnKhoiTao.TabIndex = 5;
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
            this.btnSua.Location = new System.Drawing.Point(311, 492);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 44);
            this.btnSua.TabIndex = 4;
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
            this.btnXoa.Location = new System.Drawing.Point(198, 492);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 44);
            this.btnXoa.TabIndex = 3;
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
            this.btnThem.Location = new System.Drawing.Point(86, 492);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 44);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(720, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "Từ khoá";
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
            this.btnTimkiem.Location = new System.Drawing.Point(1331, 99);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(106, 44);
            this.btnTimkiem.TabIndex = 9;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
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
            this.TimKiem.Location = new System.Drawing.Point(816, 102);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.PasswordChar = '\0';
            this.TimKiem.SelectedText = "";
            this.TimKiem.Size = new System.Drawing.Size(489, 41);
            this.TimKiem.TabIndex = 8;
            this.TimKiem.TextChanged += new System.EventHandler(this.TimKiem_TextChanged);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.White;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.Blue;
            this.btnNo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNo.IconColor = System.Drawing.Color.Black;
            this.btnNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNo.Location = new System.Drawing.Point(710, 492);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(281, 44);
            this.btnNo.TabIndex = 11;
            this.btnNo.Text = "Quản Lý Nợ";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1462, 736);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgrkhachHang);
            this.Controls.Add(this.group);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrkhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGroupBox group;
        private Guna.UI.WinForms.GunaDateTimePicker txtDate;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtCMT;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtMaKH;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrkhachHang;
        private Guna.UI.WinForms.GunaTextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnKhoiTao;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnTimkiem;
        private Guna.UI.WinForms.GunaTextBox TimKiem;
        private FontAwesome.Sharp.IconButton btnNo;
    }
}