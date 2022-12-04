internal class Program
{
    private static void Main(string[] args)
    {
        int score = 0;
        string? line = null;
        while ((line = Console.In.ReadLine()) != null)
        {
            string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            score += GetScoreTwo(parts[0], parts[1]);
        }

        Console.WriteLine(score);
    }

    // Rock - A,
    // Paper - B,
    // Scissors - C,
    //
    // Lose - X
    // Draw - Y
    // Win - Z
    public static int GetScoreOne(string opponent, string self)
    {
        return (opponent, self) switch
        {
            ("A", "X") => 1 + 3,
            ("A", "Y") => 2 + 6,
            ("A", "Z") => 3 + 0,

            ("B", "X") => 1 + 0,
            ("B", "Y") => 2 + 3,
            ("B", "Z") => 3 + 6,

            ("C", "X") => 1 + 6,
            ("C", "Y") => 2 + 0,
            ("C", "Z") => 3 + 3,

            _ => throw new ArgumentException("Invalid input"),
        };
    }

    // Rock - A,
    // Paper - B,
    // Scissors - C,
    //
    // Lose - X
    // Draw - Y
    // Win - Z
    public static int GetScoreTwo(string opponent, string self)
    {
        return (opponent, self) switch
        {
            ("A", "X") => 3 + 0,
            ("A", "Y") => 1 + 3,
            ("A", "Z") => 2 + 6,

            ("B", "X") => 1 + 0,
            ("B", "Y") => 2 + 3,
            ("B", "Z") => 3 + 6,

            ("C", "X") => 2 + 0,
            ("C", "Y") => 3 + 3,
            ("C", "Z") => 1 + 6,

            _ => throw new ArgumentException("Invalid input"),
        };
    }
}
