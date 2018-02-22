using System;
using System.Collections.Generic;

namespace loops
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
            var lines = inputData.Split("\r\n");
            var sum = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];

                if (!String.IsNullOrWhiteSpace(line))
                {
                    var columns = line.Split("\t");

                    for (int j = 0; j < columns.Length; j++)
                    {
                        var cell = columns[j];

                        sum += int.Parse(cell);
                    }
                }
            }
            
            return sum;
        }
    }
}
