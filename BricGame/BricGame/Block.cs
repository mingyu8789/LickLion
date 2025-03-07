using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrickGame;

namespace BricGame
{
        public class Block
        {
            bool[,] blocks;
            int max_block;
            int num_block;

            public void Initialize()
            {
                max_block = 10;
                num_block = max_block;
                blocks = new bool[80, 25];
                for (int i = 0; i < 80; i++)
                    for (int j = 0; j < 25; j++)
                        blocks[i, j] = false;

                Random rand = new Random();
                for (int i = 0; i < max_block; i++) // max_block 만큼 블록 생성
                {
                    int x, y;
                    x = rand.Next(2, 77);
                    y = rand.Next(2, 16);
                    if (!blocks[x, y]) // x,y가 비어있다면 생성
                        blocks[x, y] = true;
                    else
                        i--; // 이미 차있으면 랜덤위치 재시도
                }
            }

            public bool Collision(int x, int y, Ball b)
            {
                //x,y는 진행할 칸
                //진행할 칸, 가로진행 세로진행 3가지 체크
                switch (b.GetBall().nDirect) //진행 방향에 따라
                {

                    case 1: //오른쪽 위
                        if (blocks[x, y]) // 대각선 충돌
                        {
                            b.GetBall().nDirect = 4;
                            this.Delete(x, y);
                            return true;
                        }
                        else if (blocks[x - 1, y]) // 가로방향 충돌
                        {
                            b.GetBall().nDirect = 2;
                            this.Delete(x - 1, y);
                            return true;
                        }
                        else if (blocks[x, y + 1]) // 세로방향 충돌
                        {
                            b.GetBall().nDirect = 5;
                            this.Delete(x, y + 1);
                            return true;
                        }
                        break;
                    case 2: //오른쪽 아래
                        if (blocks[x, y]) // 대각선 충돌
                        {
                            b.GetBall().nDirect = 5;
                            this.Delete(x, y);
                            return true;
                        }
                        else if (blocks[x - 1, y]) // 가로방향 충돌
                        {
                            b.GetBall().nDirect = 1;
                            this.Delete(x - 1, y);
                            return true;
                        }
                        else if (blocks[x, y - 1]) // 세로방향 충돌
                        {
                            b.GetBall().nDirect = 4;
                            this.Delete(x, y - 1);
                            return true;
                        }
                        break;
                    case 4: //왼쪽 아래
                        if (blocks[x, y]) // 대각선 충돌
                        {
                            b.GetBall().nDirect = 1;
                            this.Delete(x, y);
                            return true;
                        }
                        else if (blocks[x + 1, y]) // 가로방향 충돌
                        {
                            b.GetBall().nDirect = 5;
                            this.Delete(x + 1, y);
                            return true;
                        }
                        else if (blocks[x, y - 1]) // 세로방향 충돌
                        {
                            b.GetBall().nDirect = 2;
                            this.Delete(x, y - 1);
                            return true;
                        }
                        break;
                    case 5: //왼쪽 위
                        if (blocks[x, y]) // 대각선 충돌
                        {
                            b.GetBall().nDirect = 2;
                            this.Delete(x, y);
                            return true;
                        }
                        else if (blocks[x + 1, y]) // 가로방향 충돌
                        {
                            b.GetBall().nDirect = 4;
                            this.Delete(x + 1, y);
                            return true;
                        }
                        else if (blocks[x, y + 1]) // 세로방향 충돌
                        {
                            b.GetBall().nDirect = 1;
                            this.Delete(x, y + 1);
                            return true;
                        }
                        break;
                }
                return false;
            }

            public void Render()
            {
                for (int i = 0; i < 80; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        if (blocks[i, j])
                        {
                            Console.SetCursorPosition(i, j);
                            Console.Write("■");
                        }
                    }
                }
            }

            public void Delete(int x, int y)
            {
                blocks[x, y] = false;
            }
        }
}
