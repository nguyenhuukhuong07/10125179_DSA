using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("========== BUỔI 02: DANH SÁCH ==========");

        Console.WriteLine("\n========== BÀI 1: Mảng số nguyên dương + chèn phần tử x vào vị trí k của dãy ==========");
        Bai1();

        Console.WriteLine("\n========== BÀI 2: Danh sách nhân viên ==========");
        Bai2();

        Console.WriteLine("\n========== BÀI 3: Ma trận vuông n dòng n cột ==========");
        Bai3();

        Console.WriteLine("\n========== BÀI 4: DSLK đơn có pHead chứa địa chỉ nút đầu tiên ==========");
        Bai4();

        Console.WriteLine("\n========== BÀI 5: DSLK đơn, mỗi nút là 1 số nguyên ==========");
        Bai5();
    }

    // ================= CÁC HÀM BÀI TẬP =================
    static void Bai1()
    {
        //a. Nhập n
        Console.Write("Nhập số lượng phần tử n: "); int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = "); a[i] = int.Parse(Console.ReadLine());
        }

        //b. Hiển thị danh sách
        Console.WriteLine("\nDanh sách vừa nhập: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }

        //c. Chèn phần tử x vào vị trí k
        Console.Write("\nNhập phần tử x cần chèn: "); int x = int.Parse(Console.ReadLine());
        Console.Write("Nhập vị trí k cần chèn: "); int k = int.Parse(Console.ReadLine());
        if (k >= 0 && k <= a.Length)
        {
            int[] tmp = new int[a.Length + 1]; //mảng trg gian có số phần tử > mảng cũ 1 ptử để chứa thêm x
            //sao chép các ptử trước vị trí chèn
            for (int i = 0; i < k; i++)
            {
                tmp[i] = a[i];
            }
            //chèn x và sao chép các phần tử còn lại ở sau
            tmp[k] = x;
            for (int i = k; i < a.Length; i++)
            {
                tmp[i + 1] = a[i];
            }
            //gán mảng mới tmp cho mảng a ban đầu
            a = tmp;

            Console.WriteLine("\nDanh sách sau khi chèn: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("Vị trí chèn không hợp lệ");
        }
    }

    struct NhanVien
    {
        public string MaNV;
        public string HoTen;
        public int NamSinh;
        public string Phongban;
        public int LuongCB;
        public int Thuong;
    }

    static void Bai2()
    {
        static int ThucLinh(NhanVien nv)
        {
            return nv.LuongCB + nv.Thuong;
        }

        Console.Write("Nhập số nhân viên n: "); int n = int.Parse(Console.ReadLine());
        NhanVien[] DS = new NhanVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhân viên thứ {i + 1}: ");
            Console.Write("Mã NV: "); DS[i].MaNV = Console.ReadLine();
            Console.Write("Họ tên: "); DS[i].HoTen = Console.ReadLine();
            Console.Write("Năm sinh: "); DS[i].NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Phòng ban: "); DS[i].Phongban = Console.ReadLine();
            Console.Write("Lương cơ bản: "); DS[i].LuongCB = int.Parse(Console.ReadLine());
            Console.Write("Thưởng: "); DS[i].Thuong = int.Parse(Console.ReadLine());
        }

        //a. Tính tổng thực lĩnh tháng của tất cả nv
        long tong = 0;
        for (int i = 0; i < n; i++)
        {
            tong = tong + ThucLinh(DS[i]);
        }
        Console.WriteLine("\na. Tổng thực lĩnh tháng = " + tong);
        //b. Tìm nhân viên có mức lương cơ bản thấp nhất
        int min = DS[0].LuongCB;
        for(int i = 1; i<n; i++)
        {
            if (DS[i].LuongCB < min)
                min = DS[i].LuongCB;
        }
        Console.WriteLine("\nb. Nhân viên có lương cơ bản thấp nhất: ");
        for (int i = 0; i<n;i++)
        {
            if (DS[i].LuongCB == min)
                Console.WriteLine(DS[i].MaNV + " " + DS[i].HoTen);
        }
        //c. Đếm số lượng nv có mức thưởng >= 1.200.000
        int dem = 0;
        for (int i = 0; i < n; i++)
        {
            if (DS[i].Thuong >= 1200000)
                dem++;
        }
        Console.WriteLine("\nc. Số lượng nhân viên có mức thưởng >= 1tr2: " + dem);
        //d. Sắp xếp nhân viên tăng dần theo phòng ban, nếu phòng ban trùng nhau thì giảm dần theo mã nv
        for (int i = 0; i < n-1; i++)
        {
            for(int j = i+1; j<n;j++)
            {
                if (string.Compare(DS[i].Phongban, DS[j].Phongban) > 0 ||
                        (DS[i].Phongban == DS[j].Phongban &&
                        string.Compare(DS[i].MaNV, DS[j].MaNV) < 0))
                {
                    NhanVien tam = DS[i];
                    DS[i] = DS[j];
                    DS[j] = tam;
                }
            }
        }
        Console.WriteLine("\nd. Danh sách sau khi sắp xếp: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(DS[i].MaNV + " " + DS[i].HoTen + " " + DS[i].Phongban);
        }
        //e. Tăng lương các nv lên 5%
        for(int i = 0; i < n; i++)
        {
            DS[i].LuongCB = DS[i].LuongCB + (DS[i].LuongCB * 5 / 100);
        }
        Console.WriteLine("\ne. Danh sách sau khi tăng lương 5%: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(DS[i].MaNV + " " + DS[i].HoTen + " " + DS[i].LuongCB);
        }
    }

    static void Bai3()
    {
        static void NhapMaTran(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void HienThi(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        Console.Write("Nhập cấp ma trận n: "); int n = int.Parse(Console.ReadLine());
        if (n < 1 || n >= 100)
        {
            Console.WriteLine("Cấp ma trận không hợp lệ");
            return;
        }
        int[,] a = new int[n, n];
        NhapMaTran(a, n);
        Console.WriteLine("\nMa trận vừa nhập: ");
        HienThi(a, n);

        //a. Tính tổng các phần tử của ma trận
        int tong = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                tong = tong + a[i, j];
            }
        }
        Console.WriteLine("\na. Tổng các phần tử = "+ tong);

        //b. Tìm giá trị dương nhỏ nhất
        int min = int.MaxValue;
        bool coSoDuong = false;
        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if (a[i, j] > 0 && a[i, j] < min)
                {
                    min = a[i, j];
                    coSoDuong = true;
                }
            }
        }
        if (coSoDuong) Console.WriteLine("\nb. Giá trị dương nhỏ nhất = "+ min);
        else Console.WriteLine("\nb. Ma trận không có giá trị dương");

        //c. Tính tổng các phần tử nằm trên đường chéo phụ
        int tongCheoPhu = 0;
        for (int i = 0; i < n; i++)
        {
            tongCheoPhu = tongCheoPhu + a[i, (n - 1) - i];
        }
        Console.WriteLine("\nc. Tổng đường chéo phụ: " + tongCheoPhu);

        //d. Kiểm tra đg chéo chính có tăng dần không? (góc trên bên trái -> góc dưới bên phải)
        bool tangDan = true;
        for (int i = 0; i < n - 1; i++)
        {
            if (a[i, i] >= a[i+1, i+1])
            {
                tangDan = false;
                break;
            }
        }
        if (tangDan) Console.WriteLine("\nd. Đường chéo chính tăng dần");
        else Console.WriteLine("\nd. Đường chéo chính không tăng dần");
    }

    static void Bai4()
    {
        Console.Write("Nhập số lượng phần tử: ");
        int n = int.Parse(Console.ReadLine());
        int[] pHead = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử nguyên dương thứ {i + 1}: ");
            pHead[i] = int.Parse(Console.ReadLine());
        }

        // In danh sách vừa nhập
        Console.Write("Danh sách vừa nhập: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(pHead[i] + " -> ");
        }
        Console.WriteLine("null");

        // a. Đếm xem trong danh sách có bao nhiêu số bằng x
        Console.Write("Nhập giá trị x cần đếm: ");
        int x = int.Parse(Console.ReadLine());
        int d = 0;
        for (int i = 0; i < n; i++)
        {
            if (pHead[i] == x)
                d++;
        }
        Console.WriteLine($"a. Số lượng phần tử bằng {x} là: {d}");

        // b. Tìm phần tử dương nhỏ nhất trong danh sách
        int minDuong = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            if (pHead[i] > 0 && pHead[i] < minDuong)
                minDuong = pHead[i];
        }
        if (minDuong == int.MaxValue)
            Console.WriteLine("b. Danh sách không có số dương");
        else
            Console.WriteLine($"b. Phần tử dương nhỏ nhất là: {minDuong}");

        // c. Xóa phần tử x xuất hiện đầu tiên trong danh sách[cite: 1]
        Console.Write("Nhập giá trị x cần xóa đầu tiên: ");
        int xXoa = int.Parse(Console.ReadLine());
        int viTri = -1;
        for (int i = 0; i < n; i++)
        {
            if (pHead[i] == xXoa)
            {
                viTri = i;
                break;
            }
        }

        if (viTri != -1)
        {
            for (int i = viTri; i < n - 1; i++)
            {
                pHead[i] = pHead[i + 1];
            }
            n--;

            Console.Write($"c. Danh sách sau khi xóa {xXoa}: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(pHead[i] + " -> ");
            }
            Console.WriteLine("null");
        }
        else
        {
            Console.WriteLine($"c. Không tìm thấy {xXoa} trong danh sách");
        }
    }

    static void Bai5()
    {
        Console.Write("Nhập số lượng phần tử: ");
        int n = int.Parse(Console.ReadLine());
        int[] l = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            l[i] = int.Parse(Console.ReadLine());
        }

        //a. Tìm phần tử lớn nhất danh sách l
        int max = int.MinValue;
        for (int i = 0; i < l.Length; i++)
        {
            if (l[i] > max)
                max = l[i];
        }
        Console.WriteLine($"a. Phần tử lớn nhất là: {max}");

        //b. Tính tổng các phần tử của danh sách l
        int t = 0;
        for (int i = 0; i < l.Length; i++)
        {
            t += l[i];
        }
        Console.WriteLine($"b. Tổng các phần tử là: {t}");

        //c. Đếm xem trong danh sách l có bao nhiêu số nguyên tố
        int demNT = 0;
        for (int i = 0; i < l.Length; i++)
        {
            bool laNT = l[i] >= 2;
            for (int j = 2; j <= Math.Sqrt(l[i]); j++)
            {
                if (l[i] % j == 0)
                {
                    laNT = false;
                    break;
                }
            }
            if (laNT) demNT++;
        }
        Console.WriteLine($"c. Số lượng số nguyên tố là: {demNT}");

        //d. Đếm xem có bao nhiêu số âm, số bằng 0, số dương
        int demAm = 0, demKhong = 0, demDuong = 0;
        for (int i = 0; i < l.Length; i++)
        {
            if (l[i] < 0) demAm++;
            else if (l[i] > 0) demDuong++;
            else demKhong++;
        }
        Console.WriteLine($"d. Số âm: {demAm}, Số bằng 0: {demKhong}, Số dương: {demDuong}");

        //e. Đếm xem trong danh sách có bao nhiêu số bằng x
        Console.Write("Nhập giá trị x cần đếm: ");
        int x = int.Parse(Console.ReadLine());
        int demX = 0;
        for (int i = 0; i < l.Length; i++)
        {
            if (l[i] == x)
                demX++;
        }
        Console.WriteLine($"e. Số lượng phần tử bằng {x} là: {demX}");

        //f. Tìm phần tử dương nhỏ nhất trong danh sách
        int minDuong = int.MaxValue;
        for (int i = 0; i < l.Length; i++)
        {
            if (l[i] > 0 && l[i] < minDuong)
                minDuong = l[i];
        }
        if (minDuong == int.MaxValue)
            Console.WriteLine("f. Danh sách không có số dương");
        else
            Console.WriteLine($"f. Phần tử dương nhỏ nhất là: {minDuong}");
    }
}
