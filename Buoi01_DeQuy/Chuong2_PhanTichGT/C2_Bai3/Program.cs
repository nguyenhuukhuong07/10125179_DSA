/*Chương 2 - Bài 3: Ktra 1 số có là số nguyên tố không?*/
using System;
using System.Text;

class KiemTraSoNguyenTo
{
    //Giải thuật 1: Cơ bản (Duyệt từ 2 -> n-1)
    static bool LaSoNT_CoBan(int n, out int buoc)
    {
        buoc = 0;
        if (n < 2) return false;
        
        for (int i = 2; i <= n-1; i++)
        {
            buoc++;
            if (n % i == 0) return false;
        }
        return true;
    }

    //Giải thuật 2: Cải tiến (Duyệt từ 2 đến n)
    static bool LaSoNT_CaiTien(int n, out int buoc)
    {
        buoc = 0;
        if (n < 2) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            buoc++;
            if (n % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 2 - Bài 3: Kiểm tra số nguyên tố (2 giải thuật)");

        Console.Write("Nhập số nguyên dương n cần kiểm tra: ");
        int n = int.Parse(Console.ReadLine());

        //chạy giải thuật 1
        bool kq1 = LaSoNT_CoBan(n, out int buoc1);
        Console.WriteLine($"\nGIẢI THUẬT 1: CƠ BẢN");
        Console.WriteLine($"=> {n} {(kq1 ? "LÀ" : "KHÔNG LÀ")} số nguyên tố (Số phép lặp: {buoc1})");

        //chạy giải thuật 2
        bool kq2 = LaSoNT_CaiTien(n, out int buoc2);
        Console.WriteLine($"\nGIẢI THUẬT 2: CẢI TIẾN");
        Console.WriteLine($"=> {n} {(kq2 ? "LÀ" : "KHÔNG LÀ")} số nguyên tố (Số phép lặp: {buoc2})");

        Console.ReadKey();
    }
}
