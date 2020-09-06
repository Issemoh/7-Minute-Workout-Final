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
using System.Diagnostics;

namespace _7_Minute_Workout.Forms
{
    public partial class FrmFront : Form
    {
        public FrmFront()
        {
            InitializeComponent();
        }

        //Time Counter Coding...

        private int counter1 = 35, counter2 = 35, counter3 = 35, counter4 = 35, counter5 = 35, counter6 = 35, counter7 = 35, counter8 = 35, counter9 = 35, counter10 = 35, counter11 = 35, counter12 = 35;

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter1--;
           
                if (counter1 == 0)
                {

                    timer1.Stop();
                    Console.Beep(5000, 1000);
                    Btn2.PerformClick();

                }

          
            LblCounter.Text = counter1.ToString();
        }
       
        public void TimerCode1()
        {
         
            counter1 = 35;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            LblCounter.Text = counter1.ToString();
           

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            counter2--;

            if (counter2 == 0)
            {

                timer2.Stop();
                Console.Beep(5000, 1000);
                Btn3.PerformClick();

            }


            LblCounter.Text = counter2.ToString();
        }

        public void TimerCode2()
        {

            counter2 = 35;
            timer2 = new System.Windows.Forms.Timer();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 1000; // 1 second
            timer2.Start();
            LblCounter.Text = counter2.ToString();


        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            counter3--;

            if (counter3 == 0)
            {

                timer3.Stop();
                Console.Beep(5000, 1000);
                Btn4.PerformClick();

            }


            LblCounter.Text = counter3.ToString();
        }

        public void TimerCode3()
        {

            counter3 = 35;
            timer3 = new System.Windows.Forms.Timer();
            timer3.Tick += new EventHandler(timer3_Tick);
            timer3.Interval = 1000; // 1 second
            timer3.Start();
            LblCounter.Text = counter3.ToString();


        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            counter4--;

            if (counter4 == 0)
            {

                timer4.Stop();
                Console.Beep(5000, 1000);
                Btn5.PerformClick();

            }


            LblCounter.Text = counter4.ToString();
        }

        public void TimerCode4()
        {

            counter4 = 35;
            timer4 = new System.Windows.Forms.Timer();
            timer4.Tick += new EventHandler(timer4_Tick);
            timer4.Interval = 1000; // 1 second
            timer4.Start();
            LblCounter.Text = counter4.ToString();


        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            counter5--;

            if (counter5 == 0)
            {

                timer5.Stop();
                Console.Beep(5000, 1000);
                Btn6.PerformClick();

            }


            LblCounter.Text = counter5.ToString();
        }

        public void TimerCode5()
        {

            counter5 = 35;
            timer5 = new System.Windows.Forms.Timer();
            timer5.Tick += new EventHandler(timer5_Tick);
            timer5.Interval = 1000; // 1 second
            timer5.Start();
            LblCounter.Text = counter5.ToString();


        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            counter6--;

            if (counter6 == 0)
            {

                timer6.Stop();
                Console.Beep(5000, 1000);
                Btn7.PerformClick();

            }


            LblCounter.Text = counter6.ToString();
        }

        public void TimerCode6()
        {

            counter6 = 35;
            timer6 = new System.Windows.Forms.Timer();
            timer6.Tick += new EventHandler(timer6_Tick);
            timer6.Interval = 1000; // 1 second
            timer6.Start();
            LblCounter.Text = counter6.ToString();


        }
        private void timer7_Tick(object sender, EventArgs e)
        {
            counter7--;

            if (counter7 == 0)
            {

                timer7.Stop();
                Console.Beep(5000, 1000);
                Btn8.PerformClick();

            }


            LblCounter.Text = counter7.ToString();
        }

        public void TimerCode7()
        {

            counter7 = 35;
            timer7 = new System.Windows.Forms.Timer();
            timer7.Tick += new EventHandler(timer7_Tick);
            timer7.Interval = 1000; // 1 second
            timer7.Start();
            LblCounter.Text = counter7.ToString();


        }
        private void timer8_Tick(object sender, EventArgs e)
        {
            counter8--;

            if (counter8 == 0)
            {

                timer8.Stop();
                Console.Beep(5000, 1000);
                Btn9.PerformClick();

            }


            LblCounter.Text = counter8.ToString();
        }

