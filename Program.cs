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

            SimpleDataBase<float> db = new SimpleDataBase<float>();
            db.AddNewData(20);
            db.AddNewData(40);
            db.AddNewData(14);
            db.PrintAllData();
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

    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData(T newData)
        {
            this.inputDates.Add(DateTime.Now);
            this.storedData.Add(newData);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < this.inputDates.Count; i++)
            {
                Console.WriteLine("Data " + i + " berisi: " + this.storedData[i] +
                    ", yang disimpan pada waktu UTC: " + this.inputDates[i]);
            }
        }
    }




}
