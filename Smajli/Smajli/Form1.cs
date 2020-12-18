using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KlasaSmajli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        Graphics g;
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            Width = 1400;
            Height = 800;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Smajli s=new Smajli(x,y);
            if (radioButton1.Checked == true) s.Crtaj1(g);
            else if (radioButton2.Checked == true) s.Crtaj2(g);
            else s.Crtaj3(g);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            
            for (int i = 0; i < 10; i++)
            {
                int x = r.Next(1, 4);
                Smajli s = new Smajli(r.Next(0,1400),r.Next(0,800));
                if (x == 1) s.Crtaj1(g);
                else if (x == 2) s.Crtaj2(g);
                else if (x==3)s.Crtaj3(g);
            }
        }
    }
}
