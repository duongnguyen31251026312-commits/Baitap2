using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Text;

namespace CSLT_Excercises.session7
{
    internal class baitap_7
    {
        //1. Tao mang
        static int[,] Taomang_com(int n, int m)
        {
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Nhap phan tu a[{i},{j}]: ");
                    int so = int.Parse(Console.ReadLine());
                    a[i, j] = so;
                }
            return a;
        }
        static int[,] Taomang_random(int n, int m)
        {
            int[,] a = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(0, 100);
                }
            return a;
        }
        //2. In mang
        static void In_mang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j] + " "}");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            //1.Create an integer matrix N x M (N,M was prompted from user) randomly
            Console.Write("Nhap so dong: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: "); int m = int.Parse(Console.ReadLine());
            int[,] a = Taomang_random(n, m);
            //2. Print the matrix.
            In_mang(a);
            //3. Print the i row/ column. (i was prompted from user)
            Console.Write("Nhap so dong can in: "); int i = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot can in: "); int j = int.Parse(Console.ReadLine());
            Console.WriteLine("Dong can in la: ");
            Indong(a, i);
            Console.WriteLine("Cot can in la: ");
            Incot(a, j);
            //4. Find the max value of the matrix.
            Console.WriteLine($"So lon nhat trong ma tran la: {Timmax(a)}");
            //5.  Find the min value of i row/ col of the matrix
            Console.Write("Nhap so dong can tim min: "); int d = int.Parse(Console.ReadLine());
            Console.WriteLine($"So nho nhat tren dong la: {Timmindong(a, d)}");
            Console.Write("Nhap so cot can tim min: "); int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"So nho nhat tren cot la: {Timmincot(a, c)}");
            //6. Transpose the matrix.
            Console.WriteLine("Ma tran chuyen vi la: ");
            int[,] b= Chuyenvi(a);
            In_mang(b);
            //7.  Print the main/secondary diagonal values of the matrix
            Duongcheochinh(a);
            Duongcheophu(a);
        }
        //3. In dong va cot
        static void Indong(int[,] a, int i)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
        static void Incot(int[,] a, int j)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write($"{a[i, j]}\n");
            }
        }
        //4. Tim max
        static int Timmax(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                        max = a[i, j];
                }
            return max;
        }
        //5. Tim min tren 1 dong hoac cot
        static int Timmindong(int[,] a, int i)
        {
            int min = a[i, 0];
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] < min)
                { min = a[i, j]; }
            }
            return min;
        }
        static int Timmincot(int[,] a, int j)
        {
            int min = a[0, j];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (a[i, j] < min)
                { min = a[i, j]; }
            }
            return min;
        }
        //6. Chuyen vi
        static int[,] Chuyenvi(int[,] a)
        {
            int d=a.GetLength(0);
            int c=a.GetLength(1);
            int[,]b= new int[c,d];
            for (int i = 0;i < d;i++)
                for (int j = 0;j < c;j++)
                    b[j,i] = a[i,j];
            return b;
        }
        //7.  Print the main diagonal values of the matrix
        static void Duongcheochinh(int[,] a)
        {
            int d = a.GetLength(0);
            int c= a.GetLength(1);
            if (d != c)
                Console.WriteLine("Khong co duong cheo chinh.");
            else
            {
                Console.WriteLine("Duong cheo chinh la: ");
                for (int i = 0; i < a.GetLength(0); i++)
                    Console.Write($"{a[i, i]}\n");
            }
        }
        //7.Print the secondary diagonal values of the matrix
        static void Duongcheophu(int[,] a)
        {
            int d = a.GetLength(0);
            int c = a.GetLength(1);
            if (d != c)
                Console.WriteLine("Khong co duong cheo phu.");
            else
            {
                Console.WriteLine("Duong cheo phu la: ");
                for (int i = 0; i<a.GetLength(0); i++)
                {
                    Console.Write($"{a[i, c-i-1]}\n");
                }
            }
        }
    }
}
