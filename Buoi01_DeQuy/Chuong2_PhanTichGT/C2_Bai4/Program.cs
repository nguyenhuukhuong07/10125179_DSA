/*Chương 2 - Bài 4: Liệt kê các số hoàn hảo < một số nguyên dương n cho trước*/
using System;
using System.Runtime.InteropServices;
using System.Text;

class SoHoanHao
{
    static bool LaSoHoanHao(int x, ref long buoc)
    {
        int tongUoc = 0;
        for (int i = 1; i <= x - 1; i++)
        {
            buoc++;
            if (x % i == 0)
                tongUoc = tongUoc + i;
        }
        return tongUoc == x;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 2 - Bài 4: Liệt kê số hoàn hảo");

        Console.Write("Nhập số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());

        long buoc = 0;
        Console.Write($"Các số hoàn hảo nhỏ hơn {n}: ");
        for (int x = 2; x < n; x++)
        {
            if (LaSoHoanHao(x, ref buoc))
                Console.Write(x + " ");
        }
        Console.WriteLine($"\nTổng số phép lặp: {buoc}");
    }
}
