using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jong_ri
{
    class Program
    {
        static void Main(string[] args)
        {




            //스위치를 이용하여 1이면 1 2면 2에 해당하는 문자에 들어가게한다.

            //switch = 해당하는 case에게 불을 켜달라고 합니다
            //case = 스위치가 해당 방을 말할경우 불을 켜줍니다
            //break = 해당 case의 브레이크 역할을 합니다 (안하면 다음 케이스도 켜줌)

            int day = 1;

            switch (day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;                              //break는 해당문을 멈추게 합니다 안쓰면 case2까지 가겠죠?
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                case 5:
                    Console.WriteLine("금요일");
                    break;
                default:                                //default를 사용하면 지정되지 않은 숫자가 입력되었을때 출력해줍니다. 
                    Console.WriteLine("주말입니다");
                    break;







                //반복문

                //for = 해당하는 조건이 맞을경우 계속 반복한다.

                for (int i = 1; i <= 5; i++)            //int i는 1이다   i가 5보다 작을경우    i를 1더한다
                {
                    Console.WriteLine($"숫자: {i}");    //현재 숫자 i값
                }
            }
        }
    }
}
