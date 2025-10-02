using Bai6.Bai6;
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

        // Thiết lập lương cơ bản
        Console.Write("Nhập lương cơ bản: ");
        double luongCB = Convert.ToDouble(Console.ReadLine());
        Employee.SetBasicSalary(luongCB);

        Console.Write("Nhập số nhân viên: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Employee[] ds = new Employee[n];

        // Nhập danh sách nhân viên
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\n--- Nhập thông tin nhân viên {0} ---", i + 1);
            ds[i] = new Employee();
            ds[i].Input();
        }

        // Xuất danh sách nhân viên
        Console.WriteLine("\n--- Danh sách nhân viên ---");
        for (int i = 0; i < n; i++)
        {
            ds[i].Display();
        }

        Console.ReadLine();
    }
}
