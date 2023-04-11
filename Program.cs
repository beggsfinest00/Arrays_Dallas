using System;

namespace Arrays_Dallas
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for a whole number to get an array size
            Console.WriteLine("Enter a whole number for the array size.");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;
            
            //finds the length of the array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a whole number to add to the array.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }
            //finds the sum of the arrays
            Console.WriteLine($"The sum of the array is (sum)");

            //sorts numbers of arrays from least to greatest.
            Array.Sort(numbers);

            Console.WriteLine("Array:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


        }
    }
}
