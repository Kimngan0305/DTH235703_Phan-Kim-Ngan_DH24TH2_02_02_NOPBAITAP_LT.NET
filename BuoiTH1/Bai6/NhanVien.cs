using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    namespace Bai6
    {
        class Employee
        {
            private int id;
            private string name;
            private int yearOfBirth;
            private double salaryLevel;
            private static double basicSalary; // dùng chung cho mọi đối tượng

            // Getter
            public int GetId() { return id; }
            public string GetName() { return name; }
            public int GetYearOfBirth() { return yearOfBirth; }
            public double GetSalaryLevel() { return salaryLevel; }
            public static double GetBasicSalary() { return basicSalary; }

            // Setter
            public void SetSalaryLevel(double level) { salaryLevel = level; }
            public static void SetBasicSalary(double salary) { basicSalary = salary; }

            // Thu nhập
            public double GetIncome()
            {
                return salaryLevel * basicSalary;
            }

            // Nhập thông tin nhân viên
            public void Input()
            {
                Console.Write("Nhập ID: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhập họ tên: ");
                name = Console.ReadLine();

                Console.Write("Nhập năm sinh: ");
                yearOfBirth = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhập bậc lương: ");
                salaryLevel = Convert.ToDouble(Console.ReadLine());
            }

            // Hiển thị thông tin nhân viên
            public void Display()
            {
                Console.WriteLine("ID: {0}, Họ tên: {1}, Năm sinh: {2}, Bậc lương: {3}, Lương cơ bản: {4}, Thu nhập: {5}",
                    id, name, yearOfBirth, salaryLevel, basicSalary, GetIncome());
            }
        }
    }
}
