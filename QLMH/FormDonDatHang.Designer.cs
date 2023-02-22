
namespace QLMH
{
    partial class FormDonDatHang
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
            this.group = new Guna.UI.WinForms.GunaGroupBox();
            this.cbbTenNcc = new Guna.UI.WinForms.GunaComboBox();
            this.txtDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cbbMaNCC = new Guna.UI.WinForms.GunaComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHang = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtThanhTien = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGia = new Guna.UI.WinForms.GunaTextBox();
            this.txtsoluong = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTenNv = new Guna.UI.WinForms.GunaComboBox();
            this.cbbMaNV = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDH = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.TimKiem = new Guna.UI.WinForms.GunaTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgrDonDatHang = new System.Windows.Forms.DataGridView();
            this.InCTHD = new FontAwesome.Sharp.IconButton();
            this.btnThemSP = new FontAwesome.Sharp.IconButton();
            this.btnThemNCC = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnKhoiTao = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnTimkiem = new FontAwesome.Sharp.IconButton();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDonDatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.Transparent;
            this.group.BaseColor = System.Drawing.Color.White;
            this.group.BorderColor = System.Drawing.Color.Gainsboro;
            this.group.Controls.Add(this.cbbTenNcc);
            this.group.Controls.Add(this.txtDate);
            this.group.Controls.Add(this.cbbMaNCC);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.txtTenHang);
            this.group.Controls.Add(this.label10);
            this.group.Controls.Add(this.txtThanhTien);
            this.group.Controls.Add(this.label5);
            this.group.Controls.Add(this.label8);
            this.group.Controls.Add(this.txtGia);
            this.group.Controls.Add(this.txtsoluong);
            this.group.Controls.Add(this.label6);
            this.group.Controls.Add(this.label4);
            this.group.Controls.Add(this.cbbTenNv);
            this.group.Controls.Add(this.cbbMaNV);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.label7);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.txtMaDH);
            this.group.Controls.Add(this.label9);
            this.group.LineColor = System.Drawing.Color.Gainsboro;
            this.group.Location = new System.Drawing.Point(3, 82);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(744, 396);
            this.group.TabIndex = 2;
            this.group.Text = "Thông tin đặt hàng";
            this.group.TextLocation = new System.Drawing.Point(10, 8);
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
            this.cbbTenNcc.Location = new System.Drawing.Point(515, 107);
            this.cbbTenNcc.Name = "cbbTenNcc";
            this.cbbTenNcc.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbTenNcc.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbTenNcc.Size = new System.Drawing.Size(226, 26);
            this.cbbTenNcc.TabIndex = 6;
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
            this.txtDate.Location = new System.Drawing.Point(169, 256);
            this.txtDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDate.OnPressedColor = System.Drawing.Color.Black;
            this.txtDate.Size = new System.Drawing.Size(226, 30);
            this.txtDate.TabIndex = 4;
            this.txtDate.Text = "02/02/2023";
            this.txtDate.Value = new System.DateTime(2023, 2, 2, 0, 0, 0, 0);
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
            this.cbbMaNCC.Location = new System.Drawing.Point(515, 54);
            this.cbbMaNCC.Name = "cbbMaNCC";
            this.cbbMaNCC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbMaNCC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbMaNCC.Size = new System.Drawing.Size(226, 26);
            this.cbbMaNCC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nhập tên NCC";
            // 
            // txtTenHang
            // 
            this.txtTenHang.BaseColor = System.Drawing.Color.White;
            this.txtTenHang.BorderColor = System.Drawing.Color.Silver;
            this.txtTenHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHang.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenHang.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenHang.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenHang.Location = new System.Drawing.Point(169, 207);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.PasswordChar = '\0';
            this.txtTenHang.SelectedText = "";
            this.txtTenHang.Size = new System.Drawing.Size(226, 30);
            this.txtTenHang.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(420, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Nhập mã NCC";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BaseColor = System.Drawing.Color.White;
            this.txtThanhTien.BorderColor = System.Drawing.Color.Silver;
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.FocusedBaseColor = System.Drawing.Color.White;
            this.txtThanhTien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtThanhTien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThanhTien.Location = new System.Drawing.Point(515, 264);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PasswordChar = '\0';
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.Size = new System.Drawing.Size(226, 26);
            this.txtThanhTien.TabIndex = 9;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tổng Tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(422, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Giá";
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
            this.txtGia.Location = new System.Drawing.Point(515, 214);
            this.txtGia.Name = "txtGia";
            this.txtGia.PasswordChar = '\0';
            this.txtGia.SelectedText = "";
            this.txtGia.Size = new System.Drawing.Size(226, 26);
            this.txtGia.TabIndex = 8;
            // 
            // txtsoluong
            // 
            this.txtsoluong.BaseColor = System.Drawing.Color.White;
            this.txtsoluong.BorderColor = System.Drawing.Color.Silver;
            this.txtsoluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsoluong.FocusedBaseColor = System.Drawing.Color.White;
            this.txtsoluong.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsoluong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsoluong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsoluong.Location = new System.Drawing.Point(515, 157);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.PasswordChar = '\0';
            this.txtsoluong.SelectedText = "";
            this.txtsoluong.Size = new System.Drawing.Size(226, 26);
            this.txtsoluong.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày đặt";
            // 
            // cbbTenNv
            // 
            this.cbbTenNv.BackColor = System.Drawing.Color.Transparent;
            this.cbbTenNv.BaseColor = System.Drawing.Color.White;
            this.cbbTenNv.BorderColor = System.Drawing.Color.Silver;
            this.cbbTenNv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTenNv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenNv.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTenNv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTenNv.ForeColor = System.Drawing.Color.Black;
            this.cbbTenNv.FormattingEnabled = true;
            this.cbbTenNv.Location = new System.Drawing.Point(169, 157);
            this.cbbTenNv.Name = "cbbTenNv";
            this.cbbTenNv.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbTenNv.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbTenNv.Size = new System.Drawing.Size(226, 26);
            this.cbbTenNv.TabIndex = 2;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.BackColor = System.Drawing.Color.Transparent;
            this.cbbMaNV.BaseColor = System.Drawing.Color.White;
            this.cbbMaNV.BorderColor = System.Drawing.Color.Silver;
            this.cbbMaNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNV.FocusedColor = System.Drawing.Color.Empty;
            this.cbbMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMaNV.ForeColor = System.Drawing.Color.Black;
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(169, 107);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbMaNV.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbMaNV.Size = new System.Drawing.Size(226, 26);
            this.cbbMaNV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập tên nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nhập mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nhập tên sản phẩm";
            // 
            // txtMaDH
            // 
            this.txtMaDH.BaseColor = System.Drawing.Color.White;
            this.txtMaDH.BorderColor = System.Drawing.Color.Silver;
            this.txtMaDH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDH.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaDH.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaDH.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaDH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaDH.Location = new System.Drawing.Point(169, 50);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.PasswordChar = '\0';
            this.txtMaDH.SelectedText = "";
            this.txtMaDH.Size = new System.Drawing.Size(226, 26);
            this.txtMaDH.TabIndex = 0;
            this.txtMaDH.TextChanged += new System.EventHandler(this.txtMaDH_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nhập mã đơn hàng";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(414, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(677, 54);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "THÔNG TIN QUẢN LÝ ĐẶT HÀNG";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.TimKiem.Location = new System.Drawing.Point(833, 82);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.PasswordChar = '\0';
            this.TimKiem.SelectedText = "";
            this.TimKiem.Size = new System.Drawing.Size(526, 41);
            this.TimKiem.TabIndex = 9;
            this.TimKiem.TextChanged += new System.EventHandler(this.TimKiem_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(754, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Từ khoá";
            // 
            // dgrDonDatHang
            // 
            this.dgrDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDonDatHang.Location = new System.Drawing.Point(753, 142);
            this.dgrDonDatHang.Name = "dgrDonDatHang";
            this.dgrDonDatHang.Size = new System.Drawing.Size(747, 336);
            this.dgrDonDatHang.TabIndex = 11;
            this.dgrDonDatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDonDatHang_CellContentClick);
            // 
            // InCTHD
            // 
            this.InCTHD.BackColor = System.Drawing.Color.White;
            this.InCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InCTHD.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InCTHD.ForeColor = System.Drawing.Color.Blue;
            this.InCTHD.IconChar = FontAwesome.Sharp.IconChar.None;
            this.InCTHD.IconColor = System.Drawing.Color.Black;
            this.InCTHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InCTHD.Location = new System.Drawing.Point(1076, 484);
            this.InCTHD.Name = "InCTHD";
            this.InCTHD.Size = new System.Drawing.Size(106, 44);
            this.InCTHD.TabIndex = 13;
            this.InCTHD.Text = "In";
            this.InCTHD.UseVisualStyleBackColor = false;
            this.InCTHD.Click += new System.EventHandler(this.InCTHD_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.White;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.Blue;
            this.btnThemSP.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemSP.IconColor = System.Drawing.Color.Black;
            this.btnThemSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemSP.Location = new System.Drawing.Point(1284, 484);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(216, 44);
            this.btnThemSP.TabIndex = 1;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
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
            this.btnThemNCC.Location = new System.Drawing.Point(753, 484);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(216, 44);
            this.btnThemNCC.TabIndex = 12;
            this.btnThemNCC.Text = "Thêm nhà cung cấp";
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
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
            this.btnThoat.Location = new System.Drawing.Point(538, 484);
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
            this.btnKhoiTao.Location = new System.Drawing.Point(426, 484);
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
            this.btnSua.Location = new System.Drawing.Point(314, 484);
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
            this.btnXoa.Location = new System.Drawing.Point(201, 484);
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
            this.btnThem.Location = new System.Drawing.Point(89, 484);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 44);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnTimkiem.Location = new System.Drawing.Point(1365, 82);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(116, 41);
            this.btnTimkiem.TabIndex = 10;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // FormDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1512, 699);
            this.Controls.Add(this.InCTHD);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgrDonDatHang);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.group);
            this.Name = "FormDonDatHang";
            this.Text = "FormDonDatHang";
            this.Load += new System.EventHandler(this.FormDonDatHang_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDonDatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox group;
        private Guna.UI.WinForms.GunaTextBox txtThanhTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtsoluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox cbbTenNv;
        private Guna.UI.WinForms.GunaComboBox cbbMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtMaDH;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox TimKiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgrDonDatHang;
        private Guna.UI.WinForms.GunaTextBox txtTenHang;
        private Guna.UI.WinForms.GunaDateTimePicker txtDate;
        private Guna.UI.WinForms.GunaTextBox txtGia;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnKhoiTao;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
        private Guna.UI.WinForms.GunaComboBox cbbTenNcc;
        private Guna.UI.WinForms.GunaComboBox cbbMaNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnThemNCC;
        private FontAwesome.Sharp.IconButton btnThemSP;
        private FontAwesome.Sharp.IconButton InCTHD;
        private FontAwesome.Sharp.IconButton btnTimkiem;
    }
}