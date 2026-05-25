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
            /*//2. to find the length of a string without using a library function
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
            if (Chuoibangnhau(s, a))
                Console.WriteLine("2 chuoi nay bang nhau");
            else
                Console.WriteLine("2 chuoi nay khong bang nhau");*/
            //7. to count the number of alphabets, digits and special characters in a string.
            Dem(s);
            //8. to count the number of vowels or consonants in a string.
            Demnguyenphu(s);
            //9.to check whether a given substring is present in the given string.
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
        static bool Chuoibangnhau(string s,string a)
        {
            if (Demchuoi(s)!=Demchuoi(a))
            {
                return false;
            }
            else 
                for (int i=0; i<s.Length; i++ )
                {
                    if (s[i] != a[i])
                        return false;
                }    
            return true;
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
                else if (c !=' ')
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
            string nguyenam = "aeyouAEYOU";
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
    }
}
