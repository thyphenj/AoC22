namespace No_Space_Left_On_Device;
class Program
{
    static void Main(string[] args)
    {
        var input = File.ReadAllLines("input.txt");

        string currDirectory = "";
        bool inOS = true;

        int lineno = 0;
        while (lineno < input.Length)
        {
            string curr = input[lineno];
            inOS = (curr[0] == '$');

            if (inOS)
            {
                Console.WriteLine($"{input[lineno]}");

            }
            else
            {
                Console.WriteLine($"    {input[lineno]}");
            }


            lineno++;
        }
    }
}

