/*Chương 2 - Bài 6: Sắp xếp dãy n số thực thành 1 dãy tăng dần*/

using System;
using System.Text;

class SapXepDaySo
{
    //Giải thuật 1: Sắp xếp nổi bọt (bubble sort)
    static void BubbleSort(double[] a, out int buoc)
    {
        buoc = 0;
        for (int i = 0; i < a.Length-1; i++)
        {
            for (int j = 0; j < a.Length-1; j++)
            {
                buoc++;
                if (a[j] > a[j + 1])
                {
                    double temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
    }

    //Giải thuật 2: Sắp xếp chọn (selection sort)
    static void SelectionSort(double[] a, out int buoc)
    {
        buoc = 0;
        for (int i = 0; i < a.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < a.Length; j++)
            {
                buoc++;
                if (a[j] < a[minIndex])
                    minIndex = j;
            }
            //đổi chỗ phần tử nhỏ nhất tìm được với phần tử tại i
            if (minIndex != i)
            {
                double temp = a[i];
                a[i] = a[minIndex];
                a[minIndex] = temp;
            }
        }
    }

    //Hàm in mảng
    static void InMang(double[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 2 - Bài 6: Sắp xếp dãy số (2 giải thuật: Bubble sort và Selection sort)");

        Console.Write("Nhập số lượng phần tử n: "); int n = int.Parse(Console.ReadLine());
        double[] mangGoc = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập số thực thứ [{i}]: ");
            mangGoc[i] = double.Parse(Console.ReadLine());
        }

        double[] mang1 = (double[])mangGoc.Clone();
        double[] mang2 = (double[])mangGoc.Clone();

        //chạy bubble sort
        BubbleSort(mang1, out int buoc1);
        Console.WriteLine("\nGiải thuật 1: Nổi bọt (Bubble Sort)");
        Console.Write("Kết quả: ");
        InMang(mang1);
        Console.WriteLine($"=> Số phép so sánh: {buoc1}");

        //chạy selection sort
        SelectionSort(mang2, out int buoc2);
        Console.WriteLine("\nGiải thuật 2: Chọn (Selection Sort)");
        Console.Write("Kết quả: ");
        InMang(mang2);
        Console.WriteLine($"=> Số phép so sánh: {buoc2}");

        Console.ReadKey();
    }
}
