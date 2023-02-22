
namespace QLMH
{
    partial class FormQLNO
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
            this.cbbLoaiNo = new Guna.UI.WinForms.GunaComboBox();
            this.txtThanhTien = new Guna.UI.WinForms.GunaTextBox();
            this.cbbDate = new Guna.UI.WinForms.GunaComboBox();
            this.CbbTenKH = new Guna.UI.WinForms.GunaComboBox();
            this.cbbMaHD = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMaKH = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNO = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TimKiem = new Guna.UI.WinForms.GunaTextBox();
            this.btnTimkiem = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.dgrQLNO = new System.Windows.Forms.DataGridView();
            this.btnKhoiTao = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrQLNO)).BeginInit();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.Transparent;
            this.group.BaseColor = System.Drawing.Color.White;
            this.group.BorderColor = System.Drawing.Color.Gainsboro;
            this.group.Controls.Add(this.cbbLoaiNo);
            this.group.Controls.Add(this.txtThanhTien);
            this.group.Controls.Add(this.cbbDate);
            this.group.Controls.Add(this.CbbTenKH);
            this.group.Controls.Add(this.cbbMaHD);
            this.group.Controls.Add(this.label6);
            this.group.Controls.Add(this.cbbMaKH);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.label4);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.label5);
            this.group.Controls.Add(this.txtMaNO);
            this.group.Controls.Add(this.label9);
            this.group.LineColor = System.Drawing.Color.Gainsboro;
            this.group.Location = new System.Drawing.Point(12, 70);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(524, 374);
            this.group.TabIndex = 2;
            this.group.Text = "Thông tin nợ";
            this.group.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cbbLoaiNo
            // 
            this.cbbLoaiNo.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiNo.BaseColor = System.Drawing.Color.White;
            this.cbbLoaiNo.BorderColor = System.Drawing.Color.Silver;
            this.cbbLoaiNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiNo.FocusedColor = System.Drawing.Color.Empty;
            this.cbbLoaiNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLoaiNo.ForeColor = System.Drawing.Color.Black;
            this.cbbLoaiNo.FormattingEnabled = true;
            this.cbbLoaiNo.Items.AddRange(new object[] {
            "Đã trả nợ",
            "Đang nợ"});
            this.cbbLoaiNo.Location = new System.Drawing.Point(181, 337);
            this.cbbLoaiNo.Name = "cbbLoaiNo";
            this.cbbLoaiNo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbLoaiNo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbLoaiNo.Size = new System.Drawing.Size(226, 26);
            this.cbbLoaiNo.TabIndex = 7;
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
            this.txtThanhTien.Location = new System.Drawing.Point(181, 286);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PasswordChar = '\0';
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.Size = new System.Drawing.Size(226, 30);
            this.txtThanhTien.TabIndex = 6;
            // 
            // cbbDate
            // 
            this.cbbDate.BackColor = System.Drawing.Color.Transparent;
            this.cbbDate.BaseColor = System.Drawing.Color.White;
            this.cbbDate.BorderColor = System.Drawing.Color.Silver;
            this.cbbDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDate.FocusedColor = System.Drawing.Color.Empty;
            this.cbbDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbDate.ForeColor = System.Drawing.Color.Black;
            this.cbbDate.FormattingEnabled = true;
            this.cbbDate.Location = new System.Drawing.Point(181, 246);
            this.cbbDate.Name = "cbbDate";
            this.cbbDate.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbDate.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbDate.Size = new System.Drawing.Size(226, 26);
            this.cbbDate.TabIndex = 5;
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
            this.CbbTenKH.Location = new System.Drawing.Point(181, 147);
            this.CbbTenKH.Name = "CbbTenKH";
            this.CbbTenKH.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CbbTenKH.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CbbTenKH.Size = new System.Drawing.Size(226, 26);
            this.CbbTenKH.TabIndex = 3;
            // 
            // cbbMaHD
            // 
            this.cbbMaHD.BackColor = System.Drawing.Color.Transparent;
            this.cbbMaHD.BaseColor = System.Drawing.Color.White;
            this.cbbMaHD.BorderColor = System.Drawing.Color.Silver;
            this.cbbMaHD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaHD.FocusedColor = System.Drawing.Color.Empty;
            this.cbbMaHD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMaHD.ForeColor = System.Drawing.Color.Black;
            this.cbbMaHD.FormattingEnabled = true;
            this.cbbMaHD.Location = new System.Drawing.Point(181, 195);
            this.cbbMaHD.Name = "cbbMaHD";
            this.cbbMaHD.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbMaHD.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbMaHD.Size = new System.Drawing.Size(226, 26);
            this.cbbMaHD.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nhập mã hoá đơn";
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
            this.cbbMaKH.Location = new System.Drawing.Point(181, 96);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbMaKH.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbMaKH.Size = new System.Drawing.Size(226, 26);
            this.cbbMaKH.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày mua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nhập loại nợ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tổng tiền nợ";
            // 
            // txtMaNO
            // 
            this.txtMaNO.BaseColor = System.Drawing.Color.White;
            this.txtMaNO.BorderColor = System.Drawing.Color.Silver;
            this.txtMaNO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNO.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaNO.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaNO.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaNO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNO.Location = new System.Drawing.Point(181, 49);
            this.txtMaNO.Name = "txtMaNO";
            this.txtMaNO.PasswordChar = '\0';
            this.txtMaNO.SelectedText = "";
            this.txtMaNO.Size = new System.Drawing.Size(226, 30);
            this.txtMaNO.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nhập mã nợ";
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
            this.TimKiem.Location = new System.Drawing.Point(643, 70);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.PasswordChar = '\0';
            this.TimKiem.SelectedText = "";
            this.TimKiem.Size = new System.Drawing.Size(489, 41);
            this.TimKiem.TabIndex = 8;
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
            this.btnTimkiem.Location = new System.Drawing.Point(1158, 67);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(106, 44);
            this.btnTimkiem.TabIndex = 9;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(547, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "Từ khoá";
            // 
            // dgrQLNO
            // 
            this.dgrQLNO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrQLNO.Location = new System.Drawing.Point(568, 117);
            this.dgrQLNO.Name = "dgrQLNO";
            this.dgrQLNO.Size = new System.Drawing.Size(713, 310);
            this.dgrQLNO.TabIndex = 0;
            this.dgrQLNO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrQLNO_CellContentClick);
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
            this.btnKhoiTao.Location = new System.Drawing.Point(401, 450);
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
            this.btnSua.Location = new System.Drawing.Point(289, 450);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 44);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnThem.Location = new System.Drawing.Point(65, 450);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 44);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(374, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(522, 54);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "THÔNG TIN QUẢN LÝ NỢ";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnXoa.Location = new System.Drawing.Point(177, 450);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 44);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FormQLNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 558);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgrQLNO);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.group);
            this.MaximumSize = new System.Drawing.Size(1306, 597);
            this.MinimumSize = new System.Drawing.Size(1306, 597);
            this.Name = "FormQLNO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLNO";
            this.Load += new System.EventHandler(this.FormQLNO_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrQLNO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox group;
        private Guna.UI.WinForms.GunaComboBox CbbTenKH;
        private Guna.UI.WinForms.GunaComboBox cbbMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtMaNO;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox TimKiem;
        private FontAwesome.Sharp.IconButton btnTimkiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgrQLNO;
        private FontAwesome.Sharp.IconButton btnKhoiTao;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private Guna.UI.WinForms.GunaTextBox txtThanhTien;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cbbLoaiNo;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cbbDate;
        private Guna.UI.WinForms.GunaComboBox cbbMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnXoa;
    }
}