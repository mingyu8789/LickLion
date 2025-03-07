using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_연습
{
    class Field
    {
        Player FieldPlayer = null;



        public void SetPlayer(ref Player pPlayer) { FieldPlayer = pPlayer; }


        public void Progress()
        {
            int iInput = 0;
            
            while (true)
            {
                Console.Clear();

                FieldPlayer.PlayerInfo(); //플레이어 기본상태를 나타낸다.
                DrawMap();      //처음 고르는 선택지

                iInput = int.Parse(Console.ReadLine()); //플레이어 선택

                if (iInput == 4)    //4번이면 멈춤
                    break;

                if (iInput == 3)
                {
                    CreateMonster(iInput);
                    Fight();
                }

            }
        }





        public void  Create(string)








        private void DrawMap()
        {
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 상점");
            Console.WriteLine("3. 고블린 숲");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("맵을 선택하세요 : ");
        }
    }
}
