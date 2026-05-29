using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_Excercises.session7
{
    internal class baitap_7b
    {
        static void Nhapmang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                int so=int.Parse(Console.ReadLine());
                a[i] = so;
            }    
        }
        static void Inmang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i]+ " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bai 1.Nhập và xuất mảng
            Console.WriteLine("Nhập số phần tử của mảng: ");
            int n=int.Parse(Console.ReadLine());
            int[] a=new int[n];
            Nhapmang(a, n);
            Inmang(a, n);
            //////Bai 2. Tính tổng và trung bình cộng
            ////Console.WriteLine($"Tổng của các phần tử trong mảng là: {Tong(a)}");
            ////Console.WriteLine($"Trung bình cộng của các phần tử trong mảng là: {TBC(a):f2}");
            //////Bai 3. Tìm số lớn nhất và nhỏ nhất
            ////Console.WriteLine($"Số lớn nhất trong mảng là: {Max(a)}");
            ////Console.WriteLine($"Số bé nhất trong mảng là: {Min(a)}");
            //////Bai 4. Đếm số chẵn lẻ
            ////Console.WriteLine($"Số chẵn trong mảng là: {Demso(a)}");
            ////Console.WriteLine($"Số lẻ trong mảng là: {a.Length-Demso(a)}");
            ////Bai 5. Tìm kiếm 1 số trong mảng
            //Console.WriteLine("Nhập số cần tìm: ");
            //int b=int.Parse(Console.ReadLine());
            //Console.WriteLine($"Vị trí tìm thấy số {b} trong mảng là: {Checkso(a, b)}");
            //Bai 6. Đảo ngược mảng 
            Daonguoc(a);
        }
        //2.
        static int Tong(int[] a)
        {
            int t = 0;
            foreach (int i in a)
                t += i;
            return t;
        }
        static double TBC(int[] a)
        {
            double d = (double)Tong(a)/a.Length;
            return d;
        }
        //3.
        static int Max(int[] a)
        {
            int max = a[0];
            foreach(int i in a)
                if (i > max)
                    max = i;
            return max;
        }
        static int Min(int[] a)
        {
            int min = a[0];
            foreach (int i in a)
                if(i < min)
                    min = i;
            return min;
        }
        //4. 
        static int Demso(int[] a)
        {
            int d = 0;
            foreach (int i in a)
                if (i%2==0)
                    d++;
            return d;
        }
        //5.
        static int Checkso(int[] a, int b)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == b)
                    return i;
            return -1;
        }
        //6.
        static void Daonguoc(int[] a)
        {
            for (int i = a.Length-1;i>=0 ;i--)
                Console.Write(a[i]+ " ");
        }
        //
    }
}
