// Programmer: David Flannery
// Due Date: 10/4/2022
// description: delivary 5 Methods 
using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Linq.Expressions;

namespace delivary_5__methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a value between 5 and 15");

            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                if ((value_of_input >= 5) && (value_of_input <= 15))
                {
                    Console.WriteLine("you input:" + MyMethod1(value_of_input));
                      



                }
                else
                {
                    Console.WriteLine("The value typed must be an integer between 5 and 15");
                    Console.WriteLine("Enter any key to exit and try again");
                    Console.ReadKey(true);
                }
                
            }
            catch
            {
                    Console.WriteLine("Please enter an integer number between 5 and 15");
                    Console.WriteLine("Enter any key to exit the proram");
                    Console.ReadKey(true); 
            }

        }
         private static int MyMethod1 (int x)
        {
            Random rnd = new Random();
            int[] numbers = new int[x]; 

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1,101);
            }
            

            Console.WriteLine("The elements of the array are: " );
            
            {
                Console.WriteLine(string.Join (",", numbers ));
            }
            int result = MyMethod2(numbers);
            Console.WriteLine("the sum is = {0}", result);
            return x;
        }
        private static int MyMethod2 (int[] numbers)
        {
            int sum = 0; 
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i]; 
            }
            return sum; 
            
            Console.WriteLine("Sum={0}");
            
        }
    }
}