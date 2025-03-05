using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace jong_ri
{
    class Program
    {


        static void Main(string[] args)
        {
            // 2. 배열 - 동일한 데이터 타입의 연속된 집합
            Console.WriteLine("=== 기본 배열 ===");
            string[] fruits = { "사과", "바나나", "오렌지" };

            // 3. 배열 선언하기 - 다양한 방법
            Console.WriteLine("\n=== 배열 선언 방법 ===");
            int[] numbers1 = new int[3]; // 크기만 지정
            int[] numbers2 = new int[] { 1, 2, 3 };// 초기화와 함께 선언
            int[] numbers3 = { 1, 2, 3 }; // 간단한 선언과 초기화

            // 4. 1차원 배열 사용
            Console.WriteLine("\n=== 1차원 배열 사용 ===");
            int[] scores = new int[3];
            scores[0] = 90;
            scores[1] = 85;
            scores[2] = 88;
            // 배열 순회하기
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"점수 {i + 1}: {scores[i]}");
            }
            // 5. 다차원 배열
            Console.WriteLine("\n=== 다차원 배열 ===");
            // 2차원 배열 선언
            int[,] matrix = new int[2, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 }
             };

            // 2차원 배열 순회
            for (int i = 0; i < 2; i++)
            {
               for (int j = 0; j < 3; j++)
               {
                    Console.Write($"{matrix[i, j]} ");
               }
                Console.WriteLine();
            }

            // 6. 가변 배열 (Jagged Array)
            Console.WriteLine("\n=== 가변 배열 ===");
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };

            // 가변 배열 순회
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }

            // 7. var 키워드로 배열 선언하기
            Console.WriteLine("\n=== var 키워드 사용 ===");
            var numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"배열 타입: {numbers.GetType()}");
        }
    }

}
