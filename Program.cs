using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204014
{

    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hasil Penjumlahan Tiga Angka : " + Penjumlahan.JumlahTigaAngka<float>(20, 40, 14));
        }
    }

    public class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T input1, T input2 , T input3 )
        {
            dynamic x = input1;
            dynamic y = input2;
            dynamic z = input3;

            return x + y + z;
        }
    }

    
}
