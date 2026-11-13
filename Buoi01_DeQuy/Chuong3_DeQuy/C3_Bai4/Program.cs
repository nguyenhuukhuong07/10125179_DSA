/*Chương 3 - Bài 4: Tính lũy thừa S(x, n) = x^n*/

using System;
using System.Text;

class TinhLuyThua
{
    static double LuyThua(double x, int N)
    {
        //th suy biến
        if (N == 0) return 1;
        //th đệ quy
        return LuyThua(x, N - 1) * x;
    }

    static double S(double x, int N)
    {
        if (N < 0) return 1.0 / LuyThua(x, -N);
        else return LuyThua(x, N);
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 3 - Bài 4: Tính S(x, n) = x^n");

        Console.Write("Nhập cơ số x: "); double x = double.Parse(Console.ReadLine());
        Console.Write("Nhập số mũ N: "); int N = int.Parse(Console.ReadLine());
        if (x == 0 && N < 0) Console.WriteLine("Lỗi!");
        else
        {
            double kq = S(x, N);
            Console.WriteLine($"Kết quả S({x}, {N}) = {x}^{N} = {kq}");
        }

        Console.ReadKey();
    }
}
