using APP.Classes;
using TCC.Forms;
using System;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Drawing;
using System.Runtime.InteropServices;

namespace APP
{
    public partial class FrmMain : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
                
        #region Variables and Instances
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form activeForm;
        private DateTime dt = new DateTime();
        #endregion

        #region Methods
        public FrmMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PnMenu.Controls.Add(leftBorderBtn);
            //Form
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                ThemeColor cl = new ThemeColor();
                Color color = cl.SelectColor();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(31, 30, 80);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.FlatAppearance.BorderColor = color;
                currentBtn.FlatAppearance.BorderSize = 0;
                //Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Panel Upper
                LblTitle.ForeColor = color;
                IpbPage.IconColor = color;
                IpbPage.IconChar = currentBtn.IconChar;
                ThemeColor.PrimaryColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.FlatAppearance.BorderSize = 0;
                IpbPage.IconChar = IconChar.Home;
                IpbPage.IconColor = Color.Gainsboro;
                LblTitle.Text = "Home";
                LblTitle.ForeColor = Color.Gainsboro;
                PnUpper.BackColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void OpenChild(Form child, object btnSender)
        {
            CloseChild();
            ActiveButton(btnSender);
            activeForm = child;
            activeForm.TopLevel = false;
            activeForm.Dock = DockStyle.Fill;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            PnPai.Controls.Add(activeForm);
            PnPai.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();
            LblTitle.Text = activeForm.Text;
        }

        private void CloseChild()
        {
            if (activeForm != null) activeForm.Close();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            CloseChild();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TimerHora.Start();
            TimerEntrar.Start();
            dt = DateTime.Now;
            LblDate.Text = dt.ToLongDateString();
        }

        private void IbtnLogout_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            CloseChild();
            LblTitle.Text = "Logout";
            if (MessageBox.Show("Tem certeza de que quer dar um Logout?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FrmLogin log = new FrmLogin();
                log.Show();
                Close();
            }
        }

        private void Guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void IbtnConfig_Click(object sender, EventArgs e)
        {
            OpenChild(new Forms.FrmConfiguracoes(), sender);
        }

        private void PnUpper_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        } 

        private void TimerEntrar_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1) Opacity += 0.05;
        }

        private void TimerHora_Tick(object sender, EventArgs e)
        {
            LblHour.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        #endregion

        private void CbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}