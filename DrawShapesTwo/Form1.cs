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
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 2);
            Pen bluePen = new Pen(Color.Blue, 2);
            Pen rainbowPen = new Pen(colorDialog1.Color);

            //paper.DrawLine(rainbowPen, pictureBoxDisplay.Width/2, pictureBoxDisplay.Height/2, e.X, e.Y);
            //canvas.DrawLine(bluePen, 0, 0, e.X, e.Y);

            // IF the button is pressed THEN
            if (e.Button == MouseButtons.Left)
            {
                //FILL shape with color
                SolidBrush br = new SolidBrush(Color.Orange);
                //DRAW the line
                //paper.DrawLine(rainbowPen, rand.Next(pictureBoxDisplay.Width +1), pictureBoxDisplay.Height +1, e.X, e.Y);
                //DRAW circle
                paper.DrawEllipse(bluePen, e.X, e.Y, 50, 50);
                //FILL circle
                paper.FillEllipse(br, e.X, e.Y, 50, 50);
            }
        }

        private void buttonSetColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();           
        }
    }
}
