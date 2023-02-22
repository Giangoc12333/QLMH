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
    public partial class FormINDH : Form
    {
        public FormINDH()
        {
            InitializeComponent();
        }

        private void FormINHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
            // TODO: This line of code loads data into the 'QLNS_SPDataSet1.DONDATHANG' table. You can move, or remove it, as needed.
            reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1");
            //    SqlCommand cmd = new SqlCommand("Select * from DONDATHANG WHERE NgayDAT='" + txtDate.Text + "'", con);
            //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //    DataTable table = new DataTable();
            //    adapter.Fill(table);
            //    ReportDataSource rds = new ReportDataSource("DataSet1", table);
            //    reportViewer1.LocalReport.DataSources.Clear();
            //    reportViewer1.LocalReport.DataSources.Add(rds);
            //    reportViewer1.RefreshReport();
            //}
            //catch (Exception ex)
            //{
            //   MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            //}
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1");
            SqlCommand cmd = new SqlCommand("Select DONDATHANG.MaDH, DONDATHANG.MaNV , DONDATHANG.TenDH, DONDATHANG.NgayDat,DONDATHANG.MaNCC, DONDATHANG.Soluong,Gia,TongGia,NHACUNGCAP.TenNCC from DONDATHANG,NHACUNGCAP WHERE NHACUNGCAP.MaNCC =DONDATHANG.MaNCC and  NgayDAT LIKE '" + txtDate.Text+ "'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            ReportDataSource rds = new ReportDataSource("DataSet1", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
