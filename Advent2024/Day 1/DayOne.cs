namespace Advent2024.Day_1;

public class DayOne
{
    /*
    Sample list
        A   B
        -   -
        3   4
        4   3
        2   5
        1   3
        3   9
        3   3
    
    Maybe the lists are only off by a small amount! 
    To find out, pair up the numbers and measure how far apart they are. 
    Pair up the smallest number in the left list with the smallest number in the right list, 
    then the second-smallest left number with the second-smallest right number, and so on.
    
    Within each pair, figure out how far apart the two numbers are; 
    you'll need to add up all of those distances. 
    For example, if you pair up a 3 from the left list with a 7 from the right list, the distance apart is 4; 
    if you pair up a 9 with a 3, the distance apart is 6.
     
    To find the total distance between the left list and the right list, add up the distances between all of the pairs you found. 
    In the example above, this is 2 + 1 + 0 + 1 + 2 + 5, a total distance of 11!
       
    Your actual left and right lists contain many location IDs. What is the total distance between your lists?
     
    */
    
    public static int Run()
    {
        const string filePath = "inputs.txt";

        var listOne = new List<int>();
        var listTwo = new List<int>();
        
        // Read the file line by line
        foreach (var line in File.ReadLines(filePath))
        {
            var parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            
            // we should not get this but for the end of the file if there is a blank line we will keep it.
            if (parts.Length != 2) 
                continue;
       
            var num1 = int.Parse(parts[0]);
            var num2 = int.Parse(parts[1]);
                
            listOne.Add(num1);
            listTwo.Add(num2);
        }

        if (listOne.Count != listTwo.Count)
            throw new InvalidOperationException("Lists have different lengths.");
        
        var sortedListA = listOne.OrderBy(i => i).ToList();
        var sortedListB = listTwo.OrderBy(i => i).ToList();

        return sortedListA.Select((t, i) => Math.Abs(t - sortedListB[i])).Sum();
    }
}