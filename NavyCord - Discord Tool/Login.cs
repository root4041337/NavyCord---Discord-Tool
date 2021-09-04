using NavyCord.Functions;
using NavyCord___Discord_Tool.Panels;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Console = Colorful.Console;

namespace NavyCord___Discord_Tool
{
    public partial class Login : Form
    {
        public static Point newpoint = new Point();
        public static int x;
        public static int y;
        public NotifyIcon WinNotify;
        public static string WelcomeLabelChange;

        public Login()
        {
            InitializeComponent();
        }

        #region "Mouse Down"
        private void xMouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - base.Location.X;
            y = Control.MousePosition.Y - base.Location.Y;
        }
        #endregion

        #region "Mouse Move"
        private void xMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                newpoint = Control.MousePosition;
                newpoint.X -= x;
                newpoint.Y -= y;
                base.Location = newpoint;
            }
        }
        #endregion

        private void Login_Load(object sender, EventArgs e)
        {
            Login_Panel.BackColor = Color.FromArgb(50, 13, 10, 12);


        }


        private void Login_TopPanel_Paint(object sender, PaintEventArgs e)
        {
            this.Login_TopPanel.MouseDown += this.xMouseDown; //For Move Form
            this.Login_TopPanel.MouseMove += this.xMouseMove; //For Move Form
        }

        private void Login_LoginButton_Click(object sender, EventArgs e)
        {
            if (API.Login(Login_Username_TextBox.Text, Login_Passwort_TextBox.Text))
            {
                WelcomeLabelChange = Login_Username_TextBox.Text;
                WinInfo.Visible = true;
                WinInfo.BalloonTipText = "Login successfully! \n\nWelcome Back: " + ">> " + Login_Username_TextBox.Text + " << \n\n";
                WinInfo.ShowBalloonTip(1000);

                //Gets IP infos
                string str1 = new WebClient().DownloadString("http://ipinfo.io/ip");
                string str2 = new WebClient().DownloadString("http://ipinfo.io/country");
                string str3 = new WebClient().DownloadString("http://ipinfo.io/city");
                string str4 = new WebClient().DownloadString("http://ipinfo.io/region");

                //Console Output for Successfully Login
                Console.WriteLine("_________________________________________________________________", Color.Red);
                Console.WriteLine("");
                Console.WriteLine("[>>] Successfully Logged In [<<]", Color.LimeGreen);
                Console.WriteLine("");
                Console.WriteLine("[>>] Welcome Back: " + User.Username + " [<<]", Color.LimeGreen);
                Console.WriteLine("[>>] Your E-Mail: " + User.Email + " [<<]", Color.LimeGreen);
                Console.WriteLine("[>>] Your IP: " + str1 + " [<<]", Color.LimeGreen);
                Console.WriteLine("[>>] Your HWID: " + User.HWID + " [<<]", Color.LimeGreen);
                Console.WriteLine("[>>] Your Rank: " + User.Rank + " [<<]", Color.LimeGreen);
                Console.WriteLine("[>>] Your License ill Expire at: " + User.Expiry + " [<<]", Color.LimeGreen);
                Console.WriteLine("");
                Console.WriteLine("_________________________________________________________________", Color.Red);


                //Opens Main Form after Login
                Main main = new Main();
                main.Show();
                this.Hide();

                //sends a Message to Discord Webhook with Creditenal
            }
            else
            {
                Console.WriteLine("[>>] Failed to Login...", Color.OrangeRed);
                Console.WriteLine("[>>] Your IP: " + User.IP, Color.OrangeRed);
                Console.WriteLine("[>>] Please Check ur User Information! or Contact the Support.", Color.OrangeRed);
            }
        }

        private void Login_RegiserButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void Login_NavyCord_Logo1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/B7RpQV9");
        }

        private void licensing1_Load(object sender, EventArgs e)
        {

        }
    }
}
