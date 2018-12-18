using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            for (int y = 0; y < arr.Length; y++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        var tmp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = tmp;
                    }
                }

                Console.WriteLine(string.Join(",", arr));
            }
        }
    }
}
