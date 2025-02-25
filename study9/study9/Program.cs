using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study9
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch문

            //int day = 1;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    case 4:
            //        Console.WriteLine("목요일");
            //        break;
            //    case 5:
            //        Console.WriteLine("금요일");
            //        break; 
            //    default:
            //        Console.WriteLine("주말입니다");
            //        break;
            //}



            ////문제
            //int Player = 0;

            //Console.WriteLine("캐릭터를 선택하세요.");
            //Console.WriteLine("1. 검사");
            //Console.WriteLine("2. 마법사");
            //Console.WriteLine("3. 도적");

            //Player = int.Parse(Console.ReadLine());

            //switch (Player)
            //{
            //    case 1:
            //        Console.WriteLine("직업 : 검사");
            //        Console.WriteLine("공격력 : 100");
            //        Console.WriteLine("방어력 : 90");
            //        break;
            //    case 2:
            //        Console.WriteLine("직업 : 마법사");
            //        Console.WriteLine("공격력 : 110");
            //        Console.WriteLine("방어력 : 80");
            //        break;
            //    case 3:
            //        Console.WriteLine("직업 : 검사");
            //        Console.WriteLine("공격력 : 115");
            //        Console.WriteLine("방어력 : 70");
            //        break;
            //}




            ////반복문

            //for (int i =1; i <= 5; i++)             //(int i는 1이다   i가 5보다 작을경우    i에 1더한다
            //{
            //    Console.WriteLine($"숫자: {i}");    //현재 i값 출력
            //}


            ////0부터 9까지 출력하기

            //for(int i = 0; i <= 9; i++)
            //{
            //    Console.WriteLine($"숫자 : {i}");
            //}

            //1부터 10가지의 합 구하기

            //int sum = 0;

            //for(int i =1; i<=10; i++)
            //{
            //    sum += i;
            //    Console.WriteLine($"1부터 10까지의 합 : {sum}");
            //}





            //int count = 1;

            //while(count <= 5)                       //count가 5보다 작거나 같다면
            //{
            //    Console.WriteLine("Count : " + count);

            //    count++;                            //count 1 더할게

            //    if(count == 3)
            //    {
            //        Console.WriteLine("3일때 반복문 탈출");
            //        break;
            //    }
            //}
            //Console.WriteLine("Count : " + count);





            ////랜덤
            //Random rand = new Random(); //Random 객체를 생성한다.

            ////0이상 10미만의 랜덤 정수 생성
            //int randomNumber = rand.Next(0, 10);    //0~9
            //Console.WriteLine("0 이상 10 미만의 랜덤 정수 : " + randomNumber);


            ////0이상 10미만의 랜덤 정수 생성 10번 반복하기
            //for (int i = 0; i < 10; i++)
            //{
            //    int randomNumber = rand.Next(0, 10);    //0~9
            //    Console.WriteLine("0 이상 10 미만의 랜덤 정수 : " + randomNumber);
            //}


            //대장장이 키우기
            //도끼등급 SSS  10%
            //도끼등급 SS   40%
            //도끼등급 S    50%

            //Random rand = new Random(); //랜덤값을 뽑는 문장

            //int rnd = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    rnd = rand.Next(1, 101);  //1~100


            //    if (rnd >= 1 && rnd <= 10)
            //    {
            //        Console.WriteLine("도끼등급 SSS");
            //    }
            //    else if (rnd >= 11 && rnd <= 40)
            //    {
            //        Console.WriteLine("도끼등급 SS");
            //    }
            //    else
            //    {
            //        Console.WriteLine("도끼등급 S");
            //    }
            //    Thread.Sleep(500); //0.5초정도로 뽑아라.
            //}





            ////do while
            ////1회 무조건 실행하고 while문과 같이 조건진행

            //int X = 5;

            //do
            //{
            //    Console.WriteLine("최소 한번은 실행됩니다.");
            //    X--;
            //} while (X > 0);





            ////break 문
            ////반복문을 탈출할수있다.

            //for(int i=1; i<=10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}





            ////Continue
            ////현재 반복을 건너뛰고 다음 반복으로 넘어간다.

            //for(int i =1; i<=10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);   //홀수만 출력
            //}





            ////goto

            //int n = 1;

            //start:

            //if(n <= 5)
            //{
            //    Console.WriteLine(n);
            //    n++;

            //    goto start; //레이블로 이동
            //}
        }
    }
}
