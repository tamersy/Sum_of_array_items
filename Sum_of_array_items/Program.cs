using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_array_items
{
    class Program
    {
        static void Sum(double[] Arr)
        {
            double Sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            Console.WriteLine(Sum);
        }

        static void Main(string[] args)
        {
            double[] MyArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Sum(MyArray);
            Console.ReadKey();
        }
    }
}
