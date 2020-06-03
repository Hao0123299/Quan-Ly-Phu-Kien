using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(From1_Paint);
        }

        private void From1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            e.Graphics.FillRectangle(Brushes.Blue, new Rectangle(0, 0, 1920, 1080));  //màu nền 
            e.Graphics.DrawLine(Pens.Red, new Point(0, 0), new Point(500, 500));

            string hello = "Xin chào";
            e.Graphics.DrawString(hello, this.Font, Brushes.White, 500, 600);

            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, 50, 75));
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, 75, 100));

            e.Graphics.DrawEllipse(Pens.Black, 100, 50, 160, 80); //vẽ ellipe

            //e.Graphics.DrawImage(Properties.Resources.anhtest, 20, 20);

            /*e.Graphics.AddLine(0, 0, 30, 20);
            e.Graphics.AddEllipse(20, 20, 20, 40);
            e.Graphics.AddBezier(30, 60, 70, 60, 50, 30, 100, 10);
            e.Graphics.DrawPath(Pens, &myGraphicsPath);*/
        }

        
        private void tmrAppTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();

        }
    }
}
