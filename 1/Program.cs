internal class Program
{
    private static void Main(string[] args)
    {
        int max = 0;
        int current = 0;

        string? line = null;

        while ((line = Console.In.ReadLine()) != null)
        {
            if (line == String.Empty)
            {
                max = Math.Max(max, current);
                current = 0;
                continue;
            }

            current += int.Parse(line);
        }

        Console.WriteLine(max);
    }
}
