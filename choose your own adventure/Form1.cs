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

namespace choose_your_own_adventure
{
    public partial class Form1 : Form
    {// global
        int scene = 0;
        SoundPlayer sceneSound;

        
       
        public Form1()
        {
            

           
            InitializeComponent();
            outputLabel.Parent = pictureBox;
            yellowLabel.Parent = pictureBox;
            redLabel.Parent = pictureBox;
            blueLabel.Parent = pictureBox;
            redFakeButton.Parent = pictureBox;
            blueFakeButton.Parent = pictureBox;
            yellowFakeButton.Parent = pictureBox;

            //starting sound
            sceneSound = new SoundPlayer(Properties.Resources.applause);
            sceneSound.Play();


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // red key click
            if (e.KeyCode == Keys.M)
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 12; }
                else if (scene == 3) { scene = 6; }
                else if (scene == 4) {}
                else if (scene == 5) { scene = 0; }
                else if (scene == 6) { scene = 8; }
                else if (scene == 7) { scene = 0; }
                else if (scene == 8) { scene = 0; }
                else if (scene == 9) { }
                else if (scene == 10) { scene = 0; }
                else if (scene == 11) { scene = 13; }
                else if (scene == 12) { scene = 0; }
                else if (scene == 13) { }
                else if (scene == 14) { scene = 0; }
                else if (scene == 99) { }




            }
            //blue button press
            else if (e.KeyCode == Keys.B)
            {
                if (scene == 0) { scene = 2; }
                else if (scene == 1) { scene = 5; }
                else if (scene == 2) { scene = 11; }
                else if (scene == 3)
                {
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);
                    if (value <= 5) { scene = 9; }
                    else { scene = 10; }
                }





