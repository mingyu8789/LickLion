using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math클래스 사용
            //수학적 계산
            Console.WriteLine($"Pi : {Math.PI}");               //원주율
            Console.WriteLine($"Square root of 25; {Math.Sqrt(25)}");   //왜 5가 나오지
            Console.WriteLine($"Power (2^3: {Math.Pow(2, 3)}"); //^ 제곱 2를 3곱함
            Console.WriteLine($"Round(3.75): {Math.Round(3.75)}");  //소수점을 반올림함

        }
    }
}
