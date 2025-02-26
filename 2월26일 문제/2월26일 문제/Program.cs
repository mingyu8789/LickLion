using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2월26일_문제
{
    


    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {


            ////Q7 두 수의 합을 구하는 함수

            ////문제 : 두개의 정수를 입력받아 합을 반환하는 함수를 작성하세요.

            //int result = Add(3, 5);
            //Console.WriteLine($"3과 5의 합 : {result}");



            ////Q8

            //Console.WriteLine("문자열 입력 : ");
            //string str = Console.ReadLine();
            //Console.WriteLine("문자열 길이 : " + str.Length);


            //Q9
            int a = 0;

            for (int i = 0; i < 3; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (a < b) a = b;
            }
            Console.WriteLine(a);

            //배열 관련 문제


            ////Q1. 배열 요소 출력

            ////문제 : 크기가 5인 정수 배열을 만들고 {10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.

            //int[] Q1 = new int[5];
            //Q1[0] = 10;
            //Q1[1] = 20;
            //Q1[2] = 30;
            //Q1[3] = 40;
            //Q1[4] = 50;

            //for (int i=0; i < Q1.Length; i++)    //Length는 모두 선택
            //{
            //    Console.Write(Q1[i]+" ");
            //}



            ////Q2. 배열 요소 합 구하기

            ////문제 : 사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요.

            //int[] Q2 = new int[5];
            //int Q2Score = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //        Console.Write("정수를 입력해 주세요 : ");
            //        Q2[i] = int.Parse(Console.ReadLine());
            //    Q2Score += Q2[i];
            //}
            //Console.Write("모든 수의 합은 :" + Q2Score);




            ////Q3. 최대값 찾기

            ////문제 : 정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.

            //int[] Q3 = new int[5] { 3, 8, 15, 6, 2, };
            //int max = 0;

            //for (int i = 0; i < Q3.Length; i++)
            //{
            //    if (max < Q3[i]) max = Q3[i];
            //}
            //Console.Write("최대값 : " + max);





            ////Q4 1부터 10까지 출력

            ////문제 : for문을 사용하여 1부터 10까지 출력하세요.

            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}





            ////Q5 짝수만 출력

            ////문제 : while문을 사용하여 1부터 10까지 중 짝수만 출력하세요

            //int Q5 = 1;

            //while (Q5 < 11)
            //{
            //    if (Q5 % 2 == 0)
            //    {
            //        Console.WriteLine(Q5);
            //    }
            //    ++Q5;
            //}





            ////Q6 배열 요소 출력 (Foreach문)

            ////문제 : foreach문을 사용하여 배열 {1, 2, 3, 4, 5}의 요소를 출력하세요

            //int[] Q6 = { 1, 2, 3, 4, 5 };

            //foreach (int i in Q6)
            //{
            //    Console.Write($"{i} ");
            //}







        }
    }
}
