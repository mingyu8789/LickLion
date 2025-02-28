using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study23
{
    class Program  
    {

        ////1.       기본적인 프리이빗 set get 사용법
        //class Person
        //{
        //    private string name;    //내부 변수     private 을 써서 남들이 쉽게 보지 못하게 만듬

        //    //값 설정하기 (Setter)
        //    public void SetName(string newName)     // Set을 붙여서 private을 설정할수있음
        //    {
        //        name = newName;
        //    }

        //    //값 가져오기 (Getter)
        //    public string GetName()                 // Get을 붙여서 private 값을 가져올수있음
        //    {
        //        return name;
        //    }

        //}







        ////2.    프로퍼티를 이용하면 더 간편하게 가능
        ////C# 프로퍼티 property 
        //class Person
        //{
        //    private string name; //내부변수

        //    public string Name //프로퍼티
        //    {
        //        get { return name; } //Getter
        //        set { name = value; } //Setter
        //    }
        //}




        ////프로퍼티 자동 구현        더 간편히 가능하다

        //class Person
        //{
        //    private int count = 100;
        //    public string Name { get; set; }    //자동구현 프로퍼티




        //    public int Count    
        //    {
        //        get { return Count; }      //읽기 전용으로 만들기 값변경은 불가능하게 함
        //    }



        //    public float Balance { get; private set; } //외부 변경 불가

        //    public void AddBal()
        //    {
        //        Balance += 100;
        //    }
        //}








        //마린클래스
        //프로퍼티이용해서 이름과 미네랄을 만드시오.이름 마린 미네랄 50
        class Marin
        {
            public string Name { get; private set; } = "마린";

            public int Mineral { get; set; } = 100;
        }




        static void Main(string[] args)
        {
            //C#에서 get/set 방식의 함수와 프로퍼티 비교
            //C#에서는 객체의 값을 읽고(get), 설정(set)하는
            //방식으로 함수(get/set 메서드) 또는
            //**프로퍼티(Property)**를 사용할 수 있습니다.



            ////1. 기본적인 프라이빗
            //Person p = new Person();

            //p.SetName = "홍길동";

            //Console.WriteLine("이름 : " + p.GetName());






            ////2. 프로퍼티
            //Person p = new Person();

            //p.Name = "홍길동";

            //Console.WriteLine("이름 : " + p.Name+"Count : "+ p.Count + "Balance ")+p.Balance;



            Marin m = new Marin();

            Console.WriteLine("이름 : " + m.Name + " 미네랄 : " + m.Mineral);



        }
    }
}
