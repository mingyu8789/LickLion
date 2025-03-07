using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_연습
{
    class Player
    {
        public Classic PlayerClassic;

        //플레이어 체력 데미지
        public void SetDamage(int Attack) { PlayerClassic.Hp -= Attack; }






        public void PlayerJob()
        {
            Random rand = new Random();


            PlayerClassic = new Classic();

            int chose = 0;
            Console.WriteLine("플레이어의 직업을 선택해주세요.");
            Console.WriteLine("1. 전사");
            Console.WriteLine("2. 마법사");
            Console.WriteLine("3. 도적");
            Console.WriteLine("4. 궁수");

            chose = int.Parse(Console.ReadLine());



            switch (chose)
            {
                case 1:
                    PlayerClassic.Name = "전사";
                    PlayerClassic.Hp = 500;
                    PlayerClassic.Turn = 3;
                    PlayerClassic.Ex = "상황에 따라 적제적소에 활용가능한 직업군입니다.";

                    PlayerClassic.Skill1_Name = "베기";
                    PlayerClassic.Skill1_Turn = 1;
                    PlayerClassic.Skill1_Dmg = rand.Next(30, 41);
                    PlayerClassic.Skill1_Ex = "※ Dmg 30~40 , Turn 1 (안정적이고 기본적인 공격입니다.)";

                    PlayerClassic.Skill2_Name = "연속베기";
                    PlayerClassic.Skill2_Turn = 1;
                    PlayerClassic.Skill2_Dmg = rand.Next(20, 31);
                    PlayerClassic.Skill2_Add = rand.Next(1, 3);
                    PlayerClassic.Skill2_Ex = "※ Dmg 20~30 , Turn 1 (50%확률로 Turn수가 1 늘어납니다.)";

                    PlayerClassic.Skill3_Name = "가르기";
                    PlayerClassic.Skill3_Turn = 2;
                    PlayerClassic.Skill3_Dmg = rand.Next(60, 111);
                    PlayerClassic.Skill3_Ex = "※ Dmg 60~110 , Turn 2 (적을 단숨에 두동강 냅니다)";
                    
                break;
            }
        }



        public void PlayerInfo()
        {
            Console.WriteLine("=====================");
            Console.WriteLine($"직업 : {PlayerClassic.Name}");
            Console.WriteLine($"체력 : {PlayerClassic.Hp}");
            Console.WriteLine($"턴수 : {PlayerClassic.Turn}");
            Console.WriteLine($"직업특성 : {PlayerClassic.Ex}");
            Console.WriteLine("=====================");

        }





    }
}
