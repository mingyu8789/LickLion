using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace study22_1
{
    //마린 클래스를 만드세요.
    //이름,미네랄  = 50
    //기본생성자 , 인자있는생성자 
    //SCV 클래스를 만드세요.
    //이름,미네랄  = 50
    //기본생성자 , 인자있는생성자 
    class Marin
    {
        public string Name;
        public int Mineral;

        public Marin()
        {
            Name = "마린";
            Mineral = 50;
        }

        public Marin(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }



    class SCV
    {
        public string Name;
        public int Mineral;

        public SCV()
        {
            Name = "SCV";
            Mineral = 50;
        }

        public SCV(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }





    //배럭클래스를 만드세요
    //Barrack  150
    //this 키워드를 이용해보자
    //this 자기자신을 가르킨다.  이 { 안에 있는 이름을 가리킨다

    class Barrack
    {
        public string Name;
        public int Mineral;

        public Barrack()
        {
            Name = "배럭";
            Mineral = 150;
        }

        public Barrack(string Name, int Mineral)
        {
            this.Name = Name;
            this.Mineral = Mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }

    }






    class Mineral
    {
        public int Minerals;

        public Mineral()
        {
            Minerals = 1500;
        }

        public void ShoWInfo()
        {
            Console.WriteLine($"남은 미네랄 : {Minerals}");
        }
    }

    //void 방만들기
    //static    메인에 바로 사용가능


    //Game클래스를 만들어보자
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;


        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 {mineral} 가스 {gas} 인구수 {charCount}");
        }

    }




    class Program
    {
        static void Main(string[] args)
        {

            Game.mineral = 50;
            Game.gas = 0;
            Game.charCount = 10;
            Game.ShowInfo();




            Marin marin = new Marin("불꽃테란", 100);
            SCV scv = new SCV("열받은SCV", 70);
            Barrack barrack = new Barrack();
            //클래스의 배열
            Mineral[] mineral = new Mineral[7];

            for(int i = 0; i < mineral.Length; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShoWInfo();
            }



            marin.ShowInfo();
            scv.ShowInfo();
            barrack.ShowInfo();

        }








    }
}
