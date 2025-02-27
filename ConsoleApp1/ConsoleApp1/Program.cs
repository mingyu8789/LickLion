using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        struct Student
        {
            public string Name;
            public int iKor;
            public int iEng;
            public int iMath;

            //학생 정보를 출력하는 함수
            public void Print()
            {
                Console.WriteLine($"{Name,-3} {iKor,5} {iEng,8} {iMath,8}");    //왜 {이름, 3} 여기에 숫자를 추가하면 공백이 생기는지 모르겠음
            }
        }




        static void Main(string[] args)
        {
            //구조체를 이용해서
            //학생3명의 이름 성적을 받고 국어,영어,수학
            //출력하시오.
            //이름    국어  영어  수학
            //홍길동   100  80    0
            //홍길란   13   40    55


            //학생 배열 선언
            Student[] students = new Student[3];        //Studnt[]를 통해 []를 선언하고 students로 이름을 정함 = new Student 새로운 Student를 만들고 [3]을 통해서 위 student를 편하게 3개 만든것임     새로만든이유는 []를 선언하기위해서

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("학생성적을 입력하세요.");
                Console.Write("학생이름 : ");
                students[i].Name = Console.ReadLine();
                Console.Write("국어 : ");
                students[i].iKor = int.Parse(Console.ReadLine());
                Console.Write("영어 : ");
                students[i].iEng = int.Parse(Console.ReadLine());
                Console.Write("수학 : ");
                students[i].iMath = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("이름     국어     영어     수학");

            foreach(Student std in students)
            {
                std.Print();
            }

        }
    }
}
