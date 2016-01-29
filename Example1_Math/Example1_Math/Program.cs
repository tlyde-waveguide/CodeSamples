using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Math
{
    class Program
    {
        static void Main()
        {
            // create a string variable with name in it
            string myName = "Terri";
            string keyboardArg1, keyboardArg2, keyboardArg3;

            /* Print out my name */
            Console.WriteLine("Hello {0}", myName);

            // Enter variables
            Console.Write("Enter value 1: ");
            keyboardArg1 = Console.ReadLine();
            Console.Write("Enter value 2: ");
            keyboardArg2 = Console.ReadLine();
            Console.Write("Enter value 3: ");
            keyboardArg3 = Console.ReadLine();

            /// print out the variables
            Console.WriteLine("The entered arguments are: {0}, {1}, {2}", keyboardArg1,
                keyboardArg2, keyboardArg3);

            // Enter more data to do math functions
            int[] intArray1 = new int[6];
            Console.WriteLine("Enter 6 integers: ");
            int counter = 0;
            for (int i=0; i<6; i++)
            {
                counter = counter + 1;
                Console.Write("Enter value {0}:", counter);
                try
                {
                    intArray1[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("That was not an integer.  Setting value to 0: ", ex.Message);
                    intArray1[i] = 0;
                }
            }

            // Calculate sum, average, max value, min value

            // sum, min and max values
            int arraySum = 0;
            int arrayMin = int.MaxValue;
            int arrayMax = 0;
            for (int i=0; i< intArray1.Length; i++)
            {
                arraySum = arraySum + intArray1[i];
                if (intArray1[i] > arrayMax) arrayMax = intArray1[i];
                if (intArray1[i] < arrayMin) arrayMin = intArray1[i];
            }

            // average
            decimal arrayAvg = (decimal)(arraySum / intArray1.Length);

            // print out answers
            Console.WriteLine("The sum of the numbers entered is = {0}", arraySum);
            Console.WriteLine("The average of the numbers entered is = {0}", arrayAvg);
            Console.WriteLine("The min value of the numbers entered is = {0}", arrayMin);
            Console.WriteLine("The max value of the numbers entered is = {0}", arrayMax);
       

        }
    }
}
