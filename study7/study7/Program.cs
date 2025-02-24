using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study7
{
    class Program
    {
        static void Main(string[] args)
        {
            ////이진수를 정수로 변환
            //Console.Write("2진수를 입력하세요:");
            //string binaryInput = Console.ReadLine();    //입력받는다 문자열
            //int decimalValue = Convert.ToInt32(binaryInput, 2); //2진수 -> 10진수 변환

            ////정수를 이진수로 변환
            //string binaryOutput = Convert.ToString(decimalValue, 2);    //10진수 -> 2진수

            //Console.WriteLine($"입력한 이진수: {binaryInput}");
            //Console.WriteLine($"10진수로변환 : {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환 :{binaryOutput}");





            ////var를 사용하여 변수 선언
            //var name = "Alice"; //문자열로 추론
            //var age = 25;   //정수로 추론
            //var isStudent = true;   //놀리값으로 추론

            //Console.WriteLine($"이름 : {name}, 나이: {age}, 학생 여부: {isStudent}");





            ////dafault 키워드 사용한 기본값 설정
            //int defaultInt = default;   //기본값 : 0
            //string defaultString = default; //기본값 : null
            //bool defaultBool = default;     //기본값 : false

            //Console.WriteLine($"정수 기본값: {defaultInt}");
            //Console.WriteLine($"문자열 기본값: {defaultString}");
            //Console.WriteLine($"논리값 기본값: {defaultBool}");





            //int a = 10, b = 5;

            //int sum = 0;



            //sum = a + b;    //더하기 연산자 사용
            //Console.WriteLine($"합 : {sum}");    //출력 : 8

            //sum = a - b;    //빼기 연산자 사용
            //Console.WriteLine($"합 : {sum}");

            //sum = a * b;    //곱하기 연산자 사용
            //Console.WriteLine($"합 : {sum}");

            //sum = a / b;    //나누기 연산자 사용
            //Console.WriteLine($"합 : {sum}");

            //sum = a % b;    //나머지 구하는 연산자       3%5 = 3   5는 3으로 안 나누어져 3         10%3 = 1   3을 10으로 나누고 나온 나머지 값 1    
            //Console.WriteLine($"합 : {sum}");





            ////홀수 짝수 판별
            //int number = 7;

            //int sum = 0;

            //sum = number % 2;   // 0이나오면 짝수 1 홀수

            //Console.WriteLine("짝수 홀수 판별 : " + sum);





            //bool isEqual = false;   //거짓 0

            //int a = 5;
            //int b = 5;


            ////관계형 연산자
            //isEqual = (a == b); //a랑 b랑 같은가?


            //Console.WriteLine("같은가? " + isEqual);





            ////단항 연산자
            //int number = 5;
            //bool flag = true;

            //Console.WriteLine(+number); //양수 출력 : 5
            //Console.WriteLine(-number); //음수 출력 : -5

            //Console.WriteLine(!flag);   //논리 부정 : false         참이면 거짓 거짓이면 참





            //int num = 10;
            //int result = ~num;  //모든 비트 반전 : 1010 이면 0101 결과 반전


            //Console.WriteLine("원래 값 : " + num);
            //Console.WriteLine("~ 연산자 적용 후 : " + result);





            ////캐스팅
            //double pi = 3.14;
            //int integerPi = (int)pi;    //실수형 -> 정수형으로 변환

            //Console.WriteLine(integerPi);   //3





            //int iKor = 90;
            //int iEng = 75;
            //int iMath = 58;

            //int sum = 0;
            //float average = 0.0f;

            //sum = iKor + iEng + iMath;

            //average = (float)sum / 3;  // 평균

            //Console.WriteLine("총점 : " + sum);
            //Console.WriteLine("평균 : " + average);





            //int a = 10, b = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);






            ////문자열 연결 연산자

            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + " " + lastName);  //출력





            //int a = 10;
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




            //Console.WriteLine("문제 1.");

            //Console.Write("국어 점수를 입력하세요 : ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("영어 점수를 입력하세요 : ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("수학 점수를 입력하세요 : ");
            //int c = int.Parse(Console.ReadLine());

            //int d = 0;

            //double f = 0.00;

            //d = a + b + c;
            //Console.WriteLine("각 과목의 값을 더합니다. : " + a + "+" + b + "+" + c + "=" + d);

            //f = (double)d / 3;
            //Console.WriteLine("각 과목을 나눕니다. : " + d + " / 3");

            //Console.WriteLine("각 과목의 총점 평균 : " + f.ToString("F2"));

            //Console.WriteLine(" ");





            //int g = 10;
            //int h = ~g;
            //Console.WriteLine("문제 2.");
            //Console.WriteLine("원래 정수 값 : " + g);
            //Console.WriteLine("비트 반전 값 : " + h);




            
            //증감 연산자
            int b = 3;

            //전위 ++b , 후위 b++
            ++b;
            Console.WriteLine("b의 값은 : " + b);
            ++b;
            Console.WriteLine("b의 값은 : " + b);

            Console.WriteLine("b의 값은 : " + (++b));  //이 줄에서 +
            Console.WriteLine("b의 값은 : " + (b++));  //다음 줄에서 +
            Console.WriteLine("b의 값은 : " + b);      //ㄴ이 줄에서 + 값이 적용됨






        }
    }
}
