//Chương 1 - Bài 1: Nhập ngẫu nhiên 1000 số tự nhiên và lưu nó trong mảng. Sau đó tìm trong mảng SLN, SNN
using System;
using System.Text;
class SoTuNhien { 
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int[] a = new int[1000];
        Random rd = new Random();

        //Nhập ngẫu nhiên 1000 STN vào mảng (Từ 0 -> 100)
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rd.Next(0, 100);
        }

        //Khởi tạo số lớn nhất max và số nhỏ nhất min = phần tử đầu tiên của mỗi mảng
        int max = a[0];
        int min = a[0];

        //Duyệt qua các phần tử còn lại để tìm max, min
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
            }
            if (a[i] < min)
            {
                min = a[i];
            }
        }

        Console.WriteLine("CHƯƠNG 1 - Bài 1: Nhập ngẫu nhiên 1000 số tự nhiên và tìm ra max, min");

        Console.WriteLine("Danh sách 1000 số ngẫu nhiên trong mảng: ");
        for(int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine("\nSố lớn nhất trong mảng là: {0}",max);
        Console.WriteLine("Số nhỏ nhất trong mảng là: {0}",min);

        Console.ReadKey();
    }
}