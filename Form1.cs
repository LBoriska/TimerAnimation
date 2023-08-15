using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerAnimation
{
    public partial class Form1 : Form
    {
        private int geschwHori = 5;
        private int geschwVerti = 5;
            public Form1()
        {
            InitializeComponent();
            geschwHori = Convert.ToInt32(numericUpDown1.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   //it was a timer
            //label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString(); 
            //_______________________________________
            //horizontal moving
            
            if (AmpelGruen.Visible == true
            || pictureBox1.Location.X > AmpelGruen.Location.X + AmpelGruen.Width + 20
            || pictureBox1.Location.X < AmpelGruen.Location.X)
            { 
                pictureBox1.Location = 
                new Point(pictureBox1.Location.X - 30, pictureBox1.Location.Y);
                
                if (pictureBox1.Location.X <= - pictureBox1.Width)  // < = 0
                {
                pictureBox1.Location 
                    = new Point(this.Width, pictureBox1.Location.Y);
                 }
            }

            //__________________________________
            //vertikal moving 

            if (AmpelGruen2.Visible == true
            || pictureBox3.Location.Y < AmpelGruen2.Location.Y - pictureBox3.Height 
            || pictureBox3.Location.Y > AmpelGruen2.Location.Y + AmpelGruen2.Height
            )
            {
                

                pictureBox3.Location =
                new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 10);

                if (pictureBox3.Location.Y <= -pictureBox3.Height)  
                {
                    pictureBox3.Location
                        = new Point(this.Height, pictureBox3.Location.X);
                }

            }

        }//void Timer1_Tick

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true; //Enabled is a boolean, false as a standart
            timer1.Enabled = !timer1.Enabled; //on /off 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {   
            AmpelGruen.Visible = !AmpelGruen.Visible;   
            AmpelRot.Visible = !AmpelRot.Visible;
           
            AmpelGruen2.Visible = !AmpelGruen2.Visible;
            AmpelRot2.Visible = !AmpelRot2.Visible;
        }
    }
}
