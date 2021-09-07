using NavyCord.Functions;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Console = Colorful.Console;

namespace NavyCord___Discord_Tool.Panels
{
    public partial class Main : Form
    {

        int CharCount = 0;

        ///Bools\\\ 
        bool _Rainbow = false;
        /// 
        public static Point newpoint = new Point();
        public static int x;
        public static int y;

        public NotifyIcon WinNotify;

        public Main()
        {
            InitializeComponent();
            StartFunctions();

        }

        private void StartFunctions()
        {
            Main_Welcome_Label.Text = Login.WelcomeLabelChange;
            AccUsernameLbl.Text = User.Username;
            AccEmailLbl.Text = User.Email;
            AccRankLbl.Text = User.Rank;
            AccYourHWIDLbl.Text = User.HWID;
            AccExpireLbl.Text = User.Expiry;
            _Rainbow = true;
            RainbowLblChanger();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        #region "Desgin"
        private void Main_TopPanel_Paint(object sender, PaintEventArgs e)
        {
            this.Main_TopPanel.MouseDown += this.xMouseDown; //For Move Form
            this.Main_TopPanel.MouseMove += this.xMouseMove; //For Move Form
            this.Main_TopPanel.MouseDown += this.xMouseDown; //For Move Form
            this.Main_TopPanel.MouseMove += this.xMouseMove; //For Move Form
            this.Main_TopPanel.MouseDown += this.xMouseDown; //For Move Form
            this.Main_TopPanel.MouseMove += this.xMouseMove; //For Move Form
            this.Main_TopPanel.MouseDown += this.xMouseDown; //For Move Form
            this.Main_TopPanel.MouseMove += this.xMouseMove; //For Move Form
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

        private void Main_DownPanel_Paint(object sender, PaintEventArgs e)
        {
            this.Main_DownPanel.MouseDown += this.xMouseDown; //For Move Form
            this.Main_DownPanel.MouseMove += this.xMouseMove; //For Move Form
            this.Main_DownPanel.MouseDown += this.xMouseDown; //For Move Form
            this.Main_DownPanel.MouseMove += this.xMouseMove; //For Move Form
            this.Main_DownPanel.MouseDown += this.xMouseDown; //For Move Form
            this.Main_DownPanel.MouseMove += this.xMouseMove; //For Move Form
            this.Main_DownPanel.MouseDown += this.xMouseDown; //For Move Form
            this.Main_DownPanel.MouseMove += this.xMouseMove; //For Move Form
        }
        #endregion

        private void RainbowLblChanger()
        {
            new Thread(() =>
            {
                if (_Rainbow)
                {
                    while (_Rainbow)
                    {
                        try
                        {
                            Random rand = new Random();
                            int A = rand.Next(0, 255);
                            int B = rand.Next(0, 255);
                            int C = rand.Next(0, 255);
                            int D = rand.Next(0, 255);

                            Main_Welcome_Label.ForeColor = System.Drawing.Color.FromArgb(A, B, C, D);
                            Thread.Sleep(500);
                        }
                        catch
                        {
                            //Error
                        }
                    }
                }
            }).Start();        
        }

        #region "Tabs"
        //Main
        private void Dashboard_Opener_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Tab_Dashboard;

            Console.WriteLine("[>>] Opened Dashboard [<<]", Color.IndianRed);
        }

        private void ServerJ_L_Opener_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Tab_SJoinerLeaver;

            Console.WriteLine("[>>] Opened Server Joiner / Leaver [<<]", Color.IndianRed);
        }
        //
        //Spammer
        //
        private void Spammer_Opener_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Tab_Spammer;

            Console.WriteLine("[>>] Opened Spammer [<<]", Color.IndianRed);
        }

