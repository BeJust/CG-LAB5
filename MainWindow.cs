using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_LAB5
{
    public partial class MainWindow : Form
    {   
        int x = 325, y = 160, a = 10, b = 10;

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics,e);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Draw(Graphics g, PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(Width, Height);
            Drawer.DrawPicture(e.Graphics, x, y);
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            int dx = 10, dy = 10;


            if (e.KeyValue == 37)
            {
                if (x > a - 10)
                    x = x - dx;
                Invalidate();
            }

            if (e.KeyValue == 39)
            {
                if (x < Width - 12.5 * a)
                    x = x + dx;
                Invalidate();
            }
            if (e.KeyValue == 38)
            {
                if (y > b - 10)
                    y = y - dy;
                Invalidate();
            }
            if (e.KeyValue == 40)
            {
                if (y < Height - 17.8 * b/2)
                    y = y + dy;
                Invalidate();
            }
        }
    }
    
}
