using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static _3일_프로젝트_성지키기_만들기__.Program;

namespace _3일_프로젝트_성지키기_만들기__
{

    
    public class WaponBasic         //마법사 무기 이동과 공격유무 설정
    {
        public int x;
        public int y;
        public bool fire;
    }

    public class PlayerMove         //플레이어 이동 설정
    {
        public int x;
        public int y;
    }

    public class MAXwindow      //최대로 갈수있는 화면 이동값
    {
        public int x = 78;
        public int y = 0;
    }







    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public MAXwindow maxwindow = new MAXwindow();       //최대로 갈수있는 화면 이동값

        public PlayerMove playermove = new PlayerMove();        //플레이어 이동 설정

        static int MaxMagic = 10;
        public WaponBasic[] CaneMagic = new WaponBasic[MaxMagic];   //마법사 무기 이동과 공격유무 설정


        public int MagicCount;



        public Player() //생성자
        {
            //플레이어 좌표위치 초기화
            playermove.x = 0;
            playermove.y = 12;

            for (int i = 0; i < 20; i++) //총알 초기화
            {
                CaneMagic[i] = new WaponBasic();
                CaneMagic[i].x = 0;
                CaneMagic[i].y = 0;
                CaneMagic[i].fire = false;
            }


        }



        public void GameMine()
        {
            PlayerKey();
            PlayerDraw();

        }



        private void PlayerKey()
        {
            if (!Console.KeyAvailable) return;
            {
                int key = _getch();




                switch (key)
                {
                    case 72: playermove.y = Math.Max(1, playermove.y - 1); break;
                    case 75: playermove.x = Math.Max(0, playermove.x - 1); break;
                    case 77: playermove.x = Math.Min(75, playermove.x + 1); break;
                    case 80: playermove.y = Math.Min(21, playermove.y + 1); break;
                    case 32:
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (CaneMagic[i].fire == false)
                            {
                                CaneMagic[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                CaneMagic[i].x = playermove.x + 5;
                                CaneMagic[i].y = playermove.y + 1;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        break;
                }
            }
        }





        public void PlayerDraw()
        {
            String[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };//배열 문자열로 그리기


            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정 플레이어X 플레이어Y
                Console.SetCursorPosition(playermove.x, playermove.y + i);
                //문자열배열 출력
                Console.WriteLine(player[i]);
            }
        }



        public void MagicDraw()
        {
            string Magic = "'.*※";

            for (int i = 0; i < MaxMagic; i++)
            {
                if (CaneMagic[i].fire == true)
                {
                    Console.SetCursorPosition(CaneMagic[i].x, CaneMagic[i].y);
                    Console.Write(Magic);
                    CaneMagic[i].x++;

                    if (CaneMagic[i].x > maxwindow.x)
                    {
                        CaneMagic[i].fire = false;
                    }
                }
            }
        }
    }













    class Program
    {

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            int dwTime = Environment.TickCount;


            Player player = new Player();


            while (true) //무한반복
            {
                //0.05초 지연
                if (dwTime + 50 < Environment.TickCount)
                {
                    //현재시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    player.GameMine();
                    player.MagicDraw();
                }






            }
        }
    }
}
