using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Kitchen Prep";
        job1._company = "Saguaro Lake Guest Ranch";
        job1._startYear = 2018;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Delivery Driver";
        job2._company = "The Cottage Flowers and Gifts";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Job job3 = new Job();
        job3._jobTitle = "Delivery Driver";
        job3._company = "Venezia's Pizzeria";
        job3._startYear = 2023;
        job3._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Alex Schick";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}