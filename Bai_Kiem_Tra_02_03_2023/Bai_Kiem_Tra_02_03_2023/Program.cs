using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Kiem_Tra_02_03_2023
{
    internal class Program
    {
        struct Sach
        {
            private int maSach;
            public int MaSach
            {
                get { return maSach; }
                set { maSach = value; }
            }

            private string tenSach;
            public string TenSach
            {
                get { return tenSach; }
                set { tenSach = value; }
            }
            private string tacGia;
            public string TacGia
            {
                get { return tacGia; }
                set { tacGia = value; }
            }

            private int gia;
            public int Gia
            {
                get { return gia; }
                set { gia = value; }
            }

            private int namXB;
            public int NamXB
            {
                get { return namXB; }
                set { namXB = value; }
            }

            private string nhaXB;
            public string NhaXB
            {
                get { return nhaXB; }
                set { nhaXB = value; }
            }
        }

        static int NhapSoNguyenDuong()
        {
            int num = -1;
            do
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num < 1)
                    {
                        Console.Write("Bạn phải nhập số nguyên dương khác 0. Mời bạn nhập lại: ");
                    }
                }
                catch (FormatException e)
                {
                    Console.Write("Bạn phải nhập đúng định dạng số nguyên. Mời bạn nhập lại: ");
                }
            } while (num < 1);

            return num;
        }

        static Sach NhapSach()
        {
            Sach sach = new Sach();
            Console.Write("Mã sách: ");
            sach.MaSach = NhapSoNguyenDuong();
            Console.Write("Tên sách: ");
            sach.TenSach = Console.ReadLine();
            Console.Write("Tác giả: ");
            sach.TacGia = Console.ReadLine();
            Console.Write("Giá: ");
            sach.Gia = NhapSoNguyenDuong();
            Console.Write("Năm xuất bản: ");
            sach.NamXB = NhapSoNguyenDuong();
            Console.Write("Nhà xuất bản: ");
            sach.NhaXB = Console.ReadLine();
            return sach;
        }

        static void HienThiSach(Sach sach)
        {

            Console.WriteLine("Mã sách: " + sach.MaSach);
            Console.WriteLine("Tên sách: " + sach.TenSach);
            Console.WriteLine("Tác giả: " + sach.TacGia);
            Console.WriteLine("Giá: " + sach.Gia);
            Console.WriteLine("Năm xuất bản: " + sach.NamXB);
            Console.WriteLine("Nhà xuất bản: " + sach.NhaXB);
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<Sach> saches = new List<Sach>();
            Console.Write("Số sách cần lưu trữ là: ");
            int n = NhapSoNguyenDuong();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thông tin sách thứ " + (i + 1) + " là: ");
                saches.Add(NhapSach());
            }
            Console.WriteLine("Hiển thị danh sách sách:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thông tin sách thứ " + (i + 1) + " là: ");
                HienThiSach(saches[i]);
            }
            Console.WriteLine("Hiển thị thông tin sách có năm xuất bản cũ nhất:");
            int minNamXB = saches[0].NamXB;
            for (int i = 1; i < n; i++)
            {
                minNamXB = Math.Min(minNamXB, saches[i].NamXB);
            }
            for (int i = 0; i < n; i++)
            {
                if (saches[i].NamXB == minNamXB)
                {
                    Console.WriteLine("Thông tin sách thứ " + (i + 1) + " là: ");
                    HienThiSach(saches[i]);
                }
            }
            saches.Sort((sach1, sach2) => sach2.Gia.CompareTo(sach1.Gia));
            Console.WriteLine("Hiển thị danh sách sách theo giá giảm dần:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thông tin sách thứ " + (i + 1) + " là: ");
                HienThiSach(saches[i]);
            }
            Console.ReadLine();
        }
    }
}
