namespace NavyCord___Discord_Tool
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_TopPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Login_NavyCord_Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Login_Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Login_Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Login_Panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Login_NavyCord_Logo1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Login_RegiserButton = new Guna.UI2.WinForms.Guna2Button();
            this.Login_LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Login_Passwort_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Login_Username_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Login_Username_Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.WinInfo = new System.Windows.Forms.NotifyIcon(this.components);
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Fade = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Login_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Login_NavyCord_Logo)).BeginInit();
            this.Login_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Username_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_TopPanel
            // 
            this.Login_TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(5)))));
            this.Login_TopPanel.Controls.Add(this.Login_NavyCord_Logo);
            this.Login_TopPanel.Controls.Add(this.Login_Minimize);
            this.Login_TopPanel.Controls.Add(this.Login_Close);
            this.Login_TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Login_TopPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(5)))));
            this.Login_TopPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(5)))));
            this.Login_TopPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(5)))));
            this.Login_TopPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(5)))));
            this.Login_TopPanel.Location = new System.Drawing.Point(0, 0);
            this.Login_TopPanel.Name = "Login_TopPanel";
            this.Login_TopPanel.ShadowDecoration.Parent = this.Login_TopPanel;
            this.Login_TopPanel.Size = new System.Drawing.Size(976, 24);
            this.Login_TopPanel.TabIndex = 1;
            this.Login_TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_TopPanel_Paint);
            // 
            // Login_NavyCord_Logo
            // 
            this.Login_NavyCord_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Login_NavyCord_Logo.Image")));
            this.Login_NavyCord_Logo.Location = new System.Drawing.Point(9, 6);
            this.Login_NavyCord_Logo.Name = "Login_NavyCord_Logo";
            this.Login_NavyCord_Logo.ShadowDecoration.Parent = this.Login_NavyCord_Logo;
            this.Login_NavyCord_Logo.Size = new System.Drawing.Size(144, 17);
            this.Login_NavyCord_Logo.TabIndex = 4;
            this.Login_NavyCord_Logo.TabStop = false;
            // 
            // Login_Minimize
            // 
            this.Login_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Login_Minimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.Login_Minimize.BorderRadius = 2;
            this.Login_Minimize.BorderThickness = 2;
            this.Login_Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Login_Minimize.FillColor = System.Drawing.Color.Transparent;
            this.Login_Minimize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.Login_Minimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.Login_Minimize.HoverState.Parent = this.Login_Minimize;
            this.Login_Minimize.IconColor = System.Drawing.Color.White;
            this.Login_Minimize.Location = new System.Drawing.Point(923, 4);
            this.Login_Minimize.Name = "Login_Minimize";
            this.Login_Minimize.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.Login_Minimize.ShadowDecoration.Parent = this.Login_Minimize;
            this.Login_Minimize.Size = new System.Drawing.Size(20, 17);
            this.Login_Minimize.TabIndex = 5;
            // 
            // Login_Close
            // 
            this.Login_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_Close.BackColor = System.Drawing.Color.Transparent;
            this.Login_Close.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.Login_Close.BorderRadius = 2;
            this.Login_Close.BorderThickness = 2;
            this.Login_Close.FillColor = System.Drawing.Color.Transparent;
            this.Login_Close.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Login_Close.HoverState.FillColor = System.Drawing.Color.Red;
            this.Login_Close.HoverState.Parent = this.Login_Close;
            this.Login_Close.IconColor = System.Drawing.Color.White;
            this.Login_Close.Location = new System.Drawing.Point(949, 4);
            this.Login_Close.Name = "Login_Close";
            this.Login_Close.PressedColor = System.Drawing.Color.Red;
            this.Login_Close.PressedDepth = 40;
            this.Login_Close.ShadowDecoration.Parent = this.Login_Close;
            this.Login_Close.Size = new System.Drawing.Size(20, 17);
            this.Login_Close.TabIndex = 4;
            // 
            // Login_Panel
            // 
            this.Login_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Login_Panel.Controls.Add(this.Login_NavyCord_Logo1);
            this.Login_Panel.Controls.Add(this.Login_RegiserButton);
            this.Login_Panel.Controls.Add(this.Login_LoginButton);
            this.Login_Panel.Controls.Add(this.guna2PictureBox1);
            this.Login_Panel.Controls.Add(this.Login_Passwort_TextBox);
            this.Login_Panel.Controls.Add(this.Login_Username_TextBox);
            this.Login_Panel.Controls.Add(this.Login_Username_Logo);
            this.Login_Panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.Login_Panel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.Login_Panel.Location = new System.Drawing.Point(174, 140);
            this.Login_Panel.Name = "Login_Panel";
            this.Login_Panel.ShadowDecoration.Parent = this.Login_Panel;
            this.Login_Panel.Size = new System.Drawing.Size(605, 340);
            this.Login_Panel.TabIndex = 3;
            this.Login_Panel.UseTransparentBackground = true;
            // 
            // Login_NavyCord_Logo1
            // 
            this.Login_NavyCord_Logo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.Login_NavyCord_Logo1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Login_NavyCord_Logo1.CheckedState.Parent = this.Login_NavyCord_Logo1;
            this.Login_NavyCord_Logo1.HoverState.ImageSize = new System.Drawing.Size(270, 233);
            this.Login_NavyCord_Logo1.HoverState.Parent = this.Login_NavyCord_Logo1;
            this.Login_NavyCord_Logo1.Image = ((System.Drawing.Image)(resources.GetObject("Login_NavyCord_Logo1.Image")));
            this.Login_NavyCord_Logo1.ImageRotate = 0F;
            this.Login_NavyCord_Logo1.ImageSize = new System.Drawing.Size(260, 222);
            this.Login_NavyCord_Logo1.Location = new System.Drawing.Point(13, 60);
            this.Login_NavyCord_Logo1.Name = "Login_NavyCord_Logo1";
            this.Login_NavyCord_Logo1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Login_NavyCord_Logo1.PressedState.Parent = this.Login_NavyCord_Logo1;
            this.Login_NavyCord_Logo1.Size = new System.Drawing.Size(280, 232);
            this.Login_NavyCord_Logo1.TabIndex = 7;
            this.Login_NavyCord_Logo1.Click += new System.EventHandler(this.Login_NavyCord_Logo1_Click);
            // 
            // Login_RegiserButton
            // 
            this.Login_RegiserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.Login_RegiserButton.BorderColor = System.Drawing.Color.Empty;
            this.Login_RegiserButton.BorderRadius = 2;
            this.Login_RegiserButton.BorderThickness = 2;
            this.Login_RegiserButton.CheckedState.Parent = this.Login_RegiserButton;
            this.Login_RegiserButton.CustomImages.Parent = this.Login_RegiserButton;
            this.Login_RegiserButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Login_RegiserButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.Login_RegiserButton.ForeColor = System.Drawing.Color.White;
            this.Login_RegiserButton.HoverState.Parent = this.Login_RegiserButton;
            this.Login_RegiserButton.Location = new System.Drawing.Point(314, 272);
            this.Login_RegiserButton.Name = "Login_RegiserButton";
            this.Login_RegiserButton.ShadowDecoration.Parent = this.Login_RegiserButton;
            this.Login_RegiserButton.Size = new System.Drawing.Size(231, 45);
            this.Login_RegiserButton.TabIndex = 6;
            this.Login_RegiserButton.Text = "Register";
            this.Login_RegiserButton.Click += new System.EventHandler(this.Login_RegiserButton_Click);
            // 
            // Login_LoginButton
            // 
            this.Login_LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.Login_LoginButton.BorderColor = System.Drawing.Color.Empty;
            this.Login_LoginButton.BorderRadius = 2;
            this.Login_LoginButton.BorderThickness = 2;
            this.Login_LoginButton.CheckedState.Parent = this.Login_LoginButton;
            this.Login_LoginButton.CustomImages.Parent = this.Login_LoginButton;
            this.Login_LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Login_LoginButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.Login_LoginButton.ForeColor = System.Drawing.Color.White;
            this.Login_LoginButton.HoverState.Parent = this.Login_LoginButton;
            this.Login_LoginButton.Location = new System.Drawing.Point(314, 221);
            this.Login_LoginButton.Name = "Login_LoginButton";
            this.Login_LoginButton.ShadowDecoration.Parent = this.Login_LoginButton;
            this.Login_LoginButton.Size = new System.Drawing.Size(231, 45);
            this.Login_LoginButton.TabIndex = 5;
            this.Login_LoginButton.Text = "Login";
            this.Login_LoginButton.Click += new System.EventHandler(this.Login_LoginButton_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(314, 155);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(80, 14);
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Login_Passwort_TextBox
            // 
            this.Login_Passwort_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.Login_Passwort_TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.Login_Passwort_TextBox.BorderRadius = 2;
            this.Login_Passwort_TextBox.BorderThickness = 2;
            this.Login_Passwort_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Login_Passwort_TextBox.DefaultText = "";
            this.Login_Passwort_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Login_Passwort_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Login_Passwort_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Login_Passwort_TextBox.DisabledState.Parent = this.Login_Passwort_TextBox;
            this.Login_Passwort_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Login_Passwort_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.Login_Passwort_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Login_Passwort_TextBox.FocusedState.Parent = this.Login_Passwort_TextBox;
            this.Login_Passwort_TextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Passwort_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Login_Passwort_TextBox.HoverState.Parent = this.Login_Passwort_TextBox;
            this.Login_Passwort_TextBox.Location = new System.Drawing.Point(314, 176);
            this.Login_Passwort_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Login_Passwort_TextBox.Name = "Login_Passwort_TextBox";
            this.Login_Passwort_TextBox.PasswordChar = '\0';
            this.Login_Passwort_TextBox.PlaceholderText = "Password:";
            this.Login_Passwort_TextBox.SelectedText = "";
            this.Login_Passwort_TextBox.ShadowDecoration.Parent = this.Login_Passwort_TextBox;
            this.Login_Passwort_TextBox.Size = new System.Drawing.Size(231, 38);
            this.Login_Passwort_TextBox.TabIndex = 2;
            // 
            // Login_Username_TextBox
            // 
            this.Login_Username_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.Login_Username_TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.Login_Username_TextBox.BorderRadius = 2;
            this.Login_Username_TextBox.BorderThickness = 2;
            this.Login_Username_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Login_Username_TextBox.DefaultText = "";
            this.Login_Username_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Login_Username_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Login_Username_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Login_Username_TextBox.DisabledState.Parent = this.Login_Username_TextBox;
            this.Login_Username_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Login_Username_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.Login_Username_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Login_Username_TextBox.FocusedState.Parent = this.Login_Username_TextBox;
            this.Login_Username_TextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Username_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Login_Username_TextBox.HoverState.Parent = this.Login_Username_TextBox;
            this.Login_Username_TextBox.Location = new System.Drawing.Point(314, 81);
            this.Login_Username_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Login_Username_TextBox.Name = "Login_Username_TextBox";
            this.Login_Username_TextBox.PasswordChar = '\0';
            this.Login_Username_TextBox.PlaceholderText = "Username:";
            this.Login_Username_TextBox.SelectedText = "";
            this.Login_Username_TextBox.ShadowDecoration.Parent = this.Login_Username_TextBox;
            this.Login_Username_TextBox.Size = new System.Drawing.Size(231, 38);
            this.Login_Username_TextBox.TabIndex = 1;
            // 
            // Login_Username_Logo
            // 
            this.Login_Username_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Login_Username_Logo.FillColor = System.Drawing.Color.Transparent;
            this.Login_Username_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Login_Username_Logo.Image")));
            this.Login_Username_Logo.Location = new System.Drawing.Point(314, 60);
            this.Login_Username_Logo.Name = "Login_Username_Logo";
            this.Login_Username_Logo.ShadowDecoration.Parent = this.Login_Username_Logo;
            this.Login_Username_Logo.Size = new System.Drawing.Size(80, 14);
            this.Login_Username_Logo.TabIndex = 0;
            this.Login_Username_Logo.TabStop = false;
            // 
            // WinInfo
            // 
            this.WinInfo.Icon = ((System.Drawing.Icon)(resources.GetObject("WinInfo.Icon")));
            this.WinInfo.Text = "WinInfo";
            this.WinInfo.Visible = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(625, 581);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(344, 17);
            this.guna2PictureBox2.TabIndex = 6;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(976, 596);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.Login_Panel);
            this.Controls.Add(this.Login_TopPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NavyCord - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Login_TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Login_NavyCord_Logo)).EndInit();
            this.Login_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Username_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel Login_TopPanel;
        private Guna.UI2.WinForms.Guna2ControlBox Login_Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox Login_Close;
        private Guna.UI2.WinForms.Guna2GradientPanel Login_Panel;
        private Guna.UI2.WinForms.Guna2PictureBox Login_Username_Logo;
        private Guna.UI2.WinForms.Guna2PictureBox Login_NavyCord_Logo;
        public Guna.UI2.WinForms.Guna2TextBox Login_Passwort_TextBox;
        public Guna.UI2.WinForms.Guna2TextBox Login_Username_TextBox;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button Login_RegiserButton;
        private Guna.UI2.WinForms.Guna2Button Login_LoginButton;
        private Guna.UI2.WinForms.Guna2ImageButton Login_NavyCord_Logo1;
        private System.Windows.Forms.NotifyIcon WinInfo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Timer Fade;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}

