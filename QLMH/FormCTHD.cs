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
    public partial class FormCTHD : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormCTHD()
        {
            InitializeComponent();
            txtMaCTHD.ReadOnly = true;
            txtTongTien.ReadOnly = true;
        }

        private void FormCTHD_Load(object sender, EventArgs e)
        { 
            con = new SqlConnection(str);
            con.Open();
            LoadData();
            TongTien();
            LoadSanPham();
            LoadKhacHang();
        }
        private void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select MaCT,CHITIETHD.MaHD,CHITIETHD.MaKH,KHACHHANG.TenKH,CHITIETHD.MaSP,CHITIETHD.TenSP,NgayMua,CHITIETHD.SoLuong,FORMAT((GiaMua), '#,##') AS GiaMua,FORMAT((ThanhTien), '#,##') AS ThanhTien" +
                " From HOADON, KHACHHANG, SANPHAM, CHITIETHD" +
                " where CHITIETHD.MaSP = SANPHAM.MaSP and CHITIETHD.MaKH = KHACHHANG.MaKH and CHITIETHD.MaHD = HOADON.MaHD";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrCTHD.DataSource = table;
        }
        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            double sl = Convert.ToDouble(txtsoluong.Text);
            int gia = Convert.ToInt32(cbbgia.SelectedValue);
            double tong = (sl * gia);
            txtThanhTien.Text = tong.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgrCTHD.FirstDisplayedScrollingRowIndex = dgrCTHD.RowCount - 1;


            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "Insert into CHITIETHD (CHITIETHD.MaKH, CHITIETHD.MaHD, CHITIETHD.MaSP,CHITIETHD.TenSP, CHITIETHD.SoLuong, CHITIETHD.GiaMua) " +
                    "values (@maKh, @maHD, @masP,@TenSP, @soluong, @gia)";
                cmd.Parameters.Add("@maKh", SqlDbType.NVarChar).Value = cbbMaKH.Text;
                cmd.Parameters.Add("@maHD", SqlDbType.NVarChar).Value = cbbMaHD.Text;
                cmd.Parameters.Add("@masP", SqlDbType.NVarChar).Value = cbbMaSP.Text;
                cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = cbbTenSP.Text;
                cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = txtsoluong.Text;
                cmd.Parameters.Add("@gia", SqlDbType.Int).Value = cbbgia.Text;
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi khi Thêm dữ liệu!\n", ex.ToString());
            }
        }
   
        public void LoadSanPham()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select MaSP, TenSP , Gia From SANPHAM", con);
                da.Fill(dt);
                cbbMaSP.DisplayMember = "MaSP";
                cbbMaSP.ValueMember = "MaSP";
                cbbTenSP.DisplayMember = "TenSP";
                cbbTenSP.ValueMember = "TenSP";
                cbbgia.DisplayMember = "Gia";
                cbbgia.ValueMember = "Gia";
                cbbMaSP.DataSource = dt;
                cbbgia.DataSource = dt;
                cbbTenSP.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        public void LoadKhacHang()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select HOADON.MaHD, HOADON.MaKH, KHACHHANG.TenKH,HOADON.NgayMua From HOADON,KHACHHANG where KHACHHANG.MaKH = HOADON.MaKH", con);
                da.Fill(dt);
                cbbMaHD.DisplayMember = "MaHD";
                cbbMaHD.ValueMember = "MaHD";
                cbbMaKH.DisplayMember = "MaKH";
                cbbMaKH.ValueMember = "MaKH";
                CbbTenKH.DisplayMember = "TenKH";
                CbbTenKH.ValueMember = "TenKH";
                cbbDate.DisplayMember = "NgayMua";
                cbbDate.ValueMember = "NgayMua";
                cbbDate.DataSource = dt;
                cbbMaHD.DataSource = dt;
                cbbMaKH.DataSource = dt;
                CbbTenKH.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from CHITIETHD Where MaCT ='" + txtMaCTHD.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã xoá dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi Xoá dữ liệu!\n", ex.ToString());
            }
        }
        private void dgrCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCTHD.ReadOnly = true;
            int rowindex = dgrCTHD.CurrentCell.RowIndex;
            txtMaCTHD.Text = dgrCTHD.Rows[rowindex].Cells[0].Value.ToString();
            cbbMaHD.Text = dgrCTHD.Rows[rowindex].Cells[1].Value.ToString();
            cbbMaKH.Text = dgrCTHD.Rows[rowindex].Cells[2].Value.ToString();
            CbbTenKH.Text = dgrCTHD.Rows[rowindex].Cells[3].Value.ToString();
            cbbMaSP.Text = dgrCTHD.Rows[rowindex].Cells[4].Value.ToString();
            cbbTenSP.Text = dgrCTHD.Rows[rowindex].Cells[5].Value.ToString();
            cbbDate.Text = dgrCTHD.Rows[rowindex].Cells[6].Value.ToString();
            txtsoluong.Text = dgrCTHD.Rows[rowindex].Cells[7].Value.ToString();
            cbbgia.Text = dgrCTHD.Rows[rowindex].Cells[8].Value.ToString();
            txtThanhTien.Text = dgrCTHD.Rows[rowindex].Cells[9].Value.ToString();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
        }
        private void TongTien()
        {
            string sql = "SELECT  FORMAT(sum(ThanhTien), '#,##') AS ThanhTien from CHITIETHD ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtTongTien.Text = dr["ThanhTien"].ToString();
            }
            dr.Close();
        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemLoad();
        }
        private void TimKiemLoad()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select MaCT,CHITIETHD.MaHD,CHITIETHD.MaKH,TenKH,CHITIETHD.MaSP,TenSP,NgayMua,CHITIETHD.SoLuong,Gia,ThanhTien" +
                " From HOADON, KHACHHANG, SANPHAM, CHITIETHD" +
                " where CHITIETHD.MaSP = SANPHAM.MaSP and CHITIETHD.MaKH = KHACHHANG.MaKH and CHITIETHD.MaHD = HOADON.MaHD and TenKH like N'%" + TimKiem.Text.Trim() + "%'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrCTHD.DataSource = table;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            TimKiemLoad();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "Update CHITIETHD Set MaKH = N'" + cbbMaKH.Text + "',MaHD = '" + cbbMaHD.Text + "',MaSP = '" + cbbMaSP.Text + "',TenSP = N'" + cbbTenSP.Text + "',SoLuong = N'" + txtsoluong.Text + "',GiaMua = '" + cbbgia.Text + "' where MaCT='" + txtMaCTHD.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã sửa dữ liệu thành công!");
            }
            catch (Exception ex )
            {
                MessageBox.Show("Có lỗi khi Sữa dữ liệu!\n", ex.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            HomeForm but = new HomeForm();
            but.FormClosed += new FormClosedEventHandler(FormCTHD_Load);
            but.Show();
            this.Hide();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaCTHD.Text = "";
            txtsoluong.Text = "";
            TongTien();
        }

        private void InCTHD_Click(object sender, EventArgs e)
        {

        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMaCTHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInHoaDon_Click(object sender, EventArgs e)
        {
            FormINHD but = new FormINHD();
            but.Show();
        }
    }
}
