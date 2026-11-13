/*Chương 2 - Bài 2: Tìm kiếm nhị phân*/
using System;
using System.Text;

class BinarySearch
{
    static int buoc = 0; //đếm số lần chia đôi

    static int TimKiemNhiPhan(int[] a, int left, int right, int x)
    {
        //TH cơ sở: mảng không có phần tử nào
        if (left > right) return -1;

        buoc++;
        int betw = left + (right - left) / 2;

        //tìm thấy x ở ngay giữa
        if (a[betw] == x) return betw;
        //nếu x < phần tử giữa -> tìm nửa bên trái (kích thước n/2)
        if (a[betw] > x) 
            return TimKiemNhiPhan(a, left, betw - 1, x);
        //nếu x > phần tử giữa -> tìm nửa bên phải (kích thước n/2)
        return TimKiemNhiPhan(a, betw + 1, right, x);
    }

    //Hàm sắp xếp mảng tăng dần
    static void SapXepTangDan(int[] a)
    {
        int n = a.Length;
        for (int i = 0; i < n-1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (a[i] > a[j]) //số trước > số sau -> Đổi chỗ
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 2 - Bài 2: Tìm kiếm nhị phân (Binary Search)");

        Console.Write("Nhập số lượng phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());

        //cho nhập mảng, mảng phải được sắp xếp từ nhỏ đến lớn
        int[] mang = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ [{i}]: ");
            mang[i] = int.Parse(Console.ReadLine());
        }
        //sắp xếp mảng tăng dần
        SapXepTangDan(mang);
        Console.Write("\nMảng sau khi sắp xếp tăng dần: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(mang[i] + " ");
        }
        //Nhập số cần tìm
        Console.Write("\nNhập giá trị cần tìm: ");
        int canTim = int.Parse(Console.ReadLine());
        int ketQua = TimKiemNhiPhan(mang, 0, mang.Length - 1, canTim);

        if (ketQua != -1) Console.WriteLine($"=> Tìm thấy số {canTim} tại vị trí index = {ketQua}");
        else Console.WriteLine($"=> Không tìm thấy số {canTim} trong mảng");

        Console.WriteLine($"=> Tổng số phép toán chia đôi: {buoc}");
    }
}
