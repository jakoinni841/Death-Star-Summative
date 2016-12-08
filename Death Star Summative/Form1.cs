using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Death_Star_Summative
{
    public partial class Window : Form
    {

        public Window()
        {
            InitializeComponent();
            startMisson.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            titleLabel.Visible = false;
            Refresh();
            SoundPlayer player = new SoundPlayer(Properties.Resources.Converted_file_497c9140);
            player.Play();
            #region Mission Briefing

            Graphics fg = deathstarBox.CreateGraphics();
            Font drawFont = new Font("OCR A Std", 16, FontStyle.Bold);
            Font drawLuck = new Font("Ariel", 20, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.LimeGreen);
            SolidBrush drawGood = new SolidBrush(Color.White);

            fg.DrawString("Hello,", drawFont, drawBrush, 1, 1);
            Thread.Sleep(400);
            fg.DrawString(" your", drawFont, drawBrush, 100, 3);
            Thread.Sleep(400);
            fg.DrawString("mission", drawFont, drawBrush, 190, 3);
            Thread.Sleep(400);
            fg.DrawString("is", drawFont, drawBrush, 315, 3);
            Thread.Sleep(400);
            fg.DrawString("to", drawFont, drawBrush, 5, 25);
            Thread.Sleep(400);
            fg.DrawString("fly", drawFont, drawBrush, 50, 25);
            Thread.Sleep(400);
            fg.DrawString("over", drawFont, drawBrush, 110, 25);
            Thread.Sleep(400);
            fg.DrawString("the", drawFont, drawBrush, 180, 25);
            Thread.Sleep(400);
            fg.DrawString("death-", drawFont, drawBrush, 250, 25);
            Thread.Sleep(400);
            fg.DrawString("star", drawFont, drawBrush, 5, 50);
            Thread.Sleep(400);
            fg.DrawString("and", drawFont, drawBrush, 77, 50);
            Thread.Sleep(400);
            fg.DrawString("drop", drawFont, drawBrush, 135, 50);
            Thread.Sleep(400);
            fg.DrawString("the", drawFont, drawBrush, 215, 50);
            Thread.Sleep(400);
            fg.DrawString("bomb,", drawFont, drawBrush, 280, 50);
            Thread.Sleep(400);

            fg.DrawString(" Goodluck", drawLuck, drawGood, 175, 200);


            startButton.Visible = false;
            startMisson.Visible = true;
            #endregion
        }

        private void startMisson_Click(object sender, EventArgs e)
        {
            startMisson.Visible = false;
            deathstarBox.Visible = false;

            Graphics fg = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen drawStar = new Pen(Color.White, 3);


            #region Fly in code

            int counter = 1;
            int y = 100;

            //First fly in from right
            if (counter == 1)
            {
                for (int x = 385; x >= -10; x--)
                {
                    fg.Clear(Color.Black);
                    fg.FillRectangle(drawBrush, x, y, 5, 5);
                    Thread.Sleep(2);
                }
                counter++;
                y = 150;
                Thread.Sleep(250);
            }
            //Second fly in from left
            if (counter == 2)
            {
                for (int x = -10; x <= 425; x++)
                {
                    fg.Clear(Color.Black);
                    fg.FillRectangle(drawBrush, x, y, 20, 20);
                    Thread.Sleep(4);
                }
                counter++;
                y = 100;
                Thread.Sleep(50);
            }
            //Third fly in from right
            if (counter == 3)
            {
                for (int x = 425; x >= -40; x--)
                {
                    fg.Clear(Color.Black);
                    fg.FillRectangle(drawBrush, x, y, 30, 30);
                    Thread.Sleep(5);
                }
                Thread.Sleep(50);
            }
            //End
            #endregion

            fg.DrawEllipse(drawStar, 105, 175, 200, 200);
            fg.DrawLine(drawStar, 205, 175, 205, 300);
            fg.FillEllipse(drawBrush, 200, 295, 10, 10);

            #region Ship fly in to deathstar
            y = 125;
            for (int x = 385; x >= 275; x--)
            {
                fg.Clear(Color.Black);
                fg.FillRectangle(drawBrush, x, y, 5, 5);
                fg.DrawEllipse(drawStar, 105, 175, 200, 200);
                fg.DrawLine(drawStar, 205, 175, 205, 300);
                fg.FillEllipse(drawBrush, 200, 295, 10, 10);
                Thread.Sleep(7);
            }
            fg.Clear(Color.Black);
            #endregion

            SolidBrush drawBrush3 = new SolidBrush(Color.Yellow);
            SolidBrush drawBrush2 = new SolidBrush(Color.White);
            Pen drawStar2 = new Pen(Color.White, 10);

            fg.DrawEllipse(drawStar, -10, 175, 500, 500);
            fg.DrawLine(drawStar, 205, 175, 205, 300);
            fg.FillEllipse(drawBrush, 200, 295, 10, 10);

            #region Deathstar bomb drop
                y = 125;
                int x2 = 245;
                int y2 = 125;

                for (int x = 385; x >= -10; x--)
                {
                  if(x <= 245)
                  {

                    fg.FillEllipse(drawBrush, x2, y2, 8, 8);
                    y2++;

                    Thread.Sleep(1);
                  }
                    fg.Clear(Color.Black);
                    fg.FillRectangle(drawBrush, x, y, 11, 11);
                    fg.DrawEllipse(drawStar2, -10, 175, 500, 500);
                    fg.DrawLine(drawStar2, 240, 175, 240, 450);
                    fg.DrawLine(drawStar2, 260, 175, 260, 450);
                       Thread.Sleep(1);
                }
            fg.Clear(Color.Black);
            #endregion

            fg.DrawLine(drawStar2, 200, 0, 200, 220);
            fg.DrawLine(drawStar2, 225, 0, 225, 220);
            fg.FillEllipse(drawBrush2, 200, 290, 20, 20);

            #region Deathstar blowup
            int x3 = 200;
            for (int y3 = 0; y3 <= 223; y3++)
            {
                fg.Clear(Color.Black);
                fg.FillEllipse(drawBrush, x3, y3, 20, 20);
                fg.DrawLine(drawStar2, 200, 0, 200, 220);
                fg.DrawLine(drawStar2, 225, 0, 225, 220);
                fg.DrawEllipse(drawStar, 193, 215, 35, 35);
                Thread.Sleep(4);
            }

            int width = 20;
            SoundPlayer player = new SoundPlayer(Properties.Resources.Converted_file_497c9140);
            player.Play();
            for (int height = 20; height <= 300; height++)
            {
                fg.Clear(Color.Black);
                fg.FillEllipse(drawBrush3, 200, 220, height, height);
                fg.DrawLine(drawStar2, 200, 0, 200, 220);
                fg.DrawLine(drawStar2, 225, 0, 225, 220);
                fg.DrawEllipse(drawStar, 193, 215, 35, 35);

                fg.FillEllipse(drawBrush3, 200, 220, width, width);
                width--;
            }
            fg.Clear(Color.Black);


            #endregion

            Font drawFont = new Font("OCR A Std", 16, FontStyle.Bold);

            fg.DrawString("Mission Complete, \n Goodjob", drawFont, drawBrush, 5, 5);
            Thread.Sleep(3000);

            Application.Exit();

        }
    }
}
