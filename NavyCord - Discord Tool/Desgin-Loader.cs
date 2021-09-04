using NavyCord___Discord_Tool.Panels;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NavyCord___Discord_Tool
{
    public partial class Desgin_Loder : Form
    {

        bool Desgin1;
        bool Desgin2;
        public Desgin_Loder()
        {
            InitializeComponent();
        }

        private void Desgin_Loder_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Opener_Click(object sender, EventArgs e)
        {
            if (Design1.Checked == true)
            {
                Main _Design1 = new Main();
                _Design1.Show();
                this.Hide();

            }
            else if (Design2.Checked == true)
            {
                MessageBox.Show("Coming Soon", "NavyCord - Information");
            }
            else
            {
                MessageBox.Show("Please Select a Design", "NavyCord - Information");
            }

        }

        private void Main_DownPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Login_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void JoinDiscordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/B7RpQV9");
        }
    }
}
