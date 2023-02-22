
namespace QLMH
{
    partial class FormINHD
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CHITIETHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLNS_SPDataSet1 = new QLMH.QLNS_SPDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CHITIETHDTableAdapter = new QLMH.QLNS_SPDataSet1TableAdapters.CHITIETHDTableAdapter();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CbbTenKH = new Guna.UI.WinForms.GunaComboBox();
            this.cbbMaKH = new Guna.UI.WinForms.GunaComboBox();
            this.cbbMaHD = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CHITIETHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNS_SPDataSet1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CHITIETHDBindingSource
            // 
            this.CHITIETHDBindingSource.DataMember = "CHITIETHD";
            this.CHITIETHDBindingSource.DataSource = this.QLNS_SPDataSet1;
            // 
            // QLNS_SPDataSet1
            // 
            this.QLNS_SPDataSet1.DataSetName = "QLNS_SPDataSet1";
            this.QLNS_SPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.CHITIETHDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLMH.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 169);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(987, 557);
            this.reportViewer1.TabIndex = 0;
            // 
            // CHITIETHDTableAdapter
            // 
            this.CHITIETHDTableAdapter.ClearBeforeFill = true;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.txtTimKiem);
            this.gunaPanel1.Controls.Add(this.CbbTenKH);
            this.gunaPanel1.Controls.Add(this.cbbMaKH);
            this.gunaPanel1.Controls.Add(this.cbbMaHD);
            this.gunaPanel1.Controls.Add(this.label2);
            this.gunaPanel1.Controls.Add(this.label7);
            this.gunaPanel1.Controls.Add(this.label3);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(987, 169);
            this.gunaPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoá Đơn";
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
            this.CbbTenKH.Location = new System.Drawing.Point(611, 120);
            this.CbbTenKH.Name = "CbbTenKH";
            this.CbbTenKH.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CbbTenKH.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CbbTenKH.Size = new System.Drawing.Size(226, 26);
            this.CbbTenKH.TabIndex = 14;
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
            this.cbbMaKH.Location = new System.Drawing.Point(611, 88);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbMaKH.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbMaKH.Size = new System.Drawing.Size(226, 26);
            this.cbbMaKH.TabIndex = 15;
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
            this.cbbMaHD.Location = new System.Drawing.Point(156, 84);
            this.cbbMaHD.Name = "cbbMaHD";
            this.cbbMaHD.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbMaHD.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbMaHD.Size = new System.Drawing.Size(226, 26);
            this.cbbMaHD.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhập mã khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nhập mã hoá đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nhập tên khách hàng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimKiem.Location = new System.Drawing.Point(868, 88);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(94, 30);
            this.txtTimKiem.TabIndex = 17;
            this.txtTimKiem.Text = "Tìm Kiếm";
            this.txtTimKiem.UseVisualStyleBackColor = false;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // FormINHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 726);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "FormINHD";
            this.Text = "FormINHD";
            this.Load += new System.EventHandler(this.FormINHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CHITIETHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNS_SPDataSet1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CHITIETHDBindingSource;
        private QLNS_SPDataSet1 QLNS_SPDataSet1;
        private QLNS_SPDataSet1TableAdapters.CHITIETHDTableAdapter CHITIETHDTableAdapter;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox CbbTenKH;
        private Guna.UI.WinForms.GunaComboBox cbbMaKH;
        private Guna.UI.WinForms.GunaComboBox cbbMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txtTimKiem;
    }
}