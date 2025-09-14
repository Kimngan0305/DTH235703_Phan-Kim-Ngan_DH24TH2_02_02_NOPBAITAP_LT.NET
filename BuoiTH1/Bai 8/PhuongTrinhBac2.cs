using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    
    public class PhuongTrinhBac2
    {
        // ====== Thuộc tính (field private) ======
        private int soa;
        private int sob;
        private int soc;

        // ====== Property cho hệ số ======
        public int Soa
        {
            get { return soa; }
            set { soa = value; }
        }

        public int Sob
        {
            get { return sob; }
            set { sob = value; }
        }

        public int Soc
        {
            get { return soc; }
            set { soc = value; }
        }

        // ====== Constructor không tham số ======
        public PhuongTrinhBac2()
        {
            soa = 0;
            sob = 0;
            soc = 0;
        }

        // ====== Constructor có 3 tham số ======
        public PhuongTrinhBac2(int a, int b, int c)
        {
            soa = a;
            sob = b;
            soc = c;
        }

        // ====== Phương thức tính nghiệm ======
        public string TinhNghiem()
        {
            if (soa == 0) // Phương trình bậc nhất hoặc vô nghiệm
            {
                if (sob == 0)
                {
                    if (soc == 0)
                    {
                        return "Phuong trinh vo so nghiem.";
                    }
                    else
                    {
                        return "Phuong trinh vo nghiem.";
                    }
                }
                else
                {
                    double x = -(double)soc / sob;
                    return $"Phuong trinh co mot nghiem: x = {x:0.##}";
                }
            }
            else
            {
                double delta = sob * sob - 4 * soa * soc;
                if (delta < 0)
                {
                    return "Phuong trinh vo nghiem.";
                }
                else if (delta == 0)
                {
                    double x = -(double)sob / (2 * soa);
                    return $"Phuong trinh có nghiem kep: x = {x:0.##}";
                }
                else
                {
                    double x1 = (-sob + Math.Sqrt(delta)) / (2 * soa);
                    double x2 = (-sob - Math.Sqrt(delta)) / (2 * soa);
                    return $"Phuong trinh có hai nghiem phan biet: x1 = {x1:0.##}, x2 = {x2:0.##}";
                }
            }
        }

        // ====== Phương thức hiển thị kết quả ======
        public void HienThiKetQua()
        {
            Console.WriteLine($"Phuong trinh: {soa}x^2 + {sob}x + {soc} = 0");
            Console.WriteLine(TinhNghiem());
        }
    }
}

