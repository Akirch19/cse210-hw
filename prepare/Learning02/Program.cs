using System;

class Program
{
    static void Main(string[] args)
    {
    Job job1 = new Job();
    job1._company = "Sprouts";
    job1._jobTitle = "Manager";
    job1._startYear = 2018;
    job1._endYear = 2021;

    Job job2 = new Job();
    job2._company = "Safeway";
    job2._jobTitle = "Manager";
    job2._startYear = 2021;
    job2._endYear = 2023;

    Resume Resume1 = new Resume();
    Resume1._name = "Austin Kirchner";

    Resume1._jobs.Add(job1);
    Resume1._jobs.Add(job2);

    Resume1.Display();

    }
}