using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_LAB5
{
    public class Drawer
    {
        public static void DrawPicture(Graphics g, int x, int y)
        {
            Bitmap bitmap = new Bitmap(@"C:\2 курс\Компьютерная графика\CG-LAB5\CG-LAB5\120px-Sun.png");
            g.DrawImage(bitmap, x, y);
        }
    }
}
