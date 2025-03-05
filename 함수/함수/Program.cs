using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 함수
{
    class Program
    {

        static void Main(string[] args)
        {
            void Greet()
            {
                Console.WriteLine("Welcome to C# programming!");
            }
            Greet(); // 함수 호출




            void PrintName(string name = "Guest")
            {
                Console.WriteLine($"Hello, {name}!");
            }
            PrintName(); // "Hello, Guest!"
            PrintName("Alice"); // "Hello, Alice!"



            void DisplayInfo(string name, int age)
            {
                Console.WriteLine($"Name: {name}, Age: {age}");
            }
            DisplayInfo(age: 25, name: "John");




        }
    }
}
