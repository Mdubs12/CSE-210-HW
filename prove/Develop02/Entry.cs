using System;

public class Entry
{
    public string _currentTime = "";
    public string _entry = ""; 
    public string _prompt = "";
    
    public void written()
    {
        Console.WriteLine($"\nDate: {_currentTime}");
        Console.WriteLine($"questions: {_prompt}");
        Console.WriteLine($"{_entry}");

    }
}