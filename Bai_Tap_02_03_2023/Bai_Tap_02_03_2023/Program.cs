using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap_02_03_2023
{
    internal class Program
    {
        struct NhanVien
        {
            private int maNV;
            public int MaNV
            {
                get { return maNV; }
                set { maNV = value; }
            }

            private string hoTenNV;
            public string HoTenNV
            {
                get { return hoTenNV; }
                set { hoTenNV = value; }
            }
            private int luong;
            public int Luong
            {
                get { return luong; }
                set { luong = value; }
            }

            private int thuong;
            public int Thuong
            {
                get { return thuong; }
                set { thuong = value; }
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

        static NhanVien NhapNhanVien()
        {
            NhanVien nhanVien = new NhanVien();
            Console.Write("Mã nhân viên: ");
            nhanVien.MaNV = NhapSoNguyenDuong();
            Console.Write("Tên nhân viên: ");
            nhanVien.HoTenNV = Console.ReadLine();
            Console.Write("Lương: ");
            nhanVien.Luong = NhapSoNguyenDuong();
            Console.Write("Thưởng: ");
            nhanVien.Thuong = NhapSoNguyenDuong();
            return nhanVien;
        }

        static void HienThiNhanVien(NhanVien nhanVien)
        {

            Console.WriteLine("Mã nhân viên: " + nhanVien.MaNV);
            Console.WriteLine("Tên nhân viên: " + nhanVien.HoTenNV);
            Console.WriteLine("Lương: " + nhanVien.Luong);
            Console.WriteLine("Thưởng: " + nhanVien.Thuong);
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<NhanVien> nhanViens = new List<NhanVien>();
            Console.Write("Số nhân viên cần lưu trữ là: ");
            int n = NhapSoNguyenDuong();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thông tin nhân viên thứ " + (i + 1) + " là: ");
                nhanViens.Add(NhapNhanVien());
            }
            Console.WriteLine("Hiển thị danh sách nhân viên:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thông tin nhân viên thứ " + (i + 1) + " là: ");
                HienThiNhanVien(nhanViens[i]);
            }
            Console.WriteLine("Hiển thị thông tin nhân viên có lương cao nhất:");
            int maxLuong = nhanViens[0].Luong;
            for (int i = 1; i < n; i++)
            {
                maxLuong = Math.Max(maxLuong, nhanViens[i].Luong);
            }
            for (int i = 0; i < n; i++)
            {
                if (nhanViens[i].Luong == maxLuong)
                {
                    HienThiNhanVien(nhanViens[i]);
                }
            }
            nhanViens.Sort((nhanVien1, nhanVien2) => nhanVien1.Thuong.CompareTo(nhanVien2.Thuong));
            Console.WriteLine("Hiển thị danh sách nhân viên theo thưởng tăng dần:");
            for (int i = 0; i < n; i++)
            {
                HienThiNhanVien(nhanViens[i]);
            }
            Console.ReadLine();
        }
    }
}
