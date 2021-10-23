using System;
using System.Linq;

namespace Homework._4_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = new int[] { 5, 6, 9, 56, 745, 45, 6, 9, 87, 62, 3456, 7890, 12, 34, 5678, 987, 65, 43, 223, 4, 5, 636 };
            int sum = myArray.Sum();
            Console.WriteLine("The Sum  of this Array is : " + sum);
            Console.ReadLine();
                                                   
            foreach (int number in myArray)
            
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number + "   -  Even number! ");
                }
                else
                {
                    Console.WriteLine(number + "   -  Odd number! ");
                }
               
            }
                    Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Bye, have a good day! :) ");
            Console.ReadKey();
        }
            }
        }
    
 