using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Start number:");
            var start_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter End number:");
            var end_num = Convert.ToInt32(Console.ReadLine());

            var tempStart = start_num - 1;

            for (var row = tempStart; row <= end_num; row++)
            {
                for (var col = tempStart; col <= end_num; col++)
                {
                    if (row < start_num && col < start_num)
                    {
                        Console.Write("___");
                        continue;
                    }
                    if (row < start_num)
                    {
                        Console.Write(col);
                        continue;
                    }
                    if (col < start_num)
                    {
                        Console.Write(row);
                        continue;
                    }
                    Console.Write($" {col * row} ");
                }
                Console.WriteLine();
            }

        }

    }
}


