/*Chương 1 - Bài 5: Bài toán tìm số Fibonacci thứ n: Xây dựng chương trình nhập vào 1 số nguyên dương n
                    Chương trình in ra số Fibonacci thứ n*/

using System;
using System.Text;

class Fibonacci
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 1 - Bài 5: Bài toán tìm số Fibonacci thứ n");

        int n;
        Console.Write("Nhập 1 số nguyên dương n: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Nhập sai số nguyên dương, vui lòng nhập lại!");
        }

        long f1 = 1, f2 = 1, fn = 1;

        if (n > 2)
        {
            int i = 3;
            while (i <= n)
            {
                fn = f1 + f2;
                f1 = f2;
                f2 = fn;
                i++;
            }
        }

        Console.WriteLine($"Số Fibonacci thứ {n} là: {fn}");
        Console.ReadKey();
    }
}
