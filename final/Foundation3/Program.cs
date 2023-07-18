using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        events.Add(new Lecture("Lecture", "Machine Learning Seminar", "Learn about the advances in machine learning.", "July 15th, 2023", "2:00 pm", new Address("789 BYUI St.", "Rexburg", "Idaho", "United States of America"), "Jack Bauer", 250));
        events.Add(new OutdoorGathering("Outdoor Gathering", "Pool Party", "Join us for some fun in the sun!", "July 22nd, 2023", "3:00 pm", new Address("456 Crazy St.", "Rexburg", "Idaho", "United States of America"), "Clear Skies"));
        events.Add(new Reception("Reception", "John and Mary's Wedding", "Celebrate the happy couple", "July 13th", "2:00 pm", new Address("123 Redstone st.", "Detroit", "Michigan", "United States of America"), "john@email.com"));

        foreach (Event evt in events)
        {
            evt.WriteStandardDetails();
            Console.WriteLine();
            evt.WriteFullDetails();
            Console.WriteLine();
            evt.WriteShortDescription();
            Console.WriteLine();
        }
    }
}