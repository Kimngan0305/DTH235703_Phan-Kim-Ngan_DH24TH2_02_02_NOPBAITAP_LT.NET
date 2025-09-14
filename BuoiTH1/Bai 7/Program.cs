using System;
using System.Text;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Tam giác với tham số mặc định: ");
            TamGiac tg = new TamGiac();
            tg.HienThi();


            // Nhập 3 cạnh từ bàn phím
            Console.WriteLine("\n Nhập thông tin tam giác với tham số mới: ");
            Console.Write("Nhập cạnh 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh 3: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Tam giác với tham số mới: ");
            TamGiac tg1 = new TamGiac(a, b, c);
            tg1.HienThi();

            Console.ReadLine();
        }
    }
}