using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace jong_ri
{
    class Program
    {
        static void Console_jr()
        {
            string[] Console_jr = new string[9];
            Console_jr[0] = "Console.Write();                 값 다음줄 없이 출력";
            Console_jr[1] = "Console.WriteLine();             값 출력후 다음줄로 이동";
            Console_jr[2] = "Console.WriteLine(+숫자);        음수 출력 : -5";
            Console_jr[3] = "Console.WriteLine(-숫자);        음수 출력 : -5";
            Console_jr[4] = "Console.Clear();                 화면상의 모든 내용을 지움";
            Console_jr[5] = "Console.ReadLine();              사용자로 부터 입력받음";  //숫자 = int.Parse(Console.ReadLine()); //사용자가 숫자를 입력해야 할때
            Console_jr[6] = "Console.SetWindowSize(80, 25);   x 80 , y 25"; //콘솔 창 크기 설정
            Console_jr[7] = "Console.SetBufferSize(80, 25);";   //콘솔 버퍼 크기도 설정 (스크롤없이 고정된 창 유지)
            Console_jr[8] = "Console.CursorVisible = false;;";   //커서 숨기기

            ////내가 원하는 x , y 값에 그림 출력 시키기
            //Console.SetCursorPosition(0, 0);
            //Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine();
                Console.WriteLine(i+1 + ". " + Console_jr[i]);
            }
        }





        static void Number_jr()
        {
            string[] Number_jr = new string[6];
            Number_jr[0] = "int 숫자 = 123;                   +- 숫자를 출력";
            Number_jr[1] = "float 적은소수점 = 3.14           적은 소수점을 출력";
            Number_jr[2] = "double 많은소수점 = 3.14567;      소수점 숫자 출력";
            Number_jr[3] = "ToString(''F2'');                소수점 최대 F?자리까지 출력";
            Number_jr[4] = "int 정수로 = (int)소수점;         실수형 -> 정수형 변환";
            Number_jr[5] = "var 만능 = ''문자123trueFa;se'';  //문자,숫자,참,거짓을 알아서 출력 (단점은 틀린거 찾기 힘듬)";

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine();
                Console.WriteLine(i + 1 + ". " + Number_jr[i]);
            }
        }






        static void Pluse_jr()
        {
            string[] Pluse_jr = new string[13];
            Pluse_jr[0] = "a + b     더하기 연산자 사용";
            Pluse_jr[1] = "a - b     빼기 연산자 사용";
            Pluse_jr[2] = "a * b     곱하기 연산자 사용";
            Pluse_jr[3] = "a / b     나누기 연산자 사용";
            Pluse_jr[4] = "a % b     나머지 구하기 연산자 사용";  // 3 % 5 = 3 이 나온다 5로 3을 나눌수 없기에 나머지인 3  5 % 2 = 1 이 나옴  //응용법 ? = 10 % 2  10부분에 원하는 값을 입력하면 1 또는 0 밖에 안나오기 때문에 홀수 짝수를 구분할수있다.
            Pluse_jr[5] = "출력 = a + b * c  이런경우 곱하기 먼저 계산 하지만 출력 = (a + b) * c  괄호를 넣을경우 더하기 먼저 계산";
            Pluse_jr[6] = "++a         이 줄에서 +1";
            Pluse_jr[7] = "a++         //다음 줄에서 +1";
            Pluse_jr[8] = "a += 5;     //a = a + 5 랑 똑같음";
            Pluse_jr[9] = "a -= 5;     //a = a - 5 랑 똑같음";
            Pluse_jr[10] = "a *= 5;     //a = a * 5 랑 똑같음";
            Pluse_jr[11] = "a /= 5;     //a = a / 5 랑 똑같음";
            Pluse_jr[12] = "a %= 5;     //a = a % 5 랑 똑같음";

            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine();
                Console.WriteLine(i + 1 + ". " + Pluse_jr[i]);
            }
        }




        static void Text_jr()
        {
            string[] Text_jr = new string[3];
            Text_jr[0] = "char 한문자 = 'A';               한문자만 출력";
            Text_jr[1] = "string 문자열 = ''Aile'';        문자열 출력";
            Text_jr[2] = "var 만능 = ''문자123trueFa;se'';  //문자,숫자,참,거짓을 알아서 출력 (단점은 틀린거 찾기 힘듬)";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                Console.WriteLine(i + 1 + ". " + Text_jr[i]);
            }
        }





        static void TrueFalse_jr()
        {
            string[] TrueFalse_jr = new string[11];
            TrueFalse_jr[0] = "bool 참 = true;                  참이면 0 출력";
            TrueFalse_jr[1] = "bool 거짓 = false;               거짓이면 1 출력";
            TrueFalse_jr[2] = "var 만능 = ''문자123trueFa;se'';  문자,숫자,참,거짓을 알아서 출력 (단점은 틀린거 찾기 힘듬)";
            TrueFalse_jr[3] = "a == b                           a랑 b랑 같으면 true";
            TrueFalse_jr[4] = "a < b                            a가 b보다 작으면 true";
            TrueFalse_jr[5] = "a > b                            a가 b보다 크면 true";
            TrueFalse_jr[6] = "a <= b                           a가 b보다 작거나 같다면 true";
            TrueFalse_jr[7] = "a >= b                           a가 b보다 크거나 같다면 true";
            TrueFalse_jr[8] = "a && b                           둘다 참 이면 true";
            TrueFalse_jr[9] = "a || b                           하나라도 참 이면 true";
            TrueFalse_jr[10] = "!a                               거짓이면 참으로 참이면 거짓으로";

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine();
                Console.WriteLine(i + 1 + ". " + TrueFalse_jr[i]);
            }
        }



        static void or_jr()
        {
            string[] or_jr = new string[1];
            or_jr[0] = "Thread.Sleep(1000);               지연시간을 줌 1000 = 1초";

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine();
                Console.WriteLine(i + 1 + ". " + or_jr[i]);
            }
        }






        static void switch_jr()
        {
            string[] switch_jr = new string[9];
            switch_jr[0] = "int day = 1";
            switch_jr[1] = "{";
            switch_jr[2] = "    case 1:";
            switch_jr[3] = "        Console.WriteLine(\"월요일\");";
            switch_jr[4] = "        break;";
            switch_jr[5] = "    case 2:";
            switch_jr[6] = "        Console.WriteLine(\"화요일\");";
            switch_jr[7] = "        break;";
            switch_jr[8] = "{";

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine();
                Console.WriteLine(switch_jr[i]);
            }
        }






        static void rupe_jr()
        {
            string[] rupe_jr = new string[2];
            rupe_jr[0] = "for               지정한 값만큼 반복";
            rupe_jr[1] = "while             무제한 반복";


            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                Console.WriteLine(rupe_jr[i]);
            }
        }






        static void if_jr()
        {
            string[] if_jr = new string[18];
            if_jr[0] = "int score = 75;";
            if_jr[1] = "";
            if_jr[2] = "if (score >= 90)";
            if_jr[3] = "{";
            if_jr[4] = "    Console.WriteLine(\"A 학점";
            if_jr[5] = "}";
            if_jr[6] = "else if (score >= 80)";
            if_jr[7] = "{";
            if_jr[8] = "    Console.WriteLine(\"B 학점\");";
            if_jr[9] = "}";
            if_jr[10] = "else if (score >= 70)";
            if_jr[11] = "{";
            if_jr[12] = "    Console.WriteLine(\"C 학점\");";
            if_jr[13] = "}";
            if_jr[14] = "else";
            if_jr[15] = "{";
            if_jr[16] = "    Console.WriteLine(\"F 학점\");";
            if_jr[17] = "}";

            for (int i = 0; i < 18; i++)
            {
                Console.WriteLine();
                Console.WriteLine(if_jr[i]);
            }

        }







        static void Main(string[] args)
        {
            Console.WriteLine("1. Console에 대한 명령어를 봅니다.         숫자,문자를 화면상에 출력하는것 들이 있습니다.");

            Console_jr();   //콘솔
            Number_jr();    //숫자
            Text_jr();      //문자
            TrueFalse_jr(); //참 거짓
            Pluse_jr();     //+-* 기호
            switch_jr();    //박스
            rupe_jr();      //반복
            if_jr();        //조건

            or_jr();        //기타







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












            //for (int i =1; i<= 5; i++)
            //{
            //    Console.WriteLine($"숫자: {i}");
            //}









            //int count = 1;

            //while (count <= 5)                       //count가 5보다 작거나 같다면
            //{
            //    Console.WriteLine("Count : " + count);

            //    count++;                            //count 1 더할게
            //}
            //Console.WriteLine("Count : " + count);






            //int score = 75;

            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B 학점");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C 학점");
            //}
            //else
            //{
            //    Console.WriteLine("F 학점");
            //}



            //배열


        }
    } 
}
