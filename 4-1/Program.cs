internal class Program
{
    private static void Main(string[] args)
    {
        int totalPriority = 0;

        string? line = null;
        while ((line = Console.In.ReadLine()) != null)
        {
            int compartmentSize = line.Length / 2;

            var first = line.Take(compartmentSize);
            var second = line.Skip(compartmentSize);

            var intersection = first.Intersect(second);

            var thisPriority = intersection.Sum(GetPriority);

            Console.WriteLine($"Intersection of {string.Join("", first)} and {string.Join("", second)}: {string.Join("", intersection)}({thisPriority})");

            totalPriority += thisPriority;
        }

        Console.WriteLine(totalPriority);
    }

    private static int GetPriority(char item)
    {
        if (char.IsLower(item))
        {
            return (int)item - 96;
        }

        return ((int)item - 64) + 26;
    }

}
