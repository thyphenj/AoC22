namespace Camp_Cleanup;
class Program
{
    static void Main(string[] args)
    {
        var input = File.ReadAllLines("input.txt");

        //input = new string[]
        //{   "2-4,6-8",
        //    "2-3,4-5",
        //    "5-7,7-9",
        //    "2-8,3-7",
        //    "6-6,4-6",
        //    "2-6,4-8"};

        int part1 = 0;
        int part2 = 0;

        foreach (var line in input)
        {
            var ranges = line.Split(',');
            var one = ranges[0].Split('-');
            var two = ranges[1].Split('-');
            int a = int.Parse(one[0]);
            int b = int.Parse(one[1]);
            int c = int.Parse(two[0]);
            int d = int.Parse(two[1]);

            if (a <= c && b >= d)
                part1++;
            else if (c <= a && d >= b)
                part1++;

            if ((b >= c && d >= a))
                part2++;

        }
        Console.WriteLine(part1);
        Console.WriteLine(part2);
    }
}

