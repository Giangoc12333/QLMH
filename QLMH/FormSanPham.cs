using Azure;
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
    public partial class FormSanPham : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormSanPham()
        {
            InitializeComponent();
            txtMaSP.ReadOnly = true;
        }
        private void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select MaSP,TenSP, FORMAT((Gia), '#,##') AS Gia,SoLuong,MaNCC,MaDM  From SANPHAM";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrSanPham.DataSource = table;
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadData();
            loadNCC();
            LoadDANHMUC();
            TuTangMa();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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
        public void LoadDANHMUC()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select MaDM , TenDM From DANHMUC", con);
                da.Fill(dt);
                cbbMaDM.DataSource = dt;
                cbbMaDM.DisplayMember = "MaDM";
                cbbMaDM.ValueMember = "MaDM";
                cbbTenDM.DisplayMember = "TenDM";
                cbbTenDM.ValueMember = "TenDM";
                cbbMaDM.DataSource = dt;
                cbbTenDM.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void dgrSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.ReadOnly = true;
            int rowindex = dgrSanPham.CurrentCell.RowIndex;
            txtMaSP.Text = dgrSanPham.Rows[rowindex].Cells[0].Value.ToString();
            txtTenSP.Text = dgrSanPham.Rows[rowindex].Cells[1].Value.ToString();
            txtGia.Text = dgrSanPham.Rows[rowindex].Cells[2].Value.ToString();
            txtSoLuong.Text = dgrSanPham.Rows[rowindex].Cells[3].Value.ToString();
            cbbMaNCC.Text = dgrSanPham.Rows[rowindex].Cells[4].Value.ToString();
            cbbMaDM.Text = dgrSanPham.Rows[rowindex].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgrSanPham.FirstDisplayedScrollingRowIndex = dgrSanPham.RowCount - 1;
            ///
            int count = 0;
            count = dgrSanPham.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgrSanPham.Rows[count -2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0,5)));
            if (chuoi2 + 1 < 10)
            {
                txtMaSP.Text = "112SP0000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtMaSP.Text = "112SP000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000)
            {
                txtMaSP.Text = "112SP00" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 10000)
            {
                txtMaSP.Text = "112SP0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 10000)
            {
                txtMaSP.Text = "112SP" + (chuoi2 + 1).ToString();
            }

            ///
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "Insert into SANPHAM values (@masp,@tensp,@gia,@soluong,@MaNCC,@MaDM)";
                cmd.Parameters.Add("@masp", SqlDbType.NVarChar).Value = txtMaSP.Text;
                cmd.Parameters.Add("@tensp", SqlDbType.NVarChar).Value = txtTenSP.Text;
                cmd.Parameters.Add("@gia", SqlDbType.Int).Value = txtGia.Text;
                cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = txtSoLuong.Text;
                cmd.Parameters.Add("@MaNcc", SqlDbType.NVarChar).Value = cbbMaNCC.Text;
                cmd.Parameters.Add("@MaDM", SqlDbType.NVarChar).Value = cbbMaDM.Text;
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi nhập dữ liệu!\n", ex.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from SANPHAM Where MaSP ='" + txtMaSP.Text + "'";
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
                cmd.CommandText = "Update SANPHAM Set TenSP = N'" + txtTenSP.Text + "',Gia = '" + txtGia.Text + "',SoLuong = '" + txtSoLuong.Text + "',MaNCC = N'" + cbbMaNCC.Text + "',MaDM = '" + cbbMaDM.Text + "' where MaSP='" + txtMaSP.Text + "'";
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
            txtTenSP.Text = "";
            txtGia.Text = "";
            txtSoLuong.Text = "";
            TuTangMa();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            HomeForm but = new HomeForm();
            but.FormClosed += new FormClosedEventHandler(FormSanPham_Load);
            but.Show();
            this.Hide();
        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemLoad();
        }
        private void TimKiemLoad()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from SANPHAM Where TenSP like N'%" + TimKiem.Text.Trim() + "%'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrSanPham.DataSource = table;
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            TimKiemLoad();
        }

        private void btnThemDM_Click(object sender, EventArgs e)
        {
            FormDanhMuc but = new FormDanhMuc();
            but.Show();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            FormNCC but = new FormNCC();
            but.Show();
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
        }
        public void TuTangMa()
        {
            int count = 0;
            count = dgrSanPham.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgrSanPham.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 5)));
            if (chuoi2 + 1 < 10)
            {
                txtMaSP.Text = "112SP0000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtMaSP.Text = "112SP000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000)
            {
                txtMaSP.Text = "112SP00" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 10000)
            {
                txtMaSP.Text = "112SP0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 10000)
            {
                txtMaSP.Text = "112SP" + (chuoi2 + 1).ToString();
            }
        }
        private void txtGia_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}