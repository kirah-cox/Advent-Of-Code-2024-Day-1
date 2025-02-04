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
    }
}
