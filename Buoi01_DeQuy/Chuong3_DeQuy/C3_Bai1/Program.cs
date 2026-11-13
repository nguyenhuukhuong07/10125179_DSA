/*Chương 3 - Bài 1: Tính tổng 1 + 2 + ... + (n-1) + n*/

class TinhTongDeQuy
{
    static int S(int n)
    {
        //th suy biến
        if (n == 1) return 1;
        //th đệ quy
        return S(n - 1) + n;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 3 - Bài 1: Tính S(n) = 1 + 2 + ... + (n-1) + n");
        Console.Write("Nhập số nguyên dương n (n>=1): ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1) Console.WriteLine("Vui lòng nhập số nguyên dương >= 1");
        else
        {
            int kq = S(n);
            Console.WriteLine($"Tổng S({n}) = {kq}");
        }
    }
}
