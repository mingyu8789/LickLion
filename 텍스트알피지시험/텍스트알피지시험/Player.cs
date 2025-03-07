using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 텍스트알피지시험
{
    public class Player
    {
        public INFO info;

        public void SetDamage(int Dmg) { info.Hp -= Dmg; }

        public INFO GetINFO() { return info; }

        public void SetHp(int Hp) { info.Hp = Hp; }


        public void PlayerInfo()
        {
            info = new INFO();

            Console.WriteLine("====================");
            Console.WriteLine($"직업 : {info.Name}");
            Console.WriteLine($"체력 : {info.Hp}");
            Console.WriteLine($"공격력 : {info.Dmg}");
            Console.WriteLine("====================");
        }

    }
}
