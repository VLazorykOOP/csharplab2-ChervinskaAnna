using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What task do you want?");
            Console.WriteLine("1. Task 1");
            Console.WriteLine("2. Task 2");
            Console.WriteLine("3. Task 3");
            Console.WriteLine("4. Task 4");
            Console.WriteLine("5. Exit");

            int choice;
            bool isValidChoice = false;

            do
            {
                Console.Write("Enter number of task ");
                isValidChoice = int.TryParse(Console.ReadLine(), out choice);

                if (!isValidChoice || choice < 1 || choice > 5)
                {
                    Console.WriteLine("This task not exist");
                    isValidChoice = false;
                }
            } while (!isValidChoice);
            switch (choice)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    break;
            }
        }

        static int[] InputSingle()
        {
            Console.WriteLine("Size of array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static void PrintSingle(int[] a)
        {
            for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        static void AdditionSingle(int[] a)
        { float b = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                b += a[i];
            }
            Console.WriteLine("Addition Single array: {0}", b);
            if (b >= -99 && b <= -10 || b >= 10 && b <= 99)
            {
                Console.WriteLine("It is double digit number");
            }
            else
            {
                Console.WriteLine("It isn't double digit number");
            }
        }
        static int[,] InputMulti(out int n, out int m)
        {
            Console.WriteLine("Size of array: ");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }
        static void PrintMulti(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }
        static void AdditionMulti(int[,] a)
        {
            float b = 0;
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    b += a[i, j];
                }
            Console.WriteLine("Addition Single array: {0}", b);
            if (b >= -99 && b <= -10 || b >= 10 && b <= 99)
            {
                Console.WriteLine("It is double digit number");
            }
            else
            {
                Console.WriteLine("It isn't double digit number");
            }
        }
        static void task1()
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("What kind of massive do you want?\nSingle-Dimensional Array(Enter 1)\nMulti-Dimensional Array(Enter 2)");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                int[] myArray = InputSingle();
                Console.WriteLine("Array:");
                PrintSingle(myArray);
                AdditionSingle(myArray);

            }
            else if (choice == 2)
            {
                int n, m;
                int[,] myArray = InputMulti(out n, out m);
                Console.WriteLine("Array:");
                PrintMulti(myArray);
                AdditionMulti(myArray);

            }
            else { Console.WriteLine("It doesn't exists:"); }
        }
        static void CountSingle(int[] a)
        {
            int count = 0;
            float prewA = a[0];
            for (int i = 1; i < a.Length; ++i)
            {
                if (prewA < a[i]) {
                    count++;
                }
                prewA = a[i];
            }
            Console.WriteLine("Number whose > than next element: {0}", count);

        }
        static void task2() {
            Console.WriteLine("Task 2");
            int[] myArray = InputSingle();
            Console.WriteLine("Array:");
            PrintSingle(myArray);
            CountSingle(myArray);
        }
        static void AverageMulti(int[,] a)
        {
            float sumLeftDiagonal = 0;
            int countEL = 0;
            for (int i = 0; i < a.GetLength(0); ++i) {
                for (int j = 0; j < a.GetLength(0) - i; ++j){
                    sumLeftDiagonal += a[i, j];
                    countEL++;
                }
            }
            float res = sumLeftDiagonal / countEL;
            Console.WriteLine($"sumLeftDiagonal: {sumLeftDiagonal}");
            Console.WriteLine($"countEL: {countEL}");
            Console.WriteLine("Average value: {0}", res);
        }
        static void task3()
        {
            Console.WriteLine("Task 3");
            int n, m;
            int[,] myArray = InputMulti(out n, out m);
            Console.WriteLine("Array:");
            PrintMulti(myArray);
            AverageMulti(myArray);
        }
        static void task4()
        {
            Console.WriteLine("Task 4");
        }
    }

}