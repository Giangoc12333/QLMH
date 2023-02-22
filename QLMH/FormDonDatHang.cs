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
    public partial class FormDonDatHang : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormDonDatHang()
        {
            InitializeComponent();
            txtMaDH.ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgrDonDatHang.FirstDisplayedScrollingRowIndex = dgrDonDatHang.RowCount - 1;
            try
            {

                cmd = con.CreateCommand();
                cmd.CommandText = "Insert into DONDATHANG (MaNV,MaNCC,TeNDH,NgayDAT,SoLuong,Gia) values(@MaNV,@MaNCC,@TenDH,@NgayDAT,@SoLuong,@Gia)";
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = cbbMaNV.Text;
                cmd.Parameters.Add("@MaNCC", SqlDbType.NVarChar).Value = cbbMaNCC.Text;
                cmd.Parameters.Add("@TenDH", SqlDbType.NVarChar).Value = txtTenHang.Text;
                cmd.Parameters.Add("@NgayDAT", SqlDbType.Date).Value = txtDate.Text;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = txtsoluong.Text;
                cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = txtGia.Text;
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void FormDonDatHang_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadData();
            LoadNHANVIEN();
            loadNCC();
        }
        private void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select DONDATHANG.MaDH, DONDATHANG.MaNV , NHANVIEN.TenNV, DONDATHANG.TenDH, DONDATHANG.NgayDat,DONDATHANG.MaNCC,NHACUNGCAP.TenNCC, DONDATHANG.Soluong,FORMAT(Gia, '#,##') AS gia , FORMAT(TongGia, '#,##') AS TongGia " +
                "from DONDATHANG, NHACUNGCAP, NHANVIEN " +
                "where DONDATHANG.MaNV = NHANVIEN.MaNV and DONDATHANG.MaNCC = NHACUNGCAP.MaNCC";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrDonDatHang.DataSource = table;
        }
        public void loadNCC()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select MaNCC , TenNCC From NHACUNGCAP", con);
                da.Fill(dt);
                cbbMaNCC.DataSource = dt;
                cbbMaNCC.DisplayMember = "MaNCC";
                cbbMaNCC.ValueMember = "MaNCC";
                cbbTenNcc.DisplayMember = "TenNCC";
                cbbTenNcc.ValueMember = "TenNCC";
                cbbMaNCC.DataSource = dt;
                cbbTenNcc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        public void LoadNHANVIEN()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select MaNV , TenNV From NHANVIEN", con);
                da.Fill(dt);
                cbbMaNV.DataSource = dt;
                cbbMaNV.DisplayMember = "MaNV";
                cbbMaNV.ValueMember = "MaNV";
                cbbTenNv.DisplayMember = "TenNV";
                cbbTenNv.ValueMember = "TenNV";
                cbbMaNV.DataSource = dt;
                cbbTenNv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            FormNCC but = new FormNCC();
            but.Show();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            FormSanPham but = new FormSanPham();
            but.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from DONDATHANG Where MaDH ='" + txtMaDH.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã xoá dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "Update DONDATHANG Set MaNV = N'" + cbbMaNV.Text + "',MaNCC = N'" + cbbMaNCC.Text + "', TeNDH = N'" + txtTenHang.Text + "',NgayDAT = '" + txtDate.Text + "',SoLuong = '" + txtsoluong.Text + "',Gia = N'" + txtGia.Text + "' where MaDH='" + txtMaDH.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã sửa dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaDH.Text = "";
            txtGia.Text = "";
            txtsoluong.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            HomeForm but = new HomeForm();
            but.FormClosed += new FormClosedEventHandler(FormDonDatHang_Load);
            but.Show();
            this.Hide();
        }

        private void dgrDonDatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDH.ReadOnly = true;
            int rowindex = dgrDonDatHang.CurrentCell.RowIndex;
            txtMaDH.Text = dgrDonDatHang.Rows[rowindex].Cells[0].Value.ToString();
            cbbMaNV.Text = dgrDonDatHang.Rows[rowindex].Cells[1].Value.ToString();
            cbbTenNcc.Text = dgrDonDatHang.Rows[rowindex].Cells[2].Value.ToString();
            txtTenHang.Text = dgrDonDatHang.Rows[rowindex].Cells[3].Value.ToString();
            txtDate.Text = dgrDonDatHang.Rows[rowindex].Cells[4].Value.ToString();
            cbbMaNCC.Text = dgrDonDatHang.Rows[rowindex].Cells[5].Value.ToString();
            cbbTenNcc.Text = dgrDonDatHang.Rows[rowindex].Cells[6].Value.ToString();
            txtsoluong.Text = dgrDonDatHang.Rows[rowindex].Cells[7].Value.ToString();
            txtGia.Text = dgrDonDatHang.Rows[rowindex].Cells[8].Value.ToString();
            txtThanhTien.Text = dgrDonDatHang.Rows[rowindex].Cells[9].Value.ToString();
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    double sl = Convert.ToDouble(txtsoluong.Text);
            //    double gia = Convert.ToDouble(txtGia.Text);
            //    double tong = (sl * gia);
            //    txtThanhTien.Text = tong.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            //}
        }

        private void InCTHD_Click(object sender, EventArgs e)
        {
            FormINDH but = new FormINDH();
            but.Show();

        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {
          timkiemTenDH();
        }
        public void timkiemTenDH()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select DONDATHANG.MaDH, DONDATHANG.MaNV , NHANVIEN.TenNV, DONDATHANG.TenDH, DONDATHANG.NgayDat,DONDATHANG.MaNCC,NHACUNGCAP.TenNCC, DONDATHANG.Soluong, DONDATHANG.Gia, DONDATHANG.TongGia " +
                "from DONDATHANG, NHACUNGCAP, NHANVIEN " +
                " where DONDATHANG.MaNV = NHANVIEN.MaNV and DONDATHANG.MaNCC = NHACUNGCAP.MaNCC and TeNDH like N'%" + TimKiem.Text.Trim() + "%'" ;
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrDonDatHang.DataSource = table;
        }
        public void timkiemTenNCC()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select DONDATHANG.MaDH, DONDATHANG.MaNV , NHANVIEN.TenNV, DONDATHANG.TenDH, DONDATHANG.NgayDat,DONDATHANG.MaNCC,NHACUNGCAP.TenNCC, DONDATHANG.Soluong, DONDATHANG.Gia, DONDATHANG.TongGia " +
                "from DONDATHANG, NHACUNGCAP, NHANVIEN " +
                " where DONDATHANG.MaNV = NHANVIEN.MaNV and DONDATHANG.MaNCC = NHACUNGCAP.MaNCC and TenNCC like N'%" + TimKiem.Text.Trim() + "%'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrDonDatHang.DataSource = table;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            timkiemTenNCC();
        }

        private void txtMaDH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
