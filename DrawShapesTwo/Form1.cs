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
            br.Color = Color.FromArgb(123, 255, 126);
            int randomNum = rand.Next(-10, 10);

            int size = 50;

            //IF the button pressed is the left button THEN
            //Draw the line 
            //ENDIF
            if (e.Button == MouseButtons.Left)
            {
                //canvas.DrawLine(bluePen, 0, 0, e.X, e.Y);
                //canvas.DrawLine(rainbowPen, pictureBoxDisplay.Width / 2, pictureBoxDisplay.Height / 2, e.X, e.Y);
                //canvas.DrawLine(rainbowPen, rand.Next(pictureBoxDisplay.Width + 1), rand.Next(pictureBoxDisplay.Height + 1), e.X, e.Y);
                canvas.FillEllipse(br, e.X, e.Y, size, size);
                canvas.DrawEllipse(rainbowPen, e.X, e.Y, size, size);

                //    Generate a random number of circles to draw between 4 and 10
                int num = 7;
                //    Set counter variable to 1
                int counter = 1;
                //    WHILE counter <= number of circles to draw
                while (counter <= num)
                {
                    //Random rand = new Random();
                    //    Generate a random number between 2 and 10 for the size of the circle
                    int circleSize = 9;
                    //    Store xPos = mouse X + random number between - 10 and 10
                    int xPos = e.X + randomNum;
                    //    Store yPos = mouse Y + random number between - 10 and 10
                    int yPos = e.Y + randomNum;
                    //    Draw ellipse at xPos and yPos position
                    canvas.DrawEllipse(rainbowPen, xPos, yPos, circleSize, circleSize);
                    //    Add 1 to counter variable
                    counter++;
                }   //    ENDWHILE
            }
        }

        private void buttonSetColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();           
        }
    }
}
