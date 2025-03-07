using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 텍스트알피지시험
{
    class Monster
    {
        public INFO info;


        public void SetDamage(int Dmg) { info.Hp -= Dmg; }

        public INFO GetINFO() { return info; }

        public void SetMonster(INFO tMonster) { info = tMonster; }



    }

}
