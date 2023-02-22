
namespace QLMH
{
    partial class FormNhanVien
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
            this.group = new Guna.UI.WinForms.GunaGroupBox();
            this.txtDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cbbtencv = new Guna.UI.WinForms.GunaComboBox();
            this.cbbChucVu = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCMT = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpass = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNv = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenNv = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNS_SPDataSet = new QLMH.QLNS_SPDataSet1();
            this.nHANVIENTableAdapter = new QLMH.QLNS_SPDataSet1TableAdapters.NHANVIENTableAdapter();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnKhoiTao = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.dgrNhanVien = new System.Windows.Forms.DataGridView();
            this.btnTimkiem = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TimKiem = new Guna.UI.WinForms.GunaTextBox();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNS_SPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(500, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(498, 54);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "THÔNG TIN NHÂN VIÊN";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.Transparent;
            this.group.BaseColor = System.Drawing.Color.White;
            this.group.BorderColor = System.Drawing.Color.Gainsboro;
            this.group.Controls.Add(this.txtDate);
            this.group.Controls.Add(this.cbbtencv);
            this.group.Controls.Add(this.cbbChucVu);
            this.group.Controls.Add(this.label5);
            this.group.Controls.Add(this.label4);
            this.group.Controls.Add(this.txtCMT);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.txtSDT);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.txtDiaChi);
            this.group.Controls.Add(this.label8);
            this.group.Controls.Add(this.txtpass);
            this.group.Controls.Add(this.label7);
            this.group.Controls.Add(this.txtEmail);
            this.group.Controls.Add(this.label6);
            this.group.Controls.Add(this.txtMaNv);
            this.group.Controls.Add(this.label9);
            this.group.Controls.Add(this.txtTenNv);
            this.group.Controls.Add(this.label1);
            this.group.LineColor = System.Drawing.Color.Gainsboro;
            this.group.Location = new System.Drawing.Point(13, 99);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(645, 384);
            this.group.TabIndex = 0;
            this.group.Text = "Thông tin nhân viên";
            this.group.TextLocation = new System.Drawing.Point(10, 8);
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
            this.txtDate.Location = new System.Drawing.Point(145, 264);
            this.txtDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDate.OnPressedColor = System.Drawing.Color.Black;
            this.txtDate.Size = new System.Drawing.Size(160, 30);
            this.txtDate.TabIndex = 4;
            this.txtDate.Text = "02/02/2023";
            this.txtDate.Value = new System.DateTime(2023, 2, 2, 0, 0, 0, 0);
            // 
            // cbbtencv
            // 
            this.cbbtencv.BackColor = System.Drawing.Color.Transparent;
            this.cbbtencv.BaseColor = System.Drawing.Color.White;
            this.cbbtencv.BorderColor = System.Drawing.Color.Silver;
            this.cbbtencv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbtencv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbtencv.FocusedColor = System.Drawing.Color.Empty;
            this.cbbtencv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbtencv.ForeColor = System.Drawing.Color.Black;
            this.cbbtencv.FormattingEnabled = true;
            this.cbbtencv.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbtencv.Location = new System.Drawing.Point(473, 260);
            this.cbbtencv.Name = "cbbtencv";
            this.cbbtencv.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbtencv.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbtencv.Size = new System.Drawing.Size(160, 26);
            this.cbbtencv.TabIndex = 9;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.BackColor = System.Drawing.Color.Transparent;
            this.cbbChucVu.BaseColor = System.Drawing.Color.White;
            this.cbbChucVu.BorderColor = System.Drawing.Color.Silver;
            this.cbbChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucVu.FocusedColor = System.Drawing.Color.Empty;
            this.cbbChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbChucVu.ForeColor = System.Drawing.Color.Black;
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbChucVu.Location = new System.Drawing.Point(473, 213);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbChucVu.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbChucVu.Size = new System.Drawing.Size(160, 26);
            this.cbbChucVu.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nhập ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nhập chức vụ";
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
            this.txtCMT.Location = new System.Drawing.Point(145, 209);
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.PasswordChar = '\0';
            this.txtCMT.SelectedText = "";
            this.txtCMT.Size = new System.Drawing.Size(160, 30);
            this.txtCMT.TabIndex = 3;
            this.txtCMT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMT_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 13;
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
            this.txtSDT.Location = new System.Drawing.Point(145, 157);
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
            this.label2.Location = new System.Drawing.Point(3, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nhập số điện thoại";
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
            this.txtDiaChi.Location = new System.Drawing.Point(473, 158);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(160, 30);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nhập địa chỉ";
            // 
            // txtpass
            // 
            this.txtpass.BaseColor = System.Drawing.Color.White;
            this.txtpass.BorderColor = System.Drawing.Color.Silver;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpass.Location = new System.Drawing.Point(473, 106);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.SelectedText = "";
            this.txtpass.Size = new System.Drawing.Size(160, 30);
            this.txtpass.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(343, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nhập mật khẩu";
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
            this.txtEmail.Location = new System.Drawing.Point(473, 55);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(160, 30);
            this.txtEmail.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nhập Email";
            // 
            // txtMaNv
            // 
            this.txtMaNv.BaseColor = System.Drawing.Color.White;
            this.txtMaNv.BorderColor = System.Drawing.Color.Silver;
            this.txtMaNv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNv.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaNv.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaNv.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaNv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNv.Location = new System.Drawing.Point(145, 55);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.PasswordChar = '\0';
            this.txtMaNv.SelectedText = "";
            this.txtMaNv.Size = new System.Drawing.Size(160, 30);
            this.txtMaNv.TabIndex = 0;
            this.txtMaNv.TextChanged += new System.EventHandler(this.txtMaNv_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nhập mã nhân viên";
            // 
            // txtTenNv
            // 
            this.txtTenNv.BaseColor = System.Drawing.Color.White;
            this.txtTenNv.BorderColor = System.Drawing.Color.Silver;
            this.txtTenNv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNv.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenNv.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenNv.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenNv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNv.Location = new System.Drawing.Point(145, 106);
            this.txtTenNv.Name = "txtTenNv";
            this.txtTenNv.PasswordChar = '\0';
            this.txtTenNv.SelectedText = "";
            this.txtTenNv.Size = new System.Drawing.Size(160, 30);
            this.txtTenNv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhập tên nhân viên";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLNS_SPDataSet;
            // 
            // qLNS_SPDataSet
            // 
            this.qLNS_SPDataSet.DataSetName = "QLNS_SPDataSet";
            this.qLNS_SPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
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
            this.btnThem.Location = new System.Drawing.Point(40, 510);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 44);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(152, 510);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 44);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(265, 510);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 44);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnKhoiTao.Location = new System.Drawing.Point(377, 510);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(106, 44);
            this.btnKhoiTao.TabIndex = 4;
            this.btnKhoiTao.Text = "Khởi tạo";
            this.btnKhoiTao.UseVisualStyleBackColor = false;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
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
            this.btnThoat.Location = new System.Drawing.Point(489, 510);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 44);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgrNhanVien
            // 
            this.dgrNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrNhanVien.Location = new System.Drawing.Point(708, 146);
            this.dgrNhanVien.Name = "dgrNhanVien";
            this.dgrNhanVien.Size = new System.Drawing.Size(744, 310);
            this.dgrNhanVien.TabIndex = 9;
            this.dgrNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrNhanVien_CellContentClick_1);
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
            this.btnTimkiem.Location = new System.Drawing.Point(1315, 96);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(106, 44);
            this.btnTimkiem.TabIndex = 8;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(704, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "Từ khoá";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.TimKiem.Location = new System.Drawing.Point(800, 99);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.PasswordChar = '\0';
            this.TimKiem.SelectedText = "";
            this.TimKiem.Size = new System.Drawing.Size(489, 41);
            this.TimKiem.TabIndex = 7;
            this.TimKiem.TextChanged += new System.EventHandler(this.TimKiem_TextChanged);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1493, 680);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgrNhanVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.group);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "FormNhanVien";
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNS_SPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGroupBox group;
        private Guna.UI.WinForms.GunaComboBox cbbChucVu;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtCMT;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtTenNv;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDateTimePicker txtDate;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtpass;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private QLNS_SPDataSet1 qLNS_SPDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QLNS_SPDataSet1TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnKhoiTao;
        private FontAwesome.Sharp.IconButton btnThoat;
        private Guna.UI.WinForms.GunaTextBox txtMaNv;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaComboBox cbbtencv;
        private System.Windows.Forms.DataGridView dgrNhanVien;
        private FontAwesome.Sharp.IconButton btnTimkiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI.WinForms.GunaTextBox TimKiem;
    }
}