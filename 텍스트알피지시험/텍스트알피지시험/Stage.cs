using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 텍스트알피지시험
{
    public class Stage
    {
        public INFO info;

        public void PlayerChoseJobStage()
        {
            info = new INFO();

            Console.WriteLine("1.전사");
            Console.WriteLine("2.마법사");
            Console.WriteLine("3.도적");
            Console.WriteLine("");
            Console.Write("직업을 선택해주세요");
            info.PlayerChose = int.Parse(Console.ReadLine());


            switch (info.PlayerChose)
            {
                case 1:
                    info.Name = "전사";
                    info.Hp = 100;
                    info.Dmg = 10;
                    break;

                case 2:
                    info.Name = "마법사";
                    info.Hp = 100;
                    info.Dmg = 10;
                    break;
                case 3:
                    info.Name = "도적";
                    info.Hp = 100;
                    info.Dmg = 10;
                    break;

            }
        }




        public void VillageStage()
        {
            info = new INFO();

            while (true)
            {
                Console.WriteLine("1. 사냥터");
                Console.WriteLine("2. 종료");
                Console.Write("선택해주세요 : ");
                info.PlayerChose = int.Parse(Console.ReadLine());




                if (info.PlayerChose == 1)
                {
                    //사냥터 구현하기
                }

                if (info.PlayerChose == 2)
                    break;
            }
        }
    }
}
