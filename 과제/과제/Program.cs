using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 과제
{
    class Program
    {
        //부모클래스 (기본유닛)
        class Unit
        {
            public string Name;
            protected int Health;

            public Unit()
            {
                Name = "Unknown";
                Health = 0;
            }

            public virtual void Attack()
            {
                Console.WriteLine($"{Name}이 기본 공격을 합니다. ");
            }

            public virtual void Heal(Unit target)
            {
                Console.WriteLine($"{Name}은 치료할 수 없습니다. ");
            }


            public virtual void Move()
            {
                Console.WriteLine($"{Name}이 이동합니다. ");
            }
        }

      
        class SCV : Unit
        {
            public SCV()
            {
                Name = "블리츠크랭크";
                Health = 60;
            }

            public override void Attack()
            {
                Console.WriteLine("블리츠크랭크가 그랩에 성공 했습니다.! (적을 자신 앞으로 끌어옵니다.)");
            }


            public override void Heal(Unit target)
            {
                Console.WriteLine($"블리츠크랭크가 {target.Name}을 공격합니다.(적을 띄움)");
            }

        }

        //Marine 유닛(총기 공격)
        class Marine : Unit
        {
            public Marine()
            {
                Name = "케이틀린";
                Health = 40;
            }

            public override void Attack()
            {
                Console.WriteLine("케이틀린이 저격소총으로 머리를 공격합니다.");
            }
        }


        //medic
        class Medic : Unit
        {
            public Medic()
            {
                Name = "소라카";
                Health = 50;
            }

            public override void Heal(Unit target)
            {
                Console.WriteLine($"소라카가 {target.Name}을 치료합니다. 체력이 20% 줄어듭니다.");
            }
        }

        //Tank유닛(강력한 공격)
        class Tank : Unit
        {
            public Tank()
            {
                Name = "베이가";
                Health = 150;

            }

            public override void Attack()
            {
                Console.WriteLine("베이가가 암흑물질로 강력한 포격!");
            }


            public override void Move()
            {
                Console.WriteLine("베이가가 미니언으로 스택을 쌓습니다.");
            }

        }










            // Unit units = new SCV();
            static void Main(string[] args)
            {
                List<Unit> units = new List<Unit>();

                units.Add(new SCV());
                units.Add(new Marine());
                units.Add(new Medic());
                units.Add(new Tank());


                //모든 유닛을 순회하며 다형성 적용
                foreach (var unit in units)
                {
                    unit.Move(); //이동
                    unit.Attack(); //공격
                    Console.WriteLine();
                }


                //SCV가 탱크 수리 시도
                SCV scv = new SCV();
                scv.Heal(units[3]); //탱크 수리

                //Medic이 Marince 치료시도
                Medic medic = new Medic();

                medic.Heal(units[1]); //Marine을 치료

            }
        }
}
