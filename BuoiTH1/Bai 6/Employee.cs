using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
        internal class NhanVien
        {
            private int id;
            private string name;
            private int yearOfBirth;
            private double salaryLevel;
            private static double basicSalary;

        // Hàm khởi tạo không tham số
            public NhanVien() { }

            // Hàm khởi tạo có tham số
            public NhanVien(int id, string name, int yearOfBirth, double salaryLevel)
            {
                this.id = id;
                this.name = name;
                this.yearOfBirth = yearOfBirth;
                this.salaryLevel = salaryLevel;
            }

            public int GetId()
            {
                return id;
            }

            public string GetName()
            {
                return name;
            }

            public int GetYearOfBirth()
            {
                return yearOfBirth;
            }

            public double GetIncome()
            {
                return salaryLevel * basicSalary;
            }

            public void Input()
            {
                Console.Write("Nhập mã số: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Nhập họ tên: ");
                name = Console.ReadLine();

                Console.Write("Nhập năm sinh: ");
                yearOfBirth = int.Parse(Console.ReadLine());

                Console.Write("Nhập bậc lương: ");
                salaryLevel  = double.Parse(Console.ReadLine());
            }

            public void Display()
            {
                Console.WriteLine("Mã số: " + id);
                Console.WriteLine("Họ tên: " + name);
                Console.WriteLine("Năm sinh: " + yearOfBirth);
                Console.WriteLine("Bậc Lương: " + salaryLevel);
                Console.WriteLine("Lương cơ bản: " + basicSalary);
                Console.WriteLine("Thu nhập: " + GetIncome());
            }

            public void SetSalaryLevel(double Level) 
            {
                salaryLevel = Level;
            }

            public static void SetBasicSalary(double Salary)
            {
                basicSalary = Salary;
            }
        }
}



