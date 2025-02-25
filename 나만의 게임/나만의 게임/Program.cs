using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace 나만의_게임
{
    class Program
    {
        static void Main(string[] args)
        {
            //포켓몬

            Console.SetCursorPosition(0, 1);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            for (int a = 2; a <= 7; a++)
            {
                Console.SetCursorPosition(0, a);
                Console.Write("┃                                                                             ┃");
            }


            Console.SetCursorPosition(0, 8);
            Console.Write("┃                                   Pokemon?                                  ┃");


            for (int a = 9; a <= 14; a++)
            {
                Console.SetCursorPosition(0, a);
                Console.Write("┃                                                                             ┃");
            }
            Console.SetCursorPosition(0, 15);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");






            Console.SetCursorPosition(0, 20);
            Console.Write("                     * 시작할려면 Enter를 눌러주세요 *");

            Console.ReadLine();






            for (int a = 1; a <= 3; a++)
            {
                Console.SetCursorPosition(0, 20);
                Console.Write("                                                                     ");
                Thread.Sleep(500);
                Console.SetCursorPosition(0, 20);
                Console.Write("                     * 시작할려면 Enter를 눌러주세요 *");
                Thread.Sleep(500);
            }
            Console.SetCursorPosition(0, 20);
            Console.Write("                               * 시작합니다. *             ");
            Thread.Sleep(500);
            Console.Clear();











            Console.SetCursorPosition(0, 17);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 흐음!!                                                                      ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 잘 왔다!                                                                    ┃");
            Console.SetCursorPosition(0, 20);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.ReadLine();


            Console.SetCursorPosition(0, 17);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 포켓몬스터의 세계에 온 것을                     ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 환영한다!                            ");
            Console.SetCursorPosition(0, 20);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.ReadLine();

            Console.Clear();





            //오박사
            for (int a = 2; a <= 4; a++)
            {
                Console.SetCursorPosition(37, a);
                Console.Write("□□□");
            }

            Console.SetCursorPosition(39, 5);
            Console.Write("□");

            for (int a = 6; a <= 10; a++)
            {
                Console.SetCursorPosition(37, a);
                Console.Write("□□□");
            }

            //왼팔
            Console.SetCursorPosition(35, 6);
            Console.Write("□");
            Console.SetCursorPosition(33, 7);
            Console.Write("□");
            Console.SetCursorPosition(33, 8);
            Console.Write("□");
            Console.SetCursorPosition(35, 9);
            Console.Write("□");
            Console.SetCursorPosition(35, 10);
            Console.Write("□");

            //오른팔
            Console.SetCursorPosition(42, 6);
            Console.Write("□");
            Console.SetCursorPosition(43, 7);
            Console.Write("□");
            Console.SetCursorPosition(44, 8);
            Console.Write("□");
            Console.SetCursorPosition(44, 9);
            Console.Write("□");
            Console.SetCursorPosition(44, 10);
            Console.Write("□");


            for (int a = 11; a <= 15; a++)
            {
                Console.SetCursorPosition(37, a);
                Console.Write("□  □");
            }

            Thread.Sleep(500);

            for (int a = 2; a <= 4; a++)
            {
                Console.SetCursorPosition(37, a);
                Console.Write("■■■");
            }

            Console.SetCursorPosition(39, 5);
            Console.Write("■");

            for (int a = 6; a <= 10; a++)
            {
                Console.SetCursorPosition(37, a);
                Console.Write("■■■");
            }

            //왼팔
            Console.SetCursorPosition(35, 6);
            Console.Write("■");
            Console.SetCursorPosition(33, 7);
            Console.Write("■");
            Console.SetCursorPosition(33, 8);
            Console.Write("■");
            Console.SetCursorPosition(35, 9);
            Console.Write("■");
            Console.SetCursorPosition(35, 10);
            Console.Write("■");

            //오른팔
            Console.SetCursorPosition(42, 6);
            Console.Write("■");
            Console.SetCursorPosition(43, 7);
            Console.Write("■");
            Console.SetCursorPosition(44, 8);
            Console.Write("■");
            Console.SetCursorPosition(44, 9);
            Console.Write("■");
            Console.SetCursorPosition(44, 10);
            Console.Write("■");


            for (int a = 11; a <= 15; a++)
            {
                Console.SetCursorPosition(37, a);
                Console.Write("■  ■");
            }



            Thread.Sleep(500);




            Console.SetCursorPosition(0, 17);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 내 이름은 마박사!                                                           ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 20);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.ReadLine();

            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 모두가                     ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 포켓몬 박사님이라 부르고 있단다                            ");
            Console.ReadLine();

            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 응? 뭐라고?                     ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 너가 알던 박사님이랑 다르다고?                            ");
            Console.ReadLine();

            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 시간도 없고 텍스트의 한계도 있으니                    ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 그냥 그려러니 하고 플레이해주게                           ");
            Console.ReadLine();

            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 그건 그렇고 자네는                   ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 모험이 처음인겐가?                          ");
            Console.ReadLine();

            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 그럼 내가                   ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 이것저것 가르쳐주마!                          ");
            Console.ReadLine();

            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 이 세계에는                  ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 포켓몬스터                          ");
            Console.ReadLine();

            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 줄여서 '포켓몬'이라 불리는                  ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 신기한 생명체가                          ");
            Console.ReadLine();

            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 신기한 생명체가                          ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 도처에 살고 있다!                          ");
            Console.ReadLine();

            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 우리 인간은                          ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 포켓몬과 사이좋게 살고 있지                         ");
            Console.ReadLine();

            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 함께 놀기도 하고                          ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 힘을 합쳐 일을 하기도 하고                         ");
            Console.ReadLine();

            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 그리고 포켓몬끼리 싸우게 하여                         ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 유대감을 돈독히 다지기도 하고...                         ");
            Console.ReadLine();

            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 이 이상 적는건 귀찮군..                         ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 바로 너의 포켓몬을 골라보렴!                         ");
            Console.ReadLine();
            Console.Clear();





            Console.SetCursorPosition(8, 2);
            Console.Write("■  ■");
            Console.SetCursorPosition(10, 3);
            Console.Write("■");
            Console.SetCursorPosition(2, 4);
            Console.Write("■■■■■■");
            Console.SetCursorPosition(2, 5);
            Console.Write("■■■○■■");
            Console.SetCursorPosition(2, 6);
            Console.Write("■■■■■■");
            Console.SetCursorPosition(2, 7);
            Console.Write("■■■■■■□□□□");
            Console.SetCursorPosition(8, 8);
            Console.Write("■■□□□□□□");
            Console.SetCursorPosition(8, 9);
            Console.Write("■■■■□□□□");
            Console.SetCursorPosition(8, 10);
            Console.Write("■■■■■■■■");
            Console.SetCursorPosition(8, 11);
            Console.Write("■  ■        ■");
            Console.SetCursorPosition(8, 13);
            Console.Write("[ 1. 꼬부기? ]");



            Console.SetCursorPosition(45, 1);
            Console.Write("■");
            Console.SetCursorPosition(42, 2);
            Console.Write("■■");
            Console.SetCursorPosition(35, 3);
            Console.Write("■■■■■■");
            Console.SetCursorPosition(35, 4);
            Console.Write("■■■■■■■");
            Console.SetCursorPosition(35, 5);
            Console.Write("■○■■○■■");
            Console.SetCursorPosition(35, 6);
            Console.Write("■■■■■■");
            Console.SetCursorPosition(37, 7);
            Console.Write("■■■");
            Console.SetCursorPosition(40, 8);
            Console.Write("■■");
            Console.SetCursorPosition(37, 9);
            Console.Write("■ ■■ ■");
            Console.SetCursorPosition(40, 10);
            Console.Write("■■");
            Console.SetCursorPosition(39, 11);
            Console.Write("■  ■");
            Console.SetCursorPosition(34, 13);
            Console.Write("[ 2. 불꽃숭이? ]");


            int pokemon = 0;

            Console.SetCursorPosition(0, 17);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 너와 함께할 포켓몬을 선택하렴!                                              ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 20);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Console.SetCursorPosition(2, 19);
            Console.Write("선택하기 : ");
            pokemon = int.Parse(Console.ReadLine());

            string name = "엄준식";

            if (pokemon == 1)
            {
                name = "꼬북이";
            }
            else if (pokemon == 2)
            {
                name = "불꽃숭이";
            }

            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 좋아 이제 너가 고른 포켓몬과                        ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 배틀을 배워보자!");
            Console.ReadLine();
            Console.Clear();


            Random rand = new Random();

            int battle = 0;
            int skill1 = 35;
            int skill2 = 40;

            int hp1 = 20;
            int hp2 = 20;


            Console.SetCursorPosition(62, 1);
            Console.Write("■■");
            Console.SetCursorPosition(60, 2);
            Console.Write("■■■■");
            Console.SetCursorPosition(60, 3);
            Console.Write("●■■●");
            Console.SetCursorPosition(60, 4);
            Console.Write("■□□■");
            Console.SetCursorPosition(58, 5);
            Console.Write("○■□□■○");
            Console.SetCursorPosition(56, 6);
            Console.Write("○○■■■■○○");
            Console.SetCursorPosition(58, 7);
            Console.Write("○○○○○○");
            Console.SetCursorPosition(60, 8);
            Console.Write("○○○○");

            Console.SetCursorPosition(5, 2);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(5, 3);
            Console.Write("┃ 디그다                  ♂Lv2   ┃");
            Console.SetCursorPosition(5, 4);
            Console.Write("┃                     HP :        ┃");
            Console.SetCursorPosition(5, 5);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Console.SetCursorPosition(32, 4);
            Console.Write(hp2);

            Console.SetCursorPosition(10, 11);
            Console.Write("■■■■");
            Console.SetCursorPosition(10, 12);
            Console.Write("■■■■");
            Console.SetCursorPosition(10, 13);
            Console.Write("■■■■");
            Console.SetCursorPosition(10, 14);
            Console.Write("■■■■");
            Console.SetCursorPosition(9, 15);
            Console.Write("■■■■■");
            Console.SetCursorPosition(9, 16);
            Console.Write("■■■■■");

            Console.SetCursorPosition(44, 11);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(44, 12);
            Console.Write("┃                         ♂Lv5   ┃");
            Console.SetCursorPosition(44, 13);
            Console.Write("┃                     HP :        ┃");
            Console.SetCursorPosition(44, 14);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Console.SetCursorPosition(46, 12);
            Console.Write(name);

            Console.SetCursorPosition(71, 13);
            Console.Write(hp1);

            Console.SetCursorPosition(0, 17);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 20);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 21);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 22);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        dg:
            Console.SetCursorPosition(0, 18);
            Console.Write("┃ 1. 공격하기                        ");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃ 2. 도망가기                                   ");
            Console.SetCursorPosition(0, 20);
            Console.Write("┃                         ");
            Console.SetCursorPosition(0, 21);
            Console.Write("┃ 무엇을 할까 :    ");
            Console.SetCursorPosition(16, 21);
            battle = int.Parse(Console.ReadLine());




            if (battle == 1)
            {
                Console.SetCursorPosition(0, 18);
                Console.Write("┃ 1. 막치기     PP 35/" + skill1);
                Console.SetCursorPosition(0, 19);
                Console.Write("┃ 2. 울음소리     PP 40/" + skill2);
                Console.SetCursorPosition(0, 20);
                Console.Write("┃                         ");
                Console.SetCursorPosition(0, 21);
                Console.Write("┃ 무엇을 할까 :      ");
                Console.SetCursorPosition(16, 21);
                battle = int.Parse(Console.ReadLine());

                if (battle == 1)
                {
                    skill1 -= 1;
                    int damage = rand.Next(5, 21);
                    Console.SetCursorPosition(0, 18);
                    Console.Write("┃ " + (name) + "의                    ");
                    Console.SetCursorPosition(0, 19);
                    Console.Write("┃ 막치기 공격!      " + damage + " 데미지!");
                    hp2 -= damage;
                    Console.SetCursorPosition(32, 4);
                    Console.Write("    ");
                    Console.SetCursorPosition(32, 4);
                    Console.Write(hp2);
                    Console.ReadLine();

                    if (hp2 <= 0)
                    {
                        Console.SetCursorPosition(0, 18);
                        Console.Write("┃ 디그다가 쓰러졌다!                        ");
                        Console.SetCursorPosition(0, 19);
                        Console.Write("┃                                    ");
                        Console.SetCursorPosition(0, 20);
                        Console.Write("┃                         ");
                        Console.SetCursorPosition(0, 21);
                        Console.Write("┃                   ");
                        Console.ReadLine();

                        Console.SetCursorPosition(0, 19);
                        Console.Write("┃ 적에게서 30 Gold 를 얻었다!                        ");
                        Console.ReadLine();

                        Console.SetCursorPosition(0, 20);
                        Console.Write("┃ 경험치가 10 증가하였다!                      ");
                        Console.ReadLine();

                        Console.Clear();

                        Console.WriteLine("Game clear");
                        Console.WriteLine("엔딩 : 더 만들기 힘들어");
                        Console.ReadLine();


                    }
                }

                if (battle == 2)
                {
                    skill2 -= 1;
                    Console.SetCursorPosition(0, 18);
                    Console.Write("┃ " + (name) + "의 울음소리!!      ");
                    Console.SetCursorPosition(0, 19);
                    Console.Write("┃ 적이 약해진 것 같다      (아마...아닐꺼다.)");
                    Console.ReadLine();
                }
                goto dg;
            }

            if (battle == 2)
            {
                Console.SetCursorPosition(0, 18);
                Console.Write("┃ 당신은 도망치는대 성공했다!");
                Console.SetCursorPosition(0, 19);
                Console.Write("┃                                    ");
                Console.SetCursorPosition(0, 21);
                Console.Write("┃                                ");
                Console.ReadLine();

                Console.SetCursorPosition(0, 18);
                Console.Write("┃ 오박사는 당신에게 실망했다.");
                Console.ReadLine();

                Console.SetCursorPosition(0, 19);
                Console.Write("┃ 당신의 신뢰도가 대폭 하락했다.");
                Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Game Over");
                Console.WriteLine("엔딩 : 겁쟁이");
                Console.ReadLine();
            }

        }
    }
}
