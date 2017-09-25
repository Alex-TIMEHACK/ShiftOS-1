﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShiftOS.Engine.WindowManager
{
    public partial class ShiftWindow : Form
    {
        public ShiftWindow()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                        int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Programtopbar_drag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closebutton_MouseEnter(object sender, EventArgs e)
        {
            closebutton.BackColor = Color.Gray;
        }

        private void closebutton_MouseLeave(object sender, EventArgs e)
        {
            closebutton.BackColor = Color.Black;
        }

        private void maximizebutton_MouseEnter(object sender, EventArgs e)
        {
            maximizebutton.BackColor = Color.Gray;
        }

        private void maximizebutton_MouseLeave(object sender, EventArgs e)
        {
            maximizebutton.BackColor = Color.Black;
        }

        private void minimizebutton_MouseEnter(object sender, EventArgs e)
        {
            minimizebutton.BackColor = Color.Gray;
        }

        private void minimizebutton_MouseLeave(object sender, EventArgs e)
        {
            minimizebutton.BackColor = Color.Black;
        }
    }
}
