using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static _3일_프로젝트_성지키기_만들기__.Program;

namespace _3일_프로젝트_성지키기_만들기__
{
    class Program
    {


        //무기 좌표 와 공격
        public class Cane
        {
            public int x;
            public int y;
            public bool CaneAttack;
        }

        public class Number
        {
            public int Coin;
            public int Score;
        }



        //플레이어
        public class Player
        {
            [DllImport("msvcrt.dll")]
            static extern int _getch();  //c언어 함수 가져옴


            public int playerX; //플레이어 x 좌표
            public int playerY; //플레이어 y 좌표
            public Cane[] CaneBullet = new Cane[10];        //공격 최대 개수 10개


            public int Score = 0; //점수








            public Player() //플레이어 생성
            {
                //플레이어 처음 좌표위치 설정
                playerX = 0;    //+면 오른쪽    -면 왼쪽
                playerY = 12;   //+면 아래     -면 위

                for (int i = 0; i < 10; i++)    //지팡이 마법 공격 초기화
                {
                    CaneBullet[i] = new Cane();
                    CaneBullet[i].x = 0;
                    CaneBullet[i].y = 0;
                    CaneBullet[i].CaneAttack = false;
                }
            }










            public void GameMain()
            {
                //키를 입력하는 부분
                KeyControl();
                //플레이얼를 그려준다.
                WizardDraw();
                //UI점수
                UIscore();

                UIcalse();
            }



            private void KeyControl()
            {
                int pressKey;  //정수형 변수선언 키값 받을거임 

                if (Console.KeyAvailable) //키가 눌렸을때 true
                {
                    pressKey = _getch(); //아스키값 왼쪽 오른쪽


                    switch (pressKey)
                    {
                        case 72:  //위쪽방향 아스키코드                    
                            playerY--;
                            if (playerY < 1)
                                playerY = 1;
                            break;
                        case 75:
                            //왼쪽 화살표키
                            playerX--;
                            if (playerX < 0)
                                playerX = 0;
                            break;
                        case 77:
                            //오른쪽
                            playerX++;
                            if (playerX > 75)
                                playerX = 75;
                            break;
                        case 80: //아래
                            playerY++;
                            if (playerY > 21)
                                playerY = 21;
                            break;
                        case 32: //스페이스바
                                 //마법 발사
                            for (int i = 0; i < 10; i++)
                            {
                                //마법이 false 발사가능
                                if (CaneBullet[i].CaneAttack == false)
                                {
                                    CaneBullet[i].CaneAttack = true;
                                    //플레이어 왼쪽 손에서 마법 발사
                                    CaneBullet[i].x = playerX + 1;
                                    CaneBullet[i].y = playerY + 1;
                                    //한발씩 쏘겠다.
                                    break;
                                }
                            }
                            break;
                    }
                }
            }









            //마법 그리기

            public void CaneAttackDraw()
            {
                string magic = "'.*☆"; //마법 공격 모습

                //10개 최대 공격 숫자임
                for (int i = 0; i < 10; i++)
                {
                    //마법이 살아있는 상태
                    if (CaneBullet[i].CaneAttack == true)
                    {
                        //공격 그림 좌표설정
                        Console.SetCursorPosition(CaneBullet[i].x, CaneBullet[i].y);    //스페이스바 누를시 공격 좌표에
                        Console.Write(magic);   //마법공격 그림 출력

                        CaneBullet[i].x++;  //마법공격을 오른쪽으로 날아가게 하기

                        if (CaneBullet[i].x > 75)
                        {
                            CaneBullet[i].CaneAttack = false;   //마법공격 준비 상태로 만들게
                        }
                    }
                }
            }





            //플레이어 그리기
            public void WizardDraw()
            {
                string[] wizard = new string[]
                {
                    "┏ㅡ※",
                    "○",
                    "┗"
                };


                for (int i = 0; i < wizard.Length; i++)
                {
                    Console.SetCursorPosition(playerX, playerY + i);
                    Console.WriteLine(wizard[i]);
                }
            }


