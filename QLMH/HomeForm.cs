using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace QLMH
{
    public partial class HomeForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentForm;


        public HomeForm()
        {
            //lấy kích thước của màn hình
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            //cho form hiển thị theo kích thước của màn hình
            this.Width = widthScreen;
            this.Height = heightScreen;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PanelSlideMenu.Controls.Add(leftBorderBtn);
            //
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        //di chuyển cửa sổ
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colors.color1);
            OpenForm(new FormNhanVien());
        }
        private struct colors
        {
            public static Color color1 = Color.FromArgb(255,255,255);

        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0,0,70);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //leftBoder button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //IconCurrrnt form
                iconCurrent.IconChar = currentBtn.IconChar;
                iconCurrent.IconColor = color;

            }

        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0,0,70);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        private void Reset()
        {
            DisableButton();
            //leftBorderBtn.Visible = false;
            iconCurrent.IconChar = IconChar.Home;
            iconCurrent.IconColor = Color.White;
            LabelHome.Text = "Home";
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.Show();
        }
        private void OpenForm(Form form)
        {
            if (currentForm != null)
            {
                //open only form
                currentForm.Close();
            }
            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelCons.Controls.Add(form);
            panelCons.Tag = form;
            form.BringToFront();
            form.Show();
            LabelHome.Text = form.Text;
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            currentForm.Close();
            Reset();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colors.color1);
            OpenForm(new FormKhachHang());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colors.color1);
            OpenForm(new FormSanPham());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colors.color1);
            OpenForm(new FormHD());
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colors.color1);
            OpenForm(new FormCTHD());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colors.color1);
            LoginForm but = new LoginForm();
            but.FormClosed += new FormClosedEventHandler(HomeForm_Load);
            but.Show();
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaxsize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnminisize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void gunaPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDonDatHang(object sender, EventArgs e)
        {
            ActivateButton(sender, colors.color1);
            OpenForm(new FormDonDatHang());
        }
    }
}
