namespace Advent2024.Day_2;

public class DayTwo
{
    private const string FilePath = "inputs_day_two.txt";
    
    public int RunPartOne()
    {
        var rows = new List<List<int>>();
        foreach (var line in File.ReadLines(FilePath))
        {
            var row = new List<int>();
            foreach (var part in line.Split(' '))
            {
                if (int.TryParse(part, out var number))
                {
                    row.Add(number);
                }
            }
            
            rows.Add(row);
        }

        var safeCount = 0;

        foreach (var row in rows)
        {
            if (IsSafe(row))
            {
                safeCount++;
                continue;
            }
            
            var canBeMadeSafe = row.Select((_, i) => 
                row.Where((_, index) => index != i).ToList())
                .Any(IsSafe);

            if (canBeMadeSafe)
            {
                safeCount++;
            }
        }

        return safeCount;
    }
    
    private bool IsSafe(List<int> row)
    {
        var isDecreasing = true;
        var isIncreasing = true;

        for (var i = 0; i < row.Count - 1; i++)
        {
            var difference = row[i] - row[i + 1];
            switch (difference)
            {
                case <= -4:
                case > 3:
                case 0:
                    return false;
                case > 0:
                    isIncreasing = false;
                    break;
                case < 0:
                    isDecreasing = false;
                    break;
            }

            if (!isIncreasing && !isDecreasing)
                return false; 
        }
        return true;
    }
    
}