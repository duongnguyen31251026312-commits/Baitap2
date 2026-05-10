using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_Excercises.session_4
{
    internal class baitap_3
    {
        static void Main(string[] args)
        {
            //Bai1.
            Console.Write("nhap so dau tien: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={a + b}");
            Console.WriteLine($"{a}-{b}={a - b}");
            Console.WriteLine($"{a}*{b}={a * b}");
            Console.WriteLine($"{a}/{b}={a / b}");
            //Bai2.
            Console.WriteLine("y \t x = y² + 2y + 1");
            for (int y = -5; y <= 5; y++)
            {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine($"{y} \t {x}");
            }
            //Bai3.
            Console.Write("Input distance (meters): ");
            float distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input time (hours): ");
            float hours = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input time (minutes): ");
            float minutes = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input time (seconds): ");
            float seconds = Convert.ToSingle(Console.ReadLine());
            float totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
            float kph = (distance / 1000.0f) / (totalSeconds / 3600.0f);
            float mph = kph / 1.609f;
            Console.WriteLine($"Your speed in km/h is {kph} km/h");
            Console.WriteLine($"Your speed in miles/h is {mph} miles/h");
            //Bai4.
            Console.Write("Nhap ban kinh: ");
            float r = float.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(r, 2);
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"\t Dien tich bang= {surface:f2}\n" +
                $"\t The tich bang= {volume:f2}");
            //Bai5.
            Console.Write("Enter a character: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsDigit(input))
            {
                Console.WriteLine("It is a digit.");
            }
            else if ("aeiouAEIOU".Contains(input))
            {
                Console.WriteLine("It is a vowel.");
            }
            else
            {
                Console.WriteLine("It is another symbol or a consonant.");
            }
        }
    }
}
