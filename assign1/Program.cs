using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign1
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] arr = { 2,3,4,5,2,3,4,7 };
            toUnique(arr);

          


         }
            public static void toUnique(int[] arr)
             {
            int[] uniqueValues = new int[0];
            
            bool doing = true;

            for (int i = 0; i < arr.Length; ++i)
            {
                doing = false;
                for (int j = 0; j < uniqueValues.Length; ++j)
                {
                    if (uniqueValues[j] == arr[i])
                    {
                        doing = true;
                        break;
                    }
                }
                if (doing == false)
                {
                    Array.Resize(ref uniqueValues, uniqueValues.Length + 1);
                    uniqueValues[uniqueValues.Length - 1] = arr[i];
                }
            }
            
            foreach (var num in uniqueValues)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.ReadKey();

        } 
    }
}
