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
    public partial class FormDanhMuc : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormDanhMuc()
        {
            InitializeComponent();
            txtMaDM.ReadOnly = true;
        }
        private void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * From DANHMUC";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrDanhMuc.DataSource = table;
        }
        public void TuTangMa()
        {
            int count = 0;
            count = dgrDanhMuc.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgrDanhMuc.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)
            {
                txtMaDM.Text = "DM00" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtMaDM.Text = "DM0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000)
            {
                txtMaDM.Text = "DM" + (chuoi2 + 1).ToString();
            }
        }
        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadData();
            TuTangMa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgrDanhMuc.FirstDisplayedScrollingRowIndex = dgrDanhMuc.RowCount - 1;
            ///
            int count = 0;
            count = dgrDanhMuc.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgrDanhMuc.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)
            {
                txtMaDM.Text = "DM00" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtMaDM.Text = "DM0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000)
            {
                txtMaDM.Text = "DM" + (chuoi2 + 1).ToString();
            }
            ///
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "Insert into DANHMUC values (@madm,@tendm)";
                cmd.Parameters.Add("@madm", SqlDbType.NVarChar).Value = txtMaDM.Text;
                cmd.Parameters.Add("@tendm", SqlDbType.NVarChar).Value = txtTenDM.Text;
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi Thêm dữ liệu!\n", ex.ToString());
            }
        }

        private void dgrDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDM.ReadOnly = true;
            int rowindex = dgrDanhMuc.CurrentCell.RowIndex;
            txtMaDM.Text = dgrDanhMuc.Rows[rowindex].Cells[0].Value.ToString();
            txtTenDM.Text = dgrDanhMuc.Rows[rowindex].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from DANHMUC Where MaDM ='" + txtMaDM.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã xoá dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi Xoá dữ liệu!\n", ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "Update DANHMUC Set TenDM = N'" + txtTenDM.Text + "' where MaDM='" + txtMaDM.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã sửa dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi sửa dữ liệu!\n", ex.ToString());
            }
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            TuTangMa();
            txtTenDM.Text = "";
        }

        private void txtMaDM_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