            //충돌처리
            public void ClashEnemyAndBullet(Enemy enemy)
            {


                //마법공격 최대개수 10
                for (int i = 0; i < 10; i++)
                {
                    //살아있는 마법
                    if (CaneBullet[i].CaneAttack == true)   //마법공격을 시전했다면       마법그림에 충돌좌표 넣어서 적에 닿으면 사라지게 하기
                    {
                        if (CaneBullet[i].y == enemy.enemyY+1)    //마법이 적의 y값과 같을때
                        {
                            if (CaneBullet[i].x >= (enemy.enemyX - 1)
                                && CaneBullet[i].x <= (enemy.enemyX + 2))
                            {
                                //충돌
                                
                                Random rand = new Random();
                                enemy.enemyX = 75;
                                enemy.enemyY = rand.Next(2, 22);
                                
                                CaneBullet[i].CaneAttack = false; //마법도 준비상태로 만들어주기

                                //점수
                                Score += 100;
                            }
                        }
                    }
                }

            }
            public void UIscore()
            {
                Console.SetCursorPosition(63, 0);
                Console.Write("┏━━━━━━━━━━━━━━┓");
                Console.SetCursorPosition(63, 1);
                Console.Write("┃              ┃");
                Console.SetCursorPosition(65, 1);
                Console.Write("Score : " + Score);
                Console.SetCursorPosition(63, 2);
                Console.Write("┗━━━━━━━━━━━━━━┛");
            }


            public void UIcalse()
            {
                for (int i = 0; i < 25; i++)
                {
                    Console.SetCursorPosition(8, i);
                    Console.Write("ㅁ");
                }
            }
        }










        public class Enemy
        {
            public int enemyX;  //적 위치 x좌표
            public int enemyY;  //적 위치 y좌표


            public Enemy()
            {
                //적 처음 위치 설정
                enemyX = 77;
                enemyY = 12;
            }

            public void EnemyDraw() //적 그리기
            {
                string[] enemy = new string[]
                {
                    "┓",
                    "●",
                    "┛"
                };

                for (int i = 0; i < enemy.Length; i++)
                {
                    //콘솔좌표 설정 적X 적Y
                    Console.SetCursorPosition(enemyX, enemyY + i);
                    Console.WriteLine(enemy[i]);
                }
            }

            public void EnmeyMove()
            {
                Random rand = new Random(); //랜덤 설정 태어나는 위치
                enemyX--;   //왼쪽으로 움직임

                if (enemyX < 2) //왼쪽화면에 부딛히면 새로 좌표잡을것
                {
                    enemyX = 77;    //좌표 오른쪽 77쪽
                    enemyY = rand.Next(2, 22);      //y쪽 좌표 값 랜덤 출력 4~21 중에서 ㅇㅇ
                }
            }

        }






        


        static void Main(string[] args)
        {

            Console.CursorVisible = false;  //커서 안보이게

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);  //콘솔창과  화면에 나타낼 최소 크기 맞추기




            //플레이어 생성
            Player player = new Player();
            Enemy enemy = new Enemy();  //적 생성

            //유니티처럼 속도 프레임속도
            int dwTime = Environment.TickCount;  // 1/1000 초가 흐른다.      랜덤처럼 시간도 미리 쓸거라고 설정


            while (true)    //무한반복할게
            {
                //이것들을 0.05초 지연 할거야
                if (dwTime + 50 < Environment.TickCount)
                {
                    //현재시간 세팅
                    dwTime = Environment.TickCount;     //0.05마다 전부 지울게
                    Console.Clear();

                    //플레이어
                    player.GameMain();

                    //마법
                    player.CaneAttackDraw();

                    enemy.EnmeyMove();//적이동
                    enemy.EnemyDraw();//적그리기


                    player.ClashEnemyAndBullet(enemy);

                }
            }

        }
    }
}
