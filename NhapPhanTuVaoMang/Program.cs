using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapPhanTuVaoMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kichthuocmang;
            int[] mang;

            do
            {
                Console.WriteLine("Nhap kich thuoc mang: ");
                kichthuocmang = int.Parse(Console.ReadLine());
                if (kichthuocmang > 10)
                {
                    Console.WriteLine("Kich thuoc mang khong the vuot qua 10 phan tu");
                }
            }
            while (kichthuocmang > 10);

            mang = new int[kichthuocmang];

            int i = 0;
            while (i < mang.Length)
            {
                Console.Write("Nhap gia tri thu " + (i + 1) + " : ");
                mang[i] = Int32.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("Cac gia tri da luu trong mang: ");
            for (int j = 0; j < mang.Length; j++)
            {
                Console.Write(mang[j] + "  ");
            }

            Console.WriteLine();

            int giatrimoi;
            int vitri;

            Console.WriteLine() ;
            Console.WriteLine("Moi nhap gia tri moi can chen: ");
            giatrimoi = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Moi nhap vi tri can chen du lieu moi: ");
            vitri = int.Parse(Console.ReadLine());
          
                if (vitri >= mang.Length -1 || vitri <= 1)
                {
                Console.WriteLine();
                Console.WriteLine("Khong the chen gia tri phan tu vao mang");
                }
                else
            {
                mang[vitri-1] = giatrimoi;
                Console.WriteLine();
                Console.WriteLine("Da chen gia tri {0} vao vi tri {1} trong mang.", giatrimoi, vitri);
              
            }
            
            Console.WriteLine();
            Console.WriteLine("Mang sau khi cap nhat gia tri moi: ");
            
            foreach (int giatri in mang)
            {
                Console.Write(giatri + " ");
            }




            Console.ReadKey();
        }
    }
}
