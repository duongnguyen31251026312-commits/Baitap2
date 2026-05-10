using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_Excercises.session3
{
    internal class Baitap
    {
        public static void Main(string[] args)
        {
            //1.Write a C# Sharp program to print Hello and your name in a separate line.
            Console.WriteLine("Hello");
            Console.WriteLine("Alexandra Abrahmov");
            //2. Write a C# Sharp program to print the sum of two numbers.
            Console.Write("Nhap so a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            float b = float.Parse(Console.ReadLine());
            float c = a + b;
            Console.WriteLine($"Tong cua hai so {a} va {b} là {c}");
            //3. Write a C# Sharp program to print the result of dividing two numbers.
            Console.Write("Nhap so x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap so y: ");
            int y = int.Parse(Console.ReadLine());
            int q = x / y;
            int d = x % y;
            Console.WriteLine($"{x} chia {y} = {q} du {d}");
            //4. Write a C# Sharp program to print the results of the specified operations.
            Console.WriteLine("-1+4*6={0}", -1 + 4 * 6);
            Console.WriteLine("( 35 + 5 ) % 7 = {0}", (35 + 5) % 7);
            Console.WriteLine("14 + -4 * 6 / 11 = {0}", 14 + -4 * 6 / 11);
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = {0}", 2 + 15 / 6 * 1 - 7 % 2);
            //5. Swap Two Numbers.
            int truoc = 2; int sau = 4;
            Console.WriteLine($"Truoc khi hoan doi truoc = {truoc}, sau = {sau}");
            int temp = truoc; truoc = sau; sau = temp;
            Console.WriteLine($"Sau khi hoan doi truoc = {truoc}, sau = {sau}");
            //6. Multiply Three Numbers
            Console.Write("Nhap so dau: ");
            float first= float.Parse(Console.ReadLine());
            Console.Write("Nhap so hai: ");
            float second= float.Parse(Console.ReadLine());
            Console.Write("Nhap so ba: ");
            float third = float.Parse(Console.ReadLine());
            float sum = first * second * third;
            Console.WriteLine($"Tich cua ba so {first}x{second}x{third}= {sum}");
            //7. Arithmetic Operations
            Console.Write("Nhap so thu nhat: ");
            int  f= int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int  s= int.Parse(Console.ReadLine());
            Console.WriteLine($"{f}+{s}={f+s}");
            Console.WriteLine($"{f}-{s}={f - s}");
            Console.WriteLine($"{f}*{s}={f * s}");
            Console.WriteLine($"{f}/{s}={f / s}");
            Console.WriteLine($"{f} mod {s}={f % s}");
            //8. Average of Four Numbers
            Console.Write("Nhap so dau: ");
            float fi = float.Parse(Console.ReadLine());
            Console.Write("Nhap so hai: ");
            float se = float.Parse(Console.ReadLine());
            Console.Write("Nhap so ba: ");
            float th = float.Parse(Console.ReadLine());
            Console.Write("Nhap so bon: ");
            float fo = float.Parse(Console.ReadLine());
            Console.WriteLine($"Trung binh cong bon so {fi};{se};{th};{fo} la {(fi + se + th + fo) / 4}");
            //9.Specified Formula with Three Numbers
            Console.Write("Nhap so dau: ");
            int dau = int.Parse(Console.ReadLine());
            Console.Write("Nhap so hai: ");
            int hai = int.Parse(Console.ReadLine());
            Console.Write("Nhap so ba: ");
            int cuoi = int.Parse(Console.ReadLine());
            Console.WriteLine($"({dau}+{hai}).{cuoi}={(dau+hai)*cuoi} va {dau}.{hai}+{hai}.{cuoi}={dau*hai+hai*cuoi}");
            //10. Print Age Message
            Console.Write("Nhap do tuoi: ");
            int tuoi=int.Parse(Console.ReadLine());
            Console.WriteLine($"You look older than {tuoi}");
            //11.  Repeat Number in Rows
            Console.Write("Nhap mot so: ");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}\n"+"{0}{0}{0}{0}\n"+"{0} {0} {0} {0}\n"+"{0}{0}{0}{0}", num);
            //12.Celsius to Kelvin and Fahrenheit
            Console.Write("Nhap do Celsius: ");
            int ce = int.Parse(Console.ReadLine());
            int kelvin = ce + 273;
            int fahrenheit = ce * 18 / 10 + 32;
            Console.WriteLine($"{ce} do C = {kelvin} K\n" +
                $"{ce} do C = {fahrenheit} F");
            //13.Remove Character by Index
            Console.Write("Nhap chuoi: ");
            string str=Console.ReadLine();
            Console.Write("Nhap ki tu xoa: ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine($"Chuoi sau khi xoa: {str.Remove(n, 1)}");
            //14.Swap First and Last Characters
            Console.Write("Nhap chuoi: ");
            string chuoi=Console.ReadLine();
            if (chuoi.Length <= 1)
            {
                Console.WriteLine($"Chuoi moi la: {chuoi}");
            }
            else
            {
                string fchar = chuoi.Substring(0, 1);
                string lchar = chuoi.Substring(chuoi.Length - 1);
                string mchar = chuoi.Substring(1, chuoi.Length - 2);
                Console.WriteLine($"Chuoi moi la: {lchar + mchar + fchar}");
            }
            //15. Add First Character to Front and Back
            Console.Write("Nhap chuoi: ");
            String chu=Console.ReadLine();
            Console.Write("Nhap tu them: ");
            String them=Console.ReadLine();
            Console.WriteLine($"Chuoi moi la: {them+chu+them}");
            //16. Check Positive and Negative Pair
            Console.Write("Nhap so a1: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so a2: ");
            int a2 = int.Parse(Console.ReadLine());
            bool kq = (a1 * a2 < 0);
            Console.WriteLine($"Kiem tra co 1 so am va 1 so duong la: {kq}");
            //17.Check for 20 or Sum Equals 20
            Console.Write("Nhap so b1: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b2: ");
            int b2 = int.Parse(Console.ReadLine());
            int tong = b1 + b2;
            bool b3 = (b1 == 20 || b2 == 20 || b1 + b2 == 20);
            Console.WriteLine($"Ket qua: {b3}");
            //18. Check Multiple of 3 or 7
            Console.Write("Nhap so : ");
            int so = int.Parse(Console.ReadLine());
            bool rs=(so % 3 == 0 || so % 7 == 0);
            Console.WriteLine($"So cho truoc la boi so cua 3 hoac 7: {rs}");
            //19.Check Numbers Less than 100 & Greater than 200
            Console.Write("Nhap so n1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so n2: ");
            int n2 = int.Parse(Console.ReadLine());
            bool n3 = (n1 < 100 && n2 > 200 || n2 < 100 && n1 > 200);
            Console.WriteLine($"Kiem tra mot so be hon 100 va mot so lon hon 200 la: {n3}");
            //20.Check Integer in Range -10 to 10
            Console.Write("Nhap so w1: ");
            int w1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so w2: ");
            int w2 = int.Parse(Console.ReadLine());
            bool w3= (-10<=w1 && w1<=10||-10<=w2 && w2<=10);
            Console.WriteLine($"Ket qua kiem tra trong doan -10 toi 10 la: {w3}");
        }
    }
}
