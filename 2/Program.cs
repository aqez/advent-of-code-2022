internal class Program
{
    private static void Main(string[] args)
    {
        List<int> elfCalories = new List<int>();

        int current = 0;
        string? line = null;
        while ((line = Console.In.ReadLine()) != null)
        {
            if (line == String.Empty)
            {
                elfCalories.Add(current);
                current = 0;
                continue;
            }

            current += int.Parse(line);
        }

        int topThreeTotal = elfCalories
            .OrderDescending()
            .Take(3)
            .Aggregate((acc, x) => acc + x);

        Console.WriteLine(topThreeTotal);
    }
}
