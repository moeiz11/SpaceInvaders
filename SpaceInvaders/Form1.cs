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

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button_mouseenter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.MediumSpringGreen;
            this.soundmaker = new SoundPlayer(@"C:\Users\moiez\source\repos\SpaceInvaders\SpaceInvaders\ButtonHoverSound.wav");
            soundmaker.Play();
        }
        private void button_mouseleave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.WhiteSmoke;
        }
        //Starten einer einzelnen Gameloop
        private void buttonStart_Click(object sender, EventArgs e)
        {

        }
        //Öffnen des Inventars
        private void buttonSkins_Click(object sender, EventArgs e)
        {

        }
        //Öffnen des Shops
        private void buttonShop_Click(object sender, EventArgs e)
        {

        }
        //Verlassen der Anwendung
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
