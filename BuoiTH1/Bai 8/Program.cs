using Bai8;
using System;

class Program
{
    static void Main(string[] args)
    {


        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Nhap c: ");
        int c = int.Parse(Console.ReadLine());

        // Tạo đối tượng và giải phương trình
        PhuongTrinhBac2 pt = new PhuongTrinhBac2(a, b, c);
        pt.HienThiKetQua();

        Console.ReadLine();
    }
}