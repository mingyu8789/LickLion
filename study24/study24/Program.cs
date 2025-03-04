using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace study24
{

    //클래스시그니처 기본구성
    //C#에서 클래스 시그니처는 클래스의 선언부를 의미한다.

    //[접근 지정자] [수정자] class 클래스이름    :   부모클래스 , 인터페이스
    //public       abstract                    :   BaseClass , IComparable
    //private       sealed
    //protected     static
    //              partial



    ////기본클래스
    //public class player
    //{

    //    public string Name { get; set; }

    //    public int Score { get; set; }
    //}
    ////상속하는 클래스
    //public class warrior : player
    //{
    //    public int Strength { get; set; }
    //}
    //인터페이스를 구현하는 클래스

    //public class Enmy: IAttackable, IMovable
    //{
    //    public void Attack() { }
    //    public void Move() { }
    //}

    ////추상 클래스 (abstract
    //public abstract class Animal
    //{
    //    public abstract void MakeSound();
    //}






    class Program
    {
        static void Main(string[] args)
        {

            ////내 컴퓨터 설치경로 보는거
            //string path = Environment.GetEnvironmentVariable("PATH;");
            //Console.WriteLine($"PATH: {path}");


            ////프로그램을 바로 종료합니다
            //Console.WriteLine("프로그램 종료");

            //Environment.Exit(0);





            //Random random = new Random();

            //int randomNumber = random.Next(1, 101);     //1부터 100까지
            //Console.WriteLine("랜덤 숫자 :" + randomNumber);




            ////프로그램 실행 시간 구하기

            //Stopwatch stopwatch = Stopwatch.StartNew();

            ////실행콛
            //for(int i = 0; i < 100; i++)
            //{
            //    Thread.Sleep(1);
            //}


            //stopwatch.Stop();

            //Console.WriteLine($"for 시간{stopwatch.ElapsedMilliseconds}ms");






            //string input = "Hello, my phon number is 010-1234-5678.";
            //string pattern = @"\d{3}-\d{4}-\d{4}";    //전화번호 패턴

            //bool isMatch = Regex.IsMatch(input, pattern);
            //Console.WriteLine($"전화번호가 존재하는가? {isMatch}");






            //int valueType = 10;
            //object referenceType = valueType;

            //valueType = 20;

            //Console.WriteLine($"ValueType : {valueType}"); //20
            //Console.WriteLine($"ReferenceType: {referenceType}");





            ////박싱 넘방식
            ////값 형식을 참조형식으로 변환(박싱) , 다시 값 형식으로 변환(언박싱)

            //int value = 42;
            //object boxed = value;   //박싱
            //int unboxed = (int)boxed;   //언방식

            //Console.WriteLine($"Boxed: {boxed}, Unboxed : {unboxed}");





            ////is 연산자 형식 비교하기
            ////객체가 특정 형식인지 확인할 수 있다.

            //object obj = "Hello";

            //Console.WriteLine(obj is string);   //true
            //Console.WriteLine(obj is int);  //false




            ////as 연산자로 형식 변환하기
            ////as 연산자를 사용해 안전하게 형 변환을 수행한다.

            //object obj = "Hello";
            //string str = obj as string;

            //Console.WriteLine(str);



            //var obj = 42;

            //if(obj is int number)
            //{
            //    Console.WriteLine($"Number : {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Not a number");
            //}





            //string greeting = "Hello";
            //string name = "Alice";

            //string message = greeting + "," + name + "!";
            //Console.WriteLine(message); //Hello,Alice

            //Console.WriteLine($"Length of name: {name.Length}"); //문자열 길이
            //Console.WriteLine($"To Upper: {name.ToUpper()}"); //대문자 변환
            //Console.WriteLine($"Substring: {name.Substring(1)}"); //부분 문자열








            ////string 다양한 메서드
            //string text = "C# is awesome!";
            //Console.WriteLine($"Cotains 'awesome' : {text.Contains("awesome")}");
            //Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
            //Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
            //Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome", "great")} ");







            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(",");
            //sb.Append("World!");
            //Console.WriteLine(sb.ToString());







            ////String과 StringBuilder클래스 성능차이 비교
            ////반복적으로 문자열을 수정할때 StringBuilder가 효율적이다.

            //int iterations = 10000;

            //Stopwatch sw = Stopwatch.StartNew();

            //string text = "";

            //for (int i = 0; i < iterations; i++)
            //{
            //    text += "a";
            //}

            //sw.Stop();
            //Console.WriteLine($"String  : {sw.ElapsedMilliseconds}ms");

            //sw.Restart();
            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < iterations; i++)
            //{
            //    sb.Append("a");
            //}

            //sw.Stop();
            //Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}ms");






            //예외처리하기

            //예외는 프로그램실행 중 발생하는 오류입니다. 예외를 처리하면 프로그램이 중단되지않고
            //실행을 계속할수있습니다.
            //try catch 

            while (true)
            {

                try
                {
                    int[] numbers = { 1, 2, 3 };
                    Console.WriteLine(numbers[5]); //오류 발생
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Error : {ex.Message}");
                }
            }






            ////finally 예외없이 항상 실행됩니다.

            //while (true)
            //{
            //    try
            //    {
            //        int number = int.Parse("NotANumber"); //오류발생
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine($"Format Error: {ex.Message}");
            //    }
            //    finally
            //    {
            //        Console.WriteLine("항상실행됩니다.");
            //    }
            //}







            ////Exceptoin 클래스
            ////모든예외의 기본 클래스입니다.

            //try
            //{
            //    int number = int.Parse("abc");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"General Error : {ex.Message}");
            //}




            ////throw 구문으로 직접 예외 발생시키기

            //try
            //{
            //    int age = -5;
            //    if(age < 0)
            //    {
            //        throw new ArgumentException("Age cannot be negative");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Exception : {ex.Message}");
            //}






            ////배열과 비슷하지만 동적으로 크기가 변하는 가변 길이 컬렉션
            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            //names.Add("Dave");
            //names.Remove("Bob");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}







            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(list[1]);
            //list.Insert(1, 100);
            //Console.WriteLine(list[1]);

            //Console.WriteLine(list[0]);

            //list.Insert(1, 100);
            //Console.WriteLine(list.Count);

            //list[2] = 200;

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}







            ////Stack 나중에 넣은거 부터 꺼냄

            //Stack stack = new Stack();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}





            ////Queue 먼저 넣은거 부터 꺼냄

            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}



            //Queue queue = new Queue();

            //queue.Enqueue("q");
            //queue.Enqueue("w");
            //queue.Enqueue("e");
            //queue.Enqueue("r");
            //queue.Enqueue("점멸");
            //queue.Enqueue("평타");


            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}



            //Queue queue = new Queue();

            //queue.Enqueue("→");
            //queue.Enqueue("↓");
            //queue.Enqueue("↘");
            //queue.Enqueue("→");
            //queue.Enqueue("풍신권");



            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}


            //Console.WriteLine(queue.Count);









            ////ArrayList 생성
            ////크기가 동적으로 조정되는 배열, 다양한 형식의 데이터를 저장할수있다.
            //ArrayList arrayList = new ArrayList();

            ////요소추가
            //arrayList.Add(1);  //정수
            //arrayList.Add("Hello");  //문자열
            //arrayList.Add(3.14);    //실수


            ////요소 접근
            //Console.WriteLine("ArrayList 요소: ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            ////요소 제거
            //arrayList.Remove(1);

            //Console.WriteLine("\n ArrayList요소 제거 후: ");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}






            ////Hashtable 클래스
            ////키-값 쌍을 저장하는 컬렉션이다. 
            ////키를 이용해 값을 빠르게 검색


            //Hashtable hashtable = new Hashtable();

            ////키-값 쌍 추가
            //hashtable["Alice"] = 25;
            //hashtable["Bob"] = 30;
            //hashtable["포션"] = 20;

            //Console.WriteLine("Hashtable 요소:");

            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            //}


            ////특정 키의 값 가져오기
            //Console.WriteLine($"\n Alice의 나이 : {hashtable["Alice"]}");

            ////요소제거
            //hashtable.Remove("Bob");

            //Console.WriteLine("Hashtable 요소:");

            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            //}










        }   
    }
}
