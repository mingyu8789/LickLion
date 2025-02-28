using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study22
{
    class Person
    {
        public string Name;
        public int Age;


        //방법1
        //기본생성자
        //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
        //클래스와 같은 이름을 가지며, 반환형이 없다 (void를 사용하지않음)
        //객체를 만들때 필요한 초기값을 설정할대 사용을 많이한다.

        //public person()
        //{
        //    Name = "이름 없음";
        //    Age = 0;
        //    Console.WriteLine("기본 생성자가 실행됨");
        //}




        //방법2
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("매개변수있는 생성자가 실행됨");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
        }
    }






    class Program
    {
        static void Main(string[] args)
        {
            ////클래스
            ////
            //person p1 = new person();       //객체 생성     class를 불러오는 방법은 이렇게 해야된다        static void같은 걸 더 많이 가져올수 있다
            //p1.ShowInfo();      //이러면 간단한 명령으로도 실행하게하여 불러올수있다.      p1을 기반으로 ShowInfo의 명령어를 불러온다



            Person p1 = new Person("철수", 25); //객체 생성  instance 
            p1.ShowInfo();

            Person p2 = new Person("영희", 30);
            p2.ShowInfo();



        }
    }
}
