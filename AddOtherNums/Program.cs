using System;

// 프로그래머스 코딩테스트 연습
// 3진법 뒤집기

namespace AddOtherNums
{
    class MainClass
    {
        // numbers : array including numbers from 0 to 9
        // 1 <= numbers.Length <=9
        // All the elements of numbers are different
        static int Solution(int[] numbers)
        {
            int answer = 0;
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum += i;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                answer += numbers[i];
            }
            return sum - answer;
        }

        // Test
        static int[] arr1 = { 1, 2, 3, 4, 6, 7, 8, 0 };
        static int[] arr2 = { 5, 8, 4, 0, 6, 7, 9 };

        public static void Main(string[] args)
        {
            Console.WriteLine(Solution(arr1));
            Console.WriteLine(Solution(arr2));
        }
    }
}
