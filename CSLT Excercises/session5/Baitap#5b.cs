namespace CSLT_Excercises.session5
{
    internal class Baitap_5b
    {
        //Nhập các phần tử trong mảng
        static void phatsinh_Mang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu thu {i} cua mang: ");
                int nhap = int.Parse(Console.ReadLine());
                a[i] = nhap;
            }
        }
        //In mảng ra
        static void In_Mang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            //1. Tính tổng hai số nguyên
            Console.Write("Nhap so dau tien: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so tiep theo: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tong 2 so {a} va {b} la {tong(a, b)}");
            //2. Kiểm tra số chẵn lẻ
            Console.Write("Nhap so kiem tra chan le: ");
            int c = int.Parse(Console.ReadLine());
            if (chanle(c))
                Console.Write($"{c} la so chan");
            else
                Console.Write($"{c} la so le");
            Console.WriteLine()
            //3. Tìm số lớn nhất trong ba số
            Console.Write("Nhap so dau tien: ");
            int one = int.Parse(Console.ReadLine());
            Console.Write("Nhap so tiep theo: ");
            int two = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 3: ");
            int three = int.Parse(Console.ReadLine());
            Console.WriteLine($"So lon nhat trong ba so {one}, {two}, {three} la {max3so(one,two,three)}");
            //4. Tính giai thừa của một số
            Console.Write("Nhap so can tinh giai thua: ");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine($"Giai thua cua {g} la {giaithua(g)}");
            //5.  Đảo ngược chuỗi ký tự
            Console.WriteLine("Nhap chuoi bat ki: ");
            string m = Console.ReadLine();
            string ms = Daochuoi(m);
            Console.WriteLine($"Chuoi moi sau khi dao: {ms}");
            //6. Kiểm tra số nguyên tố
            Console.Write("Nhap 1 so: ");
            int so = int.Parse(Console.ReadLine());
            if (Nto(so))
            {
                Console.WriteLine($"{so} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{so} khong la so nguyen to");
            }
            //7. In dãy Fibonacci
            Console.Write("Nhap 1 so: ");
            int k = int.Parse(Console.ReadLine());
            Fibonacci(k);
            //8.  Đếm số lượng nguyên âm trong chuỗi
            Console.WriteLine("Nhap chuoi bat ki: ");
            string chuoi = Console.ReadLine();
            int dem= Demnguyenam(chuoi);
            Console.WriteLine($"So nguyen am trong chuoi la: {dem}");
            //9. Tính luỹ thừa
            Console.Write("Nhap 1 so can tinh luy thua: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Nhap so luy thua: ");
            int mu = int.Parse(Console.ReadLine());
            double rs = luythua(f,mu);
            Console.WriteLine($"{f} luy thua {mu} = {rs}");
            //10. Tính điểm trung bình của mảng
            Console.Write("Nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] q = new int[n];
            phatsinh_Mang(q, n);
            In_Mang(q,n);
            Console.WriteLine($"Trung binh cong cac phan tu trong mang la: {avr(q)}");
            //11. Kiểm tra chuỗi đối xứng
            Console.WriteLine("Nhap chuoi bat ki: ");
            string ch = Console.ReadLine();
            if (dxung(ch))
                Console.WriteLine("Chuoi nay la chuoi doi xung");
            else
                Console.WriteLine("Chuoi nay khong phai la chuoi doi xung");
            //12. Chuyển đổi nhiệt độ
            Console.Write("Nhap nhiet do Celsius: ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine($"{C} C = {chuyendoi(C)} F");
            //13. Tìm giá trị nhỏ nhất trong mảng
            Console.Write("Nhap so phan tu mang: ");
            int sl = int.Parse(Console.ReadLine());
            int[] w = new int[sl];
            phatsinh_Mang(w, sl);
            In_Mang(w, sl);
            Console.WriteLine($"So nho nhat trong mang la: {min(w)}");
            //14.Tính tổng các chữ số của 1 số nguyên
            Console.Write("Nhap so: ");
            int nguyen = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tong cac chu so la: {Tongchuso(nguyen)}");
            //15. Sắp xếp mảng tăng dần
            Console.Write("Nhap so phan tu mang: ");
            int soluong = int.Parse(Console.ReadLine());
            int[] e = new int[soluong];
            phatsinh_Mang(e, soluong);
            In_Mang(e, soluong);
            sapxep(e);
            //16. Xóa ký tự trùng lặp
            Console.WriteLine("Nhap chuoi bat ki: ");
            string chu = Console.ReadLine();
            Console.WriteLine($"Chuoi sau khi xoa trung lap la: {new string(Xoatrunglap(chu))}");
            //17. Tìm ước chung lớn nhất
            Console.Write("Nhap so: ");
            int fi = int.Parse(Console.ReadLine());
            Console.Write("Nhap so: ");
            int se = int.Parse(Console.ReadLine());
            Console.WriteLine($"Uoc chung lon nhat cua {fi} va {se} la {UCLN(fi,se)}");
            //18. Chuyển đổi hệ thập phân thành nhị phân
            Console.Write("Nhap so thap phan: ");
            int deci = int.Parse(Console.ReadLine());
            Console.WriteLine($"Chuyen doi so {deci} sang so nhi phan la: {new string(Nhiphan(deci))}");
            //19. Kiểm tra năm nhuận
            Console.Write("Nhap nam kiem tra: ");
            int year = int.Parse(Console.ReadLine());
            if(NamNhuan(year))
                Console.WriteLine($"Nam {year} la nam nhuan");
            else
                Console.WriteLine($"Nam {year} khong phai la nam nhuan");
            //20. Đếm số từ trong câu
            Console.WriteLine("Nhap chuoi bat ki: ");
            string cau = Console.ReadLine();
            int count=demso(cau);
            Console.WriteLine($"So tu trong cau la: {count + 1}");
        }
        //bai1.
        static int tong(int a, int b)
        {
            return a + b;
        }
        //bai2.
        static bool chanle(int a)
        {
            if (a % 2 == 0)
                return true;
            return false;
        }
        //bai3. 
        static int max3so(int a, int b, int c)
        {
            int max = a;
            if (b > max && b > c)
                max = b;
            else if (c > max && b < c)
                max = c;
            return max;
        }
        //bai4
        static long giaithua(int a)
        {
            long b = 1;
            for (int i = 1; i <= a; i++)
            {
                b *= i;
            }
            return b;
        }
        //Bai5. 
        static string Daochuoi(string a)
        {
            char[] c = a.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }
        //Bai6
        static bool Nto(int a)
        {
            bool nto = true;
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                { nto = false; }
            }
            return nto;
        }
        //Bai7
        static void Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            if (n == 1)
                Console.WriteLine(a);
            else if (n == 2)
                Console.WriteLine(b);
            else
            {
                Console.Write($"Dãy Fibonacci: {a} {b} ");
                for (int i = 3; i <= n; i++)
                {
                    int c = a + b;
                    Console.Write(c + " ");
                    a = b;
                    b = c;
                }
                Console.WriteLine();
            }
        }
        //bai8.
        static int Demnguyenam(string a)
        {
            int dem = 0;
            string nguyenam = "aeiou";
            foreach (char c in a)
            {
                char kytu = char.ToLower(c);
                if (nguyenam.Contains(kytu))
                {
                    dem++;
                }
            }
            return dem;
        }
        //Bai9.
        static double luythua(double a, int b)
        {
            double c = 1;
            if (b == 0)
                return c;
            else
            {
                for (int i = 0; i < b; i++)
                    c *= a;
            }
            return c;
        }
        //Bai10
        static double avr(int[] arr)
        {
            double Sum = 0;
            foreach (int i in arr)
                Sum += i;
            double c = Sum / arr.Length;
            return c;
        }
        //Bai 11
        static bool dxung(string a)
        {
            if (a == Daochuoi(a))
                return true;
            return false;
        }
        //Bai12.
        static double chuyendoi(double a)
        {
            double c = (a * 1.8) + 32.0;
            return c;
        }
        //Bai13.
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
        //Bai14. 
        static int Tongchuso(int a)
        {
            int S = 0;
            while (a != 0)
            {
                int so = a % 10;
                S += so;
                a /= 10;
            }
            return S;
        }
        //Bai15.
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
        //Bai16.
        static string Xoatrunglap(string s)
        {
            char[] c = s.ToCharArray();
            bool dem = false;
            for (int k = 0; k < c.Length; k++)
            {
                for (int l = k+1;  l < c.Length; l++)
                    if (c[l] == c[k])
                    {
                        dem = true;
                        break;
                    }    
            }
            int dodai = c.Length;
            if (dem)
                for (int i = 0; i < dodai; i++)
                { for (int j = i + 1; j < dodai; j++)
                    { if (c[j] == c[i])
                        {
                            for (int m = j; m < dodai - 1; m++)
                            {
                                c[m] = c[m + 1];
                            }
                            dodai--;
                            j--;
                        }
                    }
                }
            string a = new string(c, 0, dodai);
            return a;
        }
        //Bai17.
        static int UCLN(int a, int b)
        {
            int r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            return b;
        }
        //Bai18.
        static string Nhiphan(int n)
        {
            string s = "";
            while (n != 0)
            {
                int r= n % 2;
                s = $"{r}{s}";
                n /= 2;
            }
            return s;
        }
        //Bai19.
        static bool NamNhuan(int n)
        {
            return (n % 4 == 0 && n % 100 != 0) || (n % 400 == 0);
        }
        //Bai20
        static int demso(string s)
        {
            int count = 0;
            char[] a = s.ToCharArray();
            foreach (char c in a)
            {
                if (c == ' ')
                    { count++; }
            }
            return count;
        }
    }
}
