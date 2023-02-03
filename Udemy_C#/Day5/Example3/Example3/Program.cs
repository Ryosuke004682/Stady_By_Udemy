using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] array = new int[10];
          
            var random = new Random();

            var sum = 0;
            var average = 0.0;

            var min = 101;
            var max = 0;

            for(var i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);

                Console.Write($"{array[i]} \n");

                sum += array[i];

                if (array[i] < min)
                {
                    min = array[i];
                }

                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            average = sum / (double)array.Length;
            Console.WriteLine($"平均値 : {average} \n 合計値 : {sum} \n 最大 : {max} \n 最小 {min} ");
        }
    }
}
