using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_Excercises.session_4
{
    internal class baitap_4
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1. Write a C# Sharp program to check whether a given number is even or odd.
            Console.Write("Nhập 1 số: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} là số chẵn");
            }
            else { Console.WriteLine($"{a} là số lẻ"); }
            //2. Write a C# Sharp program to find the largest of three numbers.
            Console.Write("Nhập số đầu: ");
            int so1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số 2: ");
            int so2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số 3: ");
            int so3 = int.Parse(Console.ReadLine());
            int max = so1;
            if (max < so2 && so2 > so3)
            {
                max = so2;
            }
            else if (max < so3 && so3 > so2)
            { max = so3; }
            Console.WriteLine($"Số lớn nhất trong 3 số {so1}; {so2}; {so3} là {max}");
            //3. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
            Console.Write("Nhập x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập y: ");
            int y = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0)
                { Console.WriteLine($"({x},{y}) thuộc góc phần tư thứ nhất"); }
                else { Console.WriteLine($"({x},{y}) thuộc góc phần tư thứ tư"); }
            }
            else
            {
                if (y > 0)
                { Console.WriteLine($"({x},{y}) thuộc góc phần tư thứ hai"); }
                else { Console.WriteLine($"({x},{y}) thuộc góc phần tư thứ ba"); }
            }
            //4.Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
            Console.Write("Nhập cạnh 1: ");
            int c1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh 2: ");
            int c2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh 3: ");
            int c3 = int.Parse(Console.ReadLine());
            if (c1 + c2 > c3 && c1 + c3 > c2 && c2 + c3 > c1)
            {
                if (c1 == c2 && c1 == c3)
                { Console.WriteLine("Đây là tam giác đều"); }
                else if (c1 == c2 || c1 == c3 || c2 == c3)
                { Console.WriteLine("Đây là tam giác cân"); }
                else { Console.WriteLine("Đây là tam giác thường"); }
            }
            else { Console.WriteLine("3 cạnh không tạo thành tam giác"); }
            //5.Write a program to read 10 numbers and find their average and sum.
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"nhập số thứ {i + 1}: ");
                int so = int.Parse(Console.ReadLine());
                sum += so;
            }
            double avr = sum / 10.0;
            Console.WriteLine($"Tổng của 10 số là: {sum}");
            Console.WriteLine($"Trung bình cộng của 10 số là: {avr}");
            //6. Write a program to display the multiplication table of a given integer.
            Console.Write("Nhập số nguyên cho trước: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bảng cửu chương của {n} là: ");
            for (int i = 1; i <= 10; i++)
            {
                int kq = n * i;
                Console.WriteLine($"{n}x{i}={kq}");
            }
            //7. Write a program to display a pattern like triangles with a number
            Console.Write("Nhập số dòng : ");
            int h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            int dem = 1;
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(dem + " ");
                    dem++;
                }
                Console.WriteLine();
            }
            int dem2 = 1;
            for (int i = 1; i <= h; i++)
            {
                for (int s = 1; s <= h - i; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(dem2 + " ");
                    dem2++;
                }
                Console.WriteLine();
            }
            //8. Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
            Console.Write("Nhập số: ");
            int nhap = int.Parse(Console.ReadLine());
            double tong = 0.0;
            for (int i = 1; i <= nhap; i++)
            {
                Console.Write($" 1/{i} + ");
                tong = tong + (1.0 / i);
            }
            Console.WriteLine($" = {tong:f2}");
            //9.Write a program to find the ‘perfect’ numbers within a given number range.
            Console.Write("Nhập số: ");
            int pvi = int.Parse(Console.ReadLine());
            Console.WriteLine("Số hoàn hảo là: ");
            for (int test = 1; test <= pvi; test++)
            {
                int hh = 0;
                for (int i = 1; i <= test / 2; i++)
                {
                    if (test % i == 0)
                    { hh += i; }
                }
                if (hh == test)
                { Console.WriteLine(test); }
            }
            //10. Write a program to determine whether a given number is prime or not.
            Console.Write("Nhập số: ");
            int num = int.Parse(Console.ReadLine());
            bool ngto = true;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ngto = false;
                    break;
                }
            }
            if (ngto)
            {
                Console.WriteLine($"{num} là số nguyên tố");
            }
            else
            { Console.WriteLine($"{num} không phải số nguyên tố"); }
        }
    }
}
