using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();

        Running running = new Running(40, 4);
        activitiesList.Add(running);
        Cycling cycling = new Cycling(90, 30);
        activitiesList.Add(cycling);
        Swimming swimming = new Swimming(40, 20);
        activitiesList.Add(swimming);


        //summaries
        foreach (Activity activity in activitiesList)
        {
            activity.DisplaySummary();
        }

    }
}