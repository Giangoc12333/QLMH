using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMH
{
    public partial class FormINHD : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormINHD()
        {
            InitializeComponent();
        }

        private void FormINHD_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadKhacHang();
            // TODO: This line of code loads data into the 'QLNS_SPDataSet1.CHITIETHD' table. You can move, or remove it, as needed.
            this.CHITIETHDTableAdapter.Fill(this.QLNS_SPDataSet1.CHITIETHD);

            this.reportViewer1.RefreshReport();
        }
        public void LoadKhacHang()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select HOADON.MaHD, HOADON.MaKH, KHACHHANG.TenKH From HOADON,KHACHHANG where KHACHHANG.MaKH = HOADON.MaKH", con);
                da.Fill(dt);
                cbbMaHD.DisplayMember = "MaHD";
                cbbMaHD.ValueMember = "MaHD";
                cbbMaKH.DisplayMember = "MaKH";
                cbbMaKH.ValueMember = "MaKH";
                CbbTenKH.DisplayMember = "TenKH";
                CbbTenKH.ValueMember = "TenKH";
                cbbMaHD.DataSource = dt;
                cbbMaKH.DataSource = dt;
                CbbTenKH.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1");
            SqlCommand cmd = new SqlCommand("Select CHITIETHD.MaHD,CHITIETHD.MaSP,CHITIETHD.TenSP,CHITIETHD.MaKH,KHACHHANG.TenKH ,CHITIETHD.SoLuong, CHITIETHD.GiaMua,CHITIETHD.ThanhTien from CHITIETHD,SANPHAM,HOADON,KHACHHANG where CHITIETHD.MaSp = SANPHAM.MaSP and CHITIETHD.MaHD = HOADON.MaHD and KHACHHANG.MaKH = CHITIETHD.MaKH and CHITIETHD.MaHD  like '" + cbbMaHD.Text + "'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            ReportDataSource rds = new ReportDataSource("DataSet1", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
