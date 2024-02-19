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

        static int[] Input()
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
        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        static void task1()
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("What kind of massive do you want?\nSingle-Dimensional Array(Enter 1)\nMulti-Dimensional Array(Enter 2)");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                int[] myArray = Input();
                Console.WriteLine("My array:");
                Print(myArray);
            }
            else if (choice == 2)
            {

            }
            else { Console.WriteLine("It doesn't exists:"); }
        }


            static void task2()
        {
            Console.WriteLine("Task 2");
        }

        static void task3()
        {
            Console.WriteLine("Task 3");
        }
        static void task4()
        {
            Console.WriteLine("Task 4");
        }
    }

}