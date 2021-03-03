using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number greater than 10");

            int array_size = Convert.ToInt32(Console.ReadLine());

            int[] random_numbers = new int[array_size];
            Random rand = new Random();
            int pos_sum = 0;
            int neg_sum = 0;
            int max = random_numbers[0];
            int min = random_numbers[0];
            int index_max = 0;
            int index_min = 0;
            int temp;



            for (int array_value = 0; array_value < array_size; array_value++)
            {
                random_numbers[array_value] = rand.Next(-10, 11);
                Console.Write("{0,-5}", random_numbers[array_value]);

                if (random_numbers[array_value] > 0)
                {
                    pos_sum += random_numbers[array_value];
                }
                if (random_numbers[array_value] < 0)
                {
                    neg_sum += random_numbers[array_value];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Sum of positive numbers is { pos_sum}");
            Console.WriteLine($"Sum of positive numbers is {neg_sum}");

            for (int number = 0; number < random_numbers.Length; number++)
            {
                if (random_numbers[number] > max)
                {
                    max = random_numbers[number];
                    index_max = number;
                }
                if (random_numbers[number] < min)
                {
                    min = random_numbers[number];
                    index_min = number;
                }
            }
            Console.WriteLine($"{max}, { min}");
            Console.WriteLine($"Index of largest element {index_max}");
            Console.WriteLine($"Index of smallest element {index_min}");

            Console.WriteLine();

            foreach (int i in random_numbers)
            {
                temp = random_numbers[index_max];
                random_numbers[index_max] = random_numbers[index_min];
                random_numbers[index_min] = temp;
                Console.Write($"{i}\t");
            }
            Console.WriteLine();

            bool allPositive = false;
            for (int i = 0; i < 3; i++)
            {
                if (random_numbers[i] >= 0)
                {
                    allPositive = true;
                }
                else /*if (random_numbers[i] < 0)*/
                {
                    allPositive = false;
                    break;
                }
            }
            if (allPositive)
            {
                Console.WriteLine("first 3 elements are positive");
            }
            else { Console.WriteLine("some of first 3 elements are negative"); }

            

        }
    }

   
}




