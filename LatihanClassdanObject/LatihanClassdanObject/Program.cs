using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassdanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat objek dari class mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            //mengedit nilai propertis saya dan kamu
            saya.NIM = "18.11.2308";
            saya.Nama = "Qadrian Pristiadi";
            saya.IPK = 4.00f;

            kamu.NIM = "18.11.3222";
            kamu.Nama = "Agus Wibowo";
            kamu.IPK = 3.98f;

            //mengambil method registrasi dan isis krs
            saya.Registrasi();
            saya.IsiKRS();

            kamu.Registrasi();
            kamu.IsiKRS();
            Console.ReadKey();
        }
    }
}
