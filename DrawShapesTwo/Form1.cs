using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawShapesTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics canvas = pictureBoxDisplay.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 2);
            Pen bluePen = new Pen(Color.Blue, 2);

            canvas.DrawLine(redPen, pictureBoxDisplay.Width/2, pictureBoxDisplay.Height/2, e.X, e.Y);
            //canvas.DrawLine(bluePen, 0, 0, e.X, e.Y);
        }
    }
}
