using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static int[] numbers = new int[10];
        static int number = 0;
        static int sum = 0;



        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 numbers rach followed by Enter Key");

            for (int i = 0; i < numbers.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Please re-enter a number.");
                };


                numbers[i] = number;
                sum += number;

            }

            //PrintArr(numbers);
            Console.WriteLine("The sum of these numbers is " + sum + ".");
            string ArrList = string.Join(" ", numbers);
            Console.WriteLine($"\n{ArrList}");
            Console.ReadKey();



        }//end Main


        //public static void PrintArr(int[] arr)
        //{
        //    foreach (int j in arr)
        //    {

        //        Console.WriteLine("Numbers you entered are " + j);


        //    }

        //}
    }
}
