using System;

public class Resume
{
    public string _name;

    // Create the list to store the job descriptions
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Jobs:");

        // Use a loop to iterate through each job in the _jobs list
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }


    }
}