        public void TimerCode8()
        {

            counter8 = 35;
            timer8 = new System.Windows.Forms.Timer();
            timer8.Tick += new EventHandler(timer8_Tick);
            timer8.Interval = 1000; // 1 second
            timer8.Start();
            LblCounter.Text = counter8.ToString();


        }
        private void timer9_Tick(object sender, EventArgs e)
        {
            counter9--;

            if (counter9 == 0)
            {

                timer9.Stop();
                Console.Beep(5000, 1000);
                Btn10.PerformClick();

            }


            LblCounter.Text = counter9.ToString();
        }

        public void TimerCode9()
        {

            counter9 = 35;
            timer9 = new System.Windows.Forms.Timer();
            timer9.Tick += new EventHandler(timer9_Tick);
            timer9.Interval = 1000; // 1 second
            timer9.Start();
            LblCounter.Text = counter9.ToString();


        }
        private void timer10_Tick(object sender, EventArgs e)
        {
            counter10--;

            if (counter10 == 0)
            {

                timer10.Stop();
                Console.Beep(5000, 1000);
                Btn11.PerformClick();

            }


            LblCounter.Text = counter10.ToString();
        }

        public void TimerCode10()
        {

            counter10 = 35;
            timer10 = new System.Windows.Forms.Timer();
            timer10.Tick += new EventHandler(timer10_Tick);
            timer10.Interval = 1000; // 1 second
            timer10.Start();
            LblCounter.Text = counter10.ToString();


        }
        private void timer11_Tick(object sender, EventArgs e)
        {
            counter11--;

            if (counter11 == 0)
            {

                timer11.Stop();
                Console.Beep(5000, 1000);
                Btn12.PerformClick();

            }


            LblCounter.Text = counter11.ToString();
        }

        public void TimerCode11()
        {

            counter11 = 35;
            timer11 = new System.Windows.Forms.Timer();
            timer11.Tick += new EventHandler(timer11_Tick);
            timer11.Interval = 1000; // 1 second
            timer11.Start();
            LblCounter.Text = counter11.ToString();


        }
        private void timer12_Tick(object sender, EventArgs e)
        {
            counter12--;

            if (counter12 == 0)
            {

                timer12.Stop();
                Console.Beep(5000, 1000);
                pictureBox1.Visible = true;
            }


            LblCounter.Text = counter12.ToString();
        }

        public void TimerCode12()
        {

            counter12 = 35;
            timer12 = new System.Windows.Forms.Timer();
            timer12.Tick += new EventHandler(timer12_Tick);
            timer12.Interval = 1000; // 1 second
            timer12.Start();
            LblCounter.Text = counter12.ToString();


        }


        //Timer Coding end...
        private void Btn1_Click(object sender, EventArgs e)
        {
           
            TimerCode1();
            PB1.BringToFront();
            LblTarget.Text = "Full body";
            LblDiscription.Text = "Stand with feet hip-width apart. Jump feet open as you raise arms to form an X shape.\nJump feet back together as you lower arms to your sides.";
            LblLink.Text = "https://www.youtube.com/watch?v=c4DAnQ6DtF8";
            pictureBox1.Visible = false;
            //Thread.Sleep(500);
            //Btn2.PerformClick();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
          
            TimerCode2();
            //Btn3.PerformClick();
            PB2.BringToFront();
            LblTarget.Text = "Quads, hamstrings, glutes";
            LblDiscription.Text = "Stand with your back to a wall. Walk feet away from the wall as you slide your back down\nthe wall, lowering your body until hips, knees, and ankles are at 90-degree angles. Engage \ncore to keep low back pressed against the wall.";
            LblLink.Text = "https://www.youtube.com/watch?v=-cdph8hv0O0";
            pictureBox1.Visible = false;
        }

