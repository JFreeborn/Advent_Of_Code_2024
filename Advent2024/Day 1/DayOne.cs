namespace Advent2024.Day_1;

public class DayOne
{
    public int RunPartOne(List<int> listOne, List<int> listTwo)
    {
        var sortedListA = listOne.OrderBy(i => i).ToList();
        var sortedListB = listTwo.OrderBy(i => i).ToList();
        
        return sortedListA.Select((t, i) => Math.Abs(t - sortedListB[i])).Sum();
    }
    
    public int RunPartTwo(List<int> listOne, List<int> listTwo)
    {
        if (listOne.Count != listTwo.Count)
            throw new InvalidOperationException("Lists have different lengths.");
        
        var total = listOne.Sum(num => num * listTwo.Count(x => x == num));
        return total;
    }
}