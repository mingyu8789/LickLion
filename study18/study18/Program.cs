using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study18
{
    class Program
    {
        

        struct Point
        {
            //public 어디서든 사용가능하게 권한
            //private 나만 사용가능하게 한 권한
            public int X;
            public int Y;


            //생성자 정의 처음생성할때 동작하는 함수
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }




            public void print()
            {
                Console.WriteLine($"좌표 : {X} , {Y}");
            }
        }



        //C# 구조체
        //클래스와 배슷하지만 , 값 타임(Value Type)이며 가볍고 빠름
        //주로 간단한 데이터 묶음을 만들때 사용

        //struct Point는 x, y 좌표 값을 저장하는 구조체
        //구조체는 클래스와 다르게 new 없이 사용가능

        static void Main(string[] args)
        {
            Point p; //구조체 선언 (초기화 필요)

            p.X = 10;
            p.Y = 20;

            p.print();



            //생성자
            Point p1 = new Point(5, 15);

            p1.print();


        }
    }
}
