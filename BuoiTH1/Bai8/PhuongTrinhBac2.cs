using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class PTBacHai
    {
        // Thuộc tính
        public int Soa { get; set; }
        public int Sob { get; set; }
        public int Soc { get; set; }

        // Constructor mặc định
        public PTBacHai()
        {
            Soa = 0;
            Sob = 0;
            Soc = 0;
        }

        // Constructor có tham số
        public PTBacHai(int a, int b, int c)
        {
            Soa = a;
            Sob = b;
            Soc = c;
        }

        // Phương thức tính nghiệm
        public void GiaiPT()
        {
            if (Soa == 0) // phương trình bậc nhất hoặc vô nghiệm
            {
                if (Sob == 0)
                {
                    if (Soc == 0)
                        Console.WriteLine("Phương trình có vô số nghiệm.");
                    else
                        Console.WriteLine("Phương trình vô nghiệm.");
                }
                else
                {
                    double x = -(double)Soc / Sob;
                    Console.WriteLine("Phương trình bậc nhất, nghiệm x = {0}", x);
                }
            }
            else
            {
                double delta = Sob * Sob - 4 * Soa * Soc;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double x = -(double)Sob / (2 * Soa);
                    Console.WriteLine("Phương trình có nghiệm kép: x1 = x2 = {0}", x);
                }
                else
                {
                    double x1 = (-Sob + Math.Sqrt(delta)) / (2 * Soa);
                    double x2 = (-Sob - Math.Sqrt(delta)) / (2 * Soa);
                    Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
                    Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
                }
            }
        }

        // Phương thức hiển thị phương trình
        public void HienThi()
        {
            Console.WriteLine("{0}x^2 + {1}x + {2} = 0", Soa, Sob, Soc);
        }
    }

}
