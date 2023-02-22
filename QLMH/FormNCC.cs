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
    public partial class FormNCC : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormNCC()
        {
            InitializeComponent();
            txtMaNCC.ReadOnly = true;
        }

        private void FormNCC_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadData();
            TuTangMa();
        }
        private void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * From NHACUNGCAP";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrNhaCungCap.DataSource = table;
        }
        public void TuTangMa()
        {
            int count = 0;
            count = dgrNhaCungCap.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgrNhaCungCap.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)
            {
                txtMaNCC.Text = "NCC00" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtMaNCC.Text = "NCC0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000)
            {
                txtMaNCC.Text = "NCC" + (chuoi2 + 1).ToString();
            }
        }
        private void dgrNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.ReadOnly = true;
            int rowindex = dgrNhaCungCap.CurrentCell.RowIndex;
            txtMaNCC.Text = dgrNhaCungCap.Rows[rowindex].Cells[0].Value.ToString();
            txtTenNCC.Text = dgrNhaCungCap.Rows[rowindex].Cells[1].Value.ToString();
            txtSDT.Text = dgrNhaCungCap.Rows[rowindex].Cells[2].Value.ToString();
            txtDiaChi.Text = dgrNhaCungCap.Rows[rowindex].Cells[3].Value.ToString();
            txtEmail.Text = dgrNhaCungCap.Rows[rowindex].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ///
            dgrNhaCungCap.FirstDisplayedScrollingRowIndex = dgrNhaCungCap.RowCount - 1;
            ///
            int count = 0;
            count = dgrNhaCungCap.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgrNhaCungCap.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)
            {
                txtMaNCC.Text = "NCC00" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtMaNCC.Text = "NCC0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000)
            {
                txtMaNCC.Text = "NCC" + (chuoi2 + 1).ToString();
            }

            ///
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "Insert into NHACUNGCAP values (@mancc,@tenncc,@diaChi,@sDT,@email)";
                cmd.Parameters.Add("@mancc", SqlDbType.NVarChar).Value = txtMaNCC.Text;
                cmd.Parameters.Add("@tenncc", SqlDbType.NVarChar).Value = txtTenNCC.Text;
                cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                cmd.Parameters.Add("@sDT", SqlDbType.Int).Value = txtSDT.Text;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmail.Text;
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi nhập dữ liệu!\n", ex.ToString());
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from NHACUNGCAP Where MaNCC ='" + txtMaNCC.Text + "'";
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
                cmd.CommandText = "Update NHACUNGCAP Set TenNCC = N'" + txtTenNCC.Text + "',DiaChi = N'" + txtDiaChi.Text + "',SDT = '" + txtSDT.Text + "',Email = '" + txtEmail.Text + "' where MaNCC = '" + txtMaNCC.Text + "'"; ;
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
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {
       
        }
    }
}
