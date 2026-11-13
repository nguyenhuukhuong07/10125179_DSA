//Chương 1 - Bài 3: Đảo ngược chuỗi
class DaoNguoc
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("CHƯƠNG 1 - Bài 3: Đảo ngược chuỗi");

        Console.Write("Nhập chuỗi: "); 
        string chuoiGoc = Console.ReadLine();

        string chuoiNguoc = "";

        for (int i = chuoiGoc.Length - 1; i >= 0; i--)
        {
            chuoiNguoc = chuoiNguoc + chuoiGoc[i];
        }

        Console.WriteLine("Chuỗi sau khi đảo ngược: {0}",chuoiNguoc);
        Console.ReadKey();
    }
}
