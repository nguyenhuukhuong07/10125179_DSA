//Chương 1 - Bài 2: Bài toán FizzBuzz
using System;
using System.Text;
class FizzBuzz
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 1 - Bài 2: Chương trình in các số từ 1 -> 100, chia hết cho 3 in Fizz, cho 5 in Buzz, cho cả 3 và 5 in FizzBuzz, còn lại in giá trị số đó");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 5 == 0 && i % 3 == 0) Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0) Console.WriteLine("Fizz");
            else if (i % 5 == 0) Console.WriteLine("Buzz");
            else Console.WriteLine(i);
        }
        Console.ReadKey();
    }
}
