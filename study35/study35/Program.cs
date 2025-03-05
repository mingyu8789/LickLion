using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study35
{
    class Skill
    {
        public string Name; //스킬 이름
        public int ManaCost; //마나 소모량
        public int Cooldown; //재사용 대기 시간(밀리초)
        public int HP;  //체력
        public int LastUsedTime; //마지막 사용 시간 (TickCount 기준)

        public Skill(string name, int manaCost, int cooldown, int hp)
        {
            Name = name;
            ManaCost = manaCost;
            Cooldown = cooldown * 1000; //초를 밀리초로 변환
            HP = hp;
            LastUsedTime = 0; //처음엔 사용하지 않은 상태
        }

        //스킬 사용 가능 여부 확인
        public bool CanUse(int playerMana)
        {
            int currentTime = Environment.TickCount;

            if (playerMana < ManaCost)
            {
                Console.WriteLine($" 마나가 부족합니다! (필요 MP: {ManaCost}");
                return false;
            }

            if (currentTime - LastUsedTime < Cooldown)
            {
                int remainingTime = (Cooldown - (currentTime - LastUsedTime)) / 1000;
                Console.WriteLine($" {Name} 스킬은 아직 사용할 수 없습니다.(남은 시간 : {remainingTime}초)");
                return false;
            }

            return true;
        }


        //스킬 사용
        public void Use(ref int playerMana)
        {
            if (!CanUse(playerMana)) return;

            playerMana -= ManaCost; //플레이어마나 참조로 외부 값도 같이 조정 동기화
            LastUsedTime = Environment.TickCount; //현재 시간을 저장

            Console.WriteLine($"{Name} 스킬 사용! (MP - {ManaCost})");

        }


        //마나 회복 스킬 사용
        public void HpPlus(int playerMP)
        {

        }
    }











    class Program
    {
        static void Main(string[] args)
        {
            int CharterChose = 0;    //선택할 캐릭터
            string Charter = "";    //선택한 캐릭터

            string[] Skill = new string[4];     //스킬이름
            int[] mana = new int[4];            //마나 소모량
            int[] cooltime = new int[4];        //쿨타임
            int hp = 0;              //체력
            int playerMana = 0; //플레이어의 초기 마나


            Console.WriteLine("1. 전사");
            Console.WriteLine("2. 마법사");
            Console.WriteLine("3. 궁수");
            Console.Write("캐릭터를 선택해주세요. : ");
            CharterChose = int.Parse(Console.ReadLine());





            switch (CharterChose)
            {
                case 1:
                    Charter = "전사";
                    Skill[0] = "베기";
                    Skill[1] = "가르기";
                    Skill[2] = "명상";
                    Skill[3] = "이동하기";

                    mana[0] = 10;
                    mana[1] = 20;
                    mana[2] = 40;
                    mana[3] = 0;

                    cooltime[0] = 3;
                    cooltime[1] = 6;
                    cooltime[2] = 15;
                    cooltime[3] = 1;

                    hp = 500;

                    playerMana = 100;
                    break;
                case 2:
                    Charter = "마법사";
                    Skill[0] = "파이어볼";
                    Skill[1] = "라이트닝";
                    Skill[2] = "힐";
                    Skill[3] = "이동하기";

                    mana[0] = 40;
                    mana[1] = 60;
                    mana[2] = 20;
                    mana[3] = 0;

                    cooltime[0] = 10;
                    cooltime[1] = 20;
                    cooltime[2] = 30;
                    cooltime[3] = 1;

                    hp = 100;

                    playerMana = 400;
                    break;
                case 3:
                    Charter = "궁수";
                    Skill[0] = "더블샷";
                    Skill[1] = "파이어 애로우";
                    Skill[2] = "비상식량";
                    Skill[3] = "이동하기";

                    mana[0] = 10;
                    mana[1] = 40;
                    mana[2] = 30;
                    mana[3] = 0;

                    cooltime[0] = 5;
                    cooltime[1] = 10;
                    cooltime[2] = 20;
                    cooltime[3] = 1;

                    hp = 200;

                    playerMana = 300;
                    break;
            }




            Skill[] skills = new Skill[]
            {
            new Skill(Skill[0],mana[0],cooltime[0],hp),  //마나 20, 소모, 3초 쿨다운 
            new Skill(Skill[1],mana[1],cooltime[1],hp),    //마나 15, 소모, 2초 쿨다운 
            new Skill(Skill[2],mana[2],cooltime[2],hp),    //마나 30, 소모, 5초 쿨다운 
            new Skill(Skill[3],mana[3],cooltime[3],hp),    //마나 30, 소모, 5초 쿨다운 
            };





            while (true)
            {
                Console.Clear();
                Console.WriteLine($"직업: {Charter}");
                Console.WriteLine($"현재 HP: {hp}");
                Console.WriteLine($"현재 MP: {playerMana}");
                Console.WriteLine("사용 가능한 스킬: ");
                for (int i = 0; i < skills.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {skills[i].Name} (MP {skills[i].ManaCost} " +
                        $",쿨다운 {skills[i].Cooldown / 1000}s)");
                }
                Console.WriteLine("0.종료");
                Console.Write("사용할 스킬 번호를 입력하세요: ");


                try
                {
                    int skillIndex = int.Parse(Console.ReadLine());

                    if (skillIndex == 0) break;

                    if (skillIndex > 0 && skillIndex <= skills.Length)
                    {
                        skills[skillIndex - 1].Use(ref playerMana);
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                    }
                }
                catch
                {
                    Console.WriteLine("숫자를 입력하세요!");
                }

                Thread.Sleep(500); //CPU과부화 방지

            }
            Console.WriteLine("게임종료");
        }
    }
}
