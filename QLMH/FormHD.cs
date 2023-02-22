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
    public partial class FormHD : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormHD()
        {
            InitializeComponent();
            txtMaHD.ReadOnly = true;
        }

        private void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select MaHD,HOADON.MaKH,TenKH,NgayMua From HOADON,KHACHHANG where  KHACHHANG.MaKH = HOADON.MaKH";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrHoaDon.DataSource = table;
        }
        private void FormHD_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadKhacHang();
            LoadData();
            TuTangMa();
        }
        public void TuTangMa()
        {
            ///
            int count = 0;
            count = dgrHoaDon.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgrHoaDon.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 5)));
            if (chuoi2 + 1 < 10)
            {
                txtMaHD.Text = "112HD00000000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtMaHD.Text = "112HD00000000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000)
            {
                txtMaHD.Text = "112HD0000000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 10000)
            {
                txtMaHD.Text = "112HD000000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100000)
            {
                txtMaHD.Text = "112HD00000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000000)
            {
                txtMaHD.Text = "112HD0000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 10000000)
            {
                txtMaHD.Text = "112HD000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000000000)
            {
                txtMaHD.Text = "112HD00" + (chuoi2 + 1).ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            dgrHoaDon.FirstDisplayedScrollingRowIndex = dgrHoaDon.RowCount - 1;
            ///
            int count = 0;
            count = dgrHoaDon.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgrHoaDon.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 5)));
            if (chuoi2 + 1 < 10)
            {
                txtMaHD.Text = "112HD00000000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtMaHD.Text = "112HD00000000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000)
            {
                txtMaHD.Text = "112HD0000000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 10000)
            {
                txtMaHD.Text = "112HD000000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100000)
            {
                txtMaHD.Text = "112HD00000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000000)
            {
                txtMaHD.Text = "112HD0000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 10000000)
            {
                txtMaHD.Text = "112HD000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000000000)
            {
                txtMaHD.Text = "112HD00" + (chuoi2 + 1).ToString();
            }
            ///
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "Insert into HOADON values (@maHD,@MaKH,@ngayMua)";
                cmd.Parameters.Add("@maHD", SqlDbType.NVarChar).Value = txtMaHD.Text;
                cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = cbbMaKH.SelectedValue;
                cmd.Parameters.Add("@ngayMua", SqlDbType.DateTime).Value = txtDate.Text;
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi nhập dữ liệu!\n", ex.ToString());
            }
        }
        public void LoadKhacHang()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select MaKH, TenKH From KHACHHANG", con);
                da.Fill(dt);
                cbbMaKH.DisplayMember = "MaKH";
                cbbMaKH.ValueMember = "MaKH";
                CbbTenKH.DisplayMember = "TenKH";
                CbbTenKH.ValueMember = "TenKH";
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
                cmd.CommandText = "delete from HOADON Where MaHD ='" + txtMaHD.Text + "'";
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
                cmd.CommandText = "Update HOADON Set MaKH = N'" + cbbMaKH.Text + "',NgayMua = '" + txtDate.Text + "'where MaHD='" + txtMaHD.Text + "'";
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
        }

        private void dgrHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.ReadOnly = true;
            int rowindex = dgrHoaDon.CurrentCell.RowIndex;
            txtMaHD.Text = dgrHoaDon.Rows[rowindex].Cells[0].Value.ToString();
            cbbMaKH.Text = dgrHoaDon.Rows[rowindex].Cells[1].Value.ToString();
            CbbTenKH.Text = dgrHoaDon.Rows[rowindex].Cells[2].Value.ToString();
            txtDate.Value = Convert.ToDateTime(dgrHoaDon.Rows[rowindex].Cells[3].Value.ToString());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            HomeForm but = new HomeForm();
            but.FormClosed += new FormClosedEventHandler(FormHD_Load);
            but.Show();
            this.Hide();
        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemSDTLoad();
        }
        private void TimKiemSDTLoad()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select MaHD,HOADON.MaKH,KHACHHANG.TenKH,NgayMua from HOADON,KHACHHANG Where KHACHHANG.MaKH = HOADON.MaKH AND KHACHHANG.TenKH like N'%" + TimKiem.Text.Trim() + "%'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrHoaDon.DataSource = table;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            TimKiemSDTLoad();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
