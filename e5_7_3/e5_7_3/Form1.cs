using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e5_7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen1 = new Pen(Color.Red);
            g.DrawRectangle(pen1, 10, 10, 200, 100);
            Rectangle rect = new Rectangle(20, 20, 100, 100);
            g.DrawRectangle(pen1, rect);
        }
    }
}
