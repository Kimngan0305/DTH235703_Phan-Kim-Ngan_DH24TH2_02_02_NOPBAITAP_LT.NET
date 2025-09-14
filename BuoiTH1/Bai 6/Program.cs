using Bai6;
using Bai6;
using System;
using System.Text;

namespace Bai6
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Nhập số lượng nhân viên
            Console.Write("Nhập số lượng nhân viên: ");
            int  n = int.Parse(Console.ReadLine());

            // Thiết lập lương cơ bản dùng chung cho tất cả nhân viên
            Console.Write("Nhập lương cơ bản: ");
            double basicSalary = double.Parse(Console.ReadLine());
            NhanVien.SetBasicSalary(basicSalary);

            // Tạo mảng nhân viên
            NhanVien[] nhanViens = new NhanVien[n];
            
            Console.WriteLine("\nNhập thông tin cho từng nhân viên:");
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("\nNhập thông tin nhân viên thứ: " + (i+1));
                nhanViens[i] = new NhanVien();
                nhanViens[i].Input();
            }

            // Hiển thị thông tin nhân viên
            Console.WriteLine("\nDanh sách thông tin nhân viên:");
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("\nThông tin nhân viên thứ: " + (i+1));
                nhanViens[i].Display();
            }

            Console.ReadLine();
        }
    }
}