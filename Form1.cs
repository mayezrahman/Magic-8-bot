using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace magic_8_bot1
{
    //This is the magic 8 bot application, and it contains a robot who has a job to answer your questions.
    //Created by Weilderman on 2/21/2023, in Tennesse, United States.
    //The program requires .net to be installed on your computer.
    //The magic 8 bot loves soda, basketball, problem solving, and shooting evil robots!
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int rannum = 0;
            Random r = new Random();
            rannum = r.Next(1, 6);
            switch (rannum)
            {
                case 1:
                    textBox2.Text = "It is certain.";
                    SoundPlayer sound = new SoundPlayer(Properties.Resources._8bot_line2);
                    sound.Play();
                    break;
                case 2:
                    textBox2.Text = "As I see it, yes.";
                    SoundPlayer sound2 = new SoundPlayer(Properties.Resources._8bot_line1);
                    sound2.Play();
                    break;
                case 3:
                    textBox2.Text = "Reply hazy, try again.";
                    SoundPlayer sound3 = new SoundPlayer(Properties.Resources._8bot_line3);
                    sound3.Play();
                    break;
                case 4:
                    textBox2.Text = "Probably not.";
                    SoundPlayer sound4 = new SoundPlayer(Properties.Resources._8bot_line4);
                    sound4.Play();
                    break;
                case 5:
                    textBox2.Text = "Definetely no.";
                    SoundPlayer sound5 = new SoundPlayer(Properties.Resources._8bot_line5);
                    sound5.Play();
                    break;
                default:
                    textBox2.Text = "Don't count on it.";
                    SoundPlayer sound6 = new SoundPlayer(Properties.Resources._8bot_line4);
                    sound6.Play();
                    break;
            }
        }
    }
}
