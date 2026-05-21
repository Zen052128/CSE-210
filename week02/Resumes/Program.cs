using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        Job job2 = new Job();
        job2._jobTitle = "Front-End Developer";
        job2._companyName = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2026;
        
        Resume kentJobs = new Resume();
        kentJobs._name = "Kent Zeniff Depaloma";

        kentJobs._jobs.Add(job1);
        kentJobs._jobs.Add(job2);
        kentJobs.Display();
    }
}