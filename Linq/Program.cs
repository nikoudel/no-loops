using System;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputData = @"
            4	8	9
            3	0	6
            ";

            Console.WriteLine("sum = {0}", GetSum(inputData));
        }

        static int GetSum(string inputData)
        {
            return inputData
                .Split("\r\n")
                .Where(line => !String.IsNullOrWhiteSpace(line))
                .SelectMany(line => line.Split("\t"))
                .Select(int.Parse)
                .Sum();
        }
    }
}
