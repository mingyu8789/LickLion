using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study13
{
    class Program
    {
        //1.
        //params 키워드 (가변 매개변수)
        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach(int num in numbers)
            {
                total += num;
            }

            return total;

        }


        ////2. 재귀함수(자기자신을 호출)
        ////자신의 이름으로 돌아온다
        //static void Print()
        //{
        //    Console.WriteLine("나는 재귀함수다.");
        //    Print();
        //}


        //2-1. 재귀함수(자기자신을 호출)
        //팩토리얼을 이용하여 반복하여 5~1까지 서로 곱하는 수를 만들어보자
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;   //출력겸 탈출

            return n * Factorial(n - 1);
        }



        static void Main(string[] args)
        {

            ////1.
            //Console.WriteLine(Sum(1, 2, 3,));   //마음대로 숫자를 넣어서 쓸 수 있다


            ////2.
            ////자신의 이름으로 돌아온다
            //Print();


            //2-1.
            //Factoria(5) = 5 * 4 * 3 * 2 * 1 =120
            Console.WriteLine(Factorial(5));    //5부터 시작   아 시발 이해못하것노



        }
    }
}
