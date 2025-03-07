using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_연습
{
    class MainGame
    {
        public Player MainPlayer = null;




        public void FirstPlayer()
        {
            MainPlayer = new Player();
            MainPlayer.PlayerJob();

        }




        public void MainProgram()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                MainPlayer.PlayerInfo();
                Console.WriteLine("1.사냥터 2.종료 : ");
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 2)
                    break;
                if (iInput == 1)
                    break;
            }
        }









    }
}
