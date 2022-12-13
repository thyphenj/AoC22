namespace RockPaperScissors;
class Program
{
    static void Main(string[] args)
    {
        var input = File.ReadAllText("input.txt").Split("\n");
        //input = new string[] { "A Y", "B X", "C Z" };

        //----------------------------------------------------------------------
        // -- Calculate all possible scores

        var part1 = new Dictionary<string, int>();
        var part2 = new Dictionary<string, int>();

        string[] lets = new string[] { "A", "B", "C", "X", "Y", "Z" };

        foreach (var op in new int[] { 1, 2, 3 })
            foreach (var me in new int[] { 1, 2, 3 })
            {
                string str = lets[op - 1] + " " + lets[me + 2];

                int scr = me;
                if (op == me)
                    scr += 3;
                if (op + 1 == me)
                    scr += 6;
                if (op == me + 2)
                    scr += 6;


                int trg = 0;
                if (me == 1)
                {
                    trg = (op == 1 ? 3 : op - 1);
                }
                if (me == 2)
                {
                    trg = 3 + op;
                }
                if (me == 3)
                {
                    trg = 6 + (op == 3 ? 1 : op + 1);
                }

                part1.Add(str, scr);
                part2.Add(str, trg);
            }

        int alpha = 0;
        int beta = 0;
        foreach (var l in input)
        {
            //Console.WriteLine($"{l} => {part1[l]} {part2[l]}");
            alpha += part1[l];
            beta += part2[l];
        }
        Console.WriteLine($"{alpha}   {beta}");

        //----------------------------------------------------------------------


    }
}

