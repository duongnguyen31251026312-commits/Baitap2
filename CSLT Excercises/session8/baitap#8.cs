using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_Excercises.session8
{
    internal class baitap_8
    {
        static void Main(string[] args)
        {
            //1. To input string and print it
            Console.WriteLine("Nhap chuoi: ");
            string s= Console.ReadLine();
            Console.WriteLine($"Chuoi moi nhap la: {s}");
            //2. to find the length of a string without using a library function
            Console.WriteLine($"Do dai cua chuoi la: {Demchuoi(s)}");
            //3.to separate individual characters from a string.
            Console.WriteLine("In ky tu chuoi: ");
            sepa(s);
            //4. to print individual characters of the string in reverse order.
            Console.WriteLine();
            Console.WriteLine("In nguoc ky tu chuoi");
            nguoc(s);
            //5. to count the total number of words in a string.
            Console.WriteLine($"Tong so trong chuoi la: {Demso(s)}");
            //6. to compare two strings without using a string library functions.
            Console.WriteLine("Nhap chuoi thu 2: ");
            string a= Console.ReadLine();
            if (Chuoibangnhau(s, a)==0)
                Console.WriteLine("2 chuoi nay bang nhau");
            else if (Chuoibangnhau(s,a)==1)
                Console.WriteLine("Chuoi thu nhat lon hon chuoi thu hai");
            else if (Chuoibangnhau(s, a) == 2)
                Console.WriteLine("Chuoi thu hai lon hon chuoi thu nhat");
            //7. to count the number of alphabets, digits and special characters in a string.
            Dem(s);
            //8. to count the number of vowels or consonants in a string.
            Demnguyenphu(s);
            //9.to check whether a given substring is present in the given string.
            Console.WriteLine("Nhap chuoi thu 2: ");
            string z=Console.ReadLine();
            if (Chuoicon(s, z))
                Console.WriteLine("Chuoi con co trong chuoi da cho.");
            else
                Console.WriteLine("Chuoi con khong co trong chuoi da cho.");
            //10. to search for the position of a substring within a string.
            Console.WriteLine("Nhap chuoi thu 2: ");
            string x = Console.ReadLine();
            Index(s, x);
            //11.To check whether a character is an alphabet and not and if so, check for the case.
            Console.Write("Nhap ky tu: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Chucai(c);
            //12.to find the number of times a substring appears in a given string.
            Console.WriteLine("Nhap chuoi con: ");
            string m = Console.ReadLine();
            if (Xuathien(s, m) == 0)
                Console.WriteLine("Chuoi con khong xuat hien trong chuoi da cho.");
            else
                Console.WriteLine($"Chuoi con xuat hien {Xuathien(s,m)} lan ");
            //13.
            Console.WriteLine("Nhap chuoi con: ");
            string n = Console.ReadLine();
            Console.WriteLine("Nhap chuoi chen ki tu vao truoc: ");
            string l = Console.ReadLine();
            Console.WriteLine("Chuoi moi sau khi chen la: ");
            Chen(s, n, l);
        }
        //2.
        static int Demchuoi(string s)
        {
            int count= 0;
            foreach (char c in s)
            {
                count++;
            }
            return count;
        }
        //3.
        static void sepa(string s)
        {
            foreach (char c in s)
                Console.Write(c+" ");
        }
        //4. in chuoi nguoc
        static void nguoc(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
                Console.Write(s[i]+" ");
        }
        //5.
        static int Demso(string s)
        {
            int tong = 0;
            foreach (char c in s)
            {
                if (c >= '0' && c <='9')
                {
                    int a=(int)c-48;
                    tong += a;
                }
            }
            return tong;
        }
        //6.
        static int Chuoibangnhau(string s,string a)
        {
            if (s == null && a==null)
                return 0;
            if (s == null)
                return 2;
            if (a == null)
                return 1;
            int c = s.Length;
            int d = a.Length;
            if (c == d)
            {
                for (int i = 0; i < d; i++)
                {
                    if (s[i] == a[i])
                        return 0;
                    else if (s[i] > a[i])
                        return 1;
                    else
                        return 2;
                }
            }
            else
            {
                int minlen=0;
                if (c < d)
                    minlen = s.Length;
                if (c > d)
                    minlen = a.Length;
                int dem = 0;
                for (int j = 0; j < minlen;j++)
                {
                    if (s[j] > a[j])
                        return 1;
                    else if (s[j] < a[j])
                        return 2;
                    else
                        dem++;
                }
                if (dem==minlen)
                {
                    if (c>d)
                        return 1;
                    else return 2;
                }    
            }
            return 0;
        }
        //7.
        static void Dem(string s)
        {
            int kytu = 0;
            int so = 0;
            int chucai = 0;
            foreach (char c in s)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                    chucai++;
                else if ((c >= '0' && c <= '9'))
                    so++;
                else
                    kytu++;
            }
            Console.WriteLine($"So luong chu cai trong chuoi la: {chucai}");
            Console.WriteLine($"So luong so trong chuoi la: {so}");
            Console.WriteLine($"So luong ky tu dac biet trong chuoi la: {kytu}");
        }
        //8.
        static void Demnguyenphu(string s)
        {
            int nguyen = 0;
            int phu = 0;
            string nguyenam = "aeiouAEIOU";
            foreach (char c in s)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                    if (nguyenam.Contains(c))
                        nguyen++;
                    else
                        phu++;
            }   
            Console.WriteLine($"So luong nguyen am la: {nguyen}");
            Console.WriteLine($"So luong phu am la: {phu}");
        }
        //9.
        static bool Chuoicon(string s, string a)
        {
            int c = s.Length;
            int d= a.Length;
            if (d>c)
                return false;
            if (c == d && c==0)
                return true;
            if (c>=d)
            {
                if (s.Contains(a)) 
                    return true;
            }
            return false;
        }
        //10.
        static void Index(string s, string a)
        {
            int p = s.IndexOf(a);
            if (p == -1)
                Console.WriteLine("Khong tim thay chuoi con.");
            else
                Console.WriteLine($"Chuoi con nam o vi tri {p}");
        }
        //11.
        static void Chucai(char a)
        {
            if (a >= 'A' && a <= 'Z' || a >= 'a' && a <= 'z')
            {
                Console.WriteLine("Ky tu nay la chu cai.");
                if (a >= 'A' && a <= 'Z')
                    Console.WriteLine("Ky tu nay la chu hoa.");
                else Console.WriteLine("Ky tu nay la chu thuong");
            }
            else
                Console.WriteLine("Ky tu nay khong phai la chu cai.");
        }
        //12. 
        static int Xuathien(string s, string a)
        {
            int dem = 0;
            int index= s.IndexOf(a);
            while (index != -1)
            {
                dem++;
                index = s.IndexOf(a, index+a.Length);
            }   
            return dem;
        }
        //13.
        static void Chen(string a, string b, string e)
        {
            int idx= a.IndexOf(e);
            string c= a.Substring(0, idx);
            c += b;
            string d= a.Substring(idx-1);
            c += d;
            Console.WriteLine(c);
        }
    }
}
