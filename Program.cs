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


            SimpleDataBase<double> db = new SimpleDataBase<double>();
            db.AddNewData(20);
            db.AddNewData(40);
            db.AddNewData(14);
            db.PrintAllData();
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
