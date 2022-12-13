namespace Supply_Stacks;
class Program
{
    static void Main(string[] args)
    {
        var input = File.ReadAllLines("input.txt");
        //input = new string[]
        //   {
        //        "    [D]",
        //        "[N] [C]",
        //        "[Z] [M] [P]",
        //        " 1   2   3",
        //        "",
        //        "move 1 from 2 to 1",
        //        "move 3 from 1 to 3",
        //        "move 2 from 2 to 1",
        //        "move 1 from 1 to 2"
        //   };

        var stacksOne = new Stack<char>[9];
        var stacksTwo = new Stack<char>[9];

        for (int i = 0; i < 9; i++)
        {
            stacksOne[i] = new Stack<char>();
            stacksTwo[i] = new Stack<char>();
        }
        var stackTmp = new Stack<char>();

        int lineno = 0;
        while (input[lineno].Length > 0)
            lineno++;

        for (int i = lineno - 2; i >= 0; i--)
        {
            for (int j = 0; j < 9; j++)
            {
                if (j * 4 + 1 <= input[i].Length)
                    if (input[i][j * 4 + 1] != ' ')
                    {
                        stacksOne[j].Push(input[i][j * 4 + 1]);
                        stacksTwo[j].Push(input[i][j * 4 + 1]);
                    }
            }
        }

        // -- Part 1 - move single items

        for (int i = lineno + 1; i < input.Length; i++)
        {
            var tokens = input[i].Split(' ');
            for (int j = 0; j < int.Parse(tokens[1]); j++)
            {
                stacksOne[int.Parse(tokens[5]) - 1].Push(stacksOne[int.Parse(tokens[3]) - 1].Pop());
                stackTmp.Push(stacksTwo[int.Parse(tokens[3]) - 1].Pop());
            }
            for (int j = 0; j < int.Parse(tokens[1]); j++)
            {
                stacksTwo[int.Parse(tokens[5]) - 1].Push(stackTmp.Pop());
            }
        }

        string result = "";
        foreach (var stack in stacksOne)
        {
            char ch = ' ';
            if (stack.TryPeek(out ch))
                result += ch;
        }
        Console.WriteLine(result);

         result = "";
        foreach (var stack in stacksTwo)
        {
            char ch = ' ';
            if (stack.TryPeek(out ch))
                result += ch;
        }
        Console.WriteLine(result);
    }
}

