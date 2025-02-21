using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study6
{
    class Program
    {
        static void Main(string[] args)
        {
            ////사용자 입력을 문자열 받기
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine();   //사용자로 부터 입력 받기

            //Console.WriteLine($"안녕하세요, {userName}님!");





            ////문자열을 정수로 변환
            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine();  //사용자로부터 입력 받기
            //int age = int.Parse(input); //문자열을 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1} 살이 되겠군요!");  //변환된 값 사용
            //Console.WriteLine("내년에는 " + age + "살이 되겠군요!");
            //Console.WriteLine("내년에는 {0} 살이 되겠군요!", age);





            //해당 스샷내용 입력받아서 출력

            Console.Write("루인 스킬 피해 값을 입력하세요: ");
            string p1 = Console.ReadLine();
            double t1 = double.Parse(p1);
            Console.Write("카드 게이지 획득량 값을 입력하세요: ");
            string p2 = Console.ReadLine();
            double t2 = double.Parse(p2);
            Console.Write("각성기 피해 값을 입력하세요: ");
            string p3 = Console.ReadLine();
            double t3 = double.Parse(p3);
            Console.Write("최대 마나 값을 입력하세요: ");
            string p4 = Console.ReadLine();
            double t4 = double.Parse(p4);
            Console.Write("전투 중 마나 회복량 값을 입력하세요: ");
            string p5 = Console.ReadLine();
            double t5 = double.Parse(p5);
            Console.Write("비전투 중 마나 회복량 값을 입력하세요: ");
            string p6 = Console.ReadLine();
            double t6 = double.Parse(p6);
            Console.Write("이동 속도 값을 입력하세요: ");
            string p7 = Console.ReadLine();
            double t7 = double.Parse(p7);
            Console.Write("탈 것 속도 값을 입력하세요: ");
            string p8 = Console.ReadLine();
            double t8 = double.Parse(p8);
            Console.Write("운반 속도 값을 입력하세요: ");
            string p9 = Console.ReadLine();
            double t9 = double.Parse(p9);
            Console.Write("스킬 재사용 대기시간 감소 값을 입력하세요: ");
            string p10 = Console.ReadLine();
            double t10 = double.Parse(p10);

            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine($"ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine($"활동                          ▽");
            Console.WriteLine($"ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine($"루인 스킬 피해            {p1}%");
            Console.WriteLine($"카드 게이지 획득량        {p2}%");
            Console.WriteLine($"각성기 피해               {p3}%");
            Console.WriteLine($"최대 마나                 {p4}");
            Console.WriteLine($"전투 중 마나 회복량       {p5}");
            Console.WriteLine($"비전투 중 마나 회복량     {p6}");
            Console.WriteLine($"이동 속도                 {p7}%");
            Console.WriteLine($"탈 것 속도                {p8}%");
            Console.WriteLine($"운반 속도                 {p9}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 {p10}%");

        }
    }
}
