using Bai8;
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

        Console.WriteLine("Nhập các hệ số a, b, c của phương trình bậc 2:");
        Console.Write("a = "); int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = "); int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c = "); int c = Convert.ToInt32(Console.ReadLine());

        PTBacHai pt = new PTBacHai(a, b, c);

        Console.Write("Phương trình: ");
        pt.HienThi();

        pt.GiaiPT();

        Console.ReadLine();
    }
}