                else if (scene == 4) { }
                else if (scene == 5) { scene = 99; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 99; }
                else if (scene == 8) { scene = 99; }
                else if (scene == 9) { }
                else if (scene == 10) { scene = 99; }
                else if (scene == 11) { scene = 14; }
                else if (scene == 12) { scene = 99; }
                else if (scene == 13) { }
                else if (scene == 14) { scene = 99; }
                else if (scene == 99) { }



            }// yellow key click- there is only one 
            else if (e.KeyCode == Keys.N)
            {
                if (scene == 6) { scene = 4; }

            }
            switch (scene)
            {
                case 0:  //start scene  
                    outputLabel.Text = "You have decided to finally follow throug with your dream of starting your own company. Starting your own business if risky... try to end up rich.  What type of company would you like to create?";
                    redLabel.Text = "Cupcake Store";
                    blueLabel.Text = "Clothing Business";
                    yellowLabel.Text = "";
                    yellowFakeButton.BackColor = Color.Transparent;

                    pictureBox.BackgroundImage = Properties.Resources.small_business;
                    sceneSound  = new SoundPlayer(Properties.Resources.applause);
                    sceneSound.Play();
                    break;

                case 1:
                    outputLabel.Text = "You want to create a cupcake business. Your town does not even have bakery yet so everyone is super excited. This sounds like a great idea but are you even good at baking?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowFakeButton.BackColor = Color.Transparent;

                    pictureBox.BackgroundImage = Properties.Resources.scene_1_again;
                    sceneSound = new SoundPlayer(Properties.Resources.sweet);
                    sceneSound.Play();
                    break;

                case 2:
                    outputLabel.Text = " Your life long dream has been to present a clothing line during paris fashion week. Do you want to start selling clothing online or in a store?";
                    redLabel.Text = "Online";
                    blueLabel.Text = "In a store";
                    yellowFakeButton.BackColor = Color.Transparent;

                    pictureBox.BackgroundImage = Properties.Resources.scene_2;
                    sceneSound = new SoundPlayer(Properties.Resources.sewingMachine);
                    sceneSound.Play();
                    break;

                case 3:
                    outputLabel.Text = "You are ahead of the game. You already love baking and your creations are pretty tasty. Do you think partnering with another company would be a good idea?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowFakeButton.BackColor = Color.Transparent;

                    pictureBox.BackgroundImage = Properties.Resources.scene_3_again;
                    sceneSound = new SoundPlayer(Properties.Resources.ovenDing);
                    sceneSound.Play();
                    break;

                case 4:// successful case and close program
                    outputLabel.Text = "  Smart move on your part! Every party Miranda plans will now use your cakes. Both of you are bound to be millionaires. Congrats!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    redFakeButton.BackColor = Color.Transparent;
                    blueFakeButton.BackColor = Color.Transparent;
                    yellowFakeButton.BackColor = Color.Transparent;
                    yellowLabel.Text = "";

                    pictureBox.BackgroundImage = Properties.Resources.money_2;
                    sceneSound = new SoundPlayer(Properties.Resources.sucess);
                    sceneSound.Play();

                    Refresh();
                    Thread.Sleep(5000);
                    Application.Exit();
                    break;

                case 5:
                    outputLabel.Text = "Your small business is not going to work well with no experience. Maybe this company is not the right fit for ou. Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowFakeButton.BackColor = Color.Transparent;
                    yellowLabel.Text = "";

                    pictureBox.BackgroundImage = Properties.Resources.bored;
                    sceneSound = new SoundPlayer(Properties.Resources.error);
                    sceneSound.Play();

                    break;

                case 6:
                    outputLabel.Text = "There are so many great small businesses you can team up with. What company would you like to partner with?";
                    redLabel.Text = "Christi's Cakes";
                    blueLabel.Text = "World Gym";
                    yellowLabel.Text = "Miranda's Party Planning";
                    yellowFakeButton.BackColor = Color.Goldenrod;

                    pictureBox.BackgroundImage = Properties.Resources.partner_3;
                    sceneSound = new SoundPlayer(Properties.Resources.applause);
                    sceneSound.Play();
                    break;

                case 7:  
                    outputLabel.Text = "Why would you partner with a gym full of health geeks when you are selling sweet treats. This drove you out of business. Do better. Would you like to play again";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    yellowFakeButton.BackColor = Color.Transparent;

                    pictureBox.BackgroundImage = Properties.Resources.healthy;
                    sceneSound = new SoundPlayer(Properties.Resources.error);
                    sceneSound.Play();

                    break;

                case 8: 
                    outputLabel.Text = "Uh oh...Christi was partnering with you just to sabatoge you. You are now bankrupt and somehow have a warrant for arrest in your name. Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    yellowFakeButton.BackColor = Color.Transparent;

                    pictureBox.BackgroundImage = Properties.Resources.pri;
                    sceneSound = new SoundPlayer(Properties.Resources.error);
                    sceneSound.Play();
                    break;

                case 9: //sucessful case and close program
                    outputLabel.Text = "You were determined to make it work on your own and boy did it pay off. Jeff Bezos wants you to make his daughters birthday cake.You are rich!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    yellowFakeButton.BackColor = Color.Transparent;
                    blueFakeButton.BackColor = Color.Transparent;
                    redFakeButton.BackColor = Color.Transparent;

                    pictureBox.BackgroundImage = Properties.Resources.money_2;
                    sceneSound = new SoundPlayer(Properties.Resources.sucess);
                    sceneSound.Play();

                    Refresh();
                    Thread.Sleep(5000);
                    Application.Exit();

                    break;

                case 10: 
                    outputLabel.Text = "Uh oh...you got bored of your own business and gave up. All your start up money is gone and you are now broke. Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    yellowFakeButton.Text = "";

                    pictureBox.BackgroundImage = Properties.Resources.bored;
                    sceneSound = new SoundPlayer(Properties.Resources.error);
                    sceneSound.Play();
                    break;

                case 11: 
                    outputLabel.Text = "You decide to sell in a store. A top fashion designer liked what he sees. Do you want to talk to him?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    yellowFakeButton.Text = "";

                    pictureBox.BackgroundImage = Properties.Resources.talk;
                    sceneSound = new SoundPlayer(Properties.Resources.talking);
                    sceneSound.Play();
                    break;

                case 12: 
                    outputLabel.Text = "Within your first month of sales your website got hacked! Everyones information got leaked and you are in deep trouble. You have been sued. Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    yellowFakeButton.Text = "";
                    pictureBox.BackgroundImage = Properties.Resources.comcom;
                    sceneSound = new SoundPlayer(Properties.Resources.error);
                    sceneSound.Play();
                    break;

                case 13:  //successful case and quit program
                    outputLabel.Text = "You talk to him and he wants to mentor you during fashion week. You are going to paris!! You are bound to be sucessful!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    yellowFakeButton.BackColor = Color.Transparent;
                    blueFakeButton.BackColor = Color.Transparent;
                    redFakeButton.BackColor = Color.Transparent;

                    pictureBox.BackgroundImage = Properties.Resources.paris;
                    sceneSound = new SoundPlayer(Properties.Resources.sucess);
                    sceneSound.Play();

                    Refresh();
                    Thread.Sleep(5000);
                    Application.Exit();
                    break;

                case 14: 
                    outputLabel.Text = "You roll your eyes and walk away. Little did you know he was looking for new talent to take to Paris for fashion week. You gain a bad reputation and all of a sudden no one wants to support your business. Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    yellowFakeButton.Text = "";

                    pictureBox.BackgroundImage = Properties.Resources.closeclose;
                    sceneSound = new SoundPlayer(Properties.Resources.error);
                    sceneSound.Play();
                    break;

                case 99:  //end scene 
                    outputLabel.Text = "Thank you for playing! Better luck next time!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    blueFakeButton.BackColor = Color.Transparent;
                    redFakeButton.BackColor = Color.Transparent;
                    yellowLabel.Text = "";
                    yellowFakeButton.BackColor = Color.Transparent;
                    pictureBox.BackgroundImage = Properties.Resources.colour ;
                    sceneSound = new SoundPlayer(Properties.Resources.gameOver);
                    sceneSound.Play();

                    Refresh();
                    Thread.Sleep(3000);
                    Application.Exit();
                    break;
                    






            }
        }

 
    }
}

