using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates a new object from the class "Job"
        Job job1 = new Job();
        // Sets the variables in the class to values in the new object
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Craig Mortensen";

        // Add the two job histories too the _jobs list in the Resume object instantiated above
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }


}