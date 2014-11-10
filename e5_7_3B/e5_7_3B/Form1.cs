using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e5_7_3B
{
    public partial class Form1 : Form
    {
        int x, y;

        public Form1()
        {
            InitializeComponent();
        }

        void DrawCir(Color color)
        {
            Graphics g = this.CreateGraphics();
            Pen pen1 = new Pen(color);
            SolidBrush brush1 = new SolidBrush(color);
            g.DrawEllipse(pen1, x, y, 100, 100);
            g.FillEllipse(brush1, x, y, 100, 100);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawCir(Color.Red); 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)//e.KeyCode是键盘每个键的编号
            {
                case Keys.Left://左箭头键编号
                    DrawCir(this.BackColor);//用Form窗体的背静色画圆，即擦除圆
                    x = x - 10;//圆左移
                    DrawCir(Color.Red);//在新的位置用红色画圆，效果是圆左移
                    break;

                case Keys.Right://圆右移
                    DrawCir(this.BackColor);
                    x += 10;
                    DrawCir(Color.Red);
                    break;

                case Keys.Down://圆下移
                    DrawCir(this.BackColor);
                    y += 10;
                    DrawCir(Color.Red);
                    break;

                case Keys.Up://圆上移
                    DrawCir(this.BackColor);
                    y = y - 10;
                    DrawCir(Color.Red);
                    break;
            }
        }
    }
}
