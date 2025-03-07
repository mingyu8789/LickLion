using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study38
{




    class Program
    {
        //ref 포인터개념 참조
        //메서드 ref, out
        static void Increase(ref int x)
        {
            x++;
        }



        //out은 반환이 여러개일때 유용하다
        static void OutFunc(int a, int b, out int x ,out int y)
        {
            x = a;
            y = b;
        }





        static void Main(string[] args)
        {
            //int a = 10;
            //Increase(ref a);        ////ref를 적으면 위 ref int x의 내용을 실행한다 원래 10일꺼 x++해서 1더해줌
            //Console.WriteLine("A의 값 : " + a);



            int a = 10;
            int b = 20;

            int x, y;
            OutFunc(a, b, out x, out y);

            Console.WriteLine("x : " + x + " y : " + y);


        }
    }
}
