using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study21
{
    class Program
    {
        static void Main(string[] args)
        {
            //현재 시간을 나타 냅니다
            DateTime now = DateTime.Now;
            Console.WriteLine($"Current Date and Time: {now}"); //현재 날짜시간

            //시간을 표시하는 방법
            TimeSpan duration = new TimeSpan(1, 30, 0); //1시간 30분
            Console.WriteLine($"Duration : {duration}");
        }
    }
}
