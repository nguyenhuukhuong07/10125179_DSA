/*Chương 3 - Bài 7: Đếm số chữ số của số nguyên dương n*/

using System;
using System.Text;

class DemSoChuSocuaN
{
    static int SoChuSo(long n)
    {
        //th suy biến
        if (n == 0) return 0;
        //th đệ quy
        return SoChuSo(n / 10) + 1;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 3 - Bài 7: Đếm số chữ số của số nguyên dương n");
        Console.Write("Nhập số nguyên dương n: ");
        long n = long.Parse(Console.ReadLine());

        if (n <= 0) Console.WriteLine("Vui lòng nhập số n > 0");
        else
        {
            int kq = SoChuSo(n);
            Console.WriteLine($"Số {n} có {kq} chữ số");
        }
        Console.ReadKey();
    }
}
