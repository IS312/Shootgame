using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shootgame
{
    class ShootClass1
    {
        //Bullet
        public int Bullet;
        public int Score = 0;
        public int ShootAHeadChances = 1;
        public int ShootAwayChances = 3;
        public void Load()
        {
            Bullet = 0;

        }
        public void Spin()
        {
            Random rand = new Random();
            Bullet = rand.Next(0, 4);
        }
        public void ShootAHead()
        {
            if (Bullet == 4)
            {
                MessageBox.Show("You die");
                Score = Score + 3;
            }
            else
            {
                MessageBox.Show("Play Again");
                Bullet++;
            }
        }
        public void ShootAway()
        {
            ShootAwayChances--;
            if(ShootAwayChances== 0)
            {
                MessageBox.Show("You Lose end");
            }
            else
            {
                if (Bullet ==3)
                {
                    MessageBox.Show("You are Lucky");
                    Score = Score + 3;

                }
                else
                {
                    MessageBox.Show("Continue playing");
                    Bullet++;
                }
            }
        }
    }
}
