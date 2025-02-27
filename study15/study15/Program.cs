using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study15
{
    class Program
    {
        //1. 일반적인 함수

        static int Add(int a, int b)
        {
            return a + b;
        }

        //1-1. 화살표 함수        일반적인 함수를 화살표 하나라로 표현 할 수 있다
        //중괄호 {}  reture 생략가능
        static int AddArrow(int a, int b) => a + b;






        //1-2. 일반적인 함수         
        static void PrintMessage()
        {
            Console.WriteLine("안녕하세요");
        }


        //1-3. 화살표 함수       화살표 함수를 문자로도 표현할 수 있다
        static void PrintMessageArrow() => Console.WriteLine("안녕하세요!");






        static void Main(string[] args)
        {
            //1 ~ 1-1. C#화살표 함수
            //C#에서 화살표 함수 => 람다 표현식 이라고도 하며
            //간결한 방식으로 함수를 장의할 수 있습니다.
            Console.WriteLine(Add(3, 5));
            Console.WriteLine(AddArrow(3, 5));


            //1-2 ~ 1.3 화살표함수 문자 버전
            PrintMessage();
            PrintMessageArrow();
        }
    }
}
