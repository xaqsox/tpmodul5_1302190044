using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302190044
{
    class Program
    {

        public class DataGeneric<T>
        {
            public T Data { get; set; }


            public void PrintData()
            {
                Console.WriteLine("Data tersimpan: " + Data);
            }
            public DataGeneric(T data)
            {
                Data = data;
            }
        }

        public class MainClass
        {
            public static void Main()
            {
                DataGeneric<string> data = new DataGeneric<string>("1302190044//aqsa");
                data.PrintData();
            }
        }
    }

}