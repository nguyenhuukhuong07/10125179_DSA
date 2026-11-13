/*Chương 3 - Bài 5: Tìm ước là số lẻ lớn nhất của số nguyên dương n*/

using System;
using System.Text;

class TimUocLeMax
{
    static int UocLeMax(int n)
    {
        //th suy biến n là số lẻ
        if (n % 2 == 1)
            return n;
        //th đệ quy n là số chẵn 
        return UocLeMax(n / 2);
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 3 - Bài 5: Tìm ước số lẻ lớn nhất của số nguyên dương n");

        Console.Write("Nhập số nguyên dương n(n>=1): ");
        int n = int.Parse(Console.ReadLine());
        if (n < 1) Console.WriteLine("Vui lòng nhập số nguyên dương >=1");
        else
        {
            int kq = UocLeMax(n);
            Console.WriteLine($"Ước lẻ lớn nhất của {n} là: {kq}");
        }
    }
}
