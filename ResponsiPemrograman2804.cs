
  
using System;

namespace ResponsiPemrograman2804
{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan karyawan = new Karyawan(1 ,19112683, "paijo", 3000000);
            Karyawan karyawan2 = new Karyawan(2 ,19112683, "jono", 2000000);

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("===========================");
            
            karyawan.showKaryawan();
            ;
            karyawan2.showKaryawan();

            Console.WriteLine("\n\n Kerja Bagus Gaji Naik 10%");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("===========================");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int no { get; set; }
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }

        public Karyawan(int no, int nik, string nama, int gaji)
        {
            this.no = no;
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gajiBulanan = 0;
            }
            else
            {
                this.gajiBulanan = gaji;
            }
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiBulanan);
        }

        public void naikGaji()
        {
            double tmp = 0;
            tmp = 0.1 * gajiBulanan;
            gajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiBulanan);



        }


    }

}

