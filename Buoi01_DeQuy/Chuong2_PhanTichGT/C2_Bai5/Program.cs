/*Chương 2 - Bài 5: Tìm số Fibonacci thứ n bằng */
using System;
using System.Text;

class TimSoFibonacci
{
    static long buocDeQuy = 0;
    static long buocCoNho = 0;

    //giải thuật 1: đệ quy trực tiếp
    static long GT1_tructiep (int n)
    {
        buocDeQuy++;
        if (n <= 1) return n;
        return GT1_tructiep(n - 1) + GT1_tructiep(n - 2);
    }

    //giải thuật 2: vòng lặp (tính từ dưới lên trên)
    static long GT2_Lap(int n, out long buoc)
    {
        buoc = 0;
        if (n <= 1) return n;
        long f0 = 0, f1 = 1, fn = 0;
        for (int i = 2; i <= n; i++)
        {
            buoc++;
            fn = f0 + f1;
            f0 = f1;
            f1 = fn;
        }
        return fn;
    }

    //giải thuật 3: đệ quy có nhớ
    static long GT3_CoNho(int n, long[] memo)
    {
        buocCoNho++;
        if (n <= 1) return n;
        if (memo[n] != -1) return memo[n];
        memo[n] = GT3_CoNho(n - 1, memo) + GT3_CoNho(n - 2, memo);
        return memo[n];
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 2 - Bài 5: Tìm số Fibonacci thứ n (3 giải thuật)");

        Console.Write("Nhập số nguyên n (n>=0): "); int n = int.Parse(Console.ReadLine());

        long kq1 = GT1_tructiep(n);
        Console.WriteLine($"\nGiải thuật 1: Đệ quy trực tiếp");
        Console.WriteLine($"=> F({n}) = {kq1} (Số lần gọi hàm: {buocDeQuy})");

        long kq2 = GT2_Lap(n, out long buocLap);
        Console.WriteLine($"\nGiải thuật 2: Vòng lặp");
        Console.WriteLine($"=> F({n}) = {kq2} (Số lần gọi hàm: {buocLap})");

        long[] memo = new long[n + 1];
        for (int i = 0; i <= n; i++) 
            memo[i] = -1;
        long kq3 = GT3_CoNho(n, memo);
        Console.WriteLine($"\nGiải thuật 3: Đệ quy có nhớ");
        Console.WriteLine($"=> F({n}) = {kq3} (Số lần gọi hàm: {buocCoNho})");

        Console.ReadKey();
    }
}
