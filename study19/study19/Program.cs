using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study19
{

    struct Rectangle
    {
        public int Width;
        public int Height;

        public int GetArea() => Width * Height;
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
