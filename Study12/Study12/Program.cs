using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study12
{
    class Program
    {
        //전역변수
        static int num2 = 20;       //이렇게 적어놓으면 num2만 적어도 나옴


        //1.매개변수도 반환값도 없는 함수

       static void PrintHello()
        {
            Console.WriteLine("안녕하세요"); //명령어를 넣지않아 내가 직접 입력해야함
        }


        //2.매개변수만 있는 함수
        static void PrinMessage(string message) //string 명령어를 넣었다.
        {
            Console.WriteLine(message);     //위 명령어를 넣을 수 있다.
        }


        //3.변환값만 있는 함수

        static int GetNumber()
        {
            return 42;          //return 은 int 랑 같다.
        }


        //4.매개변수와 반환값이 있는 함수
        static int Add(int a, int b)
        {
            return a + b;
        }


        //5.기본값을 가진 매개변수 (디폴트 매개변수)
        static void Greet(string name = "손님")       //string 명령어를 sjgdj
        {
            Console.WriteLine($"안녕하세요, {name}");    //이렇게 편하게 쓸 수 있다.
        }


        //6.함수 오버로딩(Overloading)
        //이름을 같게 하면서 함수만 다르게 쓰고싶을때 씀
        static int Multiply(int a,int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }



        //7.out 키워드 (여러 값을 변환할때)
        //returen은 한개 밖에 못쓰지만 out을 쓰면 몇개든 가능하다!

        static void Divide(int a,int b, out int quotient, out int remainder)
        {
            quotient = a / b;

            remainder = a % b;
        }



        //8.ref 키워드 (값을 참조하여 수정)
        static void Increase(ref int num) //ㅇㅇ 5받았어 이름은 이제 num이야 
        {
            num += 10;      //num에 10 더할게 (아까있던 5도 있다 그래서 15가 됨)
        }





        static void Main(string[] args)
        {
            //1.
            //PrintHello();   //출력       //여기서 메세지를 바꿀 수 없다.

            //2.
            //PrinMessage("반갑습니다");   //string 메세지를 내가 원하는대로 넣을수 있다.

            //3.
            //int num = GetNumber();        ////return  값을 출력합니다.

            //Console.WriteLine(num);     //return을 이용하여 다시 돌려보냄

            //전역변수
            //Console.WriteLine(num2);    //

            //4.
            //int result = Add(3, 5);     //위의 a, b같을 정한다
            //Console.WriteLine(result);  //result는 return 값을 불러오는대에 쓰입니다.
            //Console.WriteLine(Add(3, 5));   // * 이렇게도 가능 합니다. *

            //5.
            //Greet();            //위의 결과값을 출력한다
            //Greet("철수");      //이렇게하면 바뀌게 할 수도 있다.

            //6.
            //Console.WriteLine(Multiply(3, 4));
            //Console.WriteLine(Multiply(2.5, 3.5));

            //7.
            //int q, r;
            //Divide(10, 3, out q, out r);
            //Console.WriteLine($"몫: {q}, 나머지 : {r}");    //출력 : 몫 3, 나머지: 1

            //8.
            int value = 5;         //value 5로 할게
            Increase(ref value);    //Increase 에 5할게
            Console.WriteLine(value); // 출력할게
        }
    }
}
