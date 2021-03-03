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

            // TASK 1 - find and print the sum of all positive and negative numbers
            int pos_sum = 0;
            int neg_sum = 0;

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

            //TASK 2 - find and print the index of the largest and smallest element
            int max = random_numbers[0];
            int min = random_numbers[0];
            int index_max = 0;
            int index_min = 0;

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

            //TASK 3 - swap elements from step 2
            int temp;

            temp = random_numbers[index_max];
            random_numbers[index_max] = random_numbers[index_min];
            random_numbers[index_min] = temp;

            //TASK 4 - print all array again
            foreach (int i in random_numbers)
            {
                Console.Write($"{i}\t");
            }

            Console.WriteLine();

            //TASK 5 - check if the first 10 elements are positive
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
            else
            {
                Console.WriteLine("some of first 3 elements are negative");
            }

            //TASK 6 - check if the last 10 elements are negative
            int last = random_numbers.Length - 3;
            bool allNegative = false;
            for (int i = last; i < random_numbers.Length; i++)
            {
                if (random_numbers[i] <= 0)
                {
                    allNegative = true;
                }
                else
                {
                    allNegative = false;
                    break;
                }
            }
            if (allNegative)
            {
                Console.WriteLine("last 3 elements are negative");
            }
            else
            {
                Console.WriteLine("some of last 3 elements are positive");
            }

            //TASK 7 - print all odd elements, multiply each element to the previous one (for the first element multiply by 1)


            bool IsEven(int a)
            {
                return (a % 2) == 0;
            }

            var n = 1;

            foreach (int i in random_numbers)
            {
                if (!IsEven(i))
                {
                    Console.Write($"{i}\t");
                    Console.WriteLine();
                    n = i * n;

                    Console.Write($"multiplied to previous {n}\t");
                    n = i;
                }
            }

            Console.WriteLine();
            //TASK 8 - print all even elements, order them by descending

            foreach (int i in random_numbers)
            {
                Array.Sort(random_numbers);

                if (IsEven(i))
                {
                    Console.Write($"{i}\t");
                }
            }

            Console.WriteLine();
            foreach (int i in random_numbers)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();

            //TASK 9 - enter a number, multiply all elements greater than 10 by modulus
            Console.WriteLine("Enter some value:");
            var m = Convert.ToInt32(Console.ReadLine());
            var t = 1;

            foreach (int i in random_numbers)
            {
                if (Math.Abs(i) > Math.Abs(m))
                {
                    Console.Write($"{i * t}\t");
                    t = i * t;
                }
            }

            Console.WriteLine();
            foreach (int i in random_numbers)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();

            // TASK 10 - check if the array contains any zeros
            foreach (int i in random_numbers)
            {
                if (i == 0)
                {
                    Console.WriteLine("Array contains '0'");
                    break;
                }
                   // Console.WriteLine("No '0's in array"); ??????
            }
        }
    }

}




