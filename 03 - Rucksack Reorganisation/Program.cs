namespace Rucksack_Reorganisation;
class Program
{
    static void Main(string[] args)
    {
        var input = File.ReadAllLines("input.txt");

        //input = new string[]
        //{
        //    "vJrwpWtwJgWrhcsFMMfFFhFp",
        //    "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
        //    "PmmdzqPrVvPwwTWBwg",
        //    "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
        //    "ttgJtRGJQctTZtZT",
        //    "CrZsJsPPZsGzwwsLwLmpwMDw"
        //};

        int sum = 0;
        foreach (var l in input)
        {
            int len = l.Length / 2;
            string left = l.Substring(0, len);
            string rite = l.Substring(len);
            string match = "";

            foreach (var ch in left)
            {
                if (rite.Contains(ch))
                    match += ch.ToString();
            }
            if (match[0] <= 'Z')
                sum += match[0] - 'A' + 27;
            else
                sum += match[0] - 'a' + 1;

            //Console.WriteLine($"{l.PadRight(60)} {left.PadRight(30)} {rite.PadRight(30)} {match}");
        }
        Console.WriteLine(sum);

        sum = 0;
        for ( int i = 0; i < input.Length; i += 3)
        {
            string match = "";
            foreach (var ch in input[i])
            {
                if (input[i + 1].Contains(ch) && input[i+2].Contains(ch))
                    match += ch.ToString();
            }
            if (match[0] <= 'Z')
                sum += match[0] - 'A' + 27;
            else
                sum += match[0] - 'a' + 1;

        }
        Console.WriteLine(sum);
    }
}

