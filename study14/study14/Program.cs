using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//네임스페이스
//클래스, 함수, 변수 이름이 충돌하는것을 방지하기위해 사용된다.
//

namespace dev1
{
    class MyClass
    {
        public static void SayHello()
        {
            Console.WriteLine("안녕하세요")
        }
    }
}






namespace study14   //namespace를 이용하여 다른 스페이스와 이름이 곂쳐도 상관없게 합니다 (다른팀으로 작업할때 유용)
{
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("ㅎㅎㅎㅎㅎ");
        }


        static void Main(string[] args)
        {
            SayHello();
            dev1.MyClass.SayHello();    //위의 dev1을 불러오는 방법
        }
    }
}
