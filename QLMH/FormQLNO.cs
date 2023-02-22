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
    public partial class FormQLNO : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormQLNO()
        {
            InitializeComponent();
            txtMaNO.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "Insert into NO (MaKH,MaHD,LoaiNo) values(@MaKH,@MaHD,@LoaiNo)";
                cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = cbbMaKH.Text;
                cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = cbbMaHD.Text;
                cmd.Parameters.Add("@LoaiNo", SqlDbType.NVarChar).Value = cbbLoaiNo.Text;
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        private void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT MaNO,KHACHHANG.MaKH,KHACHHANG.TenKH,HOADON.MaHD,HOADON.NgayMua,ThanhTien,LoaiNo " +
                "FROM HOADON,NO,KHACHHANG " +
                "WHERE NO.MaKH = KHACHHANG.MaKH and NO.MaHD = HOADON.MaHD";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgrQLNO.DataSource = table;
        }

        private void FormQLNO_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadData();
            LoadKhacHang();
            
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
                cmd.CommandText = "delete from NO Where MaNO ='" + txtMaNO.Text + "'";
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
                cmd.CommandText = "Update NO Set MaKH = N'" + cbbMaKH.Text + "',MaHD = '" + cbbMaHD.Text + "',LoaiNo = N'" + cbbLoaiNo.Text + "' where MaNO='" + txtMaNO.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã sửa dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void dgrQLNO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNO.ReadOnly = true;
            int rowindex = dgrQLNO.CurrentCell.RowIndex;
            txtMaNO.Text = dgrQLNO.Rows[rowindex].Cells[0].Value.ToString();
            cbbMaKH.Text = dgrQLNO.Rows[rowindex].Cells[1].Value.ToString();
            CbbTenKH.Text = dgrQLNO.Rows[rowindex].Cells[2].Value.ToString();
            cbbMaHD.Text = dgrQLNO.Rows[rowindex].Cells[3].Value.ToString();
            cbbDate.Text = dgrQLNO.Rows[rowindex].Cells[4].Value.ToString();
            txtThanhTien.Text = dgrQLNO.Rows[rowindex].Cells[5].Value.ToString();
            cbbLoaiNo.Text = dgrQLNO.Rows[rowindex].Cells[6].Value.ToString();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaNO.Text = "";
            txtThanhTien.Text = "";
        }
    }
}
