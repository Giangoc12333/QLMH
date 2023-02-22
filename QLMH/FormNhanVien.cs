using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Azure;
using System.Globalization;

namespace QLMH
{
    public partial class FormNhanVien : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormNhanVien()
        {
            InitializeComponent();
            txtMaNv.ReadOnly = true;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNS_SPDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            con = new SqlConnection(str);
            con.Open();
            LoadData();
            TuTangMa();
            loadChucvu();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * From NHANVIEN";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrNhanVien.DataSource = table;
        }
      
        private void btnThem_Click(object sender, EventArgs e)
        {
            ///
            dgrNhanVien.FirstDisplayedScrollingRowIndex = dgrNhanVien.RowCount - 1;
            ///
            int count = 0;
            count = dgrNhanVien.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgrNhanVien.Rows[count -2 ].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 +1 < 10)
            {
                txtMaNv.Text = "NV00" + (chuoi2 + 1).ToString();
            }
            else if(chuoi2 +1 < 100)
            {
                txtMaNv.Text = "NV" + (chuoi2 + 1).ToString();
            }

            ///
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "Insert into NHANVIEN values (@manv,@tenNV,@ngaySinh,@sDT,@diaChi,@email,@cMT,@maCV,@Matkhau)";
                cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = txtMaNv.Text;
                cmd.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = txtTenNv.Text;
                cmd.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value = txtDate.Text;
                cmd.Parameters.Add("@sDT", SqlDbType.Int).Value = txtSDT.Text;
                cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@cMT", SqlDbType.Int).Value = txtCMT.Text;
                cmd.Parameters.Add("@maCV", SqlDbType.Int).Value = cbbChucVu.Text;
                cmd.Parameters.Add("@Matkhau", SqlDbType.NVarChar).Value = txtpass.Text;
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi khi nhập dữ liệu!\n", ex.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from NHANVIEN Where MaNV ='"+txtMaNv.Text+"'";
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã xoá dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        public void loadChucvu()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select MaCV , ChucVu From CHUCVU", con);
                da.Fill(dt);
                cbbChucVu.DataSource = dt;
                cbbChucVu.DisplayMember = "MaCV";
                cbbChucVu.ValueMember = "MaCV";
                cbbtencv.DisplayMember = "ChucVu";
                cbbtencv.ValueMember = "ChucVu";
                cbbChucVu.DataSource = dt;
                cbbtencv.DataSource = dt;
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
                cmd.CommandText = "Update NHANVIEN Set TenNV = N'" + txtTenNv.Text + "',NgaySinh = '" + txtDate.Text + "',SDT = '" + txtSDT.Text + "',DiaChi = N'" + txtDiaChi.Text + "',Email = '" + txtEmail.Text + "'," +
                "CMT = '" + txtCMT.Text + "', MaCV = '" + cbbChucVu.Text + "',matkhau = '" + txtpass.Text + "' where MaNV='" + txtMaNv.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã sửa dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void dgrNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNv.ReadOnly = true;
            int rowindex = dgrNhanVien.CurrentCell.RowIndex;
            txtMaNv.Text = dgrNhanVien.Rows[rowindex].Cells[0].Value.ToString();
            txtTenNv.Text = dgrNhanVien.Rows[rowindex].Cells[1].Value.ToString();
            txtDate.Value = Convert.ToDateTime(dgrNhanVien.Rows[rowindex].Cells[2].Value.ToString());
            txtSDT.Text = dgrNhanVien.Rows[rowindex].Cells[3].Value.ToString();
            txtDiaChi.Text = dgrNhanVien.Rows[rowindex].Cells[4].Value.ToString();
            txtEmail.Text = dgrNhanVien.Rows[rowindex].Cells[5].Value.ToString();
            txtCMT.Text = dgrNhanVien.Rows[rowindex].Cells[6].Value.ToString();
            cbbChucVu.Text = dgrNhanVien.Rows[rowindex].Cells[7].Value.ToString();
            txtpass.Text = dgrNhanVien.Rows[rowindex].Cells[8].Value.ToString();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            TuTangMa();
            txtCMT.Text = "";
            txtDate.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtpass.Text = "";
            txtSDT.Text = "";
            txtTenNv.Text = "";
            cbbChucVu.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            HomeForm but = new HomeForm();
            but.FormClosed += new FormClosedEventHandler(FormNhanVien_Load);
            but.Show();
            this.Hide();
        }
        private void TimKiemLoad()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from NHANVIEN Where TenNV like N'%" + TimKiem.Text.Trim() + "%'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrNhanVien.DataSource = table;
        }
        private void TimKiemSDTLoad()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from NHANVIEN Where SDT like N'%" + TimKiem.Text.Trim() + "%'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrNhanVien.DataSource = table;
        }
        private void TimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemLoad();
            TimKiemSDTLoad();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            TimKiemLoad();
            TimKiemSDTLoad();
        }

        private void txtMaNv_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }
        public void TuTangMa()
        {
            int count = 0;
            count = dgrNhanVien.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgrNhanVien.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)
            {
                txtMaNv.Text = "NV00" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtMaNv.Text = "NV" + (chuoi2 + 1).ToString();
            }
        }
    }
}
