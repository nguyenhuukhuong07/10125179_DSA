/*Chương 3 - Bài 8: Tính tổng căn trong căn từ 1 -> n*/

using System;
using System.Text;

class TinhTongCanLongNhau
{
    static double Can(int i, int n)
    {
        //th suy biến lớp căn trong cùng
        if (i == n) return Math.Sqrt(n);
        //th đệ quy
        return Math.Sqrt(i + Can(i + 1, n));
    }

    static double S(int n)
    {
        return Can(1, n);
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 3 - Bài 8: Tính tổng các căn lồng nhau");

        Console.Write("Nhập số nguyên dương n (n>=1): ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1) Console.WriteLine("Vui lòng nhập số n >=1");
        else
        {
            double kq = S(n);
            Console.WriteLine($"Kết quả S({n}) (làm tròn đến chữ số t4) = {kq:F4}");
        }

        Console.ReadKey();
    }
}
