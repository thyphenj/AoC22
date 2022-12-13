namespace CalorieCounting;

class Program
{
    static void Main(string[] args)
    {
        string input = File.ReadAllText("input.txt");
        var groups = input.Split("\n\n");

        var lst = new List<int>();

        int max = 0;
        foreach (var l in groups)
        {
            int sum = 0;
            foreach (var val in l.Split("\n"))
            {
                int result;
                if (int.TryParse(val,out result))
                    sum += result;
            }
            lst.Add(sum);
            if (sum > max)
                max = sum;
        }
        Console.WriteLine($"{max}");

        lst.Sort( );
        int sum2 = 0;
        for ( int i = 0; i < 3; i++)
        {
            sum2 += lst[lst.Count -1- i];
        }
        Console.WriteLine(sum2);
    }
}

