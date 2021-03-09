using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number greater than 10");

            int arraySize = Convert.ToInt32(Console.ReadLine());

            int[] randomNumbers = new int[arraySize];
            Random rand = new Random();

            //// TASK 1 - find and print the sum of all positive and negative numbers

            //int pos_sum = 0;
            //int neg_sum = 0;

            for (int array_index = 0; array_index < arraySize; array_index++)
            {
                randomNumbers[array_index] = rand.Next(-10, 11);
                Console.Write("{0,-5}", randomNumbers[array_index]);

                //if (random_numbers[array_index] > 0)
                //{
                //    pos_sum += random_numbers[array_index];
                //}
                //if (random_numbers[array_index] < 0)
                //{
                //    neg_sum += random_numbers[array_index];
                //}
            }
            //Console.WriteLine($"Sum of positive numbers is { pos_sum}");
            //Console.WriteLine($"Sum of positive numbers is {neg_sum}");

            ////TASK 2 - find and print the index of the largest and smallest element

            //int max = randomNumbers[0];
            //int min = randomNumbers[0];
            //Console.WriteLine($"Index of max value is {maxIndex}, index of min value is {minIndex}");

            //int index_max = 0;
            //int index_min = 0;

            //for (int number = 0; number < randomNumbers.Length; number++)
            //{
            //    if (randomNumbers[number] > max)
            //    {
            //        max = randomNumbers[number];
            //        index_max = number;
            //    }
            //    if (randomNumbers[number] < min)
            //    {
            //        min = randomNumbers[number];
            //        index_min = number;
            //    }
            //}
            //Console.WriteLine($"{max}, { min}");
            //Console.WriteLine($"Index of largest element {index_max}");
            //Console.WriteLine($"Index of smallest element {index_min}");

            //Console.WriteLine();

            ////TASK 3 - swap elements from step 2
            //int temp;

            //temp = randomNumbers[index_max];
            //randomNumbers[index_max] = randomNumbers[index_min];
            //randomNumbers[index_min] = temp;

            ////TASK 4 - print all array again
            //    foreach (int i in randomNumbers)
            //    {
            //        Console.Write($"{i}\t");
            //    }

            //    Console.WriteLine();

            //    //TASK 5 - check if the first 10 elements are positive
            //    bool allPositive = false;
            //    for (int i = 0; i < 3; i++)
            //    {
            //        if (randomNumbers[i] >= 0)
            //        {
            //            allPositive = true;
            //        }
            //        else /*if (random_numbers[i] < 0)*/
            //        {
            //            allPositive = false;
            //            break;
            //        }
            //    }

            //    if (allPositive)
            //    {
            //        Console.WriteLine("first 3 elements are positive");
            //    }
            //    else
            //    {
            //        Console.WriteLine("some of first 3 elements are negative");
            //    }

            //    //TASK 6 - check if the last 10 elements are negative
            //    int last = randomNumbers.Length - 3;
            //    bool allNegative = false;
            //    for (int i = last; i < randomNumbers.Length; i++)
            //    {
            //        if (randomNumbers[i] <= 0)
            //        {
            //            allNegative = true;
            //        }
            //        else
            //        {
            //            allNegative = false;
            //            break;
            //        }
            //    }
            //    if (allNegative)
            //    {
            //        Console.WriteLine("last 3 elements are negative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("some of last 3 elements are positive");
            //    }

            //    //TASK 7 - print all odd elements, multiply each element to the previous one (for the first element multiply by 1)


            //    bool IsEven(int a)
            //    {
            //        return (a % 2) == 0;
            //    }

            //    var n = 1;

            //    foreach (int i in randomNumbers)
            //    {
            //        if (!IsEven(i))
            //        {
            //            Console.Write($"{i}\t");
            //            Console.WriteLine();
            //            n = i * n;

            //            Console.Write($"multiplied to previous {n}\t");
            //            n = i;
            //        }
            //    }

            //    Console.WriteLine();
            //    //TASK 8 - print all even elements, order them by descending

            //    foreach (int i in randomNumbers)
            //    {
            //        Array.Sort(randomNumbers);

            //        if (IsEven(i))
            //        {
            //            Console.Write($"{i}\t");
            //        }
            //    }

            //    Console.WriteLine();
            //    foreach (int i in randomNumbers)
            //    {
            //        Console.Write($"{i}\t");
            //    }
            //    Console.WriteLine();

            //    //TASK 9 - enter a number, multiply all elements greater than 10 by modulus
            //    Console.WriteLine("Enter some value:");
            //    var m = Convert.ToInt32(Console.ReadLine());
            //    var t = 1;

            //    foreach (int i in randomNumbers)
            //    {
            //        if (Math.Abs(i) > Math.Abs(m))
            //        {
            //            Console.Write($"{i * t}\t");
            //            t = i * t;
            //        }
            //    }

            //    Console.WriteLine();
            //    foreach (int i in randomNumbers)
            //    {
            //        Console.Write($"{i}\t");
            //    }
            //    Console.WriteLine();

            //    // TASK 10 - check if the array contains any zeros
            //    //foreach (int i in random_numbers)
            //    //{
            //    //    if (i == 0)
            //    //    {
            //    //        Console.WriteLine("Array contains '0'");
            //    //        break;
            //    //    }
            //    //       // Console.WriteLine("No '0's in array"); ??????
            //    //}

            //    bool isNull (int [] Array)
            //    {
            //        for (int i = 0; i < Array.Length; i++)
            //        {
            //            if (Array[i] == 0)
            //            {
            //                return true; 
            //            }
            //        }
            //        return false;
            //    }

            //    if (isNull(randomNumbers))
            //    {
            //        Console.WriteLine("0 - yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("no");
            //    }


            // TASK 1 - LINQ - find and print the sum of all positive and negative numbers

            var positiveSum = randomNumbers.Where(number => number >= 0).Sum();
            Console.WriteLine($"Sum of positive is {positiveSum}");

            var negativeSum = randomNumbers.Where(number => number < 0).Sum();
            Console.WriteLine($"Sum of negative is {negativeSum}");


            //TASK 2 - LINQ - find and print the index of the largest and smallest element

            var maxValue = randomNumbers.Max();
            Console.WriteLine($"max value is {maxValue}");
            var indexMax = Array.FindIndex(randomNumbers, i => i == maxValue);
            Console.WriteLine($"max index {indexMax}");

            var minValue = randomNumbers.Min();
            Console.WriteLine($"min value is {minValue}");
            var indexMin = Array.FindIndex(randomNumbers, i => i == minValue);
            Console.WriteLine($"min index {indexMin}");

            //TASK 3 - swap elements from step 2
            int temp;

            temp = randomNumbers[indexMax];
            randomNumbers[indexMax] = randomNumbers[indexMin];
            randomNumbers[indexMin] = temp;

            // TASK 4 - print all array again
            foreach (int i in randomNumbers)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();

            //TASK 5 - check if the first 10 elements are positive

            int[] arrayFirst3 = randomNumbers.Take(3).ToArray();
            var allPositive = arrayFirst3.All(num => num > 0);
            Console.WriteLine($"Are first 3 random number positive - {allPositive}");

            //TASK 6 - check if the last 10 elements are negative
            int[] arrayLast3 = randomNumbers.Skip(randomNumbers.Length - 3).ToArray();
            var allNegative = arrayLast3.All(num => num < 0);
            Console.WriteLine($"Are last 3 random number negative - {allNegative}");

            //TASK 7 - print all odd elements, multiply each element to the previous one (for the first element multiply by 1)

            int[] oddArray = randomNumbers.Where(num => num % 2 > 0).ToArray();
            
            int productOfOdd = oddArray.Aggregate((result, item)  => result *= item);
            Console.WriteLine($"Product of odd- {productOfOdd}");
            // ???????????????


            //TASK 8 - print all even elements, order them by descending

            int[] evenArray = randomNumbers.Where(num => num % 2 == 0).ToArray();
            int[] evenSorted = evenArray.OrderByDescending(num => num).ToArray();
            Console.WriteLine($"All even elements are sorted -  ");
            foreach (var num in evenSorted)
            {
                Console.WriteLine(num);
            }

            //TASK 9 - enter a number, multiply all elements, which are greater than entered value by modulus

            Console.WriteLine("Enter some value:");
            var m = Convert.ToInt32(Console.ReadLine());

            int[] greaterModulus = randomNumbers.Where(num => Math.Abs(num) > m).ToArray();
            int product = greaterModulus.Aggregate((result, item) => result *= item);
            Console.WriteLine($"Product of values, which are greater by Modulus than entered value- {product}");

            // TASK 10 - check if the array contains any zeros

            var isZero = randomNumbers.Any(num => num == 0);
            Console.WriteLine($"Array contains zero - {isZero}");
        }

    }

}




