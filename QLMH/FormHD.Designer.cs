
namespace QLMH
{
    partial class FormHD
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaHD = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.group = new Guna.UI.WinForms.GunaGroupBox();
            this.CbbTenKH = new Guna.UI.WinForms.GunaComboBox();
            this.cbbMaKH = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgrHoaDon = new System.Windows.Forms.DataGridView();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnKhoiTao = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.TimKiem = new Guna.UI.WinForms.GunaTextBox();
            this.btnTimkiem = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(413, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(463, 54);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "THÔNG TIN HOÁ ĐƠN";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nhập mã hoá đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BaseColor = System.Drawing.Color.White;
            this.txtMaHD.BorderColor = System.Drawing.Color.Silver;
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHD.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaHD.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaHD.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaHD.Location = new System.Drawing.Point(181, 49);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PasswordChar = '\0';
            this.txtMaHD.SelectedText = "";
            this.txtMaHD.Size = new System.Drawing.Size(226, 30);
            this.txtMaHD.TabIndex = 0;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhập ngày sinh";
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
            this.txtDate.Location = new System.Drawing.Point(181, 209);
            this.txtDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDate.OnPressedColor = System.Drawing.Color.Black;
            this.txtDate.Size = new System.Drawing.Size(226, 30);
            this.txtDate.TabIndex = 3;
            this.txtDate.Text = "02/02/2023";
            this.txtDate.Value = new System.DateTime(2023, 2, 2, 0, 0, 0, 0);
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.Transparent;
            this.group.BaseColor = System.Drawing.Color.White;
            this.group.BorderColor = System.Drawing.Color.Gainsboro;
            this.group.Controls.Add(this.CbbTenKH);
            this.group.Controls.Add(this.cbbMaKH);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.txtDate);
            this.group.Controls.Add(this.label5);
            this.group.Controls.Add(this.txtMaHD);
            this.group.Controls.Add(this.label9);
            this.group.LineColor = System.Drawing.Color.Gainsboro;
            this.group.Location = new System.Drawing.Point(12, 80);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(524, 374);
            this.group.TabIndex = 1;
            this.group.Text = "Thông tin hoá đơn";
            this.group.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // CbbTenKH
            // 
            this.CbbTenKH.BackColor = System.Drawing.Color.Transparent;
            this.CbbTenKH.BaseColor = System.Drawing.Color.White;
            this.CbbTenKH.BorderColor = System.Drawing.Color.Silver;
            this.CbbTenKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbbTenKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbTenKH.FocusedColor = System.Drawing.Color.Empty;
            this.CbbTenKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbbTenKH.ForeColor = System.Drawing.Color.Black;
            this.CbbTenKH.FormattingEnabled = true;
            this.CbbTenKH.Location = new System.Drawing.Point(181, 155);
            this.CbbTenKH.Name = "CbbTenKH";
            this.CbbTenKH.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CbbTenKH.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CbbTenKH.Size = new System.Drawing.Size(226, 26);
            this.CbbTenKH.TabIndex = 2;
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.BackColor = System.Drawing.Color.Transparent;
            this.cbbMaKH.BaseColor = System.Drawing.Color.White;
            this.cbbMaKH.BorderColor = System.Drawing.Color.Silver;
            this.cbbMaKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaKH.FocusedColor = System.Drawing.Color.Empty;
            this.cbbMaKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMaKH.ForeColor = System.Drawing.Color.Black;
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(181, 104);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbMaKH.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbMaKH.Size = new System.Drawing.Size(226, 26);
            this.cbbMaKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập tên khách hàng";
            // 
            // dgrHoaDon
            // 
            this.dgrHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrHoaDon.Location = new System.Drawing.Point(585, 127);
            this.dgrHoaDon.Name = "dgrHoaDon";
            this.dgrHoaDon.Size = new System.Drawing.Size(713, 310);
            this.dgrHoaDon.TabIndex = 10;
            this.dgrHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrHoaDon_CellContentClick);
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
            this.btnThoat.Location = new System.Drawing.Point(462, 472);
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
            this.btnKhoiTao.Location = new System.Drawing.Point(350, 472);
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
            this.btnSua.Location = new System.Drawing.Point(238, 472);
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
            this.btnXoa.Location = new System.Drawing.Point(125, 472);
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
            this.btnThem.Location = new System.Drawing.Point(13, 472);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 44);
            this.btnThem.TabIndex = 2;
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
            this.TimKiem.Location = new System.Drawing.Point(660, 80);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.PasswordChar = '\0';
            this.TimKiem.SelectedText = "";
            this.TimKiem.Size = new System.Drawing.Size(489, 41);
            this.TimKiem.TabIndex = 8;
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
            this.btnTimkiem.Location = new System.Drawing.Point(1175, 77);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(106, 44);
            this.btnTimkiem.TabIndex = 9;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(564, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "Từ khoá";
            // 
            // FormHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1339, 659);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgrHoaDon);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.group);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnThem);
            this.Name = "FormHD";
            this.Text = "FormHD";
            this.Load += new System.EventHandler(this.FormHD_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtMaHD;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaDateTimePicker txtDate;
        private Guna.UI.WinForms.GunaGroupBox group;
        private Guna.UI.WinForms.GunaComboBox CbbTenKH;
        private Guna.UI.WinForms.GunaComboBox cbbMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgrHoaDon;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnKhoiTao;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
        private Guna.UI.WinForms.GunaTextBox TimKiem;
        private FontAwesome.Sharp.IconButton btnTimkiem;
        private System.Windows.Forms.Label label11;
    }
}