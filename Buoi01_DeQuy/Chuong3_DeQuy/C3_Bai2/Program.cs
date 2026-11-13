/*Chương 3 - Bài 2: Tính S(n) = 1^2 + 2^2 + ... + (n-1)^2 + n^2*/

class TinhTongBinhPhuong
{
    static long S(int n)
    {
        //th suy biến
        if (n == 1) return 1;
        //th đệ quy
        return S(n - 1) + (long)n * n;
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 3 - Bài 2: Tính S(n) = 1 + 2^2 + 3^2 + ... + (n-1)^2 + n^2");

        Console.Write("Nhập số nguyên dương n (n>=1): "); int n = int.Parse(Console.ReadLine());
        if (n < 1) Console.WriteLine("Nhập số nguyên dương >=1!");
        else
        {
            long kq = S(n);
            Console.WriteLine($"Tổng S({n}) = {kq}");
        }
        Console.ReadKey();
    }
}
