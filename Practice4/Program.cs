using System;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is Practice 4.");
            
            Activity running = new Activity();
            running.SetActivity("Running", "15 Dec 2022", 40);
            running.SetDistance(2.6);
           
            Activity cycling = new Activity();
            cycling.SetActivity("Cycling", "01 Dec 2022", 60);
            cycling.SetDistance(15);

            Swimming swimming = new Swimming();
            swimming.SetActivity("Swimming", "03 Dec 2022", 20);
            swimming.SetSwimmingLaps (8);

            List<Activity> activity = new List<Activity>();
            activity.Add(running);
            activity.Add(cycling);
            activity.Add(swimming);

            Console.WriteLine("Activities list:");
            foreach (Activity act in activity){
                act.GetSummary();
            }

        }
    }
}
