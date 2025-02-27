using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 과제_인벤토리_슈팅게임_함수_써서_만들기
{
    struct Player
    {
        int playerX;
        int playerY;
        public string[] player;
        public Player(bool init)
        {
            playerX = 0;
            playerY = 12;
            player = new string[]
           {
                "->",
                ">>>",
                "->",
           }; //배열 문자열로 그리기
        }

        public void move(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
                case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                case ConsoleKey.Escape: return; //ESC키로 종료 

            }
        }

        public void showPlayer()
        {
            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정 플레이어X 플레이어Y
                Console.SetCursorPosition(playerX, playerY + i);
                //문자열배열 출력
                Console.WriteLine(player[i]);
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)
            Console.CursorVisible = false;

            Player player = new Player(true);

            ConsoleKeyInfo keyInfo;

            //시간 1초루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1 /1000    1000일때 1초
            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; //현재시간 가져오기
                // Console.WriteLine("1초루프");
                if (currentSecond - prevSecond >= 100)
                {
                    Console.Clear();
                    if (Console.KeyAvailable)
                    {
                        keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 X)
                        player.move(keyInfo);//방향키 입력에 따른 좌표 변경

                    }
                    player.showPlayer();

                    prevSecond = currentSecond;//이전 시간 업데이트
                }


            }
        }
    }
}
