/*Chương 2 - Bài 1: THÁP HÀ NỘI*/
using System;
using System.Text;

class ThapHaNoi
{
    static int buoc = 0;
    static void ThapHN(int n, char nguon, char trungGian, char dich)
    {
        //TH cơ sở có 1 đĩa
        if (n == 1)
        {
            buoc++;
            Console.WriteLine($"Bước {buoc}: Chuyển đĩa 1 từ {nguon} -> {dich} ");
            return;
        }

        //Chuyển n-1 đĩa từ nguồn -> trung gian
        ThapHN(n - 1, nguon, dich, trungGian);
        //Chuyển đĩa thứ n từ nguồn -> đích
        buoc++;
        Console.WriteLine($"Bước {buoc}: Chuyển đĩa {n} từ {nguon} -> {dich} ");
        //Chuyển đĩa thứ n từ nguồn sang đích
        ThapHN(n - 1, trungGian, nguon, dich);
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        //Nhập số đĩa n

        Console.WriteLine("CHƯƠNG 2 - Bài 1: Tháp Hà Nội");

        int n;
        Console.Write("Nhập số đĩa n: ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Sai định dạng, nhập lại!");
        }
        Console.WriteLine($"Giải bài toán Tháp Hà Nội với {n} đĩa");
        ThapHN(n, 'A', 'B', 'C');
        Console.WriteLine($"\n=> Tổng số phép toán (bước): {buoc}");

        Console.ReadKey();
    }
}
