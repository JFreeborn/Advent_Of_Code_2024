namespace Advent2024.Helpers;

public class GetFileContent
{
    public (List<int>, List<int>) GetListsFromFile()
    {
        const string filePath = "inputs.txt";

        var listOne = new List<int>();
        var listTwo = new List<int>();
        
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

        return (listOne, listTwo);

    }
}