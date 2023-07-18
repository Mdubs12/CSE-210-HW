using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("Running", "03 Nov 2022", 30, 3));
        activities.Add(new Bicycle("Bicycling", "04 Nov 2022", 30, 13));
        activities.Add(new Swimming("Swimming", "05 Nov 2022", 30, 15));

        foreach (Activity activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
        }
    }
}