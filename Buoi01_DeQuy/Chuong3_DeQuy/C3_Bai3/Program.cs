/*Chương 3 - Bài 3: Tính S(n) = 1 + 1/2 + 1/3 + ... + 1/(n-1) + 1/n */

using System;
using System.Text;

class TinhTongPS
{
    static double S(int n)
    {
        //th suy biến
        if (n == 1) return 1;
        //th đệ quy
        return S(n - 1) + 1.0 / n;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 3 - Bài 3: Tính S(n) = 1 + 1/2 + 1/3 + ... + 1/(n-1) + 1/n");
        Console.Write("Nhập số nguyên dương n (n>=1): "); int n = int.Parse(Console.ReadLine());
        if (n < 1) Console.WriteLine("Vui lòng nhập số nguyên dương >=1");
        else
        {
            double kq = S(n);
            Console.WriteLine($"Tổng S({n}) = {kq:F4}");
        }
    }
}
