using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class Form1 : Form
    {

        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int Score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;



        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Prikol");
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text= "Счет: " + Score;
            Score++;


           if (goleft == true && PLAYer.Left > 10)
            {
                PLAYer.Left -= playerSpeed;
            }

           if (goright == true && PLAYer.Left < 415)
            {
                PLAYer.Left += playerSpeed;
            }

            Road1.Top += roadSpeed;
            Road2.Top += roadSpeed;

            if (Road2.Top > 519)
            {
                Road2.Top = -519;
            }

            if (Road1.Top > 519)
            {
                Road1.Top = -519;
            }

            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;

            if (AI1.Top > 530 )
            {
                changeAIcars(AI1);
            }

            if (AI2.Top > 530)
            {
                changeAIcars(AI2);
            }

            if (PLAYer.Bounds.IntersectsWith(AI1.Bounds) || PLAYer.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver();
            }

            if (Score > 40 && Score < 500)
            {
                award.Image = Properties.Resources.bronze;
            }

            if (Score > 500 && Score < 2000)
            {
                award.Image = Properties.Resources.silver_png;
                roadSpeed = 20;
                trafficSpeed = 22;

            }

            if (Score > 2000)
            {
                award.Image = Properties.Resources.gold_png;
                roadSpeed = 25;
                trafficSpeed = 27;
            }
        }

        private void changeAIcars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 8);

            switch(carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.ambulance_png;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.cargreen_png;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.cargrey_png;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carorange_png;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carpink_png;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.carred_png;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.truckblue_png;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.truckwhite_png;
                    break;
            }

            tempCar.Top = carPosition.Next(100, 400) * -1;

            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }

            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }

        }

        private void gameOver()
        {
            playSound();
            GameTimer.Stop();
            bom.Visible = true;
            PLAYer.Controls.Add(bom);
            bom.Location = new Point(8, 5);
            bom.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            btnStart.Enabled = true;

            

        }

        private void ResetGame()
            {
              
                btnStart.Enabled = false;
                bom.Visible = false;
                award.Visible = false;
                goleft = false;
                goright = false;
                Score = 0;
                award.Image = Properties.Resources.bronze;

                roadSpeed = 12;
                trafficSpeed = 15;

                AI1.Top = carPosition.Next(200, 500) * -1;
                AI1.Left = carPosition.Next(5, 200);

                AI2.Top = carPosition.Next(200, 500) * -1;
                AI2.Left = carPosition.Next(245, 422);

            GameTimer.Start();

            }

        private void reStartGame(object sender, EventArgs e)
        {
            ResetGame();

        }

        private void playSound()
        { 
            
        }

}
}
