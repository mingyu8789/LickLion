using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__정리
{


}












//C# 구조체
//클래스와 배슷하지만 , 값 타임(Value Type)이며 가볍고 빠름
//주로 간단한 데이터 묶음을 만들때 사용
//구조체는 클래스와 다르게 new 없이 사용가능


// public       어디서든 사용가능하게 권한
// private      나만 사용가능하게 한 권한
// =>           a = a + a 이런거 생략해주는거

namespace 구조체_struct활용하기
{
    class Program
    {


        struct Point
        {
            public int X;   //x 숫자야
            public int Y;   //y 숫자야


            public Point(int x, int y)  //struct Point는 x, y 좌표 값을 저장하는 구조체
            {
                X = x;      //예네 x로 지정
                Y = y;      //예네 y로 지정
            }




            public void print()
            {
                Console.WriteLine($"좌표 : {X} , {Y}");   //애들 이렇게 출력할게
            }
        }



        static void Main(string[] args)
        {
            Point p; //구조체 struct 이름 이제 p다

            p.X = 10;   //p에 있는 x 10으로 할게
            p.Y = 20;   //p에 있는 y 20으로 할게

            p.print();  //츌력한다는거 출력할게    10,20 나오지?



            //생성자       이렇게하면 new 써야 됬었지
            Point p1 = new Point(5, 15);    

            p1.print();


        }
    }
}

namespace 구조체_struct활용하기1  //struct을 namespace밑에 사용하여 main에서 간편하게 빼 올수 있게 하는것입니다.
{

    struct Rectangle    //이 스턱의 이름은 Rectangle
    {
        public int Width;   //int 이름은 width   숫자를 적지 않음
        public int Height;

        public int GetArea() => Width * Height;     //width * Heigth 곱할게 이름은 GetArea 지정
    }




    class Program
    {
        static void Main(string[] args)
        {
            //var rect = new Rectangle { Width = 5, Height = 4 };


            Rectangle rect; //위의 struct 이름을 rect로 할게
            rect.Width = 10;    //rect에 Width를 10으로 바꿀게
            rect.Height = 20;   //rect에 Height를 20으로 바꿀게
            Console.WriteLine($"Area : {rect.GetArea()}");  //rect에 GetArea 출력할게

        }
    }

}

namespace 구조체_struct_활용하기2 // [] 박스 활용하는 방법
{
    struct 스턱ㅁ //struct을 이용하여 []를 사용하는 방법입니다.
    {
        public int x;   //public은 공개하겠다 입니다.    기본적으로 되어있지만 사용하면 좋습니다.
        public int y;
    }

    class struct을_이용해서 //[]박스 만들기
    {
        static void Main(string[] args)
        {
            //이름[]  [0] 안에 숫자를 적으면 큰 박스를 만들어 낸다.
            스턱ㅁ[] points = new 스턱ㅁ[2];    //points라는 이름에 스턱ㅁ에 큰 박스2개를 만들게

            //스턱의 x,y값이 2개 있고 큰박스를 2개 만들었으니 2개가 한 박스 더 생긴상황이다
            points[0].x = 10;   //첫번째 박스이기에 이름은 [0]
            points[0].y = 10;

            points[1].x = 20;   //2번째 박스이기에 이름은 [1]
            points[1].y = 30;


            //foreach 2번 반복하겠다
            //var   int cher string double 등을 자동으로 생각해서 쓰는 만능
            //in    내부 명령어로 값을 바꿀수 없다 본래 명령어쪽에 찾아가 바꿔야만 바꾸어진다.
            foreach (var point in points)   //2번 반복할게 points 이름을 point라는 이름으로 여기선 실행가능하게 변경할거야
            {
                Console.WriteLine($"Point: ({point.x},{point.y})"); //point를 화면에 출력할게
            }
        }
    }
}
