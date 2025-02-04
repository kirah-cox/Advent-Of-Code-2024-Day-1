using MyTools;

public class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\kirah.cox\\source\\repos\\kirah-cox\\Advent-Of-Code-2024-Day-1\\Advent Of Code 2024 Day 1\\input.txt";
        List<string> inputList = File.ReadAllLines(filePath).ToList();

        List<string[]> newInputList = new List<string[]>();
        foreach (string input in inputList)
        {
            newInputList.Add(input.Split("   "));
        }
        
        List<string> firstColumn = new List<string>();
        List<string> secondColumn = new List<string>();
        foreach (string[] line in newInputList)
        {
            firstColumn.Add(line[0]);
            secondColumn.Add(line[1]);
        }

        List<int> parsedFirstColumn = new List<int>();
        foreach (string column in firstColumn)
        {
            parsedFirstColumn.Add(int.Parse(column));
        }

        List<int> parsedSecondColumn = new List<int>();
        foreach (string column in secondColumn)
        {
            parsedSecondColumn.Add(int.Parse(column));
        }


        // This code was a part of part 1

        //parsedFirstColumn.Sort();
        //parsedSecondColumn.Sort();

        //List<int> addColumns = new List<int>();
        //int lineNumber = 0;
        //foreach (int column in parsedFirstColumn)
        //{
        //    addColumns.Add(Tools.FindDifferenceInColumns(parsedFirstColumn[lineNumber], parsedSecondColumn[lineNumber]));
        //    lineNumber++;
        //}

        //int result = addColumns.Sum();
        //Console.WriteLine(result);



        // This section was added for part 2
        List<int> similarityList = new List<int>();
        foreach (int line in parsedFirstColumn)
        {
            if (parsedSecondColumn.Contains(line))
            {
                int count = 0;
                foreach (int row in parsedSecondColumn)
                {
                    if(row == line)
                    {
                        count++;
                    }
                }

                for (int i = 0; i < count; i++)
                {
                    similarityList.Add(line);
                }
            }
        }

        int result = similarityList.Sum();
        Tools.GoodbyeMessage(result);
    }
}

