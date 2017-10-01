﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ShiftOS.Engine;
using ShiftOS.Engine.WindowManager;
using ShiftOS.Main.ShiftOS.Apps;

namespace ShiftOS.Main
{
    public partial class TestForm : Form
    {
        Point loc;
        public TestForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ShiftDemo demo = new ShiftDemo { label1 = { Text = textBox2.Text } };

            var item = typeof(SystemIcons).GetProperties()
                .First(p => p.Name == comboBox1.SelectedItem as string);

            ShiftWM.Init(demo, textBox1.Text, (item.GetMethod.Invoke(null, new object[0]) as Icon));
            ShiftWM.StartInfoboxSession(textBox1.Text, textBox2.Text, InfoboxTemplate.ButtonType.Ok, InfoboxTemplate.ErrorIcon.Critical);
        }

        private void button2_Click(object sender, EventArgs e)
            => ShiftWM.Init(new Shifter(), "Shifter", Properties.Resources.iconShifter.ToIcon());

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                loc = new Point(Cursor.Position.X, Cursor.Position.Y);
                this.Location = loc;
            }
        }
    }
}
