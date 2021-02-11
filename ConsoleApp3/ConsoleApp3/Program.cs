using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Start number:");
            int start_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter End number:");
            int end_num = Convert.ToInt32(Console.ReadLine());

            for (int header = start_num; header <= end_num; header++)
            {
                Console.WriteLine($"Header is: {header}");

                for (int header2 = start_num; header2 <= end_num; header2++)
                {
                    Console.WriteLine($"{header * header2}");
                }
            }


        }
    }
}
