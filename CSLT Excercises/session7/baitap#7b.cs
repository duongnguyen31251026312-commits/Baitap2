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
                int so = int.Parse(Console.ReadLine());
                a[i] = so;
            }
        }
        static void Inmang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bai 1.Nhập và xuất mảng
            Console.WriteLine("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Nhapmang(a, n);
            Inmang(a, n);
            //Bai 2.Tính tổng và trung bình cộng
            Console.WriteLine($"Tổng của các phần tử trong mảng là: {Tong(a)}");
            Console.WriteLine($"Trung bình cộng của các phần tử trong mảng là: {TBC(a):f2}");
            //Bai 3.Tìm số lớn nhất và nhỏ nhất
            Console.WriteLine($"Số lớn nhất trong mảng là: {Max(a)}");
            Console.WriteLine($"Số bé nhất trong mảng là: {Min(a)}");
            //Bai 4.Đếm số chẵn lẻ
            Console.WriteLine($"Số chẵn trong mảng là: {Demso(a)}");
            Console.WriteLine($"Số lẻ trong mảng là: {a.Length - Demso(a)}");
            //Bai 5.Tìm kiếm 1 số trong mảng
            Console.WriteLine("Nhập số cần tìm: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Vị trí tìm thấy số {b} trong mảng là: {Checkso(a, b)}");
            //Bai 6.Đảo ngược mảng
            Daonguoc(a);
            //Bai 7.Kiểm tra mảng đối xứng
            if (Doixung(a))
                Console.WriteLine("YES");
            else Console.WriteLine("NO");
            //Bai 8.Liệt kê các số nguyên tố trong mảng
            Console.WriteLine("Các số nguyên tố trong mảng là: ");
            Innguyento(a);
            //Bai 9.Tách mảng Chẵn -Lẻ
            Tachmang(a);
            //Bai 10. Sắp xếp mảng tăng dần và giảm dần
            Console.WriteLine("Mảng sắp xếp tăng dần là: ");
            Noibot(a);
            Console.WriteLine("Mảng sắp xếp giảm dần là: ");
            Console.WriteLine();
            Giamdan(a);
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
            double d = (double)Tong(a) / a.Length;
            return d;
        }
        //3.
        static int Max(int[] a)
        {
            int max = a[0];
            foreach (int i in a)
                if (i > max)
                    max = i;
            return max;
        }
        static int Min(int[] a)
        {
            int min = a[0];
            foreach (int i in a)
                if (i < min)
                    min = i;
            return min;
        }
        //4. 
        static int Demso(int[] a)
        {
            int d = 0;
            foreach (int i in a)
                if (i % 2 == 0)
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
            for (int i = a.Length - 1; i >= 0; i--)
                Console.Write(a[i] + " ");
        }
        //7. 
        static bool Doixung(int[] a)
        {
            int n = a.Length;
            for (int i = 0;i < n/2;i++)
                if (a[i] != a[n-1-i])
                    return false;
            return true;
        }
        //8.
        static bool Checknguyento(int a)
        {
            for (int i = 2; i <= Math.Sqrt(a); i++)
                if (a % i == 0)
                    return false;
            return true;
        }
        static void Innguyento(int[] a)
        {
            foreach (int i in a)
                if (Checknguyento(i))
                    Console.Write(i + " ");
        }
        //9. 
        static void Tachmang(int[] a)
        {
            int dem = 0;
            foreach (int i in a)
                if (i % 2 == 0)
                    dem++;
            int[] b = new int[dem];
            int[] c = new int[a.Length-dem];
            int idxb = 0; int idxc=0;
            foreach (int i in a)
            {
                if (i%2==0)
                {
                    b[idxb] = i;
                    idxb++;
                }    
                else
                {
                    c[idxc] = i;
                    idxc++;
                }    
            }
            Console.WriteLine("Số phần tử chẵn trong mảng: ");
            foreach (int i in b)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("Số phần tử lẻ trong mảng: ");
            foreach (int j in c)
                Console.Write(j + " ");
        }
        //10. 
        static void Noibot(int[] a)
        {
            for (int i=0; i<a.Length-1; i++)
            {
                for (int j=0; j<a.Length-1-i; j++)
                {
                    if (a[j]>a[j+1])
                    { 
                        int temp = a[j+1];
                        a[j+1]=a[j];
                        a[j] = temp;
                    }    
                }        
            }
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write(a[k] + " ");
            }
        }
        static void Giamdan(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write(a[k] + " ");
            }
        }
    }
}
