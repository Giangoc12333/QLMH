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
using System.Runtime.InteropServices;

namespace QLMH
{
    public partial class LoginForm : Form
    {
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
        public LoginForm()
        {
            InitializeComponent();

        }
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUser.Text = Properties.Settings.Default.User;
            txtPass.Text = Properties.Settings.Default.Password;
             this.Show();
        }
        //di chuyển cửa sổ
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSUGHA;Initial Catalog=QLNS_SP;Persist Security Info=True;User ID=sa;Password=giangoc1");
            con.Open();
            string tk = txtUser.Text;
            string mk = txtPass.Text;
            string sql = "Select * from TAIKHOAN where TaiKhoan ='" + tk + "'and Matkhau ='" + mk + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader data = cmd.ExecuteReader();
            SaveSetting();
            if (dt.Rows.Count > 0 && data.Read() == true)
            {
                HomeForm but = new HomeForm();
                but.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản/mật khẩu" + "\nMời bạn nhập lại!!");
            }

        }
        private void SaveSetting()
        {
            if (gunaCheckBox1.Checked == true)
            {
                Properties.Settings.Default.User = txtUser.Text;
                Properties.Settings.Default.Password = txtPass.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.User = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
            RegisterPassword but = new RegisterPassword();
            but.Show();
            this.Hide();
        }

        private void gunaPictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
