using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_Excercises.session2
{
    internal class Baitap_1
    {
        public static void Main(string[] args)
        {
            //1. to Add / Sum Two Numbers.
            Console.Write("Nhap so thu nhat: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double sum = a + b;
            Console.WriteLine($"Tong cua {a} va {b} la: {sum}");
            //2.to Swap Values of Two Variables.
            int x = 5, y = 10;
            Console.WriteLine($"truoc khi hoan doi: x = {x}, y = {y}");
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"Sau khi hoan doi: x = {x}, y = {y}");
            //3.to Multiply two Floating Point Numbers
            Console.Write("Nhap so thuc thu nhat: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc thu hai: ");
            float n2 = float.Parse(Console.ReadLine());
            float product = n1 * n2;
            Console.WriteLine($"Tich cua {n1} va {n2} la: {product}");
            //4. to convert feet to meter
            Console.Write("Nhap so feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            double meter = feet * 0.3048;
            Console.WriteLine($"{feet} feet = {meter} met");
            //5. to convert Celsius to Fahrenheit and vice versa
            Console.Write("Nhap do Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            Console.Write("Nhap do Fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) * 5 / 9;
            Console.WriteLine($"{f}°F = {c}°C");
            //6.to find the Size of data types
            Console.WriteLine("Kich thuoc cua int: " + sizeof(int) + " bytes");
            Console.WriteLine("Kich thuoc cua float: " + sizeof(float) + " bytes");
            Console.WriteLine("Kich thuoc cua double: " + sizeof(double) + " bytes");
            Console.WriteLine("Kich thuoc cua char: " + sizeof(char) + " bytes");
            Console.WriteLine("Kich thuoc cua bool: " + sizeof(bool) + " bytes");
            //7. to Print ASCII Value (tip: read character, print number of this char)
            Console.Write("Nhap mot ky tu: ");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int asciiValue = (int)character;
            Console.WriteLine($"Ma ASCII cua '{character}' la: {asciiValue}");
            //8. to Calculate Area of Circle
            Console.Write("Nhap ban kinh hinh tron: ");
            double r = double.Parse(Console.ReadLine());
            double areaCircle = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Dien tich hinh tron la: {areaCircle:F2}");
            //9. to Calculate Area of Square
            Console.Write("Nhap do dai canh hinh vuong: ");
            double side = Convert.ToDouble(Console.ReadLine());
            double areaSquare = side * side;
            Console.WriteLine($"Dien tich hinh vuong la: {areaSquare}");
            //10.  to convert days to years, weeks and days
            Console.Write("Nhap so ngay: ");
            int totalDays = int.Parse(Console.ReadLine());
            int years = totalDays / 365;
            int weeks = (totalDays % 365) / 7;
            int days = (totalDays % 365) % 7;
            Console.WriteLine($"{totalDays} ngay tuong duong voi:");
            Console.WriteLine($"{years} nam, {weeks} tuan va {days} ngay.");
        }
    }
}
