using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace jong_ri
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write();    //값 다음줄 없이 출력
            Console.WriteLine();    //값 출력후 다음줄로 이동
            Console.WriteLine(+이름); //음수 출력 : -5
            Console.WriteLine(-이름); //음수 출력 : -5






            int 숫자 = 123;   //+-숫자 출력
            double 소수점 = 3.14;   //소수점 숫자 출력
            int 숫자로 = (int)소수점;    //실수형 -> 정수형으로 변환



            char 한문자 = 'A'; //한문자만 출력
            string 문자열 = "Aile"; //문자열 출력



            bool 참 = true;    //참 혹은 거짓을 출력
            bool 거짓 = false;

            var 만능 = "문자123trueFa;se";  //문자,숫자,참,거짓을 알아서 출력 (단점은 틀린거 찾기 힘듬)



            Console.Clear();     //화면상의 모든 내용을 지움

            Console.ReadLine();  //사용자로 부터 입력받음
            숫자 = int.Parse(Console.ReadLine()); //사용자가 숫자를 입력해야 할때

            Thread.Sleep(500);  //지연시간을 줌 1000 = 1초

            //a + b     더하기 연산자 사용
            //a - b     빼기 연산자 사용
            //a * b     곱하기 연산자 사용
            //a / b     나누기 연산자 사용
            //a % b     나머지 구하기 연산자 사용 3 % 5 = 3 이 나온다 5로 3을 나눌수 없기에 나머지인 3  5 % 2 = 1 이 나옴
            //응용법 ? = 10 % 2  10부분에 원하는 값을 입력하면 1 또는 0 밖에 안나오기 때문에 홀수 짝수를 구분할수있다.

            // 출력 = a + b * c  이런경우 곱하기 먼저 계산 하지만
            // 출력 = (a + b) * c  괄호를 넣을경우 더하기 먼저 계산



            //++a         //이 줄에서 +1
            //a++         //다음 줄에서 +1

            //a += 5;     //a = a + 5 랑 똑같음
            //Console.WriteLine(a);   //출력 : 15
            //a -= 5;     //a = a - 5 랑 똑같음
            //Console.WriteLine(a);   //출력 : 15
            //a *= 5;     //a = a * 5 랑 똑같음
            //Console.WriteLine(a);   //출력 : 15
            //a /= 5;     //a = a / 5 랑 똑같음
            //Console.WriteLine(a);   //출력 : 15
            //a %= 5;     //a = a % 5 랑 똑같음
            //Console.WriteLine(a);   //출력 : 15




            //두 값을 비교해서 관계를 평가한다

            //a == b    a랑 b랑 같으면 true
            //a == b    a랑 b랑 틀리면 true
            //a < b     a가 b보다 작으면 true
            //a > b     a가 b보다 크면 true
            //a <= b    a가 b보다 작거나 같다면 true
            //a >= b    a가 b보다 크거나 같다면 true



            //bool을 이용하여 비교해서 관계를 평가한다

            //a && b    둘다 참 이면 true
            //a || b    하나라도 참 이면 true
            //!a        거짓이면 참으로 참이면 거짓으로



            ////비트연산자
            //int x = 5;  // 0101
            //int y = 3;  // 0011

            //x & y     //AND : 1 (0001)
            //x | y     //OR : 7 (0111)
            //x ^ y     //XOR : 6 (0110)
            //~x        //not : -6      비트 반전

            //y << 1    //왼쪽으로이동 0110
            //y << 1    //오른쪽으로이동 0001



            //삼향 연산자

            //출력 = (a > b) ? a : b;         ()의 문제를 보고 참일경우 a값 거짓이라면 b값
            //출력 = (key == 1) ? "문이 열렸습니다." : "문을 못 열었습니다.";












            int day = 1;

            switch (day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
            }








            for (int i =1; i<= 5; i++)
            {
                Console.WriteLine($"숫자: {i}");
            }







            

            int count = 1;

            while (count <= 5)                       //count가 5보다 작거나 같다면
            {
                Console.WriteLine("Count : " + count);

                count++;                            //count 1 더할게
            }
            Console.WriteLine("Count : " + count);






            int score = 75;

            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }



            //콘솔 창 크기 설정
            Console.SetWindowSize(80, 25);  //x 80 , y 25

            //콘솔 버퍼 크기도 설정 (스크롤없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);

            //커서 숨기기
            Console.CursorVisible = false;

            //내가 원하는 x , y 값에 그림 출력 시키기
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        }
    } 
}
