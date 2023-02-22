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
    public partial class RegisterPassword : Form
    {
        public RegisterPassword()
        {
            InitializeComponent();
        }
        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public bool KiemTra()
        {
            if (txtuser.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập tên tài khoản !!";
                txtuser.Focus();
                return false;
            }
            else if (txtpass1.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu mới !!";
                txtrepass.Focus();
                return false;
            }
            else if (txtrepass.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng xác nhận mật khẩu !!";
                txtrepass.Focus();
                return false;
            }
            else if (txtpass1.Text != txtrepass.Text)
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Mật khẩu mới và mật khẩu xác nhận không trùng khớp";
                txtrepass.Focus();
                txtrepass.SelectAll();
                return false;
            }
            return true;
        }



        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaCheckBox1.Checked)
            {
                txtpass1.PasswordChar = (char)0;
                txtrepass.PasswordChar = (char)0;

            }
            else
            {
                txtpass1.PasswordChar = '*';
                txtrepass.PasswordChar = '*';
            }
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Update_Pass";
                cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txtuser.Text;
                cmd.Parameters.Add("@NewPass", SqlDbType.NVarChar).Value = txtpass1.Text;
                cmd.Connection = con;
                con.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if(dr.GetInt32(0) == 1)
                    {
                    lblShowInfor.ForeColor = System.Drawing.Color.Blue;
                    lblShowInfor.Text = dr.GetString(1);
                    txtpass1.Text = "";
                    txtrepass.Text = "";
                    txtpass1.Focus();
                }
                    else
                {
                    lblShowInfor.ForeColor = System.Drawing.Color.Red;
                    lblShowInfor.Text = dr.GetString(1);
                    txtpass1.Focus();
                    txtpass1.SelectAll();
                }
                dr.Read();
                dr.Close();
                con.Close();
            }
        }

        private void RegisterPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
