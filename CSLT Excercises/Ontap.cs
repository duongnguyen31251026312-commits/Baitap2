using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_Excercises
{
    internal class Ontap
    {
        static int[] Nhapmangrandom(int[] a, int n)
        {
            Random rnd= new Random();
            for (int i = 0; i < n;i++)
            {
                a[i] = rnd.Next(1,100);
            }
            return a;
        }
        static void Xuatmang(int[] a)
        {
            foreach (int i in a)
                Console.Write(i+ " ");
        }
        static int[,] Nhapmang2chieu(int m, int n)
        {
            int[,] a= new int[m, n];
            Random rnd= new Random();
            for (int i = 0;i < m;i++)
                for (int j = 0;j < n;j++)
                {
                    a[i,j]= rnd.Next(1,100);
                }
            return a;
        }
        static void Xuatmang2chieu(int[,]a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            int n=int.Parse(Console.ReadLine());
            int[] a=new int[n];
            Nhapmangrandom(a, n);
            Xuatmang(a);
            Console.WriteLine();
            Console.WriteLine("Nhap so dong: ");
            int d=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            int c=int.Parse(Console.ReadLine());
            int[,] b = Nhapmang2chieu(d, c);
            Xuatmang2chieu(b);
        }

    }
}
