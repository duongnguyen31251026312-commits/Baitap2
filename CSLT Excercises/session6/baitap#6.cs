using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text;

namespace CSLT_Excercises.session6
{
    internal class baitap_6
    {
        static void In_mang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine("");
        }
        static void phatsinh_mang(int[] a, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(1, 100);
        }
        static void nhap_mang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                int nhap = int.Parse(Console.ReadLine());
                a[i] = nhap;
            }    
        }
        public static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            phatsinh_mang(a, n);
            In_mang(a, n);
            //1. to calculate the average value of array elements.
            double tb = avr(a);
            Console.WriteLine($"Trung binh cong cua cac so la: {tb}");
            //2. to test if an array contains a specific value.
            Console.Write("Nhap gia tri cu the: ");
            int t=int.Parse(Console.ReadLine());
            if (test(a, t))
                Console.WriteLine($"Mang co chua gia tri {t}");
            else
                Console.WriteLine($"Mang khong chua gia tri {t}");
            //3.to find the index of an array element.
            Console.Write("Nhap gia tri cu the: ");
            int b = int.Parse(Console.ReadLine());
            int c =indexOf(a,b);
            Console.WriteLine($"Chi so cua phan tu {b} la: {c}");
            //4. to remove a specific element from an array.
            Console.Write("Nhap so can xoa: ");
            int d = int.Parse(Console.ReadLine());
            if (remove(a,ref n,d))
            {
                Console.Write("Mang moi la: ");
                for (int i = 0; i < n; i++)
                    Console.Write(a[i] + " ");
            }  
            else
                Console.WriteLine("Khong co phan tu de xoa");
            //5. to find the maximum and minimum value of an array.
            Console.WriteLine($"So lon nhat trong mang la: {max(a)} \n" +
                $"So be nhat trong mang la: {min(a)}");
            //6.to reverse an array of integer values.
            Console.WriteLine($"Mang moi sau khi dao la: {string.Join(",", reverse(a))}");
            //7..to find duplicate values in an array of values.
            int[] z = { 1, 2, 3, 4, 5, 6, 4, 3, 2,12, 8, 15, 8, 12, 4 , 12 };
            duplicate(z);
            //8. to remove duplicate elements from an array.
            Console.Write("Nhap so can xoa: ");
            int h = int.Parse(Console.ReadLine());
            int[] j = removedup(z,h);
            Console.WriteLine($"Mang sau khi xoa la: {string.Join(", ",removedup(z,h))}");
            //9. Requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
            Console.Write("Nhap so phan tu mang: ");
            int soluong = int.Parse(Console.ReadLine());
            int[] x = new int[soluong];
            nhap_mang(x, soluong);
            In_mang(x, soluong);
            sapxep(x);
            //10. Request a sentence from the user, then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm.
            Console.WriteLine("Nhap cau bat ki: ");
            string cau = Console.ReadLine();
            Console.WriteLine("Nhap tu bat ki: ");
            string tu = Console.ReadLine();
            if (TimKiemBangCachGomTu(cau, tu))
            {
                Console.WriteLine($"Co tu {tu} trong cau");
            }    
            else
                Console.WriteLine($"Khong co tu {tu} trong cau");
        }
        //Bai1
        static double avr(int[] arr)
        {
            double Sum = 0;
            foreach (int i in arr)
                Sum += i;
            double c = Sum/arr.Length;
            return c; 
        }
        //Bai2
        static bool test(int[] arr, int a)
        {
            bool t = false;
            foreach (int i in arr)
            {
                if (i==a)
                    t = true;
            }
            return t;
        }
        //Bai3
        static int indexOf(int[] arr, int b)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == b)
                    return i;
            }
            return -1;
        }
        //Bai4
        static bool remove(int[] arr, ref int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    for (int j = i; j < n - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    n--;
                    return true;
                }
            }
            return false;
        }
        //Bai5. Tìm max
        static int max(int[] arr)
        {
            int max = arr[0];
            for (int i = 1;i < arr.Length;i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        //Bai5. Tìm min
        static int min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
        //Bai6
        static int[] reverse(int[] arr)
        {
            int n=arr.Length;
            for (int i = 0;i < n/2;i++)
            {
                int t=arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = t;
            }    
            return arr;
        }
        //Bai7.
        static void duplicate(int[] arr)
        {
            Console.WriteLine("Cac con so trung lap la: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        Console.Write(arr[j] + " ");
                        break;
                    }
                }
            } 
            Console.WriteLine();
        }
        //Bai8.
        static int[] removedup(int[] arr, int a)
        { 
            int dem = 0;
            for (int i = 0;i < arr.Length;i++)
            {
                if (arr[i] == a)
                    dem++;
            }
            if (dem == 0)
                return arr;
            else
            {
                int[] b = new int[arr.Length-dem];
                int indexB = 0; 
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr [i] != a)
                    {
                        b[indexB] = arr[i];
                        indexB++;
                    }    
                }    
                return b;
            }  
        }
        //Bai9. 
        static void sapxep(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
                for (int j = 0; j < a.Length - i - 1; j++)
                    if (a[j] > a[j + 1])
                    {
                        int t = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = t;
                    }
            for (int k = 0; k < a.Length; k++)
                Console.Write(a[k] + " ");
            Console.WriteLine();
        }
        //Bai10.
        static bool TimKiemBangCachGomTu(string cau, string tuCanTim)
        {
            string tuHienTai = "";
            for (int i = 0; i <= cau.Length; i++)
            {
                if (i < cau.Length && !LaDauCauHoacKhoangTrang(cau[i]))
                {
                    tuHienTai += ToLower(cau[i]);
                }
                else
                {
                    if (tuHienTai != "")
                    {
                        if (tuHienTai == ChuyenChuThuong(tuCanTim))
                        {
                            return true;
                        }
                        tuHienTai = "";
                    }
                }
            }

            return false;
        }
        static bool LaDauCauHoacKhoangTrang(char ch)
        {
            return ch == ' ' || ch == '.' || ch == ',' || ch == '!' || ch == '?' || ch == '\t';
        }
        static char ToLower(char ch)
        {
            if (ch >= 'A' && ch <= 'Z') return (char)(ch + 32);
            return ch;
        }
        static string ChuyenChuThuong(string s)
        {
            string ketQua = "";
            for (int i = 0; i < s.Length; i++)
            {
                ketQua += ToLower(s[i]);
            }
            return ketQua;
        }
    }
}
