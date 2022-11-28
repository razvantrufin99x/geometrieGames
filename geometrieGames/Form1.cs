using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace geometrieGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int x = 0;
        public int y = 0;
        public int x1 = 10;
        public int y1 = 10;
        public int x2 = 40;
        public int y2 = 40;

        public bool eInInterior()
        {
            if ((x > x1  && x < x2 + 10) && (y > y1 && y < y2 + 10))
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void userControl11_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            Text = eInInterior().ToString() + " : "  + e.X.ToString() + " : " + e.Y.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.g.DrawRectangle(userControl11.p, x1, y1, x2, y2);
            userControl11.Refresh();
        }
    }
}
