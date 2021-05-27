using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCsharp
{
    class Permutation_Combination
    {
        private int[] print;
        private int count;

        public Permutation_Combination(int r)
        {
            this.print = new int[r];
            this.count = 0;
        }
        public int getCount()
        {
            return this.count;
        }
        public void setCount(int count)
        {
            this.count = count;
        }
        public void setPrint(int r)
        {
            this.print = new int[r];
        }
        // 순열
        public void per(int[] arr, bool[] visit, int n, int r, int start)
        {
            if (start == r)
            {
                count++;
                for (int i = 0; i < r; i++)
                {
                    Console.Write(print[i] + " ");
                }
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < n; i++)
            {
                if (visit[i])
                {
                    continue;
                }
                print[start] = arr[i];
                visit[i] = true;
                per(arr, visit, n, r, start + 1);
                visit[i] = false;
            }
        }
        // 중복 순열
        public void per_repetition(int[] arr, int n, int r, int index)
        {
            if (index == r)
            {
                count++;
                for (int i = 0; i < r; i++)
                {
                    Console.Write(print[i] + " ");
                }
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < n; i++)
            {
                print[index] = arr[i];
                per_repetition(arr, n, r, index + 1);
            }
        }
        // 조합
        public void combi(int[] arr, int n, int r, int current, int start)
        {
            if (current == r)
            {
                count++;
                for (int i = 0; i < r; i++)
                {
                    Console.Write(print[i] + " ");
                }
                Console.WriteLine();
                return;
            }
            for (int i = start; i < n; i++)
            {
                print[current] = arr[i];
                combi(arr, n, r, current + 1, i + 1);
            }
        }
        // 중복 조합
        public void combi_repetition(int[] arr, int n, int r, int current, int start)
        {
            if (current == r)
            {
                count++;
                for (int i = 0; i < r; i++)
                {
                    Console.Write(print[i] + " ");
                }
                Console.WriteLine();
                return;
            }
            for (int i = start; i < n; i++)
            {
                print[current] = arr[i];
                combi_repetition(arr, n, r, current + 1, i);
            }
        }
    }
}
