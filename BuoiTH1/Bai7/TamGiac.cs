using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class TamGiac
    {
        private int Canh1, Canh2, Canh3;
        private float ChuVi;
        private float DienTich;
        private string LoaiTG;

        // Constructor mặc định
        public TamGiac()
        {
            Canh1 = 2;
            Canh2 = 3;
            Canh3 = 5;
        }

        // Constructor có tham số
        public TamGiac(int a, int b, int c)
        {
            Canh1 = a;
            Canh2 = b;
            Canh3 = c;
        }

        // Tính chu vi
        public float TinhChuVi()
        {
            ChuVi = Canh1 + Canh2 + Canh3;
            return ChuVi;
        }

        // Tính diện tích theo công thức Heron
        public float TinhDienTich()
        {
            float p = TinhChuVi() / 2;
            DienTich = (float)Math.Sqrt(p * (p - Canh1) * (p - Canh2) * (p - Canh3));
            return DienTich;
        }

        // Xác định loại tam giác
        public string XacDinhLoai()
        {
            if (Canh1 == Canh2 && Canh2 == Canh3)
                LoaiTG = "Tam giác đều";
            else if (Canh1 == Canh2 || Canh2 == Canh3 || Canh1 == Canh3)
                LoaiTG = "Tam giác cân";
            else if (Canh1 * Canh1 + Canh2 * Canh2 == Canh3 * Canh3 ||
                     Canh1 * Canh1 + Canh3 * Canh3 == Canh2 * Canh2 ||
                     Canh2 * Canh2 + Canh3 * Canh3 == Canh1 * Canh1)
                LoaiTG = "Tam giác vuông";
            else
                LoaiTG = "Tam giác thường";

            return LoaiTG;
        }

        // Hiển thị thông tin
        public void HienThi()
        {
            Console.WriteLine("Cạnh 1: {0}, Cạnh 2: {1}, Cạnh 3: {2}", Canh1, Canh2, Canh3);
            Console.WriteLine("Chu vi: {0}", TinhChuVi());
            Console.WriteLine("Diện tích: {0}", TinhDienTich());
            Console.WriteLine("Loại tam giác: {0}", XacDinhLoai());
        }
    }
}
