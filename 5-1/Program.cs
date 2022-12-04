internal class Program
{
    private static void Main(string[] args)
    {
        int totalDuplicatePairs = 0;

        string? line = null;
        while ((line = Console.In.ReadLine()) != null)
        {
            string[] elves = line.Split(',', StringSplitOptions.RemoveEmptyEntries);

            var (firstStart, firstEnd) = GetRange(elves[0]);
            var (secondStart, secondEnd) = GetRange(elves[1]);

            if (firstStart >= secondStart && firstEnd <= secondEnd)
            {
                totalDuplicatePairs += 1;
            }
            else if (secondStart >= firstStart && secondEnd <= firstEnd)
            {
                totalDuplicatePairs += 1;
            }
        }

        Console.WriteLine(totalDuplicatePairs);
    }

    public static (int start, int end) GetRange(string elf)
    {

        string[] endpoints = elf.Split('-', StringSplitOptions.RemoveEmptyEntries);

        return (int.Parse(endpoints[0]), int.Parse(endpoints[1]));
    }
}
