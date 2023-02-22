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

namespace QLMH
{
    public partial class FormKhachHang : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormKhachHang()
        {
            InitializeComponent();
            txtMaKH.ReadOnly = true;

        }
        private void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * From KHACHHANG";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrkhachHang.DataSource = table;
        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadData();
            TuTangMa();

        }
        public void TuTangMa()
        {
            int count = 0;
            count = dgrkhachHang.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgrkhachHang.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 5)));
            if (chuoi2 + 1 < 10)
            {
                txtMaKH.Text = "112KH0000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtMaKH.Text = "112KKH000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000)
            {
                txtMaKH.Text = "112KH00" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 10000)
            {
                txtMaKH.Text = "112KH0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100000)
            {
                txtMaKH.Text = "112KH" + (chuoi2 + 1).ToString();
            }
        }
        private void dgrkhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.ReadOnly = true;
            int rowindex = dgrkhachHang.CurrentCell.RowIndex;
            txtMaKH.Text = dgrkhachHang.Rows[rowindex].Cells[0].Value.ToString();
            txtTenKH.Text = dgrkhachHang.Rows[rowindex].Cells[1].Value.ToString();
            txtDate.Value = Convert.ToDateTime(dgrkhachHang.Rows[rowindex].Cells[2].Value.ToString());
            txtSDT.Text = dgrkhachHang.Rows[rowindex].Cells[3].Value.ToString();
            txtDiaChi.Text = dgrkhachHang.Rows[rowindex].Cells[4].Value.ToString();
            txtEmail.Text = dgrkhachHang.Rows[rowindex].Cells[5].Value.ToString();
            txtCMT.Text = dgrkhachHang.Rows[rowindex].Cells[6].Value.ToString();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgrkhachHang.FirstDisplayedScrollingRowIndex = dgrkhachHang.RowCount - 1;
            /////
            int count = 0;
            count = dgrkhachHang.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgrkhachHang.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 5)));
            if (chuoi2 + 1 < 10)
            {
                txtMaKH.Text = "112KH0000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtMaKH.Text = "112KKH000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000)
            {
                txtMaKH.Text = "112KH00" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 10000)
            {
                txtMaKH.Text = "112KH0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100000)
            {
                txtMaKH.Text = "112KH" + (chuoi2 + 1).ToString();
            }
            //
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "Insert into KHACHHANG(MaKH,TenKH,NgaySinh,SDT,DiaChi,Email,CMT) values (@maKH,@tenKH,@ngaySinh,@sDT,@diaChi,@email,@cMT)";
                cmd.Parameters.Add("@maKH", SqlDbType.NVarChar).Value = txtMaKH.Text;
                cmd.Parameters.Add("@tenKH", SqlDbType.NVarChar).Value = txtTenKH.Text;
                cmd.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value = txtDate.Text;
                cmd.Parameters.Add("@sDT", SqlDbType.Int).Value = txtSDT.Text;
                cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@cMT", SqlDbType.NVarChar).Value = txtCMT.Text;
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
                cmd.CommandText = "delete from KHACHHANG Where MaKH ='" + txtMaKH.Text + "'";
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
                cmd.CommandText = "Update KHACHHANG Set TenKH = N'" + txtTenKH.Text + "',NgaySinh = '" + txtDate.Text + "',SDT = '" + txtSDT.Text + "',DiaChi = N'" + txtDiaChi.Text + "',Email = '" + txtEmail.Text + "'," +
                "CMT = '" + txtCMT.Text + "' where MaKH='" + txtMaKH.Text + "'";
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
            TuTangMa();
            txtCMT.Text = "";
            txtDate.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            HomeForm but = new HomeForm();
            but.FormClosed += new FormClosedEventHandler(FormKhachHang_Load);
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
            cmd.CommandText = "Select * from KHACHHANG Where TenKH like N'%" + TimKiem.Text.Trim() + "%'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrkhachHang.DataSource = table;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            TimKiemLoad();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            FormQLNO but = new FormQLNO();
            but.Show();
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
