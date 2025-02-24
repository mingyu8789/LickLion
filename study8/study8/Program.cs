using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace study8
{
    class Program
    {
        static void Main(string[] args)
        {
            ////두 값을 비교하여 관계를 평가한다.
            //// == 같다 != 같지않다 a < b  c > d  <=   =>

            //int x = 5, y = 10;

            //Console.WriteLine(x == y);  //false
            //Console.WriteLine(x != y);  //true
            //Console.WriteLine(x < y);   //true
            //Console.WriteLine(x > y);   //false
            //Console.WriteLine(x >= y);   //false
            //Console.WriteLine(x <= y);   //true





            ////논리 연산자

            //bool a = false;
            //bool b = true;

            //Console.WriteLine(a && b);
            ////AND : 1 : 1       둘다 참일 때만 TRUE

            //Console.WriteLine(a || b);
            ////OR    1 : 0       하나라도 참이면 TRUE

            //Console.WriteLine(!a);
            ////not   0 -> 1      거짓이면 참으로    참이면 거짓으로





            ////비트연산자
            //int x = 5;  // 0101
            //int y = 3;  // 0011

            //Console.WriteLine(x & y);   //AND : 1 (0001)
            //Console.WriteLine(x | y);   //OR : 7 (0111)
            //Console.WriteLine(x ^ y);   //XOR : 6 (0110)
            //Console.WriteLine(~x);      //not : -6





            //int value = 4;  //0100

            //Console.WriteLine(value << 1);  //왼쪽이동 : 8 (1000)
            //Console.WriteLine(value >> 1);  //오른쪽이동 : 2 (0010)





            ////삼항 연산자
            //int a = 10, b = 20;

            //int max;

            //max = (a > b) ? a : b;  // (문제) ? 참 : 거짓        문제를 보고 참 일경우 a값  거짓일 경우 b값

            //Console.WriteLine(max);






            //int key = 1;

            //string str;
            //str = (key == 1) ? "문이 열렸습니다." : "문을 못 열었습니다.";

            //Console.WriteLine(str);





            //int result = 10 + 2 * 5;    //곱셈이 덧셈보다 우선
            //Console.WriteLine(result);

            //int adjustedResult = (10 + 2) * 5;  //괄호 우선순위 먼저 계산
            //Console.WriteLine(adjustedResult);





            //int score = 95;

            //if(score >= 90)     //만약 90점 이상이라면
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else                //아니라면
            //{
            //    Console.WriteLine("B 학점");
            //}





            //string GameID = "멋사검존";


            //if(GameID == "멋사검존")
            //{
            //    Console.WriteLine("아이디가 일치합니다.");
            //}
            //else
            //{
            //    Console.WriteLine("아이디가 일치하지 않습니다.");

            //}





            //int score = 75;

            //if(score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else if(score >= 80)
            //{
            //    Console.WriteLine("B 학점");
            //}
            //else if(score >= 70)
            //{
            //    Console.WriteLine("C 학점");
            //}
            //else
            //{
            //    Console.WriteLine("F 학점");
            //}





            //int money = 0;
            //int AddAtt = 0;
            //string weapon = "";
            //Console.WriteLine("가지고 있는 소지금을 입력하세요 : ");

            //money = int.Parse(Console.ReadLine());

            ////소지금에 따른 무기와 공격력 결정
            //if (money >= 0 && money <= 100)
            //{
            //    weapon = "무한의대검";
            //    AddAtt = 1;
            //}
            //else if (money >= 101 && money <= 200)
            //{
            //    weapon = "카타나";
            //    AddAtt = 2;
            //}
            //else if (money >= 201 && money <= 300)
            //{
            //    weapon = "진은검";
            //    AddAtt = 3;
            //}
            //else if (money >= 301 && money <= 400)
            //{
            //    weapon = "집판검";
            //    AddAtt = 4;
            //}
            //else if (money >= 401 && money <= 500)
            //{
            //    weapon = "엑스칼리버";
            //    AddAtt = 5;
            //}
            //else if (money >= 501 && money <= 600)
            //{
            //    weapon = "유령검";
            //    AddAtt = 6;
            //}
            //else
            //{
            //    weapon = "전설의검";
            //    AddAtt = 7;
            //}



            ////2단계출력
            //Console.WriteLine("캐릭터 멋사검존");
            //Console.WriteLine("무기 : " + weapon);
            //Console.WriteLine("공격력 : 100 +" + AddAtt);




            Console.WriteLine("문제 1. 세 정수의 최대값 구하기");

            int aa = 0, ba = 0, ca = 0;

            Console.Write("첫번째 숫자를 정해주세요. : ");
            aa = int.Parse(Console.ReadLine());

            Console.Write("두번째 숫자를 정해주세요. : ");
            ba = int.Parse(Console.ReadLine());

            Console.Write("세번째 숫자를 정해주세요. : ");
            ca = int.Parse(Console.ReadLine());

            if (aa > ba && aa > ca)
            {
                Console.WriteLine("3개의 정수중 가장 큰 숫자는 첫번째 숫자 입니다. : " + aa);
            }
            else if (ba > aa && ba > ca)
            {
                Console.WriteLine("3개의 정수중 가장 큰 숫자는 두번째 숫자 입니다. : " + ba);
            }
            else if (ca > aa && ca > ba)
            {
                Console.WriteLine("3개의 정수중 가장 큰 숫자는 두번째 숫자 입니다. : " + ca);
            }




            int Myscore = 0;
            string hg = "";

            Console.Write("내 학점을 입력해 주세요 : ");
            Myscore = int.Parse(Console.ReadLine());

            if (Myscore >= 91)
            {
                hg = "내 학점은 A 학점 입니다.";
            }
            else if (Myscore >= 81 && Myscore <= 90)
            {
                hg = "내 학점은 B 학점 입니다.";
            }
            else if (Myscore >= 71 && Myscore <= 80)
            {
                hg = "내 학점은 C 학점 입니다.";
            }
            else if (Myscore >= 61 && Myscore <= 70)
            {
                hg = "내 학점은 D 학점 입니다.";
            }
            else
            {
                hg = "내 학점은 F 학점 입니다.";
            }

            Console.WriteLine(hg);



            int a = 0, b = 0, c = 0;
            string d = "";

            Console.Write("계산하실 첫번째 숫자를 입력 해주세요. : ");
            a = int.Parse(Console.ReadLine());

            Console.Write("계산하실 두번째 숫자를 입력 해주세요. : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("사용하실 연산자 기호를 입력 해주세요.");
            d = string.Join(Console.ReadLine());


            if (d == "+")
            {
                c = a + b;
            }
            else if (d == "-")
            {
                c = a - b;
            }
            else if (d == "*")
            {
                c = a * b;
            }
            else if (d == "/")
            {
                Console.Write("결과 값은 : ");
                Console.WriteLine(c);


                if (b == 0)
                {
                    Console.Write("0을 나눌수 없습니다.");
                }
                else c = a / b;
            }





            
        }
    }
}
