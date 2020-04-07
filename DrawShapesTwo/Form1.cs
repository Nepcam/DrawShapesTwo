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
            Graphics canvas = pictureBoxDisplay.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 2);
            Pen bluePen = new Pen(Color.Blue, 2);
            Pen rainbowPen = new Pen(colorDialog1.Color); //default color is black
            SolidBrush br = new SolidBrush(Color.Orange);

            //IF the button pressed is the left button THEN
            //Draw the line 
            //ENDIF
            if (e.Button == MouseButtons.Left)
            {
                //canvas.DrawLine(bluePen, 0, 0, e.X, e.Y);
                //canvas.DrawLine(rainbowPen, pictureBoxDisplay.Width / 2, pictureBoxDisplay.Height / 2, e.X, e.Y);
                //canvas.DrawLine(rainbowPen, rand.Next(pictureBoxDisplay.Width + 1), rand.Next(pictureBoxDisplay.Height + 1), e.X, e.Y);
                canvas.FillEllipse(br, e.X, e.Y, 50, 50);
                canvas.DrawEllipse(rainbowPen, e.X, e.Y, 50, 50);
            }


        }

        private void buttonSetColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();           
        }
    }
}
