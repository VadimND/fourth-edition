using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintBall
{
    internal class PaintBallGun
    {
        public PaintBallGun(int balls, int magazineSize, bool loaded)
        {
            this.balls = balls;
            MagazineSize = magazineSize;
            if (!loaded) Reload();
        }
        //public const int MAGAZINE_SIZE = 16;
        private int balls = 0;
        public int MagazineSize { get; private set; } = 16;
        //private int BallsLoaded = 0;

        /*public int BallsLoaded
        {
            get { return ballsLoaded; }
            set { ballsLoaded = value; }
        }*/
        public int BallsLoaded { get; private set; }
        /*public int GatBallsLoaded()
        {
            return ballsLoaded;
        }*/

        public bool IsEmpty()
        {
            return BallsLoaded == 0;
        }
        /*public int GetBalls ()
        {
            return balls;
        }
        public void SetBalls(int numberOfBalls)
        {
            if(numberOfBalls > 0)
            {
                balls = numberOfBalls;                
            }
            Reload();
        }*/
        public int Balls
        {
            get { return balls; }
            set { if (value > 0) balls = value;
                Reload();
            }
        }
        public void Reload()
        {
            if (balls > MagazineSize)
            {
                BallsLoaded = MagazineSize;
            } else
            {
                BallsLoaded = balls;
            }
        }
        public bool Shoot()
        {
            if(BallsLoaded == 0)
            {
                return false;
            }
            BallsLoaded--;
            balls--;

            return true;
        }

    }
}