        private void MultiSpammer_Opener_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon","NavyCord");
        }

        private void Voice_Opener_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[>>] Opened Voice [<<]", Color.IndianRed);
        }

        private void Friend_Opener_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Tab_Friend;

            Console.WriteLine("[>>] Opened Friends [<<]", Color.IndianRed);
        }

        private void Webhook_Opener_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Tab_WebhookS;

            Console.WriteLine("[>>] Opened Webhook [<<]", Color.IndianRed);
        }

        private void AIOS_Opener_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Tab_AIOS;

            MessageBox.Show("With AIO Spammer u can Spam to Server Channels and All User in Guilds", "NavyCord - Information");

            Console.WriteLine("[>>] Opened All in One Spammer [<<]", Color.IndianRed);
        }
        //
        //Misc
        //
        private void Exploits_Opener_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Tab_Exploits;

            Console.WriteLine("[>>] Opened Exploits [<<]", Color.IndianRed);
        }

        private void TokenN_Opener_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Tab_Nuker;

            Console.WriteLine("[>>] Opened Token Nuker [<<]", Color.IndianRed);
        }

        //
        //Settings
        //
        private void TProxys_Opener_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Tab_TProxys;

            Console.WriteLine("[>>] Opened Tokens & Proxys [<<]", Color.IndianRed);
        }

        private void TokenS_Opener_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Tab_TSettings;

            Console.WriteLine("[>>] Opened Token Settings [<<]", Color.IndianRed);
        }

        private void Settings_Opener_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Tab_Settings;

            Console.WriteLine("[>>] Opened Settings [<<]", Color.IndianRed);
        }

        private void Sbot_Opener_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon...", "NavyCord - Information");

            Console.WriteLine("[>>] Coming Soon... Please for an Update [<<]", Color.Red);
        }

        private void Suggestions_Opener_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Tab_Suggestions;
            Console.WriteLine("[>>] Opened Suggestions [<<]", Color.IndianRed);
        }
        #endregion

        private void Exploits_GetTokenButton_Click(object sender, EventArgs e)
        {
            GetTokenFromID(Exploits_UserID_TextBox.Text);
            MessageBox.Show("Look at the Console Log!", "NavyCord - Information");
        }

        #region "Functs"

        private void GetTokenFromID(string _userID)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(_userID);
            string converted = Convert.ToBase64String(bytes);


            Console.WriteLine("_________________________________________________________________", Color.Red);
            Console.WriteLine("");
            Console.WriteLine("[>>] " + converted + " [<<]", Color.Red);
            Console.WriteLine("");
            Console.WriteLine("[>>] Now u can Bruteforce Token to get the Full Token\n But it ill Take a Time" + " [<<]", Color.Red);
            Console.WriteLine("");
            Console.WriteLine("_________________________________________________________________", Color.Red);


        }

        private void Suggestions_Textbox_TextChanged(object sender, EventArgs e)
        {

            CharCount = Suggestions_Textbox.Text.Length;
            CharCountOutput.Text = CharCount.ToString() + "/1940";

        }

        #endregion

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/B7RpQV9");
        }

        #region "Color Changer"
        private void ChangeColor1_Button_Click(object sender, EventArgs e)
        {
            ChangeColor.ShowDialog();

            Main_TopPanel.FillColor = ChangeColor.Color;
            Main_DownPanel.FillColor = ChangeColor.Color;

            LeftPanelPanel3.FillColor = ChangeColor.Color;
            LeftPanelPanel4.FillColor = ChangeColor.Color;
            LeftPanelPanel5.FillColor = ChangeColor.Color;
            LeftPanelPanel6.FillColor = ChangeColor.Color;
            LeftPanelPanel7.FillColor = ChangeColor.Color;

            //Functions Panel
            AccountInfoPanel.FillColor = ChangeColor.Color;
            ServerInformationShow_Panel.FillColor = ChangeColor.Color;
            VanityPanel.FillColor = ChangeColor.Color;
            GetTokenPanel.FillColor = ChangeColor.Color;

            //Text Panels
            ServerInformationTxt_Panel.FillColor = ChangeColor.Color;
            JoinerTxt_Panel.FillColor = ChangeColor.Color;




            Console.ForegroundColor = ChangeColor.Color;
            Console.WriteLine("u Changed to >> " + ChangeColor.Color);
            Console.WriteLine("Oben Links >> " + ChangeColor.Color);
        }

        private void ChangeColor2_Button_Click(object sender, EventArgs e)
        {
            Main_TopPanel.FillColor2 = ChangeColor.Color;
            Main_DownPanel.FillColor2 = ChangeColor.Color;
            LeftPanelPanel3.FillColor2 = ChangeColor.Color;
            LeftPanelPanel4.FillColor2 = ChangeColor.Color;
            LeftPanelPanel5.FillColor2 = ChangeColor.Color;
            LeftPanelPanel6.FillColor2 = ChangeColor.Color;
            LeftPanelPanel7.FillColor2 = ChangeColor.Color;
            guna2CustomGradientPanel3.FillColor2 = ChangeColor.Color;
            AccountInfoPanel.FillColor2 = ChangeColor.Color;

            ServerInformationShow_Panel.FillColor2 = ChangeColor.Color;
            ServerInformationTxt_Panel.FillColor2 = ChangeColor.Color;
            VanityPanel.FillColor2 = ChangeColor.Color;
            GetTokenPanel.FillColor2 = ChangeColor.Color;

            JoinerTxt_Panel.FillColor2 = ChangeColor.Color;
            LeaverTxt_Panel.FillColor2 = ChangeColor.Color;
            Console.WriteLine("Unten Links >> " + ChangeColor.Color);
        }

        private void ChangeColor3_Button_Click(object sender, EventArgs e)
        {
            Main_TopPanel.FillColor3 = ChangeColor.Color;
            Main_DownPanel.FillColor3 = ChangeColor.Color;
            LeftPanelPanel3.FillColor3 = ChangeColor.Color;
            LeftPanelPanel4.FillColor3 = ChangeColor.Color;
            LeftPanelPanel5.FillColor3 = ChangeColor.Color;
            LeftPanelPanel6.FillColor3 = ChangeColor.Color;
            LeftPanelPanel7.FillColor3 = ChangeColor.Color;
            guna2CustomGradientPanel3.FillColor3 = ChangeColor.Color;
            AccountInfoPanel.FillColor3 = ChangeColor.Color;

            AccountInfoPanel.FillColor3 = ChangeColor.Color;
            ServerInformationShow_Panel.FillColor3 = ChangeColor.Color;
            VanityPanel.FillColor3 = ChangeColor.Color;
            GetTokenPanel.FillColor3 = ChangeColor.Color;

            ServerInformationTxt_Panel.FillColor = ChangeColor.Color;
            JoinerTxt_Panel.FillColor3 = ChangeColor.Color;
            LeaverTxt_Panel.FillColor3 = ChangeColor.Color;

            Console.WriteLine("Oben Rechts >> " + ChangeColor.Color);
        }

        private void ChangeColor4_Button_Click(object sender, EventArgs e)
        {
            Main_TopPanel.FillColor4 = ChangeColor.Color;
            Main_DownPanel.FillColor4 = ChangeColor.Color;
            LeftPanelPanel3.FillColor4 = ChangeColor.Color;
            LeftPanelPanel4.FillColor4 = ChangeColor.Color;
            LeftPanelPanel5.FillColor4 = ChangeColor.Color;
            LeftPanelPanel6.FillColor4 = ChangeColor.Color;
            LeftPanelPanel7.FillColor4 = ChangeColor.Color;
            guna2CustomGradientPanel3.FillColor4 = ChangeColor.Color;
            AccountInfoPanel.FillColor4 = ChangeColor.Color;


            AccountInfoPanel.FillColor4 = ChangeColor.Color;
            ServerInformationShow_Panel.FillColor4 = ChangeColor.Color;
            VanityPanel.FillColor4 = ChangeColor.Color;
            GetTokenPanel.FillColor4 = ChangeColor.Color;

            ServerInformationTxt_Panel.FillColor4 = ChangeColor.Color;
            JoinerTxt_Panel.FillColor4 = ChangeColor.Color;
            LeaverTxt_Panel.FillColor4 = ChangeColor.Color;
            Console.WriteLine("Unten Rechts >> " + ChangeColor.Color);
        }
        private void ChangeColorDefault_Button_Click(object sender, EventArgs e)
        {
            Main_TopPanel.FillColor = Color.FromArgb(4, 3, 5);
            Main_TopPanel.FillColor2 = Color.FromArgb(4, 3, 5);
            Main_TopPanel.FillColor3 = Color.FromArgb(4, 3, 5);
            Main_TopPanel.FillColor4 = Color.FromArgb(4, 3, 5);
            Main_DownPanel.FillColor = Color.FromArgb(4, 3, 5);
            Main_DownPanel.FillColor2 = Color.FromArgb(4, 3, 5);
            Main_DownPanel.FillColor3 = Color.FromArgb(4, 3, 5);
            Main_DownPanel.FillColor4 = Color.FromArgb(4, 3, 5);
            LeftPanelPanel3.FillColor = Color.Black;
            LeftPanelPanel3.FillColor2 = Color.Black;
            LeftPanelPanel3.FillColor3 = Color.Black;
            LeftPanelPanel3.FillColor4 = Color.Black;
            LeftPanelPanel4.FillColor = Color.Black;
            LeftPanelPanel4.FillColor2 = Color.Black;
            LeftPanelPanel4.FillColor3 = Color.Black;
            LeftPanelPanel4.FillColor4 = Color.Black;
            LeftPanelPanel5.FillColor = Color.Black;
            LeftPanelPanel5.FillColor2 = Color.Black;
            LeftPanelPanel5.FillColor3 = Color.Black;
            LeftPanelPanel5.FillColor4 = Color.Black;
            LeftPanelPanel6.FillColor = Color.Black;
            LeftPanelPanel6.FillColor2 = Color.Black;
            LeftPanelPanel6.FillColor3 = Color.Black;
            LeftPanelPanel6.FillColor4 = Color.Black;
            LeftPanelPanel7.FillColor = Color.Black;
            LeftPanelPanel7.FillColor2 = Color.Black;
            LeftPanelPanel7.FillColor3 = Color.Black;
            LeftPanelPanel7.FillColor4 = Color.Black;

        }
        #endregion

        #region "Misc"


        #endregion





        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void LeftPanel_2_Resize(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Detected....");
        }
    }
}
