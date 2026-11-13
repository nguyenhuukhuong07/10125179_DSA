/*Chương 3 - Bài 6: Tìm ước chung lớn nhất của 2 số nguyên dương a, b*/

using System;
using System.Text;

class TimUocChungMax
{
    static int UCLN(int a, int b)
    {
        //th suy biến a chia hết cho b
        if (a % b == 0) return b;
        //th đệ quy
        return UCLN(b, a % b);
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 3 - Bài 6: Tìm UCLN của 2 số nguyên dương a, b");

        Console.Write("Nhập số nguyên dương a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập số nguyên dương b: ");
        int b = int.Parse(Console.ReadLine());

        if (a <= 0 || b <= 0) Console.WriteLine("Vui lòng nhập số nguyên dương > 0");
        else
        {
            int kq = UCLN(a, b);
            Console.WriteLine($"UCLN của {a} và {b} là: {kq}");
        }
    }
}
