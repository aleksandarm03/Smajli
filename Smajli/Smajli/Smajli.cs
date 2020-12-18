using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace KlasaSmajli
{
    class Smajli
    {
        int x, y,a=200;
        public Smajli(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Crtaj1(Graphics g)
        {
            Pen olovka = new Pen(Color.Black, 15);
            SolidBrush cetka1 = new SolidBrush(Color.Black);
            SolidBrush cetka2 = new SolidBrush(Color.Yellow);
            g.FillEllipse(cetka2, x - a / 2, y - a / 2, a, a);
            g.FillEllipse(cetka1, x - a / 5 - 15, y - 3 * a / 10, 30, 30);
            g.FillEllipse(cetka1, x + a / 5 - 15, y - 3 * a / 10, 30, 30);
            g.DrawArc(olovka, x - 3 * a / 10, y - 3 * a / 10, 120, 120, 0, 180);
        }

        public void Crtaj2(Graphics g)
        {
            Pen olovka = new Pen(Color.Black, 15);
            SolidBrush cetka1 = new SolidBrush(Color.Black);
            SolidBrush cetka2 = new SolidBrush(Color.Yellow);
            g.FillEllipse(cetka2, x - a / 2, y - a / 2, a, a);
            g.FillEllipse(cetka1, x - a / 5 - 15, y - a / 5 - a / 10, 30, 30);
            g.FillEllipse(cetka1, x + a / 5 - 15, y - a / 5 - a / 10, 30, 30);
            g.DrawArc(olovka, x - 3 * a / 10, y + a / 10, 120, 120, 210, 120);           
        }

        public void Crtaj3(Graphics g)
        {
            Pen olovka = new Pen(Color.Black, 15);
            SolidBrush cetka1 = new SolidBrush(Color.Black);
            SolidBrush cetka2 = new SolidBrush(Color.Yellow);
            g.FillEllipse(cetka2, x - a / 2, y - a / 2, a, a);
            g.FillRectangle(cetka1, x - a / 4, y - 3 * a / 16, a / 2, a / 16);
            g.FillRectangle(cetka1, x - 3 * a / 8, y - a / 4, 5 * a / 16, a / 4);
            g.FillRectangle(cetka1, x + a / 16, y - a / 4, 5 * a / 16, a / 4);
            g.DrawArc(olovka, x - 3 * a / 10, y - 3 * a / 10, 120, 120, 30, 120);
        }
    }
}
