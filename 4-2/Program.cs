internal class Program
{
    private static void Main(string[] args)
    {
        var inventories = new List<char[]>();

        string? line = null;
        while ((line = Console.In.ReadLine()) != null)
        {
            inventories.Add(line.ToArray());
        }

        int priorityTotal = 0;
        for (int i = 0; i < inventories.Count; i += 3)
        {
            var intersection = inventories[i]
                .Intersect(inventories[i + 1])
                .Intersect(inventories[i + 2]);

            priorityTotal += intersection.Sum(GetPriority);
        }

        Console.WriteLine(priorityTotal);
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
