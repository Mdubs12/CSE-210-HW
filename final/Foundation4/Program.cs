using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("Running", "10 May 2023", 30, 3));
        activities.Add(new Bicycle("Bicycling", "11 May 2023", 30, 13));
        activities.Add(new Swimming("Swimming", "12 May 2023", 30, 15));

        foreach (Activity activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
        }
    }
}