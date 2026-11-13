//Chương 1 - Bài 4: Nhập ngẫu nhiên 100 số tự nhiên và lưu vào mảng
//Sau đó in mảng ra màn hình và Sắp xếp mảng theo chiều tăng + in ra màn hình
using System;
using System.Text;
class Mang
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        int[] a = new int[100];
        Random rd = new Random();
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rd.Next(0, 1000);
        }

        Console.WriteLine("CHƯƠNG 1 - Bài 4: Nhập ngẫu nhiên 1000 số tự nhiên, in ra và sắp xếp theo chiều tăng");

        Console.WriteLine("Danh sách 100 số tự nhiên ngẫu nhiên từ 0-1000 là: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }

        //Sắp xếp mảng tăng dần
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] > a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
        //In ra mảng sau sắp xếp
        Console.WriteLine("\n\nMảng sau khi sắp xếp: ");
        for(int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.ReadKey();
    }
}
