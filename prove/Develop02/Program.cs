using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Your journal");
        Journal journaling = new Journal();
        Prompt questions = new Prompt();
        int newNumber = 0;
        while (newNumber != 5)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Please select one of the following options:");
            
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string number = Console.ReadLine();
            newNumber = int.Parse(number);
            switch (newNumber)
            {
                case 1:
                    Entry newEntry = new Entry();
                    string time = DateTime.Now.ToLongTimeString();
                    string date = DateTime.Now.ToShortDateString();
                    newEntry._currentTime = $"{date} - {time}";
                    Random randomness = new Random();
                    int randomNumber = randomness.Next(0,9);
                    newEntry._prompt = questions.ReturnPrompt(randomNumber);
                    Console.WriteLine($"\n{newEntry._prompt}\n");
                    Console.Write("> ");
                    newEntry._entry = Console.ReadLine();
                    Console.WriteLine();
                    journaling._entries.Add(newEntry);
                    break;
                case 2:
                    journaling.Display();
                    break;
                case 3:
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("~");
                        Entry readJournal = new Entry();

                        readJournal._currentTime = parts[0];
                        readJournal._prompt = parts[1];
                        readJournal._entry = parts[2];

                        Console.WriteLine(readJournal._currentTime);
                        Console.WriteLine(readJournal._prompt);
                        Console.WriteLine(readJournal._entry);

                    }
                    break;
                case 4:
                    Console.WriteLine("What is the name of the file?");
                    string fileToRead = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(fileToRead, true))
                    {
                        foreach (Entry writing in journaling._entries)
                        {
                            outputFile.WriteLine($"{writing._currentTime} ~ {writing._prompt} ~ {writing._entry}");
                        }
                    }
                    break;
                case 5:
                    newNumber = 5;
                    break;
                default:
                    Console.WriteLine("Please choose a valid number");
                    break;
            }
        }

    }
}