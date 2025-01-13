using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15__Hdt
{
    public class TamGiac
    {
        //thuoc tinh
        private double a;
        private double b;
        private double c;


        // phuong thuc
        public TamGiac()
        {
           
        }
        public void Nhap()
        {
            do
            {
                Console.Write("Nhap canh a: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Nhap canh b: ");
                b = double.Parse(Console.ReadLine());
                Console.Write("Nhap canh c: ");
                c = double.Parse(Console.ReadLine());

                // kiểm tra điều kiện 
                if((a + b <= c) || (a + c <= b) || (b + c <= a))
                {
                    Console.WriteLine("3 canh vua nhap khong phai la 3 canh cua tam giac. Moi nhap lai!");
                }   


            }
            while((a+b <= c) || (a+c <= b) || (b+c<= a));
        }

        // ham tính chu vi  
        public double TinhChuVi()
        {
            return a + b + c;
        }


        // ham tính dien tich   
        public double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
