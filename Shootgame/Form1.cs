using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shootgame
{
    public partial class Form1 : Form
    {
        ShootClass1 Shoot = new ShootClass1();
        public object ShootAHaed { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void ShootAway_Click(object sender, EventArgs e)
        {
            if (Shoot.ShootAwayChances == 1)
            {
                ShootAway.Enabled = false;
                PlayTheGameAgain.Enabled = true;
            }
            Shoot.ShootAway();
            SoundPlayer player = new SoundPlayer(Resource1.ShootAwaySound);
            player.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Shoot.Load();
            Load.Enabled = true;
            Spin.Enabled = false;
            ShootAHead.Enabled = false;
            ShootAway.Enabled = false;
        }

        private void ShootAHead_Click(object sender, EventArgs e)
        {
            Shoot.ShootAHead();
            PlayTheGameAgain.Enabled = true;
            TextBox2.Text = Shoot.Score + "";
            SoundPlayer player = new SoundPlayer(Resource1.ShootAHeadSound);
            player.Play();
            if(Shoot.ShootAHeadChances==0)
            {
                ShootAHead.Enabled = false;
            }
        }
        //Spin
        private void Spin_Click(object sender, EventArgs e)
        {
            Shoot.Load();
            Load.Enabled = false;
            Spin.Enabled = false;
            ShootAHead.Enabled = true;
            ShootAway.Enabled = true;
            PlayTheGameAgain.Enabled = false;
            SoundPlayer player = new SoundPlayer(Resource1.SpinSound);

        }
        //Load Coding

        private void Load_Click(object sender, EventArgs e)
        {
            Shoot.Load();
            Load.Enabled = false;
            Spin.Enabled = true;
            ShootAHead.Enabled = false;
            ShootAway.Enabled = false;
            PlayTheGameAgain.Enabled = false;
            SoundPlayer player = new SoundPlayer(Resource1.LoadSound);

        }

        private void Score_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
