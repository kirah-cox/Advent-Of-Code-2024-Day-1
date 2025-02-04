using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class Tools
    {
        public static int FindDifferenceInColumns(int parsedFirstColumn, int parsedSecondColumn)
        {
            return Math.Abs(parsedFirstColumn - parsedSecondColumn);
        }

        public static void GoodbyeMessage(int result)
        {
            Console.WriteLine($"The answer is {result}, nice job!");
        }
    }
}
