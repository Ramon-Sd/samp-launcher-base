using System;
using System.Windows.Forms;

namespace LauncherBase
{
    public partial class Form_Main : Form
    {

        private int mouseX = 0;
        private int mouseY = 0;
        private bool isMoveMouse = false;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Panel_SBar_MouseDown(object sender, MouseEventArgs e)
        {
            isMoveMouse = !isMoveMouse;
            mouseX = e.Y;
            mouseY = e.Y;
        }

        private void Panel_SBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoveMouse)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void Panel_SBar_MouseUp(object sender, MouseEventArgs e)
        {
            isMoveMouse = !isMoveMouse;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            var SampLauncher = new SAMP();

            switch (SampLauncher.Init("Your IP", "Player_Name"))
            {
                case 1:
                {
                    // Path Not Find
                    // MessageBox.Show(...);
                    break;
                }
                case 2:
                {
                    // Invalid IP
                    // MessageBox.Show(...);
                    break;
                }
                case 3:
                {
                    // Is Started
                    // MessageBox.Show(...);
                    break;
                }
                case 4:
                {
                    // Other Error
                    // MessageBox.Show(...);
                    break;
                }
                default:
                {
                    // Sucess
                    break;
                }
            }
        }
    }
}

/* Samp Launcher base By : Ramon (https://github.com/Ramon-Sd */