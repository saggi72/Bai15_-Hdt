using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15__Hdt
{
    class Program
    {
        static void Main(string[] args)
        {
            TamGiac tg = new TamGiac();
            tg.Nhap();
            Console.WriteLine("Chu vi tam giac la: " + tg.TinhChuVi());
            Console.WriteLine("Dien tich tam giac la: " + tg.TinhDienTich());
            Console.ReadKey();
        }
    }
}