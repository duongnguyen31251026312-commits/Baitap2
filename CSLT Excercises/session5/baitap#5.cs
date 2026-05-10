using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_Excercises.session5
{
    internal class baitap_5
    {
        static int Max(int a, params int[] pars)
        {
            int max = a;
            foreach (int i in pars)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
        static long Factorial(int a)
        {
            long b = 1;
            for (int i = 1; i <= a; i++)
            {
                b = b * i;
            }
            return b;
        }
        static bool Nto(int a)
        {
            bool nto = true;
            for (int i = 2; i <=a / 2; i++)
            {
                if (a % i == 0)
                { nto = false; }
            }
            return nto;
        }
        static void Demnto(int a)
        {
            int dem = 0;
            int so = 2;
            Console.WriteLine($"\nThe first {a} prime number is: ");
            while (dem <a)
            { 
              if (Nto(so))
                {
                    dem++;
                    Console.Write($"{so} ");
                }
              so++;
            }
        }
        static bool Hhao(int a)
        {
            bool hhao = false;
            int b = 1;
            for (int i = 2; i < a; i++)
            {
                if ((a % i) == 0)
                {
                    b = b + i;
                }
            }
            if (b == a)
            {
                hhao = true;
            }
            return hhao;
        }
        static bool IsPangram(string text)
        {
            HashSet<char> letters = new HashSet<char>();

            foreach (char c in text.ToLower())
            {
                if (c >= 'a' && c <= 'z')
                {
                    letters.Add(c);
                }
            }

            return letters.Count == 26;
        }

        public static void Main(string[] args)
        {
            //Bai1.Write a C# function to find the maximum of three numbers
            Console.Write("Nhap 1 so: ");
            int da = int.Parse(Console.ReadLine());
            Console.Write("Nhap 1 so: ");
            int gi = int.Parse(Console.ReadLine());
            Console.Write("Nhap 1 so: ");
            int cu = int.Parse(Console.ReadLine());
            int m = Max(da, gi, cu);
            Console.WriteLine($"So lon nhat trong ba so {da}; {gi}; {cu} la {m}");
            //Bai2. Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
            Console.Write("Nhap 1 so: ");
            int a = int.Parse(Console.ReadLine());
            long f = Factorial(a);
            Console.WriteLine($"Giai thua cua a la: {f}");
            //Bai3. Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
            Console.Write("Nhap 1 so: ");
            int b = int.Parse(Console.ReadLine());
            if (Nto(b))
            {
                Console.WriteLine($"{b} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{b} khong la so nguyen to");
            }
            //Bai4. Write a C# function to print 1.all prime numbers that less than a number(enter prompt keyboard). 2.the first N prime numbers
            Console.Write("Nhap 1 so cho truoc: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Cac so nguyen to truoc so cho truoc la: ");
            for (int i = 2; i <= c; i++)
            {
                if (Nto(i))
                { Console.Write($"{i} "); }
            }
            Demnto(c);
            //Bai5. Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
            Console.Write("Nhap 1 so cho truoc: ");
            int d = int.Parse(Console.ReadLine());
            if (Hhao(d))
            { Console.WriteLine($"{d} la so hoan hao"); }
            else { Console.WriteLine($"{d} khong la so hoan hao"); }
            Console.WriteLine("Cac so hoan hao nho hon 1000 la: ");
            for (int i = 2; i < 1000; i++)
            {
                if (Hhao(i))
                {
                    Console.Write($"{i} \n");
                }
            }
            //Bai6. Write a C# function to check whether a string is a pangram or not
            Console.Write("Nhap chuoi: ");
            string sentence = Console.ReadLine();
            if (IsPangram(sentence))
            {
                Console.WriteLine("The string is a pangram.");
            }
            else
            {
                Console.WriteLine("The string is not a pangram.");
            }
        }
    }
}

