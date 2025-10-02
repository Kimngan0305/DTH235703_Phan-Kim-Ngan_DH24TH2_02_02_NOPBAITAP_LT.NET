using Bai7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Nhập 3 cạnh tam giác:");
        Console.Write("Cạnh 1: "); int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cạnh 2: "); int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cạnh 3: "); int c = Convert.ToInt32(Console.ReadLine());

        TamGiac tg = new TamGiac(a, b, c);
        tg.HienThi();

        Console.ReadLine();
    }
}
