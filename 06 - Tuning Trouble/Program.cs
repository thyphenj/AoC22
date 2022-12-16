namespace Tuning_Trouble;
class Program
{
    static void Main()
    {
        var input = File.ReadAllText("input.txt");

        for (int i = 3; i < input.Length; i++)
        {
            if (input[i - 3] != input[i - 2]
                && input[i - 3] != input[i - 1]
                && input[i - 3] != input[i]
                && input[i - 2] != input[i - 1]
                && input[i - 2] != input[i]
                && input[i - 1] != input[i])
            {
                Console.WriteLine($"{i + 1,4}  {input.Substring(i - 3, 4)}");
                break;
            }
        }

        //input = "mjqjpqmgbljsphdztnvjfqwrcgsmlb";
        Console.WriteLine($"\n\n123456789 123456789\n") ;

        int from = 0;

        int pos = RepeatAt(input.Substring(from, 14));
        while ( pos >= 0)
        {
            from += pos+1;
            pos = RepeatAt(input.Substring(from, 14));
        }

        Console.WriteLine(from+14);
    }
    static int RepeatAt ( string str)
    {
        int len = str.Length - 1;
        while ( len > 0)
        {
            string test = str.Substring(0, len);
            char ch = str[len];

            int pos = test.IndexOf(ch);

            Console.WriteLine($"{test} {ch}  {pos}");

            if (pos >= 0)
                return pos;
            len--;
        }
        return -1;
    }
}