        private void LblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(LblLink.Text);
        }

        private void FrmFront_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            
            TimerCode3();
            //Btn4.PerformClick();
            PB3.BringToFront();
            LblTarget.Text = "Chest, shoulders, triceps, abs";
            LblDiscription.Text = "Start in high plank, wrists under shoulders, core engaged. Lower your chest to the floor,\nkeeping legs, hips, and back in a straight line. Press into palms to push back up.";
            LblLink.Text = "https://www.youtube.com/watch?v=rjc0O7OXS3g";
            pictureBox1.Visible = false;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
          
            TimerCode4();
            //Btn5.PerformClick();
            PB4.BringToFront();
            LblTarget.Text = "Abs";
            LblDiscription.Text = "Lie faceup on the floor with knees bent and arms reaching toward feet. Press low back into\nthe floor and engage core to lift shoulder blades off the floor and slightly forward.";
            LblLink.Text = "https://www.youtube.com/watch?v=_M2Etme-tfE";
            pictureBox1.Visible = false;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            
            TimerCode5();
            //Btn6.PerformClick();
            PB5.BringToFront();
            LblTarget.Text = "Quads, hamstrings, glutes, abs";
            LblDiscription.Text = "Stand facing a chair or stool and lift right foot onto the seat. Press into heel of right foot to \nlift your body onto the chair, balancing on right leg. Slowly lower back down to the floor. \nSwitch legs and repeat. Continue to alternate.";
            LblLink.Text = "https://www.youtube.com/watch?v=nAl0t57yPD4";
            pictureBox1.Visible = false;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
           
            TimerCode6();
            //Btn7.PerformClick();
            PB6.BringToFront();
            LblTarget.Text = "Quads, hamstrings, glutes";
            LblDiscription.Text = "Stand with feet just wider than hip width, hips stacked over knees, knees over ankles. Hinge\nat hips, then send hips back. Bend knees to lower your body. Keep chest lifted while lownering \nto at least 90 degrees.Rise and repeat.";
            LblLink.Text = "https://www.youtube.com/watch?v=mGvzVjuY8SY";
            pictureBox1.Visible = false;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
           

            TimerCode7();
           // Btn8.PerformClick();
            PB7.BringToFront();
            LblTarget.Text = "Triceps, abs";
            LblDiscription.Text = "Sit on the edge of a chair and place hands on edge, just outside your hips. Walk feet out a \nfew steps, slide butt off the chair, and straighten arms. Bend elbows and lower your body \nuntil arms are bent at about 90 degrees.Press into the chair to return to starting position.";
            LblLink.Text = "https://www.youtube.com/watch?v=6kALZikXxLc";
            pictureBox1.Visible = false;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
           
            TimerCode8();
            //Btn9.PerformClick();
            Pb8.BringToFront();
            LblTarget.Text = "Abs, arms, glutes";
            LblDiscription.Text = "Place hands directly under shoulders. Engage core and squeeze glutes to stabilize your body.\nKeep neck and spine neutral. Head should be in line with back. Hold.";
            LblLink.Text = "https://www.youtube.com/watch?v=TvxNkmjdhMM";
            pictureBox1.Visible = false;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
         
            TimerCode9();
            //Btn10.PerformClick();
            PB9.BringToFront();
            LblTarget.Text = "Legs, abs";
            LblDiscription.Text = "Stand with feet hip-width apart. Engage core and use lower abs to lift and lower one knee at a\ntime, as if running in place. Bring knees to same height as hips, thighs parallel to the floor, and \ntry not to lean back. Stay on balls of feet and alternate legs as fast as possible.";
            LblLink.Text = "https://www.youtube.com/watch?v=Xh8JEoYjYhg";
            pictureBox1.Visible = false;
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            

            TimerCode10();
            //Btn11.PerformClick();
            PB10.BringToFront();
            LblTarget.Text = "Quads, hamstrings, glutes";
            LblDiscription.Text = "Stand tall. Take a big step forward with right leg and lower your body until right thigh is par-\nallel to the floor and right shin is vertical. Don’t let right knee go past toe. Press into right heel\nto drive back up to starting position.Repeat on other side. Continue to alternate legs.";
            LblLink.Text = "https://www.youtube.com/watch?v=j0GT6daJg3o";
            pictureBox1.Visible = false;
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
           
            TimerCode11();
           // Btn12.PerformClick();
            PB11.BringToFront();
            LblTarget.Text = "Abs, chest, glutes, shoulders, triceps";
            LblDiscription.Text = "Start in high plank. Lower your body toward the floor, then press back up to perform a push-up.\nShift weight to left arm and rotate your body to the left side. Hold side plank for 1 count, keeping \nhips high.Return to starting position, perform a push - up, and repeat on the right side. Continue \nto alternate.";
            LblLink.Text = "https://www.youtube.com/watch?v=gdcw0QVY4KM";
            pictureBox1.Visible = false;
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
           

            TimerCode12();
            //PB12.BringToFront();
            LblTarget.Text = "Obliques, hips, arms";
            LblDiscription.Text = "Lie on your side with legs and feet stacked. Lift hips and prop your body up on one elbow, \nkeeping feet stacked. Press forearm into floor to keep torso and hips in a straight line. Hold.";
            LblLink.Text = "https://www.youtube.com/watch?v=9Q0D6xAyrOI";
            pictureBox1.Visible = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
