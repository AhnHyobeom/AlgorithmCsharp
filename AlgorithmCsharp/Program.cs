using System;

namespace AlgorithmCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int n = arr.Length;
            bool[] visit = new bool[n];
            int r = 3;

            Permutation_Combination pc = new Permutation_Combination(r);
            // 순열
            pc.per(arr, visit, n, r, 0); // Permutation
            Console.WriteLine("순열의 경우의 수 : " + pc.getCount());
            // 중복 순열
            pc.setCount(0);
            pc.per_repetition(arr, n, r, 0);
            Console.WriteLine("중복 순열의 경우의 수 : " + pc.getCount());
            // 조합
            pc.setCount(0);
            pc.combi(arr, n, r, 0, 0);
            Console.WriteLine("조합의 경우의 수 : " + pc.getCount());
            // 중복 조합
            pc.setCount(0);
            pc.combi_repetition(arr, n, r, 0, 0);
            Console.WriteLine("중복 조합의 경우의 수 : " + pc.getCount());
        }
    }
}
