
namespace QLMH
{
    partial class FormDanhMuc
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
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtTenDM = new Guna.UI.WinForms.GunaTextBox();
            this.txtMaDM = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgrDanhMuc = new System.Windows.Forms.DataGridView();
            this.btnKhoiTao = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.txtTenDM);
            this.gunaGroupBox1.Controls.Add(this.txtMaDM);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 94);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(469, 310);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.Text = "Thông tin danh mục";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtTenDM
            // 
            this.txtTenDM.BaseColor = System.Drawing.Color.White;
            this.txtTenDM.BorderColor = System.Drawing.Color.Silver;
            this.txtTenDM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDM.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenDM.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenDM.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenDM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDM.Location = new System.Drawing.Point(183, 133);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.PasswordChar = '\0';
            this.txtTenDM.SelectedText = "";
            this.txtTenDM.Size = new System.Drawing.Size(210, 30);
            this.txtTenDM.TabIndex = 1;
            // 
            // txtMaDM
            // 
            this.txtMaDM.BaseColor = System.Drawing.Color.White;
            this.txtMaDM.BorderColor = System.Drawing.Color.Silver;
            this.txtMaDM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDM.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaDM.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaDM.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaDM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaDM.Location = new System.Drawing.Point(183, 71);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.PasswordChar = '\0';
            this.txtMaDM.SelectedText = "";
            this.txtMaDM.Size = new System.Drawing.Size(210, 30);
            this.txtMaDM.TabIndex = 0;
            this.txtMaDM.TextChanged += new System.EventHandler(this.txtMaDM_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nhập tên danh mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập danh mục";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(308, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(494, 54);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "THÔNG TIN DANH MỤC";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgrDanhMuc
            // 
            this.dgrDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDanhMuc.Location = new System.Drawing.Point(503, 94);
            this.dgrDanhMuc.Name = "dgrDanhMuc";
            this.dgrDanhMuc.Size = new System.Drawing.Size(577, 310);
            this.dgrDanhMuc.TabIndex = 6;
            this.dgrDanhMuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhMuc_CellContentClick);
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
            this.btnKhoiTao.Location = new System.Drawing.Point(615, 457);
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
            this.btnSua.Location = new System.Drawing.Point(503, 457);
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
            this.btnXoa.Location = new System.Drawing.Point(390, 457);
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
            this.btnThem.Location = new System.Drawing.Point(278, 457);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 44);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 571);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgrDanhMuc);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaGroupBox1);
            this.MaximumSize = new System.Drawing.Size(1108, 610);
            this.MinimumSize = new System.Drawing.Size(1108, 610);
            this.Name = "FormDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDanhMuc";
            this.Load += new System.EventHandler(this.FormDanhMuc_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtTenDM;
        private Guna.UI.WinForms.GunaTextBox txtMaDM;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridView dgrDanhMuc;
        private FontAwesome.Sharp.IconButton btnKhoiTao;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
    }
}